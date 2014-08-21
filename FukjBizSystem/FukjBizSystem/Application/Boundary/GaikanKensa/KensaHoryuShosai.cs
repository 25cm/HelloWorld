using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.GaikanKensa
{
    public partial class KensaHoryuShosaiForm : Form
    {
        public KensaHoryuShosaiForm()
        {
            InitializeComponent();
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
            MessageForm.Show2(MessageForm.DispModeType.Infomation, "前受金No：123456");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            KensaHoryuListForm frm = new KensaHoryuListForm();
            Program.mForm.ShowForm(frm);
        }

    }

}
