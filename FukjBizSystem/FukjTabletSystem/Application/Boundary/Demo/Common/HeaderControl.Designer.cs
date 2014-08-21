namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    partial class HeaderControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new System.Windows.Forms.Button();
            this.nextAllButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.prevAllButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(627, 8);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 64);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // nextAllButton
            // 
            this.nextAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextAllButton.Location = new System.Drawing.Point(713, 8);
            this.nextAllButton.Name = "nextAllButton";
            this.nextAllButton.Size = new System.Drawing.Size(80, 64);
            this.nextAllButton.TabIndex = 3;
            this.nextAllButton.Text = ">>";
            this.nextAllButton.UseVisualStyleBackColor = true;
            this.nextAllButton.Visible = false;
            this.nextAllButton.Click += new System.EventHandler(this.nextAllButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevButton.Image = global::FukjTabletSystem.Properties.Resources.Back;
            this.prevButton.Location = new System.Drawing.Point(7, 7);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(80, 64);
            this.prevButton.TabIndex = 1;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // prevAllButton
            // 
            this.prevAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevAllButton.Location = new System.Drawing.Point(93, 8);
            this.prevAllButton.Name = "prevAllButton";
            this.prevAllButton.Size = new System.Drawing.Size(80, 64);
            this.prevAllButton.TabIndex = 0;
            this.prevAllButton.Text = "<<";
            this.prevAllButton.UseVisualStyleBackColor = true;
            this.prevAllButton.Visible = false;
            this.prevAllButton.Click += new System.EventHandler(this.prevAllButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Location = new System.Drawing.Point(10, 18);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(10);
            this.titleLabel.MinimumSize = new System.Drawing.Size(300, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(780, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "タイトルサンプル";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeaderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.prevAllButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.nextAllButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("メイリオ", 20F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1920, 80);
            this.MinimumSize = new System.Drawing.Size(800, 80);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(800, 78);
            this.Load += new System.EventHandler(this.HeaderControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button nextAllButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button prevAllButton;


    }
}
