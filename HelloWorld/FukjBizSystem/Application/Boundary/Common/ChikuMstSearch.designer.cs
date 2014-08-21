namespace FukjBizSystem.Application.Boundary.Common
{
    partial class ChikuMstSearchForm
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
            this.tojiruButton = new System.Windows.Forms.Button();
            this.torokuButton = new System.Windows.Forms.Button();
            this.chikuListPanel = new System.Windows.Forms.Panel();
            this.chikuListCountLabel = new System.Windows.Forms.Label();
            this.chikuListDataGridView = new System.Windows.Forms.DataGridView();
            this.ChikuCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChikuNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChikuRyakushoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KankatsuHokenjoCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KankatsuHokenjoNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoteiTantoShishoCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoteiTantoShishoNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuishitsuTantoShishoCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuishitsuTantoShishoNmCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaikanChikuwariCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaikanChikuwari2CdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GappeigoChikuCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertTarmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateTarmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chikuMstKensakuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chikuMstDataSet = new FukjBizSystem.Application.DataSet.ChikuMstDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.chikuCdFromTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.chikuCdToTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.chikuNmTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.viewChangeButton = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.chikuMstKensakuTableAdapter = new FukjBizSystem.Application.DataSet.ChikuMstDataSetTableAdapters.ChikuMstKensakuTableAdapter();
            this.chikuListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chikuListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chikuMstKensakuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chikuMstDataSet)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tojiruButton
            // 
            this.tojiruButton.Location = new System.Drawing.Point(996, 546);
            this.tojiruButton.Name = "tojiruButton";
            this.tojiruButton.Size = new System.Drawing.Size(101, 37);
            this.tojiruButton.TabIndex = 5;
            this.tojiruButton.Text = "F12:閉じる";
            this.tojiruButton.UseVisualStyleBackColor = true;
            this.tojiruButton.Click += new System.EventHandler(this.tojiruButton_Click);
            // 
            // torokuButton
            // 
            this.torokuButton.Location = new System.Drawing.Point(886, 546);
            this.torokuButton.Name = "torokuButton";
            this.torokuButton.Size = new System.Drawing.Size(101, 37);
            this.torokuButton.TabIndex = 2;
            this.torokuButton.Text = "F1:選択戻り";
            this.torokuButton.UseVisualStyleBackColor = true;
            this.torokuButton.Click += new System.EventHandler(this.torokuButton_Click);
            // 
            // chikuListPanel
            // 
            this.chikuListPanel.Controls.Add(this.chikuListCountLabel);
            this.chikuListPanel.Controls.Add(this.chikuListDataGridView);
            this.chikuListPanel.Controls.Add(this.label4);
            this.chikuListPanel.Location = new System.Drawing.Point(1, 130);
            this.chikuListPanel.Name = "chikuListPanel";
            this.chikuListPanel.Size = new System.Drawing.Size(1103, 410);
            this.chikuListPanel.TabIndex = 1;
            // 
            // chikuListCountLabel
            // 
            this.chikuListCountLabel.AutoSize = true;
            this.chikuListCountLabel.Location = new System.Drawing.Point(987, -1);
            this.chikuListCountLabel.Name = "chikuListCountLabel";
            this.chikuListCountLabel.Size = new System.Drawing.Size(30, 20);
            this.chikuListCountLabel.TabIndex = 2;
            this.chikuListCountLabel.Text = "0件";
            // 
            // chikuListDataGridView
            // 
            this.chikuListDataGridView.AllowUserToAddRows = false;
            this.chikuListDataGridView.AllowUserToDeleteRows = false;
            this.chikuListDataGridView.AllowUserToResizeRows = false;
            this.chikuListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chikuListDataGridView.AutoGenerateColumns = false;
            this.chikuListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chikuListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChikuCdCol,
            this.ChikuNmCol,
            this.ChikuRyakushoCol,
            this.KankatsuHokenjoCdCol,
            this.KankatsuHokenjoNmCol,
            this.HoteiTantoShishoCdCol,
            this.HoteiTantoShishoNmCol,
            this.SuishitsuTantoShishoCdCol,
            this.SuishitsuTantoShishoNmCol,
            this.GaikanChikuwariCdCol,
            this.GaikanChikuwari2CdCol,
            this.GappeigoChikuCdCol,
            this.insertDtDataGridViewTextBoxColumn,
            this.insertUserDataGridViewTextBoxColumn,
            this.insertTarmDataGridViewTextBoxColumn,
            this.updateDtDataGridViewTextBoxColumn,
            this.updateUserDataGridViewTextBoxColumn,
            this.updateTarmDataGridViewTextBoxColumn});
            this.chikuListDataGridView.DataSource = this.chikuMstKensakuBindingSource;
            this.chikuListDataGridView.Location = new System.Drawing.Point(7, 22);
            this.chikuListDataGridView.MultiSelect = false;
            this.chikuListDataGridView.Name = "chikuListDataGridView";
            this.chikuListDataGridView.ReadOnly = true;
            this.chikuListDataGridView.RowHeadersVisible = false;
            this.chikuListDataGridView.RowTemplate.Height = 21;
            this.chikuListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chikuListDataGridView.Size = new System.Drawing.Size(1089, 380);
            this.chikuListDataGridView.TabIndex = 0;
            this.chikuListDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chikuListDataGridView_CellDoubleClick);
            // 
            // ChikuCdCol
            // 
            this.ChikuCdCol.DataPropertyName = "ChikuCd";
            this.ChikuCdCol.HeaderText = "地区コード";
            this.ChikuCdCol.MinimumWidth = 110;
            this.ChikuCdCol.Name = "ChikuCdCol";
            this.ChikuCdCol.ReadOnly = true;
            this.ChikuCdCol.Width = 110;
            // 
            // ChikuNmCol
            // 
            this.ChikuNmCol.DataPropertyName = "ChikuNm";
            this.ChikuNmCol.HeaderText = "地区名称";
            this.ChikuNmCol.MinimumWidth = 300;
            this.ChikuNmCol.Name = "ChikuNmCol";
            this.ChikuNmCol.ReadOnly = true;
            this.ChikuNmCol.Width = 300;
            // 
            // ChikuRyakushoCol
            // 
            this.ChikuRyakushoCol.DataPropertyName = "ChikuRyakusho";
            this.ChikuRyakushoCol.HeaderText = "地区略称";
            this.ChikuRyakushoCol.MinimumWidth = 200;
            this.ChikuRyakushoCol.Name = "ChikuRyakushoCol";
            this.ChikuRyakushoCol.ReadOnly = true;
            this.ChikuRyakushoCol.Width = 200;
            // 
            // KankatsuHokenjoCdCol
            // 
            this.KankatsuHokenjoCdCol.DataPropertyName = "KankatsuHokenjoCd";
            this.KankatsuHokenjoCdCol.HeaderText = "管轄保健所コード";
            this.KankatsuHokenjoCdCol.MinimumWidth = 160;
            this.KankatsuHokenjoCdCol.Name = "KankatsuHokenjoCdCol";
            this.KankatsuHokenjoCdCol.ReadOnly = true;
            this.KankatsuHokenjoCdCol.Width = 160;
            // 
            // KankatsuHokenjoNmCol
            // 
            this.KankatsuHokenjoNmCol.DataPropertyName = "HokenjoNm";
            this.KankatsuHokenjoNmCol.HeaderText = "管轄保健所名称";
            this.KankatsuHokenjoNmCol.MinimumWidth = 160;
            this.KankatsuHokenjoNmCol.Name = "KankatsuHokenjoNmCol";
            this.KankatsuHokenjoNmCol.ReadOnly = true;
            this.KankatsuHokenjoNmCol.Width = 160;
            // 
            // HoteiTantoShishoCdCol
            // 
            this.HoteiTantoShishoCdCol.DataPropertyName = "HoteiTantoShishoCd";
            this.HoteiTantoShishoCdCol.HeaderText = "法定担当支所コード";
            this.HoteiTantoShishoCdCol.MinimumWidth = 170;
            this.HoteiTantoShishoCdCol.Name = "HoteiTantoShishoCdCol";
            this.HoteiTantoShishoCdCol.ReadOnly = true;
            this.HoteiTantoShishoCdCol.Width = 170;
            // 
            // HoteiTantoShishoNmCol
            // 
            this.HoteiTantoShishoNmCol.DataPropertyName = "HoteiShishoName";
            this.HoteiTantoShishoNmCol.HeaderText = "法定担当支所名称";
            this.HoteiTantoShishoNmCol.MinimumWidth = 170;
            this.HoteiTantoShishoNmCol.Name = "HoteiTantoShishoNmCol";
            this.HoteiTantoShishoNmCol.ReadOnly = true;
            this.HoteiTantoShishoNmCol.Width = 170;
            // 
            // SuishitsuTantoShishoCdCol
            // 
            this.SuishitsuTantoShishoCdCol.DataPropertyName = "SuishitsuTantoShishoCd";
            this.SuishitsuTantoShishoCdCol.HeaderText = "水質担当支所コード";
            this.SuishitsuTantoShishoCdCol.MinimumWidth = 170;
            this.SuishitsuTantoShishoCdCol.Name = "SuishitsuTantoShishoCdCol";
            this.SuishitsuTantoShishoCdCol.ReadOnly = true;
            this.SuishitsuTantoShishoCdCol.Width = 170;
            // 
            // SuishitsuTantoShishoNmCol
            // 
            this.SuishitsuTantoShishoNmCol.DataPropertyName = "SuishitsuShishoName";
            this.SuishitsuTantoShishoNmCol.HeaderText = "水質担当支所名称";
            this.SuishitsuTantoShishoNmCol.MinimumWidth = 170;
            this.SuishitsuTantoShishoNmCol.Name = "SuishitsuTantoShishoNmCol";
            this.SuishitsuTantoShishoNmCol.ReadOnly = true;
            this.SuishitsuTantoShishoNmCol.Width = 170;
            // 
            // GaikanChikuwariCdCol
            // 
            this.GaikanChikuwariCdCol.DataPropertyName = "GaikanChikuwariCd";
            this.GaikanChikuwariCdCol.HeaderText = "外観地区割";
            this.GaikanChikuwariCdCol.MinimumWidth = 130;
            this.GaikanChikuwariCdCol.Name = "GaikanChikuwariCdCol";
            this.GaikanChikuwariCdCol.ReadOnly = true;
            this.GaikanChikuwariCdCol.Width = 130;
            // 
            // GaikanChikuwari2CdCol
            // 
            this.GaikanChikuwari2CdCol.DataPropertyName = "GaikanChikuwari2Cd";
            this.GaikanChikuwari2CdCol.HeaderText = "外観地区割Ⅱ";
            this.GaikanChikuwari2CdCol.MinimumWidth = 130;
            this.GaikanChikuwari2CdCol.Name = "GaikanChikuwari2CdCol";
            this.GaikanChikuwari2CdCol.ReadOnly = true;
            this.GaikanChikuwari2CdCol.Width = 130;
            // 
            // GappeigoChikuCdCol
            // 
            this.GappeigoChikuCdCol.DataPropertyName = "GappeigoChikuCd";
            this.GappeigoChikuCdCol.HeaderText = "合併後地区コード";
            this.GappeigoChikuCdCol.MinimumWidth = 160;
            this.GappeigoChikuCdCol.Name = "GappeigoChikuCdCol";
            this.GappeigoChikuCdCol.ReadOnly = true;
            this.GappeigoChikuCdCol.Width = 160;
            // 
            // insertDtDataGridViewTextBoxColumn
            // 
            this.insertDtDataGridViewTextBoxColumn.DataPropertyName = "InsertDt";
            this.insertDtDataGridViewTextBoxColumn.HeaderText = "InsertDt";
            this.insertDtDataGridViewTextBoxColumn.Name = "insertDtDataGridViewTextBoxColumn";
            this.insertDtDataGridViewTextBoxColumn.ReadOnly = true;
            this.insertDtDataGridViewTextBoxColumn.Visible = false;
            // 
            // insertUserDataGridViewTextBoxColumn
            // 
            this.insertUserDataGridViewTextBoxColumn.DataPropertyName = "InsertUser";
            this.insertUserDataGridViewTextBoxColumn.HeaderText = "InsertUser";
            this.insertUserDataGridViewTextBoxColumn.Name = "insertUserDataGridViewTextBoxColumn";
            this.insertUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.insertUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // insertTarmDataGridViewTextBoxColumn
            // 
            this.insertTarmDataGridViewTextBoxColumn.DataPropertyName = "InsertTarm";
            this.insertTarmDataGridViewTextBoxColumn.HeaderText = "InsertTarm";
            this.insertTarmDataGridViewTextBoxColumn.Name = "insertTarmDataGridViewTextBoxColumn";
            this.insertTarmDataGridViewTextBoxColumn.ReadOnly = true;
            this.insertTarmDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateDtDataGridViewTextBoxColumn
            // 
            this.updateDtDataGridViewTextBoxColumn.DataPropertyName = "UpdateDt";
            this.updateDtDataGridViewTextBoxColumn.HeaderText = "UpdateDt";
            this.updateDtDataGridViewTextBoxColumn.Name = "updateDtDataGridViewTextBoxColumn";
            this.updateDtDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateDtDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateUserDataGridViewTextBoxColumn
            // 
            this.updateUserDataGridViewTextBoxColumn.DataPropertyName = "UpdateUser";
            this.updateUserDataGridViewTextBoxColumn.HeaderText = "UpdateUser";
            this.updateUserDataGridViewTextBoxColumn.Name = "updateUserDataGridViewTextBoxColumn";
            this.updateUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // updateTarmDataGridViewTextBoxColumn
            // 
            this.updateTarmDataGridViewTextBoxColumn.DataPropertyName = "UpdateTarm";
            this.updateTarmDataGridViewTextBoxColumn.HeaderText = "UpdateTarm";
            this.updateTarmDataGridViewTextBoxColumn.Name = "updateTarmDataGridViewTextBoxColumn";
            this.updateTarmDataGridViewTextBoxColumn.ReadOnly = true;
            this.updateTarmDataGridViewTextBoxColumn.Visible = false;
            // 
            // chikuMstKensakuBindingSource
            // 
            this.chikuMstKensakuBindingSource.DataMember = "ChikuMstKensaku";
            this.chikuMstKensakuBindingSource.DataSource = this.chikuMstDataSet;
            // 
            // chikuMstDataSet
            // 
            this.chikuMstDataSet.DataSetName = "ChikuMstDataSet";
            this.chikuMstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(905, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "検索結果：";
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.chikuCdFromTextBox);
            this.searchPanel.Controls.Add(this.chikuCdToTextBox);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.chikuNmTextBox);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.viewChangeButton);
            this.searchPanel.Controls.Add(this.label19);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.clearButton);
            this.searchPanel.Controls.Add(this.kensakuButton);
            this.searchPanel.Location = new System.Drawing.Point(1, 3);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1103, 121);
            this.searchPanel.TabIndex = 11;
            // 
            // chikuCdFromTextBox
            // 
            this.chikuCdFromTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.chikuCdFromTextBox.CustomDigitParts = 0;
            this.chikuCdFromTextBox.CustomFormat = null;
            this.chikuCdFromTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.chikuCdFromTextBox.CustomReadOnly = false;
            this.chikuCdFromTextBox.Location = new System.Drawing.Point(106, 37);
            this.chikuCdFromTextBox.MaxLength = 5;
            this.chikuCdFromTextBox.Name = "chikuCdFromTextBox";
            this.chikuCdFromTextBox.Size = new System.Drawing.Size(73, 27);
            this.chikuCdFromTextBox.TabIndex = 2;
            // 
            // chikuCdToTextBox
            // 
            this.chikuCdToTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.chikuCdToTextBox.CustomDigitParts = 0;
            this.chikuCdToTextBox.CustomFormat = null;
            this.chikuCdToTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.PositiveInt;
            this.chikuCdToTextBox.CustomReadOnly = false;
            this.chikuCdToTextBox.Location = new System.Drawing.Point(213, 37);
            this.chikuCdToTextBox.MaxLength = 5;
            this.chikuCdToTextBox.Name = "chikuCdToTextBox";
            this.chikuCdToTextBox.Size = new System.Drawing.Size(73, 27);
            this.chikuCdToTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "～";
            // 
            // chikuNmTextBox
            // 
            this.chikuNmTextBox.Location = new System.Drawing.Point(106, 70);
            this.chikuNmTextBox.MaxLength = 20;
            this.chikuNmTextBox.Name = "chikuNmTextBox";
            this.chikuNmTextBox.Size = new System.Drawing.Size(305, 27);
            this.chikuNmTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "地区名称";
            // 
            // viewChangeButton
            // 
            this.viewChangeButton.Location = new System.Drawing.Point(1071, 0);
            this.viewChangeButton.Name = "viewChangeButton";
            this.viewChangeButton.Size = new System.Drawing.Size(29, 21);
            this.viewChangeButton.TabIndex = 9;
            this.viewChangeButton.Text = "▲";
            this.viewChangeButton.UseVisualStyleBackColor = true;
            this.viewChangeButton.Click += new System.EventHandler(this.viewChangeButton_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 40);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "地区コード";
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
            this.clearButton.Location = new System.Drawing.Point(885, 76);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 37);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "F7:クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kensakuButton
            // 
            this.kensakuButton.Location = new System.Drawing.Point(991, 75);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(101, 37);
            this.kensakuButton.TabIndex = 8;
            this.kensakuButton.Text = "F8:検索";
            this.kensakuButton.UseVisualStyleBackColor = true;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // chikuMstKensakuTableAdapter
            // 
            this.chikuMstKensakuTableAdapter.ClearBeforeFill = true;
            // 
            // ChikuMstSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 589);
            this.Controls.Add(this.tojiruButton);
            this.Controls.Add(this.torokuButton);
            this.Controls.Add(this.chikuListPanel);
            this.Controls.Add(this.searchPanel);
            this.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1129, 627);
            this.Name = "ChikuMstSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地区マスタ検索";
            this.Load += new System.EventHandler(this.ChikuMstSearchForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChikuMstSearchForm_KeyDown);
            this.chikuListPanel.ResumeLayout(false);
            this.chikuListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chikuListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chikuMstKensakuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chikuMstDataSet)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tojiruButton;
        private System.Windows.Forms.Button torokuButton;
        private System.Windows.Forms.Panel chikuListPanel;
        private System.Windows.Forms.Label chikuListCountLabel;
        private System.Windows.Forms.DataGridView chikuListDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chikuNmTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewChangeButton;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button kensakuButton;
        private Control.NumberTextBox chikuCdToTextBox;
        private Control.NumberTextBox chikuCdFromTextBox;
        private DataSet.ChikuMstDataSet chikuMstDataSet;
        private System.Windows.Forms.BindingSource chikuMstKensakuBindingSource;
        private DataSet.ChikuMstDataSetTableAdapters.ChikuMstKensakuTableAdapter chikuMstKensakuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChikuCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChikuNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChikuRyakushoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KankatsuHokenjoCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn KankatsuHokenjoNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoteiTantoShishoCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoteiTantoShishoNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuishitsuTantoShishoCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuishitsuTantoShishoNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaikanChikuwariCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaikanChikuwari2CdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GappeigoChikuCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertTarmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateTarmDataGridViewTextBoxColumn;




    }
}