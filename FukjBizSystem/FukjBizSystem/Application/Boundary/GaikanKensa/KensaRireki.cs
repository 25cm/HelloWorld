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

namespace FukjBizSystem.Application.Boundary.GaikanKensa
{
    public partial class KensaRirekiForm : Form
    {
        public KensaRirekiForm()
        {
            InitializeComponent();
            this.kensaRirekiListDataGridView.Rows.Add("1", "7条検査", "11-23-001223", "2012/02/12", "2014/03/01","検査員太郎", "○", "6.0", "12", "4.9", "0.5", "90", "90","");
            this.kensaRirekiListDataGridView.Rows.Add("2", "11条外観", "11-24-000234", "2013/01/12", "2013/01/30", "検査員太郎", "△", "5.9", "11", "6.0", "-", "99", "98", "○");
            this.kensaRirekiListDataGridView.Rows.Add("3", "11条水質", "11-25-000880", "2014/06/12", "2013/06/30", "検査員太郎", "×", "11.0", "13", "6.0", "-", "120", "123", "");

        
        
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
            GaikanKensaMenuForm frm = new GaikanKensaMenuForm();
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
            KensaMstSearchForm frm = new KensaMstSearchForm();
            frm.ShowDialog();
        }


    }

}
