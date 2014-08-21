namespace FukjBizSystem.Application.Boundary.Keiri
{
    partial class SeikyuShimeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.suishitsuCdToTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.suishitsuCdFromTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SrhDtFromTextBox = new Zynas.Control.ZDate(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NyukinDtTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.ShisyoNmComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.entryButton.Text = "F1:締め処理";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ShisyoNmComboBox);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.checkBox1);
            this.mainPanel.Controls.Add(this.suishitsuCdToTextBox);
            this.mainPanel.Controls.Add(this.suishitsuCdFromTextBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label19);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.SrhDtFromTextBox);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label17);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 169;
            this.label3.Text = "請求締済扱い";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(115, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 24);
            this.checkBox1.TabIndex = 168;
            this.checkBox1.Text = "再作成する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // suishitsuCdToTextBox
            // 
            this.suishitsuCdToTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.suishitsuCdToTextBox.CustomDigitParts = 0;
            this.suishitsuCdToTextBox.CustomFormat = null;
            this.suishitsuCdToTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.Int;
            this.suishitsuCdToTextBox.CustomReadOnly = false;
            this.suishitsuCdToTextBox.Location = new System.Drawing.Point(218, 88);
            this.suishitsuCdToTextBox.MaxLength = 6;
            this.suishitsuCdToTextBox.Name = "suishitsuCdToTextBox";
            this.suishitsuCdToTextBox.Size = new System.Drawing.Size(51, 27);
            this.suishitsuCdToTextBox.TabIndex = 167;
            this.suishitsuCdToTextBox.Text = "2345";
            // 
            // suishitsuCdFromTextBox
            // 
            this.suishitsuCdFromTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.suishitsuCdFromTextBox.CustomDigitParts = 0;
            this.suishitsuCdFromTextBox.CustomFormat = null;
            this.suishitsuCdFromTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.Int;
            this.suishitsuCdFromTextBox.CustomReadOnly = false;
            this.suishitsuCdFromTextBox.Location = new System.Drawing.Point(115, 88);
            this.suishitsuCdFromTextBox.MaxLength = 6;
            this.suishitsuCdFromTextBox.Name = "suishitsuCdFromTextBox";
            this.suishitsuCdFromTextBox.Size = new System.Drawing.Size(51, 27);
            this.suishitsuCdFromTextBox.TabIndex = 165;
            this.suishitsuCdFromTextBox.Text = "1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "～";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 20);
            this.label19.TabIndex = 164;
            this.label19.Text = "業者コード";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(453, 22);
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
            this.label2.Text = "請求日";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(202, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 20);
            this.label17.TabIndex = 143;
            this.label17.Text = "例)201401 (半角)";
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
            this.label11.Text = "締め年月";
            // 
            // NyukinDtTextBox
            // 
            this.NyukinDtTextBox.Location = new System.Drawing.Point(115, 22);
            this.NyukinDtTextBox.MaxLength = 8;
            this.NyukinDtTextBox.Name = "NyukinDtTextBox";
            this.NyukinDtTextBox.Size = new System.Drawing.Size(81, 27);
            this.NyukinDtTextBox.TabIndex = 140;
            this.NyukinDtTextBox.Text = "201407";
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
            // ShisyoNmComboBox
            // 
            this.ShisyoNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShisyoNmComboBox.FormattingEnabled = true;
            this.ShisyoNmComboBox.Location = new System.Drawing.Point(115, 121);
            this.ShisyoNmComboBox.Name = "ShisyoNmComboBox";
            this.ShisyoNmComboBox.Size = new System.Drawing.Size(191, 28);
            this.ShisyoNmComboBox.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 172;
            this.label5.Text = "支所";
            // 
            // SeikyuShimeForm
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
            this.Name = "SeikyuShimeForm";
            this.Text = "請求締め処理";
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NyukinDtTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Zynas.Control.ZDate SrhDtFromTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private Control.NumberTextBox suishitsuCdToTextBox;
        private Control.NumberTextBox suishitsuCdFromTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ShisyoNmComboBox;
        private System.Windows.Forms.Label label5;
    }
}