using System;
using System.Reflection;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Master.HokenjoMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;
using System.Net;

namespace FukjBizSystem.Application.Boundary.Master
{
    public partial class ShokenShosai : Form
    {
        public ShokenShosai()
        {
            InitializeComponent();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            ShokenList frm = new ShokenList();
            Program.mForm.ShowForm(frm);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
