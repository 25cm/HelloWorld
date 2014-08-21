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
    //  インターフェイス名 ： IPrintShushuToriatsukaiGyoshaBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintShushuToriatsukaiGyoshaBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable KensaKeihatsuSuishinListDataTable { get; set; }

        /// <summary>
        /// PrintNo
        /// </summary>
        string PrintNo { get; set; }

        /// <summary>
        /// SystemDt
        /// </summary>
        DateTime SystemDt { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintShushuToriatsukaiGyoshaBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintShushuToriatsukaiGyoshaBLInput : IPrintShushuToriatsukaiGyoshaBLInput
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
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        public KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable KensaKeihatsuSuishinListDataTable { get; set; }

        /// <summary>
        /// PrintNo
        /// </summary>
        public string PrintNo { get; set; }

        /// <summary>
        /// SystemDt
        /// </summary>
        public DateTime SystemDt { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintShushuToriatsukaiGyoshaBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintShushuToriatsukaiGyoshaBLOutput : IBaseExcelPrintBLOutput
    {
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintShushuToriatsukaiGyoshaBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintShushuToriatsukaiGyoshaBLOutput : IPrintShushuToriatsukaiGyoshaBLOutput
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
    //  クラス名 ： PrintShushuToriatsukaiGyoshaBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintShushuToriatsukaiGyoshaBusinessLogic : BaseExcelPrintBusinessLogic<IPrintShushuToriatsukaiGyoshaBLInput, IPrintShushuToriatsukaiGyoshaBLOutput>
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintShushuToriatsukaiGyoshaBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintShushuToriatsukaiGyoshaBusinessLogic()
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
        /// 2014/08/21　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintShushuToriatsukaiGyoshaBLOutput SetBook(IPrintShushuToriatsukaiGyoshaBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            IPrintShushuToriatsukaiGyoshaBLOutput output = new PrintShushuToriatsukaiGyoshaBLOutput();

            Worksheet outputSheet = null;

            try
            {
                outputSheet = (Worksheet)book.Sheets["Sheet1"];

                string loginUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

                ISelectHoteiKanriMstByKeyDAInput daInput = new SelectHoteiKanriMstByKeyDAInput();
                daInput.JimukyokuKbn = "0";
                ISelectHoteiKanriMstByKeyDAOutput daOutput = new SelectHoteiKanriMstByKeyDataAccess().Execute(daInput);

                int pageIdx = 1;
                int rowCount = 42;

                foreach (KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListRow printRow in input.KensaKeihatsuSuishinListDataTable)
                {
                    //check condition print
                    if (printRow.ToriatsukaiGyoshaKbn == "2" && string.IsNullOrEmpty(printRow.ToriatsukaiGyoshaCd)) continue;

                    //画面の支払票印刷号番号(1)
                    CellOutput(outputSheet, 0, 28, input.PrintNo);

                    //システム日付 (2)
                    CellOutput(outputSheet, 1, 23, "'平成 " + Boundary.Common.Common.ConvertToHoshouNendoWareki(input.SystemDt.ToString("yyyy")
                                    + "年 " + input.SystemDt.Month + "月 " + input.SystemDt.ToString("dd") + "日"));

                    //業者名称 (3)
                    CellOutput(outputSheet, 2, 1, printRow.GyoshaNm);

                    //事務局代表者名 (4)
                    CellOutput(outputSheet, 5, 23, daOutput.HoteiKanriMstDataTable[0].JimukyokuDaihyoshaNm);

                    //年度 (5)
                    string kamiShimo = string.Empty;
                    if (printRow.KamiShimoKbn == "1")
                    {
                        kamiShimo = "上半期";
                    }
                    if (printRow.KamiShimoKbn == "2")
                    {
                        kamiShimo = "下半期";
                    }

                    CellOutput(outputSheet, 9, 0, "平成"
                                                + Boundary.Common.Common.ConvertToHoshouNendoWareki(printRow.SuishinhiNendo)
                                                + "年度" + kamiShimo + "検査啓発推進費等の支払について");

                    //11条水質持込単価 (6)
                    //CellOutput(outputSheet, 23, 10, printRow.Kensa11SuishitsuMochiUp);

                    //11条水質収集単価 (7)
                    CellOutput(outputSheet, 24, 10, printRow.Kensa11SuishitsuShushuUp);

                    //11条水質取扱単価 (8)
                    CellOutput(outputSheet, 25, 10, printRow.Kensa11SuishitsuToriUp);

                    //11条外観単価 (9)
                    CellOutput(outputSheet, 26, 10, printRow.Kensa11GaikanUp);

                    //計量証明持込単価 (10)
                    CellOutput(outputSheet, 27, 10, printRow.KeiryoShomeiMochiUp);

                    //計量証明収集単価 (11)
                    CellOutput(outputSheet, 28, 10, printRow.KeiryoShomeiShushuUp);

                    //計量証明取扱単価 (12) 
                    CellOutput(outputSheet, 29, 10, printRow.KeiryoShomeiToriUp);

                    //11条水質持込件数 (13)
                    CellOutput(outputSheet, 23, 17, printRow.Kensa11SuishitsuMochiCnt);

                    //11条水質収集件数 (14)
                    CellOutput(outputSheet, 24, 17, printRow.Kensa11SuishitsuShushuCnt);

                    //11条水質取扱件数 (15)
                    CellOutput(outputSheet, 25, 17, printRow.Kensa11SuishitsuToriCnt);

                    //11条外観件数 (16)
                    CellOutput(outputSheet, 26, 17, printRow.Kensa11GaikanCnt);

                    //計量証明持込件数 (17)
                    CellOutput(outputSheet, 27, 17, printRow.KeiryoShomeiMochiCnt);

                    //計量証明収集件数 (18)
                    CellOutput(outputSheet, 28, 17, printRow.KeiryoShomeiShushuCnt);

                    //計量証明取扱件数 (19) 
                    CellOutput(outputSheet, 29, 17, printRow.KeiryoShomeiToriCnt);

                    //11条水質持込金額 (20)
                    CellOutput(outputSheet, 23, 23, printRow.Kensa11SuishitsuMochiCnt);

                    //11条水質収集金額 (21)
                    CellOutput(outputSheet, 24, 23, printRow.Kensa11SuishitsuShushuCnt);

                    //11条水質取扱金額 (22)
                    CellOutput(outputSheet, 25, 23, printRow.Kensa11SuishitsuToriCnt);

                    //11条外観金額 (23)
                    CellOutput(outputSheet, 26, 23, printRow.Kensa11GaikanCnt);

                    //計量証明持込金額 (24)
                    CellOutput(outputSheet, 27, 23, printRow.KeiryoShomeiMochiCnt);

                    //計量証明収集金額 (25)
                    CellOutput(outputSheet, 28, 23, printRow.KeiryoShomeiShushuCnt);

                    //計量証明取扱金額 (26) 
                    CellOutput(outputSheet, 29, 23, printRow.KeiryoShomeiToriCnt);

                    //支払合計  (27) 
                    CellOutput(outputSheet, 30, 23, printRow.ShiharaiTotal);

                    //職員名 (28)
                    CellOutput(outputSheet, 43, 23, loginUser);

                    //事務局電話番号 (29)
                    CellOutput(outputSheet, 44, 20, daOutput.HoteiKanriMstDataTable[0].JimukyokuTelNo);

                    CopyRow(outputSheet, 0, rowCount - 1, rowCount * pageIdx);
                    SetPageBreak(outputSheet, rowCount * pageIdx);
                    pageIdx++;
                }

                //delete first page
                DeleteRow(outputSheet, 0, rowCount);
            }
            catch
            {
                throw;
            }
            finally 
            {
                if (outputSheet != null)
                {
                    Marshal.ReleaseComObject(outputSheet);   
                }
            }

            return output;
        }
        #endregion

        #endregion

    }
    #endregion
}
