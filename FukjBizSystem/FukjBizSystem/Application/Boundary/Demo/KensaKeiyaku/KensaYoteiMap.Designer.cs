namespace KensaYoteiMapDemo
{
    partial class KensaYoteiMap
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
            this.components = new System.ComponentModel.Container();
            this.memoListButton = new System.Windows.Forms.Button();
            this.calenderButton = new System.Windows.Forms.Button();
            this.yoteiListButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.mwView1 = new MapWorks50.MWView();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.zoomOutButton = new System.Windows.Forms.Button();
            this.modeNormalButton = new System.Windows.Forms.Button();
            this.modeMoveButton = new System.Windows.Forms.Button();
            this.iconBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this.heijyunkaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memoListButton
            // 
            this.memoListButton.Location = new System.Drawing.Point(12, 12);
            this.memoListButton.Name = "memoListButton";
            this.memoListButton.Size = new System.Drawing.Size(99, 33);
            this.memoListButton.TabIndex = 1;
            this.memoListButton.Text = "メモ一覧";
            this.memoListButton.UseVisualStyleBackColor = true;
            this.memoListButton.Click += new System.EventHandler(this.memoListButton_Click);
            // 
            // calenderButton
            // 
            this.calenderButton.Location = new System.Drawing.Point(117, 12);
            this.calenderButton.Name = "calenderButton";
            this.calenderButton.Size = new System.Drawing.Size(99, 33);
            this.calenderButton.TabIndex = 2;
            this.calenderButton.Text = "カレンダー";
            this.calenderButton.UseVisualStyleBackColor = true;
            this.calenderButton.Click += new System.EventHandler(this.calenderButton_Click);
            // 
            // yoteiListButton
            // 
            this.yoteiListButton.Location = new System.Drawing.Point(222, 12);
            this.yoteiListButton.Name = "yoteiListButton";
            this.yoteiListButton.Size = new System.Drawing.Size(99, 33);
            this.yoteiListButton.TabIndex = 3;
            this.yoteiListButton.Text = "予定入力";
            this.yoteiListButton.UseVisualStyleBackColor = true;
            this.yoteiListButton.Click += new System.EventHandler(this.yoteiListButton_Click);
            // 
            // allButton
            // 
            this.allButton.Location = new System.Drawing.Point(338, 12);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(99, 33);
            this.allButton.TabIndex = 4;
            this.allButton.Text = "全て";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // mwView1
            // 
            this.mwView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mwView1.BackColor = System.Drawing.Color.White;
            this.mwView1.BorderStyle = ((short)(0));
            this.mwView1.ControlID = 1;
            this.mwView1.CurLayerNo = 0;
            this.mwView1.CursorType = MapWorks50.mwcCursorType.CURSOR_NONE;
            this.mwView1.EditMode = MapWorks50.mwcEditMode.EM_NONE;
            this.mwView1.Location = new System.Drawing.Point(12, 51);
            this.mwView1.MapCache = 32;
            this.mwView1.MapDrawMode = MapWorks50.mwcMapDrawMode.MDM_DRAW_1_PASS;
            this.mwView1.MapScale = 0;
            this.mwView1.MapScaleMode = MapWorks50.mwcMapScaleMode.MSM_ZMD;
            this.mwView1.MapSelColor = System.Drawing.Color.Red;
            this.mwView1.MapType = MapWorks50.mwcMapType.MT_NONE;
            this.mwView1.MapTypeEx = ((ulong)(0ul));
            this.mwView1.MouseMode = MapWorks50.mwcMouseMode.MM_NORMAL;
            this.mwView1.MWEnvPath = null;
            this.mwView1.Name = "mwView1";
            this.mwView1.PickDistance = 5;
            this.mwView1.PickMode = MapWorks50.mwcPickMode.PKM_NORMAL;
            this.mwView1.Rotation = 0F;
            this.mwView1.ScaleMode = MapWorks50.mwcScaleMode.SM_BL;
            this.mwView1.ScreenRegion = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.mwView1.ScrollCursor = false;
            this.mwView1.ScrollPeriod = ((short)(10));
            this.mwView1.ScrollRange = ((short)(50));
            this.mwView1.Size = new System.Drawing.Size(1240, 619);
            this.mwView1.TabIndex = 0;
            this.mwView1.TenKeyControl = false;
            this.mwView1.Text = "mwView1";
            this.mwView1.UseGaijiFont = true;
            this.mwView1.ZoomMode = MapWorks50.mwcZoomMode.ZM_NONE;
            this.mwView1.ObjectSelected += new MapWorks50.ObjectSelectedEventHandler(this.mwView1_ObjectSelected);
            this.mwView1.ObjectUnselected += new MapWorks50.ObjectUnselectedEventHandler(this.mwView1_ObjectUnselected);
            this.mwView1.Click += new System.EventHandler(this.mwView1_Click);
            this.mwView1.MouseHover += new System.EventHandler(this.mwView1_MouseHover);
            this.mwView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mwView1_MouseMove);
            // 
            // zoomInButton
            // 
            this.zoomInButton.Location = new System.Drawing.Point(639, 12);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(44, 33);
            this.zoomInButton.TabIndex = 6;
            this.zoomInButton.Text = "+";
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // zoomOutButton
            // 
            this.zoomOutButton.Location = new System.Drawing.Point(689, 12);
            this.zoomOutButton.Name = "zoomOutButton";
            this.zoomOutButton.Size = new System.Drawing.Size(42, 33);
            this.zoomOutButton.TabIndex = 7;
            this.zoomOutButton.Text = "-";
            this.zoomOutButton.UseVisualStyleBackColor = true;
            this.zoomOutButton.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // modeNormalButton
            // 
            this.modeNormalButton.Location = new System.Drawing.Point(795, 12);
            this.modeNormalButton.Name = "modeNormalButton";
            this.modeNormalButton.Size = new System.Drawing.Size(99, 33);
            this.modeNormalButton.TabIndex = 8;
            this.modeNormalButton.Text = "通常モード";
            this.modeNormalButton.UseVisualStyleBackColor = true;
            this.modeNormalButton.Click += new System.EventHandler(this.modeNormalButton_Click);
            // 
            // modeMoveButton
            // 
            this.modeMoveButton.Location = new System.Drawing.Point(900, 12);
            this.modeMoveButton.Name = "modeMoveButton";
            this.modeMoveButton.Size = new System.Drawing.Size(99, 33);
            this.modeMoveButton.TabIndex = 9;
            this.modeMoveButton.Text = "住所移動モード";
            this.modeMoveButton.UseVisualStyleBackColor = true;
            this.modeMoveButton.Click += new System.EventHandler(this.modeMoveButton_Click);
            // 
            // iconBlinkTimer
            // 
            this.iconBlinkTimer.Interval = 1000;
            this.iconBlinkTimer.Tick += new System.EventHandler(this.iconBlinkTimer_Tick);
            // 
            // heijyunkaButton
            // 
            this.heijyunkaButton.Location = new System.Drawing.Point(496, 12);
            this.heijyunkaButton.Name = "heijyunkaButton";
            this.heijyunkaButton.Size = new System.Drawing.Size(99, 33);
            this.heijyunkaButton.TabIndex = 5;
            this.heijyunkaButton.Text = "予定平準化";
            this.heijyunkaButton.UseVisualStyleBackColor = true;
            this.heijyunkaButton.Click += new System.EventHandler(this.heijyunkaButton_Click);
            // 
            // KensaYoteiMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.heijyunkaButton);
            this.Controls.Add(this.modeMoveButton);
            this.Controls.Add(this.modeNormalButton);
            this.Controls.Add(this.zoomOutButton);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.mwView1);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.yoteiListButton);
            this.Controls.Add(this.calenderButton);
            this.Controls.Add(this.memoListButton);
            this.Name = "KensaYoteiMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "検査予定地図表示";
            this.Load += new System.EventHandler(this.KensaYoteiMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button memoListButton;
        private System.Windows.Forms.Button calenderButton;
        private System.Windows.Forms.Button yoteiListButton;
        private System.Windows.Forms.Button allButton;
        private MapWorks50.MWView mwView1;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButton;
        private System.Windows.Forms.Button modeNormalButton;
        private System.Windows.Forms.Button modeMoveButton;
        private System.Windows.Forms.Timer iconBlinkTimer;
        private System.Windows.Forms.Button heijyunkaButton;
    }
}

