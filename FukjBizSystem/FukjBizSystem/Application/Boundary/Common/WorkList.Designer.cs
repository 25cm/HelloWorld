namespace FukjBizSystem.Application.Boundary.Common
{
    partial class WorkListForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.workListDataGridView = new System.Windows.Forms.DataGridView();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtl = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColFormId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFuncId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.workListDataGridView)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(988, 506);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 34);
            this.closeButton.TabIndex = 72;
            this.closeButton.Text = "F12:閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            // 
            // workListDataGridView
            // 
            this.workListDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workListDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.workListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDesc,
            this.ColNum,
            this.ColDtl,
            this.ColFormId,
            this.ColFuncId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.workListDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.workListDataGridView.Location = new System.Drawing.Point(6, 18);
            this.workListDataGridView.Name = "workListDataGridView";
            this.workListDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.workListDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.workListDataGridView.RowHeadersVisible = false;
            this.workListDataGridView.RowTemplate.Height = 40;
            this.workListDataGridView.Size = new System.Drawing.Size(495, 254);
            this.workListDataGridView.TabIndex = 165;
            this.workListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workListDataGridView_CellContentClick);
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "作業内容";
            this.ColDesc.Name = "ColDesc";
            this.ColDesc.ReadOnly = true;
            this.ColDesc.Width = 300;
            // 
            // ColNum
            // 
            this.ColNum.HeaderText = "残件数";
            this.ColNum.Name = "ColNum";
            this.ColNum.ReadOnly = true;
            this.ColNum.Width = 80;
            // 
            // ColDtl
            // 
            this.ColDtl.HeaderText = "詳細";
            this.ColDtl.Name = "ColDtl";
            this.ColDtl.ReadOnly = true;
            this.ColDtl.Text = "詳細";
            this.ColDtl.UseColumnTextForButtonValue = true;
            this.ColDtl.Width = 80;
            // 
            // ColFormId
            // 
            this.ColFormId.HeaderText = "画面ID";
            this.ColFormId.Name = "ColFormId";
            this.ColFormId.ReadOnly = true;
            this.ColFormId.Visible = false;
            // 
            // ColFuncId
            // 
            this.ColFuncId.HeaderText = "機能ID";
            this.ColFuncId.Name = "ColFuncId";
            this.ColFuncId.ReadOnly = true;
            this.ColFuncId.Visible = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.groupBox8.Location = new System.Drawing.Point(640, 114);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(573, 317);
            this.groupBox8.TabIndex = 167;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "管理者";
            this.groupBox8.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label13);
            this.groupBox9.Controls.Add(this.label14);
            this.groupBox9.Controls.Add(this.label15);
            this.groupBox9.Controls.Add(this.button6);
            this.groupBox9.Location = new System.Drawing.Point(6, 208);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(556, 85);
            this.groupBox9.TabIndex = 165;
            this.groupBox9.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label13.Location = new System.Drawing.Point(11, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 76;
            this.label13.Text = "担当者未割当検査依頼";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label14.Location = new System.Drawing.Point(375, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 20);
            this.label14.TabIndex = 75;
            this.label14.Text = "32";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label15.Location = new System.Drawing.Point(403, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 20);
            this.label15.TabIndex = 74;
            this.label15.Text = "件";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(431, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 34);
            this.button6.TabIndex = 73;
            this.button6.Text = "詳細";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.label21);
            this.groupBox10.Controls.Add(this.button7);
            this.groupBox10.Location = new System.Drawing.Point(6, 26);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(556, 85);
            this.groupBox10.TabIndex = 163;
            this.groupBox10.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label16.Location = new System.Drawing.Point(11, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 20);
            this.label16.TabIndex = 76;
            this.label16.Text = "担当センター内検査結果未入力";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label17.Location = new System.Drawing.Point(375, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 20);
            this.label17.TabIndex = 75;
            this.label17.Text = "23";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label21.Location = new System.Drawing.Point(403, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 20);
            this.label21.TabIndex = 74;
            this.label21.Text = "件";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(431, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 34);
            this.button7.TabIndex = 73;
            this.button7.Text = "詳細";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label22);
            this.groupBox11.Controls.Add(this.label23);
            this.groupBox11.Controls.Add(this.label24);
            this.groupBox11.Controls.Add(this.button8);
            this.groupBox11.Location = new System.Drawing.Point(6, 117);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(556, 85);
            this.groupBox11.TabIndex = 164;
            this.groupBox11.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label22.Location = new System.Drawing.Point(11, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 20);
            this.label22.TabIndex = 76;
            this.label22.Text = "検印対象";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label23.Location = new System.Drawing.Point(375, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 20);
            this.label23.TabIndex = 75;
            this.label23.Text = "32";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label24.Location = new System.Drawing.Point(403, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 20);
            this.label24.TabIndex = 74;
            this.label24.Text = "件";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(431, 27);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 34);
            this.button8.TabIndex = 73;
            this.button8.Text = "詳細";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(640, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 50);
            this.panel1.TabIndex = 168;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.workListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 291);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "本日残作業リスト";
            // 
            // WorkListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "WorkListForm";
            this.Text = "支所情報";
            this.Load += new System.EventHandler(this.WorkListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WorkListForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.workListDataGridView)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView workListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNum;
        private System.Windows.Forms.DataGridViewButtonColumn ColDtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFuncId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}