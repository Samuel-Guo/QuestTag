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
    public partial class QuestForm : Form
    {
        Dictionary<int, int> listId_id_map = new Dictionary<int, int>();
        Dictionary<int, Db_struct.Quest_def> quests_map = new Dictionary<int, Db_struct.Quest_def>();
        Dictionary<int, Db_struct.Tag_def> tag_map = new Dictionary<int, Db_struct.Tag_def>();
        public QuestForm()
        {
            InitializeComponent();
        }

        private void QuestForm_Load(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM quest_def where is_valid=1;";
            var quests=  GlobalVar.globalDB.ReadDB<Db_struct.Quest_def>(sqlcmd);
            int i = 0;
            listQuest.Items.Clear();
            listId_id_map.Clear();
            foreach (var quest in quests)
            {
                listId_id_map.Add(i++, quest.id);
                listQuest.Items.Add(quest.caption);
                quests_map.Add(quest.id, quest);
            }

            string getTagSql = "SELECT" + Db_struct.tag_def_field +
                 "from tag_def where is_valid =1; ";
            var tagList = GlobalVar.globalDB.ReadDB<Db_struct.Tag_def>(getTagSql);
            foreach (var tag in tagList)
            {
               tag_map.Add(tag.id,tag);
            }

        }

        private void listQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listQuest.
            //string sqlcmd = "SELECT file_path from quest_def where id =" + listId_id_map[listQuest.SelectedIndex].ToString();
            //var path = GlobalVar.globalDB.ReadDB<String>(sqlcmd)[0];
            var selectQuest = quests_map[listId_id_map[listQuest.SelectedIndex]];
            var questId = selectQuest.id;
            string sqlcmd = "SELECT caption from quest_tag_map " +
                "inner join tag_def on quest_tag_map.tag_id = tag_def.id " +
                "where quest_tag_map.is_valid =1 and " +
                "quest_id =" + listId_id_map[listQuest.SelectedIndex].ToString()
                + " order by group_id;";

            var tagsCap = GlobalVar.globalDB.ReadDB<string>(sqlcmd);
            //   listTags.Items.AddRange(tagsCap);
            listTags.Items.Clear();
            foreach (var tagId in tagsCap)
            {
                listTags.Items.Add(tagId);
            }
            label1.Text = selectQuest.file_path;
            textBoxPath.Text = selectQuest.file_path;
            label2.Text = selectQuest.detail;
            pictureBox1.Load(selectQuest.file_path);
        }
    }
}
