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

        public FormMain()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDBconf();
            TagForm tagForm = new TagForm();
            tagForm.Show();
            ReadGroupList();

        }

        private void ReadGroupList()
        {
            var tag_group_list = GlobalVar.tag_group_list;
            string sqlcmd = "SELECT * FROM tag_group_def where is_valid = 1 ; ";
            var tagGroup = globalDB.ExeQuery(sqlcmd);
            while (tagGroup.Read())
            {
                Db_struct.Tag_group_def tag_Group;
                tag_Group.id = Convert.ToInt32(tagGroup.GetString(0));
                tag_Group.caption = tagGroup.GetString(1);
                tag_Group.unique = Convert.ToInt32(tagGroup.GetString(2));
                tag_Group.is_valid = Convert.ToInt32(tagGroup.GetString(3));
                tag_group_list.Add(tag_Group);
                //      tagMap.Add(id, group_tag_name);
                // ListBoxTagGroup.
            }
        }

        private static void InitDBconf()
        {
            GlobalVar.globalDB = new MysqlConnector();
            GlobalVar.globalDB.SetServer("127.0.0.1")
           .SetDataBase("edu")
           .SetUserID("root")
           .SetPassword("1234qwer")
           //.SetPassword("12qw!@QW")
           .SetPort("3306")
           .SetCharset("utf8");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
