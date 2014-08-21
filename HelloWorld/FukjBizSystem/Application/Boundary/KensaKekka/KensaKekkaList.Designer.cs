namespace FukjBizSystem.Application.Boundary.KensaKekka
{
    partial class KensaKekkaListForm
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
            this.kekkaListDataGridView = new System.Windows.Forms.DataGridView();
            this.kekkasyoButton = new System.Windows.Forms.Button();
            this.kekkaListPanel = new System.Windows.Forms.Panel();
            this.kekkaListCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.faxMkButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.settisyaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewChangeButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.kensaKbnComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.kensaDtUseCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kensaDtToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.kensaDtFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shisetsuNmTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hokenjoComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.kensaIraiDtUseCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.kensaIraiDtToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.kensaIraiDtFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.tojiruButton = new System.Windows.Forms.Button();
            this.faxHosyuButton = new System.Windows.Forms.Button();
            this.faxKojiButton = new System.Windows.Forms.Button();
            this.faxHokenButton = new System.Windows.Forms.Button();
            this.iraiNendoTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.kensaIraiTblDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kensaIraiTblDataSet = new FukjBizSystem.Application.DataSet.KensaIraiTblDataSet();
            this.KbnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HokenjoCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HokenjoNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NendoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenbanNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KensaIraiDtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KensaDtCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettisyaNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShisetsuNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettibasyoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanteiCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KensaIraiHoteiKbnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiNendoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiRenbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hokenjoNmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaKekkaHanteiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kekkaListDataGridView)).BeginInit();
            this.kekkaListPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kensaIraiTblDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kensaIraiTblDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // kekkaListDataGridView
            // 
            this.kekkaListDataGridView.AllowUserToAddRows = false;
            this.kekkaListDataGridView.AllowUserToDeleteRows = false;
            this.kekkaListDataGridView.AllowUserToResizeRows = false;
            this.kekkaListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kekkaListDataGridView.AutoGenerateColumns = false;
            this.kekkaListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kekkaListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KbnCol,
            this.HokenjoCdCol,
            this.HokenjoNmCol,
            this.NendoCol,
            this.RenbanNoCol,
            this.KensaIraiDtCol,
            this.KensaDtCol,
            this.SettisyaNmCol,
            this.ShisetsuNmCol,
            this.SettibasyoCol,
            this.HanteiCol,
            this.KensaIraiHoteiKbnCol,
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn,
            this.kensaIraiNendoDataGridViewTextBoxColumn,
            this.kensaIraiRenbanDataGridViewTextBoxColumn,
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn,
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn,
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn,
            this.hokenjoNmDataGridViewTextBoxColumn,
            this.kensaKekkaHanteiDataGridViewTextBoxColumn});
            this.kekkaListDataGridView.DataMember = "KensaIraiTblKensaku";
            this.kekkaListDataGridView.DataSource = this.kensaIraiTblDataSetBindingSource;
            this.kekkaListDataGridView.Location = new System.Drawing.Point(2, 24);
            this.kekkaListDataGridView.MultiSelect = false;
            this.kekkaListDataGridView.Name = "kekkaListDataGridView";
            this.kekkaListDataGridView.ReadOnly = true;
            this.kekkaListDataGridView.RowHeadersVisible = false;
            this.kekkaListDataGridView.RowTemplate.Height = 21;
            this.kekkaListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kekkaListDataGridView.Size = new System.Drawing.Size(1085, 312);
            this.kekkaListDataGridView.TabIndex = 1;
            this.kekkaListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kekkaListDataGridView_CellDoubleClick);
            // 
            // kekkasyoButton
            // 
            this.kekkasyoButton.Location = new System.Drawing.Point(168, 544);
            this.kekkasyoButton.Name = "kekkasyoButton";
            this.kekkasyoButton.Size = new System.Drawing.Size(101, 37);
            this.kekkasyoButton.TabIndex = 2;
            this.kekkasyoButton.Text = "F1:結果書";
            this.kekkasyoButton.UseVisualStyleBackColor = true;
            this.kekkasyoButton.Click += new System.EventHandler(this.kekkasyoButton_Click);
            // 
            // kekkaListPanel
            // 
            this.kekkaListPanel.Controls.Add(this.kekkaListCountLabel);
            this.kekkaListPanel.Controls.Add(this.label4);
            this.kekkaListPanel.Controls.Add(this.kekkaListDataGridView);
            this.kekkaListPanel.Location = new System.Drawing.Point(1, 187);
            this.kekkaListPanel.Name = "kekkaListPanel";
            this.kekkaListPanel.Size = new System.Drawing.Size(1090, 339);
            this.kekkaListPanel.TabIndex = 1;
            // 
            // kekkaListCountLabel
            // 
            this.kekkaListCountLabel.AutoSize = true;
            this.kekkaListCountLabel.Location = new System.Drawing.Point(987, 0);
            this.kekkaListCountLabel.Name = "kekkaListCountLabel";
            this.kekkaListCountLabel.Size = new System.Drawing.Size(30, 20);
            this.kekkaListCountLabel.TabIndex = 0;
            this.kekkaListCountLabel.Text = "0件";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "検索結果：";
            // 
            // faxMkButton
            // 
            this.faxMkButton.Location = new System.Drawing.Point(281, 544);
            this.faxMkButton.Name = "faxMkButton";
            this.faxMkButton.Size = new System.Drawing.Size(133, 37);
            this.faxMkButton.TabIndex = 3;
            this.faxMkButton.Text = "F2:FAX(メーカー)";
            this.faxMkButton.UseVisualStyleBackColor = true;
            this.faxMkButton.Click += new System.EventHandler(this.faxMkButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "検査区分";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(854, 544);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(101, 37);
            this.outputButton.TabIndex = 7;
            this.outputButton.Text = "F6:一覧出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // settisyaTextBox
            // 
            this.settisyaTextBox.Location = new System.Drawing.Point(108, 66);
            this.settisyaTextBox.Name = "settisyaTextBox";
            this.settisyaTextBox.Size = new System.Drawing.Size(305, 27);
            this.settisyaTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "設置者";
            // 
            // viewChangeButton
            // 
            this.viewChangeButton.Location = new System.Drawing.Point(1058, 0);
            this.viewChangeButton.Name = "viewChangeButton";
            this.viewChangeButton.Size = new System.Drawing.Size(29, 21);
            this.viewChangeButton.TabIndex = 15;
            this.viewChangeButton.Text = "▲";
            this.viewChangeButton.UseVisualStyleBackColor = true;
            this.viewChangeButton.Click += new System.EventHandler(this.viewChangeButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.kensaKbnComboBox);
            this.searchPanel.Controls.Add(this.iraiNendoTextBox);
            this.searchPanel.Controls.Add(this.label12);
            this.searchPanel.Controls.Add(this.kensaDtUseCheckBox);
            this.searchPanel.Controls.Add(this.label10);
            this.searchPanel.Controls.Add(this.kensaDtToDateTimePicker);
            this.searchPanel.Controls.Add(this.label11);
            this.searchPanel.Controls.Add(this.kensaDtFromDateTimePicker);
            this.searchPanel.Controls.Add(this.shisetsuNmTextBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.hokenjoComboBox);
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.kensaIraiDtUseCheckBox);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.kensaIraiDtToDateTimePicker);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.kensaIraiDtFromDateTimePicker);
            this.searchPanel.Controls.Add(this.label8);
            this.searchPanel.Controls.Add(this.settisyaTextBox);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.viewChangeButton);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.clearButton);
            this.searchPanel.Controls.Add(this.kensakuButton);
            this.searchPanel.Location = new System.Drawing.Point(1, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1090, 184);
            this.searchPanel.TabIndex = 0;
            // 
            // kensaKbnComboBox
            // 
            this.kensaKbnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kensaKbnComboBox.FormattingEnabled = true;
            this.kensaKbnComboBox.Location = new System.Drawing.Point(109, 35);
            this.kensaKbnComboBox.Name = "kensaKbnComboBox";
            this.kensaKbnComboBox.Size = new System.Drawing.Size(190, 28);
            this.kensaKbnComboBox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(664, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 161;
            this.label12.Text = "依頼年度";
            // 
            // kensaDtUseCheckBox
            // 
            this.kensaDtUseCheckBox.AutoSize = true;
            this.kensaDtUseCheckBox.Checked = true;
            this.kensaDtUseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kensaDtUseCheckBox.Location = new System.Drawing.Point(12, 139);
            this.kensaDtUseCheckBox.Name = "kensaDtUseCheckBox";
            this.kensaDtUseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.kensaDtUseCheckBox.TabIndex = 10;
            this.kensaDtUseCheckBox.UseVisualStyleBackColor = true;
            this.kensaDtUseCheckBox.Click += new System.EventHandler(this.kensaDtUseCheckBox_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 159;
            this.label10.Text = "～";
            // 
            // kensaDtToDateTimePicker
            // 
            this.kensaDtToDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.kensaDtToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kensaDtToDateTimePicker.Location = new System.Drawing.Point(288, 132);
            this.kensaDtToDateTimePicker.Name = "kensaDtToDateTimePicker";
            this.kensaDtToDateTimePicker.Size = new System.Drawing.Size(145, 27);
            this.kensaDtToDateTimePicker.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 157;
            this.label11.Text = "検査日";
            // 
            // kensaDtFromDateTimePicker
            // 
            this.kensaDtFromDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.kensaDtFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kensaDtFromDateTimePicker.Location = new System.Drawing.Point(109, 132);
            this.kensaDtFromDateTimePicker.Name = "kensaDtFromDateTimePicker";
            this.kensaDtFromDateTimePicker.Size = new System.Drawing.Size(145, 27);
            this.kensaDtFromDateTimePicker.TabIndex = 11;
            // 
            // shisetsuNmTextBox
            // 
            this.shisetsuNmTextBox.Location = new System.Drawing.Point(513, 65);
            this.shisetsuNmTextBox.Name = "shisetsuNmTextBox";
            this.shisetsuNmTextBox.Size = new System.Drawing.Size(305, 27);
            this.shisetsuNmTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 154;
            this.label2.Text = "施設名称";
            // 
            // hokenjoComboBox
            // 
            this.hokenjoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hokenjoComboBox.FormattingEnabled = true;
            this.hokenjoComboBox.Location = new System.Drawing.Point(446, 35);
            this.hokenjoComboBox.Name = "hokenjoComboBox";
            this.hokenjoComboBox.Size = new System.Drawing.Size(191, 28);
            this.hokenjoComboBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 152;
            this.label9.Text = "保健所";
            // 
            // kensaIraiDtUseCheckBox
            // 
            this.kensaIraiDtUseCheckBox.AutoSize = true;
            this.kensaIraiDtUseCheckBox.Location = new System.Drawing.Point(12, 106);
            this.kensaIraiDtUseCheckBox.Name = "kensaIraiDtUseCheckBox";
            this.kensaIraiDtUseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.kensaIraiDtUseCheckBox.TabIndex = 7;
            this.kensaIraiDtUseCheckBox.UseVisualStyleBackColor = true;
            this.kensaIraiDtUseCheckBox.Click += new System.EventHandler(this.kensaIraiDtUseCheckBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "～";
            // 
            // kensaIraiDtToDateTimePicker
            // 
            this.kensaIraiDtToDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.kensaIraiDtToDateTimePicker.Enabled = false;
            this.kensaIraiDtToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kensaIraiDtToDateTimePicker.Location = new System.Drawing.Point(288, 99);
            this.kensaIraiDtToDateTimePicker.Name = "kensaIraiDtToDateTimePicker";
            this.kensaIraiDtToDateTimePicker.Size = new System.Drawing.Size(145, 27);
            this.kensaIraiDtToDateTimePicker.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "検査依頼日";
            // 
            // kensaIraiDtFromDateTimePicker
            // 
            this.kensaIraiDtFromDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.kensaIraiDtFromDateTimePicker.Enabled = false;
            this.kensaIraiDtFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.kensaIraiDtFromDateTimePicker.Location = new System.Drawing.Point(109, 99);
            this.kensaIraiDtFromDateTimePicker.Name = "kensaIraiDtFromDateTimePicker";
            this.kensaIraiDtFromDateTimePicker.Size = new System.Drawing.Size(145, 27);
            this.kensaIraiDtFromDateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "検索条件";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(878, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 37);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "F7:クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kensakuButton
            // 
            this.kensakuButton.Location = new System.Drawing.Point(985, 132);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(101, 37);
            this.kensakuButton.TabIndex = 14;
            this.kensakuButton.Text = "F8:検索";
            this.kensakuButton.UseVisualStyleBackColor = true;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // tojiruButton
            // 
            this.tojiruButton.Location = new System.Drawing.Point(990, 544);
            this.tojiruButton.Name = "tojiruButton";
            this.tojiruButton.Size = new System.Drawing.Size(101, 37);
            this.tojiruButton.TabIndex = 8;
            this.tojiruButton.Text = "F12:閉じる";
            this.tojiruButton.UseVisualStyleBackColor = true;
            this.tojiruButton.Click += new System.EventHandler(this.tojiruButton_Click);
            // 
            // faxHosyuButton
            // 
            this.faxHosyuButton.Location = new System.Drawing.Point(420, 544);
            this.faxHosyuButton.Name = "faxHosyuButton";
            this.faxHosyuButton.Size = new System.Drawing.Size(133, 37);
            this.faxHosyuButton.TabIndex = 4;
            this.faxHosyuButton.Text = "F3:FAX(保点検業)";
            this.faxHosyuButton.UseVisualStyleBackColor = true;
            this.faxHosyuButton.Click += new System.EventHandler(this.faxHosyuButton_Click);
            // 
            // faxKojiButton
            // 
            this.faxKojiButton.Location = new System.Drawing.Point(559, 544);
            this.faxKojiButton.Name = "faxKojiButton";
            this.faxKojiButton.Size = new System.Drawing.Size(133, 37);
            this.faxKojiButton.TabIndex = 5;
            this.faxKojiButton.Text = "F4:FAX(工事業者)";
            this.faxKojiButton.UseVisualStyleBackColor = true;
            this.faxKojiButton.Click += new System.EventHandler(this.faxKojiButton_Click);
            // 
            // faxHokenButton
            // 
            this.faxHokenButton.Location = new System.Drawing.Point(698, 544);
            this.faxHokenButton.Name = "faxHokenButton";
            this.faxHokenButton.Size = new System.Drawing.Size(133, 37);
            this.faxHokenButton.TabIndex = 6;
            this.faxHokenButton.Text = "F5:FAX(保健所)";
            this.faxHokenButton.UseVisualStyleBackColor = true;
            this.faxHokenButton.Click += new System.EventHandler(this.faxHokenButton_Click);
            // 
            // iraiNendoTextBox
            // 
            this.iraiNendoTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.iraiNendoTextBox.CustomDigitParts = 0;
            this.iraiNendoTextBox.CustomFormat = null;
            this.iraiNendoTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.iraiNendoTextBox.CustomReadOnly = false;
            this.iraiNendoTextBox.Location = new System.Drawing.Point(735, 36);
            this.iraiNendoTextBox.MaxLength = 4;
            this.iraiNendoTextBox.Name = "iraiNendoTextBox";
            this.iraiNendoTextBox.Size = new System.Drawing.Size(83, 27);
            this.iraiNendoTextBox.TabIndex = 4;
            // 
            // kensaIraiTblDataSetBindingSource
            // 
            this.kensaIraiTblDataSetBindingSource.DataSource = this.kensaIraiTblDataSet;
            this.kensaIraiTblDataSetBindingSource.Position = 0;
            // 
            // kensaIraiTblDataSet
            // 
            this.kensaIraiTblDataSet.DataSetName = "KensaIraiTblDataSet";
            this.kensaIraiTblDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KbnCol
            // 
            this.KbnCol.DataPropertyName = "ConstNm";
            this.KbnCol.HeaderText = "区分";
            this.KbnCol.MinimumWidth = 100;
            this.KbnCol.Name = "KbnCol";
            this.KbnCol.ReadOnly = true;
            // 
            // HokenjoCdCol
            // 
            this.HokenjoCdCol.DataPropertyName = "KensaIraiHokenjoCd";
            this.HokenjoCdCol.HeaderText = "保健所コード";
            this.HokenjoCdCol.MinimumWidth = 120;
            this.HokenjoCdCol.Name = "HokenjoCdCol";
            this.HokenjoCdCol.ReadOnly = true;
            this.HokenjoCdCol.Width = 120;
            // 
            // HokenjoNmCol
            // 
            this.HokenjoNmCol.DataPropertyName = "HokenjoNm";
            this.HokenjoNmCol.HeaderText = "保健所名";
            this.HokenjoNmCol.MinimumWidth = 120;
            this.HokenjoNmCol.Name = "HokenjoNmCol";
            this.HokenjoNmCol.ReadOnly = true;
            this.HokenjoNmCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HokenjoNmCol.Width = 120;
            // 
            // NendoCol
            // 
            this.NendoCol.DataPropertyName = "KensaIraiNendo";
            this.NendoCol.HeaderText = "年度";
            this.NendoCol.MinimumWidth = 60;
            this.NendoCol.Name = "NendoCol";
            this.NendoCol.ReadOnly = true;
            this.NendoCol.Width = 60;
            // 
            // RenbanNoCol
            // 
            this.RenbanNoCol.DataPropertyName = "KensaIraiRenban";
            this.RenbanNoCol.HeaderText = "連番";
            this.RenbanNoCol.MinimumWidth = 60;
            this.RenbanNoCol.Name = "RenbanNoCol";
            this.RenbanNoCol.ReadOnly = true;
            this.RenbanNoCol.Width = 60;
            // 
            // KensaIraiDtCol
            // 
            this.KensaIraiDtCol.DataPropertyName = "KensaIraiDt";
            dataGridViewCellStyle1.NullValue = null;
            this.KensaIraiDtCol.DefaultCellStyle = dataGridViewCellStyle1;
            this.KensaIraiDtCol.HeaderText = "検査依頼日";
            this.KensaIraiDtCol.MinimumWidth = 100;
            this.KensaIraiDtCol.Name = "KensaIraiDtCol";
            this.KensaIraiDtCol.ReadOnly = true;
            // 
            // KensaDtCol
            // 
            this.KensaDtCol.DataPropertyName = "KensaDt";
            dataGridViewCellStyle2.NullValue = null;
            this.KensaDtCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.KensaDtCol.HeaderText = "検査日";
            this.KensaDtCol.MinimumWidth = 100;
            this.KensaDtCol.Name = "KensaDtCol";
            this.KensaDtCol.ReadOnly = true;
            // 
            // SettisyaNmCol
            // 
            this.SettisyaNmCol.DataPropertyName = "KensaIraiSetchishaNm";
            this.SettisyaNmCol.HeaderText = "設置者名";
            this.SettisyaNmCol.MinimumWidth = 150;
            this.SettisyaNmCol.Name = "SettisyaNmCol";
            this.SettisyaNmCol.ReadOnly = true;
            this.SettisyaNmCol.Width = 150;
            // 
            // ShisetsuNmCol
            // 
            this.ShisetsuNmCol.DataPropertyName = "KensaIraiShisetsuNm";
            this.ShisetsuNmCol.HeaderText = "施設名";
            this.ShisetsuNmCol.MinimumWidth = 150;
            this.ShisetsuNmCol.Name = "ShisetsuNmCol";
            this.ShisetsuNmCol.ReadOnly = true;
            this.ShisetsuNmCol.Width = 150;
            // 
            // SettibasyoCol
            // 
            this.SettibasyoCol.DataPropertyName = "KensaIraiSetchibashoAdr";
            this.SettibasyoCol.HeaderText = "設置場所";
            this.SettibasyoCol.MinimumWidth = 120;
            this.SettibasyoCol.Name = "SettibasyoCol";
            this.SettibasyoCol.ReadOnly = true;
            this.SettibasyoCol.Width = 120;
            // 
            // HanteiCol
            // 
            this.HanteiCol.DataPropertyName = "KensaKekkaHantei";
            this.HanteiCol.HeaderText = "判定";
            this.HanteiCol.MinimumWidth = 60;
            this.HanteiCol.Name = "HanteiCol";
            this.HanteiCol.ReadOnly = true;
            this.HanteiCol.Width = 60;
            // 
            // KensaIraiHoteiKbnCol
            // 
            this.KensaIraiHoteiKbnCol.DataPropertyName = "KensaIraiHoteiKbn";
            this.KensaIraiHoteiKbnCol.HeaderText = "KensaIraiHoteiKbn";
            this.KensaIraiHoteiKbnCol.Name = "KensaIraiHoteiKbnCol";
            this.KensaIraiHoteiKbnCol.ReadOnly = true;
            this.KensaIraiHoteiKbnCol.Visible = false;
            // 
            // kensaIraiHokenjoCdDataGridViewTextBoxColumn
            // 
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiHokenjoCd";
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn.HeaderText = "KensaIraiHokenjoCd";
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn.Name = "kensaIraiHokenjoCdDataGridViewTextBoxColumn";
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiHokenjoCdDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaIraiNendoDataGridViewTextBoxColumn
            // 
            this.kensaIraiNendoDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiNendo";
            this.kensaIraiNendoDataGridViewTextBoxColumn.HeaderText = "KensaIraiNendo";
            this.kensaIraiNendoDataGridViewTextBoxColumn.Name = "kensaIraiNendoDataGridViewTextBoxColumn";
            this.kensaIraiNendoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiNendoDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaIraiRenbanDataGridViewTextBoxColumn
            // 
            this.kensaIraiRenbanDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiRenban";
            this.kensaIraiRenbanDataGridViewTextBoxColumn.HeaderText = "KensaIraiRenban";
            this.kensaIraiRenbanDataGridViewTextBoxColumn.Name = "kensaIraiRenbanDataGridViewTextBoxColumn";
            this.kensaIraiRenbanDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiRenbanDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaIraiSetchishaNmDataGridViewTextBoxColumn
            // 
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiSetchishaNm";
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn.HeaderText = "KensaIraiSetchishaNm";
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn.Name = "kensaIraiSetchishaNmDataGridViewTextBoxColumn";
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiSetchishaNmDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaIraiSetchibashoAdrDataGridViewTextBoxColumn
            // 
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiSetchibashoAdr";
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn.HeaderText = "KensaIraiSetchibashoAdr";
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn.Name = "kensaIraiSetchibashoAdrDataGridViewTextBoxColumn";
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiSetchibashoAdrDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaIraiShisetsuNmDataGridViewTextBoxColumn
            // 
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn.DataPropertyName = "KensaIraiShisetsuNm";
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn.HeaderText = "KensaIraiShisetsuNm";
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn.Name = "kensaIraiShisetsuNmDataGridViewTextBoxColumn";
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaIraiShisetsuNmDataGridViewTextBoxColumn.Visible = false;
            // 
            // hokenjoNmDataGridViewTextBoxColumn
            // 
            this.hokenjoNmDataGridViewTextBoxColumn.DataPropertyName = "HokenjoNm";
            this.hokenjoNmDataGridViewTextBoxColumn.HeaderText = "HokenjoNm";
            this.hokenjoNmDataGridViewTextBoxColumn.Name = "hokenjoNmDataGridViewTextBoxColumn";
            this.hokenjoNmDataGridViewTextBoxColumn.ReadOnly = true;
            this.hokenjoNmDataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaKekkaHanteiDataGridViewTextBoxColumn
            // 
            this.kensaKekkaHanteiDataGridViewTextBoxColumn.DataPropertyName = "KensaKekkaHantei";
            this.kensaKekkaHanteiDataGridViewTextBoxColumn.HeaderText = "KensaKekkaHantei";
            this.kensaKekkaHanteiDataGridViewTextBoxColumn.Name = "kensaKekkaHanteiDataGridViewTextBoxColumn";
            this.kensaKekkaHanteiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kensaKekkaHanteiDataGridViewTextBoxColumn.Visible = false;
            // 
            // KensaKekkaListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.faxHokenButton);
            this.Controls.Add(this.faxKojiButton);
            this.Controls.Add(this.faxHosyuButton);
            this.Controls.Add(this.kekkasyoButton);
            this.Controls.Add(this.kekkaListPanel);
            this.Controls.Add(this.faxMkButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tojiruButton);
            this.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KensaKekkaListForm";
            this.Text = "検査結果一覧";
            this.Load += new System.EventHandler(this.KensaKekkaListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KensaKekkaListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kekkaListDataGridView)).EndInit();
            this.kekkaListPanel.ResumeLayout(false);
            this.kekkaListPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kensaIraiTblDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kensaIraiTblDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kekkaListDataGridView;
        private System.Windows.Forms.Button kekkasyoButton;
        private System.Windows.Forms.Panel kekkaListPanel;
        private System.Windows.Forms.Label kekkaListCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button faxMkButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.TextBox settisyaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewChangeButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button kensakuButton;
        private System.Windows.Forms.Button tojiruButton;
        private System.Windows.Forms.CheckBox kensaIraiDtUseCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker kensaIraiDtToDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker kensaIraiDtFromDateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox kensaDtUseCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker kensaDtToDateTimePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker kensaDtFromDateTimePicker;
        private System.Windows.Forms.TextBox shisetsuNmTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hokenjoComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button faxHosyuButton;
        private System.Windows.Forms.Button faxKojiButton;
        private System.Windows.Forms.Button faxHokenButton;
        private System.Windows.Forms.BindingSource kensaIraiTblDataSetBindingSource;
        private DataSet.KensaIraiTblDataSet kensaIraiTblDataSet;
        private Control.NumberTextBox iraiNendoTextBox;
        private System.Windows.Forms.ComboBox kensaKbnComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn KbnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HokenjoCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HokenjoNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NendoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenbanNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KensaIraiDtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KensaDtCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettisyaNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShisetsuNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettibasyoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanteiCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KensaIraiHoteiKbnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiHokenjoCdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiNendoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiRenbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiSetchishaNmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiSetchibashoAdrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaIraiShisetsuNmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hokenjoNmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kensaKekkaHanteiDataGridViewTextBoxColumn;

    }
}