using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class SeikyuShosaiForm : Form
    {
        public SeikyuShosaiForm()
        {
            InitializeComponent();
            this.SeikyuListDataGridView.Rows.Add("01", "1", "○○支所", "検査手数料", "浄化槽法定検査手数料（11条外観検査）", "1", "21,000", "21,000", "0", "21,000", "0", "未");
            this.SeikyuListDataGridView.Rows.Add("02", "1", "○○支所", "検査手数料", "浄化槽法定検査手数料（11条水質検査）", "1", "18,000", "18,000", "0", "18,000", "0", "未");
            this.SeikyuListDataGridView.Rows.Add("03", "1", "○○支所", "用紙販売", "浄化槽設置届出・計画書", "10", "150", "1,500", "120", "1,620", "0", "未");
            this.SeikyuListDataGridView.Rows.Add("04", "", "", "繰り越し金", "繰り越し金", "1", "", "", "", "-2,000", "0", "", "－");
            this.SeikyuListDataGridView.Rows.Add("05", "", "", "追加明細", "検査啓発推進費調整分", "1", "", "-7,000", "0", "-7,000", "0", "", "－");
        }
        private void EntryButton_Click(object sender, EventArgs e)
        {
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }

        private void ReInputButton_Click(object sender, EventArgs e)
        {
        }

        private void DecisionButton_Click(object sender, EventArgs e)
        {
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SeikyuListForm frm = new SeikyuListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GyoshaMstSearchForm frm = new GyoshaMstSearchForm();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JokasoDaichoSearchForm frm = new JokasoDaichoSearchForm();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeikyuAddMeisaiForm frm = new SeikyuAddMeisaiForm();
            frm.ShowDialog();
        }

    }

}
