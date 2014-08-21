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
    public partial class NyukinShosaiForm : Form
    {
        public NyukinShosaiForm()
        {
            InitializeComponent();
            this.NyukinListDataGridView.Rows.Add("2014000001", "01", "検査手数料", "浄化槽法定検査手数料（11条外観検査）", "21,000", "", "21,000");
            this.NyukinListDataGridView.Rows.Add("2014000003", "01", "検査手数料", "浄化槽法定検査手数料（11条水質検査）", "18,000", "", "18,000");
            this.NyukinListDataGridView.Rows.Add("2014000003", "02", "用紙販売", "浄化槽設置届出・計画書", "1,500", "", "1,500");
            this.NyukinListDataGridView.Rows.Add("2014000003", "03", "追加明細", "特別検査手数料", "1,000", "", "1,000");
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
            NyukinListForm frm = new NyukinListForm();
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

    }

}
