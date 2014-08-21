namespace FukjTabletSystem.Application.Boundary.Demo.SuishitsuKensa
{
    partial class SuishitsuKensaEntryForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuishitsuKensaEntryForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.elementLayoutPanel = new FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.doComboBox = new System.Windows.Forms.ComboBox();
            this.doTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phTextBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.phComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ensoTextBox = new System.Windows.Forms.TextBox();
            this.trTextBox = new System.Windows.Forms.TextBox();
            this.svTextBox = new System.Windows.Forms.TextBox();
            this.trComboBox = new System.Windows.Forms.ComboBox();
            this.ensoComboBox = new System.Windows.Forms.ComboBox();
            this.svComboBox = new System.Windows.Forms.ComboBox();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.elementLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Controls.Add(this.elementLayoutPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 858);
            this.mainPanel.TabIndex = 0;
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.BackColor = System.Drawing.Color.LightGreen;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Image = ((System.Drawing.Image)(resources.GetObject("inputButton.Image")));
            this.inputButton.Location = new System.Drawing.Point(708, 8);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(80, 64);
            this.inputButton.TabIndex = 123;
            this.inputButton.TabStop = false;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // cameraButton
            // 
            this.cameraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraButton.BackColor = System.Drawing.Color.LightGreen;
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.Image = global::FukjTabletSystem.Properties.Resources.Camera;
            this.cameraButton.Location = new System.Drawing.Point(622, 8);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(80, 64);
            this.cameraButton.TabIndex = 122;
            this.cameraButton.TabStop = false;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // headerControl1
            // 
            this.headerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl1.BackColor = System.Drawing.Color.LightGreen;
            this.headerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerControl1.Font = new System.Drawing.Font("メイリオ", 20F);
            this.headerControl1.Location = new System.Drawing.Point(0, 0);
            this.headerControl1.Margin = new System.Windows.Forms.Padding(0);
            this.headerControl1.MaximumSize = new System.Drawing.Size(1920, 80);
            this.headerControl1.MinimumSize = new System.Drawing.Size(800, 80);
            this.headerControl1.Name = "headerControl1";
            this.headerControl1.Size = new System.Drawing.Size(800, 80);
            this.headerControl1.TabIndex = 1;
            // 
            // elementLayoutPanel
            // 
            this.elementLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementLayoutPanel.AutoScroll = true;
            this.elementLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.elementLayoutPanel.Controls.Add(this.tableLayoutPanel2);
            this.elementLayoutPanel.Controls.Add(this.tableLayoutPanel3);
            this.elementLayoutPanel.Controls.Add(this.kakuteiButton);
            this.elementLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elementLayoutPanel.Location = new System.Drawing.Point(3, 83);
            this.elementLayoutPanel.Name = "elementLayoutPanel";
            this.elementLayoutPanel.Padding = new System.Windows.Forms.Padding(21, 0, 21, 0);
            this.elementLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elementLayoutPanel.Size = new System.Drawing.Size(794, 772);
            this.elementLayoutPanel.TabIndex = 0;
            this.elementLayoutPanel.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 90);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "判断";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "測定値";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "項目";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Controls.Add(this.doComboBox, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.doTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.phTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.phComboBox, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 90);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 111);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // doComboBox
            // 
            this.doComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doComboBox.FormattingEnabled = true;
            this.doComboBox.Items.AddRange(new object[] {
            "",
            "適正",
            "概ね",
            "不適正"});
            this.doComboBox.Location = new System.Drawing.Point(576, 59);
            this.doComboBox.Name = "doComboBox";
            this.doComboBox.Size = new System.Drawing.Size(172, 49);
            this.doComboBox.TabIndex = 9;
            // 
            // doTextBox
            // 
            this.doTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doTextBox.Location = new System.Drawing.Point(175, 59);
            this.doTextBox.Name = "doTextBox";
            this.doTextBox.Size = new System.Drawing.Size(149, 47);
            this.doTextBox.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(420, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 47);
            this.textBox2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 41);
            this.label8.TabIndex = 5;
            this.label8.Text = "DO";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "pH";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 41);
            this.label5.TabIndex = 2;
            this.label5.Text = "水温";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 41);
            this.label7.TabIndex = 7;
            this.label7.Text = "~";
            // 
            // phTextBox
            // 
            this.phTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phTextBox.Location = new System.Drawing.Point(175, 4);
            this.phTextBox.Name = "phTextBox";
            this.phTextBox.Size = new System.Drawing.Size(149, 47);
            this.phTextBox.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(420, 59);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(149, 47);
            this.textBox6.TabIndex = 8;
            // 
            // phComboBox
            // 
            this.phComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.phComboBox.FormattingEnabled = true;
            this.phComboBox.Items.AddRange(new object[] {
            "",
            "適正",
            "概ね",
            "不適正"});
            this.phComboBox.Location = new System.Drawing.Point(576, 4);
            this.phComboBox.Name = "phComboBox";
            this.phComboBox.Size = new System.Drawing.Size(172, 49);
            this.phComboBox.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ensoTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.trTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.svTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.trComboBox, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ensoComboBox, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.svComboBox, 2, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(21, 201);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(750, 166);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 41);
            this.label12.TabIndex = 6;
            this.label12.Text = "SV30";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 41);
            this.label9.TabIndex = 0;
            this.label9.Text = "透視度";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 41);
            this.label10.TabIndex = 3;
            this.label10.Text = "残留塩素";
            // 
            // ensoTextBox
            // 
            this.ensoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ensoTextBox.Location = new System.Drawing.Point(175, 59);
            this.ensoTextBox.Name = "ensoTextBox";
            this.ensoTextBox.Size = new System.Drawing.Size(394, 47);
            this.ensoTextBox.TabIndex = 4;
            // 
            // trTextBox
            // 
            this.trTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trTextBox.Location = new System.Drawing.Point(175, 4);
            this.trTextBox.Name = "trTextBox";
            this.trTextBox.Size = new System.Drawing.Size(394, 47);
            this.trTextBox.TabIndex = 1;
            // 
            // svTextBox
            // 
            this.svTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svTextBox.Location = new System.Drawing.Point(175, 114);
            this.svTextBox.Name = "svTextBox";
            this.svTextBox.Size = new System.Drawing.Size(394, 47);
            this.svTextBox.TabIndex = 7;
            // 
            // trComboBox
            // 
            this.trComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trComboBox.FormattingEnabled = true;
            this.trComboBox.Items.AddRange(new object[] {
            "",
            "適正",
            "概ね",
            "不適正"});
            this.trComboBox.Location = new System.Drawing.Point(576, 4);
            this.trComboBox.Name = "trComboBox";
            this.trComboBox.Size = new System.Drawing.Size(172, 49);
            this.trComboBox.TabIndex = 2;
            // 
            // ensoComboBox
            // 
            this.ensoComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ensoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ensoComboBox.FormattingEnabled = true;
            this.ensoComboBox.Items.AddRange(new object[] {
            "",
            "適正",
            "概ね",
            "不適正"});
            this.ensoComboBox.Location = new System.Drawing.Point(576, 59);
            this.ensoComboBox.Name = "ensoComboBox";
            this.ensoComboBox.Size = new System.Drawing.Size(172, 49);
            this.ensoComboBox.TabIndex = 5;
            // 
            // svComboBox
            // 
            this.svComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.svComboBox.FormattingEnabled = true;
            this.svComboBox.Items.AddRange(new object[] {
            "",
            "適正",
            "概ね",
            "不適正"});
            this.svComboBox.Location = new System.Drawing.Point(576, 114);
            this.svComboBox.Name = "svComboBox";
            this.svComboBox.Size = new System.Drawing.Size(172, 49);
            this.svComboBox.TabIndex = 8;
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(271, 387);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(250, 86);
            this.kakuteiButton.TabIndex = 4;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
            // 
            // SuishitsuKensaEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 858);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Name = "SuishitsuKensaEntryForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.SuishitsuKensaEntryForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.elementLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel elementLayoutPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox doComboBox;
        private System.Windows.Forms.TextBox doTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phTextBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox phComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ensoTextBox;
        private System.Windows.Forms.TextBox trTextBox;
        private System.Windows.Forms.TextBox svTextBox;
        private System.Windows.Forms.ComboBox trComboBox;
        private System.Windows.Forms.ComboBox ensoComboBox;
        private System.Windows.Forms.ComboBox svComboBox;
        private System.Windows.Forms.Button kakuteiButton;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}