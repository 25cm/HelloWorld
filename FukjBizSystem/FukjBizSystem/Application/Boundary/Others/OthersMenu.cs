using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.Others
{
    public partial class OthersMenuForm : Form
    {
        public OthersMenuForm()
        {
            InitializeComponent();
        }

        private void KaiinListButton_Click(object sender, EventArgs e)
        {
            FileKanriListForm frm = new FileKanriListForm();
            Program.mForm.ShowForm(frm);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TuckSealListForm frm = new TuckSealListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KensaKeihatsuSuishinhiListForm frm = new KensaKeihatsuSuishinhiListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KensaJokyoListForm frm = new KensaJokyoListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KensainGeppoListForm frm = new KensainGeppoListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KensainSyuhoListForm frm = new KensainSyuhoListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JokasoDaichoSyukeiListForm frm = new JokasoDaichoSyukeiListForm();
            Program.mForm.ShowForm(frm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EnkabutsuIonNodoHikakuListForm frm = new EnkabutsuIonNodoHikakuListForm();
            Program.mForm.ShowForm(frm);
        }



    }
}
