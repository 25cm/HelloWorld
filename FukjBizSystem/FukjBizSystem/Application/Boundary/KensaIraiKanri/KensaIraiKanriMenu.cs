using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjBizSystem.Application.Boundary.KensaIraiKanri
{
    public partial class KensaIraiKanriMenu : Form
    {
        public KensaIraiKanriMenu()
        {
            InitializeComponent();
        }

        private void kensaIraiToroku7joButton_Click(object sender, EventArgs e)
        {
            KensaIraiToroku7jo frm = new KensaIraiToroku7jo();
            frm.Show();
            
        }
    }
}
