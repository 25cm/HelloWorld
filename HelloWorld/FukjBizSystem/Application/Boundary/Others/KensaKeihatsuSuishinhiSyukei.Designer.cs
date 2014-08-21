namespace FukjBizSystem.Application.Boundary.Others
{
    partial class KensaKeihatsuSuishinhiSyukeiForm
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
            this.entryButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SrhDtFromTextBox = new Zynas.Control.ZDate(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NyukinDtTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.ShimokiRadioButton = new System.Windows.Forms.RadioButton();
            this.KamikiRadioButton = new System.Windows.Forms.RadioButton();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(391, 366);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(101, 37);
            this.entryButton.TabIndex = 9;
            this.entryButton.Text = "F1:集計";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ShimokiRadioButton);
            this.mainPanel.Controls.Add(this.KamikiRadioButton);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.SrhDtFromTextBox);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.NyukinDtTextBox);
            this.mainPanel.Controls.Add(this.entryButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Location = new System.Drawing.Point(2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(620, 406);
            this.mainPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 171;
            this.label4.Text = "処理メッセージ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(21, 209);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(591, 146);
            this.textBox1.TabIndex = 170;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(453, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 50);
            this.panel1.TabIndex = 163;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 159;
            this.label2.Text = "支払日";
            // 
            // SrhDtFromTextBox
            // 
            this.SrhDtFromTextBox.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SrhDtFromTextBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SrhDtFromTextBox.Location = new System.Drawing.Point(115, 55);
            this.SrhDtFromTextBox.Name = "SrhDtFromTextBox";
            this.SrhDtFromTextBox.Size = new System.Drawing.Size(113, 27);
            this.SrhDtFromTextBox.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(92, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 146;
            this.label7.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(92, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 142;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 141;
            this.label11.Text = "集計年度";
            // 
            // NyukinDtTextBox
            // 
            this.NyukinDtTextBox.Location = new System.Drawing.Point(115, 22);
            this.NyukinDtTextBox.MaxLength = 8;
            this.NyukinDtTextBox.Name = "NyukinDtTextBox";
            this.NyukinDtTextBox.Size = new System.Drawing.Size(45, 27);
            this.NyukinDtTextBox.TabIndex = 140;
            this.NyukinDtTextBox.Text = "2014";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(512, 366);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 37);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "F12:閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ShimokiRadioButton
            // 
            this.ShimokiRadioButton.AutoSize = true;
            this.ShimokiRadioButton.Location = new System.Drawing.Point(301, 23);
            this.ShimokiRadioButton.Name = "ShimokiRadioButton";
            this.ShimokiRadioButton.Size = new System.Drawing.Size(128, 24);
            this.ShimokiRadioButton.TabIndex = 173;
            this.ShimokiRadioButton.Text = "下期(10月～3月)";
            this.ShimokiRadioButton.UseVisualStyleBackColor = true;
            // 
            // KamikiRadioButton
            // 
            this.KamikiRadioButton.AutoSize = true;
            this.KamikiRadioButton.Checked = true;
            this.KamikiRadioButton.Location = new System.Drawing.Point(175, 23);
            this.KamikiRadioButton.Name = "KamikiRadioButton";
            this.KamikiRadioButton.Size = new System.Drawing.Size(120, 24);
            this.KamikiRadioButton.TabIndex = 172;
            this.KamikiRadioButton.TabStop = true;
            this.KamikiRadioButton.Text = "上期(4月～9月)";
            this.KamikiRadioButton.UseVisualStyleBackColor = true;
            // 
            // KensaKeihatsuSuishinhiSyukeiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 419);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KensaKeihatsuSuishinhiSyukeiForm";
            this.Text = "検査啓発推進費集計";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NyukinDtTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Zynas.Control.ZDate SrhDtFromTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton ShimokiRadioButton;
        private System.Windows.Forms.RadioButton KamikiRadioButton;
    }
}