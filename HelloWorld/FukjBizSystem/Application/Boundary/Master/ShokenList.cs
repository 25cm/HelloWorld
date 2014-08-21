using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjBizSystem.Application.Boundary.Master
{
    public partial class ShokenList : Form
    {
        public ShokenList()
        {
            InitializeComponent();
        }

        private void TorokuButton_Click(object sender, EventArgs e)
        {
            ShokenShosai frm = new ShokenShosai();
            Program.mForm.ShowForm(frm);
        }

        private void TojiruButton_Click(object sender, EventArgs e)
        {
            MstMenuForm frm = new MstMenuForm();
            Program.mForm.ShowForm(frm);
        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Height == 30)
            {
                SearchPanel.Height = 177;
                GyoshaListPanel.Top = 176;
                GyoshaListPanel.Height = 375;
                ViewChangeButton.Text = "▲";
            }
            else
            {
                SearchPanel.Height = 30;
                GyoshaListPanel.Top = 30;
                GyoshaListPanel.Height = 520;
                ViewChangeButton.Text = "▼";
            }
        }

    }
}
