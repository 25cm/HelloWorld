using System;
using System.Net;
using System.Reflection;
using FukjBizSystem.Application.BusinessLogic.YoshiHanbaiKanri.TyumonShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using FukjBizSystem.Application.BusinessLogic.YoshiHanbaiKanri.ZaikoList;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.YoshiHanbaiKanri.TyumonShosai
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDeleteBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDeleteBtnClickALInput : IBseALInput
    {
        /// <summary>
        /// 注文番号
        /// </summary>
        string YoshiHanbaiChumonNo { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickALInput : IDeleteBtnClickALInput
    {
        /// <summary>
        /// 注文番号
        /// </summary>
        public string YoshiHanbaiChumonNo { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("注文番号[{0}]", YoshiHanbaiChumonNo);
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDeleteBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDeleteBtnClickALOutput
    {
        /// <summary>
        /// Error message for delete
        /// </summary>
        string ErrMsg { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickALOutput : IDeleteBtnClickALOutput
    {
        /// <summary>
        /// Error message for delete
        /// </summary>
        public string ErrMsg { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickApplicationLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickApplicationLogic : BaseApplicationLogic<IDeleteBtnClickALInput, IDeleteBtnClickALOutput>
    {
        #region プロパティ

        /// <summary>
        /// 機能名
        /// </summary>
        private const string FunctionName = "TyumonShosai：DeleteBtnClick";

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： DeleteBtnClickApplicationLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public DeleteBtnClickApplicationLogic()
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
        /// 2014/07/23　AnhNV　　    新規作成
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
        /// 2014/07/23　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDeleteBtnClickALOutput Execute(IDeleteBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDeleteBtnClickALOutput output = new DeleteBtnClickALOutput();

            try
            {
                // トランザクション開始
                StartTransaction();

                // Get 用紙販売ヘッダテーブル by key
                IGetYoshiHanbaiHdrTblByKeyBLInput hdrInput = new GetYoshiHanbaiHdrTblByKeyBLInput();
                hdrInput.YoshiHanbaiChumonNo = input.YoshiHanbaiChumonNo;
                IGetYoshiHanbaiHdrTblByKeyBLOutput hdrOutput = new GetYoshiHanbaiHdrTblByKeyBusinessLogic().Execute(hdrInput);

                if (hdrOutput.YoshiHanbaiHdrTblDataTable.Count > 0)
                {
                    // 処理済チェック(削除時)
                    output.ErrMsg = ShoriSumiCheck(hdrOutput.YoshiHanbaiHdrTblDataTable[0]);

                    // Check OK
                    if (string.IsNullOrEmpty(output.ErrMsg))
                    {
                        // Get 用紙販売明細テーブル by 注文番号
                        IGetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput dtlInput = new GetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput();
                        dtlInput.YoshiHanbaiChumonNo = input.YoshiHanbaiChumonNo;
                        IGetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLOutput dtlOutput = new GetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBusinessLogic().Execute(dtlInput);

                        // Update 用紙在庫テーブル
                        IUpdateYoshiZaikoTblBLInput zaikoInput = new UpdateYoshiZaikoTblBLInput();
                        zaikoInput.YoshiZaikoTblDataTable = MakeYoshiZaikoTblUpdate(hdrOutput.YoshiHanbaiHdrTblDataTable[0].YoshiHanbaiShishoCd, dtlOutput.YoshiHanbaiDtlTblDataTable);
                        new UpdateYoshiZaikoTblBusinessLogic().Execute(zaikoInput);

                        // Delete 用紙販売ヘッダテーブル
                        IDeleteYoshiHanbaiHdrTblByKeyBLInput hdrDelInput = new DeleteYoshiHanbaiHdrTblByKeyBLInput();
                        hdrDelInput.YoshiHanbaiChumonNo = input.YoshiHanbaiChumonNo;
                        new DeleteYoshiHanbaiHdrTblByKeyBusinessLogic().Execute(hdrDelInput);

                        // Delete 用紙販売明細テーブル
                        IDeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput dtlDelInput = new DeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput();
                        dtlDelInput.YoshiHanbaiChumonNo = input.YoshiHanbaiChumonNo;
                        new DeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBusinessLogic().Execute(dtlDelInput);
                    }
                }
                else
                {
                    // Error
                    output.ErrMsg = string.Format("該当するデータは登録されていません。[注文番号：{0}]", input.YoshiHanbaiChumonNo);
                }

                // コミット
                CompleteTransaction();
            }
            catch
            {
                throw;
            }
            finally
            {
                // トランザクション終了
                EndTransaction();

                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region ShoriSumiCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ShoriSumiCheck
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdrRow"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string ShoriSumiCheck(YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow hdrRow)
        {
            string errMsg = string.Empty;

            // 処理済チェック(更新)
            if (hdrRow.IsYoshiHanbaiGenkinNyukingakuNull() || hdrRow.YoshiHanbaiGenkinNyukingaku != 0
                || hdrRow.IsYoshiHanbaiSeikyuKingakuNull() || hdrRow.YoshiHanbaiSeikyuKingaku != 0
                || hdrRow.IsYoshiHanbaiKansaiFlgNull() || hdrRow.YoshiHanbaiKansaiFlg != "0"
                || hdrRow.IsYoshiHanbaiSeikyushoHakkoFlgNull() || hdrRow.YoshiHanbaiSeikyushoHakkoFlg != "0"
                || hdrRow.IsYoshiHanbaiNohinshoHakkoFlgNull() || hdrRow.YoshiHanbaiNohinshoHakkoFlg != "0"
                || hdrRow.IsYoshiHanbaiHassoFlgNull() || hdrRow.YoshiHanbaiHassoFlg != "0")
            {
                errMsg = "既に処理済のため、更新/削除できません。";
            }

            return errMsg;
        }
        #endregion

        #region MakeYoshiZaikoTblUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeYoshiZaikoTblUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yoshiHanbaiChumonNo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private YoshiZaikoTblDataSet.YoshiZaikoTblDataTable MakeYoshiZaikoTblUpdate(string shishoCd, YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblDataTable dtlTable)
        {
            // 更新日
            DateTime now = Boundary.Common.Common.GetCurrentTimestamp();
            // 更新者
            string username = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;
            // 更新端末
            string hostname = Dns.GetHostName();

            // 在庫数量
            object sumObj;
            sumObj = dtlTable.Compute("Sum(YoshiHanbaiGokeiSuryo)", string.Empty);
            int zaikoSuryo = Convert.ToInt32(sumObj);

            // 用紙在庫テーブル
            YoshiZaikoTblDataSet.YoshiZaikoTblDataTable zaikoDT = new YoshiZaikoTblDataSet.YoshiZaikoTblDataTable();

            foreach (YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblRow row in dtlTable)
            {
                // Get 用紙在庫テーブル by key
                IGetYoshiZaikoTblByKeyBLInput zaikoInp = new GetYoshiZaikoTblByKeyBLInput();
                zaikoInp.YoshiZaikoShishoCd = shishoCd;
                zaikoInp.YoshiZaikoYoshiCd = row.YoshiHanbaiYoshiCd;
                IGetYoshiZaikoTblByKeyBLOutput zaikoOutp = new GetYoshiZaikoTblByKeyBusinessLogic().Execute(zaikoInp);

                if (zaikoOutp.YoshiZaikoTblDataTable.Count > 0)
                {
                    // 在庫数量
                    zaikoOutp.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo = zaikoOutp.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo + zaikoSuryo;

                    // 更新日
                    zaikoOutp.YoshiZaikoTblDataTable[0].UpdateDt = now;

                    // 更新者
                    zaikoOutp.YoshiZaikoTblDataTable[0].UpdateUser = username;

                    // 更新端末
                    zaikoOutp.YoshiZaikoTblDataTable[0].UpdateTarm = hostname;

                    zaikoDT.Merge(zaikoOutp.YoshiZaikoTblDataTable);
                }
            }

            return zaikoDT;
        }
        #endregion

        #endregion
    }
    #endregion
}
