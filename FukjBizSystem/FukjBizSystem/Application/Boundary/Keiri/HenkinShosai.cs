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
    public partial class HenkinShosaiForm : Form
    {
        public HenkinShosaiForm()
        {
            InitializeComponent();
            this.NyukinListDataGridView.Rows.Add( "1", "2014/07/01",  "11,000", "済");
            this.NyukinListDataGridView.Rows.Add("2", "2014/07/05",  "3,000", "済");
            this.NyukinListDataGridView.Rows.Add("3", "2014/07/09",  "1,500", "");
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
            HenkinListForm frm = new HenkinListForm();
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
