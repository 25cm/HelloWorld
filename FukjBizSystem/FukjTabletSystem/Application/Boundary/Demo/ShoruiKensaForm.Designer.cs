namespace FukjTabletSystem.Application.Boundary.Demo
{
    partial class ShoruiKensaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoruiKensaForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.burowaGridView = new System.Windows.Forms.DataGridView();
            this.KOUMOKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOSHU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SEISOU = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.burowaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.kakuteiButton);
            this.mainPanel.Controls.Add(this.burowaGridView);
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
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(1007, 743);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(244, 86);
            this.kakuteiButton.TabIndex = 2;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
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
            this.burowaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.KOUMOKU,
            this.HOSHU,
            this.SEISOU});
            this.burowaGridView.EnableHeadersVisualStyles = false;
            this.burowaGridView.Location = new System.Drawing.Point(25, 100);
            this.burowaGridView.MultiSelect = false;
            this.burowaGridView.Name = "burowaGridView";
            this.burowaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.burowaGridView.RowHeadersVisible = false;
            this.burowaGridView.RowTemplate.Height = 100;
            this.burowaGridView.Size = new System.Drawing.Size(1226, 620);
            this.burowaGridView.TabIndex = 1;
            this.burowaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.burowaGridView_CellClick);
            this.burowaGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.burowaGridView_DataError);
            // 
            // KOUMOKU
            // 
            this.KOUMOKU.FillWeight = 30F;
            this.KOUMOKU.HeaderText = "項目";
            this.KOUMOKU.Name = "KOUMOKU";
            this.KOUMOKU.ReadOnly = true;
            this.KOUMOKU.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HOSHU
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.HOSHU.DefaultCellStyle = dataGridViewCellStyle2;
            this.HOSHU.FillWeight = 30F;
            this.HOSHU.HeaderText = "保守点検";
            this.HOSHU.Name = "HOSHU";
            this.HOSHU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SEISOU
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.SEISOU.DefaultCellStyle = dataGridViewCellStyle3;
            this.SEISOU.FillWeight = 30F;
            this.SEISOU.HeaderText = "清掃";
            this.SEISOU.Name = "SEISOU";
            this.SEISOU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // ShoruiKensaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 858);
            this.Controls.Add(this.mainPanel);
            this.Name = "ShoruiKensaForm";
            this.Text = "ShoruiKensaForm";
            this.Load += new System.EventHandler(this.ShoruiKensaForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.burowaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
        private Common.HeaderControl headerControl1;
        private System.Windows.Forms.DataGridView burowaGridView;
        private System.Windows.Forms.Button kakuteiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOUMOKU;
        private System.Windows.Forms.DataGridViewComboBoxColumn HOSHU;
        private System.Windows.Forms.DataGridViewComboBoxColumn SEISOU;
    }
}