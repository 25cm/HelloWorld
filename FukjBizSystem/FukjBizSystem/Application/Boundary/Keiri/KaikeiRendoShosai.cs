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
    public partial class KaikeiRendoShosaiForm : Form
    {
        public KaikeiRendoShosaiForm()
        {
            InitializeComponent();
            this.NyukinListDataGridView.Rows.Add("true", "01", "000", "999", "郵便貯金", "001", "郵貯 手数料", "00", "119,000", "000", "888", "前受金", "", "", "00", "119,000",  "前受金");
            this.NyukinListDataGridView.Rows.Add("true", "01", "000", "999", "郵便貯金", "001", "郵貯 手数料", "00", "17,000", "000", "998", "未収金", "001", "H25 7条検査", "00", "17,000", "7条検査収益 (株)○○○○");
            this.NyukinListDataGridView.Rows.Add("true", "01", "000", "999", "郵便貯金", "001", "郵貯 手数料", "00", "61,600", "000", "998", "未収金", "002", "H25 11条検査", "00", "61,600", "11条検査収益 (株)△△△△");

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
            KaikeiRendoListForm frm = new KaikeiRendoListForm();
            Program.mForm.ShowForm(frm);
        }


    }

}
