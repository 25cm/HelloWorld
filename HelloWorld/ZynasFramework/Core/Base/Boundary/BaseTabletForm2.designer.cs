namespace Zynas.Framework.Core.Base.Boundary
{
    partial class BaseTabletForm2
    {
        /// <summary>
        /// 必要なデザイナー変数です。
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerTop = new System.Windows.Forms.SplitContainer();
            this.titleLabel = new System.Windows.Forms.Label();
            this.splitContainerBottom = new System.Windows.Forms.SplitContainer();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerTop
            // 
            this.splitContainerTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerTop.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTop.IsSplitterFixed = true;
            this.splitContainerTop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTop.Name = "splitContainerTop";
            this.splitContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.BackColor = System.Drawing.Color.LightGreen;
            this.splitContainerTop.Panel1.Controls.Add(this.titleLabel);
            this.splitContainerTop.Panel1MinSize = 75;
            this.splitContainerTop.Size = new System.Drawing.Size(800, 300);
            this.splitContainerTop.SplitterDistance = 75;
            this.splitContainerTop.TabIndex = 0;
            this.splitContainerTop.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(100, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(600, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FORM_TITLE";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerBottom.IsSplitterFixed = true;
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 301);
            this.splitContainerBottom.Name = "splitContainerBottom";
            this.splitContainerBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerBottom.Panel2MinSize = 75;
            this.splitContainerBottom.Size = new System.Drawing.Size(800, 661);
            this.splitContainerBottom.SplitterDistance = 582;
            this.splitContainerBottom.TabIndex = 1;
            this.splitContainerBottom.TabStop = false;
            // 
            // BaseTabletForm2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.splitContainerBottom);
            this.Controls.Add(this.splitContainerTop);
            this.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 858);
            this.Name = "BaseTabletForm2";
            this.Text = "FORM NAME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainerBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainerTop;
        protected System.Windows.Forms.SplitContainer splitContainerBottom;
        protected System.Windows.Forms.Label titleLabel;


    }
}

