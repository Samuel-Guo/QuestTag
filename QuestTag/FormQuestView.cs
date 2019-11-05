using SamuelSpace;
using System;
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
    public partial class FormQuestView : Form
    {
        Dictionary<int, int> listId_id_map = new Dictionary<int, int>();
        Dictionary<int, Db_struct.Quest_def> quests_map = new Dictionary<int, Db_struct.Quest_def>();
        Dictionary<int, Db_struct.Tag_def> tag_map = new Dictionary<int, Db_struct.Tag_def>();
        private ListBox selectedBox;
        private MysqlConnector globalDB = GlobalVar.globalDB;
        FormQuestAdd formAdd;

        public FormQuestView()
        {
            InitializeComponent();
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            LoadListBox();

        }

        private void LoadListBox()
        {
            int i = 0;
            listQuest.Items.Clear();
            listId_id_map.Clear();
            quests_map.Clear();

            string sqlcmd = "SELECT * FROM quest_def where is_valid=1;";
            var quests = GlobalVar.globalDB.ReadDB<Db_struct.Quest_def>(sqlcmd);
            foreach (var quest in quests)
            {
                listId_id_map.Add(i++, quest.id);
                listQuest.Items.Add(quest.caption);
                quests_map.Add(quest.id, quest);
            }

            tag_map.Clear();
            string getTagSql = "SELECT" + Db_struct.tag_def_field +
                 "from tag_def where is_valid =1; ";
            var tagList = GlobalVar.globalDB.ReadDB<Db_struct.Tag_def>(getTagSql);
            foreach (var tag in tagList)
            {
                tag_map.Add(tag.id, tag);
            }
        }

        private void listQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listQuest.
            //string sqlcmd = "SELECT file_path from quest_def where id =" + listId_id_map[listQuest.SelectedIndex].ToString();
            //var path = GlobalVar.globalDB.ReadDB<String>(sqlcmd)[0];
            listTags.Items.Clear();
            if (listQuest.SelectedIndex == -1) return;
            var selectQuest = quests_map[listId_id_map[listQuest.SelectedIndex]];
            var questId = selectQuest.id;
            string sqlcmd = "SELECT caption from quest_tag_map " +
                "inner join tag_def on quest_tag_map.tag_id = tag_def.id " +
                "where quest_tag_map.is_valid =1 and " +
                "quest_id =" + listId_id_map[listQuest.SelectedIndex].ToString()
                + " order by group_id;";

            var tagsCap = GlobalVar.globalDB.ReadDB<string>(sqlcmd);
            //   listTags.Items.AddRange(tagsCap);
            foreach (var tagId in tagsCap)
            {
                listTags.Items.Add(tagId);
            }
            label1.Text = selectQuest.file_path;
            //textBoxPath.Text = selectQuest.file_path;
            label2.Text = selectQuest.detail;
            //textBox1.Text = selectQuest.detail;
            try
            {
                pictureBox1.Load(selectQuest.file_path);

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void listQuest_MouseUp(object sender, MouseEventArgs e)
        {
            PopMenu(sender, e);
        }

        private void PopMenu(object ClickSrc, MouseEventArgs e)
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
                MenuPop.Show(Cursor.Position.X, Cursor.Position.Y);

            }
        }
        
        private void MenuAdd_Click(object sender, EventArgs e)
        {
            if (selectedBox.Tag.ToString() == "Quest")
            {
                string getkeysql = "analyze table quest_def; ";
                globalDB.ExeQuery(getkeysql);
                getkeysql = "SELECT `AUTO_INCREMENT` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`= 'edu' AND`TABLE_NAME`= 'quest_def';";
                int newKeyIdx = globalDB.ReadDB<int>(getkeysql)[0];

                formAdd = new FormQuestAdd("增加问题");
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    string questName = formAdd.QuestName;
                    string questDetail = formAdd.QuestDetail;
                    string questPath = formAdd.QuestPath;
                    //    int isUnique = formAdd.isChecked ? 1 : 0;

                    string sqlcmd = string.Format("INSERT INTO quest_def (`caption`,`detail`,`file_path`) VALUES ('{0}','{1}','{2}' );", questName,questDetail,questPath);
                    //sqlcmd =sqlcmd.Replace("\\", "\\\\");
                    if (globalDB.ExeUpdate(sqlcmd.Replace("\\", "\\\\")) == 0)
                        MessageBox.Show("insert fail!");

                    foreach (var item in formAdd.listId_selectTagId_map)
                    {
                        string tagsql = string.Format( "INSERT INTO quest_tag_map (`quest_id`, `tag_id`) VALUES ({0}, {1});",newKeyIdx,item.Value);
                        if (globalDB.ExeUpdate(tagsql) == 0)
                            MessageBox.Show("insert fail!");

                    }


                    LoadListBox();
                    formAdd.Close();

                }
            }
            //else
            //{
            //    formOpt = new FormTagAdd("增添标签", false);
            //    if (formOpt.ShowDialog() == DialogResult.OK)
            //    {
            //        int tagSeletIdx = listTags.SelectedIndex;
            //        string newTag = formOpt.textString;
            //        string questName = listQuest.SelectedItem.ToString();
            //        int questId = listId_id_map[tagSeletIdx];

            //      //  int group_id = cap_map_tag_group[questName].id;
            //        //string sqlcmd = string.Format("INSERT INTO tag_def (`caption`, `group_id`) VALUES ('{0}', {1} );", newTag, group_id);
            //        //if (globalDB.ExeUpdate(sqlcmd) == 0)
            //          //  MessageBox.Show("insert fail!");
            //       // LoadListBox();
            //       // ListBoxTagGroup.SelectedIndex = tagSeletIdx;
            //    }

            //}


        }

        private void MenuModify_Click(object sender, EventArgs e)
        {
            if (selectedBox.Tag.ToString() == "Quest")
            {
                formAdd = new FormQuestAdd("编辑问题",listId_id_map[ selectedBox.SelectedIndex]);
                if (formAdd.ShowDialog() == DialogResult.OK)
                {
                    string questName = formAdd.QuestName;
                    string questDetail = formAdd.QuestDetail;
                    string questPath = formAdd.QuestPath;
                    //    int isUnique = formAdd.isChecked ? 1 : 0;
                    string getkeysql = "analyze table tag_group_def; ";
                    globalDB.ExeQuery(getkeysql);
                    getkeysql = "SELECT `AUTO_INCREMENT` FROM `information_schema`.`TABLES` WHERE `TABLE_SCHEMA`= 'edu' AND`TABLE_NAME`= 'quest_def';";
                    int newKeyIdx = globalDB.ReadDB<int>(getkeysql)[0];

                    string sqlcmd = string.Format("INSERT INTO quest_def (`caption`,`detail`,`file_path`) VALUES ('{0}','{1}','{2}' );", questName, questDetail, questPath);
                    //sqlcmd =sqlcmd.Replace("\\", "\\\\");
                    if (globalDB.ExeUpdate(sqlcmd.Replace("\\", "\\\\")) == 0)
                        MessageBox.Show("insert fail!");

                    foreach (var item in formAdd.listId_selectTagId_map)
                    {
                        string tagsql = string.Format("INSERT INTO quest_tag_map (`quest_id`, `tag_id`) VALUES ({0}, {1});", newKeyIdx, item.Value);
                        if (globalDB.ExeUpdate(tagsql) == 0)
                            MessageBox.Show("insert fail!");

                    }

                    LoadListBox();
                }
                formAdd.Close();

            }

        }

        private void MenuDel_Click(object sender, EventArgs e)
        {
            int questId = listId_id_map[listQuest.SelectedIndex];
           var con= MessageBox.Show("确认要删除吗？","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if(con==DialogResult.Yes)
           {
                string sqlcmd = string.Format("UPDATE quest_def set is_valid= 0 where id = {0} ;", questId);
                if (globalDB.ExeUpdate(sqlcmd) == 0)
                    MessageBox.Show("update fail!");
           }
            LoadListBox();

        }
    }
}
