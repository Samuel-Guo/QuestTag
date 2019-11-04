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


            ListQuests.Items.Clear();
            listId_tagId_map.Clear();

            string sqlcmd = "SELECT * FROM tag_def where is_valid = 1 ; ";

            var tag_list = globalDB.ReadDB<Db_struct.Tag_def>(sqlcmd);

            foreach (var tags in tag_list)
            {
               int addIndex = ListQuests.Items.Add(tags.caption);
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



        }


        private static void InitDBconf()
        {
            GlobalVar.globalDB = new MysqlConnector();
            GlobalVar.globalDB.SetServer("127.0.0.1")
           .SetDataBase("edu")
           .SetUserID("root")
           .SetPassword("1234!@#$qwer")
           //.SetPassword("12qw!@QW")
           .SetPort("3306")
           .SetCharset("utf8");
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

        }
    }
}
