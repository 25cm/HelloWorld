namespace FukjTabletSystem.Application.Boundary.Demo.SuishitsuKensa
{
    partial class SuishitsuKensaOutputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuishitsuKensaOutputForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.elementLayoutPanel = new FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kensaKbnComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uketsukeNoToTextBox = new System.Windows.Forms.TextBox();
            this.uketsukeNoFromTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kensakuButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.zFlowLayoutPanel1 = new FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel();
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.ColUketsukeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKensaKbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKensaYoteiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.elementLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.zFlowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
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
            this.elementLayoutPanel.Controls.Add(this.panel1);
            this.elementLayoutPanel.Controls.Add(this.panel2);
            this.elementLayoutPanel.Controls.Add(this.zFlowLayoutPanel1);
            this.elementLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elementLayoutPanel.Location = new System.Drawing.Point(3, 83);
            this.elementLayoutPanel.MinimumSize = new System.Drawing.Size(600, 2);
            this.elementLayoutPanel.Name = "elementLayoutPanel";
            this.elementLayoutPanel.Padding = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.elementLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elementLayoutPanel.Size = new System.Drawing.Size(794, 876);
            this.elementLayoutPanel.TabIndex = 0;
            this.elementLayoutPanel.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kensaKbnComboBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uketsukeNoToTextBox);
            this.panel1.Controls.Add(this.uketsukeNoFromTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.kensakuButton);
            this.panel1.Location = new System.Drawing.Point(96, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 185);
            this.panel1.TabIndex = 1;
            // 
            // kensaKbnComboBox
            // 
            this.kensaKbnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kensaKbnComboBox.FormattingEnabled = true;
            this.kensaKbnComboBox.Location = new System.Drawing.Point(136, 22);
            this.kensaKbnComboBox.Name = "kensaKbnComboBox";
            this.kensaKbnComboBox.Size = new System.Drawing.Size(121, 49);
            this.kensaKbnComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "種別";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "受付番号";
            // 
            // uketsukeNoToTextBox
            // 
            this.uketsukeNoToTextBox.Location = new System.Drawing.Point(162, 133);
            this.uketsukeNoToTextBox.Name = "uketsukeNoToTextBox";
            this.uketsukeNoToTextBox.Size = new System.Drawing.Size(100, 47);
            this.uketsukeNoToTextBox.TabIndex = 2;
            // 
            // uketsukeNoFromTextBox
            // 
            this.uketsukeNoFromTextBox.Location = new System.Drawing.Point(5, 133);
            this.uketsukeNoFromTextBox.Name = "uketsukeNoFromTextBox";
            this.uketsukeNoFromTextBox.Size = new System.Drawing.Size(100, 47);
            this.uketsukeNoFromTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "～";
            // 
            // kensakuButton
            // 
            this.kensakuButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kensakuButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kensakuButton.Location = new System.Drawing.Point(329, 47);
            this.kensakuButton.Margin = new System.Windows.Forms.Padding(20);
            this.kensakuButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kensakuButton.Name = "kensakuButton";
            this.kensakuButton.Size = new System.Drawing.Size(250, 86);
            this.kensakuButton.TabIndex = 3;
            this.kensakuButton.Text = "検索";
            this.kensakuButton.UseVisualStyleBackColor = true;
            this.kensakuButton.Click += new System.EventHandler(this.kensakuButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.outputButton);
            this.panel2.Controls.Add(this.importButton);
            this.panel2.Location = new System.Drawing.Point(96, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 130);
            this.panel2.TabIndex = 2;
            // 
            // outputButton
            // 
            this.outputButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.outputButton.Location = new System.Drawing.Point(19, 28);
            this.outputButton.Margin = new System.Windows.Forms.Padding(20);
            this.outputButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(250, 86);
            this.outputButton.TabIndex = 5;
            this.outputButton.Text = "帳票出力";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // importButton
            // 
            this.importButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importButton.Location = new System.Drawing.Point(309, 28);
            this.importButton.Margin = new System.Windows.Forms.Padding(20);
            this.importButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(250, 86);
            this.importButton.TabIndex = 6;
            this.importButton.Text = "帳票取込";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // zFlowLayoutPanel1
            // 
            this.zFlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zFlowLayoutPanel1.AutoScroll = true;
            this.zFlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zFlowLayoutPanel1.Controls.Add(this.elementDataGridView);
            this.zFlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.zFlowLayoutPanel1.Font = new System.Drawing.Font("メイリオ", 12F);
            this.zFlowLayoutPanel1.Location = new System.Drawing.Point(96, 330);
            this.zFlowLayoutPanel1.MinimumSize = new System.Drawing.Size(600, 2);
            this.zFlowLayoutPanel1.Name = "zFlowLayoutPanel1";
            this.zFlowLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zFlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.zFlowLayoutPanel1.Size = new System.Drawing.Size(600, 370);
            this.zFlowLayoutPanel1.TabIndex = 0;
            this.zFlowLayoutPanel1.WrapContents = false;
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.AllowUserToAddRows = false;
            this.elementDataGridView.AllowUserToDeleteRows = false;
            this.elementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.elementDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUketsukeNo,
            this.ColKensaKbn,
            this.ColBasho,
            this.ColKensaYoteiDate});
            this.elementDataGridView.EnableHeadersVisualStyles = false;
            this.elementDataGridView.Location = new System.Drawing.Point(5, 3);
            this.elementDataGridView.MultiSelect = false;
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.ReadOnly = true;
            this.elementDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.elementDataGridView.RowHeadersVisible = false;
            this.elementDataGridView.RowTemplate.Height = 64;
            this.elementDataGridView.Size = new System.Drawing.Size(587, 360);
            this.elementDataGridView.TabIndex = 0;
            // 
            // ColUketsukeNo
            // 
            this.ColUketsukeNo.HeaderText = "受付番号";
            this.ColUketsukeNo.Name = "ColUketsukeNo";
            this.ColUketsukeNo.ReadOnly = true;
            // 
            // ColKensaKbn
            // 
            this.ColKensaKbn.HeaderText = "種別";
            this.ColKensaKbn.Name = "ColKensaKbn";
            this.ColKensaKbn.ReadOnly = true;
            // 
            // ColBasho
            // 
            this.ColBasho.HeaderText = "検査場所";
            this.ColBasho.Name = "ColBasho";
            this.ColBasho.ReadOnly = true;
            // 
            // ColKensaYoteiDate
            // 
            this.ColKensaYoteiDate.HeaderText = "検査予定日";
            this.ColKensaYoteiDate.Name = "ColKensaYoteiDate";
            this.ColKensaYoteiDate.ReadOnly = true;
            // 
            // SuishitsuKensaOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Name = "SuishitsuKensaOutputForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.SuishitsuKensaOutputForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.elementLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.zFlowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel elementLayoutPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button kensakuButton;
        private Common.ZFlowLayoutPanel zFlowLayoutPanel1;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uketsukeNoToTextBox;
        private System.Windows.Forms.TextBox uketsukeNoFromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUketsukeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKensaKbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasho;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKensaYoteiDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kensaKbnComboBox;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}