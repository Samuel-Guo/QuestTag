namespace QuestTag
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
            this.ListQuests = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1213, 32);
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
            this.MenuQuest.Size = new System.Drawing.Size(270, 34);
            this.MenuQuest.Text = "试题管理";
            this.MenuQuest.Click += new System.EventHandler(this.MenuQuest_Click);
            // 
            // 标签ToolStripMenuItem
            // 
            this.标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTag});
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
            // ListQuests
            // 
            this.ListQuests.FormattingEnabled = true;
            this.ListQuests.Location = new System.Drawing.Point(22, 52);
            this.ListQuests.Name = "ListQuests";
            this.ListQuests.Size = new System.Drawing.Size(280, 404);
            this.ListQuests.TabIndex = 1;
            this.ListQuests.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListQuests_ItemCheck);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(333, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(246, 404);
            this.checkedListBox1.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 516);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ListQuests);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

