using System;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.YoshiHanbaiKanri;
using FukjBizSystem.Application.BusinessLogic.YoshiHanbaiKanri.TyumonShosai;
using FukjBizSystem.Application.BusinessLogic.YoshiHanbaiKanri.ZaikoList;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.YoshiHanbaiKanri.TyumonShosai
{
    #region UpdateData class
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： UpdateData
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public class UpdateData
    {
        /// <summary>
        /// 表示モード
        /// </summary>
        public TyumonShosaiForm.DispMode DispMode { get; set; }

        /// <summary>
        /// 注文番号(7)
        /// </summary>
        public string YoshiHanbaiChumonNo { get; set; }

        /// <summary>
        /// 支所コード(1)
        /// </summary>
        public string YoshiHanbaiShishoCd { get; set; }

        /// <summary>
        /// 販売先業者コード(2)
        /// </summary>
        public string YoshiHanbaisakiGyoshaCd { get; set; }

        /// <summary>
        /// 販売先担当者(4)
        /// </summary>
        public string YoshiHanbaisakiTantosha { get; set; }

        /// <summary>
        /// 会員区分
        /// </summary>
        public string KaiinKbn { get; set; }

        /// <summary>
        /// 販売合計金額(8)
        /// </summary>
        public decimal YoshiHanbaiGokeiKingaku { get; set; }

        /// <summary>
        /// 用紙一覧グリッドビュー(9)
        /// </summary>
        public DataGridView YoshiListDgv { get; set; }

        /// <summary>
        /// Current datetime in DB
        /// </summary>
        public DateTime Now { get; set; }

        /// <summary>
        /// 販売日
        /// </summary>
        public DateTime YoshiHanbaiDt { get; set; }

        /// <summary>
        /// 用紙販売ヘッダテーブル
        /// </summary>
        public YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable YoshiHanbaiHdrTblDataTable { get; set; }
    }
    #endregion

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
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALInput : IBseALInput
    {
        /// <summary>
        /// UpdateData
        /// </summary>
        UpdateData UpdateData { get; set; }
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
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALInput : IDecisionBtnClickALInput
    {
        /// <summary>
        /// UpdateData
        /// </summary>
        public UpdateData UpdateData { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("注文番号[{0}]", UpdateData.YoshiHanbaiChumonNo);
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
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALOutput
    {
        /// <summary>
        /// Update error message
        /// </summary>
        string ErrMsg { get; set; }
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
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALOutput : IDecisionBtnClickALOutput
    {
        /// <summary>
        /// Update error message
        /// </summary>
        public string ErrMsg { get; set; }
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
    /// 2014/07/22　AnhNV　　    新規作成
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
        private const string FunctionName = "TyumonShosai：DecisionBtnClick";

        /// <summary>
        /// ログインユーザー名
        /// </summary>
        private string LoginUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

        /// <summary>
        /// クライアント端末名
        /// </summary>
        private string HostName = Dns.GetHostName();

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
        /// 2014/07/22　AnhNV　　    新規作成
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
        /// 2014/07/22　AnhNV　　    新規作成
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
        /// 2014/07/22　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDecisionBtnClickALOutput Execute(IDecisionBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDecisionBtnClickALOutput output = new DecisionBtnClickALOutput();

            try
            {
                // トランザクション開始
                StartTransaction();

                // 明細行番号
                int meisaiNo = MakeMeisaiNo(input);

                // Register mode
                if (input.UpdateData.DispMode == TyumonShosaiForm.DispMode.Add)
                {
                    DoInsert(input, output, meisaiNo);
                }
                else // Edit mode
                {
                    DoUpdate(input, output, meisaiNo);
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

        #region DoInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoInsert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="meisaiNo"></param>
        /// <returns>
        /// 
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoInsert(IDecisionBtnClickALInput input, IDecisionBtnClickALOutput output, int meisaiNo)
        {
            TyumonDataTable updateDT = new TyumonDataTable();
            // 販売合計数量
            int gokeiSuryo = MakeGokeiSuryoTotal(input);
            // 販売合計金額
            decimal yoshiHanbaiGokeiKingaku = 0;
            // Error messages for 在庫数チェック
            string zaikosu = string.Empty;

            IUpdateTyumonBLInput blInput = new UpdateTyumonBLInput();

            // Create 用紙販売ヘッダテーブル
            updateDT.YoshiHanbaiHdrTblDataTable = CreateYoshiHanbaiHdrInsert(input);

            // Loop the dgv
            int rowIdx = 0;
            foreach (DataGridViewRow dgvr in input.UpdateData.YoshiListDgv.Rows)
            {
                // Skip empty columns 販売数量(17) and 販売セット数量(18)
                if (dgvr.Cells["HanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["HanbaiCnt"].Value.ToString())
                    || dgvr.Cells["SetHanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    continue;
                }

                // Create 用紙販売明細テーブル
                CreateYoshiHanbaiDtlInsert(input, dgvr, updateDT.YoshiHanbaiDtlTblDataTable, meisaiNo);

                // Sum of 販売合計金額
                yoshiHanbaiGokeiKingaku += updateDT.YoshiHanbaiDtlTblDataTable[rowIdx].YoshiHanbaiKakaku;

                // Create 用紙在庫テーブル
                CreateYoshiZaikoTblInsert(input, dgvr, updateDT.YoshiZaikoTblDataTable, updateDT.YoshiHanbaiHdrTblDataTable[0], gokeiSuryo);

                // 在庫数チェック
                zaikosu += ZaikosuCheck(dgvr, updateDT.YoshiHanbaiHdrTblDataTable[0], updateDT.YoshiHanbaiDtlTblDataTable[rowIdx]);

                // Next row
                rowIdx++;
            }

            if (zaikosu != string.Empty)
            {
                output.ErrMsg = string.Format("行{0}: 販売数が在庫数を超えています。", zaikosu.Remove(zaikosu.Length - 2));
                return;
            }

            // Set 販売合計金額 for update
            updateDT.YoshiHanbaiHdrTblDataTable[0].YoshiHanbaiGokeiKingaku = yoshiHanbaiGokeiKingaku;

            // Execute insert
            blInput.TyumonDataTable = updateDT;
            new UpdateTyumonBusinessLogic().Execute(blInput);
        }
        #endregion

        #region DoUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="meisaiNo"></param>
        /// <param name="output"></param>
        /// <returns>
        /// 
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoUpdate(IDecisionBtnClickALInput input, IDecisionBtnClickALOutput output, int meisaiNo)
        {
            // 注文情報の登録済みチェック
            output.ErrMsg = ExistCheck(input);
            if (!string.IsNullOrEmpty(output.ErrMsg)) return;

            // 処理済チェック(更新)
            output.ErrMsg = ShoriSumiCheck(input);
            if (!string.IsNullOrEmpty(output.ErrMsg)) return;
            
            // Error messages for 在庫数チェック
            string zaikosu = string.Empty;
            // 販売合計数量
            int gokeiSuryo = MakeGokeiSuryoTotal(input);
            // 販売合計金額
            decimal yoshiHanbaiGokeiKingaku = 0;
            // 販売合計数量 - before edit
            int staticGokeiSuryo = 0;
            object sumObj;

            TyumonDataTable updateDT = new TyumonDataTable();
            IUpdateTyumonBLInput blInput = new UpdateTyumonBLInput();

            // 用紙販売ヘッダテーブル
            updateDT.YoshiHanbaiHdrTblDataTable = input.UpdateData.YoshiHanbaiHdrTblDataTable;

            // Get 用紙販売明細テーブル by YoshiHanbaiChumonNo
            IGetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput dtlInput = new GetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput();
            dtlInput.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;
            IGetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLOutput dtlOutput = new GetYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBusinessLogic().Execute(dtlInput);
            sumObj = dtlOutput.YoshiHanbaiDtlTblDataTable.Compute("Sum(YoshiHanbaiGokeiSuryo)", string.Empty);
            staticGokeiSuryo = Convert.ToInt32(sumObj);

            // Loop the dgv
            int rowIdx = 0;
            foreach (DataGridViewRow dgvr in input.UpdateData.YoshiListDgv.Rows)
            {
                // Skip empty columns 販売数量(17) and 販売セット数量(18)
                if (dgvr.Cells["HanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["HanbaiCnt"].Value.ToString())
                    || dgvr.Cells["SetHanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    continue;
                }

                // Re-create 用紙販売明細テーブル
                CreateYoshiHanbaiDtlInsert(input, dgvr, updateDT.YoshiHanbaiDtlTblDataTable, meisaiNo);

                // Sum of 販売合計金額
                yoshiHanbaiGokeiKingaku += updateDT.YoshiHanbaiDtlTblDataTable[rowIdx].YoshiHanbaiKakaku;

                // Create 用紙在庫テーブル
                updateDT.YoshiZaikoTblDataTable.Merge(CreateYoshiZaikoTblUpdate(input, dgvr, updateDT.YoshiHanbaiHdrTblDataTable[0], gokeiSuryo, staticGokeiSuryo));

                // 在庫数チェック
                zaikosu += ZaikosuCheck(dgvr, updateDT.YoshiHanbaiHdrTblDataTable[0], updateDT.YoshiHanbaiDtlTblDataTable[rowIdx]);

                // Next row
                rowIdx++;
            }

            if (zaikosu != string.Empty)
            {
                output.ErrMsg = string.Format("行{0}: 販売数が在庫数を超えています。", zaikosu.Remove(zaikosu.Length - 2));
                return;
            }

            // Delete 用紙販売明細テーブル
            DeleteYoshiHanbaiDtl(input);

            // Set 販売合計金額 for update
            updateDT.YoshiHanbaiHdrTblDataTable[0].YoshiHanbaiGokeiKingaku = yoshiHanbaiGokeiKingaku;

            // 変更
            blInput.TyumonDataTable = updateDT;
            RakkanCheck(input);
            new UpdateTyumonBusinessLogic().Execute(blInput);
        }
        #endregion

        #region CreateYoshiHanbaiHdrInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateYoshiHanbaiHdrInsert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// 
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable CreateYoshiHanbaiHdrInsert(IDecisionBtnClickALInput input)
        {
            YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable table = new YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable();
            YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow newRow = table.NewYoshiHanbaiHdrTblRow();

            // 注文番号
            newRow.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;

            // 支所コード
            newRow.YoshiHanbaiShishoCd = input.UpdateData.YoshiHanbaiShishoCd;

            // 販売日
            newRow.YoshiHanbaiDt = input.UpdateData.YoshiHanbaiDt.ToString("yyyyMMdd");

            // 販売先業者コード
            newRow.YoshiHanbaisakiGyoshaCd = input.UpdateData.YoshiHanbaisakiGyoshaCd;

            // 販売先担当者
            newRow.YoshiHanbaisakiTantosha = input.UpdateData.YoshiHanbaisakiTantosha;

            // 販売合計金額
            newRow.YoshiHanbaiGokeiKingaku = 0;

            // 登録日時
            newRow.InsertDt =

            // 更新日時
            newRow.UpdateDt = input.UpdateData.Now;

            // 登録者
            newRow.InsertUser =

            // 更新者
            newRow.UpdateUser = this.LoginUser;

            // 登録端末
            newRow.InsertTarm =

            // 更新端末
            newRow.UpdateTarm = this.HostName;

            // 行を挿入
            table.AddYoshiHanbaiHdrTblRow(newRow);

            // 行の状態を設定
            newRow.AcceptChanges();

            // 行の状態を設定（新規）
            newRow.SetAdded();

            return table;
        }
        #endregion

        #region CreateYoshiHanbaiDtlInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateYoshiHanbaiDtlInsert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="dgvr"></param>
        /// <param name="table"></param>
        /// <param name="meisaiNo"></param>
        /// <returns>
        /// 
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void CreateYoshiHanbaiDtlInsert
            (
                IDecisionBtnClickALInput input,
                DataGridViewRow dgvr,
                YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblDataTable table,
                int meisaiNo
            )
        {
            // Create a new row
            YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblRow newRow = table.NewYoshiHanbaiDtlTblRow();

            // 注文番号
            newRow.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;

            // 販売用紙コード
            newRow.YoshiHanbaiYoshiCd = dgvr.Cells["YoshiCdCol"].Value.ToString();

            // 明細行番号
            newRow.YoshiHanbaiMeisaiGyoNo = meisaiNo;

            // 販売数量(17)
            newRow.YoshiHanbaiSuryo = Convert.ToInt32(dgvr.Cells["HanbaiCnt"].Value == null || dgvr.Cells["HanbaiCnt"].Value.ToString() == string.Empty
                ? "0" : dgvr.Cells["HanbaiCnt"].Value.ToString());

            // 販売単価
            newRow.YoshiHanbaiUp = input.UpdateData.KaiinKbn == "0"
                ? Convert.ToDecimal(dgvr.Cells["HiKaiinTankaCol"].Value == null || dgvr.Cells["HiKaiinTankaCol"].Value.ToString() == string.Empty ? "0" : dgvr.Cells["HiKaiinTankaCol"].Value.ToString())
                : Convert.ToDecimal(dgvr.Cells["KaiinTankaCol"].Value == null || dgvr.Cells["KaiinTankaCol"].Value.ToString() == string.Empty ? "0" : dgvr.Cells["KaiinTankaCol"].Value.ToString());

            // 販売セット数量(18)
            newRow.YoshiHanbaiSetSuryo = Convert.ToInt32(dgvr.Cells["SetHanbaiCnt"].Value == null || dgvr.Cells["SetHanbaiCnt"].Value.ToString() == string.Empty 
                ? "0" : dgvr.Cells["SetHanbaiCnt"].Value.ToString());

            // 販売セット価格
            newRow.YoshiHanbaiSetKakaku = input.UpdateData.KaiinKbn == "0"
                ? Convert.ToDecimal(dgvr.Cells["HiKaiinSetKakakuCol"].Value == null || dgvr.Cells["HiKaiinSetKakakuCol"].Value.ToString() == string.Empty ? "0" : dgvr.Cells["HiKaiinSetKakakuCol"].Value.ToString())
                : Convert.ToDecimal(dgvr.Cells["KaiinSetKakakuCol"].Value == null || dgvr.Cells["KaiinSetKakakuCol"].Value.ToString() == string.Empty ? "0" : dgvr.Cells["KaiinSetKakakuCol"].Value.ToString());

            // 販売価格
            newRow.YoshiHanbaiKakaku = newRow.YoshiHanbaiSuryo * newRow.YoshiHanbaiUp
                + newRow.YoshiHanbaiSetSuryo * newRow.YoshiHanbaiSetKakaku;

            // 販売合計数量
            newRow.YoshiHanbaiGokeiSuryo = newRow.YoshiHanbaiSuryo +
                newRow.YoshiHanbaiSetSuryo * Convert.ToInt32(dgvr.Cells["SetBusuCol"].Value != null ? dgvr.Cells["SetBusuCol"].Value.ToString() : "0");

            // 登録日時
            newRow.InsertDt =

            // 更新日時
            newRow.UpdateDt = input.UpdateData.Now;

            // 登録者
            newRow.InsertUser =

            // 更新者
            newRow.UpdateUser = this.LoginUser;

            // 登録端末
            newRow.InsertTarm =

            // 更新端末
            newRow.UpdateTarm = this.HostName;

            // 行を挿入
            table.AddYoshiHanbaiDtlTblRow(newRow);

            // 行の状態を設定
            newRow.AcceptChanges();

            // 行の状態を設定（新規）
            newRow.SetAdded();
        }
        #endregion

        #region CreateYoshiZaikoTblInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateYoshiZaikoTblInsert
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="dgvr"></param>
        /// <param name="table"></param>
        /// <param name="gokeiSuryo">17 + 18 * 16</param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void CreateYoshiZaikoTblInsert
            (
                IDecisionBtnClickALInput input,
                DataGridViewRow dgvr,
                YoshiZaikoTblDataSet.YoshiZaikoTblDataTable table,
                YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow hdrRow,
                int gokeiSuryo
            )
        {
            IGetYoshiZaikoTblByKeyBLInput blInput = new GetYoshiZaikoTblByKeyBLInput();
            blInput.YoshiZaikoShishoCd = hdrRow.YoshiHanbaiShishoCd;
            blInput.YoshiZaikoYoshiCd = dgvr.Cells["YoshiCdCol"].Value != null ? dgvr.Cells["YoshiCdCol"].Value.ToString() : string.Empty;
            IGetYoshiZaikoTblByKeyBLOutput blOutput = new GetYoshiZaikoTblByKeyBusinessLogic().Execute(blInput);

            if (blOutput.YoshiZaikoTblDataTable.Count > 0)
            {
                // 在庫数量 = 在庫数量 - (17 + 18 * 16)
                blOutput.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo = blOutput.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo - gokeiSuryo;

                // 更新日
                blOutput.YoshiZaikoTblDataTable[0].UpdateDt = input.UpdateData.Now;

                // 更新者
                blOutput.YoshiZaikoTblDataTable[0].UpdateUser = this.LoginUser;

                // 更新端末
                blOutput.YoshiZaikoTblDataTable[0].UpdateTarm = this.HostName;

                table.Merge(blOutput.YoshiZaikoTblDataTable);
            }
        }
        #endregion

        #region CreateYoshiZaikoTblUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateYoshiZaikoTblUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="dgvr"></param>
        /// <param name="hdrRow"></param>
        /// <param name="gokeiSuryo"></param>
        /// <param name="staticGokeiSuryo"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private YoshiZaikoTblDataSet.YoshiZaikoTblDataTable CreateYoshiZaikoTblUpdate
            (
                IDecisionBtnClickALInput input,
                DataGridViewRow dgvr,
                YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow hdrRow,
                int gokeiSuryo,
                int staticGokeiSuryo
            )
        {
            IGetYoshiZaikoTblByKeyBLInput blInput = new GetYoshiZaikoTblByKeyBLInput();
            blInput.YoshiZaikoShishoCd = hdrRow.YoshiHanbaiShishoCd;
            blInput.YoshiZaikoYoshiCd = dgvr.Cells["YoshiCdCol"].Value != null ? dgvr.Cells["YoshiCdCol"].Value.ToString() : string.Empty;
            IGetYoshiZaikoTblByKeyBLOutput blOutput = new GetYoshiZaikoTblByKeyBusinessLogic().Execute(blInput);

            if (blOutput.YoshiZaikoTblDataTable.Count > 0)
            {
                // 在庫数量 = 在庫数量 － 明細の販売数量合計(17 + 18 * 16) ＋ 変更前の明細の販売数量合計(before edit)
                blOutput.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo = blOutput.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo - gokeiSuryo + staticGokeiSuryo;

                // 更新日
                blOutput.YoshiZaikoTblDataTable[0].UpdateDt = input.UpdateData.Now;

                // 更新者
                blOutput.YoshiZaikoTblDataTable[0].UpdateUser = this.LoginUser;

                // 更新端末
                blOutput.YoshiZaikoTblDataTable[0].UpdateTarm = this.HostName;
            }

            return blOutput.YoshiZaikoTblDataTable;
        }
        #endregion

        #region DeleteYoshiHanbaiDtl
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DeleteYoshiHanbaiDtl
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DeleteYoshiHanbaiDtl(IDecisionBtnClickALInput input)
        {
            // Delete YoshiHanbaiDtl by YoshiHanbaiChumonNo
            IDeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput blInput = new DeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBLInput();
            blInput.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;
            new DeleteYoshiHanbaiDtlTblByYoshiHanbaiChumonNoBusinessLogic().Execute(blInput);
        }
        #endregion

        #region ExistCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ExistCheck
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string ExistCheck(IDecisionBtnClickALInput input)
        {
            // Message check
            string errMsg = string.Empty;

            // Get 用紙販売ヘッダテーブル by key
            IGetYoshiHanbaiHdrTblByKeyBLInput blInput = new GetYoshiHanbaiHdrTblByKeyBLInput();
            blInput.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;
            IGetYoshiHanbaiHdrTblByKeyBLOutput blOutput = new GetYoshiHanbaiHdrTblByKeyBusinessLogic().Execute(blInput);

            // No record was found
            if (blOutput.YoshiHanbaiHdrTblDataTable.Count == 0)
            {
                errMsg = string.Format("該当するデータは登録されていません。[注文番号：{0}]", input.UpdateData.YoshiHanbaiChumonNo);
            }

            return errMsg;
        }
        #endregion

        #region RakkanCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： RakkanCheck
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void RakkanCheck(IDecisionBtnClickALInput input)
        {
            // Get 用紙販売ヘッダテーブル by key
            IGetYoshiHanbaiHdrTblByKeyBLInput blInput = new GetYoshiHanbaiHdrTblByKeyBLInput();
            blInput.YoshiHanbaiChumonNo = input.UpdateData.YoshiHanbaiChumonNo;
            IGetYoshiHanbaiHdrTblByKeyBLOutput blOutput = new GetYoshiHanbaiHdrTblByKeyBusinessLogic().Execute(blInput);

            // 更新日が違うか？
            if (blOutput.YoshiHanbaiHdrTblDataTable[0].UpdateDt != input.UpdateData.YoshiHanbaiHdrTblDataTable[0].UpdateDt)
            {
                throw new CustomException((int)ResultCode.LockError, (int)OperationErr.RakkanLock, string.Empty);
            }

            // 更新日
            input.UpdateData.YoshiHanbaiHdrTblDataTable[0].UpdateDt = input.UpdateData.Now;

            // 更新者
            input.UpdateData.YoshiHanbaiHdrTblDataTable[0].UpdateUser = this.LoginUser;

            // 更新端末
            input.UpdateData.YoshiHanbaiHdrTblDataTable[0].UpdateTarm = this.HostName;
        }
        #endregion

        #region ZaikosuCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ZaikosuCheck
        /// <summary>
        /// 在庫数チェック
        /// </summary>
        /// <param name="dgvr"></param>
        /// <param name="hdrRow"></param>
        /// <param name="dtlRow"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string ZaikosuCheck
            (
                DataGridViewRow dgvr,
                YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow hdrRow,
                YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblRow dtlRow
            )
        {
            string rowErr = string.Empty;

            // バラ販売数(17)
            int hanbaiCnt = 0;
            // セット販売数(18)
            int setHanbaiCnt = 0;
            // セット部数(16)
            int setBusu = 0;

            // バラ販売数(17)
            hanbaiCnt = Convert.ToInt32(dgvr.Cells["HanbaiCnt"].Value.ToString());
            // セット販売数(18)
            setHanbaiCnt = Convert.ToInt32(dgvr.Cells["SetHanbaiCnt"].Value.ToString());
            // セット部数(16)
            setBusu = Convert.ToInt32(dgvr.Cells["SetBusuCol"].Value.ToString());
            
            // Get YoshiZaikoTbl by key
            IGetYoshiZaikoTblByKeyBLInput blInput = new GetYoshiZaikoTblByKeyBLInput();
            blInput.YoshiZaikoShishoCd = hdrRow.YoshiHanbaiShishoCd;
            blInput.YoshiZaikoYoshiCd = dtlRow.YoshiHanbaiYoshiCd;
            IGetYoshiZaikoTblByKeyBLOutput blOutput = new GetYoshiZaikoTblByKeyBusinessLogic().Execute(blInput);
            
            // (17) + (18) x (16) > 用紙在庫テーブルの在庫数量
            if (blOutput.YoshiZaikoTblDataTable.Count > 0 
                && hanbaiCnt + setHanbaiCnt * setBusu > blOutput.YoshiZaikoTblDataTable[0].YoshiZaikoSuryo)
            {
                rowErr = dgvr.Index + 1 + ", ";
            }

            return rowErr;
        }
        #endregion

        #region MakeMeisaiNo
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeMeisaiNo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private int MakeMeisaiNo(IDecisionBtnClickALInput input)
        {
            // 明細行番号
            int meisaiNo = 0;

            foreach (DataGridViewRow dgvr in input.UpdateData.YoshiListDgv.Rows)
            {
                // Skip empty columns 販売数量(17) and 販売セット数量(18)
                if (dgvr.Cells["HanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["HanbaiCnt"].Value.ToString())
                    || dgvr.Cells["SetHanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    continue;
                }

                meisaiNo++;
            }

            return meisaiNo;
        }
        #endregion

        #region ShoriSumiCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ShoriSumiCheck
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string ShoriSumiCheck(IDecisionBtnClickALInput input)
        {
            string errMsg = string.Empty;

            YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblRow row = input.UpdateData.YoshiHanbaiHdrTblDataTable[0];

            // 処理済チェック(更新)
            if (row.IsYoshiHanbaiGenkinNyukingakuNull() || row.YoshiHanbaiGenkinNyukingaku != 0
                || row.IsYoshiHanbaiSeikyuKingakuNull() || row.YoshiHanbaiSeikyuKingaku != 0
                || row.IsYoshiHanbaiKansaiFlgNull() || row.YoshiHanbaiKansaiFlg != "0"
                || row.IsYoshiHanbaiSeikyushoHakkoFlgNull() || row.YoshiHanbaiSeikyushoHakkoFlg != "0"
                || row.IsYoshiHanbaiNohinshoHakkoFlgNull() || row.YoshiHanbaiNohinshoHakkoFlg != "0"
                || row.IsYoshiHanbaiHassoFlgNull() || row.YoshiHanbaiHassoFlg != "0")
            {
                errMsg = "既に処理済のため、更新/削除できません。";
            }

            return errMsg;
        }
        #endregion

        #region MakeGokeiSuryoTotal
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeGokeiSuryoTotal
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/30  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private int MakeGokeiSuryoTotal(IDecisionBtnClickALInput input)
        {
            // 販売合計数量
            int gokeiSuryo = 0;

            foreach (DataGridViewRow dgvr in input.UpdateData.YoshiListDgv.Rows)
            {
                // Skip empty columns 販売数量(17) and 販売セット数量(18)
                if (dgvr.Cells["HanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["HanbaiCnt"].Value.ToString())
                    || dgvr.Cells["SetHanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    continue;
                }

                // 販売合計数量 = 17 + 18 * 16
                gokeiSuryo += Convert.ToInt32(dgvr.Cells["HanbaiCnt"].Value != null ? dgvr.Cells["HanbaiCnt"].Value.ToString() : "0")
                                + Convert.ToInt32(dgvr.Cells["SetHanbaiCnt"].Value != null ? dgvr.Cells["SetHanbaiCnt"].Value.ToString() : "0")
                                * Convert.ToInt32(dgvr.Cells["SetBusuCol"].Value != null ? dgvr.Cells["SetBusuCol"].Value.ToString() : "0");
            }

            return gokeiSuryo;
        }
        #endregion

        #endregion
    }
    #endregion
}
