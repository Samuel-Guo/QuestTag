namespace QuestTag
{
    partial class FormQuestAdd
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
            this.listBoxTags = new System.Windows.Forms.ListBox();
            this.listBoxQuestSelectTags = new System.Windows.Forms.ListBox();
            this.textQuestName = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxTags
            // 
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 18;
            this.listBoxTags.Location = new System.Drawing.Point(44, 71);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(222, 256);
            this.listBoxTags.TabIndex = 0;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.listBoxTags_SelectedIndexChanged);
            this.listBoxTags.DoubleClick += new System.EventHandler(this.listBoxTags_DoubleClick);
            // 
            // listBoxQuestSelectTags
            // 
            this.listBoxQuestSelectTags.FormattingEnabled = true;
            this.listBoxQuestSelectTags.ItemHeight = 18;
            this.listBoxQuestSelectTags.Location = new System.Drawing.Point(325, 71);
            this.listBoxQuestSelectTags.Name = "listBoxQuestSelectTags";
            this.listBoxQuestSelectTags.Size = new System.Drawing.Size(199, 256);
            this.listBoxQuestSelectTags.TabIndex = 1;
            this.listBoxQuestSelectTags.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestSelectTags_SelectedIndexChanged);
            this.listBoxQuestSelectTags.DoubleClick += new System.EventHandler(this.listBoxQuestTags_DoubleClick);
            // 
            // textQuestName
            // 
            this.textQuestName.Location = new System.Drawing.Point(140, 21);
            this.textQuestName.Name = "textQuestName";
            this.textQuestName.Size = new System.Drawing.Size(384, 28);
            this.textQuestName.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(325, 356);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(437, 356);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormQuestAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 409);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textQuestName);
            this.Controls.Add(this.listBoxQuestSelectTags);
            this.Controls.Add(this.listBoxTags);
            this.Name = "FormQuestAdd";
            this.Text = "FormQuestAdd";
            this.Load += new System.EventHandler(this.FormQuestAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTags;
        private System.Windows.Forms.ListBox listBoxQuestSelectTags;
        private System.Windows.Forms.TextBox textQuestName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}