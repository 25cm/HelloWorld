namespace FukjBizSystem.Application.Boundary.Master
{
    partial class SuishitsuKensaSetMstShosaiForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.setRyoukinTextBox = new FukjBizSystem.Control.ZTextBox(this.components);
            this.setShikenListDataGridView = new System.Windows.Forms.DataGridView();
            this.SetKomokuSetCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetKomokuCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetKomokuNmCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.suishitsuShikenKoumokuMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suishitsuShikenKoumokuMstDataSet = new FukjBizSystem.Application.DataSet.SuishitsuShikenKoumokuMstDataSet();
            this.SetKomokuRyokinCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShomeishoKisaiKbnCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SetKomokuSeikyuUmuKbnCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SuishitsuShikenKoumokuCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultSetKomokuCdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultShomeishoKisaiKbnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultSetKomokuSeikyuUmuKbnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setCdTextBox = new FukjBizSystem.Control.NumberTextBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.shukeiButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setNmRyakushoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.setNmTextBox = new System.Windows.Forms.TextBox();
            this.entryButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.decisionButton = new System.Windows.Forms.Button();
            this.reInputButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.suishitsuShikenKoumokuMstTableAdapter = new FukjBizSystem.Application.DataSet.SuishitsuShikenKoumokuMstDataSetTableAdapters.SuishitsuShikenKoumokuMstTableAdapter();
            this.suishitsuKensaSetMstShosaiTableAdapter = new FukjBizSystem.Application.DataSet.SuishitsuKensaSetMstDataSetTableAdapters.SuishitsuKensaSetMstShosaiTableAdapter();
            this.suishitsuKensaSetMstShosaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suishitsuKensaSetMstDataSet = new FukjBizSystem.Application.DataSet.SuishitsuKensaSetMstDataSet();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setShikenListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuShikenKoumokuMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuShikenKoumokuMstDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuKensaSetMstShosaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuKensaSetMstDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "セット名称（正式）";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.setRyoukinTextBox);
            this.mainPanel.Controls.Add(this.setShikenListDataGridView);
            this.mainPanel.Controls.Add(this.setCdTextBox);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.shukeiButton);
            this.mainPanel.Controls.Add(this.label26);
            this.mainPanel.Controls.Add(this.label14);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.setNmRyakushoTextBox);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.setNmTextBox);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.entryButton);
            this.mainPanel.Controls.Add(this.changeButton);
            this.mainPanel.Controls.Add(this.decisionButton);
            this.mainPanel.Controls.Add(this.reInputButton);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1091, 593);
            this.mainPanel.TabIndex = 0;
            // 
            // setRyoukinTextBox
            // 
            this.setRyoukinTextBox.AllowDropDown = false;
            this.setRyoukinTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.setRyoukinTextBox.CustomInputMode = FukjBizSystem.Control.ZTextBox.InputMode.None;
            this.setRyoukinTextBox.CustomReadOnly = false;
            this.setRyoukinTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.setRyoukinTextBox.Location = new System.Drawing.Point(156, 123);
            this.setRyoukinTextBox.Name = "setRyoukinTextBox";
            this.setRyoukinTextBox.Size = new System.Drawing.Size(175, 27);
            this.setRyoukinTextBox.TabIndex = 11;
            this.setRyoukinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.setRyoukinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setRyoukinTextBox_KeyPress);
            // 
            // setShikenListDataGridView
            // 
            this.setShikenListDataGridView.AllowUserToResizeRows = false;
            this.setShikenListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setShikenListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.setShikenListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SetKomokuSetCdCol,
            this.SetKomokuCdCol,
            this.SetKomokuNmCol,
            this.SetKomokuRyokinCol,
            this.ShomeishoKisaiKbnCol,
            this.SetKomokuSeikyuUmuKbnCol,
            this.SuishitsuShikenKoumokuCd,
            this.DefaultSetKomokuCdCol,
            this.DefaultShomeishoKisaiKbnCol,
            this.DefaultSetKomokuSeikyuUmuKbnCol});
            this.setShikenListDataGridView.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.setShikenListDataGridView.Location = new System.Drawing.Point(24, 183);
            this.setShikenListDataGridView.MultiSelect = false;
            this.setShikenListDataGridView.Name = "setShikenListDataGridView";
            this.setShikenListDataGridView.RowHeadersVisible = false;
            this.setShikenListDataGridView.RowTemplate.Height = 21;
            this.setShikenListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.setShikenListDataGridView.Size = new System.Drawing.Size(748, 343);
            this.setShikenListDataGridView.TabIndex = 16;
            this.setShikenListDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.setShikenListDataGridView_CellEndEdit);
            this.setShikenListDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.setShikenListDataGridView_DataError);
            this.setShikenListDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.setShikenListDataGridView_DefaultValuesNeeded);
            this.setShikenListDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.setShikenListDataGridView_EditingControlShowing);
            this.setShikenListDataGridView.Sorted += new System.EventHandler(this.setShikenListDataGridView_Sorted);
            this.setShikenListDataGridView.Enter += new System.EventHandler(this.setShikenListDataGridView_Enter);
            // 
            // SetKomokuSetCdCol
            // 
            this.SetKomokuSetCdCol.DataPropertyName = "SetKomokuSetCd";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.SetKomokuSetCdCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.SetKomokuSetCdCol.HeaderText = "セットコード";
            this.SetKomokuSetCdCol.MinimumWidth = 115;
            this.SetKomokuSetCdCol.Name = "SetKomokuSetCdCol";
            this.SetKomokuSetCdCol.Visible = false;
            this.SetKomokuSetCdCol.Width = 115;
            // 
            // SetKomokuCdCol
            // 
            this.SetKomokuCdCol.DataPropertyName = "SetKomokuCd";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SetKomokuCdCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.SetKomokuCdCol.HeaderText = "セット試験項目コード";
            this.SetKomokuCdCol.MaxInputLength = 3;
            this.SetKomokuCdCol.MinimumWidth = 100;
            this.SetKomokuCdCol.Name = "SetKomokuCdCol";
            // 
            // SetKomokuNmCol
            // 
            this.SetKomokuNmCol.DataPropertyName = "SetKomokuCd";
            this.SetKomokuNmCol.DataSource = this.suishitsuShikenKoumokuMstBindingSource;
            this.SetKomokuNmCol.DisplayMember = "SeishikiNm";
            this.SetKomokuNmCol.HeaderText = "セット試験項目名称";
            this.SetKomokuNmCol.MinimumWidth = 300;
            this.SetKomokuNmCol.Name = "SetKomokuNmCol";
            this.SetKomokuNmCol.ValueMember = "SuishitsuShikenKoumokuCd";
            this.SetKomokuNmCol.Width = 300;
            // 
            // suishitsuShikenKoumokuMstBindingSource
            // 
            this.suishitsuShikenKoumokuMstBindingSource.DataMember = "SuishitsuShikenKoumokuMst";
            this.suishitsuShikenKoumokuMstBindingSource.DataSource = this.suishitsuShikenKoumokuMstDataSet;
            // 
            // suishitsuShikenKoumokuMstDataSet
            // 
            this.suishitsuShikenKoumokuMstDataSet.DataSetName = "SuishitsuShikenKoumokuMstDataSet";
            this.suishitsuShikenKoumokuMstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SetKomokuRyokinCol
            // 
            this.SetKomokuRyokinCol.DataPropertyName = "SuishitsuShikenKomokuAmt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            this.SetKomokuRyokinCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.SetKomokuRyokinCol.HeaderText = "水質試験項目料金";
            this.SetKomokuRyokinCol.MinimumWidth = 130;
            this.SetKomokuRyokinCol.Name = "SetKomokuRyokinCol";
            this.SetKomokuRyokinCol.ReadOnly = true;
            this.SetKomokuRyokinCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SetKomokuRyokinCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SetKomokuRyokinCol.Width = 130;
            // 
            // ShomeishoKisaiKbnCol
            // 
            this.ShomeishoKisaiKbnCol.DataPropertyName = "ShomeishoKisaiKbn";
            this.ShomeishoKisaiKbnCol.FalseValue = "2";
            this.ShomeishoKisaiKbnCol.HeaderText = "証明書記載区分";
            this.ShomeishoKisaiKbnCol.MinimumWidth = 110;
            this.ShomeishoKisaiKbnCol.Name = "ShomeishoKisaiKbnCol";
            this.ShomeishoKisaiKbnCol.TrueValue = "1";
            this.ShomeishoKisaiKbnCol.Width = 110;
            // 
            // SetKomokuSeikyuUmuKbnCol
            // 
            this.SetKomokuSeikyuUmuKbnCol.DataPropertyName = "SetKomokuSeikyuUmuKbn";
            this.SetKomokuSeikyuUmuKbnCol.FalseValue = "2";
            this.SetKomokuSeikyuUmuKbnCol.HeaderText = "請求有無区分";
            this.SetKomokuSeikyuUmuKbnCol.MinimumWidth = 100;
            this.SetKomokuSeikyuUmuKbnCol.Name = "SetKomokuSeikyuUmuKbnCol";
            this.SetKomokuSeikyuUmuKbnCol.TrueValue = "1";
            // 
            // SuishitsuShikenKoumokuCd
            // 
            this.SuishitsuShikenKoumokuCd.DataPropertyName = "SuishitsuShikenKoumokuCd";
            this.SuishitsuShikenKoumokuCd.HeaderText = "SuishitsuShikenKoumokuCd";
            this.SuishitsuShikenKoumokuCd.Name = "SuishitsuShikenKoumokuCd";
            this.SuishitsuShikenKoumokuCd.Visible = false;
            // 
            // DefaultSetKomokuCdCol
            // 
            this.DefaultSetKomokuCdCol.HeaderText = "DefaultSetKomokuCd";
            this.DefaultSetKomokuCdCol.Name = "DefaultSetKomokuCdCol";
            this.DefaultSetKomokuCdCol.Visible = false;
            // 
            // DefaultShomeishoKisaiKbnCol
            // 
            this.DefaultShomeishoKisaiKbnCol.HeaderText = "DefaultShomeishoKisaiKbnCol";
            this.DefaultShomeishoKisaiKbnCol.Name = "DefaultShomeishoKisaiKbnCol";
            this.DefaultShomeishoKisaiKbnCol.Visible = false;
            // 
            // DefaultSetKomokuSeikyuUmuKbnCol
            // 
            this.DefaultSetKomokuSeikyuUmuKbnCol.HeaderText = "DefaultSetKomokuSeikyuUmuKbnCol";
            this.DefaultSetKomokuSeikyuUmuKbnCol.Name = "DefaultSetKomokuSeikyuUmuKbnCol";
            this.DefaultSetKomokuSeikyuUmuKbnCol.Visible = false;
            // 
            // setCdTextBox
            // 
            this.setCdTextBox.CustomControlDomain = Zynas.Control.Common.ZControlDomain.NONE;
            this.setCdTextBox.CustomDigitParts = 0;
            this.setCdTextBox.CustomFormat = null;
            this.setCdTextBox.CustomInputMode = FukjBizSystem.Control.NumberTextBox.InputMode.Int;
            this.setCdTextBox.CustomReadOnly = false;
            this.setCdTextBox.Location = new System.Drawing.Point(156, 24);
            this.setCdTextBox.Name = "setCdTextBox";
            this.setCdTextBox.Size = new System.Drawing.Size(35, 27);
            this.setCdTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(337, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "円";
            // 
            // shukeiButton
            // 
            this.shukeiButton.Location = new System.Drawing.Point(380, 123);
            this.shukeiButton.Name = "shukeiButton";
            this.shukeiButton.Size = new System.Drawing.Size(101, 27);
            this.shukeiButton.TabIndex = 13;
            this.shukeiButton.Text = "集計";
            this.shukeiButton.UseVisualStyleBackColor = true;
            this.shukeiButton.Click += new System.EventHandler(this.shukeiButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Red;
            this.label26.Location = new System.Drawing.Point(143, 162);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 20);
            this.label26.TabIndex = 15;
            this.label26.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "セット試験項目一覧";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(89, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "セット料金";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(133, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "セット名称（略式）";
            // 
            // setNmRyakushoTextBox
            // 
            this.setNmRyakushoTextBox.Location = new System.Drawing.Point(156, 90);
            this.setNmRyakushoTextBox.MaxLength = 30;
            this.setNmRyakushoTextBox.Name = "setNmRyakushoTextBox";
            this.setNmRyakushoTextBox.Size = new System.Drawing.Size(628, 27);
            this.setNmRyakushoTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(101, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(133, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "セットコード";
            // 
            // setNmTextBox
            // 
            this.setNmTextBox.Location = new System.Drawing.Point(156, 57);
            this.setNmTextBox.MaxLength = 80;
            this.setNmTextBox.Name = "setNmTextBox";
            this.setNmTextBox.Size = new System.Drawing.Size(628, 27);
            this.setNmTextBox.TabIndex = 5;
            // 
            // entryButton
            // 
            this.entryButton.Location = new System.Drawing.Point(421, 553);
            this.entryButton.Name = "entryButton";
            this.entryButton.Size = new System.Drawing.Size(101, 37);
            this.entryButton.TabIndex = 17;
            this.entryButton.Text = "F1:登録";
            this.entryButton.UseVisualStyleBackColor = true;
            this.entryButton.Click += new System.EventHandler(this.entryButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(528, 553);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(101, 37);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "F2:変更";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(849, 553);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(101, 37);
            this.decisionButton.TabIndex = 21;
            this.decisionButton.Text = "F5:確定";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // reInputButton
            // 
            this.reInputButton.Location = new System.Drawing.Point(742, 553);
            this.reInputButton.Name = "reInputButton";
            this.reInputButton.Size = new System.Drawing.Size(101, 37);
            this.reInputButton.TabIndex = 20;
            this.reInputButton.Text = "F4:再入力";
            this.reInputButton.UseVisualStyleBackColor = true;
            this.reInputButton.Click += new System.EventHandler(this.reInputButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(635, 553);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(101, 37);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "F3:削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(991, 553);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 37);
            this.closeButton.TabIndex = 22;
            this.closeButton.Text = "F12:閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // suishitsuShikenKoumokuMstTableAdapter
            // 
            this.suishitsuShikenKoumokuMstTableAdapter.ClearBeforeFill = true;
            // 
            // suishitsuKensaSetMstShosaiTableAdapter
            // 
            this.suishitsuKensaSetMstShosaiTableAdapter.ClearBeforeFill = true;
            // 
            // suishitsuKensaSetMstShosaiBindingSource
            // 
            this.suishitsuKensaSetMstShosaiBindingSource.DataMember = "SuishitsuKensaSetMstShosai";
            // 
            // suishitsuKensaSetMstDataSet
            // 
            this.suishitsuKensaSetMstDataSet.DataSetName = "SuishitsuKensaSetMstDataSet";
            this.suishitsuKensaSetMstDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SuishitsuKensaSetMstShosaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "SuishitsuKensaSetMstShosaiForm";
            this.Text = "保健所情報";
            this.Load += new System.EventHandler(this.SuishitsuKensaSetMstShosaiForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SuishitsuKensaSetMstShosaiForm_KeyDown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setShikenListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuShikenKoumokuMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuShikenKoumokuMstDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuKensaSetMstShosaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suishitsuKensaSetMstDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button entryButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.Button reInputButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox setNmTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox setNmRyakushoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView setShikenListDataGridView;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button shukeiButton;
        private System.Windows.Forms.Label label10;
        private Control.NumberTextBox setCdTextBox;
        private DataSet.SuishitsuShikenKoumokuMstDataSet suishitsuShikenKoumokuMstDataSet;
        private System.Windows.Forms.BindingSource suishitsuShikenKoumokuMstBindingSource;
        private DataSet.SuishitsuShikenKoumokuMstDataSetTableAdapters.SuishitsuShikenKoumokuMstTableAdapter suishitsuShikenKoumokuMstTableAdapter;
        private DataSet.SuishitsuKensaSetMstDataSetTableAdapters.SuishitsuKensaSetMstShosaiTableAdapter suishitsuKensaSetMstShosaiTableAdapter;
        private System.Windows.Forms.BindingSource suishitsuKensaSetMstShosaiBindingSource;
        private DataSet.SuishitsuKensaSetMstDataSet suishitsuKensaSetMstDataSet;
        private Control.ZTextBox setRyoukinTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetKomokuSetCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetKomokuCdCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn SetKomokuNmCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetKomokuRyokinCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ShomeishoKisaiKbnCol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SetKomokuSeikyuUmuKbnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuishitsuShikenKoumokuCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultSetKomokuCdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultShomeishoKisaiKbnCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultSetKomokuSeikyuUmuKbnCol;
    }
}