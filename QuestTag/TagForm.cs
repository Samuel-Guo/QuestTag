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
    public partial class TagForm : Form
    {
        private MysqlConnector globalDB = GlobalVar.globalDB;
        private Dictionary<string, int> cap_id_map = new Dictionary<string, int>();
        private Dictionary<int, string> id_cap_map = new Dictionary<int, string>();

        //   private ArrayList tag_Group_List = new ArrayList();
        public TagForm()
        {
            InitializeComponent();
        }

        private void TagForm_Load(object sender, EventArgs e)
        {
            loadListBox();

        }

        private void loadListBox()
        {
            cap_id_map.Clear();
            id_cap_map.Clear();
            ListBoxTagGroup.Items.Clear();
            listBoxTag.Items.Clear();
            string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";
            var tagGroup = globalDB.ExeQuery(sqlcmd);
            while (tagGroup.Read())
            {

                var id = Convert.ToInt32(tagGroup.GetString(0));
                var caption = tagGroup.GetString(1);
                var unique = Convert.ToInt32(tagGroup.GetString(2));
                cap_id_map.Add(caption, id);
                id_cap_map.Add(id, caption);

                //      tagMap.Add(id, group_tag_name);
                ListBoxTagGroup.Items.Add(caption);
                // ListBoxTagGroup.
            }
        }

        private void ListBoxTagGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTag.Items.Clear();
            if (ListBoxTagGroup.SelectedItem == null) return;
            string tagGroupName = ListBoxTagGroup.SelectedItem.ToString();
            int group_id = cap_id_map[tagGroupName];
            string sqlcmd = string.Format("SELECT * FROM edu.tag_def where is_valid = 1 and group_id ={0} ;", group_id);
            var tags = globalDB.ExeQuery(sqlcmd);
            while (tags.Read())
            {

                var id = Convert.ToInt32(tags.GetString(0));
                var caption = tags.GetString(1);
                listBoxTag.Items.Add(caption);
                // ListBoxTagGroup.
            }


        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxTagGroup_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentIndex = e.Y / 12;
                if (ListBoxTagGroup.SelectedItem != null && currentIndex != ListBoxTagGroup.SelectedIndex)
                {
                    this.ListBoxTagGroup.SetSelected(ListBoxTagGroup.SelectedIndex, false);
                }
                if(currentIndex< ListBoxTagGroup.Items.Count  )
                {
                    this.ListBoxTagGroup.SetSelected(currentIndex, true);
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
            FormOpt formOpt = new FormOpt("增添标签组",true);
            if (formOpt.ShowDialog() == DialogResult.OK)
            {
                string newTagGroup = formOpt.textString;
                int isUnique = formOpt.isChecked ? 1:0;

                string sqlcmd = string.Format("INSERT INTO tag_group_def (`caption`, `is_unique`) VALUES ('{0}', {1} );", newTagGroup, isUnique);
                if(globalDB.ExeUpdate(sqlcmd) == 0)
                    MessageBox.Show("insert fail!");
                loadListBox();

            }
        }
    }
}
