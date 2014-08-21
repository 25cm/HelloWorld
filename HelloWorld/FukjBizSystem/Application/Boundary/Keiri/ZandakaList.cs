using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class ZandakaListForm : Form
    {
        public ZandakaListForm()
        {
            InitializeComponent();
            this.MaeukekinListDataGridView.Rows.Add("2014000001", "1", "0", "1234", "株式会社○○環境開発工業", "2014/07/05",  "検査手数料", "浄化槽法定検査手数料（11条外観検査）", "21,000", "0");
            this.MaeukekinListDataGridView.Rows.Add("2014000001", "2", "0", "1234", "株式会社○○環境開発工業", "2014/07/05",  "用紙販売", "浄化槽設置届出・計画書", "2,000", "0");
            this.MaeukekinListDataGridView.Rows.Add("2014000003", "1", "0", "2345", "株式会社△△環境開発工業", "2014/07/05",  "計量証明", "浄化槽法定検査手数料（計量証明）", "9,000", "0");


            this.SrhDtFromTextBox.Value = DateTime.ParseExact("2014/07/01", "yyyy/MM/dd", null);
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

        private void SrhUseSeikyuDtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SrhUseSeikyuDtCheckBox.Checked)
            {
                SrhDtFromTextBox.Enabled = true;
                SrhDtToTextBox.Enabled = true;
            }
            else
            {
                SrhDtFromTextBox.Enabled = false;
                SrhDtToTextBox.Enabled = false;
            }
        }



    }

}
