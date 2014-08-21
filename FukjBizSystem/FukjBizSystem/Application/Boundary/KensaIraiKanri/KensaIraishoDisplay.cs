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
    public partial class KensaIraishoDisplay : Form
    {

        KensaIraishoList frmlist;

        KensaIraiToroku7jo dispForm;

        // 画面位置管理クラス
        FormLocation formLocation = new FormLocation();

        public KensaIraishoDisplay()
        {
            InitializeComponent();
        }



        public KensaIraishoDisplay(KensaIraiToroku7jo f)
        {
            dispForm = f; // メイン・フォームへの参照を保存
            InitializeComponent();
        }


        private void KensaIraishoDisplay_Load(object sender, EventArgs e)
        {

            //            frmimglist = new KensaIraishoImageList(this);
            //            frmimglist.Show();

            frmlist = new KensaIraishoList(this);
            frmlist.Show(this);
            //frmlist.Show();

            // 保存画面位置取得
            Location = formLocation.GetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this);
            Size = formLocation.GetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, this.Size);
        }

        private void KensaIraishoDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmlist.Close();
        }

        private void KensaIraishoDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 画面位置保存
            formLocation.SetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Location);
            formLocation.SetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Size);
        }

        private void KensaIraishoDisplay_Activated(object sender, EventArgs e)
        {
            // TODO ウィンドウの親子関係で対応できる場合は、以下は不要

            //frmlist.SuspendLayout();
            //this.SuspendLayout();
            //frmlist.BringToFront();
            //this.BringToFront();
            //this.Activate();
            //this.ResumeLayout();
            //frmlist.ResumeLayout();
        }
    }
}
