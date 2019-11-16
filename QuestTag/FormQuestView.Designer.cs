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
            this.labelQuestPath = new System.Windows.Forms.Label();
            this.labelQuestDetail = new System.Windows.Forms.Label();
            this.listTags = new System.Windows.Forms.ListBox();
            this.MenuPop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureAnswer = new System.Windows.Forms.PictureBox();
            this.labelAnswerPath = new System.Windows.Forms.Label();
            this.labelAnswerDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).BeginInit();
            this.MenuPop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // listQuest
            // 
            this.listQuest.FormattingEnabled = true;
            this.listQuest.ItemHeight = 12;
            this.listQuest.Location = new System.Drawing.Point(32, 45);
            this.listQuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listQuest.Name = "listQuest";
            this.listQuest.Size = new System.Drawing.Size(124, 184);
            this.listQuest.TabIndex = 0;
            this.listQuest.Tag = "Quest";
            this.listQuest.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            this.listQuest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listQuest_MouseUp);
            // 
            // pictureQuest
            // 
            this.pictureQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureQuest.Location = new System.Drawing.Point(321, 45);
            this.pictureQuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureQuest.Name = "pictureQuest";
            this.pictureQuest.Size = new System.Drawing.Size(271, 158);
            this.pictureQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQuest.TabIndex = 1;
            this.pictureQuest.TabStop = false;
            // 
            // labelQuestPath
            // 
            this.labelQuestPath.AutoSize = true;
            this.labelQuestPath.Location = new System.Drawing.Point(319, 212);
            this.labelQuestPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestPath.Name = "labelQuestPath";
            this.labelQuestPath.Size = new System.Drawing.Size(41, 12);
            this.labelQuestPath.TabIndex = 2;
            this.labelQuestPath.Text = "label1";
            // 
            // labelQuestDetail
            // 
            this.labelQuestDetail.AutoSize = true;
            this.labelQuestDetail.Location = new System.Drawing.Point(30, 250);
            this.labelQuestDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestDetail.Name = "labelQuestDetail";
            this.labelQuestDetail.Size = new System.Drawing.Size(41, 12);
            this.labelQuestDetail.TabIndex = 3;
            this.labelQuestDetail.Text = "label2";
            // 
            // listTags
            // 
            this.listTags.FormattingEnabled = true;
            this.listTags.ItemHeight = 12;
            this.listTags.Location = new System.Drawing.Point(173, 45);
            this.listTags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTags.Name = "listTags";
            this.listTags.Size = new System.Drawing.Size(124, 184);
            this.listTags.TabIndex = 0;
            this.listTags.Tag = "Tag";
            this.listTags.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            // 
            // MenuPop
            // 
            this.MenuPop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuPop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuModify,
            this.MenuDel});
            this.MenuPop.Name = "MenuPop";
            this.MenuPop.Size = new System.Drawing.Size(101, 70);
            // 
            // MenuAdd
            // 
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(100, 22);
            this.MenuAdd.Text = "新建";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuModify
            // 
            this.MenuModify.Name = "MenuModify";
            this.MenuModify.Size = new System.Drawing.Size(100, 22);
            this.MenuModify.Text = "修改";
            this.MenuModify.Click += new System.EventHandler(this.MenuModify_Click);
            // 
            // MenuDel
            // 
            this.MenuDel.Name = "MenuDel";
            this.MenuDel.Size = new System.Drawing.Size(100, 22);
            this.MenuDel.Text = "删除";
            this.MenuDel.Click += new System.EventHandler(this.MenuDel_Click);
            // 
            // pictureAnswer
            // 
            this.pictureAnswer.Location = new System.Drawing.Point(321, 241);
            this.pictureAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureAnswer.Name = "pictureAnswer";
            this.pictureAnswer.Size = new System.Drawing.Size(271, 93);
            this.pictureAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAnswer.TabIndex = 6;
            this.pictureAnswer.TabStop = false;
            // 
            // labelAnswerPath
            // 
            this.labelAnswerPath.AutoSize = true;
            this.labelAnswerPath.Location = new System.Drawing.Point(319, 344);
            this.labelAnswerPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerPath.Name = "labelAnswerPath";
            this.labelAnswerPath.Size = new System.Drawing.Size(41, 12);
            this.labelAnswerPath.TabIndex = 7;
            this.labelAnswerPath.Text = "label1";
            // 
            // labelAnswerDetail
            // 
            this.labelAnswerDetail.AutoSize = true;
            this.labelAnswerDetail.Location = new System.Drawing.Point(30, 298);
            this.labelAnswerDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswerDetail.Name = "labelAnswerDetail";
            this.labelAnswerDetail.Size = new System.Drawing.Size(41, 12);
            this.labelAnswerDetail.TabIndex = 8;
            this.labelAnswerDetail.Text = "label1";
            // 
            // FormQuestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 376);
            this.Controls.Add(this.labelAnswerDetail);
            this.Controls.Add(this.labelAnswerPath);
            this.Controls.Add(this.pictureAnswer);
            this.Controls.Add(this.labelQuestDetail);
            this.Controls.Add(this.labelQuestPath);
            this.Controls.Add(this.pictureQuest);
            this.Controls.Add(this.listTags);
            this.Controls.Add(this.listQuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label labelQuestPath;
        private System.Windows.Forms.Label labelQuestDetail;
        private System.Windows.Forms.ListBox listTags;
        private System.Windows.Forms.ContextMenuStrip MenuPop;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuModify;
        private System.Windows.Forms.ToolStripMenuItem MenuDel;
        private System.Windows.Forms.PictureBox pictureAnswer;
        private System.Windows.Forms.Label labelAnswerPath;
        private System.Windows.Forms.Label labelAnswerDetail;
    }
}