using System;
using System.Runtime.InteropServices;
using FukjBizSystem.Application.DataAccess.HoteiKanriMst;
using FukjBizSystem.Application.DataSet;
using Microsoft.Office.Interop.Excel;
using Zynas.Framework.Core.Base.BusinessLogic;

namespace FukjBizSystem.Application.BusinessLogic.Others.KensaKeihatsuSuishinhiList
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintKensaKeihatsuKyodoKumiaiBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintKensaKeihatsuKyodoKumiaiBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// 支払票印刷第○号(44)
        /// </summary>
        string PrintNo { get; set; }

        /// <summary>
        /// 職員名
        /// </summary>
        string LoginNm { get; set; }

        /// <summary>
        /// Current datetime in DB
        /// </summary>
        DateTime SystemDt { get; set; }

        /// <summary>
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable KensaKeihatsuSuishinListDataTable { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintKensaKeihatsuKyodoKumiaiBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintKensaKeihatsuKyodoKumiaiBLInput : IPrintKensaKeihatsuKyodoKumiaiBLInput
    {
        /// <summary>
        /// 保存ファイルモード
        /// </summary>
        public int SaveFileMode { get; set; }

        /// <summary>
        /// ＥＸＣＥＬ書式へのパス
        /// </summary>
        public string FormatPath { get; set; }

        /// <summary>
        /// 帳票ディレクトリパス
        /// </summary>
        public string PrintDirectory { get; set; }

        /// <summary>
        /// 指定保存パス
        /// 未指定の場合は、帳票出力ディレクトリに出力されます
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// 処理後ＥＸＣＥＬ表示フラグ
        /// </summary>
        public bool AfterDispFlg { get; set; }

        /// <summary>
        /// 処理後印刷フラグ
        /// </summary>
        public bool AfterPrintFlg { get; set; }

        /// <summary>
        /// 印刷プリンタ名
        /// </summary>
        public string PrinterName { get; set; }

        /// <summary>
        /// 支払票印刷第○号(44)
        /// </summary>
        public string PrintNo { get; set; }

        /// <summary>
        /// 職員名
        /// </summary>
        public string LoginNm { get; set; }

        /// <summary>
        /// Current datetime in DB
        /// </summary>
        public DateTime SystemDt { get; set; }

        /// <summary>
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        public KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable KensaKeihatsuSuishinListDataTable { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintKensaKeihatsuKyodoKumiaiBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintKensaKeihatsuKyodoKumiaiBLOutput : IBaseExcelPrintBLOutput
    {
        
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintKensaKeihatsuKyodoKumiaiBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintKensaKeihatsuKyodoKumiaiBLOutput : IPrintKensaKeihatsuKyodoKumiaiBLOutput
    {
        /// <summary>
        /// 保存パス
        /// </summary>
        public string SavePath { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintKensaKeihatsuKyodoKumiaiBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintKensaKeihatsuKyodoKumiaiBusinessLogic : BaseExcelPrintBusinessLogic<IPrintKensaKeihatsuKyodoKumiaiBLInput, IPrintKensaKeihatsuKyodoKumiaiBLOutput>
    {
        #region 置換文字列

        /// <summary>
        /// Number of header rows
        /// </summary>
        private const int HEADER_ROW_NUM = 54;

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintKensaKeihatsuKyodoKumiaiBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintKensaKeihatsuKyodoKumiaiBusinessLogic()
        {
            
        }
        #endregion

        #region メソッド(protected)

        #region SetBook
        ////////////////////////////////////////////////////////////////////////////
        //  クラス名 ： SetBook
        /// <summary>
        /// ＥＸＣＥＬのブックオブジェクトにデータを設定する
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="input">入力</param>
        /// <param name="book">ＥＸＣＥＬのブックオブジェクト</param>
        /// <returns>戻り値</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintKensaKeihatsuKyodoKumiaiBLOutput SetBook(IPrintKensaKeihatsuKyodoKumiaiBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            IPrintKensaKeihatsuKyodoKumiaiBLOutput output = new PrintKensaKeihatsuKyodoKumiaiBLOutput();

            Microsoft.Office.Interop.Excel.Application application = null;
            Worksheet outputSheet = null;
            Worksheet tempSheet = null;

            try
            {
                application = book.Application;

                // Prevents from display messages of Excel
                application.DisplayAlerts = false;

                // Template sheet
                tempSheet = (Worksheet)book.Sheets["Sheet1"];
                tempSheet.Copy(tempSheet, Type.Missing);

                // Set output sheet to current active sheet
                outputSheet = (Worksheet)book.ActiveSheet;
                outputSheet.Name = "検査啓発推進費支払票(協同組合)";

                // Current row in process
                int curRow = 0;
                string tempKyodoKumiaiCd = string.Empty;

                // Get 事務局電話番号
                string jimukyokuTelNo = GetJimukyokuTelNo();

                foreach (KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListRow row in input.KensaKeihatsuSuishinListDataTable)
                {
                    // Current KyodoKumiaiCd is set
                    if (curRow > 0 && row.KyodoKumiaiCd == tempKyodoKumiaiCd) continue;

                    // New 2 page?
                    if (row.KyodoKumiaiCd != tempKyodoKumiaiCd)
                    {
                        // Set header (page 1)
                        SetHeaderPage(outputSheet, row, input, jimukyokuTelNo, curRow);
                    }

                    int curDetailRow = 1;
                    foreach (KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListRow detailRow in
                        input.KensaKeihatsuSuishinListDataTable.Select(string.Format("KyodoKumiaiCd = '{0}'", row.KyodoKumiaiCd)))
                    {
                        // Set detail (page 2)
                        SetDetailPage(outputSheet, detailRow, HEADER_ROW_NUM + curDetailRow);

                        // Next row (page 2)
                        curDetailRow++;
                    }

                    // Buffer to check new 2 pages
                    tempKyodoKumiaiCd = row.KyodoKumiaiCd;

                    // Next 2 page
                    curRow += HEADER_ROW_NUM + curDetailRow;
                }

                // 2シート以上あるか？
                if (book.Sheets.Count > 1)
                {
                    // テンプレートシートを削除
                    tempSheet.Delete();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                #region オブジェクトを解放
                if (application != null) { Marshal.ReleaseComObject(application); }
                if (tempSheet != null) { Marshal.ReleaseComObject(tempSheet); }
                if (outputSheet != null) { Marshal.ReleaseComObject(outputSheet); }
                #endregion
            }

            return output;
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region GetJimukyokuTelNo
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GetJimukyokuTelNo
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string GetJimukyokuTelNo()
        {
            string jimukyokuTelNo = string.Empty;

            // Get 事務局電話番号
            ISelectHoteiKanriMstByKeyDAInput hoteiInp = new SelectHoteiKanriMstByKeyDAInput();
            hoteiInp.JimukyokuKbn = "0";
            ISelectHoteiKanriMstByKeyDAOutput hoteiOutp = new SelectHoteiKanriMstByKeyDataAccess().Execute(hoteiInp);

            if (hoteiOutp.HoteiKanriMstDataTable.Count > 0)
            {
                jimukyokuTelNo = hoteiOutp.HoteiKanriMstDataTable[0].JimukyokuTelNo;
            }

            return jimukyokuTelNo;
        }
        #endregion

        #region SetHeaderPage
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetHeaderPage
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sheet"></param>
        /// <param name="row"></param>
        /// <param name="input"></param>
        /// <param name="curRow"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetHeaderPage
            (
                Worksheet sheet,
                KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListRow row,
                IPrintKensaKeihatsuKyodoKumiaiBLInput input,
                string jimukyokuTelNo,
                int curRow
            )
        {
            // 支払票印刷第○号(1)
            CellOutput(sheet, curRow, 28, input.PrintNo);

            // システム日付(2)
            CellOutput(sheet, curRow + 1, 23, string.Format("'平成{0}年{1}月{2}日",
                Boundary.Common.Common.ConvertToHoshouNendoWareki(input.SystemDt.ToString("yyyy")),
                input.SystemDt.ToString("MM"),
                input.SystemDt.ToString("dd")));

            // 組合名称(3)
            CellOutput(sheet, curRow + 2, 1, row.KumiaiNm);

            // 年度(4)
            CellOutput(sheet, curRow + 9, 0, string.Format("平成{0}年度{1}検査啓発推進費等の支払について",
                Boundary.Common.Common.ConvertToHoshouNendoWareki(row.SuishinhiNendo),
                row.KamiShimoKbn == "1" ? "上半期" : "下半期"));

            // Total of 9条持込金額(5)
            // Auto fill by excel formula

            // 支払計上日(6)
            DateTime shiharaiDt = Convert.ToDateTime(row.ShiharaiDt);
            CellOutput(sheet, curRow + 25, 9, string.Format("'平成{0}年{1}月{2}日",
                Boundary.Common.Common.ConvertToHoshouNendoWareki(shiharaiDt.ToString("yyyy")),
                shiharaiDt.ToString("MM"),
                shiharaiDt.ToString("dd")));

            // 職員名(7)
            CellOutput(sheet, curRow + 40, 23, input.LoginNm);

            // 事務局電話番号(8)
            CellOutput(sheet, curRow + 41, 20, jimukyokuTelNo);

            // 年度(9)
            CellOutput(sheet, curRow + 47, 0, string.Format("平成{0}年度{1}検査啓発推進費",
                Boundary.Common.Common.ConvertToHoshouNendoWareki(row.SuishinhiNendo),
                row.KamiShimoKbn == "1" ? " (４月～９月）" : "（１０月～３月分）"));

            // 組合名称(10)
            CellOutput(sheet, curRow + 49, 1, row.KumiaiNm);

            // 計量証明持込単価 (11)
            CellOutput(sheet, curRow + 53, 16, row.KeiryoShomeiMochiUp);

            // 11条水質持込単価 (12)
            CellOutput(sheet, curRow + 53, 21, row.Kensa11SuishitsuMochiUp);

            // 11条外観単価(13)
            CellOutput(sheet, curRow + 53, 26, row.Kensa11GaikanUp);
        }
        #endregion

        #region SetDetail
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetDetail
        /// <summary>
        /// 預券明細情報をセット
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sheet"></param>
        /// <param name="detailRow"></param>
        /// <param name="detailIdxRow"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDetailPage(Worksheet sheet, KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListRow detailRow, int detailIdxRow)
        {
            // 業者名称(14)
            CellOutput(sheet, detailIdxRow, 1, detailRow.GyoshaNm);

            // 支払合計(15)
            CellOutput(sheet, detailIdxRow, 11, detailRow.ShiharaiTotal);

            // 計量証明持込件数(16)
            CellOutput(sheet, detailIdxRow, 16, detailRow.KeiryoShomeiMochiCnt);

            // 11条水質持込件数(17)
            CellOutput(sheet, detailIdxRow, 21, detailRow.Kensa11SuishitsuMochiCnt);

            // 11条外観件数(18)
            CellOutput(sheet, detailIdxRow, 26, detailRow.Kensa11GaikanCnt);
        }
        #endregion

        #endregion
    }
    #endregion
}
