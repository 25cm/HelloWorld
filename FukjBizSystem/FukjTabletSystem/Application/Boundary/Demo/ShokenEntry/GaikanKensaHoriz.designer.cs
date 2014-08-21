namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    partial class GaikanKensaHorizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaikanKensaHorizForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.renrakuPanel = new System.Windows.Forms.Panel();
            this.renrakuLabel = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.soutiAddButton = new System.Windows.Forms.Button();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.elementPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.shokenItemLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.shokenCheckNoLabel = new System.Windows.Forms.Label();
            this.shokenLevelLabel = new System.Windows.Forms.Label();
            this.shokenJudgeLabel = new System.Windows.Forms.Label();
            this.autoCondLabel = new System.Windows.Forms.Label();
            this.judgeLabel = new System.Windows.Forms.Label();
            this.shokenAutoCondLabel = new System.Windows.Forms.Label();
            this.checkNoLabel = new System.Windows.Forms.Label();
            this.handanLabel = new System.Windows.Forms.Label();
            this.shokenHandanLabel = new System.Windows.Forms.Label();
            this.shokenDescLabel = new System.Windows.Forms.Label();
            this.teidoListBox = new System.Windows.Forms.ListBox();
            this.shouListBox = new System.Windows.Forms.ListBox();
            this.chuListBox = new System.Windows.Forms.ListBox();
            this.daiListBox = new System.Windows.Forms.ListBox();
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            this.renrakuPanel.SuspendLayout();
            this.elementPanel1.SuspendLayout();
            this.shokenItemLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.renrakuPanel);
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.soutiAddButton);
            this.mainPanel.Controls.Add(this.kakuteiButton);
            this.mainPanel.Controls.Add(this.elementPanel1);
            this.mainPanel.Controls.Add(this.teidoListBox);
            this.mainPanel.Controls.Add(this.shouListBox);
            this.mainPanel.Controls.Add(this.chuListBox);
            this.mainPanel.Controls.Add(this.daiListBox);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1280, 858);
            this.mainPanel.TabIndex = 4;
            // 
            // renrakuPanel
            // 
            this.renrakuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.renrakuPanel.BackColor = System.Drawing.Color.White;
            this.renrakuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.renrakuPanel.Controls.Add(this.renrakuLabel);
            this.renrakuPanel.Controls.Add(this.checkBox4);
            this.renrakuPanel.Controls.Add(this.checkBox5);
            this.renrakuPanel.Controls.Add(this.checkBox6);
            this.renrakuPanel.Controls.Add(this.checkBox3);
            this.renrakuPanel.Controls.Add(this.checkBox2);
            this.renrakuPanel.Controls.Add(this.checkBox1);
            this.renrakuPanel.Location = new System.Drawing.Point(751, 571);
            this.renrakuPanel.Name = "renrakuPanel";
            this.renrakuPanel.Size = new System.Drawing.Size(515, 162);
            this.renrakuPanel.TabIndex = 125;
            // 
            // renrakuLabel
            // 
            this.renrakuLabel.AutoSize = true;
            this.renrakuLabel.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.renrakuLabel.Location = new System.Drawing.Point(12, 9);
            this.renrakuLabel.Name = "renrakuLabel";
            this.renrakuLabel.Size = new System.Drawing.Size(203, 31);
            this.renrakuLabel.TabIndex = 6;
            this.renrakuLabel.Text = "関係者への連絡事項";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox4.Location = new System.Drawing.Point(7, 102);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(121, 46);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "工事業者";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox5.AutoSize = true;
            this.checkBox5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox5.Location = new System.Drawing.Point(134, 102);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(121, 46);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "メーカー";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6.AutoSize = true;
            this.checkBox6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox6.Location = new System.Drawing.Point(261, 102);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(241, 46);
            this.checkBox6.TabIndex = 3;
            this.checkBox6.Text = "保健福祉環境事務所";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox3.Location = new System.Drawing.Point(285, 46);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 46);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "清掃業者";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox2.Location = new System.Drawing.Point(110, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(169, 46);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "保守点検業者";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox1.Location = new System.Drawing.Point(7, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 46);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "設置者";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.BackColor = System.Drawing.Color.LightGreen;
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Image = ((System.Drawing.Image)(resources.GetObject("inputButton.Image")));
            this.inputButton.Location = new System.Drawing.Point(1188, 8);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(80, 64);
            this.inputButton.TabIndex = 124;
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
            this.cameraButton.Location = new System.Drawing.Point(1102, 8);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(80, 64);
            this.cameraButton.TabIndex = 123;
            this.cameraButton.TabStop = false;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // soutiAddButton
            // 
            this.soutiAddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soutiAddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soutiAddButton.Location = new System.Drawing.Point(751, 743);
            this.soutiAddButton.Margin = new System.Windows.Forms.Padding(20);
            this.soutiAddButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.soutiAddButton.Name = "soutiAddButton";
            this.soutiAddButton.Size = new System.Drawing.Size(250, 86);
            this.soutiAddButton.TabIndex = 122;
            this.soutiAddButton.Text = "装置追加";
            this.soutiAddButton.UseVisualStyleBackColor = true;
            this.soutiAddButton.Click += new System.EventHandler(this.soutiAddButton_Click);
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(1018, 743);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(250, 86);
            this.kakuteiButton.TabIndex = 121;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
            // 
            // elementPanel1
            // 
            this.elementPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementPanel1.Controls.Add(this.shokenItemLayoutPanel);
            this.elementPanel1.Controls.Add(this.shokenDescLabel);
            this.elementPanel1.Font = new System.Drawing.Font("メイリオ", 12F);
            this.elementPanel1.Location = new System.Drawing.Point(12, 571);
            this.elementPanel1.Name = "elementPanel1";
            this.elementPanel1.Size = new System.Drawing.Size(713, 258);
            this.elementPanel1.TabIndex = 120;
            // 
            // shokenItemLayoutPanel
            // 
            this.shokenItemLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenItemLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.shokenItemLayoutPanel.ColumnCount = 5;
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.shokenItemLayoutPanel.Controls.Add(this.levelLabel, 2, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenCheckNoLabel, 0, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenLevelLabel, 2, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenJudgeLabel, 3, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.autoCondLabel, 4, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.judgeLabel, 3, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenAutoCondLabel, 4, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.checkNoLabel, 0, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.handanLabel, 1, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenHandanLabel, 1, 0);
            this.shokenItemLayoutPanel.Font = new System.Drawing.Font("メイリオ", 16F);
            this.shokenItemLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.shokenItemLayoutPanel.MinimumSize = new System.Drawing.Size(550, 80);
            this.shokenItemLayoutPanel.Name = "shokenItemLayoutPanel";
            this.shokenItemLayoutPanel.RowCount = 2;
            this.shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.shokenItemLayoutPanel.Size = new System.Drawing.Size(704, 80);
            this.shokenItemLayoutPanel.TabIndex = 0;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(274, 43);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(30, 33);
            this.levelLabel.TabIndex = 11;
            this.levelLabel.Text = "A";
            // 
            // shokenCheckNoLabel
            // 
            this.shokenCheckNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenCheckNoLabel.AutoSize = true;
            this.shokenCheckNoLabel.Location = new System.Drawing.Point(15, 4);
            this.shokenCheckNoLabel.Name = "shokenCheckNoLabel";
            this.shokenCheckNoLabel.Size = new System.Drawing.Size(147, 33);
            this.shokenCheckNoLabel.TabIndex = 0;
            this.shokenCheckNoLabel.Text = "チェック番号";
            // 
            // shokenLevelLabel
            // 
            this.shokenLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenLevelLabel.AutoSize = true;
            this.shokenLevelLabel.Location = new System.Drawing.Point(249, 4);
            this.shokenLevelLabel.Name = "shokenLevelLabel";
            this.shokenLevelLabel.Size = new System.Drawing.Size(81, 33);
            this.shokenLevelLabel.TabIndex = 2;
            this.shokenLevelLabel.Text = "重要度";
            // 
            // shokenJudgeLabel
            // 
            this.shokenJudgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenJudgeLabel.AutoSize = true;
            this.shokenJudgeLabel.Location = new System.Drawing.Point(377, 4);
            this.shokenJudgeLabel.Name = "shokenJudgeLabel";
            this.shokenJudgeLabel.Size = new System.Drawing.Size(59, 33);
            this.shokenJudgeLabel.TabIndex = 3;
            this.shokenJudgeLabel.Text = "判定";
            // 
            // autoCondLabel
            // 
            this.autoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoCondLabel.AutoSize = true;
            this.autoCondLabel.Location = new System.Drawing.Point(593, 43);
            this.autoCondLabel.Name = "autoCondLabel";
            this.autoCondLabel.Size = new System.Drawing.Size(22, 33);
            this.autoCondLabel.TabIndex = 9;
            this.autoCondLabel.Text = " ";
            // 
            // judgeLabel
            // 
            this.judgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.judgeLabel.AutoSize = true;
            this.judgeLabel.Location = new System.Drawing.Point(366, 43);
            this.judgeLabel.Name = "judgeLabel";
            this.judgeLabel.Size = new System.Drawing.Size(81, 33);
            this.judgeLabel.TabIndex = 8;
            this.judgeLabel.Text = "不適正";
            // 
            // shokenAutoCondLabel
            // 
            this.shokenAutoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenAutoCondLabel.AutoSize = true;
            this.shokenAutoCondLabel.Font = new System.Drawing.Font("メイリオ", 16F);
            this.shokenAutoCondLabel.Location = new System.Drawing.Point(552, 3);
            this.shokenAutoCondLabel.Name = "shokenAutoCondLabel";
            this.shokenAutoCondLabel.Size = new System.Drawing.Size(103, 36);
            this.shokenAutoCondLabel.TabIndex = 4;
            this.shokenAutoCondLabel.Text = "自動判定\r\n基準";
            // 
            // checkNoLabel
            // 
            this.checkNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkNoLabel.AutoSize = true;
            this.checkNoLabel.Location = new System.Drawing.Point(67, 43);
            this.checkNoLabel.Name = "checkNoLabel";
            this.checkNoLabel.Size = new System.Drawing.Size(43, 33);
            this.checkNoLabel.TabIndex = 5;
            this.checkNoLabel.Text = "23";
            // 
            // handanLabel
            // 
            this.handanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.handanLabel.AutoSize = true;
            this.handanLabel.Location = new System.Drawing.Point(194, 43);
            this.handanLabel.Name = "handanLabel";
            this.handanLabel.Size = new System.Drawing.Size(33, 33);
            this.handanLabel.TabIndex = 10;
            this.handanLabel.Text = "×";
            // 
            // shokenHandanLabel
            // 
            this.shokenHandanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenHandanLabel.AutoSize = true;
            this.shokenHandanLabel.Location = new System.Drawing.Point(181, 4);
            this.shokenHandanLabel.Name = "shokenHandanLabel";
            this.shokenHandanLabel.Size = new System.Drawing.Size(59, 33);
            this.shokenHandanLabel.TabIndex = 1;
            this.shokenHandanLabel.Text = "判断";
            // 
            // shokenDescLabel
            // 
            this.shokenDescLabel.AutoSize = true;
            this.shokenDescLabel.Font = new System.Drawing.Font("メイリオ", 16F);
            this.shokenDescLabel.Location = new System.Drawing.Point(3, 86);
            this.shokenDescLabel.Name = "shokenDescLabel";
            this.shokenDescLabel.Size = new System.Drawing.Size(697, 66);
            this.shokenDescLabel.TabIndex = 1;
            this.shokenDescLabel.Text = "・接触ばっ気槽において、槽内の内壁と隔壁の接合部に隙間があります。処理機能に影響を与えるので、改善が必要です。";
            // 
            // teidoListBox
            // 
            this.teidoListBox.FormattingEnabled = true;
            this.teidoListBox.ItemHeight = 41;
            this.teidoListBox.Location = new System.Drawing.Point(966, 110);
            this.teidoListBox.Name = "teidoListBox";
            this.teidoListBox.Size = new System.Drawing.Size(300, 455);
            this.teidoListBox.TabIndex = 119;
            this.teidoListBox.SelectedValueChanged += new System.EventHandler(this.teidoListBox_SelectedValueChanged);
            // 
            // shouListBox
            // 
            this.shouListBox.FormattingEnabled = true;
            this.shouListBox.ItemHeight = 41;
            this.shouListBox.Location = new System.Drawing.Point(648, 110);
            this.shouListBox.Name = "shouListBox";
            this.shouListBox.Size = new System.Drawing.Size(300, 455);
            this.shouListBox.TabIndex = 118;
            this.shouListBox.SelectedValueChanged += new System.EventHandler(this.shouListBox_SelectedValueChanged);
            // 
            // chuListBox
            // 
            this.chuListBox.FormattingEnabled = true;
            this.chuListBox.ItemHeight = 41;
            this.chuListBox.Location = new System.Drawing.Point(330, 110);
            this.chuListBox.Name = "chuListBox";
            this.chuListBox.Size = new System.Drawing.Size(300, 455);
            this.chuListBox.TabIndex = 117;
            this.chuListBox.SelectedValueChanged += new System.EventHandler(this.chuListBox_SelectedValueChanged);
            // 
            // daiListBox
            // 
            this.daiListBox.FormattingEnabled = true;
            this.daiListBox.ItemHeight = 41;
            this.daiListBox.Location = new System.Drawing.Point(12, 110);
            this.daiListBox.Name = "daiListBox";
            this.daiListBox.Size = new System.Drawing.Size(300, 455);
            this.daiListBox.TabIndex = 116;
            this.daiListBox.SelectedValueChanged += new System.EventHandler(this.daiListBox_SelectedValueChanged);
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
            this.headerControl1.Size = new System.Drawing.Size(1280, 80);
            this.headerControl1.TabIndex = 115;
            // 
            // GaikanKensaHorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 858);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 20F);
            this.KeyPreview = true;
            this.Name = "GaikanKensaHorizForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.GaikanKensaHorizForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.renrakuPanel.ResumeLayout(false);
            this.renrakuPanel.PerformLayout();
            this.elementPanel1.ResumeLayout(false);
            this.elementPanel1.PerformLayout();
            this.shokenItemLayoutPanel.ResumeLayout(false);
            this.shokenItemLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.ListBox shouListBox;
        private System.Windows.Forms.ListBox chuListBox;
        private System.Windows.Forms.ListBox daiListBox;
        private System.Windows.Forms.ListBox teidoListBox;
        private System.Windows.Forms.FlowLayoutPanel elementPanel1;
        private System.Windows.Forms.TableLayoutPanel shokenItemLayoutPanel;
        private System.Windows.Forms.Label shokenCheckNoLabel;
        private System.Windows.Forms.Label shokenHandanLabel;
        private System.Windows.Forms.Label shokenLevelLabel;
        private System.Windows.Forms.Label shokenJudgeLabel;
        private System.Windows.Forms.Label shokenAutoCondLabel;
        private System.Windows.Forms.Label checkNoLabel;
        private System.Windows.Forms.Label autoCondLabel;
        private System.Windows.Forms.Label judgeLabel;
        private System.Windows.Forms.Label shokenDescLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label handanLabel;
        private System.Windows.Forms.Button kakuteiButton;
        private System.Windows.Forms.Button soutiAddButton;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
        private System.Windows.Forms.Panel renrakuPanel;
        private System.Windows.Forms.Label renrakuLabel;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}