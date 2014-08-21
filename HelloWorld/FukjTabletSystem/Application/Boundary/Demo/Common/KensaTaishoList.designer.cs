namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    partial class KensaTaishoListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mapButton = new Zynas.Control.ZButton(this.components);
            this.elementDataGridView = new System.Windows.Forms.DataGridView();
            this.ColKensaKbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColRireki = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.mapButton);
            this.mainPanel.Controls.Add(this.elementDataGridView);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 962);
            this.mainPanel.TabIndex = 0;
            // 
            // mapButton
            // 
            this.mapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapButton.BackColor = System.Drawing.Color.LightGreen;
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Image = global::FukjTabletSystem.Properties.Resources.Map;
            this.mapButton.Location = new System.Drawing.Point(708, 8);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(80, 64);
            this.mapButton.TabIndex = 117;
            this.mapButton.TabStop = false;
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // elementDataGridView
            // 
            this.elementDataGridView.AllowUserToAddRows = false;
            this.elementDataGridView.AllowUserToDeleteRows = false;
            this.elementDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.elementDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.elementDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.elementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKensaKbn,
            this.ColBasho,
            this.ColInfo,
            this.ColRireki});
            this.elementDataGridView.EnableHeadersVisualStyles = false;
            this.elementDataGridView.Location = new System.Drawing.Point(3, 83);
            this.elementDataGridView.MultiSelect = false;
            this.elementDataGridView.Name = "elementDataGridView";
            this.elementDataGridView.ReadOnly = true;
            this.elementDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.elementDataGridView.RowHeadersVisible = false;
            this.elementDataGridView.RowTemplate.Height = 64;
            this.elementDataGridView.Size = new System.Drawing.Size(794, 876);
            this.elementDataGridView.TabIndex = 3;
            this.elementDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elementDataGridView_CellClick);
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
            // ColInfo
            // 
            this.ColInfo.HeaderText = "情報";
            this.ColInfo.Name = "ColInfo";
            this.ColInfo.ReadOnly = true;
            this.ColInfo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColRireki
            // 
            this.ColRireki.HeaderText = "履歴";
            this.ColRireki.Name = "ColRireki";
            this.ColRireki.ReadOnly = true;
            this.ColRireki.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColRireki.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // headerControl1
            // 
            this.headerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            // KensaTaishoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Name = "KensaTaishoListForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.KensaTaishoListForm_Load);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.DataGridView elementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKensaKbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasho;
        private System.Windows.Forms.DataGridViewButtonColumn ColInfo;
        private System.Windows.Forms.DataGridViewButtonColumn ColRireki;
        private Zynas.Control.ZButton mapButton;
    }
}