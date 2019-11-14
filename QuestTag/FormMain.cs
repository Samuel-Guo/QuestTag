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
    public partial class FormMain : Form
    {
        private MysqlConnector globalDB = GlobalVar.globalDB;
        private Dictionary<int, int> listId_tagId_map = new Dictionary<int, int>();
        private Dictionary<int, Db_struct.Quest_def> quests_map = new Dictionary<int, Db_struct.Quest_def>();
        FormQuestView questForm;
        FormTag tagForm ;
        List<SortedSet<int>> tagGroupQuest = new List<SortedSet<int>>();
        Dictionary<int, SortedSet<int>> tagId_quests_map = new Dictionary<int, SortedSet<int>>();
        Dictionary<int, HashSet<int>> tagGroupId_tags_map = new Dictionary<int, HashSet<int>>();
        Dictionary<int, int> selectlistId_quest_map = new Dictionary<int, int>();

        public FormMain()
        {
            

            InitDBconf();

            InitializeComponent();
            globalDB = GlobalVar.globalDB;
            //    GlobalVar.UpdateDBList();
            questForm = new FormQuestView();
            tagForm = new FormTag();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Visible = false;
            //WindowState = FormWindowState.Minimized;
            // Size = new Size(1050, 550);
            var size = Properties.Settings.Default.MainWndSize;
            Size = size;
            UpdateTagsList();
            SetAnswerVisible();

        }

        private void UpdateTagsList()
        {
            ListTags.Items.Clear();
            listId_tagId_map.Clear();

            string sqlcmd = "SELECT * FROM tag_def where is_valid = 1  ORDER BY group_id; ";

            var tag_list = globalDB.ReadDB<Db_struct.Tag_def>(sqlcmd);

            foreach (var tags in tag_list)
            {
                int addIndex = ListTags.Items.Add(tags.caption);
                listId_tagId_map.Add(addIndex, tags.id);
                string tagsql = "SELECT quest_id FROM quest_tag_map where is_valid = 1 and tag_id =  " + tags.id + " ;";
                var questIds = globalDB.ReadDB<int>(tagsql);
                SortedSet<int> questSet = new SortedSet<int>(questIds);
                tagId_quests_map[tags.id] = questSet;
                //cap_map_tag_group.Add(tag_Group.caption, tag_Group);
                //id_map_tag_group.Add(tag_Group.id, tag_Group);

                ////      tagMap.Add(id, group_tag_name);
                //ListBoxTagGroup.Items.Add(tag_Group.caption);

            }
        }

        private static void InitDBconf()
        {
            GlobalVar.globalDB = new MysqlConnector();
          
            GlobalVar.globalDB.SetServer(Properties.Settings.Default.DbIP)
           .SetDataBase(Properties.Settings.Default.DbName)
           .SetUserID(Properties.Settings.Default.DbUser)
           .SetPassword(Properties.Settings.Default.DbPwd)
           .SetPort(Properties.Settings.Default.DbPort)
           .SetCharset(Properties.Settings.Default.DbCharSet);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuQuest_Click(object sender, EventArgs e)
        {
            if(questForm.IsDisposed)
            {
                questForm = new FormQuestView();
            }
            questForm.Show();
            questForm.Activate();

        }

        private void MenuTag_Click(object sender, EventArgs e)
        {
            if (tagForm.IsDisposed)
            {
                tagForm = new FormTag();
            }
            tagForm.Show();
            tagForm.Activate();

        }

        private void ListQuests_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string getgroupsql = "SELECT group_id FROM edu.tag_def where is_valid = 1; ";
            var groupIds = globalDB.ReadDB<int>(getgroupsql);
            foreach (var groupId in groupIds)
            {
                string tagsql = "SELECT id FROM tag_def where is_valid = 1 and group_id =  " + groupId + " ;";
                var tagIds = globalDB.ReadDB<int>(tagsql);
                HashSet<int> tagSet = new HashSet<int>(tagIds);

                tagGroupId_tags_map[groupId] = tagSet;
                //TODO:
            }
            HashSet<int> selectTagIds = new HashSet<int>();
            var selectQuestIndex = ListTags.CheckedIndices;
            foreach (int item in selectQuestIndex)
            {
                selectTagIds.Add(listId_tagId_map[item]);
            }
            if (e.NewValue == CheckState.Checked)
                selectTagIds.Add(listId_tagId_map[e.Index]);
            else
                selectTagIds.Remove(listId_tagId_map[e.Index]);


            SortedSet<int> allQuestSet = new SortedSet<int>();

            string sqlcmd = "SELECT * FROM quest_def where is_valid=1;";
            var quests = GlobalVar.globalDB.ReadDB<Db_struct.Quest_def>(sqlcmd);
            quests_map.Clear();
            foreach (var quest in quests)
            {
                quests_map.Add(quest.id, quest);
                allQuestSet.Add(quest.id);
            }


            //  List<SortedSet<int>> selectQuestId = new List<SortedSet<int>>();

            foreach (var it_group in tagGroupId_tags_map)
            {
                SortedSet<int> singleGroupQuestSet = new SortedSet<int>();

                foreach (var item in it_group.Value)
                {
                    if (selectTagIds.Contains(item))
                    {
                        string questsql = "SELECT quest_id FROM quest_tag_map where tag_id = " + item + " ;";
                        var questIds = globalDB.ReadDB<int>(questsql);
                        SortedSet<int> questTagSet = new SortedSet<int>(questIds);

                        singleGroupQuestSet.UnionWith(questTagSet);

                    }

                }
                allQuestSet.IntersectWith(singleGroupQuestSet);

            }
            ListSelectedQuest.Items.Clear();
            foreach (var item in allQuestSet)
            {
                int addIndex = ListSelectedQuest.Items.Add(quests_map[item].caption);
                selectlistId_quest_map[addIndex] = quests_map[item].id;
            }

        }

        private void ListQuests_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> selectQuestId=new  List<int>();
            foreach (var item in selectlistId_quest_map)
            {
                selectQuestId.Add(item.Value);
            }
            var newQueue = RandomSort<int>(selectQuestId);
            ListSelectedQuest.Items.Clear();

            for (int i = 0; i < selectlistId_quest_map.Count; i++)
            {
                selectlistId_quest_map[i] = newQueue[i];
                ListSelectedQuest.Items.Add(quests_map[newQueue[i]].caption);
            }

        }

        private List<T> RandomSort<T>(List<T> list)
        {
            var random = new Random();
            var newList = new List<T>();
            foreach (var item in list)
            {
                newList.Insert(random.Next(newList.Count), item);
            }
            return newList;
        }
        private void ListSelectedQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectQuesId = selectlistId_quest_map[ListSelectedQuest.SelectedIndex];
            var selectQuest = quests_map[selectQuesId];
            labelDetail.Text = selectQuest.detail;
            labelAnswer.Text = selectQuest.answer_text;
            try
            {
                pictureQuest.Load(selectQuest.file_path);
                pictureAnswer.Load(selectQuest.answer_picture);
            }
            catch (Exception)
            {

               // throw;
            }
        }

        private void checkBoxRevealAnswer_CheckedChanged(object sender, EventArgs e)
        {
            SetAnswerVisible();
        }

        private void SetAnswerVisible()
        {
            labelAnswer.Visible = checkBoxRevealAnswer.Checked;
            pictureAnswer.Visible = checkBoxRevealAnswer.Checked;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateTagsList();

        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            System.Drawing.Size wndSize = new Size(Size.Width, Size.Height);
            if(Size.Width<1500 || Size.Width >1600)
            {
                Size = wndSize;
            }
        }

        private void FormMain_ResizeEnd(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainWndSize = Size;
            Properties.Settings.Default.Save();
        }
    }
}
