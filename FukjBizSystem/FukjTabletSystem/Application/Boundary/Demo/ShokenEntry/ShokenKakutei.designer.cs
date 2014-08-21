namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    partial class ShokenKakuteiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShokenKakuteiForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.elementLayoutPanel = new FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel();
            this.elementPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.shokenItemLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.checkNoLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.shokenCheckNoLabel = new System.Windows.Forms.Label();
            this.shokenHandanLabel = new System.Windows.Forms.Label();
            this.shokenLevelLabel = new System.Windows.Forms.Label();
            this.shokenJudgeLabel = new System.Windows.Forms.Label();
            this.handanLabel = new System.Windows.Forms.Label();
            this.autoCondLabel = new System.Windows.Forms.Label();
            this.judgeLabel = new System.Windows.Forms.Label();
            this.shokenAutoCondLabel = new System.Windows.Forms.Label();
            this.shokenDescLabel = new System.Windows.Forms.Label();
            this.kakuteiButton = new System.Windows.Forms.Button();
            this.headerControl1 = new FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl();
            this.mainPanel.SuspendLayout();
            this.elementLayoutPanel.SuspendLayout();
            this.elementPanel1.SuspendLayout();
            this.shokenItemLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.inputButton);
            this.mainPanel.Controls.Add(this.cameraButton);
            this.mainPanel.Controls.Add(this.elementLayoutPanel);
            this.mainPanel.Controls.Add(this.headerControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("メイリオ", 20F);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 962);
            this.mainPanel.TabIndex = 0;
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
            // elementLayoutPanel
            // 
            this.elementLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementLayoutPanel.AutoScroll = true;
            this.elementLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementLayoutPanel.Controls.Add(this.elementPanel1);
            this.elementLayoutPanel.Controls.Add(this.kakuteiButton);
            this.elementLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elementLayoutPanel.Location = new System.Drawing.Point(3, 83);
            this.elementLayoutPanel.Name = "elementLayoutPanel";
            this.elementLayoutPanel.Padding = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.elementLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elementLayoutPanel.Size = new System.Drawing.Size(794, 876);
            this.elementLayoutPanel.TabIndex = 0;
            this.elementLayoutPanel.WrapContents = false;
            // 
            // elementPanel1
            // 
            this.elementPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elementPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.elementPanel1.Controls.Add(this.shokenItemLayoutPanel);
            this.elementPanel1.Controls.Add(this.shokenDescLabel);
            this.elementPanel1.Font = new System.Drawing.Font("メイリオ", 12F);
            this.elementPanel1.Location = new System.Drawing.Point(39, 3);
            this.elementPanel1.Name = "elementPanel1";
            this.elementPanel1.Size = new System.Drawing.Size(713, 297);
            this.elementPanel1.TabIndex = 1;
            // 
            // shokenItemLayoutPanel
            // 
            this.shokenItemLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenItemLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.shokenItemLayoutPanel.ColumnCount = 5;
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.shokenItemLayoutPanel.Controls.Add(this.checkNoLabel, 0, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.levelLabel, 0, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenCheckNoLabel, 0, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenHandanLabel, 1, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenLevelLabel, 2, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenJudgeLabel, 3, 0);
            this.shokenItemLayoutPanel.Controls.Add(this.handanLabel, 0, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.autoCondLabel, 4, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.judgeLabel, 3, 1);
            this.shokenItemLayoutPanel.Controls.Add(this.shokenAutoCondLabel, 4, 0);
            this.shokenItemLayoutPanel.Font = new System.Drawing.Font("メイリオ", 16F);
            this.shokenItemLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.shokenItemLayoutPanel.MinimumSize = new System.Drawing.Size(550, 100);
            this.shokenItemLayoutPanel.Name = "shokenItemLayoutPanel";
            this.shokenItemLayoutPanel.RowCount = 2;
            this.shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.shokenItemLayoutPanel.Size = new System.Drawing.Size(700, 185);
            this.shokenItemLayoutPanel.TabIndex = 0;
            // 
            // checkNoLabel
            // 
            this.checkNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkNoLabel.AutoSize = true;
            this.checkNoLabel.Location = new System.Drawing.Point(64, 112);
            this.checkNoLabel.Name = "checkNoLabel";
            this.checkNoLabel.Size = new System.Drawing.Size(43, 33);
            this.checkNoLabel.TabIndex = 11;
            this.checkNoLabel.Text = "23";
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(399, 112);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(30, 33);
            this.levelLabel.TabIndex = 10;
            this.levelLabel.Text = "A";
            // 
            // shokenCheckNoLabel
            // 
            this.shokenCheckNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenCheckNoLabel.AutoSize = true;
            this.shokenCheckNoLabel.Location = new System.Drawing.Point(12, 21);
            this.shokenCheckNoLabel.Name = "shokenCheckNoLabel";
            this.shokenCheckNoLabel.Size = new System.Drawing.Size(147, 33);
            this.shokenCheckNoLabel.TabIndex = 0;
            this.shokenCheckNoLabel.Text = "チェック番号";
            // 
            // shokenHandanLabel
            // 
            this.shokenHandanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenHandanLabel.AutoSize = true;
            this.shokenHandanLabel.Location = new System.Drawing.Point(227, 21);
            this.shokenHandanLabel.Name = "shokenHandanLabel";
            this.shokenHandanLabel.Size = new System.Drawing.Size(59, 33);
            this.shokenHandanLabel.TabIndex = 1;
            this.shokenHandanLabel.Text = "判断";
            // 
            // shokenLevelLabel
            // 
            this.shokenLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenLevelLabel.AutoSize = true;
            this.shokenLevelLabel.Location = new System.Drawing.Point(374, 21);
            this.shokenLevelLabel.Name = "shokenLevelLabel";
            this.shokenLevelLabel.Size = new System.Drawing.Size(81, 33);
            this.shokenLevelLabel.TabIndex = 2;
            this.shokenLevelLabel.Text = "重要度";
            // 
            // shokenJudgeLabel
            // 
            this.shokenJudgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenJudgeLabel.AutoSize = true;
            this.shokenJudgeLabel.Location = new System.Drawing.Point(503, 21);
            this.shokenJudgeLabel.Name = "shokenJudgeLabel";
            this.shokenJudgeLabel.Size = new System.Drawing.Size(59, 33);
            this.shokenJudgeLabel.TabIndex = 3;
            this.shokenJudgeLabel.Text = "判定";
            // 
            // handanLabel
            // 
            this.handanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.handanLabel.AutoSize = true;
            this.handanLabel.Location = new System.Drawing.Point(238, 112);
            this.handanLabel.Name = "handanLabel";
            this.handanLabel.Size = new System.Drawing.Size(37, 33);
            this.handanLabel.TabIndex = 5;
            this.handanLabel.Text = "△";
            // 
            // autoCondLabel
            // 
            this.autoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.autoCondLabel.AutoSize = true;
            this.autoCondLabel.Location = new System.Drawing.Point(649, 112);
            this.autoCondLabel.Name = "autoCondLabel";
            this.autoCondLabel.Size = new System.Drawing.Size(22, 33);
            this.autoCondLabel.TabIndex = 9;
            this.autoCondLabel.Text = " ";
            // 
            // judgeLabel
            // 
            this.judgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.judgeLabel.AutoSize = true;
            this.judgeLabel.Location = new System.Drawing.Point(492, 112);
            this.judgeLabel.Name = "judgeLabel";
            this.judgeLabel.Size = new System.Drawing.Size(81, 33);
            this.judgeLabel.TabIndex = 8;
            this.judgeLabel.Text = "不適正";
            // 
            // shokenAutoCondLabel
            // 
            this.shokenAutoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shokenAutoCondLabel.AutoSize = true;
            this.shokenAutoCondLabel.Location = new System.Drawing.Point(608, 5);
            this.shokenAutoCondLabel.Name = "shokenAutoCondLabel";
            this.shokenAutoCondLabel.Size = new System.Drawing.Size(103, 66);
            this.shokenAutoCondLabel.TabIndex = 4;
            this.shokenAutoCondLabel.Text = "自動判定\r\n基準";
            // 
            // shokenDescLabel
            // 
            this.shokenDescLabel.AutoSize = true;
            this.shokenDescLabel.Font = new System.Drawing.Font("メイリオ", 16F);
            this.shokenDescLabel.Location = new System.Drawing.Point(3, 191);
            this.shokenDescLabel.Name = "shokenDescLabel";
            this.shokenDescLabel.Size = new System.Drawing.Size(697, 66);
            this.shokenDescLabel.TabIndex = 1;
            this.shokenDescLabel.Text = "・接触ばっ気槽において、槽内の内壁と隔壁の接合部に隙間があります。処理機能に影響を与えるので、改善が必要です。";
            // 
            // kakuteiButton
            // 
            this.kakuteiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kakuteiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kakuteiButton.Location = new System.Drawing.Point(270, 323);
            this.kakuteiButton.Margin = new System.Windows.Forms.Padding(20);
            this.kakuteiButton.MinimumSize = new System.Drawing.Size(60, 60);
            this.kakuteiButton.Name = "kakuteiButton";
            this.kakuteiButton.Size = new System.Drawing.Size(250, 86);
            this.kakuteiButton.TabIndex = 2;
            this.kakuteiButton.Text = "確定登録";
            this.kakuteiButton.UseVisualStyleBackColor = true;
            this.kakuteiButton.Click += new System.EventHandler(this.kakuteiButton_Click);
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
            this.headerControl1.TabIndex = 1;
            // 
            // ShokenKakuteiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.KeyPreview = true;
            this.Name = "ShokenKakuteiForm";
            this.Text = "状況選択";
            this.Load += new System.EventHandler(this.ShokenKakuteiForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.elementLayoutPanel.ResumeLayout(false);
            this.elementPanel1.ResumeLayout(false);
            this.elementPanel1.PerformLayout();
            this.shokenItemLayoutPanel.ResumeLayout(false);
            this.shokenItemLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.ZFlowLayoutPanel elementLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel shokenItemLayoutPanel;
        private System.Windows.Forms.Button kakuteiButton;
        private System.Windows.Forms.Label shokenHandanLabel;
        private System.Windows.Forms.Label shokenCheckNoLabel;
        private System.Windows.Forms.Label shokenLevelLabel;
        private System.Windows.Forms.Label shokenJudgeLabel;
        private System.Windows.Forms.Label shokenAutoCondLabel;
        private System.Windows.Forms.Label handanLabel;
        private System.Windows.Forms.Label judgeLabel;
        private System.Windows.Forms.Label autoCondLabel;
        private System.Windows.Forms.FlowLayoutPanel elementPanel1;
        private System.Windows.Forms.Label shokenDescLabel;
        private FukjTabletSystem.Application.Boundary.Demo.Common.HeaderControl headerControl1;
        private System.Windows.Forms.Label checkNoLabel;
        private System.Windows.Forms.Label levelLabel;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
    }
}