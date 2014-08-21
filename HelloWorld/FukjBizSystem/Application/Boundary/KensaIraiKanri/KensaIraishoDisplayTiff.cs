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
    public partial class KensaIraishoDisplayTiff : Form
    {
        public KensaIraishoDisplayTiff()
        {
            InitializeComponent();
        }

        private void KensaIraishoDisplayTiff_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(@"C:\kino\work\FukjBizSystem\fj_biz-system_bk20140710\FukjBizSystem\TestImage.tif");

            pictureBox1.Image = bm;

        }
    }
}
