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
        public string QuestName,QuestDetail,QuestPath;
        private string InitialDirectory;

        public FormQuestAdd(string formCaption,int questId=0)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Text = formCaption;
            if(questId!=0)
            {
                LoadTagSelectQuest(questId);
            }
        }

        private void LoadTagSelectQuest(int questId)
        {
            string sqlcmd = "SELECT " + Db_struct.quest_tag_map_field + " FROM quest_tag_map " +
                "inner join tag_def on quest_tag_map.tag_id = tag_def.id "
                + " where quest_tag_map.is_valid=1 and quest_id= " + questId + " order by group_id;";
            var quests = GlobalVar.globalDB.ReadDB<Db_struct.Quest_tag_map>(sqlcmd);

            string tagcapsql = "SELECT caption from quest_tag_map " +
                "inner join tag_def on quest_tag_map.tag_id = tag_def.id " +
                "where quest_tag_map.is_valid =1 and " +
                "quest_id =" + questId + " order by group_id;";

            var tagsCaps = GlobalVar.globalDB.ReadDB<string>(tagcapsql);
            listBoxQuestSelectTags.Items.Clear();
            for (int i = 0; i < quests.Count; i++)
            {
                var addIndex = listBoxQuestSelectTags.Items.Add(tagsCaps[i]);
                listId_selectTagId_map[addIndex] = quests[i].tag_id;

            }

            string questsql = "SELECT * FROM quest_def where is_valid=1 and id = "+ questId;
            var quest = GlobalVar.globalDB.ReadDB<Db_struct.Quest_def>(questsql)[0];
            textQuestName.Text = quest.caption;
            textQuestDetail.Text = quest.detail;
            textQuestPath.Text = quest.file_path;
        }

        private void FormQuestAdd_Load(object sender, EventArgs e)
        {
           // listBoxQuestSelectTags.Items.Clear();

            LoadListBoxQuest();

        }

        private void LoadListBoxQuest()
        {

            string taggroupsql = "SELECT * FROM tag_def where is_valid = 1 ";
            var tag_list_all = globalDB.ReadDB<Db_struct.Tag_def>(taggroupsql);
            foreach (var tag in tag_list_all)
            {
                tagId_groupId_map[tag.id] = tag.group_id;
            }

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
              //  tagId_groupId_map[tag.id] = tag.group_id;
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
            for (int i=0; i< listId_selectTagId_map.Count-1;i++)
            {
                if (i >= listBoxQuestSelectTags.SelectedIndex)
                {
                    listId_selectTagId_map[i] = listId_selectTagId_map[i + 1];
                }
            }
            listId_selectTagId_map.Remove(listId_selectTagId_map.Count - 1);
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
            QuestDetail = textQuestDetail.Text;
            QuestPath = textQuestPath.Text;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private bool InitialDialog(FileDialog fileDialog, string title)
        {
            fileDialog.InitialDirectory = InitialDirectory;//初始化路径
            fileDialog.Filter = "jpeg files (*.jpeg,*.*)|*.jpeg;*.*";//过滤选项设置，文本文件，所有文件。
            fileDialog.FilterIndex = 1;//当前使用第二个过滤字符串
            //fileDialog.RestoreDirectory = true;//对话框关闭时恢复原目录
            fileDialog.Title = title;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i <= fileDialog.FileName.Length; i++)
                {
                    if (fileDialog.FileName.Substring(fileDialog.FileName.Length - i, 1).Equals(@"\"))
                    {
                        //更改默认路径为最近打开路径
                        InitialDirectory = fileDialog.FileName.Substring(0, fileDialog.FileName.Length - i + 1);
                        return true;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//打开文件对话框              
            if (InitialDialog(openFileDialog, "Open"))
            {
                 textQuestPath.Text= openFileDialog.FileName;
            }
        }
    }
}
