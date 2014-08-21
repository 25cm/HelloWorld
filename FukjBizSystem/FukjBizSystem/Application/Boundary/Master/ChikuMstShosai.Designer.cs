namespace FukjBizSystem.Application.Boundary.Master
{
    partial class ChikuMstShosaiForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.suishitsuTantoShishoNmComboBox = new System.Windows.Forms.ComboBox();
            this.hoteiTantoShishoNmComboBox = new System.Windows.Forms.ComboBox();
            this.kankatsuHokenjoNmComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gaikanChikuwari2CdTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gaikanChikuwariCdTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chikuRyakushoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chikuNmTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.entryButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.decisionButton = new System.Windows.Forms.Button();
            this.reInputButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.keyCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gappeigoChikuCdTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.kankatsuHokenjoCdTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.chikuCdTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 131;
            this.label4.Text = "地区コード";
            // 
            // suishitsuTantoShishoNmComboBox
            // 
            this.suishitsuTantoShishoNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suishitsuTantoShishoNmComboBox.FormattingEnabled = true;
            this.suishitsuTantoShishoNmComboBox.Location = new System.Drawing.Point(140, 172);
            this.suishitsuTantoShishoNmComboBox.Name = "suishitsuTantoShishoNmComboBox";
            this.suishitsuTantoShishoNmComboBox.Size = new System.Drawing.Size(206, 28);
            this.suishitsuTantoShishoNmComboBox.TabIndex = 114;
            // 
            // hoteiTantoShishoNmComboBox
            // 
            this.hoteiTantoShishoNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoteiTantoShishoNmComboBox.FormattingEnabled = true;
            this.hoteiTantoShishoNmComboBox.Location = new System.Drawing.Point(140, 139);
            this.hoteiTantoShishoNmComboBox.Name = "hoteiTantoShishoNmComboBox";
            this.hoteiTantoShishoNmComboBox.Size = new System.Drawing.Size(206, 28);
            this.hoteiTantoShishoNmComboBox.TabIndex = 113;
            // 
            // kankatsuHokenjoNmComboBox
            // 
            this.kankatsuHokenjoNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kankatsuHokenjoNmComboBox.FormattingEnabled = true;
            this.kankatsuHokenjoNmComboBox.Location = new System.Drawing.Point(194, 105);
            this.kankatsuHokenjoNmComboBox.Name = "kankatsuHokenjoNmComboBox";
            this.kankatsuHokenjoNmComboBox.Size = new System.Drawing.Size(402, 28);
            this.kankatsuHokenjoNmComboBox.TabIndex = 112;
            this.kankatsuHokenjoNmComboBox.SelectedIndexChanged += new System.EventHandler(this.kankatsuHokenjoNmComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 130;
            this.label9.Text = "合併後地区コード";
            // 
            // gaikanChikuwari2CdTextBox
            // 
            this.gaikanChikuwari2CdTextBox.Location = new System.Drawing.Point(140, 239);
            this.gaikanChikuwari2CdTextBox.MaxLength = 1;
            this.gaikanChikuwari2CdTextBox.Name = "gaikanChikuwari2CdTextBox";
            this.gaikanChikuwari2CdTextBox.Size = new System.Drawing.Size(48, 27);
            this.gaikanChikuwari2CdTextBox.TabIndex = 116;
            this.gaikanChikuwari2CdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gaikanChikuwariCdTextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 129;
            this.label8.Text = "外観地区割Ⅱ";
            // 
            // gaikanChikuwariCdTextBox
            // 
            this.gaikanChikuwariCdTextBox.Location = new System.Drawing.Point(140, 206);
            this.gaikanChikuwariCdTextBox.MaxLength = 1;
            this.gaikanChikuwariCdTextBox.Name = "gaikanChikuwariCdTextBox";
            this.gaikanChikuwariCdTextBox.Size = new System.Drawing.Size(48, 27);
            this.gaikanChikuwariCdTextBox.TabIndex = 115;
            this.gaikanChikuwariCdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gaikanChikuwariCdTextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 128;
            this.label7.Text = "外観地区割";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 127;
            this.label6.Text = "水質担当支所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 126;
            this.label1.Text = "法定担当支所";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 125;
            this.label2.Text = "管轄保健所";
            // 
            // chikuRyakushoTextBox
            // 
            this.chikuRyakushoTextBox.Location = new System.Drawing.Point(140, 72);
            this.chikuRyakushoTextBox.MaxLength = 10;
            this.chikuRyakushoTextBox.Name = "chikuRyakushoTextBox";
            this.chikuRyakushoTextBox.Size = new System.Drawing.Size(186, 27);
            this.chikuRyakushoTextBox.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "地区略称";
            // 
            // chikuNmTextBox
            // 
            this.chikuNmTextBox.Location = new System.Drawing.Point(140, 39);
            this.chikuNmTextBox.MaxLength = 20;
            this.chikuNmTextBox.Name = "chikuNmTextBox";
            this.chikuNmTextBox.Size = new System.Drawing.Size(332, 27);
            this.chikuNmTextBox.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 123;
            this.label10.Text = "地区名称";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(415, 543);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(101, 37);
            this.entryButton.TabIndex = 118;
            this.entryButton.Text = "F1:登録";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(522, 543);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(101, 37);
            this.changeButton.TabIndex = 119;
            this.changeButton.Text = "F2:変更";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(843, 543);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(101, 37);
            this.decisionButton.TabIndex = 122;
            this.decisionButton.Text = "F5:確定";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // reInputButton
            // 
            this.reInputButton.Location = new System.Drawing.Point(736, 543);
            this.reInputButton.Name = "reInputButton";
            this.reInputButton.Size = new System.Drawing.Size(101, 37);
            this.reInputButton.TabIndex = 121;
            this.reInputButton.Text = "F4:再入力";
            this.reInputButton.UseVisualStyleBackColor = true;
            this.reInputButton.Click += new System.EventHandler(this.reInputButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(629, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.TabIndex = 120;
            this.deleteButton.Text = "F3:削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(985, 543);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 37);
            this.closeButton.TabIndex = 132;
            this.closeButton.Text = "F12:閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // keyCode
            // 
            this.keyCode.AutoSize = true;
            this.keyCode.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyCode.ForeColor = System.Drawing.Color.Red;
            this.keyCode.Location = new System.Drawing.Point(82, 9);
            this.keyCode.Name = "keyCode";
            this.keyCode.Size = new System.Drawing.Size(17, 20);
            this.keyCode.TabIndex = 154;
            this.keyCode.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(69, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 154;
            this.label5.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(69, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 154;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(84, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 20);
            this.label12.TabIndex = 154;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(96, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 20);
            this.label13.TabIndex = 154;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(95, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 20);
            this.label14.TabIndex = 154;
            this.label14.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(120, 276);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 20);
            this.label17.TabIndex = 154;
            this.label17.Text = "*";
            // 
            // gappeigoChikuCdTextBox
            // 
            this.gappeigoChikuCdTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.gappeigoChikuCdTextBox.CustomDigitParts = 0;
            this.gappeigoChikuCdTextBox.CustomFormat = null;
            this.gappeigoChikuCdTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.gappeigoChikuCdTextBox.CustomReadOnly = false;
            this.gappeigoChikuCdTextBox.Location = new System.Drawing.Point(140, 272);
            this.gappeigoChikuCdTextBox.MaxLength = 5;
            this.gappeigoChikuCdTextBox.Name = "gappeigoChikuCdTextBox";
            this.gappeigoChikuCdTextBox.Size = new System.Drawing.Size(48, 27);
            this.gappeigoChikuCdTextBox.TabIndex = 117;
            // 
            // kankatsuHokenjoCdTextBox
            // 
            this.kankatsuHokenjoCdTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.kankatsuHokenjoCdTextBox.CustomDigitParts = 0;
            this.kankatsuHokenjoCdTextBox.CustomFormat = null;
            this.kankatsuHokenjoCdTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.kankatsuHokenjoCdTextBox.CustomReadOnly = false;
            this.kankatsuHokenjoCdTextBox.Location = new System.Drawing.Point(140, 105);
            this.kankatsuHokenjoCdTextBox.MaxLength = 2;
            this.kankatsuHokenjoCdTextBox.Name = "kankatsuHokenjoCdTextBox";
            this.kankatsuHokenjoCdTextBox.Size = new System.Drawing.Size(48, 27);
            this.kankatsuHokenjoCdTextBox.TabIndex = 111;
            this.kankatsuHokenjoCdTextBox.Leave += new System.EventHandler(this.kankatsuHokenjoCdTextBox_Leave);
            // 
            // chikuCdTextBox
            // 
            this.chikuCdTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.chikuCdTextBox.CustomDigitParts = 0;
            this.chikuCdTextBox.CustomFormat = null;
            this.chikuCdTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.chikuCdTextBox.CustomReadOnly = false;
            this.chikuCdTextBox.Location = new System.Drawing.Point(140, 6);
            this.chikuCdTextBox.MaxLength = 5;
            this.chikuCdTextBox.Name = "chikuCdTextBox";
            this.chikuCdTextBox.Size = new System.Drawing.Size(48, 27);
            this.chikuCdTextBox.TabIndex = 108;
            // 
            // ChikuMstShosaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 868);
            this.Controls.Add(this.gappeigoChikuCdTextBox);
            this.Controls.Add(this.kankatsuHokenjoCdTextBox);
            this.Controls.Add(this.chikuCdTextBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyCode);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.suishitsuTantoShishoNmComboBox);
            this.Controls.Add(this.hoteiTantoShishoNmComboBox);
            this.Controls.Add(this.kankatsuHokenjoNmComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gaikanChikuwari2CdTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gaikanChikuwariCdTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chikuRyakushoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chikuNmTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.entryButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.decisionButton);
            this.Controls.Add(this.reInputButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ChikuMstShosaiForm";
            this.Text = "ChikuMstShosai";
            this.Load += new System.EventHandler(this.ChikuMstShosaiForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChikuMstShosaiForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox suishitsuTantoShishoNmComboBox;
        private System.Windows.Forms.ComboBox hoteiTantoShishoNmComboBox;
        private System.Windows.Forms.ComboBox kankatsuHokenjoNmComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox gaikanChikuwari2CdTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox gaikanChikuwariCdTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chikuRyakushoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox chikuNmTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.Button reInputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label keyCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private Control.NumberTextBox chikuCdTextBox;
        private Control.NumberTextBox gappeigoChikuCdTextBox;
        private Control.NumberTextBox kankatsuHokenjoCdTextBox;
    }
}