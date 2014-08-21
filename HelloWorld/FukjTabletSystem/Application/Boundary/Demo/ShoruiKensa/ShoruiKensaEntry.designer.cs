namespace FukjTabletSystem.Application.Boundary.Demo.ShoruiKensa
{
    partial class ShoruiKensaEntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoruiKensaEntryForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.elementLayoutPanel = new FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel();
            this.elementPanel1 = new System.Windows.Forms.Panel();
            this.seisouGroupBox = new System.Windows.Forms.GroupBox();
            this.seisouShoruicomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seisouKaisuComboBox = new System.Windows.Forms.ComboBox();
            this.seisouKaisuTextBox = new System.Windows.Forms.TextBox();
            this.seisouGyoshaNmTextBox = new System.Windows.Forms.TextBox();
            this.seisouGyoshaComboBox = new System.Windows.Forms.ComboBox();
            this.hoshuGroupBox = new System.Windows.Forms.GroupBox();
            this.hoshuShoruiComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hoshuKaisuComboBox = new System.Windows.Forms.ComboBox();
            this.hoshuKaisuTextBox = new System.Windows.Forms.TextBox();
            this.hoshuGyoshaNmTextBox = new System.Windows.Forms.TextBox();
            this.hoshuGyoshaComboBox = new System.Windows.Forms.ComboBox();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.elementLayoutPanel.SuspendLayout();
            this.elementPanel1.SuspendLayout();
            this.seisouGroupBox.SuspendLayout();
            this.hoshuGroupBox.SuspendLayout();
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
            this.mainPanel.Size = new System.Drawing.Size(800, 962);
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
            this.inputButton.TabIndex = 121;
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
            this.cameraButton.TabIndex = 120;
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
            this.elementLayoutPanel.Controls.Add(this.elementPanel1);
            this.elementLayoutPanel.Controls.Add(this.kakuteiButton);
            this.elementLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elementLayoutPanel.Location = new System.Drawing.Point(3, 83);
            this.elementLayoutPanel.Name = "elementLayoutPanel";
            this.elementLayoutPanel.Padding = new System.Windows.Forms.Padding(43, 0, 43, 0);
            this.elementLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elementLayoutPanel.Size = new System.Drawing.Size(794, 876);
            this.elementLayoutPanel.TabIndex = 0;
            this.elementLayoutPanel.WrapContents = false;
            // 
            // elementPanel1
            // 
            this.elementPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementPanel1.Controls.Add(this.seisouGroupBox);
            this.elementPanel1.Controls.Add(this.hoshuGroupBox);
            this.elementPanel1.Location = new System.Drawing.Point(46, 3);
            this.elementPanel1.MinimumSize = new System.Drawing.Size(550, 100);
            this.elementPanel1.Name = "elementPanel1";
            this.elementPanel1.Size = new System.Drawing.Size(700, 538);
            this.elementPanel1.TabIndex = 1;
            // 
            // seisouGroupBox
            // 
            this.seisouGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seisouGroupBox.Controls.Add(this.seisouShoruicomboBox);
            this.seisouGroupBox.Controls.Add(this.label7);
            this.seisouGroupBox.Controls.Add(this.label4);
            this.seisouGroupBox.Controls.Add(this.label3);
            this.seisouGroupBox.Controls.Add(this.seisouKaisuComboBox);
            this.seisouGroupBox.Controls.Add(this.seisouKaisuTextBox);
            this.seisouGroupBox.Controls.Add(this.seisouGyoshaNmTextBox);
            this.seisouGroupBox.Controls.Add(this.seisouGyoshaComboBox);
            this.seisouGroupBox.Location = new System.Drawing.Point(0, 271);
            this.seisouGroupBox.Name = "seisouGroupBox";
            this.seisouGroupBox.Size = new System.Drawing.Size(698, 265);
            this.seisouGroupBox.TabIndex = 1;
            this.seisouGroupBox.TabStop = false;
            this.seisouGroupBox.Text = "清掃業者";
            // 
            // seisouShoruicomboBox
            // 
            this.seisouShoruicomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seisouShoruicomboBox.FormattingEnabled = true;
            this.seisouShoruicomboBox.Items.AddRange(new object[] {
            "有",
            "無"});
            this.seisouShoruicomboBox.Location = new System.Drawing.Point(173, 113);
            this.seisouShoruicomboBox.Margin = new System.Windows.Forms.Padding(9);
            this.seisouShoruicomboBox.Name = "seisouShoruicomboBox";
            this.seisouShoruicomboBox.Size = new System.Drawing.Size(111, 49);
            this.seisouShoruicomboBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 41);
            this.label7.TabIndex = 3;
            this.label7.Text = "書類有無";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "業者";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "回数";
            // 
            // seisouKaisuComboBox
            // 
            this.seisouKaisuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seisouKaisuComboBox.FormattingEnabled = true;
            this.seisouKaisuComboBox.Items.AddRange(new object[] {
            "",
            "回/月",
            "回/年"});
            this.seisouKaisuComboBox.Location = new System.Drawing.Point(252, 180);
            this.seisouKaisuComboBox.Margin = new System.Windows.Forms.Padding(9);
            this.seisouKaisuComboBox.Name = "seisouKaisuComboBox";
            this.seisouKaisuComboBox.Size = new System.Drawing.Size(95, 49);
            this.seisouKaisuComboBox.TabIndex = 7;
            // 
            // seisouKaisuTextBox
            // 
            this.seisouKaisuTextBox.Location = new System.Drawing.Point(173, 180);
            this.seisouKaisuTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.seisouKaisuTextBox.Name = "seisouKaisuTextBox";
            this.seisouKaisuTextBox.Size = new System.Drawing.Size(61, 47);
            this.seisouKaisuTextBox.TabIndex = 6;
            // 
            // seisouGyoshaNmTextBox
            // 
            this.seisouGyoshaNmTextBox.Location = new System.Drawing.Point(303, 46);
            this.seisouGyoshaNmTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.seisouGyoshaNmTextBox.Name = "seisouGyoshaNmTextBox";
            this.seisouGyoshaNmTextBox.ReadOnly = true;
            this.seisouGyoshaNmTextBox.Size = new System.Drawing.Size(225, 47);
            this.seisouGyoshaNmTextBox.TabIndex = 2;
            // 
            // seisouGyoshaComboBox
            // 
            this.seisouGyoshaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seisouGyoshaComboBox.FormattingEnabled = true;
            this.seisouGyoshaComboBox.Items.AddRange(new object[] {
            "",
            "0001",
            "0002",
            "0003",
            "0004",
            "0005",
            "0006"});
            this.seisouGyoshaComboBox.Location = new System.Drawing.Point(174, 46);
            this.seisouGyoshaComboBox.Margin = new System.Windows.Forms.Padding(9);
            this.seisouGyoshaComboBox.Name = "seisouGyoshaComboBox";
            this.seisouGyoshaComboBox.Size = new System.Drawing.Size(111, 49);
            this.seisouGyoshaComboBox.TabIndex = 1;
            this.seisouGyoshaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // hoshuGroupBox
            // 
            this.hoshuGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hoshuGroupBox.Controls.Add(this.hoshuShoruiComboBox);
            this.hoshuGroupBox.Controls.Add(this.label5);
            this.hoshuGroupBox.Controls.Add(this.label2);
            this.hoshuGroupBox.Controls.Add(this.label1);
            this.hoshuGroupBox.Controls.Add(this.hoshuKaisuComboBox);
            this.hoshuGroupBox.Controls.Add(this.hoshuKaisuTextBox);
            this.hoshuGroupBox.Controls.Add(this.hoshuGyoshaNmTextBox);
            this.hoshuGroupBox.Controls.Add(this.hoshuGyoshaComboBox);
            this.hoshuGroupBox.Location = new System.Drawing.Point(0, 0);
            this.hoshuGroupBox.Name = "hoshuGroupBox";
            this.hoshuGroupBox.Size = new System.Drawing.Size(698, 265);
            this.hoshuGroupBox.TabIndex = 0;
            this.hoshuGroupBox.TabStop = false;
            this.hoshuGroupBox.Text = "保守業者";
            // 
            // hoshuShoruiComboBox
            // 
            this.hoshuShoruiComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoshuShoruiComboBox.FormattingEnabled = true;
            this.hoshuShoruiComboBox.Items.AddRange(new object[] {
            "有",
            "無"});
            this.hoshuShoruiComboBox.Location = new System.Drawing.Point(174, 113);
            this.hoshuShoruiComboBox.Margin = new System.Windows.Forms.Padding(9);
            this.hoshuShoruiComboBox.Name = "hoshuShoruiComboBox";
            this.hoshuShoruiComboBox.Size = new System.Drawing.Size(111, 49);
            this.hoshuShoruiComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 41);
            this.label5.TabIndex = 3;
            this.label5.Text = "書類有無";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "回数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "業者";
            // 
            // hoshuKaisuComboBox
            // 
            this.hoshuKaisuComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoshuKaisuComboBox.FormattingEnabled = true;
            this.hoshuKaisuComboBox.Items.AddRange(new object[] {
            "",
            "回/月",
            "回/年"});
            this.hoshuKaisuComboBox.Location = new System.Drawing.Point(253, 180);
            this.hoshuKaisuComboBox.Margin = new System.Windows.Forms.Padding(9);
            this.hoshuKaisuComboBox.Name = "hoshuKaisuComboBox";
            this.hoshuKaisuComboBox.Size = new System.Drawing.Size(95, 49);
            this.hoshuKaisuComboBox.TabIndex = 7;
            // 
            // hoshuKaisuTextBox
            // 
            this.hoshuKaisuTextBox.Location = new System.Drawing.Point(174, 180);
            this.hoshuKaisuTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.hoshuKaisuTextBox.Name = "hoshuKaisuTextBox";
            this.hoshuKaisuTextBox.Size = new System.Drawing.Size(61, 47);
            this.hoshuKaisuTextBox.TabIndex = 6;
            // 
            // hoshuGyoshaNmTextBox
            // 
            this.hoshuGyoshaNmTextBox.Location = new System.Drawing.Point(303, 46);
            this.hoshuGyoshaNmTextBox.Margin = new System.Windows.Forms.Padding(9);
            this.hoshuGyoshaNmTextBox.Name = "hoshuGyoshaNmTextBox";
            this.hoshuGyoshaNmTextBox.ReadOnly = true;
            this.hoshuGyoshaNmTextBox.Size = new System.Drawing.Size(225, 47);
            this.hoshuGyoshaNmTextBox.TabIndex = 2;
            // 
            // hoshuGyoshaComboBox
            // 
            this.hoshuGyoshaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoshuGyoshaComboBox.FormattingEnabled = true;
            this.hoshuGyoshaComboBox.Items.AddRange(new object[] {
            "",
            "0001",
            "0002",
            "0003",
            "0004",
            "0005",
            "0006"});
            this.hoshuGyoshaComboBox.Location = new System.Drawing.Point(174, 46);
            this.hoshuGyoshaComboBox.Margin = new System.Windows.Forms.Padding(9);
            this.hoshuGyoshaComboBox.Name = "hoshuGyoshaComboBox";
            this.hoshuGyoshaComboBox.Size = new System.Drawing.Size(111, 49);
            this.hoshuGyoshaComboBox.TabIndex = 1;
            this.hoshuGyoshaComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(271, 564);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(250, 86);
            this.kakuteiButton.TabIndex = 4;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
            // 
            // ShoruiKensaEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Name = "ShoruiKensaEntryForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.ShoruiKensaEntryForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.elementLayoutPanel.ResumeLayout(false);
            this.elementPanel1.ResumeLayout(false);
            this.seisouGroupBox.ResumeLayout(false);
            this.seisouGroupBox.PerformLayout();
            this.hoshuGroupBox.ResumeLayout(false);
            this.hoshuGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel elementLayoutPanel;
        private System.Windows.Forms.Panel elementPanel1;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.GroupBox hoshuGroupBox;
        private System.Windows.Forms.GroupBox seisouGroupBox;
        private System.Windows.Forms.TextBox hoshuGyoshaNmTextBox;
        private System.Windows.Forms.ComboBox hoshuGyoshaComboBox;
        private System.Windows.Forms.TextBox seisouGyoshaNmTextBox;
        private System.Windows.Forms.ComboBox seisouGyoshaComboBox;
        private System.Windows.Forms.ComboBox hoshuKaisuComboBox;
        private System.Windows.Forms.TextBox hoshuKaisuTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seisouKaisuComboBox;
        private System.Windows.Forms.TextBox seisouKaisuTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hoshuShoruiComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seisouShoruicomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button kakuteiButton;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}