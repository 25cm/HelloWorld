using System.Net;
using System.Reflection;
using FukjBizSystem.Application.Boundary.Keiri;
using FukjBizSystem.Application.BusinessLogic.Keiri.MaeukekinShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.Keiri.MaeukekinShosai
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDecisionBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALInput : IBseALInput, IUpdateMaeukekinTblBLInput
    {
        /// <summary>
        /// DispMode
        /// </summary>
        MaeukekinShosaiForm.DispMode DispMode { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DecisionBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALInput : IDecisionBtnClickALInput
    {
        /// <summary>
        /// DispMode
        /// </summary>
        public MaeukekinShosaiForm.DispMode DispMode { get; set; }

        /// <summary>
        /// MaeukekinTblDataTable
        /// </summary>
        public MaeukekinTblDataSet.MaeukekinTblDataTable MaeukekinTblDT { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("DispMode[{0}], MaeukekinTblDataTable[{1}]", 
                    new string[] { 
                        DispMode.ToString(),
                        MaeukekinTblDT[0].MaeukekinSyogoNo1 
                    });
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDecisionBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALOutput : IUpdateMaeukekinTblBLOutput
    {
        /// <summary>
        /// ErrMessage
        /// </summary>
        string ErrMessage { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DecisionBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALOutput : IDecisionBtnClickALOutput
    {
        /// <summary>
        /// ErrMessage
        /// </summary>
        public string ErrMessage { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DecisionBtnClickApplicationLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickApplicationLogic : BaseApplicationLogic<IDecisionBtnClickALInput, IDecisionBtnClickALOutput>
    {
        #region 定義

        public enum OperationErr
        {
            RakkanLock,     // 楽観ロックエラー
        }

        #endregion

        #region プロパティ

        /// <summary>
        /// 機能名
        /// </summary>
        private const string FunctionName = "MaeukekinShosai：DecisionBtnClickApplicationLogic";

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： DecisionBtnClickApplicationLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public DecisionBtnClickApplicationLogic()
        {
            
        }
        #endregion

        #region メソッド(protected)

        #region GetFunctionName
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GetFunctionName
        /// <summary>
        /// 機能名取得
        /// </summary>
        /// <returns>機能名</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override string GetFunctionName()
        {
            return FunctionName;
        }
        #endregion

        #endregion

        #region メソッド(public)

        #region Execute
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： Execute
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDecisionBtnClickALOutput Execute(IDecisionBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDecisionBtnClickALOutput output = new DecisionBtnClickALOutput();

            try
            {
                MaeukekinTblDataSet.MaeukekinTblDataTable dataTable = new MaeukekinTblDataSet.MaeukekinTblDataTable();

                StartTransaction();

                if (input.DispMode == MaeukekinShosaiForm.DispMode.Edit)
                {
                    if (CheckExist(input.MaeukekinTblDT))
                    {
                        output.ErrMessage = string.Format("該当するデータは登録されていません。[前受金No：{0}]",
                            new string[] { input.MaeukekinTblDT[0].MaeukekinSyogoNo1 + "-" + input.MaeukekinTblDT[0].MaeukekinSyogoNo2 });

                        return output;
                    }

                    dataTable = CreateDataUpdate(input);
                }
                else
                {
                    if (!CheckExist(input.MaeukekinTblDT))
                    {
                        output.ErrMessage = string.Format("既に登録済みです。[前受金No：{0}]",
                            new string[] { input.MaeukekinTblDT[0].MaeukekinSyogoNo1 + "-" + input.MaeukekinTblDT[0].MaeukekinSyogoNo2 });

                        return output;
                    }

                    dataTable = input.MaeukekinTblDT;
                }

                // insert/update
                IUpdateMaeukekinTblBLInput blInput = new UpdateMaeukekinTblBLInput();
                blInput.MaeukekinTblDT = dataTable;
                IUpdateMaeukekinTblBLOutput blOutput = new UpdateMaeukekinTblBusinessLogic().Execute(blInput);

                CompleteTransaction();

            }
            catch
            {
                throw;
            }
            finally
            {
                EndTransaction();

                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region CreateDataUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateDataUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="input">AL入力情報</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private MaeukekinTblDataSet.MaeukekinTblDataTable CreateDataUpdate(IDecisionBtnClickALInput input)
        {
            MaeukekinTblDataSet.MaeukekinTblDataTable updateDT = new MaeukekinTblDataSet.MaeukekinTblDataTable();

            IGetMaeukekinTblByKeyBLInput blInput    = new GetMaeukekinTblByKeyBLInput();
            blInput.MaeukekinSyogoNo1               = input.MaeukekinTblDT[0].MaeukekinSyogoNo1;
            blInput.MaeukekinSyogoNo2               = input.MaeukekinTblDT[0].MaeukekinSyogoNo2;
            IGetMaeukekinTblByKeyBLOutput blOutput  = new GetMaeukekinTblByKeyBusinessLogic().Execute(blInput);

            MaeukekinTblDataSet.MaeukekinTblRow row = blOutput.MaeukekinTblDT[0];

            // 更新日が違うか？
            if (row.UpdateDt != input.MaeukekinTblDT[0].UpdateDt)
            {
                throw new CustomException((int)ResultCode.LockError, (int)OperationErr.RakkanLock, string.Empty);
            }

            // 入金先金融機関
            row.MaeukekinKinyukikan = input.MaeukekinTblDT[0].MaeukekinKinyukikan;

            // 入金日付
            row.MaeukekinNyukinDt = input.MaeukekinTblDT[0].MaeukekinNyukinDt;

            // 入金額
            row.MaeukekinNyukinAmt = input.MaeukekinTblDT[0].MaeukekinNyukinAmt;

            // 振込人名
            row.MaeukekinFurikomininNm = input.MaeukekinTblDT[0].MaeukekinFurikomininNm;

            // 振込人名カナ
            row.MaeukekinFurikomininKana = input.MaeukekinTblDT[0].MaeukekinFurikomininKana;

            // 備考
            row.MaeukekinBiko = input.MaeukekinTblDT[0].MaeukekinBiko;

            // 売上日付
            row.MaeukekinUriageDt = input.MaeukekinTblDT[0].MaeukekinUriageDt;

            // 取下日付
            row.MaeukekinTorisageDt = input.MaeukekinTblDT[0].MaeukekinTorisageDt;

            // 検査依頼法定区分
            row.MaeukekinKensaIraiHoteiKbn = input.MaeukekinTblDT[0].MaeukekinKensaIraiHoteiKbn;

            // 検査依頼保健所コード
            row.MaeukekinKensaIraiHokenjoCd = input.MaeukekinTblDT[0].MaeukekinKensaIraiHokenjoCd;

            // 検査依頼年度
            row.MaeukekinKensaIraiNendo = input.MaeukekinTblDT[0].MaeukekinKensaIraiNendo;

            // 検査依頼連番
            row.MaeukekinKensaIraiRenban = input.MaeukekinTblDT[0].MaeukekinKensaIraiRenban;

            // 強制売上金額
            row.MaeukekinKyoseiUriageAmt = input.MaeukekinTblDT[0].MaeukekinKyoseiUriageAmt;

            // 強制売上フラグ
            row.MaeukekinKyoseiUriageFlg = input.MaeukekinTblDT[0].MaeukekinKyoseiUriageFlg;

            // 入金取扱日付
            row.MaeukekinNyukintoriatukaiDt = input.MaeukekinTblDT[0].MaeukekinNyukintoriatukaiDt;

            // 一部返金日
            row.MaeukekinIchibuHenkinDt = input.MaeukekinTblDT[0].MaeukekinIchibuHenkinDt;

            // 一部返金額
            row.MaeukekinIchibuHenkinAmt = input.MaeukekinTblDT[0].MaeukekinIchibuHenkinAmt;

            // 残金
            row.MaeukekinZanAmt = input.MaeukekinTblDT[0].MaeukekinZanAmt;

            // 更新日
            row.UpdateDt = Boundary.Common.Common.GetCurrentTimestamp();

            // 更新者
            row.UpdateUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

            // 更新端末
            row.UpdateTarm = Dns.GetHostName();

            updateDT.ImportRow(row);

            return updateDT;
        }
        #endregion

        #region CheckExist
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CheckExist
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dataTable"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckExist(MaeukekinTblDataSet.MaeukekinTblDataTable dataTable)
        {
            IGetMaeukekinTblByKeyBLInput blInput    = new GetMaeukekinTblByKeyBLInput();
            blInput.MaeukekinSyogoNo1               = dataTable[0].MaeukekinSyogoNo1;
            blInput.MaeukekinSyogoNo2               = dataTable[0].MaeukekinSyogoNo2;
            IGetMaeukekinTblByKeyBLOutput blOutput  = new GetMaeukekinTblByKeyBusinessLogic().Execute(blInput);

            if (blOutput.MaeukekinTblDT != null && blOutput.MaeukekinTblDT.Count > 0)
            {
                return false;
            }

            return true;
        }
        #endregion

        #endregion
    }
    #endregion
}
