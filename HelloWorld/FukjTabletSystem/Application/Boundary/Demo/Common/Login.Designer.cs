﻿namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    partial class Login
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
            this.AccountGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseButton = new Zynas.Control.ZButton(this.components);
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new Zynas.Control.ZButton(this.components);
            this.PasswordTextBox = new FukjTabletSystem.Controls.ZTextBox(this.components);
            this.UserIdTextBox = new FukjTabletSystem.Controls.ZTextBox(this.components);
            this.TitleTextBox = new FukjTabletSystem.Controls.ZTextBox(this.components);
            this.AccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountGroupBox
            // 
            this.AccountGroupBox.Controls.Add(this.LoginButton);
            this.AccountGroupBox.Controls.Add(this.PasswordTextBox);
            this.AccountGroupBox.Controls.Add(this.UserIdTextBox);
            this.AccountGroupBox.Controls.Add(this.PasswordLabel);
            this.AccountGroupBox.Controls.Add(this.UserIdLabel);
            this.AccountGroupBox.Location = new System.Drawing.Point(13, 67);
            this.AccountGroupBox.Name = "AccountGroupBox";
            this.AccountGroupBox.Size = new System.Drawing.Size(449, 100);
            this.AccountGroupBox.TabIndex = 1;
            this.AccountGroupBox.TabStop = false;
            this.AccountGroupBox.Text = "ユーザーID/パスワード";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(341, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(120, 32);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.UserIdLabel.ForeColor = System.Drawing.Color.White;
            this.UserIdLabel.Location = new System.Drawing.Point(6, 26);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(3);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(102, 27);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "ユーザID";
            this.UserIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.Color.OliveDrab;
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 59);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(3);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(102, 27);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "パスワード";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(323, 21);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(120, 32);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "ログイン(F5)";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AllowDropDown = false;
            this.PasswordTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.PasswordTextBox.CustomInputMode = FukjTabletSystem.Controls.ZTextBox.InputMode.None;
            this.PasswordTextBox.CustomReadOnly = false;
            this.PasswordTextBox.Location = new System.Drawing.Point(114, 59);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(193, 27);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.AllowDropDown = false;
            this.UserIdTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.UserIdTextBox.CustomInputMode = FukjTabletSystem.Controls.ZTextBox.InputMode.None;
            this.UserIdTextBox.CustomReadOnly = false;
            this.UserIdTextBox.Location = new System.Drawing.Point(114, 26);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(193, 27);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.AllowDropDown = false;
            this.TitleTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.TitleTextBox.CustomInputMode = FukjTabletSystem.Controls.ZTextBox.InputMode.None;
            this.TitleTextBox.CustomReadOnly = true;
            this.TitleTextBox.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleTextBox.Location = new System.Drawing.Point(13, 14);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(307, 39);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.TabStop = false;
            this.TitleTextBox.Text = "ログイン";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 179);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AccountGroupBox);
            this.Controls.Add(this.TitleTextBox);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.AccountGroupBox.ResumeLayout(false);
            this.AccountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ZTextBox TitleTextBox;
        private System.Windows.Forms.GroupBox AccountGroupBox;
        private Zynas.Control.ZButton CloseButton;
        private Zynas.Control.ZButton LoginButton;
        private Controls.ZTextBox PasswordTextBox;
        private Controls.ZTextBox UserIdTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserIdLabel;
    }
}