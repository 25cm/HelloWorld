using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class KeiriMenuForm : Form
    {
        public KeiriMenuForm()
        {
            InitializeComponent();
        }

        private void MaeukekinButton_Click(object sender, EventArgs e)
        {
            MaeukekinListForm frm = new MaeukekinListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UriageListForm frm = new UriageListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeikyuShimeForm frm = new SeikyuShimeForm();
            Program.mForm.ShowForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeikyuListForm frm = new SeikyuListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NyukinListForm frm = new NyukinListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KingakuShisanForm frm = new KingakuShisanForm();
            Program.mForm.ShowForm(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ZandakaListForm frm = new ZandakaListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KaikeiRendoListForm frm = new KaikeiRendoListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NyukinShosaiForm frm = new NyukinShosaiForm();
            Program.mForm.ShowForm(frm);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HenkinListForm frm = new HenkinListForm();
            Program.mForm.ShowForm(frm);
        }



    }
}
