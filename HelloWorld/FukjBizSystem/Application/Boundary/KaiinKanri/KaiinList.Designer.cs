namespace FukjBizSystem.Application.Boundary.KaiinKanri
{
    partial class KaiinListForm
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
            this.kaiinListDataGridView = new System.Windows.Forms.DataGridView();
            this.GyosyaCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GyosyaNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeizoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KogyoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HosyuCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeisoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyoshaCdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyoshaNmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bukaiNyukaiDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BukaiKbnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seizoColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kojiColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosyuColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seisoColDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyoshaBukaiMstDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gyoshaBukaiMstDataSet = new FukjBizSystem.Application.DataSet.GyoshaBukaiMstDataSet();
            this.kaiinListPanel = new System.Windows.Forms.Panel();
            this.kaiinListCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.shosaiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.gyosyaNmTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewChangeButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.nyukaiDtToDateTimePicker = new Zynas.Control.ZDate(this.components);
            this.nyukaiDtFromDateTimePicker = new Zynas.Control.ZDate(this.components);
            this.nyukaiDtUseCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sonotaGyoshaKbnCheckBox = new System.Windows.Forms.CheckBox();
            this.seizoGyoShaKbnCheckBox = new System.Windows.Forms.CheckBox();
            this.seisoGyoshaKbnCheckBox = new System.Windows.Forms.CheckBox();
            this.hoshuGyoshaKbnCheckBox = new System.Windows.Forms.CheckBox();
            this.kojiGyoshaKbnCheckBox = new System.Windows.Forms.CheckBox();
            this.gyosyaCdToTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.gyosyaCdFromTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.tojiruButton = new System.Windows.Forms.Button();
            this.KakuninsyoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kaiinListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyoshaBukaiMstDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyoshaBukaiMstDataSet)).BeginInit();
            this.kaiinListPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // kaiinListDataGridView
            // 
            this.kaiinListDataGridView.AllowUserToAddRows = false;
            this.kaiinListDataGridView.AllowUserToResizeRows = false;
            this.kaiinListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.kaiinListDataGridView.AutoGenerateColumns = false;
            this.kaiinListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kaiinListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GyosyaCdCol,
            this.GyosyaNmCol,
            this.SeizoCol,
            this.KogyoCol,
            this.HosyuCol,
            this.SeisoCol,
            this.gyoshaCdDataGridViewTextBoxColumn,
            this.gyoshaNmDataGridViewTextBoxColumn,
            this.bukaiNyukaiDtDataGridViewTextBoxColumn,
            this.BukaiKbnCol,
            this.seizoColDataGridViewTextBoxColumn,
            this.kojiColDataGridViewTextBoxColumn,
            this.hosyuColDataGridViewTextBoxColumn,
            this.seisoColDataGridViewTextBoxColumn});
            this.kaiinListDataGridView.DataMember = "KaiinList";
            this.kaiinListDataGridView.DataSource = this.gyoshaBukaiMstDataSetBindingSource;
            this.kaiinListDataGridView.Location = new System.Drawing.Point(2, 24);
            this.kaiinListDataGridView.MultiSelect = false;
            this.kaiinListDataGridView.Name = "kaiinListDataGridView";
            this.kaiinListDataGridView.RowHeadersVisible = false;
            this.kaiinListDataGridView.RowTemplate.Height = 21;
            this.kaiinListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kaiinListDataGridView.Size = new System.Drawing.Size(1085, 312);
            this.kaiinListDataGridView.TabIndex = 0;
            this.kaiinListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kaiinListDataGridView_CellDoubleClick);
            // 
            // GyosyaCdCol
            // 
            this.GyosyaCdCol.DataPropertyName = "GyoshaCd";
            this.GyosyaCdCol.HeaderText = "業者コード";
            this.GyosyaCdCol.MinimumWidth = 110;
            this.GyosyaCdCol.Name = "GyosyaCdCol";
            this.GyosyaCdCol.ReadOnly = true;
            this.GyosyaCdCol.Width = 110;
            // 
            // GyosyaNmCol
            // 
            this.GyosyaNmCol.DataPropertyName = "GyoshaNm";
            this.GyosyaNmCol.HeaderText = "業者名称";
            this.GyosyaNmCol.MinimumWidth = 400;
            this.GyosyaNmCol.Name = "GyosyaNmCol";
            this.GyosyaNmCol.ReadOnly = true;
            this.GyosyaNmCol.Width = 400;
            // 
            // SeizoCol
            // 
            this.SeizoCol.DataPropertyName = "SeizoCol";
            this.SeizoCol.HeaderText = "製造部会";
            this.SeizoCol.MinimumWidth = 110;
            this.SeizoCol.Name = "SeizoCol";
            this.SeizoCol.ReadOnly = true;
            this.SeizoCol.Width = 110;
            // 
            // KogyoCol
            // 
            this.KogyoCol.DataPropertyName = "KojiCol";
            this.KogyoCol.HeaderText = "工事部会";
            this.KogyoCol.MinimumWidth = 110;
            this.KogyoCol.Name = "KogyoCol";
            this.KogyoCol.ReadOnly = true;
            this.KogyoCol.Width = 110;
            // 
            // HosyuCol
            // 
            this.HosyuCol.DataPropertyName = "HosyuCol";
            this.HosyuCol.HeaderText = "保守部会";
            this.HosyuCol.MinimumWidth = 110;
            this.HosyuCol.Name = "HosyuCol";
            this.HosyuCol.ReadOnly = true;
            this.HosyuCol.Width = 110;
            // 
            // SeisoCol
            // 
            this.SeisoCol.DataPropertyName = "SeisoCol";
            this.SeisoCol.HeaderText = "清掃部会";
            this.SeisoCol.MinimumWidth = 110;
            this.SeisoCol.Name = "SeisoCol";
            this.SeisoCol.ReadOnly = true;
            this.SeisoCol.Width = 110;
            // 
            // gyoshaCdDataGridViewTextBoxColumn
            // 
            this.gyoshaCdDataGridViewTextBoxColumn.DataPropertyName = "GyoshaCd";
            this.gyoshaCdDataGridViewTextBoxColumn.HeaderText = "GyoshaCd";
            this.gyoshaCdDataGridViewTextBoxColumn.Name = "gyoshaCdDataGridViewTextBoxColumn";
            this.gyoshaCdDataGridViewTextBoxColumn.Visible = false;
            // 
            // gyoshaNmDataGridViewTextBoxColumn
            // 
            this.gyoshaNmDataGridViewTextBoxColumn.DataPropertyName = "GyoshaNm";
            this.gyoshaNmDataGridViewTextBoxColumn.HeaderText = "GyoshaNm";
            this.gyoshaNmDataGridViewTextBoxColumn.Name = "gyoshaNmDataGridViewTextBoxColumn";
            this.gyoshaNmDataGridViewTextBoxColumn.Visible = false;
            // 
            // bukaiNyukaiDtDataGridViewTextBoxColumn
            // 
            this.bukaiNyukaiDtDataGridViewTextBoxColumn.DataPropertyName = "BukaiNyukaiDt";
            this.bukaiNyukaiDtDataGridViewTextBoxColumn.HeaderText = "BukaiNyukaiDt";
            this.bukaiNyukaiDtDataGridViewTextBoxColumn.Name = "bukaiNyukaiDtDataGridViewTextBoxColumn";
            this.bukaiNyukaiDtDataGridViewTextBoxColumn.Visible = false;
            // 
            // BukaiKbnCol
            // 
            this.BukaiKbnCol.DataPropertyName = "BukaiKbn";
            this.BukaiKbnCol.HeaderText = "BukaiKbn";
            this.BukaiKbnCol.Name = "BukaiKbnCol";
            this.BukaiKbnCol.Visible = false;
            // 
            // seizoColDataGridViewTextBoxColumn
            // 
            this.seizoColDataGridViewTextBoxColumn.DataPropertyName = "SeizoCol";
            this.seizoColDataGridViewTextBoxColumn.HeaderText = "SeizoCol";
            this.seizoColDataGridViewTextBoxColumn.Name = "seizoColDataGridViewTextBoxColumn";
            this.seizoColDataGridViewTextBoxColumn.ReadOnly = true;
            this.seizoColDataGridViewTextBoxColumn.Visible = false;
            // 
            // kojiColDataGridViewTextBoxColumn
            // 
            this.kojiColDataGridViewTextBoxColumn.DataPropertyName = "KojiCol";
            this.kojiColDataGridViewTextBoxColumn.HeaderText = "KojiCol";
            this.kojiColDataGridViewTextBoxColumn.Name = "kojiColDataGridViewTextBoxColumn";
            this.kojiColDataGridViewTextBoxColumn.ReadOnly = true;
            this.kojiColDataGridViewTextBoxColumn.Visible = false;
            // 
            // hosyuColDataGridViewTextBoxColumn
            // 
            this.hosyuColDataGridViewTextBoxColumn.DataPropertyName = "HosyuCol";
            this.hosyuColDataGridViewTextBoxColumn.HeaderText = "HosyuCol";
            this.hosyuColDataGridViewTextBoxColumn.Name = "hosyuColDataGridViewTextBoxColumn";
            this.hosyuColDataGridViewTextBoxColumn.ReadOnly = true;
            this.hosyuColDataGridViewTextBoxColumn.Visible = false;
            // 
            // seisoColDataGridViewTextBoxColumn
            // 
            this.seisoColDataGridViewTextBoxColumn.DataPropertyName = "SeisoCol";
            this.seisoColDataGridViewTextBoxColumn.HeaderText = "SeisoCol";
            this.seisoColDataGridViewTextBoxColumn.Name = "seisoColDataGridViewTextBoxColumn";
            this.seisoColDataGridViewTextBoxColumn.ReadOnly = true;
            this.seisoColDataGridViewTextBoxColumn.Visible = false;
            // 
            // gyoshaBukaiMstDataSetBindingSource
            // 
            this.gyoshaBukaiMstDataSetBindingSource.DataSource = this.gyoshaBukaiMstDataSet;
            this.gyoshaBukaiMstDataSetBindingSource.Position = 0;
            // 
            // gyoshaBukaiMstDataSet
            // 
            this.gyoshaBukaiMstDataSet.DataSetName = "GyoshaBukaiMstDataSet";
            this.gyoshaBukaiMstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kaiinListPanel
            // 
            this.kaiinListPanel.Controls.Add(this.kaiinListCountLabel);
            this.kaiinListPanel.Controls.Add(this.label4);
            this.kaiinListPanel.Controls.Add(this.kaiinListDataGridView);
            this.kaiinListPanel.Location = new System.Drawing.Point(1, 187);
            this.kaiinListPanel.Name = "kaiinListPanel";
            this.kaiinListPanel.Size = new System.Drawing.Size(1090, 339);
            this.kaiinListPanel.TabIndex = 1;
            // 
            // kaiinListCountLabel
            // 
            this.kaiinListCountLabel.AutoSize = true;
            this.kaiinListCountLabel.Location = new System.Drawing.Point(987, 0);
            this.kaiinListCountLabel.Name = "kaiinListCountLabel";
            this.kaiinListCountLabel.Size = new System.Drawing.Size(30, 20);
            this.kaiinListCountLabel.TabIndex = 2;
            this.kaiinListCountLabel.Text = "0件";
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
            // shosaiButton
            // 
            this.shosaiButton.Location = new System.Drawing.Point(604, 544);
            this.shosaiButton.Name = "shosaiButton";
            this.shosaiButton.Size = new System.Drawing.Size(101, 37);
            this.shosaiButton.TabIndex = 3;
            this.shosaiButton.Text = "F1:編集";
            this.shosaiButton.UseVisualStyleBackColor = true;
            this.shosaiButton.Click += new System.EventHandler(this.shosaiButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "～";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(854, 544);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(101, 37);
            this.outputButton.TabIndex = 5;
            this.outputButton.Text = "F6:一覧出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // gyosyaNmTextBox
            // 
            this.gyosyaNmTextBox.Location = new System.Drawing.Point(112, 73);
            this.gyosyaNmTextBox.MaxLength = 40;
            this.gyosyaNmTextBox.Name = "gyosyaNmTextBox";
            this.gyosyaNmTextBox.Size = new System.Drawing.Size(364, 27);
            this.gyosyaNmTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "業者名称";
            // 
            // viewChangeButton
            // 
            this.viewChangeButton.Location = new System.Drawing.Point(1058, 0);
            this.viewChangeButton.Name = "viewChangeButton";
            this.viewChangeButton.Size = new System.Drawing.Size(29, 21);
            this.viewChangeButton.TabIndex = 20;
            this.viewChangeButton.Text = "▲";
            this.viewChangeButton.UseVisualStyleBackColor = true;
            this.viewChangeButton.Click += new System.EventHandler(this.ViewChangeButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "業者コード";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.nyukaiDtToDateTimePicker);
            this.searchPanel.Controls.Add(this.nyukaiDtFromDateTimePicker);
            this.searchPanel.Controls.Add(this.nyukaiDtUseCheckBox);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.label6);
            this.searchPanel.Controls.Add(this.sonotaGyoshaKbnCheckBox);
            this.searchPanel.Controls.Add(this.seizoGyoShaKbnCheckBox);
            this.searchPanel.Controls.Add(this.seisoGyoshaKbnCheckBox);
            this.searchPanel.Controls.Add(this.hoshuGyoshaKbnCheckBox);
            this.searchPanel.Controls.Add(this.kojiGyoshaKbnCheckBox);
            this.searchPanel.Controls.Add(this.gyosyaCdToTextBox);
            this.searchPanel.Controls.Add(this.gyosyaCdFromTextBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.gyosyaNmTextBox);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.viewChangeButton);
            this.searchPanel.Controls.Add(this.label19);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.clearButton);
            this.searchPanel.Controls.Add(this.kensakuButton);
            this.searchPanel.Location = new System.Drawing.Point(1, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1090, 184);
            this.searchPanel.TabIndex = 0;
            // 
            // nyukaiDtToDateTimePicker
            // 
            this.nyukaiDtToDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.nyukaiDtToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nyukaiDtToDateTimePicker.Location = new System.Drawing.Point(314, 107);
            this.nyukaiDtToDateTimePicker.Name = "nyukaiDtToDateTimePicker";
            this.nyukaiDtToDateTimePicker.Size = new System.Drawing.Size(162, 27);
            this.nyukaiDtToDateTimePicker.TabIndex = 11;
            // 
            // nyukaiDtFromDateTimePicker
            // 
            this.nyukaiDtFromDateTimePicker.CustomFormat = "yyyy年MM月dd日";
            this.nyukaiDtFromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nyukaiDtFromDateTimePicker.Location = new System.Drawing.Point(112, 107);
            this.nyukaiDtFromDateTimePicker.Name = "nyukaiDtFromDateTimePicker";
            this.nyukaiDtFromDateTimePicker.Size = new System.Drawing.Size(162, 27);
            this.nyukaiDtFromDateTimePicker.TabIndex = 9;
            // 
            // nyukaiDtUseCheckBox
            // 
            this.nyukaiDtUseCheckBox.AutoSize = true;
            this.nyukaiDtUseCheckBox.Location = new System.Drawing.Point(11, 114);
            this.nyukaiDtUseCheckBox.Name = "nyukaiDtUseCheckBox";
            this.nyukaiDtUseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.nyukaiDtUseCheckBox.TabIndex = 7;
            this.nyukaiDtUseCheckBox.UseVisualStyleBackColor = true;
            this.nyukaiDtUseCheckBox.CheckedChanged += new System.EventHandler(this.nyukaiDtUseCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "～";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "入会日";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "会員区分";
            // 
            // sonotaGyoshaKbnCheckBox
            // 
            this.sonotaGyoshaKbnCheckBox.AutoSize = true;
            this.sonotaGyoshaKbnCheckBox.Location = new System.Drawing.Point(350, 140);
            this.sonotaGyoshaKbnCheckBox.Name = "sonotaGyoshaKbnCheckBox";
            this.sonotaGyoshaKbnCheckBox.Size = new System.Drawing.Size(67, 24);
            this.sonotaGyoshaKbnCheckBox.TabIndex = 17;
            this.sonotaGyoshaKbnCheckBox.Text = "未加入";
            this.sonotaGyoshaKbnCheckBox.UseVisualStyleBackColor = true;
            // 
            // seizoGyoShaKbnCheckBox
            // 
            this.seizoGyoShaKbnCheckBox.AutoSize = true;
            this.seizoGyoShaKbnCheckBox.Location = new System.Drawing.Point(112, 140);
            this.seizoGyoShaKbnCheckBox.Name = "seizoGyoShaKbnCheckBox";
            this.seizoGyoShaKbnCheckBox.Size = new System.Drawing.Size(54, 24);
            this.seizoGyoShaKbnCheckBox.TabIndex = 13;
            this.seizoGyoShaKbnCheckBox.Text = "製造";
            this.seizoGyoShaKbnCheckBox.UseVisualStyleBackColor = true;
            // 
            // seisoGyoshaKbnCheckBox
            // 
            this.seisoGyoshaKbnCheckBox.AutoSize = true;
            this.seisoGyoshaKbnCheckBox.Location = new System.Drawing.Point(290, 140);
            this.seisoGyoshaKbnCheckBox.Name = "seisoGyoshaKbnCheckBox";
            this.seisoGyoshaKbnCheckBox.Size = new System.Drawing.Size(54, 24);
            this.seisoGyoshaKbnCheckBox.TabIndex = 16;
            this.seisoGyoshaKbnCheckBox.Text = "清掃";
            this.seisoGyoshaKbnCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoshuGyoshaKbnCheckBox
            // 
            this.hoshuGyoshaKbnCheckBox.AutoSize = true;
            this.hoshuGyoshaKbnCheckBox.Location = new System.Drawing.Point(230, 140);
            this.hoshuGyoshaKbnCheckBox.Name = "hoshuGyoshaKbnCheckBox";
            this.hoshuGyoshaKbnCheckBox.Size = new System.Drawing.Size(54, 24);
            this.hoshuGyoshaKbnCheckBox.TabIndex = 15;
            this.hoshuGyoshaKbnCheckBox.Text = "保守";
            this.hoshuGyoshaKbnCheckBox.UseVisualStyleBackColor = true;
            // 
            // kojiGyoshaKbnCheckBox
            // 
            this.kojiGyoshaKbnCheckBox.AutoSize = true;
            this.kojiGyoshaKbnCheckBox.Location = new System.Drawing.Point(170, 140);
            this.kojiGyoshaKbnCheckBox.Name = "kojiGyoshaKbnCheckBox";
            this.kojiGyoshaKbnCheckBox.Size = new System.Drawing.Size(54, 24);
            this.kojiGyoshaKbnCheckBox.TabIndex = 14;
            this.kojiGyoshaKbnCheckBox.Text = "工事";
            this.kojiGyoshaKbnCheckBox.UseVisualStyleBackColor = true;
            // 
            // gyosyaCdToTextBox
            // 
            this.gyosyaCdToTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.gyosyaCdToTextBox.CustomDigitParts = 0;
            this.gyosyaCdToTextBox.CustomFormat = null;
            this.gyosyaCdToTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.gyosyaCdToTextBox.CustomReadOnly = false;
            this.gyosyaCdToTextBox.Location = new System.Drawing.Point(194, 40);
            this.gyosyaCdToTextBox.MaxLength = 4;
            this.gyosyaCdToTextBox.Name = "gyosyaCdToTextBox";
            this.gyosyaCdToTextBox.Size = new System.Drawing.Size(48, 27);
            this.gyosyaCdToTextBox.TabIndex = 4;
            // 
            // gyosyaCdFromTextBox
            // 
            this.gyosyaCdFromTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.gyosyaCdFromTextBox.CustomDigitParts = 0;
            this.gyosyaCdFromTextBox.CustomFormat = null;
            this.gyosyaCdFromTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.gyosyaCdFromTextBox.CustomReadOnly = false;
            this.gyosyaCdFromTextBox.Location = new System.Drawing.Point(112, 40);
            this.gyosyaCdFromTextBox.MaxLength = 4;
            this.gyosyaCdFromTextBox.Name = "gyosyaCdFromTextBox";
            this.gyosyaCdFromTextBox.Size = new System.Drawing.Size(48, 27);
            this.gyosyaCdFromTextBox.TabIndex = 2;
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
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "F7:クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kensakuButton
            // 
            this.kensakuButton.Location = new System.Drawing.Point(985, 132);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(101, 37);
            this.kensakuButton.TabIndex = 19;
            this.kensakuButton.Text = "F8:検索";
            this.kensakuButton.UseVisualStyleBackColor = true;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // tojiruButton
            // 
            this.tojiruButton.Location = new System.Drawing.Point(990, 544);
            this.tojiruButton.Name = "tojiruButton";
            this.tojiruButton.Size = new System.Drawing.Size(101, 37);
            this.tojiruButton.TabIndex = 6;
            this.tojiruButton.Text = "F12:閉じる";
            this.tojiruButton.UseVisualStyleBackColor = true;
            this.tojiruButton.Click += new System.EventHandler(this.tojiruButton_Click);
            // 
            // KakuninsyoButton
            // 
            this.KakuninsyoButton.Location = new System.Drawing.Point(747, 544);
            this.KakuninsyoButton.Name = "KakuninsyoButton";
            this.KakuninsyoButton.Size = new System.Drawing.Size(101, 37);
            this.KakuninsyoButton.TabIndex = 4;
            this.KakuninsyoButton.Text = "F５:確認書";
            this.KakuninsyoButton.UseVisualStyleBackColor = true;
            this.KakuninsyoButton.Click += new System.EventHandler(this.KakuninsyoButton_Click);
            // 
            // KaiinListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.KakuninsyoButton);
            this.Controls.Add(this.kaiinListPanel);
            this.Controls.Add(this.shosaiButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tojiruButton);
            this.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KaiinListForm";
            this.Text = "会員一覧";
            this.Load += new System.EventHandler(this.KaiinListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KaiinListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kaiinListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyoshaBukaiMstDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gyoshaBukaiMstDataSet)).EndInit();
            this.kaiinListPanel.ResumeLayout(false);
            this.kaiinListPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView kaiinListDataGridView;
        private System.Windows.Forms.Panel kaiinListPanel;
        private System.Windows.Forms.Label kaiinListCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button shosaiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.TextBox gyosyaNmTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewChangeButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button kensakuButton;
        private System.Windows.Forms.Button tojiruButton;
        private Control.NumberTextBox gyosyaCdFromTextBox;
        private Control.NumberTextBox gyosyaCdToTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox sonotaGyoshaKbnCheckBox;
        private System.Windows.Forms.CheckBox seizoGyoShaKbnCheckBox;
        private System.Windows.Forms.CheckBox seisoGyoshaKbnCheckBox;
        private System.Windows.Forms.CheckBox hoshuGyoshaKbnCheckBox;
        private System.Windows.Forms.CheckBox kojiGyoshaKbnCheckBox;
        private System.Windows.Forms.CheckBox nyukaiDtUseCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button KakuninsyoButton;
        private Zynas.Control.ZDate nyukaiDtToDateTimePicker;
        private Zynas.Control.ZDate nyukaiDtFromDateTimePicker;
        private System.Windows.Forms.BindingSource gyoshaBukaiMstDataSetBindingSource;
        private DataSet.GyoshaBukaiMstDataSet gyoshaBukaiMstDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn GyosyaCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GyosyaNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeizoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KogyoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HosyuCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeisoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyoshaCdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gyoshaNmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bukaiNyukaiDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BukaiKbnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn seizoColDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kojiColDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosyuColDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seisoColDataGridViewTextBoxColumn;

    }
}