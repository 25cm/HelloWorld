using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.GaikanKensa
{
    public partial class GaikanKensaMenuForm : Form
    {
        public GaikanKensaMenuForm()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            KensaHoryuListForm frm = new KensaHoryuListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KensaRirekiForm frm = new KensaRirekiForm();
            Program.mForm.ShowForm(frm);
        }




    }
}
