using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;
using System.Drawing;

namespace FukjBizSystem.Application.Boundary.GaikanKensa
{
    public partial class KensaHoryuListForm : Form
    {
        public KensaHoryuListForm()
        {
            InitializeComponent();
            this.HoryuListDataGridView.Rows.Add("1", "05-20-000082", "浄化槽太郎","検査員太郎", "未建築", "未建築（造成のみ）", "2014/08/01", "2015/02/01", "○", "○");
            this.HoryuListDataGridView.Rows.Add("2", "05-20-000102", "株式会社○○", "検査員太郎", "未入居", "未入居", "2014/05/11", "2014/11/11", "", "");
            this.HoryuListDataGridView.Rows.Add("3", "06-22-000152", "浄化槽花子", "検査員太郎", "未建築", "未建築（下水道との兼ね合い）", "2014/02/10", "2014/08/10", "○", "○");
            this.HoryuListDataGridView[7, 2].Style.ForeColor = Color.Red;
            this.HoryuListDataGridView.Rows.Add("4", "06-22-000152", "(有)△△", "検査員太郎", "", "", "", "", "", "");

        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Height == 30)
            {
                searchPanel.Height = 141;
                MaeukekinListPanel.Top = 139;
                MaeukekinListPanel.Height = 399;
                viewChangeButton.Text = "▲";
            }
            else
            {
                searchPanel.Height = 30;
                MaeukekinListPanel.Top = 30;
                MaeukekinListPanel.Height = 500;
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
            KensaHoryuShosaiForm frm = new KensaHoryuShosaiForm();
            Program.mForm.ShowForm(frm);
        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {
            KensaHoryuShosaiForm frm = new KensaHoryuShosaiForm();
            Program.mForm.ShowForm(frm);
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            GaikanKensaMenuForm frm = new GaikanKensaMenuForm();
            Program.mForm.ShowForm(frm);
        }



    }

}
