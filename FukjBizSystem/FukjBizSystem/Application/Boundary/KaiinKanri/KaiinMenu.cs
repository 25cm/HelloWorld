using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.KaiinKanri
{
    public partial class KaiinMenuForm : Form
    {
        public KaiinMenuForm()
        {
            InitializeComponent();
        }

        private void KaiinListButton_Click(object sender, EventArgs e)
        {
            KaiinListForm frm = new KaiinListForm();
            Program.mForm.ShowForm(frm);

        }



    }
}
