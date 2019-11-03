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
    public partial class FormQuestAdd : Form
    {
        private MysqlConnector globalDB = GlobalVar.globalDB;
        private Dictionary<int, int> tagId_groupId_map = new Dictionary<int, int>();
        private Dictionary<int, int> listId_tagId_map = new Dictionary<int, int>();
        public Dictionary<int, int> listId_selectTagId_map = new Dictionary<int, int>();
        public string QuestName;

        public FormQuestAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

        }

        private void FormQuestAdd_Load(object sender, EventArgs e)
        {
            listBoxQuestSelectTags.Items.Clear();

            LoadListBoxQuest();

        }

        private void LoadListBoxQuest()
        {
 
            List<int> exclusiveGroup = new List<int>();
            string exsql="";
            for (int i = 0; i < listBoxQuestSelectTags.Items.Count; i++)
            {
                exclusiveGroup.Add(listId_selectTagId_map[i]);
                exsql =exsql+ " and group_id != " + tagId_groupId_map[listId_selectTagId_map[i]];

            }
            listBoxTags.Items.Clear();

            string sqlcmd = "SELECT * FROM tag_def where is_valid = 1 "
                + exsql  +" order by group_id ; ";

            var tag_list = globalDB.ReadDB<Db_struct.Tag_def>(sqlcmd);

            //string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";
            //var tagGroup = globalDB.ExeQuery(sqlcmd);
            foreach (var tag in tag_list)
            {
                //cap_map_tag_group.Add(tag_Group.caption, tag_Group);
                //id_map_tag_group.Add(tag_Group.id, tag_Group);

                //      tagMap.Add(id, group_tag_name);
                var addIndex =  listBoxTags.Items.Add(tag.caption);
                tagId_groupId_map[tag.id] = tag.group_id;
                listId_tagId_map[addIndex] = tag.id;
            }
        }

        private void listBoxTags_DoubleClick(object sender, EventArgs e)
        {
            var selectItem = listBoxTags.SelectedItem;
            if (selectItem == null) return;
            if (listBoxQuestSelectTags.Items.Contains(selectItem)) return;
            
            var addIndex = listBoxQuestSelectTags.Items.Add(selectItem);
            listId_selectTagId_map[addIndex] = listId_tagId_map[listBoxTags.SelectedIndex];
            LoadListBoxQuest();
        }

        private void listBoxQuestTags_DoubleClick(object sender, EventArgs e)
        {
            var selectItem = listBoxQuestSelectTags.SelectedItem;
            listBoxQuestSelectTags.Items.Remove(selectItem);
            LoadListBoxQuest();
        }

        private void listBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxQuestSelectTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (textQuestName.Text == "")
            {
                MessageBox.Show("请输入题目名称！");
                return;
            }
            QuestName = textQuestName.Text;
            this.DialogResult = DialogResult.OK;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
