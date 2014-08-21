using System.Net;
using System.Reflection;
using FukjBizSystem.Application.Boundary.Master;
using FukjBizSystem.Application.BusinessLogic.Master.ShoriHoshikiMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.Master.ShoriHoshikiMstShosai
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
    /// 2014/07/01  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALInput : IBseALInput, IUpdateShoriHoshikiMstBLInput
    {
        /// <summary>
        /// DispMode
        /// </summary>
        ShoriHoshikiMstShosaiForm.DispMode DispMode { get; set; }
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
    /// 2014/07/01  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALInput : IDecisionBtnClickALInput
    {
        /// <summary>
        /// DispMode
        /// </summary>
        public ShoriHoshikiMstShosaiForm.DispMode DispMode { get; set; }

        /// <summary>
        /// ShoriHoshikiMstDataTable
        /// </summary>
        public ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable ShoriHoshikiMstDT { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("DispMode[{0}], ShoriHoshikiMstDataTable[{1}]", 
                    new string[]{
                        DispMode.ToString(),
                        ShoriHoshikiMstDT[0].ShoriHoshikiCd
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
    /// 2014/07/01  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALOutput : IUpdateShoriHoshikiMstBLOutput
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
    /// 2014/07/01  DatNT　　    新規作成
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
    /// 2014/07/01  DatNT　　    新規作成
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
        private const string FunctionName = "ShoriHoshikiMstShosai：DecisionBtnClickApplicationLogic";

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
        /// 2014/07/01  DatNT　　    新規作成
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
        /// 2014/07/01  DatNT　　    新規作成
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
        /// 2014/07/01  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDecisionBtnClickALOutput Execute(IDecisionBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDecisionBtnClickALOutput output = new DecisionBtnClickALOutput();

            try
            {
                ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable dataTable = new ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable();

                StartTransaction();

                if (input.DispMode == ShoriHoshikiMstShosaiForm.DispMode.Edit)
                {
                    if (CheckExist(input.ShoriHoshikiMstDT))
                    {
                        output.ErrMessage = string.Format("該当するデータは登録されていません。[処理方式区分：{0}、処理方式コード：{1}]",
                            new string[] { input.ShoriHoshikiMstDT[0].ShoriHoshikiKbn, input.ShoriHoshikiMstDT[0].ShoriHoshikiCd });

                        return output;
                    }

                    dataTable = CreateDataUpdate(input);
                }
                else
                {
                    if (!CheckExist(input.ShoriHoshikiMstDT))
                    {
                        output.ErrMessage = string.Format("既に登録済みです。[処理方式区分：{0}、処理方式コード：{1}]", 
                            new string[]{ input.ShoriHoshikiMstDT[0].ShoriHoshikiKbn, input.ShoriHoshikiMstDT[0].ShoriHoshikiCd });

                        return output;
                    }

                    dataTable = input.ShoriHoshikiMstDT;
                }

                // insert/update
                IUpdateShoriHoshikiMstBLInput blInput = new UpdateShoriHoshikiMstBLInput();
                blInput.ShoriHoshikiMstDT = dataTable;
                IUpdateShoriHoshikiMstBLOutput blOutput = new UpdateShoriHoshikiMstBusinessLogic().Execute(blInput);

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
        /// 2014/07/01　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable CreateDataUpdate(IDecisionBtnClickALInput input)
        {
            ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable updateDT = new ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable();

            IGetShoriHoshikiMstByKeyBLInput blInput     = new GetShoriHoshikiMstByKeyBLInput();
            blInput.ShoriHoshikiKbn                     = input.ShoriHoshikiMstDT[0].ShoriHoshikiKbn;
            blInput.ShoriHoshikiCd                      = input.ShoriHoshikiMstDT[0].ShoriHoshikiCd;
            IGetShoriHoshikiMstByKeyBLOutput blOutput   = new GetShoriHoshikiMstByKeyBusinessLogic().Execute(blInput);

            ShoriHoshikiMstDataSet.ShoriHoshikiMstRow row = blOutput.ShoriHoshikiMstDT[0];

            // 更新日が違うか？
            if (row.UpdateDt != input.ShoriHoshikiMstDT[0].UpdateDt)
            {
                throw new CustomException((int)ResultCode.LockError, (int)OperationErr.RakkanLock, string.Empty);
            }

            // 処理方式区分
            row.ShoriHoshikiKbn = input.ShoriHoshikiMstDT[0].ShoriHoshikiKbn;

            // 処理方式コード
            row.ShoriHoshikiCd = input.ShoriHoshikiMstDT[0].ShoriHoshikiCd;

            // 処理方式種別名
            row.ShoriHoshikiShubetsuNm = input.ShoriHoshikiMstDT[0].ShoriHoshikiShubetsuNm;

            // 処理方式名
            row.ShoriHoshikiNm = input.ShoriHoshikiMstDT[0].ShoriHoshikiNm;

            // 処理方式種別区分
            row.ShoriHoshikiShubetsuKbn = input.ShoriHoshikiMstDT[0].ShoriHoshikiShubetsuKbn;

            // 処理方式内部名
            row.ShoriHoshikiNaibuNm = input.ShoriHoshikiMstDT[0].ShoriHoshikiNaibuNm;

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
        /// 2014/07/02　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckExist(ShoriHoshikiMstDataSet.ShoriHoshikiMstDataTable dataTable)
        {
            IGetShoriHoshikiMstByKeyBLInput blInput     = new GetShoriHoshikiMstByKeyBLInput();
            blInput.ShoriHoshikiCd                      = dataTable[0].ShoriHoshikiCd;
            blInput.ShoriHoshikiKbn                     = dataTable[0].ShoriHoshikiKbn;
            IGetShoriHoshikiMstByKeyBLOutput blOutput   = new GetShoriHoshikiMstByKeyBusinessLogic().Execute(blInput);

            if (blOutput.ShoriHoshikiMstDT != null && blOutput.ShoriHoshikiMstDT.Count > 0)
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
