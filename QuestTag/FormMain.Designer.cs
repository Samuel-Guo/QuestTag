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
            this.标签ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标签管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.试题ToolStripMenuItem.Name = "试题ToolStripMenuItem";
            this.试题ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.试题ToolStripMenuItem.Text = "试题";
            // 
            // 标签ToolStripMenuItem
            // 
            this.标签ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标签管理ToolStripMenuItem});
            this.标签ToolStripMenuItem.Name = "标签ToolStripMenuItem";
            this.标签ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.标签ToolStripMenuItem.Text = "标签";
            // 
            // 标签管理ToolStripMenuItem
            // 
            this.标签管理ToolStripMenuItem.Name = "标签管理ToolStripMenuItem";
            this.标签管理ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.标签管理ToolStripMenuItem.Text = "标签管理";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 480);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem 标签管理ToolStripMenuItem;
    }
}

