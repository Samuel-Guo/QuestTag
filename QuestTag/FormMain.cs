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
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GlobalVar.globalDB = new MysqlConnector();
            GlobalVar.globalDB.SetServer("127.0.0.1")
           .SetDataBase("edu")
           .SetUserID("root")
           .SetPassword("1234qwer")
           //.SetPassword("12qw!@QW")
           .SetPort("3306")
           .SetCharset("utf8");
            TagForm tagForm = new TagForm();
            tagForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
