using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;

namespace FukjBizSystem.Application.Boundary.SaisuiinKanri
{
    public partial class SaisuiinMenuForm : Form
    {
        public SaisuiinMenuForm()
        {
            InitializeComponent();
        }

        #region 受講予定者一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： JyukoYoteishaListButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/14　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void JyukoYoteishaListButton_Click(object sender, EventArgs e)
        {
            JyukoYoteishaListForm frm = new JyukoYoteishaListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 採水員情報一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SaisuiinInfoListButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/14　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SaisuiinInfoListButton_Click(object sender, EventArgs e)
        {
            SaisuiinInfoListForm frm = new SaisuiinInfoListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 採水員証明書発行
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SaisuiinShoshoHakkoButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/14　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SaisuiinShoshoHakkoButton_Click(object sender, EventArgs e)
        {
            SaisuiinShomeishoHakkoForm frm = new SaisuiinShomeishoHakkoForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 受講履入力
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： button1_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/14　宗          新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            JyukoshaInputForm frm = new JyukoshaInputForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

    }
}
