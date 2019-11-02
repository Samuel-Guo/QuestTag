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
            InitDBconf();

        //    GlobalVar.UpdateDBList();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Visible = false;
            WindowState = FormWindowState.Minimized;

            TagForm tagForm = new TagForm();
            tagForm.Show();
            QuestForm questForm = new QuestForm();
            questForm.Show();
            questForm.Activate();
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
