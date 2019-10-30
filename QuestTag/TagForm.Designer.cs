namespace QuestTag
{
    partial class TagForm
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
            this.ListBoxTagGroup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxTag = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuModify = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxTagGroup
            // 
            this.ListBoxTagGroup.FormattingEnabled = true;
            this.ListBoxTagGroup.ItemHeight = 18;
            this.ListBoxTagGroup.Location = new System.Drawing.Point(75, 85);
            this.ListBoxTagGroup.Name = "ListBoxTagGroup";
            this.ListBoxTagGroup.Size = new System.Drawing.Size(220, 238);
            this.ListBoxTagGroup.TabIndex = 0;
            this.ListBoxTagGroup.SelectedIndexChanged += new System.EventHandler(this.ListBoxTagGroup_SelectedIndexChanged);
            this.ListBoxTagGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBoxTagGroup_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "标签组";
            // 
            // listBoxTag
            // 
            this.listBoxTag.FormattingEnabled = true;
            this.listBoxTag.ItemHeight = 18;
            this.listBoxTag.Location = new System.Drawing.Point(375, 85);
            this.listBoxTag.Name = "listBoxTag";
            this.listBoxTag.Size = new System.Drawing.Size(212, 238);
            this.listBoxTag.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "标签组";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuModify,
            this.MenuDel});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 127);
            // 
            // MenuAdd
            // 
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(240, 30);
            this.MenuAdd.Text = "增加";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuModify
            // 
            this.MenuModify.Name = "MenuModify";
            this.MenuModify.Size = new System.Drawing.Size(240, 30);
            this.MenuModify.Text = "修改";
            this.MenuModify.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // MenuDel
            // 
            this.MenuDel.Name = "MenuDel";
            this.MenuDel.Size = new System.Drawing.Size(240, 30);
            this.MenuDel.Text = "删除";
            // 
            // TagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxTagGroup);
            this.Name = "TagForm";
            this.Text = "TagForm";
            this.Load += new System.EventHandler(this.TagForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxTagGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuModify;
        private System.Windows.Forms.ToolStripMenuItem MenuDel;
    }
}