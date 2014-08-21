using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Common;
using FukjBizSystem.Application.Boundary.Keiri;

namespace FukjBizSystem.Application.Boundary.Master
{
    public partial class MstMenuForm : Form
    {
        public MstMenuForm()
        {
            InitializeComponent();
        }

        #region 保健所マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： HokenjoMstButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void HokenjoMstButton_Click(object sender, EventArgs e)
        {
            HokenjoMstListForm frm = new HokenjoMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 地区マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ChikuMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ChikuMstButton_click(object sender, EventArgs e)
        {
            ChikuMstListForm frm = new ChikuMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 水質マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SishoMstButton_click(object sender, EventArgs e)
        {
            ShishoMstListForm frm = new ShishoMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 採水員マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SaisuiinMstButton_click(object sender, EventArgs e)
        {
            SaisuiinMstListForm frm = new SaisuiinMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 業者マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： GoyushaMstButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void GoyushaMstButton_Click(object sender, EventArgs e)
        {
            GyoshaMstListForm frm = new GyoshaMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 名称マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： MeishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MeishoMstButton_click(object sender, EventArgs e)
        {
            NameMstEditListForm frm = new NameMstEditListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 水質マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SuisitsuMstButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SuisitsuMstButton_Click(object sender, EventArgs e)
        {
            SuishitsuMstListForm frm = new SuishitsuMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 職員マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SyokuinMstButton_click(object sender, EventArgs e)
        {
            ShokuinMstListForm frm = new ShokuinMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 部署マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void BusyoMstButton_click(object sender, EventArgs e)
        {
            BushoMstListForm frm = new BushoMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 役職マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void YakushokuMstButton_click(object sender, EventArgs e)
        {
            YakushokuMstListForm frm = new YakushokuMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 権限マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KengenMstButton_click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 処理方式マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ShoriMstButton_click(object sender, EventArgs e)
        {
            ShoriHoshikiMstListForm frm = new ShoriHoshikiMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 型式マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KatasikiMstButton_click(object sender, EventArgs e)
        {
            KatashikiMstListForm frm = new KatashikiMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 外観検査項目マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void GaikanKensaItemMstButton_click(object sender, EventArgs e)
        {
            GaikankensaKomokuMstListForm frm = new GaikankensaKomokuMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 水質検査項目マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SuishitsuKensaItemMstButton_click(object sender, EventArgs e)
        {
            SuishitsuShikenKoumokuMstListForm frm = new SuishitsuShikenKoumokuMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 水質結果名称マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SuishitsuKekkaNameMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SuishitsuKekkaNameMstButton_click(object sender, EventArgs e)
        {
            SuishitsuKekkaNmMstListForm frm = new SuishitsuKekkaNmMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region セット試験項目マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetSikenItemMstButton_click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 水質検査セットマスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ShuishitsuKensaSetMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ShuishitsuKensaSetMstButton_click(object sender, EventArgs e)
        {
            SuishitsuKensaSetMstListForm frm = new SuishitsuKensaSetMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 建築用途マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KentikuYoutoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KentikuYoutoMstButton_click(object sender, EventArgs e)
        {
            KenchikuyotoMstListForm frm = new KenchikuyotoMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 所見マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ShokenMstButton_click(object sender, EventArgs e)
        {
            ShokenList frm = new ShokenList();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 料金マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void RyokinMstButton_click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 支所管理マスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： SishoMstButton_click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24　YS.CHEW    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SishoKanriMstButton_click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region メモマスタ一覧
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： MemoMstButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/05　宗　　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MemoMstButton_Click(object sender, EventArgs e)
        {
            MemoMstListForm frm = new MemoMstListForm();
            Program.mForm.ShowForm(frm);
        }
        #endregion

        #region 動作確認
        private void MstMenuForm_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.F12:
            //        Test frm = new Test();
            //        Program.mForm.ShowForm(frm);
            //        break;
            //    default:
            //        break;
            //}
        }
        #endregion

    }
}
