namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    partial class ChuBunruiSentakuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuBunruiSentakuForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.selectButtonPanel1 = new FukjTabletSystem.Application.Boundary.Demo.Common.SelectButtonPanel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Controls.Add(this.selectButtonPanel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 962);
            this.mainPanel.TabIndex = 4;
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
            this.inputButton.TabIndex = 121;
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
            this.cameraButton.TabIndex = 120;
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
            this.headerControl1.TabIndex = 115;
            // 
            // selectButtonPanel1
            // 
            this.selectButtonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButtonPanel1.AutoScroll = true;
            this.selectButtonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectButtonPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.selectButtonPanel1.Location = new System.Drawing.Point(3, 83);
            this.selectButtonPanel1.Name = "selectButtonPanel1";
            this.selectButtonPanel1.Padding = new System.Windows.Forms.Padding(179, 0, 179, 0);
            this.selectButtonPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectButtonPanel1.Size = new System.Drawing.Size(794, 876);
            this.selectButtonPanel1.TabIndex = 1;
            this.selectButtonPanel1.WrapContents = false;
            // 
            // ChuBunruiSentakuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 20F);
            this.KeyPreview = true;
            this.Name = "ChuBunruiSentakuForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.ChuBunruiSentakuForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private FukjTabletSystem.Application.Boundary.Demo.Common.SelectButtonPanel selectButtonPanel1;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}