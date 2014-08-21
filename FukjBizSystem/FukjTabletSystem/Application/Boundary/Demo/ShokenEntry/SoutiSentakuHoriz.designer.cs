namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    partial class SoutiSentakuHorizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoutiSentakuHorizForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soutiNmTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.soutiGroupListBox = new System.Windows.Forms.ListBox();
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.soutiNmTextBox);
            this.mainPanel.Controls.Add(this.selectButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.soutiGroupListBox);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1280, 858);
            this.mainPanel.TabIndex = 4;
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
            this.inputButton.TabIndex = 127;
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
            this.cameraButton.TabIndex = 126;
            this.cameraButton.TabStop = false;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(644, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 41);
            this.label2.TabIndex = 125;
            this.label2.Text = "確定単位装置名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 41);
            this.label1.TabIndex = 124;
            this.label1.Text = "単位装置グループ";
            // 
            // soutiNmTextBox
            // 
            this.soutiNmTextBox.Location = new System.Drawing.Point(644, 235);
            this.soutiNmTextBox.Name = "soutiNmTextBox";
            this.soutiNmTextBox.Size = new System.Drawing.Size(189, 47);
            this.soutiNmTextBox.TabIndex = 123;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectButton.Location = new System.Drawing.Point(370, 642);
            this.selectButton.Margin = new System.Windows.Forms.Padding(20);
            this.selectButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(250, 86);
            this.selectButton.TabIndex = 122;
            this.selectButton.Text = "装置選択";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.soutiAddButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.closeButton.Location = new System.Drawing.Point(660, 642);
            this.closeButton.Margin = new System.Windows.Forms.Padding(20);
            this.closeButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(250, 86);
            this.closeButton.TabIndex = 121;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // soutiGroupListBox
            // 
            this.soutiGroupListBox.FormattingEnabled = true;
            this.soutiGroupListBox.ItemHeight = 41;
            this.soutiGroupListBox.Location = new System.Drawing.Point(337, 238);
            this.soutiGroupListBox.Name = "soutiGroupListBox";
            this.soutiGroupListBox.Size = new System.Drawing.Size(300, 332);
            this.soutiGroupListBox.TabIndex = 116;
            this.soutiGroupListBox.SelectedValueChanged += new System.EventHandler(this.daiListBox_SelectedValueChanged);
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
            this.headerControl1.TabIndex = 115;
            // 
            // SoutiSentakuHorizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 858);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 20F);
            this.KeyPreview = true;
            this.Name = "SoutiSentakuHorizForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.SoutiSentakuHorizForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.ListBox soutiGroupListBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox soutiNmTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}