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
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListTags = new System.Windows.Forms.CheckedListBox();
            this.ListSelectedQuest = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureQuest = new System.Windows.Forms.PictureBox();
            this.labelDetail = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureAnswer = new System.Windows.Forms.PictureBox();
            this.checkBoxRevealAnswer = new System.Windows.Forms.CheckBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.试题ToolStripMenuItem,
            this.标签ToolStripMenuItem,
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1118, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 试题ToolStripMenuItem
            // 
            this.试题ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuQuest});
            this.试题ToolStripMenuItem.Name = "试题ToolStripMenuItem";
            this.试题ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.试题ToolStripMenuItem.Text = "试题";
            // 
            // MenuQuest
            // 
            this.MenuQuest.Name = "MenuQuest";
            this.MenuQuest.Size = new System.Drawing.Size(124, 22);
            this.MenuQuest.Text = "试题管理";
            this.MenuQuest.Click += new System.EventHandler(this.MenuQuest_Click);
            // 
            // 标签ToolStripMenuItem
            // 
            this.标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTag,
            this.toolStripMenuItem1});
            this.标签ToolStripMenuItem.Name = "标签ToolStripMenuItem";
            this.标签ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.标签ToolStripMenuItem.Text = "标签";
            // 
            // MenuTag
            // 
            this.MenuTag.Name = "MenuTag";
            this.MenuTag.Size = new System.Drawing.Size(124, 22);
            this.MenuTag.Text = "标签管理";
            this.MenuTag.Click += new System.EventHandler(this.MenuTag_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItem1.Text = "刷新";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 数据库设置ToolStripMenuItem
            // 
            this.数据库设置ToolStripMenuItem.Name = "数据库设置ToolStripMenuItem";
            this.数据库设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.数据库设置ToolStripMenuItem.Text = "数据库设置";
            // 
            // ListTags
            // 
            this.ListTags.FormattingEnabled = true;
            this.ListTags.Location = new System.Drawing.Point(15, 35);
            this.ListTags.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListTags.Name = "ListTags";
            this.ListTags.Size = new System.Drawing.Size(152, 228);
            this.ListTags.TabIndex = 1;
            this.ListTags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListQuests_ItemCheck);
            this.ListTags.SelectedIndexChanged += new System.EventHandler(this.ListQuests_SelectedIndexChanged);
            // 
            // ListSelectedQuest
            // 
            this.ListSelectedQuest.FormattingEnabled = true;
            this.ListSelectedQuest.Location = new System.Drawing.Point(189, 35);
            this.ListSelectedQuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListSelectedQuest.Name = "ListSelectedQuest";
            this.ListSelectedQuest.Size = new System.Drawing.Size(163, 228);
            this.ListSelectedQuest.TabIndex = 2;
            this.ListSelectedQuest.SelectedIndexChanged += new System.EventHandler(this.ListSelectedQuest_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 265);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "重排列";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureQuest
            // 
            this.pictureQuest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureQuest.Location = new System.Drawing.Point(0, 332);
            this.pictureQuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureQuest.Name = "pictureQuest";
            this.pictureQuest.Size = new System.Drawing.Size(1118, 199);
            this.pictureQuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureQuest.TabIndex = 4;
            this.pictureQuest.TabStop = false;
            // 
            // labelDetail
            // 
            this.labelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDetail.Location = new System.Drawing.Point(0, 0);
            this.labelDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(145, 178);
            this.labelDetail.TabIndex = 5;
            this.labelDetail.Text = "无";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureAnswer);
            this.groupBox1.Controls.Add(this.checkBoxRevealAnswer);
            this.groupBox1.Controls.Add(this.labelAnswer);
            this.groupBox1.Location = new System.Drawing.Point(557, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(453, 228);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答案";
            // 
            // pictureAnswer
            // 
            this.pictureAnswer.Location = new System.Drawing.Point(21, 72);
            this.pictureAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureAnswer.Name = "pictureAnswer";
            this.pictureAnswer.Size = new System.Drawing.Size(397, 142);
            this.pictureAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAnswer.TabIndex = 2;
            this.pictureAnswer.TabStop = false;
            this.pictureAnswer.Visible = false;
            // 
            // checkBoxRevealAnswer
            // 
            this.checkBoxRevealAnswer.AutoSize = true;
            this.checkBoxRevealAnswer.Location = new System.Drawing.Point(39, 0);
            this.checkBoxRevealAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxRevealAnswer.Name = "checkBoxRevealAnswer";
            this.checkBoxRevealAnswer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRevealAnswer.TabIndex = 1;
            this.checkBoxRevealAnswer.UseVisualStyleBackColor = true;
            this.checkBoxRevealAnswer.CheckedChanged += new System.EventHandler(this.checkBoxRevealAnswer_CheckedChanged);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(19, 25);
            this.labelAnswer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(41, 12);
            this.labelAnswer.TabIndex = 0;
            this.labelAnswer.Text = "label1";
            this.labelAnswer.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(367, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(167, 210);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "描述";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDetail);
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 178);
            this.panel1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1118, 531);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListSelectedQuest);
            this.Controls.Add(this.ListTags);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureQuest);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(2005, 1680);
            this.MinimumSize = new System.Drawing.Size(139, 370);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureQuest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnswer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 试题ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标签ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTag;
        private System.Windows.Forms.CheckedListBox ListTags;
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
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库设置ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

