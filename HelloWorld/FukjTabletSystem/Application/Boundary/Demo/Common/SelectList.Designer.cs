namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    partial class SelectList
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
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.headerControl1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(794, 823);
            this.dataGridView1.TabIndex = 3;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectButton.Location = new System.Drawing.Point(130, 929);
            this.selectButton.Margin = new System.Windows.Forms.Padding(20);
            this.selectButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(250, 86);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "選択";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Location = new System.Drawing.Point(420, 929);
            this.closeButton.Margin = new System.Windows.Forms.Padding(20);
            this.closeButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(250, 86);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // SelectList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 1044);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.headerControl1);
            this.Font = new System.Drawing.Font("メイリオ", 20F);
            this.Name = "SelectList";
            this.Text = "SelectList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderControl headerControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button closeButton;
    }
}