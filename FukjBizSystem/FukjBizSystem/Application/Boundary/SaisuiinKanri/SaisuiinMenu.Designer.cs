namespace FukjBizSystem.Application.Boundary.SaisuiinKanri
{
    partial class SaisuiinMenuForm
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
            this.JyukoYoteishaListButton = new System.Windows.Forms.Button();
            this.SaisuiinInfoListButton = new System.Windows.Forms.Button();
            this.SaisuiinShoshoHakkoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JyukoYoteishaListButton
            // 
            this.JyukoYoteishaListButton.Location = new System.Drawing.Point(12, 12);
            this.JyukoYoteishaListButton.Name = "JyukoYoteishaListButton";
            this.JyukoYoteishaListButton.Size = new System.Drawing.Size(135, 55);
            this.JyukoYoteishaListButton.TabIndex = 1;
            this.JyukoYoteishaListButton.Text = "受講予定者一覧";
            this.JyukoYoteishaListButton.UseVisualStyleBackColor = true;
            this.JyukoYoteishaListButton.Click += new System.EventHandler(this.JyukoYoteishaListButton_Click);
            // 
            // SaisuiinInfoListButton
            // 
            this.SaisuiinInfoListButton.Location = new System.Drawing.Point(12, 83);
            this.SaisuiinInfoListButton.Name = "SaisuiinInfoListButton";
            this.SaisuiinInfoListButton.Size = new System.Drawing.Size(135, 55);
            this.SaisuiinInfoListButton.TabIndex = 2;
            this.SaisuiinInfoListButton.Text = "採水員情報一覧";
            this.SaisuiinInfoListButton.UseVisualStyleBackColor = true;
            this.SaisuiinInfoListButton.Click += new System.EventHandler(this.SaisuiinInfoListButton_Click);
            // 
            // SaisuiinShoshoHakkoButton
            // 
            this.SaisuiinShoshoHakkoButton.Location = new System.Drawing.Point(12, 156);
            this.SaisuiinShoshoHakkoButton.Name = "SaisuiinShoshoHakkoButton";
            this.SaisuiinShoshoHakkoButton.Size = new System.Drawing.Size(135, 55);
            this.SaisuiinShoshoHakkoButton.TabIndex = 4;
            this.SaisuiinShoshoHakkoButton.Text = "採水員証明書発行";
            this.SaisuiinShoshoHakkoButton.UseVisualStyleBackColor = true;
            this.SaisuiinShoshoHakkoButton.Click += new System.EventHandler(this.SaisuiinShoshoHakkoButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "受講履入力";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaisuiinMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaisuiinShoshoHakkoButton);
            this.Controls.Add(this.SaisuiinInfoListButton);
            this.Controls.Add(this.JyukoYoteishaListButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaisuiinMenuForm";
            this.Text = "機能選択";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JyukoYoteishaListButton;
        private System.Windows.Forms.Button SaisuiinInfoListButton;
        private System.Windows.Forms.Button SaisuiinShoshoHakkoButton;
        private System.Windows.Forms.Button button1;
    }
}