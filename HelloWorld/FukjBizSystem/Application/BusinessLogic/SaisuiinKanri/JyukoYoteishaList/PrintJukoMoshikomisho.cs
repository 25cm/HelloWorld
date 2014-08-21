using System;
using System.Runtime.InteropServices;
using FukjBizSystem.Application.DataSet;
using Microsoft.Office.Interop.Excel;
using Zynas.Framework.Core.Base.BusinessLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.BusinessLogic.SaisuiinKanri.JyukoYoteishaList
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintJukoMoshikomishoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintJukoMoshikomishoBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// CurrentDate
        /// </summary>
        DateTime CurrentDate { get; set; }

        /// <summary>
        /// JyukoYoteishaListDataTable
        /// </summary>
        SaisuiinMstDataSet.JyukoYoteishaListDataTable ExportDT { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintJukoMoshikomishoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintJukoMoshikomishoBLInput : IPrintJukoMoshikomishoBLInput
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
        /// CurrentDate
        /// </summary>
        public DateTime CurrentDate { get; set; }

        /// <summary>
        /// JyukoYoteishaListDataTable
        /// </summary>
        public SaisuiinMstDataSet.JyukoYoteishaListDataTable ExportDT { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintJukoMoshikomishoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintJukoMoshikomishoBLOutput : IBaseExcelPrintBLOutput
    {
        
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintJukoMoshikomishoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintJukoMoshikomishoBLOutput : IPrintJukoMoshikomishoBLOutput
    {
        /// <summary>
        /// 保存パス
        /// </summary>
        public string SavePath { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintJukoMoshikomishoBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintJukoMoshikomishoBusinessLogic : BaseExcelPrintBusinessLogic<IPrintJukoMoshikomishoBLInput, IPrintJukoMoshikomishoBLOutput>
    {
        #region 置換文字列

        /// <summary>
        /// Number of rows per page
        /// </summary>
        private const int ROW_IN_PAGE = 40;

        private const string SAISUIIN_ADR_TEXTBOX                   = "SaisuiinAdrTextBox";
        private const string SAISUIIN_KANA_TEXTBOX                  = "SaisuiinKanaTextBox";
        private const string SAISUIIN_NM_TEXTBOX                    = "SaisuiinNmTextBox";
        private const string SAISUIIN_SEINEGAPPI_YEAR_TEXTBOX       = "SaisuiinSeinegappiYTextBox";
        private const string SAISUIIN_SEINEGAPPI_MONTH_TEXTBOX      = "SaisuiinSeinegappiMTextBox";
        private const string SAISUIIN_SEINEGAPPI_DAY_TEXTBOX        = "SaisuiinSeinegappiDTextBox";
        private const string ZENKAIJUKO_DT_TEXTBOX                  = "ZenkaiJukoDtTextBox";
        private const string SAISUIIN_SHITEINO_TEXTBOX              = "SaisuiinShiteiNoTextBox";
        private const string KANRISHINO_TEXTBOX                     = "KanrishiNoTextBox";
        private const string KANRISHI_SYUTOKU_DT_YEAR_TEXTBOX       = "KanrishiSyutokuDtYTextBox";
        private const string KANRISHI_SYUTOKU_DT_MONTH_TEXTBOX      = "KanrishiSyutokuDtMTextBox";
        private const string KANRISHI_SYUTOKU_DT_DAY_TEXTBOX        = "KanrishiSyutokuDtDTextBox";
        private const string GYOSHA_NM_TEXTBOX                      = "GyoshaNmTextBox";
        private const string SYOZOKU_GYOSHACD_TEXTBOX               = "SyozokuGyosyaCdTextBox";
        private const string DAIHYOSHA_NM_TEXTBOX                   = "DaihyoshaNmTextBox";
        private const string GYOSHA_ADR_TEXTBOX                     = "GyoshaAdrTextBox";
        
        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintJukoMoshikomishoBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintJukoMoshikomishoBusinessLogic()
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
        /// 2014/08/07  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintJukoMoshikomishoBLOutput SetBook(IPrintJukoMoshikomishoBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            IPrintJukoMoshikomishoBLOutput output = new PrintJukoMoshikomishoBLOutput();

            Microsoft.Office.Interop.Excel.Application application = null;
            Worksheet outputSheet = null;
            Worksheet tempSheet = null;

            try
            {
                application = book.Application;

                // Prevents from display messages of Excel
                application.DisplayAlerts = false;

                // Template sheet
                outputSheet = (Worksheet)book.Sheets["Sheet1"];
                outputSheet.Name = "指定採水員証明書";
                
                int i = 1;

                foreach (SaisuiinMstDataSet.JyukoYoteishaListRow row in input.ExportDT)
                {
                    // Detail for each rows
                    SetDetail(outputSheet, row);

                    CopyRow(outputSheet, 0, ROW_IN_PAGE - 1, ROW_IN_PAGE * i);

                    SetPageBreak(outputSheet, ROW_IN_PAGE * i);
                    
                    i++;   
                }

                DeleteRow(outputSheet, 0, ROW_IN_PAGE);
            }
            catch
            {
                throw;
            }
            finally
            {
                #region オブジェクトを解放
                
                if (application != null) 
                { 
                    Marshal.ReleaseComObject(application); 
                }
                
                if (tempSheet != null) 
                { 
                    Marshal.ReleaseComObject(tempSheet); 
                }

                if (outputSheet != null) 
                { 
                    Marshal.ReleaseComObject(outputSheet); 
                }
                
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
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDetail(Worksheet sheet, SaisuiinMstDataSet.JyukoYoteishaListRow row)
        {
            string seinegappiY = string.Empty;
            string seinegappiM = string.Empty;
            string seinegappiD = string.Empty;
            string syutokuDtY = string.Empty;
            string syutokuDtM = string.Empty;
            string syutokuDtD = string.Empty;
            string zenkaiJukoDt = string.Empty;

            if (!string.IsNullOrEmpty(row.SaisuiinSeinegappi.Trim()))
            {
                // 20140811 habu Aggregated Hoshou Toroku No Convertion To Date Utility
                seinegappiY = DateUtility.ConvertToWareki(row.SaisuiinSeinegappi, "y");
                // TODO is H1/01/01 will do ? (not H1/1/1)
                seinegappiM = DateUtility.ConvertToWareki(row.SaisuiinSeinegappi, "MM");
                seinegappiD = DateUtility.ConvertToWareki(row.SaisuiinSeinegappi, "dd");
                //seinegappiY = Utility.Utility.ConvertToHeisei(Convert.ToInt32(row.SaisuiinSeinegappi.Substring(0, 4)));
                //seinegappiM = row.SaisuiinSeinegappi.Substring(4, 2);
                //seinegappiD = row.SaisuiinSeinegappi.Substring(6, 2);
                // 20140811 habu End
            }

            if (!string.IsNullOrEmpty(row.KanrishiSyutokuDt.Trim()))
            {
                // 20140811 habu Aggregated Hoshou Toroku No Convertion To Date Utility
                syutokuDtY = DateUtility.ConvertToWareki(row.KanrishiSyutokuDt, "y");
                // TODO is H1/01/01 will do ? (not H1/1/1)
                syutokuDtM = DateUtility.ConvertToWareki(row.KanrishiSyutokuDt, "MM");
                syutokuDtD = DateUtility.ConvertToWareki(row.KanrishiSyutokuDt, "dd");
                //syutokuDtY = Utility.Utility.ConvertToHeisei(Convert.ToInt32(row.KanrishiSyutokuDt.Substring(0, 4)));
                //syutokuDtM = row.KanrishiSyutokuDt.Substring(4, 2);
                //syutokuDtD = row.KanrishiSyutokuDt.Substring(6, 2);
                // 20140811 habu End
            }

            if (!string.IsNullOrEmpty(row.ZenkaiJukoDt.Trim()))
            {
                // 20140811 habu Aggregated Hoshou Toroku No Convertion To Date Utility
                // TODO is H.1.01.01 will do ? (not H.1.1.1)
                zenkaiJukoDt = DateUtility.ConvertToWareki(row.ZenkaiJukoDt, "H.y.MM.dd");
                //zenkaiJukoDt = "H" + "."
                //                + Utility.Utility.ConvertToHeisei(Convert.ToInt32(row.ZenkaiJukoDt.Substring(0, 4))) + "."
                //                + row.ZenkaiJukoDt.Substring(4, 2) + "."
                //                + row.KanrishiSyutokuDt.Substring(6, 2);
                // 20140811 habu End
            }

            // 採水員住所
            SetShapeText(sheet, SAISUIIN_ADR_TEXTBOX, string.IsNullOrEmpty(row.SaisuiinAdr.Trim()) ? string.Empty : row.SaisuiinAdr);

            // 採水員名かな
            SetShapeText(sheet, SAISUIIN_KANA_TEXTBOX, string.IsNullOrEmpty(row.SaisuiinKana.Trim()) ? string.Empty : row.SaisuiinKana);

            // 採水員名
            SetShapeText(sheet, SAISUIIN_NM_TEXTBOX, string.IsNullOrEmpty(row.SaisuiinNm.Trim()) ? string.Empty : row.SaisuiinNm);

            // 採水員生年月日 YEAR
            SetShapeText(sheet, SAISUIIN_SEINEGAPPI_YEAR_TEXTBOX, seinegappiY);

            // 採水員生年月日 MONTH
            SetShapeText(sheet, SAISUIIN_SEINEGAPPI_MONTH_TEXTBOX, seinegappiM);

            // 採水員生年月日 DAY
            SetShapeText(sheet, SAISUIIN_SEINEGAPPI_DAY_TEXTBOX, seinegappiD);

            // 前回受講日
            SetShapeText(sheet, ZENKAIJUKO_DT_TEXTBOX, zenkaiJukoDt);

            // 採水員指定No
            SetShapeText(sheet, SAISUIIN_SHITEINO_TEXTBOX, string.IsNullOrEmpty(row.SaisuiinShiteiNo.Trim()) ? string.Empty : row.SaisuiinShiteiNo);

            // 管理士No
            SetShapeText(sheet, KANRISHINO_TEXTBOX, string.IsNullOrEmpty(row.KanrishiNo.Trim()) ? string.Empty : row.KanrishiNo);

            // 管理士取得日 YEAR
            SetShapeText(sheet, KANRISHI_SYUTOKU_DT_YEAR_TEXTBOX, syutokuDtY);

            // 管理士取得日 MONTH
            SetShapeText(sheet, KANRISHI_SYUTOKU_DT_MONTH_TEXTBOX, syutokuDtM);

            // 管理士取得日 DAY
            SetShapeText(sheet, KANRISHI_SYUTOKU_DT_DAY_TEXTBOX, syutokuDtD);

            // 業者名称
            SetShapeText(sheet, GYOSHA_NM_TEXTBOX, string.IsNullOrEmpty(row.GyoshaNm.Trim()) ? string.Empty : row.GyoshaNm);

            // 所属業者コード
            SetShapeText(sheet, SYOZOKU_GYOSHACD_TEXTBOX, row.SyozokuGyosyaCd);

            // 代表者氏名
            SetShapeText(sheet, DAIHYOSHA_NM_TEXTBOX, string.IsNullOrEmpty(row.DaihyoshaNm.Trim()) ? string.Empty : row.DaihyoshaNm);

            // 業者住所
            SetShapeText(sheet, GYOSHA_ADR_TEXTBOX, string.IsNullOrEmpty(row.GyoshaAdr.Trim()) ? string.Empty : row.GyoshaAdr);

        }
        #endregion



        #endregion

    }
    #endregion
}
