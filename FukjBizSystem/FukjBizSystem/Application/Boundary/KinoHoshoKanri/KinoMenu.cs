using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.KinoHoshoKanri
{
    public partial class KinoMenuForm : Form
    {
        public KinoMenuForm()
        {
            InitializeComponent();
        }

        #region 保証番号印刷
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： HoshoNoPrintButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/04　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void HoshoNoPrintButton_Click(object sender, EventArgs e)
        {
            HoshoNoPrintForm frm = new HoshoNoPrintForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 保証申請入力
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： HoshoShinseiInputButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/04　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void HoshoShinseiInputButton_Click(object sender, EventArgs e)
        {
            HoshoShinseiListForm frm = new HoshoShinseiListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 保証登録申請書交換
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： HoshoShinseiKokanButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/01　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void HoshoShinseiKokanButton_Click(object sender, EventArgs e)
        {
            HoshoShinseiKokanForm frm = new HoshoShinseiKokanForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

    }
}
