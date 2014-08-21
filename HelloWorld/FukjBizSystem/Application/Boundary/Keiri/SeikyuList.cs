using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class SeikyuListForm : Form
    {
        public SeikyuListForm()
        {
            InitializeComponent();
            this.MaeukekinListDataGridView.Rows.Add("2014000001", "1234", "株式会社○○環境開発工業", "2014/07/05",  "21,000", "未", "済");
            this.MaeukekinListDataGridView.Rows.Add("2014000002", "2345", "株式会社△△環境開発工業", "2014/07/05",  "34,000", "未", "済");
            this.MaeukekinListDataGridView.Rows.Add("2014000003", "3456", "株式会社□□環境開発工業", "2014/07/05",  "56,000", "未", "済");
            this.MaeukekinListDataGridView.Rows.Add("", "4567", "株式会社××環境開発工業", "", "56,000", "未", "未");

            this.SeikyuDtFromTextBox.Value = DateTime.ParseExact("2014/07/01", "yyyy/MM/dd", null);
        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Height == 30)
            {
                searchPanel.Height = 184;
                MaeukekinListPanel.Top = 187;
                MaeukekinListPanel.Height = 339;
                viewChangeButton.Text = "▲";
            }
            else
            {
                searchPanel.Height = 30;
                MaeukekinListPanel.Top = 30;
                MaeukekinListPanel.Height = 475;
                viewChangeButton.Text = "▼";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
        }

        private void torokuButton_Click(object sender, EventArgs e)
        {
            SeikyuShimeForm frm = new SeikyuShimeForm();
            frm.ShowDialog();
        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {
            SeikyuShosaiForm frm = new SeikyuShosaiForm();
            Program.mForm.ShowForm(frm);
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            KeiriMenuForm frm = new KeiriMenuForm();
            Program.mForm.ShowForm(frm);
        }

        private void SrhUseSeikyuDtcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SrhUseSeikyuDtcheckBox.Checked)
            {
                SeikyuDtFromTextBox.Enabled = true;
                SeikyuDtToTextBox.Enabled = true;
            }
            else
            {
                SeikyuDtFromTextBox.Enabled = false;
                SeikyuDtToTextBox.Enabled = false;
            }
        }



    }

}
