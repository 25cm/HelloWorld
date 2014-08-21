namespace FukjBizSystem.Application.Boundary.KensaKekka
{
    partial class KekkaMenuForm
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
            this.MaeukekinButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.kensaDaichoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaeukekinButton
            // 
            this.MaeukekinButton.Location = new System.Drawing.Point(12, 12);
            this.MaeukekinButton.Name = "MaeukekinButton";
            this.MaeukekinButton.Size = new System.Drawing.Size(135, 55);
            this.MaeukekinButton.TabIndex = 1;
            this.MaeukekinButton.Text = "検査結果一覧";
            this.MaeukekinButton.UseVisualStyleBackColor = true;
            this.MaeukekinButton.Click += new System.EventHandler(this.MaeukekinButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(834, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 50);
            this.panel1.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(13, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 41);
            this.label6.TabIndex = 0;
            this.label6.Text = "MockUp";
            // 
            // kensaDaichoButton
            // 
            this.kensaDaichoButton.Location = new System.Drawing.Point(12, 73);
            this.kensaDaichoButton.Name = "kensaDaichoButton";
            this.kensaDaichoButton.Size = new System.Drawing.Size(135, 55);
            this.kensaDaichoButton.TabIndex = 74;
            this.kensaDaichoButton.Text = "検査台帳";
            this.kensaDaichoButton.UseVisualStyleBackColor = true;
            this.kensaDaichoButton.Click += new System.EventHandler(this.kensaDaichoButton_Click);
            // 
            // KekkaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.kensaDaichoButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MaeukekinButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KekkaMenuForm";
            this.Text = "機能選択";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MaeukekinButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kensaDaichoButton;
    }
}