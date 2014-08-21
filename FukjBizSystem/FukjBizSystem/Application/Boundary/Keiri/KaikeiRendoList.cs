using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class KaikeiRendoListForm : Form
    {
        public KaikeiRendoListForm()
        {
            InitializeComponent();
            this.MaeukekinListDataGridView.Rows.Add("2014000003", "入金", "福　岡", "2014/08/05", "2014/07/01", "2014/07/31", "1,200", "○", "○", "○", "×", "256,000", "21,000","未");
            this.MaeukekinListDataGridView.Rows.Add("2014000002", "入金", "福　岡", "2014/07/05", "2014/06/01", "2014/06/30", "1,211", "○", "○", "○", "×", "286,900", "111,000", "済");
            this.MaeukekinListDataGridView.Rows.Add("2014000001", "入金", "福　岡", "2014/06/07", "2014/05/01", "2014/05/31", "1,139", "○", "○", "○", "×", "209,000", "89,000", "済");
            this.MakeDtFromTextBox.Value = DateTime.ParseExact("2014/08/01", "yyyy/MM/dd", null); 

        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Height == 30)
            {
                searchPanel.Height = 97;
                MaeukekinListPanel.Top = 103;
                MaeukekinListPanel.Height = 423;
                viewChangeButton.Text = "▲";
            }
            else
            {
                searchPanel.Height = 30;
                MaeukekinListPanel.Top = 30;
                MaeukekinListPanel.Height = 485;
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
            KaikeiRendoShosaiForm frm = new KaikeiRendoShosaiForm();
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

        private void SrhDtUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SrhDtUseCheckBox.Checked )
            {
                MakeDtFromTextBox.Enabled = true;
                MakeDtToTextBox.Enabled = true;
            }else{
                MakeDtFromTextBox.Enabled = false;
                MakeDtToTextBox.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            KaikeiMakeFileForm frm = new KaikeiMakeFileForm();
            frm.ShowDialog();
        }




    }

}
