﻿namespace QuestTag
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
            this.textQuestDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQuestPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAnswerPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTags
            // 
            this.listBoxTags.FormattingEnabled = true;
            this.listBoxTags.ItemHeight = 18;
            this.listBoxTags.Location = new System.Drawing.Point(44, 71);
            this.listBoxTags.Name = "listBoxTags";
            this.listBoxTags.Size = new System.Drawing.Size(198, 256);
            this.listBoxTags.TabIndex = 0;
            this.listBoxTags.SelectedIndexChanged += new System.EventHandler(this.listBoxTags_SelectedIndexChanged);
            this.listBoxTags.DoubleClick += new System.EventHandler(this.listBoxTags_DoubleClick);
            // 
            // listBoxQuestSelectTags
            // 
            this.listBoxQuestSelectTags.FormattingEnabled = true;
            this.listBoxQuestSelectTags.ItemHeight = 18;
            this.listBoxQuestSelectTags.Location = new System.Drawing.Point(268, 71);
            this.listBoxQuestSelectTags.Name = "listBoxQuestSelectTags";
            this.listBoxQuestSelectTags.Size = new System.Drawing.Size(190, 256);
            this.listBoxQuestSelectTags.TabIndex = 1;
            this.listBoxQuestSelectTags.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestSelectTags_SelectedIndexChanged);
            this.listBoxQuestSelectTags.DoubleClick += new System.EventHandler(this.listBoxQuestTags_DoubleClick);
            // 
            // textQuestName
            // 
            this.textQuestName.Location = new System.Drawing.Point(150, 25);
            this.textQuestName.Name = "textQuestName";
            this.textQuestName.Size = new System.Drawing.Size(308, 28);
            this.textQuestName.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(708, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(827, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textQuestDetail
            // 
            this.textQuestDetail.Location = new System.Drawing.Point(485, 75);
            this.textQuestDetail.Multiline = true;
            this.textQuestDetail.Name = "textQuestDetail";
            this.textQuestDetail.Size = new System.Drawing.Size(213, 252);
            this.textQuestDetail.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path：";
            // 
            // textQuestPath
            // 
            this.textQuestPath.Location = new System.Drawing.Point(96, 364);
            this.textQuestPath.Name = "textQuestPath";
            this.textQuestPath.Size = new System.Drawing.Size(482, 28);
            this.textQuestPath.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 29);
            this.button1.TabIndex = 8;
            this.button1.Tag = "Quest";
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSetPath);
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(724, 75);
            this.textAnswer.Multiline = true;
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(199, 252);
            this.textAnswer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer：";
            // 
            // textAnswerPath
            // 
            this.textAnswerPath.Location = new System.Drawing.Point(96, 400);
            this.textAnswerPath.Name = "textAnswerPath";
            this.textAnswerPath.Size = new System.Drawing.Size(482, 28);
            this.textAnswerPath.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 29);
            this.button2.TabIndex = 8;
            this.button2.Tag = "Answer";
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSetPath);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "试题描述：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "试题名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(721, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "答案描述：";
            // 
            // FormQuestAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAnswerPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textQuestPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuestDetail);
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
        private System.Windows.Forms.TextBox textQuestDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQuestPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAnswerPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}