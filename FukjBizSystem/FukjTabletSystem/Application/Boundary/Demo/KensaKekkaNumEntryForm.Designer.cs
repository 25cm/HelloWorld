namespace FukjTabletSystem.Application.Boundary.Demo
{
    partial class KensaKekkaNumEntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KensaKekkaNumEntryForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.burowaLabel = new System.Windows.Forms.Label();
            this.burowaGridView = new System.Windows.Forms.DataGridView();
            this.BUROWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KITEI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KITEI_TANNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SECCHI_TANNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kankyoLabel = new System.Windows.Forms.Label();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.kasaageLabel = new System.Windows.Forms.Label();
            this.kasaageUnitLabel = new System.Windows.Forms.Label();
            this.kasaageTextBox = new System.Windows.Forms.TextBox();
            this.ryuushutsuLabel = new System.Windows.Forms.Label();
            this.ryuunyuuLabel = new System.Windows.Forms.Label();
            this.ryuushutsuUnitLabel = new System.Windows.Forms.Label();
            this.ryuunyuuUnitLabel = new System.Windows.Forms.Label();
            this.ryuushutsuTextBox = new System.Windows.Forms.TextBox();
            this.ryuunyuuTextBox = new System.Windows.Forms.TextBox();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burowaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.splitContainer1);
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1280, 858);
            this.mainPanel.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(13, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.burowaLabel);
            this.splitContainer1.Panel1.Controls.Add(this.burowaGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.kankyoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.kakuteiButton);
            this.splitContainer1.Panel2.Controls.Add(this.kasaageLabel);
            this.splitContainer1.Panel2.Controls.Add(this.kasaageUnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.kasaageTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ryuushutsuLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ryuunyuuLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ryuushutsuUnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ryuunyuuUnitLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ryuushutsuTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.ryuunyuuTextBox);
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(1255, 762);
            this.splitContainer1.SplitterDistance = 851;
            this.splitContainer1.TabIndex = 3;
            // 
            // burowaLabel
            // 
            this.burowaLabel.AutoSize = true;
            this.burowaLabel.Location = new System.Drawing.Point(7, 34);
            this.burowaLabel.Name = "burowaLabel";
            this.burowaLabel.Size = new System.Drawing.Size(180, 41);
            this.burowaLabel.TabIndex = 0;
            this.burowaLabel.Text = "ブロワの風量";
            // 
            // burowaGridView
            // 
            this.burowaGridView.AllowUserToAddRows = false;
            this.burowaGridView.AllowUserToDeleteRows = false;
            this.burowaGridView.AllowUserToResizeColumns = false;
            this.burowaGridView.AllowUserToResizeRows = false;
            this.burowaGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.burowaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.burowaGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.burowaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.burowaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.burowaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BUROWA,
            this.KITEI,
            this.KITEI_TANNI,
            this.SECCHI,
            this.SECCHI_TANNI});
            this.burowaGridView.EnableHeadersVisualStyles = false;
            this.burowaGridView.Location = new System.Drawing.Point(14, 78);
            this.burowaGridView.MultiSelect = false;
            this.burowaGridView.Name = "burowaGridView";
            this.burowaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.burowaGridView.RowHeadersVisible = false;
            this.burowaGridView.RowTemplate.Height = 64;
            this.burowaGridView.Size = new System.Drawing.Size(820, 640);
            this.burowaGridView.TabIndex = 1;
            this.burowaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.burowaGridView_CellClick);
            this.burowaGridView.SelectionChanged += new System.EventHandler(this.burowaGridView_SelectionChanged);
            this.burowaGridView.Leave += new System.EventHandler(this.burowaGridView_Leave);
            // 
            // BUROWA
            // 
            this.BUROWA.FillWeight = 30F;
            this.BUROWA.HeaderText = "ブロワ";
            this.BUROWA.Name = "BUROWA";
            this.BUROWA.ReadOnly = true;
            this.BUROWA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KITEI
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.KITEI.DefaultCellStyle = dataGridViewCellStyle2;
            this.KITEI.FillWeight = 25F;
            this.KITEI.HeaderText = "規定";
            this.KITEI.Name = "KITEI";
            this.KITEI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KITEI_TANNI
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KITEI_TANNI.DefaultCellStyle = dataGridViewCellStyle3;
            this.KITEI_TANNI.FillWeight = 10F;
            this.KITEI_TANNI.HeaderText = "";
            this.KITEI_TANNI.Name = "KITEI_TANNI";
            this.KITEI_TANNI.ReadOnly = true;
            this.KITEI_TANNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SECCHI
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.SECCHI.DefaultCellStyle = dataGridViewCellStyle4;
            this.SECCHI.FillWeight = 25F;
            this.SECCHI.HeaderText = "設置";
            this.SECCHI.Name = "SECCHI";
            this.SECCHI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SECCHI_TANNI
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SECCHI_TANNI.DefaultCellStyle = dataGridViewCellStyle5;
            this.SECCHI_TANNI.FillWeight = 10F;
            this.SECCHI_TANNI.HeaderText = "";
            this.SECCHI_TANNI.Name = "SECCHI_TANNI";
            this.SECCHI_TANNI.ReadOnly = true;
            this.SECCHI_TANNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kankyoLabel
            // 
            this.kankyoLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kankyoLabel.AutoSize = true;
            this.kankyoLabel.Location = new System.Drawing.Point(7, 34);
            this.kankyoLabel.Name = "kankyoLabel";
            this.kankyoLabel.Size = new System.Drawing.Size(153, 41);
            this.kankyoLabel.TabIndex = 0;
            this.kankyoLabel.Text = "管渠の滞留";
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(85, 348);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(244, 86);
            this.kakuteiButton.TabIndex = 10;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
            // 
            // kasaageLabel
            // 
            this.kasaageLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kasaageLabel.AutoSize = true;
            this.kasaageLabel.Location = new System.Drawing.Point(7, 234);
            this.kasaageLabel.Name = "kasaageLabel";
            this.kasaageLabel.Size = new System.Drawing.Size(180, 41);
            this.kasaageLabel.TabIndex = 7;
            this.kasaageLabel.Text = "嵩上げの高さ";
            // 
            // kasaageUnitLabel
            // 
            this.kasaageUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kasaageUnitLabel.AutoSize = true;
            this.kasaageUnitLabel.Location = new System.Drawing.Point(335, 281);
            this.kasaageUnitLabel.Name = "kasaageUnitLabel";
            this.kasaageUnitLabel.Size = new System.Drawing.Size(58, 41);
            this.kasaageUnitLabel.TabIndex = 9;
            this.kasaageUnitLabel.Text = "cm";
            // 
            // kasaageTextBox
            // 
            this.kasaageTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kasaageTextBox.BackColor = System.Drawing.Color.White;
            this.kasaageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kasaageTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.kasaageTextBox.Location = new System.Drawing.Point(85, 278);
            this.kasaageTextBox.Name = "kasaageTextBox";
            this.kasaageTextBox.Size = new System.Drawing.Size(244, 47);
            this.kasaageTextBox.TabIndex = 8;
            this.kasaageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kasaageTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.kasaageTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ryuushutsuLabel
            // 
            this.ryuushutsuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuushutsuLabel.AutoSize = true;
            this.ryuushutsuLabel.Location = new System.Drawing.Point(7, 134);
            this.ryuushutsuLabel.Name = "ryuushutsuLabel";
            this.ryuushutsuLabel.Size = new System.Drawing.Size(72, 41);
            this.ryuushutsuLabel.TabIndex = 4;
            this.ryuushutsuLabel.Text = "流出";
            // 
            // ryuunyuuLabel
            // 
            this.ryuunyuuLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuunyuuLabel.AutoSize = true;
            this.ryuunyuuLabel.Location = new System.Drawing.Point(7, 81);
            this.ryuunyuuLabel.Name = "ryuunyuuLabel";
            this.ryuunyuuLabel.Size = new System.Drawing.Size(72, 41);
            this.ryuunyuuLabel.TabIndex = 1;
            this.ryuunyuuLabel.Text = "流入";
            // 
            // ryuushutsuUnitLabel
            // 
            this.ryuushutsuUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuushutsuUnitLabel.AutoSize = true;
            this.ryuushutsuUnitLabel.Location = new System.Drawing.Point(335, 134);
            this.ryuushutsuUnitLabel.Name = "ryuushutsuUnitLabel";
            this.ryuushutsuUnitLabel.Size = new System.Drawing.Size(58, 41);
            this.ryuushutsuUnitLabel.TabIndex = 6;
            this.ryuushutsuUnitLabel.Text = "cm";
            // 
            // ryuunyuuUnitLabel
            // 
            this.ryuunyuuUnitLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuunyuuUnitLabel.AutoSize = true;
            this.ryuunyuuUnitLabel.Location = new System.Drawing.Point(335, 81);
            this.ryuunyuuUnitLabel.Name = "ryuunyuuUnitLabel";
            this.ryuunyuuUnitLabel.Size = new System.Drawing.Size(58, 41);
            this.ryuunyuuUnitLabel.TabIndex = 3;
            this.ryuunyuuUnitLabel.Text = "cm";
            // 
            // ryuushutsuTextBox
            // 
            this.ryuushutsuTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuushutsuTextBox.BackColor = System.Drawing.Color.White;
            this.ryuushutsuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ryuushutsuTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ryuushutsuTextBox.Location = new System.Drawing.Point(85, 131);
            this.ryuushutsuTextBox.Name = "ryuushutsuTextBox";
            this.ryuushutsuTextBox.Size = new System.Drawing.Size(244, 47);
            this.ryuushutsuTextBox.TabIndex = 5;
            this.ryuushutsuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ryuushutsuTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ryuushutsuTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ryuunyuuTextBox
            // 
            this.ryuunyuuTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ryuunyuuTextBox.BackColor = System.Drawing.Color.White;
            this.ryuunyuuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ryuunyuuTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.ryuunyuuTextBox.Location = new System.Drawing.Point(85, 78);
            this.ryuunyuuTextBox.Name = "ryuunyuuTextBox";
            this.ryuunyuuTextBox.Size = new System.Drawing.Size(244, 47);
            this.ryuunyuuTextBox.TabIndex = 2;
            this.ryuunyuuTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ryuunyuuTextBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.ryuunyuuTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
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
            this.inputButton.TabIndex = 2;
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
            this.cameraButton.TabIndex = 1;
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
            this.headerControl1.Size = new System.Drawing.Size(1280, 80);
            this.headerControl1.TabIndex = 0;
            // 
            // KensaKekkaNumEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 858);
            this.Controls.Add(this.mainPanel);
            this.Name = "KensaKekkaNumEntryForm";
            this.Text = "KensaKekkaNumEntryForm";
            this.Load += new System.EventHandler(this.KensaKekkaNumEntryForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.burowaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
        private Common.HeaderControl headerControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView burowaGridView;
        private System.Windows.Forms.TextBox ryuushutsuTextBox;
        private System.Windows.Forms.TextBox ryuunyuuTextBox;
        private System.Windows.Forms.Label kasaageLabel;
        private System.Windows.Forms.Label kasaageUnitLabel;
        private System.Windows.Forms.TextBox kasaageTextBox;
        private System.Windows.Forms.Label ryuushutsuLabel;
        private System.Windows.Forms.Label ryuunyuuLabel;
        private System.Windows.Forms.Label ryuushutsuUnitLabel;
        private System.Windows.Forms.Label ryuunyuuUnitLabel;
        private System.Windows.Forms.Label kankyoLabel;
        private System.Windows.Forms.Button kakuteiButton;
        private System.Windows.Forms.Label burowaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUROWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn KITEI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KITEI_TANNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SECCHI_TANNI;
    }
}