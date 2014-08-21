namespace FukjBizSystem.Application.Boundary.Others
{
    partial class JokasoDaichoSyukeiListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.JokasoListDataGridView = new System.Windows.Forms.DataGridView();
            this.Hokenjo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UketsukeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JuriDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KensaDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KensaKbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanrisyaNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyoriHoshiki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ninso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoryuBod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiteki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyashinPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyashinUmu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IjiKanriGyosya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HosyuTenkenGyosya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KaizenHoho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Biko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaeukekinListPanel = new System.Windows.Forms.Panel();
            this.ListCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.viewChangeButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.HokenjoNmComboBox = new System.Windows.Forms.ComboBox();
            this.MijukenRadioButton = new System.Windows.Forms.RadioButton();
            this.IkoJokyoRadioButton = new System.Windows.Forms.RadioButton();
            this.MukanriRadioButton = new System.Windows.Forms.RadioButton();
            this.FutekiseiRadioButton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NyukinDtToTextBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.NyukinDtFromTextBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.tojiruButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JokasoListDataGridView)).BeginInit();
            this.MaeukekinListPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JokasoListDataGridView
            // 
            this.JokasoListDataGridView.AllowUserToAddRows = false;
            this.JokasoListDataGridView.AllowUserToDeleteRows = false;
            this.JokasoListDataGridView.AllowUserToResizeRows = false;
            this.JokasoListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JokasoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JokasoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hokenjo,
            this.UketsukeNo,
            this.JuriDt,
            this.KensaDt,
            this.KensaKbn,
            this.KanrisyaNm,
            this.AdrCol,
            this.Tel,
            this.SyoriHoshiki,
            this.Ninso,
            this.HoryuBod,
            this.Shiteki,
            this.SyashinPath,
            this.SyashinUmu,
            this.IjiKanriGyosya,
            this.HosyuTenkenGyosya,
            this.KaizenHoho,
            this.Biko});
            this.JokasoListDataGridView.Location = new System.Drawing.Point(2, 23);
            this.JokasoListDataGridView.MultiSelect = false;
            this.JokasoListDataGridView.Name = "JokasoListDataGridView";
            this.JokasoListDataGridView.RowHeadersVisible = false;
            this.JokasoListDataGridView.RowTemplate.Height = 21;
            this.JokasoListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JokasoListDataGridView.Size = new System.Drawing.Size(1085, 373);
            this.JokasoListDataGridView.TabIndex = 0;
            // 
            // Hokenjo
            // 
            this.Hokenjo.HeaderText = "保健所";
            this.Hokenjo.MinimumWidth = 100;
            this.Hokenjo.Name = "Hokenjo";
            this.Hokenjo.ReadOnly = true;
            // 
            // UketsukeNo
            // 
            this.UketsukeNo.HeaderText = "受付番号";
            this.UketsukeNo.MinimumWidth = 90;
            this.UketsukeNo.Name = "UketsukeNo";
            this.UketsukeNo.ReadOnly = true;
            this.UketsukeNo.Width = 90;
            // 
            // JuriDt
            // 
            this.JuriDt.HeaderText = "受理日";
            this.JuriDt.MinimumWidth = 90;
            this.JuriDt.Name = "JuriDt";
            this.JuriDt.ReadOnly = true;
            this.JuriDt.Width = 90;
            // 
            // KensaDt
            // 
            this.KensaDt.HeaderText = "検査日";
            this.KensaDt.MinimumWidth = 90;
            this.KensaDt.Name = "KensaDt";
            this.KensaDt.ReadOnly = true;
            this.KensaDt.Width = 90;
            // 
            // KensaKbn
            // 
            this.KensaKbn.HeaderText = "検査区分";
            this.KensaKbn.MinimumWidth = 80;
            this.KensaKbn.Name = "KensaKbn";
            this.KensaKbn.ReadOnly = true;
            this.KensaKbn.Width = 80;
            // 
            // KanrisyaNm
            // 
            this.KanrisyaNm.HeaderText = "管理者名";
            this.KanrisyaNm.MinimumWidth = 100;
            this.KanrisyaNm.Name = "KanrisyaNm";
            this.KanrisyaNm.ReadOnly = true;
            // 
            // AdrCol
            // 
            this.AdrCol.HeaderText = "住所";
            this.AdrCol.MinimumWidth = 150;
            this.AdrCol.Name = "AdrCol";
            this.AdrCol.ReadOnly = true;
            this.AdrCol.Width = 150;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "電話番号";
            this.Tel.MinimumWidth = 120;
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            this.Tel.Width = 120;
            // 
            // SyoriHoshiki
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SyoriHoshiki.DefaultCellStyle = dataGridViewCellStyle1;
            this.SyoriHoshiki.HeaderText = "処理方式";
            this.SyoriHoshiki.MinimumWidth = 70;
            this.SyoriHoshiki.Name = "SyoriHoshiki";
            this.SyoriHoshiki.ReadOnly = true;
            this.SyoriHoshiki.Width = 70;
            // 
            // Ninso
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Ninso.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ninso.HeaderText = "人槽";
            this.Ninso.MinimumWidth = 60;
            this.Ninso.Name = "Ninso";
            this.Ninso.ReadOnly = true;
            this.Ninso.Width = 60;
            // 
            // HoryuBod
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HoryuBod.DefaultCellStyle = dataGridViewCellStyle3;
            this.HoryuBod.HeaderText = "放流水BOD";
            this.HoryuBod.MinimumWidth = 80;
            this.HoryuBod.Name = "HoryuBod";
            this.HoryuBod.ReadOnly = true;
            this.HoryuBod.Width = 80;
            // 
            // Shiteki
            // 
            this.Shiteki.HeaderText = "主な指摘";
            this.Shiteki.MinimumWidth = 200;
            this.Shiteki.Name = "Shiteki";
            this.Shiteki.ReadOnly = true;
            this.Shiteki.Width = 200;
            // 
            // SyashinPath
            // 
            this.SyashinPath.HeaderText = "写真パス";
            this.SyashinPath.Name = "SyashinPath";
            this.SyashinPath.ReadOnly = true;
            this.SyashinPath.Visible = false;
            // 
            // SyashinUmu
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SyashinUmu.DefaultCellStyle = dataGridViewCellStyle4;
            this.SyashinUmu.HeaderText = "写真有無";
            this.SyashinUmu.MinimumWidth = 70;
            this.SyashinUmu.Name = "SyashinUmu";
            this.SyashinUmu.ReadOnly = true;
            this.SyashinUmu.Width = 70;
            // 
            // IjiKanriGyosya
            // 
            this.IjiKanriGyosya.HeaderText = "維持管理業者";
            this.IjiKanriGyosya.MinimumWidth = 140;
            this.IjiKanriGyosya.Name = "IjiKanriGyosya";
            this.IjiKanriGyosya.ReadOnly = true;
            this.IjiKanriGyosya.Width = 140;
            // 
            // HosyuTenkenGyosya
            // 
            this.HosyuTenkenGyosya.HeaderText = "保守点検業者";
            this.HosyuTenkenGyosya.MinimumWidth = 140;
            this.HosyuTenkenGyosya.Name = "HosyuTenkenGyosya";
            this.HosyuTenkenGyosya.ReadOnly = true;
            this.HosyuTenkenGyosya.Width = 140;
            // 
            // KaizenHoho
            // 
            this.KaizenHoho.HeaderText = "改善方法";
            this.KaizenHoho.MinimumWidth = 200;
            this.KaizenHoho.Name = "KaizenHoho";
            this.KaizenHoho.ReadOnly = true;
            this.KaizenHoho.Width = 200;
            // 
            // Biko
            // 
            this.Biko.HeaderText = "備考";
            this.Biko.MinimumWidth = 100;
            this.Biko.Name = "Biko";
            this.Biko.ReadOnly = true;
            // 
            // MaeukekinListPanel
            // 
            this.MaeukekinListPanel.Controls.Add(this.ListCountLabel);
            this.MaeukekinListPanel.Controls.Add(this.label4);
            this.MaeukekinListPanel.Controls.Add(this.JokasoListDataGridView);
            this.MaeukekinListPanel.Location = new System.Drawing.Point(1, 139);
            this.MaeukekinListPanel.Name = "MaeukekinListPanel";
            this.MaeukekinListPanel.Size = new System.Drawing.Size(1090, 399);
            this.MaeukekinListPanel.TabIndex = 1;
            // 
            // ListCountLabel
            // 
            this.ListCountLabel.AutoSize = true;
            this.ListCountLabel.Location = new System.Drawing.Point(987, 0);
            this.ListCountLabel.Name = "ListCountLabel";
            this.ListCountLabel.Size = new System.Drawing.Size(30, 20);
            this.ListCountLabel.TabIndex = 2;
            this.ListCountLabel.Text = "0件";
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
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(854, 544);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(101, 37);
            this.outputButton.TabIndex = 4;
            this.outputButton.Text = "F6:帳票出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // viewChangeButton
            // 
            this.viewChangeButton.Location = new System.Drawing.Point(1058, 0);
            this.viewChangeButton.Name = "viewChangeButton";
            this.viewChangeButton.Size = new System.Drawing.Size(29, 21);
            this.viewChangeButton.TabIndex = 11;
            this.viewChangeButton.Text = "▲";
            this.viewChangeButton.UseVisualStyleBackColor = true;
            this.viewChangeButton.Click += new System.EventHandler(this.ViewChangeButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.label9);
            this.searchPanel.Controls.Add(this.HokenjoNmComboBox);
            this.searchPanel.Controls.Add(this.MijukenRadioButton);
            this.searchPanel.Controls.Add(this.IkoJokyoRadioButton);
            this.searchPanel.Controls.Add(this.MukanriRadioButton);
            this.searchPanel.Controls.Add(this.FutekiseiRadioButton);
            this.searchPanel.Controls.Add(this.label8);
            this.searchPanel.Controls.Add(this.panel1);
            this.searchPanel.Controls.Add(this.label7);
            this.searchPanel.Controls.Add(this.NyukinDtToTextBox);
            this.searchPanel.Controls.Add(this.label5);
            this.searchPanel.Controls.Add(this.NyukinDtFromTextBox);
            this.searchPanel.Controls.Add(this.viewChangeButton);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.clearButton);
            this.searchPanel.Controls.Add(this.kensakuButton);
            this.searchPanel.Location = new System.Drawing.Point(1, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1090, 136);
            this.searchPanel.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 198;
            this.label9.Text = "保健所";
            // 
            // HokenjoNmComboBox
            // 
            this.HokenjoNmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HokenjoNmComboBox.FormattingEnabled = true;
            this.HokenjoNmComboBox.Location = new System.Drawing.Point(110, 65);
            this.HokenjoNmComboBox.Name = "HokenjoNmComboBox";
            this.HokenjoNmComboBox.Size = new System.Drawing.Size(191, 28);
            this.HokenjoNmComboBox.TabIndex = 199;
            // 
            // MijukenRadioButton
            // 
            this.MijukenRadioButton.AutoSize = true;
            this.MijukenRadioButton.Location = new System.Drawing.Point(480, 34);
            this.MijukenRadioButton.Name = "MijukenRadioButton";
            this.MijukenRadioButton.Size = new System.Drawing.Size(121, 24);
            this.MijukenRadioButton.TabIndex = 197;
            this.MijukenRadioButton.Text = "11条検査未受験";
            this.MijukenRadioButton.UseVisualStyleBackColor = true;
            this.MijukenRadioButton.CheckedChanged += new System.EventHandler(this.MijukenRadioButton_CheckedChanged);
            // 
            // IkoJokyoRadioButton
            // 
            this.IkoJokyoRadioButton.AutoSize = true;
            this.IkoJokyoRadioButton.Location = new System.Drawing.Point(332, 34);
            this.IkoJokyoRadioButton.Name = "IkoJokyoRadioButton";
            this.IkoJokyoRadioButton.Size = new System.Drawing.Size(142, 24);
            this.IkoJokyoRadioButton.TabIndex = 196;
            this.IkoJokyoRadioButton.Text = "7条⇒11条移行状況";
            this.IkoJokyoRadioButton.UseVisualStyleBackColor = true;
            this.IkoJokyoRadioButton.CheckedChanged += new System.EventHandler(this.IkoJokyoRadioButton_CheckedChanged);
            // 
            // MukanriRadioButton
            // 
            this.MukanriRadioButton.AutoSize = true;
            this.MukanriRadioButton.Location = new System.Drawing.Point(221, 34);
            this.MukanriRadioButton.Name = "MukanriRadioButton";
            this.MukanriRadioButton.Size = new System.Drawing.Size(105, 24);
            this.MukanriRadioButton.TabIndex = 195;
            this.MukanriRadioButton.Text = "無管理浄化槽";
            this.MukanriRadioButton.UseVisualStyleBackColor = true;
            this.MukanriRadioButton.CheckedChanged += new System.EventHandler(this.MukanriRadioButton_CheckedChanged);
            // 
            // FutekiseiRadioButton
            // 
            this.FutekiseiRadioButton.AutoSize = true;
            this.FutekiseiRadioButton.Checked = true;
            this.FutekiseiRadioButton.Location = new System.Drawing.Point(110, 34);
            this.FutekiseiRadioButton.Name = "FutekiseiRadioButton";
            this.FutekiseiRadioButton.Size = new System.Drawing.Size(105, 24);
            this.FutekiseiRadioButton.TabIndex = 194;
            this.FutekiseiRadioButton.TabStop = true;
            this.FutekiseiRadioButton.Text = "不適正浄化槽";
            this.FutekiseiRadioButton.UseVisualStyleBackColor = true;
            this.FutekiseiRadioButton.CheckedChanged += new System.EventHandler(this.FutekiseiRadioButton_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 193;
            this.label8.Text = "出力帳票";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(809, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 50);
            this.panel1.TabIndex = 92;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "～";
            // 
            // NyukinDtToTextBox
            // 
            this.NyukinDtToTextBox.Location = new System.Drawing.Point(288, 99);
            this.NyukinDtToTextBox.Name = "NyukinDtToTextBox";
            this.NyukinDtToTextBox.Size = new System.Drawing.Size(145, 27);
            this.NyukinDtToTextBox.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "対象期間";
            // 
            // NyukinDtFromTextBox
            // 
            this.NyukinDtFromTextBox.Location = new System.Drawing.Point(109, 99);
            this.NyukinDtFromTextBox.Name = "NyukinDtFromTextBox";
            this.NyukinDtFromTextBox.Size = new System.Drawing.Size(145, 27);
            this.NyukinDtFromTextBox.TabIndex = 87;
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
            this.clearButton.Location = new System.Drawing.Point(868, 96);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(101, 37);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "F7:クリア";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kensakuButton
            // 
            this.kensakuButton.Location = new System.Drawing.Point(975, 95);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(101, 37);
            this.kensakuButton.TabIndex = 10;
            this.kensakuButton.Text = "F8:検索";
            this.kensakuButton.UseVisualStyleBackColor = true;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // tojiruButton
            // 
            this.tojiruButton.Location = new System.Drawing.Point(990, 544);
            this.tojiruButton.Name = "tojiruButton";
            this.tojiruButton.Size = new System.Drawing.Size(101, 37);
            this.tojiruButton.TabIndex = 5;
            this.tojiruButton.Text = "F12:閉じる";
            this.tojiruButton.UseVisualStyleBackColor = true;
            this.tojiruButton.Click += new System.EventHandler(this.tojiruButton_Click);
            // 
            // JokasoDaichoSyukeiListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.MaeukekinListPanel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.tojiruButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JokasoDaichoSyukeiListForm";
            this.Text = "浄化槽台帳集計";
            ((System.ComponentModel.ISupportInitialize)(this.JokasoListDataGridView)).EndInit();
            this.MaeukekinListPanel.ResumeLayout(false);
            this.MaeukekinListPanel.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JokasoListDataGridView;
        private System.Windows.Forms.Panel MaeukekinListPanel;
        private System.Windows.Forms.Label ListCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button viewChangeButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button kensakuButton;
        private System.Windows.Forms.Button tojiruButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker NyukinDtToTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NyukinDtFromTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton MijukenRadioButton;
        private System.Windows.Forms.RadioButton IkoJokyoRadioButton;
        private System.Windows.Forms.RadioButton MukanriRadioButton;
        private System.Windows.Forms.RadioButton FutekiseiRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox HokenjoNmComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hokenjo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UketsukeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn JuriDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn KensaDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn KensaKbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanrisyaNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdrCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyoriHoshiki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ninso;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoryuBod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shiteki;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyashinPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyashinUmu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IjiKanriGyosya;
        private System.Windows.Forms.DataGridViewTextBoxColumn HosyuTenkenGyosya;
        private System.Windows.Forms.DataGridViewTextBoxColumn KaizenHoho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Biko;

    }
}