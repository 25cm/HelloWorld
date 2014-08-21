using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zynas.Framework.Core.Common.Boundary;
using FukjBizSystem.Application.Utility;

namespace FukjBizSystem.Application.Boundary.KensaIraiKanri
{
    public partial class KensaIraiToroku7jo : Form
    {
        KensaIraishoDisplay frmdisp;

        // 画面位置管理クラス
        FormLocation formLocation = new FormLocation();

        public KensaIraiToroku7jo()
        {
            InitializeComponent();
        }

        private void KensaIraiToroku7jo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool forward = e.Modifiers != Keys.Shift;
                this.SelectNextControl(this.ActiveControl, forward, true, true, true);
                e.Handled = true;
            }
        }

        private void KensaIraiToroku7jo_Load(object sender, EventArgs e)
        {
            frmdisp = new KensaIraishoDisplay(this);
            frmdisp.Show();

            // 保存画面位置取得
            Location = formLocation.GetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this);
            Size = formLocation.GetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, this.Size);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KensaIraiToroku7jo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frmdisp.Close();
        }

        private void KensaIraiToroku7jo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 画面位置保存
            formLocation.SetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Location);
            formLocation.SetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Size);
        }

    }
}
