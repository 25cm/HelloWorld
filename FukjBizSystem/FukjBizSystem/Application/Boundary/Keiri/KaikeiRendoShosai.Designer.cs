namespace FukjBizSystem.Application.Boundary.Keiri
{
    partial class KaikeiRendoShosaiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.changeButton = new System.Windows.Forms.Button();
            this.decisionButton = new System.Windows.Forms.Button();
            this.reInputButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.numberTextBox1 = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.NyukinListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bukaiRenbanCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BukaiKaiinCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukaiNyukaiDtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukaiMenJoNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukaiKankeiHokenjo1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NyukinListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(326, 543);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(101, 37);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "F2:変更";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(647, 543);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(101, 37);
            this.decisionButton.TabIndex = 13;
            this.decisionButton.Text = "F5:確定";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.DecisionButton_Click);
            // 
            // reInputButton
            // 
            this.reInputButton.Location = new System.Drawing.Point(540, 543);
            this.reInputButton.Name = "reInputButton";
            this.reInputButton.Size = new System.Drawing.Size(101, 37);
            this.reInputButton.TabIndex = 12;
            this.reInputButton.Text = "F4:再入力";
            this.reInputButton.UseVisualStyleBackColor = true;
            this.reInputButton.Click += new System.EventHandler(this.ReInputButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(433, 543);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "F3:削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.textBox5);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.radioButton3);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.textBox4);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.radioButton1);
            this.mainPanel.Controls.Add(this.radioButton2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.textBox3);
            this.mainPanel.Controls.Add(this.textBox2);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.checkBox4);
            this.mainPanel.Controls.Add(this.checkBox3);
            this.mainPanel.Controls.Add(this.checkBox2);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.checkBox1);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.numberTextBox1);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.NyukinListDataGridView);
            this.mainPanel.Controls.Add(this.changeButton);
            this.mainPanel.Controls.Add(this.decisionButton);
            this.mainPanel.Controls.Add(this.reInputButton);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Location = new System.Drawing.Point(2, 1);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1103, 580);
            this.mainPanel.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(238, 171);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 24);
            this.radioButton3.TabIndex = 233;
            this.radioButton3.Text = "却下";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(881, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 232;
            this.button2.Text = "F7:会計連動";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 231;
            this.textBox4.Text = "差分";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(81, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 20);
            this.label4.TabIndex = 230;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 229;
            this.label3.Text = "承認区分";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(176, 171);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 24);
            this.radioButton1.TabIndex = 228;
            this.radioButton1.Text = "承認";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 24);
            this.radioButton2.TabIndex = 227;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "未承認";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 226;
            this.label1.Text = "～";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 225;
            this.textBox3.Text = "2014/07/01";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 224;
            this.textBox2.Text = "2014/07/31";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 223;
            this.textBox1.Text = "入金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 222;
            this.label2.Text = "対象区分";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 219;
            this.label8.Text = "作成範囲";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(284, 111);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(54, 24);
            this.checkBox4.TabIndex = 216;
            this.checkBox4.Text = "支払";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(224, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(54, 24);
            this.checkBox3.TabIndex = 215;
            this.checkBox3.Text = "現金";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(164, 111);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 24);
            this.checkBox2.TabIndex = 214;
            this.checkBox2.Text = "銀行";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 212;
            this.label6.Text = "作成対象";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(104, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 24);
            this.checkBox1.TabIndex = 211;
            this.checkBox1.Text = "郵便";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 210;
            this.label9.Text = "対象期間";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(774, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 208;
            this.button1.Text = "F6:伺書印刷";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(839, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 50);
            this.panel1.TabIndex = 192;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(13, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 41);
            this.label12.TabIndex = 0;
            this.label12.Text = "MockUp";
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.numberTextBox1.CustomDigitParts = 0;
            this.numberTextBox1.CustomFormat = null;
            this.numberTextBox1.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.Int;
            this.numberTextBox1.CustomReadOnly = false;
            this.numberTextBox1.Location = new System.Drawing.Point(104, 11);
            this.numberTextBox1.MaxLength = 6;
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.ReadOnly = true;
            this.numberTextBox1.Size = new System.Drawing.Size(98, 27);
            this.numberTextBox1.TabIndex = 153;
            this.numberTextBox1.Text = "2014000001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 152;
            this.label5.Text = "会計No";
            // 
            // NyukinListDataGridView
            // 
            this.NyukinListDataGridView.AllowUserToAddRows = false;
            this.NyukinListDataGridView.AllowUserToDeleteRows = false;
            this.NyukinListDataGridView.AllowUserToResizeRows = false;
            this.NyukinListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NyukinListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NyukinListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.bukaiRenbanCol,
            this.Column1,
            this.BukaiKaiinCdCol,
            this.bukaiNyukaiDtCol,
            this.bukaiMenJoNoCol,
            this.Column2,
            this.Column11,
            this.bukaiKankeiHokenjo1Col,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column12,
            this.Column9,
            this.Column10});
            this.NyukinListDataGridView.Location = new System.Drawing.Point(8, 201);
            this.NyukinListDataGridView.Name = "NyukinListDataGridView";
            this.NyukinListDataGridView.RowHeadersVisible = false;
            this.NyukinListDataGridView.RowHeadersWidth = 30;
            this.NyukinListDataGridView.RowTemplate.Height = 21;
            this.NyukinListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.NyukinListDataGridView.Size = new System.Drawing.Size(1081, 336);
            this.NyukinListDataGridView.TabIndex = 147;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "出力";
            this.Column3.MinimumWidth = 65;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 65;
            // 
            // bukaiRenbanCol
            // 
            this.bukaiRenbanCol.DataPropertyName = "BukaiRenban";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bukaiRenbanCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.bukaiRenbanCol.HeaderText = "連番";
            this.bukaiRenbanCol.MinimumWidth = 60;
            this.bukaiRenbanCol.Name = "bukaiRenbanCol";
            this.bukaiRenbanCol.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "借方事業ｺｰﾄﾞ";
            this.Column1.MinimumWidth = 80;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // BukaiKaiinCdCol
            // 
            this.BukaiKaiinCdCol.DataPropertyName = "BukaiKaiinCd";
            this.BukaiKaiinCdCol.HeaderText = "借方科目ｺｰﾄﾞ";
            this.BukaiKaiinCdCol.MinimumWidth = 80;
            this.BukaiKaiinCdCol.Name = "BukaiKaiinCdCol";
            this.BukaiKaiinCdCol.Width = 80;
            // 
            // bukaiNyukaiDtCol
            // 
            this.bukaiNyukaiDtCol.DataPropertyName = "BukaiNyukaiDt";
            this.bukaiNyukaiDtCol.HeaderText = "借方科目名";
            this.bukaiNyukaiDtCol.MinimumWidth = 120;
            this.bukaiNyukaiDtCol.Name = "bukaiNyukaiDtCol";
            this.bukaiNyukaiDtCol.Width = 120;
            // 
            // bukaiMenJoNoCol
            // 
            this.bukaiMenJoNoCol.DataPropertyName = "BukaiMenJoNo";
            this.bukaiMenJoNoCol.HeaderText = "借方補助ｺｰﾄﾞ";
            this.bukaiMenJoNoCol.MinimumWidth = 80;
            this.bukaiMenJoNoCol.Name = "bukaiMenJoNoCol";
            this.bukaiMenJoNoCol.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "借方補助名";
            this.Column2.MinimumWidth = 120;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "借方税区分";
            this.Column11.MinimumWidth = 75;
            this.Column11.Name = "Column11";
            this.Column11.Width = 75;
            // 
            // bukaiKankeiHokenjo1Col
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bukaiKankeiHokenjo1Col.DefaultCellStyle = dataGridViewCellStyle2;
            this.bukaiKankeiHokenjo1Col.HeaderText = "借方金額";
            this.bukaiKankeiHokenjo1Col.MinimumWidth = 100;
            this.bukaiKankeiHokenjo1Col.Name = "bukaiKankeiHokenjo1Col";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "貸方事業ｺｰﾄﾞ";
            this.Column7.MinimumWidth = 80;
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "貸方科目ｺｰﾄﾞ";
            this.Column4.MinimumWidth = 80;
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "貸方科目名";
            this.Column5.MinimumWidth = 120;
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "貸方補助ｺｰﾄﾞ";
            this.Column6.MinimumWidth = 80;
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "貸方補助名";
            this.Column8.MinimumWidth = 120;
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "貸方税区分";
            this.Column12.MinimumWidth = 75;
            this.Column12.Name = "Column12";
            this.Column12.Width = 75;
            // 
            // Column9
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.HeaderText = "貸方金額";
            this.Column9.MinimumWidth = 100;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "摘要";
            this.Column10.MinimumWidth = 120;
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(311, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 27);
            this.textBox5.TabIndex = 235;
            this.textBox5.Text = "福　岡";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 234;
            this.label7.Text = "対象支所";
            // 
            // KaikeiRendoShosaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KaikeiRendoShosaiForm";
            this.Text = "出納データ詳細";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NyukinListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.Button reInputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView NyukinListDataGridView;
        private Control.NumberTextBox numberTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukaiRenbanCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BukaiKaiinCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukaiNyukaiDtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukaiMenJoNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukaiKankeiHokenjo1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
    }
}