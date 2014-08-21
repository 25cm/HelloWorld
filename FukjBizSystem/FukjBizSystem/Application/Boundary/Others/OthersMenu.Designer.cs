namespace FukjBizSystem.Application.Boundary.Others
{
    partial class OthersMenuForm
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
            this.FileKanriListButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileKanriListButton
            // 
            this.FileKanriListButton.Location = new System.Drawing.Point(12, 12);
            this.FileKanriListButton.Name = "FileKanriListButton";
            this.FileKanriListButton.Size = new System.Drawing.Size(135, 55);
            this.FileKanriListButton.TabIndex = 1;
            this.FileKanriListButton.Text = "受検啓発履歴管理";
            this.FileKanriListButton.UseVisualStyleBackColor = true;
            this.FileKanriListButton.Click += new System.EventHandler(this.KaiinListButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(883, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 50);
            this.panel1.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(13, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "MockUp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 156;
            this.button1.Text = "タックシール印刷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 55);
            this.button2.TabIndex = 157;
            this.button2.Text = "検査啓発推進費";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(501, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 55);
            this.button3.TabIndex = 158;
            this.button3.Text = "検査状況一覧";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(658, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 55);
            this.button4.TabIndex = 159;
            this.button4.Text = "検査員月報";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(658, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 55);
            this.button5.TabIndex = 160;
            this.button5.Text = "検査員週報";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(501, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 55);
            this.button6.TabIndex = 161;
            this.button6.Text = "浄化槽台帳集計";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(501, 155);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 55);
            this.button7.TabIndex = 162;
            this.button7.Text = "塩化物イオン濃度 比較一覧";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // OthersMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileKanriListButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OthersMenuForm";
            this.Text = "機能選択";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FileKanriListButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}