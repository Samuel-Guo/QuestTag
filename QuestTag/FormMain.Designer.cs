﻿namespace QuestTag
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.试题ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuest = new System.Windows.Forms.ToolStripMenuItem();
            this.标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListQuests = new System.Windows.Forms.CheckedListBox();
            this.ListSelectedQuest = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureQuest = new System.Windows.Forms.PictureBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureAnswer = new System.Windows.Forms.PictureBox();
            this.checkBoxRevealAnswer = new System.Windows.Forms.CheckBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.试题ToolStripMenuItem,
            this.标签ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1529, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 试题ToolStripMenuItem
            // 
            this.试题ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuQuest});
            this.试题ToolStripMenuItem.Name = "试题ToolStripMenuItem";
            this.试题ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.试题ToolStripMenuItem.Text = "试题";
            // 
            // MenuQuest
            // 
            this.MenuQuest.Name = "MenuQuest";
            this.MenuQuest.Size = new System.Drawing.Size(182, 34);
            this.MenuQuest.Text = "试题管理";
            this.MenuQuest.Click += new System.EventHandler(this.MenuQuest_Click);
            // 
            // 标签ToolStripMenuItem
            // 
            this.标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTag,
            this.toolStripMenuItem1});
            this.标签ToolStripMenuItem.Name = "标签ToolStripMenuItem";
            this.标签ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.标签ToolStripMenuItem.Text = "标签";
            // 
            // MenuTag
            // 
            this.MenuTag.Name = "MenuTag";
            this.MenuTag.Size = new System.Drawing.Size(270, 34);
            this.MenuTag.Text = "标签管理";
            this.MenuTag.Click += new System.EventHandler(this.MenuTag_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.toolStripMenuItem1.Text = "刷新";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ListQuests
            // 
            this.ListQuests.FormattingEnabled = true;
            this.ListQuests.Location = new System.Drawing.Point(22, 52);
            this.ListQuests.Name = "ListQuests";
            this.ListQuests.Size = new System.Drawing.Size(226, 379);
            this.ListQuests.TabIndex = 1;
            this.ListQuests.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListQuests_ItemCheck);
            this.ListQuests.SelectedIndexChanged += new System.EventHandler(this.ListQuests_SelectedIndexChanged);
            // 
            // ListSelectedQuest
            // 
            this.ListSelectedQuest.FormattingEnabled = true;
            this.ListSelectedQuest.Location = new System.Drawing.Point(283, 52);
            this.ListSelectedQuest.Name = "ListSelectedQuest";
            this.ListSelectedQuest.Size = new System.Drawing.Size(242, 379);
            this.ListSelectedQuest.TabIndex = 2;
            this.ListSelectedQuest.SelectedIndexChanged += new System.EventHandler(this.ListSelectedQuest_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "重排列";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureQuest
            // 
            this.pictureQuest.Location = new System.Drawing.Point(22, 457);
            this.pictureQuest.Name = "pictureQuest";
            this.pictureQuest.Size = new System.Drawing.Size(1398, 568);
            this.pictureQuest.TabIndex = 4;
            this.pictureQuest.TabStop = false;
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Location = new System.Drawing.Point(559, 52);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(62, 18);
            this.labelDetail.TabIndex = 5;
            this.labelDetail.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureAnswer);
            this.groupBox1.Controls.Add(this.checkBoxRevealAnswer);
            this.groupBox1.Controls.Add(this.labelAnswer);
            this.groupBox1.Location = new System.Drawing.Point(835, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 342);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答案";
            // 
            // pictureAnswer
            // 
            this.pictureAnswer.Location = new System.Drawing.Point(31, 108);
            this.pictureAnswer.Name = "pictureAnswer";
            this.pictureAnswer.Size = new System.Drawing.Size(596, 213);
            this.pictureAnswer.TabIndex = 2;
            this.pictureAnswer.TabStop = false;
            // 
            // checkBoxRevealAnswer
            // 
            this.checkBoxRevealAnswer.AutoSize = true;
            this.checkBoxRevealAnswer.Location = new System.Drawing.Point(406, 37);
            this.checkBoxRevealAnswer.Name = "checkBoxRevealAnswer";
            this.checkBoxRevealAnswer.Size = new System.Drawing.Size(106, 22);
            this.checkBoxRevealAnswer.TabIndex = 1;
            this.checkBoxRevealAnswer.Text = "显示答案";
            this.checkBoxRevealAnswer.UseVisualStyleBackColor = true;
            this.checkBoxRevealAnswer.CheckedChanged += new System.EventHandler(this.checkBoxRevealAnswer_CheckedChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(28, 37);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(62, 18);
            this.labelAnswer.TabIndex = 0;
            this.labelAnswer.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1529, 1046);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.pictureQuest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListSelectedQuest);
            this.Controls.Add(this.ListQuests);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 试题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTag;
        private System.Windows.Forms.CheckedListBox ListQuests;
        private System.Windows.Forms.ToolStripMenuItem MenuQuest;
        private System.Windows.Forms.CheckedListBox ListSelectedQuest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureQuest;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureAnswer;
        private System.Windows.Forms.CheckBox checkBoxRevealAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

