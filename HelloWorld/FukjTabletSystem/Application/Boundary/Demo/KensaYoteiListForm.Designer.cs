namespace FukjTabletSystem.Application.Boundary.Demo
{
    partial class KensaYoteiListForm
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
            this.closeButton = new Zynas.Control.ZButton(this.components);
            this.targetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateKetteiButton = new Zynas.Control.ZButton(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.順番DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.検査箇所名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状況DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kensaYoteiListDataSet = new FukjTabletSystem.Application.Boundary.Demo.KensaYoteiListDataSet();
            this.mapButton = new Zynas.Control.ZButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.Panel2.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel1.SuspendLayout();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kensaYoteiListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerTop
            // 
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.mapButton);
            // 
            // splitContainerTop.Panel2
            // 
            this.splitContainerTop.Panel2.Controls.Add(this.dateKetteiButton);
            this.splitContainerTop.Panel2.Controls.Add(this.targetDateTimePicker);
            this.splitContainerTop.Size = new System.Drawing.Size(800, 150);
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 151);
            // 
            // splitContainerBottom.Panel1
            // 
            this.splitContainerBottom.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.closeButton);
            this.splitContainerBottom.Size = new System.Drawing.Size(800, 811);
            this.splitContainerBottom.SplitterDistance = 732;
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "検査計画リスト";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(628, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(160, 42);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "終了";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // targetDateTimePicker
            // 
            this.targetDateTimePicker.CustomFormat = " yyyy年MM月dd日";
            this.targetDateTimePicker.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.targetDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.targetDateTimePicker.Location = new System.Drawing.Point(12, 14);
            this.targetDateTimePicker.Name = "targetDateTimePicker";
            this.targetDateTimePicker.Size = new System.Drawing.Size(240, 43);
            this.targetDateTimePicker.TabIndex = 0;
            // 
            // dateKetteiButton
            // 
            this.dateKetteiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateKetteiButton.Location = new System.Drawing.Point(253, 14);
            this.dateKetteiButton.Name = "dateKetteiButton";
            this.dateKetteiButton.Size = new System.Drawing.Size(80, 43);
            this.dateKetteiButton.TabIndex = 1;
            this.dateKetteiButton.Text = "表示";
            this.dateKetteiButton.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.順番DataGridViewTextBoxColumn,
            this.検査箇所名DataGridViewTextBoxColumn,
            this.状況DataGridViewTextBoxColumn});
            this.dataGridView.DataMember = "検査予定リスト";
            this.dataGridView.DataSource = this.kensaYoteiListDataSet;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(792, 726);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // 順番DataGridViewTextBoxColumn
            // 
            this.順番DataGridViewTextBoxColumn.DataPropertyName = "順番";
            this.順番DataGridViewTextBoxColumn.HeaderText = "順番";
            this.順番DataGridViewTextBoxColumn.Name = "順番DataGridViewTextBoxColumn";
            this.順番DataGridViewTextBoxColumn.ReadOnly = true;
            this.順番DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 検査箇所名DataGridViewTextBoxColumn
            // 
            this.検査箇所名DataGridViewTextBoxColumn.DataPropertyName = "検査箇所名";
            this.検査箇所名DataGridViewTextBoxColumn.HeaderText = "検査箇所名";
            this.検査箇所名DataGridViewTextBoxColumn.Name = "検査箇所名DataGridViewTextBoxColumn";
            this.検査箇所名DataGridViewTextBoxColumn.ReadOnly = true;
            this.検査箇所名DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 状況DataGridViewTextBoxColumn
            // 
            this.状況DataGridViewTextBoxColumn.DataPropertyName = "状況";
            this.状況DataGridViewTextBoxColumn.HeaderText = "状況";
            this.状況DataGridViewTextBoxColumn.Name = "状況DataGridViewTextBoxColumn";
            this.状況DataGridViewTextBoxColumn.ReadOnly = true;
            this.状況DataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.状況DataGridViewTextBoxColumn.Visible = false;
            // 
            // kensaYoteiListDataSet
            // 
            this.kensaYoteiListDataSet.DataSetName = "KensaYoteiListDataSet";
            this.kensaYoteiListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mapButton
            // 
            this.mapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Image = global::FukjTabletSystem.Properties.Resources.Map;
            this.mapButton.Location = new System.Drawing.Point(708, 5);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(80, 64);
            this.mapButton.TabIndex = 1;
            this.mapButton.TabStop = false;
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // KensaYoteiListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Name = "KensaYoteiListForm";
            this.Text = "検査予定リスト";
            this.Load += new System.EventHandler(this.KensaYoteiListForm_Load);
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainerBottom.Panel1.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kensaYoteiListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Zynas.Control.ZButton closeButton;
        private Zynas.Control.ZButton dateKetteiButton;
        private System.Windows.Forms.DateTimePicker targetDateTimePicker;
        private System.Windows.Forms.DataGridView dataGridView;
        private KensaYoteiListDataSet kensaYoteiListDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn 機能１DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 機能２DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 順番DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 検査箇所名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状況DataGridViewTextBoxColumn;
        private Zynas.Control.ZButton mapButton;

    }
}