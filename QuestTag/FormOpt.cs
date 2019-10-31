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
    public partial class FormOpt : Form
    {
        public string textString;
        public bool isChecked;
        public FormOpt(string formCaption,bool hasCheckBox,string textCaption ="",bool isChecked = false )
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            ShowIcon = false;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Text = formCaption;
            textBox1.Text = textCaption;
            checkBox1.Visible = hasCheckBox;
            checkBox1.Checked = isChecked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Null ! ");
                return;
            }
            textString = textBox1.Text;
            isChecked = checkBox1.Checked;
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
    }
}
