namespace FukjBizSystem.Application.Boundary.KinoHoshoKanri
{
    partial class KinoMenuForm
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
            this.HoshoNoPrintButton = new System.Windows.Forms.Button();
            this.HoshoShinseiInputButton = new System.Windows.Forms.Button();
            this.HoshoShinseiKokanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HoshoNoPrintButton
            // 
            this.HoshoNoPrintButton.Location = new System.Drawing.Point(12, 12);
            this.HoshoNoPrintButton.Name = "HoshoNoPrintButton";
            this.HoshoNoPrintButton.Size = new System.Drawing.Size(135, 55);
            this.HoshoNoPrintButton.TabIndex = 1;
            this.HoshoNoPrintButton.Text = "保証番号印刷";
            this.HoshoNoPrintButton.UseVisualStyleBackColor = true;
            this.HoshoNoPrintButton.Click += new System.EventHandler(this.HoshoNoPrintButton_Click);
            // 
            // HoshoShinseiInputButton
            // 
            this.HoshoShinseiInputButton.Location = new System.Drawing.Point(12, 83);
            this.HoshoShinseiInputButton.Name = "HoshoShinseiInputButton";
            this.HoshoShinseiInputButton.Size = new System.Drawing.Size(135, 55);
            this.HoshoShinseiInputButton.TabIndex = 2;
            this.HoshoShinseiInputButton.Text = "保証申請入力";
            this.HoshoShinseiInputButton.UseVisualStyleBackColor = true;
            this.HoshoShinseiInputButton.Click += new System.EventHandler(this.HoshoShinseiInputButton_Click);
            // 
            // HoshoShinseiKokanButton
            // 
            this.HoshoShinseiKokanButton.Location = new System.Drawing.Point(12, 158);
            this.HoshoShinseiKokanButton.Name = "HoshoShinseiKokanButton";
            this.HoshoShinseiKokanButton.Size = new System.Drawing.Size(135, 55);
            this.HoshoShinseiKokanButton.TabIndex = 3;
            this.HoshoShinseiKokanButton.Text = "保証申請書交換";
            this.HoshoShinseiKokanButton.UseVisualStyleBackColor = true;
            this.HoshoShinseiKokanButton.Click += new System.EventHandler(this.HoshoShinseiKokanButton_Click);
            // 
            // KinoMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.HoshoShinseiKokanButton);
            this.Controls.Add(this.HoshoShinseiInputButton);
            this.Controls.Add(this.HoshoNoPrintButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KinoMenuForm";
            this.Text = "機能選択";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HoshoNoPrintButton;
        private System.Windows.Forms.Button HoshoShinseiInputButton;
        private System.Windows.Forms.Button HoshoShinseiKokanButton;
    }
}