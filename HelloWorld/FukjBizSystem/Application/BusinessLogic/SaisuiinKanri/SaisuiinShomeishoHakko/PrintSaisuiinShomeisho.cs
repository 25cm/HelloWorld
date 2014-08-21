using System;
using System.Runtime.InteropServices;
using FukjBizSystem.Application.DataAccess.HoteiKanriMst;
using FukjBizSystem.Application.DataSet;
using Microsoft.Office.Interop.Excel;
using Zynas.Framework.Core.Base.BusinessLogic;

namespace FukjBizSystem.Application.BusinessLogic.SaisuiinKanri.SaisuiinShomeishoHakko
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintSaisuiinShomeishoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/05　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintSaisuiinShomeishoBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// SaisuiinShomeishoHakkoKensakuDataTable
        /// </summary>
        SaisuiinMstDataSet.SaisuiinShomeishoHakkoKensakuDataTable SaisuiinShomeishoHakkoKensakuDataTable { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintSaisuiinShomeishoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/05　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSaisuiinShomeishoBLInput : IPrintSaisuiinShomeishoBLInput
    {
        /// <summary>
        /// 保存ファイルモード
        /// </summary>
        public int SaveFileMode
        {
            get;
            set;
        }

        /// <summary>
        /// ＥＸＣＥＬ書式へのパス
        /// </summary>
        public string FormatPath
        {
            get;
            set;
        }

        /// <summary>
        /// 帳票ディレクトリパス
        /// </summary>
        public string PrintDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// 指定保存パス
        /// 未指定の場合は、帳票出力ディレクトリに出力されます
        /// </summary>
        public string SavePath
        {
            get;
            set;
        }

        /// <summary>
        /// 処理後ＥＸＣＥＬ表示フラグ
        /// </summary>
        public bool AfterDispFlg
        {
            get;
            set;
        }

        /// <summary>
        /// 処理後印刷フラグ
        /// </summary>
        public bool AfterPrintFlg { get; set; }

        /// <summary>
        /// 印刷プリンタ名
        /// </summary>
        public string PrinterName { get; set; }

        /// <summary>
        /// SaisuiinShomeishoHakkoKensakuDataTable
        /// </summary>
        public SaisuiinMstDataSet.SaisuiinShomeishoHakkoKensakuDataTable SaisuiinShomeishoHakkoKensakuDataTable { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintSaisuiinShomeishoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/05　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintSaisuiinShomeishoBLOutput : IBaseExcelPrintBLOutput
    {
        
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintSaisuiinShomeishoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/05　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSaisuiinShomeishoBLOutput : IPrintSaisuiinShomeishoBLOutput
    {
        /// <summary>
        /// 保存パス
        /// </summary>
        public string SavePath
        {
            get;
            set;
        }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintSaisuiinShomeishoBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/05　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSaisuiinShomeishoBusinessLogic : BaseExcelPrintBusinessLogic<IPrintSaisuiinShomeishoBLInput, IPrintSaisuiinShomeishoBLOutput>
    {
        #region 置換文字列

        /// <summary>
        /// Number of rows per page
        /// </summary>
        private const int ROW_IN_PAGE = 52;

        #region ヘッダー
        
        #endregion

        #region 明細
        //private const string REPLACE_CELL_SHITEINO = "#SHITEINO";
        #endregion

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintSaisuiinShomeishoBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/05　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintSaisuiinShomeishoBusinessLogic()
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
        /// 2014/08/05　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintSaisuiinShomeishoBLOutput SetBook(IPrintSaisuiinShomeishoBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            IPrintSaisuiinShomeishoBLOutput output = new PrintSaisuiinShomeishoBLOutput();

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
                outputSheet.Name = "指定採水員証明書";

                // Index of detail row
                int curRow = 1;

                // Get 法定管理マスタ by key
                ISelectHoteiKanriMstByKeyDAInput daInput = new SelectHoteiKanriMstByKeyDAInput();
                daInput.JimukyokuKbn = "0";
                ISelectHoteiKanriMstByKeyDAOutput daOutput = new SelectHoteiKanriMstByKeyDataAccess().Execute(daInput);
                string daihyoshaNm = daOutput.HoteiKanriMstDataTable.Count > 0 ? daOutput.HoteiKanriMstDataTable[0].JimukyokuDaihyoshaNm : string.Empty;

                foreach (SaisuiinMstDataSet.SaisuiinShomeishoHakkoKensakuRow row in input.SaisuiinShomeishoHakkoKensakuDataTable)
                {
                    // Page break
                    if (curRow > 1)
                    {
                        // Break page
                        outputSheet.HPageBreaks.Add((Range)outputSheet.Cells[curRow + ROW_IN_PAGE / 2 - 1, 1]);
                        outputSheet.HPageBreaks.Add((Range)outputSheet.Cells[curRow - 1, 1]);

                        // New page
                        RowCopy(tempSheet, outputSheet, 1, ROW_IN_PAGE, curRow, XlPasteType.xlPasteAll);

                        // Row height
                        outputSheet.Range[string.Format("A{0}", curRow + 6), string.Format("A{0}", curRow + 6)].RowHeight = 6.75;
                        outputSheet.Range[string.Format("A{0}", curRow + 14), string.Format("A{0}", curRow + 14)].RowHeight = 9.75;
                        outputSheet.Range[string.Format("A{0}", curRow + 16), string.Format("A{0}", curRow + 16)].RowHeight = 7.50;
                        outputSheet.Range[string.Format("A{0}", curRow + 43), string.Format("A{0}", curRow + 43)].RowHeight = 5.25;
                        outputSheet.Range[string.Format("A{0}", curRow + 48), string.Format("A{0}", curRow + 48)].RowHeight = 5.25;
                        outputSheet.Range[string.Format("A{0}", curRow + 50), string.Format("A{0}", curRow + 50)].RowHeight = 5.25;

                    }

                    // Detail for each rows
                    SetDetail(outputSheet, row, curRow, daihyoshaNm);

                    // Row in next page
                    curRow += ROW_IN_PAGE + 2;
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
        /// <param name="row"></param>
        /// <param name="curRow"></param>
        /// <param name="daihyoshaNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/05　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDetail(Worksheet sheet, SaisuiinMstDataSet.SaisuiinShomeishoHakkoKensakuRow row, int curRow, string daihyoshaNm)
        {
            // 採水員指定No(1)
            CellOutput(sheet, curRow + 1, 4, row.SaisuiinShiteiNo);

            // 採水員名(2)
            CellOutput(sheet, curRow + 3, 4, row.SaisuiinNm);

            // 採水員生年月日(3)
            CellOutput(sheet, curRow + 6, 6, string.IsNullOrEmpty(row.SaisuiinSeinegappi) ? string.Empty : Convert.ToDateTime(row.SaisuiinSeinegappi).ToString("yyyy"));
            CellOutput(sheet, curRow + 6, 9, string.IsNullOrEmpty(row.SaisuiinSeinegappi) ? string.Empty : Convert.ToDateTime(row.SaisuiinSeinegappi).ToString("MM"));
            CellOutput(sheet, curRow + 6, 11, string.IsNullOrEmpty(row.SaisuiinSeinegappi) ? string.Empty : Convert.ToDateTime(row.SaisuiinSeinegappi).ToString("dd"));

            // 受講日(4)
            CellOutput(sheet, curRow + 14, 4, string.IsNullOrEmpty(row.JukoDt) ? string.Empty : Convert.ToDateTime(row.JukoDt).ToString("yyyy"));
            CellOutput(sheet, curRow + 14, 7, string.IsNullOrEmpty(row.JukoDt) ? string.Empty : Convert.ToDateTime(row.JukoDt).ToString("MM"));
            CellOutput(sheet, curRow + 14, 9, string.IsNullOrEmpty(row.JukoDt) ? string.Empty : Convert.ToDateTime(row.JukoDt).ToString("dd"));

            // 採水員有効期限(5)
            CellOutput(sheet, curRow + 16, 4, string.IsNullOrEmpty(row.SaisuiinYukokigenDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinYukokigenDt).ToString("yyyy"));
            CellOutput(sheet, curRow + 16, 7, string.IsNullOrEmpty(row.SaisuiinYukokigenDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinYukokigenDt).ToString("MM"));
            CellOutput(sheet, curRow + 16, 9, string.IsNullOrEmpty(row.SaisuiinYukokigenDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinYukokigenDt).ToString("dd"));

            // 採水員取得日(6)
            CellOutput(sheet, curRow + 18, 3, string.IsNullOrEmpty(row.SaisuiinSyutokuDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinSyutokuDt).ToString("yyyy"));
            CellOutput(sheet, curRow + 18, 6, string.IsNullOrEmpty(row.SaisuiinSyutokuDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinSyutokuDt).ToString("MM"));
            CellOutput(sheet, curRow + 18, 8, string.IsNullOrEmpty(row.SaisuiinSyutokuDt) ? string.Empty : Convert.ToDateTime(row.SaisuiinSyutokuDt).ToString("dd"));

            // 事務局代表者名(7)
            CellOutput(sheet, curRow + 22, 4, daihyoshaNm);
        }
        #endregion

        #endregion
    }
    #endregion
}
