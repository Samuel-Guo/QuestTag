namespace QuestTag
{
    partial class FormQuestView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listQuest = new System.Windows.Forms.ListBox();
            this.pictureQuest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listTags = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MenuPop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureAnswer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).BeginInit();
            this.MenuPop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // listQuest
            // 
            this.listQuest.FormattingEnabled = true;
            this.listQuest.ItemHeight = 18;
            this.listQuest.Location = new System.Drawing.Point(48, 67);
            this.listQuest.Name = "listQuest";
            this.listQuest.Size = new System.Drawing.Size(184, 274);
            this.listQuest.TabIndex = 0;
            this.listQuest.Tag = "Quest";
            this.listQuest.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            this.listQuest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listQuest_MouseUp);
            // 
            // pictureQuest
            // 
            this.pictureQuest.Location = new System.Drawing.Point(476, 67);
            this.pictureQuest.Name = "pictureQuest";
            this.pictureQuest.Size = new System.Drawing.Size(382, 237);
            this.pictureQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQuest.TabIndex = 1;
            this.pictureQuest.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // listTags
            // 
            this.listTags.FormattingEnabled = true;
            this.listTags.ItemHeight = 18;
            this.listTags.Location = new System.Drawing.Point(259, 67);
            this.listTags.Name = "listTags";
            this.listTags.Size = new System.Drawing.Size(184, 274);
            this.listTags.TabIndex = 0;
            this.listTags.Tag = "Tag";
            this.listTags.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "路径";
            // 
            // MenuPop
            // 
            this.MenuPop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuPop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuModify,
            this.MenuDel});
            this.MenuPop.Name = "MenuPop";
            this.MenuPop.Size = new System.Drawing.Size(117, 94);
            // 
            // MenuAdd
            // 
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(116, 30);
            this.MenuAdd.Text = "新建";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuModify
            // 
            this.MenuModify.Name = "MenuModify";
            this.MenuModify.Size = new System.Drawing.Size(116, 30);
            this.MenuModify.Text = "修改";
            this.MenuModify.Click += new System.EventHandler(this.MenuModify_Click);
            // 
            // MenuDel
            // 
            this.MenuDel.Name = "MenuDel";
            this.MenuDel.Size = new System.Drawing.Size(116, 30);
            this.MenuDel.Text = "删除";
            this.MenuDel.Click += new System.EventHandler(this.MenuDel_Click);
            // 
            // pictureAnswer
            // 
            this.pictureAnswer.Location = new System.Drawing.Point(481, 339);
            this.pictureAnswer.Name = "pictureAnswer";
            this.pictureAnswer.Size = new System.Drawing.Size(376, 126);
            this.pictureAnswer.TabIndex = 6;
            this.pictureAnswer.TabStop = false;
            // 
            // FormQuestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 533);
            this.Controls.Add(this.pictureAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureQuest);
            this.Controls.Add(this.listTags);
            this.Controls.Add(this.listQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQuestView";
            this.Text = "QuestForm";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).EndInit();
            this.MenuPop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuest;
        private System.Windows.Forms.PictureBox pictureQuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip MenuPop;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuModify;
        private System.Windows.Forms.ToolStripMenuItem MenuDel;
        private System.Windows.Forms.PictureBox pictureAnswer;
    }
}