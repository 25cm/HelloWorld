﻿namespace FukjBizSystem.Application.Boundary.KaiinKanri
{
    partial class KaiinMenuForm
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
            this.KaiinListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KaiinListButton
            // 
            this.KaiinListButton.Location = new System.Drawing.Point(12, 12);
            this.KaiinListButton.Name = "KaiinListButton";
            this.KaiinListButton.Size = new System.Drawing.Size(135, 55);
            this.KaiinListButton.TabIndex = 1;
            this.KaiinListButton.Text = "会員一覧";
            this.KaiinListButton.UseVisualStyleBackColor = true;
            this.KaiinListButton.Click += new System.EventHandler(this.KaiinListButton_Click);
            // 
            // KaiinMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.KaiinListButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KaiinMenuForm";
            this.Text = "機能選択";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KaiinListButton;
    }
}