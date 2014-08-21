namespace FukjBizSystem.Application.Boundary.JokasoDaichoKanri
{
    partial class JokasoDaichoKanriMenu
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
            this.jokasoDaichoIchiranButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jokasoDaichoIchiranButton
            // 
            this.jokasoDaichoIchiranButton.Location = new System.Drawing.Point(12, 12);
            this.jokasoDaichoIchiranButton.Name = "jokasoDaichoIchiranButton";
            this.jokasoDaichoIchiranButton.Size = new System.Drawing.Size(135, 55);
            this.jokasoDaichoIchiranButton.TabIndex = 3;
            this.jokasoDaichoIchiranButton.Text = "浄化槽台帳一覧";
            this.jokasoDaichoIchiranButton.UseVisualStyleBackColor = true;
            this.jokasoDaichoIchiranButton.Click += new System.EventHandler(this.jokasoDaichoIchiranButton_Click);
            // 
            // JokasoDaichoKanriMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 593);
            this.Controls.Add(this.jokasoDaichoIchiranButton);
            this.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JokasoDaichoKanriMenu";
            this.Text = "JokasoDaichoKanriMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jokasoDaichoIchiranButton;
    }
}