using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.KensaKekka
{
    public partial class KekkaMenuForm : Form
    {
        public KekkaMenuForm()
        {
            InitializeComponent();
        }

        private void MaeukekinButton_Click(object sender, EventArgs e)
        {
            KensaKekkaListForm frm = new KensaKekkaListForm();
            Program.mForm.ShowForm(frm);
        }

        private void kensaDaichoButton_Click(object sender, EventArgs e)
        {
            Demo.SuishitsuKensaDaichoForm frm = new Demo.SuishitsuKensaDaichoForm();
            Program.mForm.ShowForm(frm);
        }
    }
}
