namespace FukjBizSystem.Application.Boundary.Keiri
{
    partial class KeiriMenuForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaeukekinButton
            // 
            this.MaeukekinButton.Location = new System.Drawing.Point(177, 12);
            this.MaeukekinButton.Name = "MaeukekinButton";
            this.MaeukekinButton.Size = new System.Drawing.Size(135, 55);
            this.MaeukekinButton.TabIndex = 1;
            this.MaeukekinButton.Text = "前受金管理";
            this.MaeukekinButton.UseVisualStyleBackColor = true;
            this.MaeukekinButton.Click += new System.EventHandler(this.MaeukekinButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(344, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "請求管理";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(510, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "入金状況一覧";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 55);
            this.button5.TabIndex = 6;
            this.button5.Text = "金額試算";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(344, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 55);
            this.button6.TabIndex = 7;
            this.button6.Text = "請求残高一覧";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(833, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 55);
            this.button7.TabIndex = 8;
            this.button7.Text = "出納管理";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 74;
            this.button1.Text = "入金入力";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 55);
            this.button2.TabIndex = 75;
            this.button2.Text = "返金入力";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // KeiriMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.MaeukekinButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KeiriMenuForm";
            this.Text = "機能選択";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MaeukekinButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}