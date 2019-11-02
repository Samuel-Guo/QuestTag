namespace QuestTag
{
    partial class QuestForm
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
            this.listQuest = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listTags = new System.Windows.Forms.ListBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.listQuest.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(476, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 402);
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
            this.listTags.SelectedIndexChanged += new System.EventHandler(this.listQuest_SelectedIndexChanged);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(110, 483);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(689, 28);
            this.textBoxPath.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "路径";
            // 
            // QuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listTags);
            this.Controls.Add(this.listQuest);
            this.Name = "QuestForm";
            this.Text = "QuestForm";
            this.Load += new System.EventHandler(this.QuestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTags;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label3;
    }
}