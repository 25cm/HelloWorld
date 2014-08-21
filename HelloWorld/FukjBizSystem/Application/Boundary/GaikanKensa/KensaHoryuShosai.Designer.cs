namespace FukjBizSystem.Application.Boundary.GaikanKensa
{
    partial class KensaHoryuShosaiForm
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
            this.KinyuNmComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FurikomiNmTextBox = new System.Windows.Forms.TextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.reInputButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.From1TextBox = new System.Windows.Forms.TextBox();
            this.RenzokuGroupBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FurikomiKanaTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.RenzokuGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KinyuNmComboBox
            // 
            this.KinyuNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KinyuNmComboBox.FormattingEnabled = true;
            this.KinyuNmComboBox.Items.AddRange(new object[] {
            "筑　豊",
            "筑　後",
            "福　岡"});
            this.KinyuNmComboBox.Location = new System.Drawing.Point(119, 88);
            this.KinyuNmComboBox.Name = "KinyuNmComboBox";
            this.KinyuNmComboBox.Size = new System.Drawing.Size(191, 28);
            this.KinyuNmComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "設置者名";
            // 
            // FurikomiNmTextBox
            // 
            this.FurikomiNmTextBox.Location = new System.Drawing.Point(119, 55);
            this.FurikomiNmTextBox.MaxLength = 20;
            this.FurikomiNmTextBox.Name = "FurikomiNmTextBox";
            this.FurikomiNmTextBox.ReadOnly = true;
            this.FurikomiNmTextBox.Size = new System.Drawing.Size(448, 27);
            this.FurikomiNmTextBox.TabIndex = 8;
            this.FurikomiNmTextBox.Text = "浄化槽太郎";
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(35, 543);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(101, 37);
            this.entryButton.TabIndex = 9;
            this.entryButton.Text = "F1:更新";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // reInputButton
            // 
            this.reInputButton.Location = new System.Drawing.Point(249, 543);
            this.reInputButton.Name = "reInputButton";
            this.reInputButton.Size = new System.Drawing.Size(179, 37);
            this.reInputButton.TabIndex = 12;
            this.reInputButton.Text = "F5:状況把握票作成・編集";
            this.reInputButton.UseVisualStyleBackColor = true;
            this.reInputButton.Click += new System.EventHandler(this.ReInputButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(142, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "F3:保留取消";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label30);
            this.mainPanel.Controls.Add(this.label31);
            this.mainPanel.Controls.Add(this.dateTimePicker2);
            this.mainPanel.Controls.Add(this.label29);
            this.mainPanel.Controls.Add(this.label28);
            this.mainPanel.Controls.Add(this.dateTimePicker1);
            this.mainPanel.Controls.Add(this.label27);
            this.mainPanel.Controls.Add(this.comboBox2);
            this.mainPanel.Controls.Add(this.label26);
            this.mainPanel.Controls.Add(this.comboBox1);
            this.mainPanel.Controls.Add(this.textBox2);
            this.mainPanel.Controls.Add(this.label21);
            this.mainPanel.Controls.Add(this.textBox3);
            this.mainPanel.Controls.Add(this.label22);
            this.mainPanel.Controls.Add(this.From1TextBox);
            this.mainPanel.Controls.Add(this.RenzokuGroupBox);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label14);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.FurikomiKanaTextBox);
            this.mainPanel.Controls.Add(this.label19);
            this.mainPanel.Controls.Add(this.KinyuNmComboBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.FurikomiNmTextBox);
            this.mainPanel.Controls.Add(this.entryButton);
            this.mainPanel.Controls.Add(this.reInputButton);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Location = new System.Drawing.Point(2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1103, 580);
            this.mainPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 37);
            this.button2.TabIndex = 196;
            this.button2.Text = "F8:現況報告書の削除";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(619, 543);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 37);
            this.button3.TabIndex = 195;
            this.button3.Text = "F7:現況報告書作成・編集";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 37);
            this.button1.TabIndex = 194;
            this.button1.Text = "F6:状況把握票の削除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(96, 282);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(17, 20);
            this.label30.TabIndex = 193;
            this.label30.Text = "*";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(21, 274);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(61, 20);
            this.label31.TabIndex = 192;
            this.label31.Text = "次回確認";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(119, 277);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 27);
            this.dateTimePicker2.TabIndex = 191;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Red;
            this.label29.Location = new System.Drawing.Point(96, 249);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(17, 20);
            this.label29.TabIndex = 190;
            this.label29.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(21, 249);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 20);
            this.label28.TabIndex = 189;
            this.label28.Text = "確認日";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 27);
            this.dateTimePicker1.TabIndex = 188;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(21, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 20);
            this.label27.TabIndex = 187;
            this.label27.Text = "保留の理由";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "未建築",
            "建築中",
            "３ヶ月未満",
            "６ヶ月未満",
            "未入居",
            "その他"});
            this.comboBox2.Location = new System.Drawing.Point(119, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(333, 28);
            this.comboBox2.TabIndex = 186;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 125);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 20);
            this.label26.TabIndex = 185;
            this.label26.Text = "担当検査員";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "検査員太郎",
            "検査員次郎"});
            this.comboBox1.Location = new System.Drawing.Point(119, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 28);
            this.comboBox1.TabIndex = 184;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 22);
            this.textBox2.MaxLength = 6;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 27);
            this.textBox2.TabIndex = 183;
            this.textBox2.Text = "123456";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(196, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 20);
            this.label21.TabIndex = 182;
            this.label21.Text = "－";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(168, 22);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(31, 27);
            this.textBox3.TabIndex = 181;
            this.textBox3.Text = "20";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(150, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 20);
            this.label22.TabIndex = 180;
            this.label22.Text = "－";
            // 
            // From1TextBox
            // 
            this.From1TextBox.Location = new System.Drawing.Point(119, 22);
            this.From1TextBox.MaxLength = 2;
            this.From1TextBox.Name = "From1TextBox";
            this.From1TextBox.ReadOnly = true;
            this.From1TextBox.Size = new System.Drawing.Size(31, 27);
            this.From1TextBox.TabIndex = 179;
            this.From1TextBox.Text = "01";
            // 
            // RenzokuGroupBox
            // 
            this.RenzokuGroupBox.Controls.Add(this.label15);
            this.RenzokuGroupBox.Controls.Add(this.comboBox5);
            this.RenzokuGroupBox.Controls.Add(this.label5);
            this.RenzokuGroupBox.Controls.Add(this.comboBox3);
            this.RenzokuGroupBox.Controls.Add(this.label13);
            this.RenzokuGroupBox.Controls.Add(this.comboBox4);
            this.RenzokuGroupBox.Location = new System.Drawing.Point(25, 326);
            this.RenzokuGroupBox.Name = "RenzokuGroupBox";
            this.RenzokuGroupBox.Size = new System.Drawing.Size(448, 137);
            this.RenzokuGroupBox.TabIndex = 178;
            this.RenzokuGroupBox.TabStop = false;
            this.RenzokuGroupBox.Text = "新規作成時起票者";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 191;
            this.label15.Text = "起票者";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "検査員太郎",
            "検査員次郎"});
            this.comboBox5.Location = new System.Drawing.Point(111, 94);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(191, 28);
            this.comboBox5.TabIndex = 190;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 189;
            this.label5.Text = "所属部署";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "法定検査課"});
            this.comboBox3.Location = new System.Drawing.Point(111, 60);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 28);
            this.comboBox3.TabIndex = 188;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 187;
            this.label13.Text = "所属支所";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "筑　豊",
            "筑　後",
            "福　岡"});
            this.comboBox4.Location = new System.Drawing.Point(111, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(191, 28);
            this.comboBox4.TabIndex = 186;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label34);
            this.panel1.Location = new System.Drawing.Point(846, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 50);
            this.panel1.TabIndex = 172;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label34.Location = new System.Drawing.Point(13, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(121, 41);
            this.label34.TabIndex = 0;
            this.label34.Text = "MockUp";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 153;
            this.label14.Text = "期限日";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 150;
            this.label12.Text = "保留内容";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(96, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 148;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 147;
            this.label9.Text = "受付支所";
            // 
            // FurikomiKanaTextBox
            // 
            this.FurikomiKanaTextBox.Location = new System.Drawing.Point(119, 190);
            this.FurikomiKanaTextBox.MaxLength = 80;
            this.FurikomiKanaTextBox.Multiline = true;
            this.FurikomiKanaTextBox.Name = "FurikomiKanaTextBox";
            this.FurikomiKanaTextBox.Size = new System.Drawing.Size(470, 48);
            this.FurikomiKanaTextBox.TabIndex = 149;
            this.FurikomiKanaTextBox.Text = "Ｈ２３年度内に計画の一部建物が建築予定。";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "協会No";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(988, 543);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 37);
            this.closeButton.TabIndex = 14;
            this.closeButton.Text = "F12:閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // KensaHoryuShosaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KensaHoryuShosaiForm";
            this.Text = "７条検査保留情報";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.RenzokuGroupBox.ResumeLayout(false);
            this.RenzokuGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox KinyuNmComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FurikomiNmTextBox;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button reInputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FurikomiKanaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.GroupBox RenzokuGroupBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox From1TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}