namespace KensaYoteiMapDemo
{
    partial class KensaYoteiHeijyunDetailForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.leftDataGridView = new System.Windows.Forms.DataGridView();
            this.ColKensaYoteiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNinsou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSettiBasho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.leftKensainTextBox = new System.Windows.Forms.TextBox();
            this.rightKensainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.leftMimanTextBox = new System.Windows.Forms.TextBox();
            this.leftIzyouTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rightIzyouTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rightMimanTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(666, 427);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 26);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kakuteiButton.Location = new System.Drawing.Point(12, 427);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(108, 26);
            this.kakuteiButton.TabIndex = 16;
            this.kakuteiButton.Text = "振替確定";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
            // 
            // leftDataGridView
            // 
            this.leftDataGridView.AllowUserToAddRows = false;
            this.leftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leftDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKensaYoteiDate,
            this.ColNinsou,
            this.ColSettiBasho});
            this.leftDataGridView.Location = new System.Drawing.Point(12, 37);
            this.leftDataGridView.Name = "leftDataGridView";
            this.leftDataGridView.RowHeadersVisible = false;
            this.leftDataGridView.RowTemplate.Height = 21;
            this.leftDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.leftDataGridView.Size = new System.Drawing.Size(325, 384);
            this.leftDataGridView.TabIndex = 6;
            // 
            // ColKensaYoteiDate
            // 
            this.ColKensaYoteiDate.HeaderText = "予定日";
            this.ColKensaYoteiDate.Name = "ColKensaYoteiDate";
            // 
            // ColNinsou
            // 
            this.ColNinsou.HeaderText = "人槽";
            this.ColNinsou.Name = "ColNinsou";
            // 
            // ColSettiBasho
            // 
            this.ColSettiBasho.HeaderText = "設置場所";
            this.ColSettiBasho.Name = "ColSettiBasho";
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(371, 164);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(52, 43);
            this.rightButton.TabIndex = 14;
            this.rightButton.Text = "＞";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(371, 235);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(52, 43);
            this.leftButton.TabIndex = 15;
            this.leftButton.Text = "＜";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // leftKensainTextBox
            // 
            this.leftKensainTextBox.Location = new System.Drawing.Point(58, 12);
            this.leftKensainTextBox.Name = "leftKensainTextBox";
            this.leftKensainTextBox.ReadOnly = true;
            this.leftKensainTextBox.Size = new System.Drawing.Size(108, 19);
            this.leftKensainTextBox.TabIndex = 1;
            // 
            // rightKensainTextBox
            // 
            this.rightKensainTextBox.Location = new System.Drawing.Point(493, 12);
            this.rightKensainTextBox.Name = "rightKensainTextBox";
            this.rightKensainTextBox.ReadOnly = true;
            this.rightKensainTextBox.Size = new System.Drawing.Size(108, 19);
            this.rightKensainTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "検査員";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "検査員";
            // 
            // rightDataGridView
            // 
            this.rightDataGridView.AllowUserToAddRows = false;
            this.rightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.rightDataGridView.Location = new System.Drawing.Point(450, 37);
            this.rightDataGridView.Name = "rightDataGridView";
            this.rightDataGridView.RowHeadersVisible = false;
            this.rightDataGridView.RowTemplate.Height = 21;
            this.rightDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rightDataGridView.Size = new System.Drawing.Size(325, 384);
            this.rightDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "予定日";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "人槽";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "設置場所";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "50人槽以下";
            // 
            // leftMimanTextBox
            // 
            this.leftMimanTextBox.Location = new System.Drawing.Point(243, 12);
            this.leftMimanTextBox.Name = "leftMimanTextBox";
            this.leftMimanTextBox.ReadOnly = true;
            this.leftMimanTextBox.Size = new System.Drawing.Size(31, 19);
            this.leftMimanTextBox.TabIndex = 3;
            // 
            // leftIzyouTextBox
            // 
            this.leftIzyouTextBox.Location = new System.Drawing.Point(315, 12);
            this.leftIzyouTextBox.Name = "leftIzyouTextBox";
            this.leftIzyouTextBox.ReadOnly = true;
            this.leftIzyouTextBox.Size = new System.Drawing.Size(31, 19);
            this.leftIzyouTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "以上";
            // 
            // rightIzyouTextBox
            // 
            this.rightIzyouTextBox.Location = new System.Drawing.Point(750, 12);
            this.rightIzyouTextBox.Name = "rightIzyouTextBox";
            this.rightIzyouTextBox.ReadOnly = true;
            this.rightIzyouTextBox.Size = new System.Drawing.Size(31, 19);
            this.rightIzyouTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "以上";
            // 
            // rightMimanTextBox
            // 
            this.rightMimanTextBox.Location = new System.Drawing.Point(678, 12);
            this.rightMimanTextBox.Name = "rightMimanTextBox";
            this.rightMimanTextBox.ReadOnly = true;
            this.rightMimanTextBox.Size = new System.Drawing.Size(31, 19);
            this.rightMimanTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "50人槽以下";
            // 
            // KensaYoteiHeijyunDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.rightIzyouTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rightMimanTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.leftIzyouTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftMimanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rightDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightKensainTextBox);
            this.Controls.Add(this.leftKensainTextBox);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftDataGridView);
            this.Controls.Add(this.kakuteiButton);
            this.Controls.Add(this.closeButton);
            this.Name = "KensaYoteiHeijyunDetailForm";
            this.Text = "検査予定平準化";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KensaYoteiHeijyunDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button kakuteiButton;
        private System.Windows.Forms.DataGridView leftDataGridView;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.TextBox leftKensainTextBox;
        private System.Windows.Forms.TextBox rightKensainTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKensaYoteiDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNinsou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSettiBasho;
        private System.Windows.Forms.DataGridView rightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leftMimanTextBox;
        private System.Windows.Forms.TextBox leftIzyouTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rightIzyouTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rightMimanTextBox;
        private System.Windows.Forms.Label label6;
    }
}