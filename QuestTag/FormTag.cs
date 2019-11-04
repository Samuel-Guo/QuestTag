using SamuelSpace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestTag
{
    public partial class FormTag : Form
    {
        private MysqlConnector globalDB = GlobalVar.globalDB;
        private Dictionary<string, Db_struct.Tag_group_def> cap_map_tag_group = new Dictionary<string, Db_struct.Tag_group_def>();
        private Dictionary<int, Db_struct.Tag_group_def> id_map_tag_group = new Dictionary<int, Db_struct.Tag_group_def>();
        private Dictionary<string, Db_struct.Tag_def> cap_map_tag = new Dictionary<string, Db_struct.Tag_def>();
        private ListBox selectedBox;
        //   private ArrayList tag_Group_List = new ArrayList();
        public FormTag()
        {
            globalDB = GlobalVar.globalDB;
            InitializeComponent();
        }

        private void TagForm_Load(object sender, EventArgs e)
        {
            loadListBox();

        }

        private void loadListBox()
        {
            cap_map_tag_group.Clear();
            id_map_tag_group.Clear();
            ListBoxTagGroup.Items.Clear();
            listBoxTag.Items.Clear();


            string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";

            var tag_group_list = globalDB.ReadDB<Db_struct.Tag_group_def>(sqlcmd);

            //string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";
            //var tagGroup = globalDB.ExeQuery(sqlcmd);
            foreach (var tag_Group in tag_group_list)
            {
                cap_map_tag_group.Add(tag_Group.caption, tag_Group);
                id_map_tag_group.Add(tag_Group.id, tag_Group);

                //      tagMap.Add(id, group_tag_name);
                ListBoxTagGroup.Items.Add(tag_Group.caption);

            }
            //while (tagGroup.Read())
            //{
            //    Db_struct.Tag_group_def tag_Group = new QuestTag.Db_struct.Tag_group_def
            //    {
            //        id = Convert.ToInt32(tagGroup.GetString(0)),
            //        caption = tagGroup.GetString(1),
            //        unique = Convert.ToInt32(tagGroup.GetString(2))
            //    };
            //    tag_Group.unique = Convert.ToInt32(tagGroup.GetString(3));

            //    cap_map_tag_group.Add(tag_Group.caption, tag_Group);
            //    id_map_tag_group.Add(tag_Group.id, tag_Group);
                
            //    //      tagMap.Add(id, group_tag_name);
            //    ListBoxTagGroup.Items.Add(tag_Group.caption);
            //    // ListBoxTagGroup.
            //}
        }

        private Db_struct.Tag_group_def Db_struct(int id, string caption, int unique)
        {
            throw new NotImplementedException();
        }

        private void ListBoxTagGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTag.Items.Clear();
            if (ListBoxTagGroup.SelectedItem == null) return;
            string tagGroupName = ListBoxTagGroup.SelectedItem.ToString();
            

           int group_id = cap_map_tag_group[tagGroupName].id;
            string sqlcmd = string.Format("SELECT * FROM edu.tag_def where is_valid = 1 and group_id ={0} ;", group_id);
            var tags = globalDB.ExeQuery(sqlcmd);
            while (tags.Read())
            {
                Db_struct.Tag_def tag = new Db_struct.Tag_def();
                tag.id = Convert.ToInt32(tags.GetString(0));
                tag.caption = tags.GetString(1);
                if (!cap_map_tag.ContainsKey(tag.caption))
                    cap_map_tag.Add(tag.caption,tag);
                listBoxTag.Items.Add(tag.caption);
                // ListBoxTagGroup.
            }

        }

        private void MenuModfiy_Click(object sender, EventArgs e)
        {
            FormTagAdd formOpt;
            string selectText = selectedBox.SelectedItem.ToString();
            if (selectedBox.Tag.ToString() == "Group")
            {
               
                formOpt = new FormTagAdd("修改标签组", true, selectText, cap_map_tag_group[selectText].unique == 0 ? false : true);
                if (formOpt.ShowDialog() == DialogResult.OK)
                {
                    string newTagGroup = formOpt.textString;
                    int isUnique = formOpt.isChecked ? 1 : 0;

                    string sqlcmd = string.Format("UPDATE tag_group_def set caption='{0}' , is_unique = {1} where id = {2} ;", newTagGroup, isUnique , cap_map_tag_group[selectText].id);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("update fail!");
                    loadListBox();
                }
            }
            else
            {
                formOpt = new FormTagAdd("修改标签", false, selectText);
                if (formOpt.ShowDialog() == DialogResult.OK)
                {
                    int seletIdx = ListBoxTagGroup.SelectedIndex;
                    int tagId = cap_map_tag[selectText].id;
                    string newTag = formOpt.textString;
                    string tagGroupName = ListBoxTagGroup.SelectedItem.ToString();
                    int group_id = cap_map_tag_group[tagGroupName].id; //TODO::
                    string sqlcmd = string.Format("UPDATE tag_def set caption='{0}' , group_id = {1} where id = {2} ;", newTag, group_id, tagId);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("update fail!");
                    loadListBox();
                    ListBoxTagGroup.SelectedIndex = seletIdx;
                }

            }
            formOpt.Close();
            GlobalVar.UpdateDBList();
        }

        private void ListBoxTagGroup_MouseUp(object sender, MouseEventArgs e)
        {
            PopMenu(sender,e);
        }

        private void PopMenu(object ClickSrc,MouseEventArgs e)
        {
            selectedBox = (ListBox)ClickSrc;
            if (e.Button == MouseButtons.Right)
            {
                int currentIndex = e.Y / 12;
                if (selectedBox.SelectedItem != null && currentIndex != selectedBox.SelectedIndex)
                {
                    selectedBox.SetSelected(selectedBox.SelectedIndex, false);
                }
                if (currentIndex < selectedBox.Items.Count)
                {
                    selectedBox.SetSelected(currentIndex, true);
                    MenuAdd.Visible = false;
                    MenuModify.Visible = true;
                    MenuDel.Visible = true;
                }
                else
                {
                    MenuAdd.Visible = true;
                    MenuModify.Visible = false;
                    MenuDel.Visible = false;

                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);

            }
        }

        private void MenuAdd_Click(object sender, EventArgs e)
        {
            FormTagAdd formOpt;
            if (selectedBox.Tag.ToString() == "Group")
            {
                formOpt = new FormTagAdd("增添标签组", true);
                if (formOpt.ShowDialog() == DialogResult.OK)
                {
                    string newTagGroup = formOpt.textString;
                    int isUnique = formOpt.isChecked ? 1 : 0;

                    string sqlcmd = string.Format("INSERT INTO tag_group_def (`caption`, `is_unique`) VALUES ('{0}', {1} );", newTagGroup, isUnique);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("insert fail!");
                    loadListBox();
                }
            }
            else
            {
                formOpt = new FormTagAdd("增添标签", false);
                if (formOpt.ShowDialog() == DialogResult.OK)
                {
                    int seletIdx = ListBoxTagGroup.SelectedIndex;
                    string newTag = formOpt.textString;
                    string tagGroupName = ListBoxTagGroup.SelectedItem.ToString();
                    int group_id = cap_map_tag_group[tagGroupName].id;
                    string sqlcmd = string.Format("INSERT INTO tag_def (`caption`, `group_id`) VALUES ('{0}', {1} );", newTag, group_id);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("insert fail!");
                    loadListBox();
                    ListBoxTagGroup.SelectedIndex = seletIdx;
                }

            }
            formOpt.Close();

        }

        private void listBoxTag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxTag_MouseUp(object sender, MouseEventArgs e)
        {
            PopMenu(sender,e);
        }

        private void MenuDel_Click(object sender, EventArgs e)
        {
            string selectText = selectedBox.SelectedItem.ToString();
            if (selectedBox.Tag.ToString() == "Group")
            {
                var confirm = MessageBox.Show("确定删除标签组"+ selectText +"吗？此操作将删除标签组下面所有标签。","确认删除",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string sqlcmd = string.Format("UPDATE tag_group_def set is_valid= 0 where id = {0} ;", cap_map_tag_group[selectText].id);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("update fail!");
                    loadListBox();
                }
            }
            else
            {
                var confirm = MessageBox.Show("确定删除标签" + selectText + "吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int tagId = cap_map_tag[selectText].id;
                    int seletIdx = ListBoxTagGroup.SelectedIndex;

                    string sqlcmd = string.Format("UPDATE tag_def set is_valid= 0 where id = {0} ;", tagId);
                    if (globalDB.ExeUpdate(sqlcmd) == 0)
                        MessageBox.Show("update fail!");
                    loadListBox();
                    ListBoxTagGroup.SelectedIndex = seletIdx;

                }


            }
            GlobalVar.UpdateDBList();

        }
    }
}
