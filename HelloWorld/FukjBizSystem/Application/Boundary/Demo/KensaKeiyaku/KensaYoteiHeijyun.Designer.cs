namespace KensaYoteiMapDemo
{
    partial class KensaYoteiHeijyunForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.furikaeButton = new System.Windows.Forms.Button();
            this.ColKensaIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKadouRitsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col11JouIka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col11JouIkaDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col11JouIzyou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col11JouIzyouDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7JouKensu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.avg11JouIkaTextBox = new System.Windows.Forms.TextBox();
            this.avg11JouIzyouTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(231, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "平成26年10月";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "＜＜";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "＞＞";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(529, 421);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 26);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColKensaIn,
            this.ColKadouRitsu,
            this.Col11JouIka,
            this.Col11JouIkaDiff,
            this.Col11JouIzyou,
            this.Col11JouIzyouDiff,
            this.Col7JouKensu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 305);
            this.dataGridView1.TabIndex = 8;
            // 
            // furikaeButton
            // 
            this.furikaeButton.Location = new System.Drawing.Point(12, 421);
            this.furikaeButton.Name = "furikaeButton";
            this.furikaeButton.Size = new System.Drawing.Size(108, 26);
            this.furikaeButton.TabIndex = 9;
            this.furikaeButton.Text = "予定振替";
            this.furikaeButton.UseVisualStyleBackColor = true;
            this.furikaeButton.Click += new System.EventHandler(this.furikaeButton_Click);
            // 
            // ColKensaIn
            // 
            this.ColKensaIn.HeaderText = "検査員";
            this.ColKensaIn.Name = "ColKensaIn";
            // 
            // ColKadouRitsu
            // 
            this.ColKadouRitsu.HeaderText = "予定稼働率";
            this.ColKadouRitsu.Name = "ColKadouRitsu";
            this.ColKadouRitsu.Width = 80;
            // 
            // Col11JouIka
            // 
            this.Col11JouIka.HeaderText = "11条(50人槽以下)";
            this.Col11JouIka.Name = "Col11JouIka";
            this.Col11JouIka.Width = 70;
            // 
            // Col11JouIkaDiff
            // 
            this.Col11JouIkaDiff.HeaderText = "平均との差";
            this.Col11JouIkaDiff.Name = "Col11JouIkaDiff";
            this.Col11JouIkaDiff.Width = 70;
            // 
            // Col11JouIzyou
            // 
            this.Col11JouIzyou.HeaderText = "11条(51人槽以上)";
            this.Col11JouIzyou.Name = "Col11JouIzyou";
            this.Col11JouIzyou.Width = 70;
            // 
            // Col11JouIzyouDiff
            // 
            this.Col11JouIzyouDiff.HeaderText = "平均との差";
            this.Col11JouIzyouDiff.Name = "Col11JouIzyouDiff";
            this.Col11JouIzyouDiff.Width = 70;
            // 
            // Col7JouKensu
            // 
            this.Col7JouKensu.HeaderText = "7条(参考)";
            this.Col7JouKensu.Name = "Col7JouKensu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "平均値";
            // 
            // avg11JouIkaTextBox
            // 
            this.avg11JouIkaTextBox.Location = new System.Drawing.Point(135, 45);
            this.avg11JouIkaTextBox.Name = "avg11JouIkaTextBox";
            this.avg11JouIkaTextBox.Size = new System.Drawing.Size(100, 19);
            this.avg11JouIkaTextBox.TabIndex = 5;
            // 
            // avg11JouIzyouTextBox
            // 
            this.avg11JouIzyouTextBox.Location = new System.Drawing.Point(135, 70);
            this.avg11JouIzyouTextBox.Name = "avg11JouIzyouTextBox";
            this.avg11JouIzyouTextBox.Size = new System.Drawing.Size(100, 19);
            this.avg11JouIzyouTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "50人槽以下";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "51人槽以上";
            // 
            // KensaYoteiHeijyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 459);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avg11JouIzyouTextBox);
            this.Controls.Add(this.avg11JouIkaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.furikaeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "KensaYoteiHeijyunForm";
            this.Text = "検査予定平準化";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.KensaYoteiHeijyunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button furikaeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKensaIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKadouRitsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11JouIka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11JouIkaDiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11JouIzyou;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col11JouIzyouDiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7JouKensu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox avg11JouIkaTextBox;
        private System.Windows.Forms.TextBox avg11JouIzyouTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}