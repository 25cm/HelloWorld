using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Utility;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjBizSystem.Application.Boundary.KensaIraiKanri
{
    public partial class KensaIraishoList : Form
    {

        KensaIraishoDisplay dispForm;

        // 画面位置管理クラス
        FormLocation formLocation = new FormLocation();

        public KensaIraishoList()
        {
            InitializeComponent();
        }

        public KensaIraishoList(KensaIraishoDisplay f)
        {
            dispForm = f; // メイン・フォームへの参照を保存
            InitializeComponent();
        }


        private void KensaIraishoList_Load(object sender, EventArgs e)
        {
            SetPdfInfo();

            // 保存画面位置取得
            Location = formLocation.GetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this);
            Size = formLocation.GetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, this.Size);
        }

        private void SetPdfInfo()
        {
            string pdfDir = @"C:\PDF"; // 画像ディレクトリ
            string[] pdfFiles = System.IO.Directory.GetFiles(pdfDir, "*.pdf");


            for (int i = 0; i < pdfFiles.Length; i++)
            {
                DateTime dtCreate = System.IO.File.GetCreationTime(pdfFiles[i]);

                dataGridView1.Rows.Add(pdfFiles[i], dtCreate);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                AxAcroPDFLib.AxAcroPDF acPdf = (AxAcroPDFLib.AxAcroPDF)dispForm.Controls["axAcroPDF1"];

                acPdf.LoadFile(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                acPdf.Refresh();
            }
        }

        private void KensaIraishoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 画面位置保存
            formLocation.SetPoint(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Location);
            formLocation.SetSize(ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinCd, this, Size);
        }
    }
}
