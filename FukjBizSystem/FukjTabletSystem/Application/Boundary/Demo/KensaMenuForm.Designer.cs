namespace FukjTabletSystem.Application.Boundary.Demo
{
    partial class KensaMenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KensaMenuForm));
            this.backButton = new Zynas.Control.ZButton(this.components);
            this.closeButton = new Zynas.Control.ZButton(this.components);
            this.mapButton = new Zynas.Control.ZButton(this.components);
            this.inputButton = new Zynas.Control.ZButton(this.components);
            this.cameraButton = new Zynas.Control.ZButton(this.components);
            this.gpsButton = new Zynas.Control.ZButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).BeginInit();
            this.splitContainerTop.Panel1.SuspendLayout();
            this.splitContainerTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).BeginInit();
            this.splitContainerBottom.Panel2.SuspendLayout();
            this.splitContainerBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerTop
            // 
            // 
            // splitContainerTop.Panel1
            // 
            this.splitContainerTop.Panel1.Controls.Add(this.gpsButton);
            this.splitContainerTop.Panel1.Controls.Add(this.inputButton);
            this.splitContainerTop.Panel1.Controls.Add(this.cameraButton);
            this.splitContainerTop.Panel1.Controls.Add(this.mapButton);
            this.splitContainerTop.Panel1.Controls.Add(this.backButton);
            this.splitContainerTop.Size = new System.Drawing.Size(800, 150);
            // 
            // splitContainerBottom
            // 
            this.splitContainerBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerBottom.Location = new System.Drawing.Point(0, 151);
            // 
            // splitContainerBottom.Panel2
            // 
            this.splitContainerBottom.Panel2.Controls.Add(this.closeButton);
            this.splitContainerBottom.Size = new System.Drawing.Size(800, 811);
            this.splitContainerBottom.SplitterDistance = 732;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(294, 13);
            this.titleLabel.Size = new System.Drawing.Size(212, 48);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "検査メニュー";
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(12, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(80, 64);
            this.backButton.TabIndex = 0;
            this.backButton.TabStop = false;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(628, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(160, 42);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "戻る";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mapButton
            // 
            this.mapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapButton.Image = global::FukjTabletSystem.Properties.Resources.Map;
            this.mapButton.Location = new System.Drawing.Point(708, 5);
            this.mapButton.Name = "mapButton";
            this.mapButton.Size = new System.Drawing.Size(80, 64);
            this.mapButton.TabIndex = 5;
            this.mapButton.TabStop = false;
            this.mapButton.UseVisualStyleBackColor = false;
            this.mapButton.Click += new System.EventHandler(this.mapButton_Click);
            // 
            // inputButton
            // 
            this.inputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputButton.Image = ((System.Drawing.Image)(resources.GetObject("inputButton.Image")));
            this.inputButton.Location = new System.Drawing.Point(622, 5);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(80, 64);
            this.inputButton.TabIndex = 4;
            this.inputButton.TabStop = false;
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // cameraButton
            // 
            this.cameraButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cameraButton.Image = global::FukjTabletSystem.Properties.Resources.Camera;
            this.cameraButton.Location = new System.Drawing.Point(536, 5);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(80, 64);
            this.cameraButton.TabIndex = 3;
            this.cameraButton.TabStop = false;
            this.cameraButton.UseVisualStyleBackColor = false;
            this.cameraButton.Click += new System.EventHandler(this.cameraButton_Click);
            // 
            // gpsButton
            // 
            this.gpsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpsButton.Image = global::FukjTabletSystem.Properties.Resources.Gps;
            this.gpsButton.Location = new System.Drawing.Point(98, 5);
            this.gpsButton.Name = "gpsButton";
            this.gpsButton.Size = new System.Drawing.Size(80, 64);
            this.gpsButton.TabIndex = 1;
            this.gpsButton.TabStop = false;
            this.gpsButton.UseVisualStyleBackColor = false;
            this.gpsButton.Click += new System.EventHandler(this.gpsButton_Click);
            // 
            // KensaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Name = "KensaMenuForm";
            this.Text = "検査メニュー";
            this.splitContainerTop.Panel1.ResumeLayout(false);
            this.splitContainerTop.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTop)).EndInit();
            this.splitContainerTop.ResumeLayout(false);
            this.splitContainerBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBottom)).EndInit();
            this.splitContainerBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Zynas.Control.ZButton backButton;
        private Zynas.Control.ZButton closeButton;
        private Zynas.Control.ZButton mapButton;
        private Zynas.Control.ZButton inputButton;
        private Zynas.Control.ZButton cameraButton;
        private Zynas.Control.ZButton gpsButton;
    }
}