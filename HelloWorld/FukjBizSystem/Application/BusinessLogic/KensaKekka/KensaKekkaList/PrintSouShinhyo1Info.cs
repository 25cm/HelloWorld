using System;
using System.Runtime.InteropServices;
using FukjBizSystem.Application.DataSet;
using Microsoft.Office.Interop.Excel;
using Zynas.Framework.Core.Base.BusinessLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.BusinessLogic.KensaKekka.KensaKekkaList
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintSouShinhyo1InfoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/15　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintSouShinhyo1InfoBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// SouShinhyo1PrintInfoDataTable
        /// </summary>
        KensaIraiTblDataSet.SouShinhyo1PrintInfoDataTable SouShinhyo1PrintInfoDataTable { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintSouShinhyo1InfoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/15　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSouShinhyo1InfoBLInput : IPrintSouShinhyo1InfoBLInput
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
        /// SouShinhyo1PrintInfoDataTable
        /// </summary>
        public KensaIraiTblDataSet.SouShinhyo1PrintInfoDataTable SouShinhyo1PrintInfoDataTable { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintSouShinhyo1InfoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/15　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintSouShinhyo1InfoBLOutput : IBaseExcelPrintBLOutput
    {
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintSouShinhyo1InfoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/15　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSouShinhyo1InfoBLOutput : IPrintSouShinhyo1InfoBLOutput
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
    //  クラス名 ： PrintSouShinhyo1InfoBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/15　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintSouShinhyo1InfoBusinessLogic : BaseExcelPrintBusinessLogic<IPrintSouShinhyo1InfoBLInput, IPrintSouShinhyo1InfoBLOutput>
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintSouShinhyo1InfoBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/15　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintSouShinhyo1InfoBusinessLogic()
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
        /// 2014/08/15　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintSouShinhyo1InfoBLOutput SetBook(IPrintSouShinhyo1InfoBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            IPrintSouShinhyo1InfoBLOutput output = new PrintSouShinhyo1InfoBLOutput();

            Worksheet outputSheet = null;

            try
            {
                outputSheet = (Worksheet) book.Sheets["Sheet1"];

                KensaIraiTblDataSet.SouShinhyo1PrintInfoRow printRow = input.SouShinhyo1PrintInfoDataTable[0];
                DateTime currentDateTime = Boundary.Common.Common.GetCurrentTimestamp();

                //保健所名 (1)
                CellOutput(outputSheet, 3, 2, printRow.HokenjoNm);

                //システム日付 (3)
                CellOutput(outputSheet, 3, 28, "'" + DateUtility.ConvertToWareki(currentDateTime.Year.ToString(), "yy"));
                CellOutput(outputSheet, 3, 31, "'" + currentDateTime.ToString("MM"));
                CellOutput(outputSheet, 3, 34, "'" + currentDateTime.ToString("dd"));

                //支所名称 (4)
                CellOutput(outputSheet, 7, 26, printRow.ShishoNm);

                //支所電話番号 (5)
                CellOutput(outputSheet, 8, 26, printRow.ShishoTelNo);

                //支所Fax番号 (6)
                CellOutput(outputSheet, 9, 26, printRow.ShishoFaxNo);

                //検査担当者  (7)
                CellOutput(outputSheet, 10, 30, printRow.KensaIraiKensaTanato);

                //検査依頼法定区分 (8)
                CellOutput(outputSheet, 13, 9, printRow.ConstNm);

                //設置者名（漢字）(10)
                CellOutput(outputSheet, 19, 6, printRow.KensaIraiSetchishaNm);

                //検査依頼設置場所（住所）(11)
                CellOutput(outputSheet, 20, 6, printRow.KensaIraiSetchibashoAdr);

                //メーカコード (12)
                CellOutput(outputSheet, 21, 6, printRow.GyoshaNmMaker);

                //工事業者コード  (13)
                CellOutput(outputSheet, 22, 6, printRow.GyoshaNmKoiji);

                //保守点検業者コード  (14)
                CellOutput(outputSheet, 23, 6, printRow.GyoshaNmHoshutenken);

                //検査年 検査月 検査日 (15)
                CellOutput(outputSheet, 19, 25, string.Format("平成  {0}年  {1}月  {2}日",
                    new string[] { printRow.KensaIraiKensaNen, printRow.KensaIraiKensaTsuki, printRow.KensaIraiKensaBi }));

                //施設名称 (16)
                CellOutput(outputSheet, 20, 25, printRow.KensaIraiShisetsuNm);

                //処理方式区分 (17)
                CellOutput(outputSheet, 21, 25, printRow.KensaIraiShorihoshikiKbn);

                //処理対象人員 (18)
                CellOutput(outputSheet, 22, 25, printRow.KensaIraiShoritaishoJinin + "人槽");

                //型式コード (19)
                CellOutput(outputSheet, 23, 25, printRow.KatashikiNm);

            }
            catch(Exception)
            {
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
