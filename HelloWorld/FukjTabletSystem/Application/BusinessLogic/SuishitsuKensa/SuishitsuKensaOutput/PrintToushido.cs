using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;
using FukjTabletSystem.Application.DataSet;
using Microsoft.Office.Interop.Excel;
using Zynas.Framework.Core.Base.BusinessLogic;
using Zynas.Framework.Utility;

namespace FukjTabletSystem.Application.BusinessLogic.SuishitsuKensa.SuishitsuKensaOutput
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintToushidoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintToushidoBLInput : IBaseExcelPrintBLInput
    {
        /// <summary>
        /// 受付番号リスト
        /// </summary>
        List<string> uketsukeNoList { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintToushidoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintToushidoBLInput : IPrintToushidoBLInput
    {
        /// <summary>
        /// 受付番号リスト
        /// </summary>
        public List<string> uketsukeNoList { get; set; }

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
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintToushidoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintToushidoBLOutput : IBaseExcelPrintBLOutput
    {

    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintToushidoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintToushidoBLOutput : IPrintToushidoBLOutput
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
    //  クラス名 ： PrintToushidoBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintToushidoBusinessLogic : BaseExcelPrintBusinessLogic<IPrintToushidoBLInput, IPrintToushidoBLOutput>
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintToushidoBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/15　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintToushidoBusinessLogic()
        {

        }
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
        /// 2014/07/15　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected override IPrintToushidoBLOutput SetBook(IPrintToushidoBLInput input, Microsoft.Office.Interop.Excel.Workbook book)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IPrintToushidoBLOutput output = new PrintToushidoBLOutput();

            try
            {
                // TODO テスト用データを出力する
                // TODO 実際には、DBからデータを出力すること

                System.Data.DataTable table = new System.Data.DataTable();
                table.Columns.Add("UketsukeNo", typeof(string));

                {
                    DataRow row = table.NewRow();

                    row["UketsukeNo"] = "1001";

                    table.Rows.Add(row);
                }
                {
                    DataRow row = table.NewRow();

                    row["UketsukeNo"] = "1002";

                    table.Rows.Add(row);
                }
                {
                    DataRow row = table.NewRow();

                    row["UketsukeNo"] = "1003";

                    table.Rows.Add(row);
                }
                {
                    DataRow row = table.NewRow();

                    row["UketsukeNo"] = "1004";

                    table.Rows.Add(row);
                }

                // TODO create In condition(in TableAdapter)
                StringBuilder orStrBuf = new StringBuilder();

                for (int i = 0; i < input.uketsukeNoList.Count; i++)
                {
                    if (orStrBuf.Length > 0)
                    {
                        orStrBuf.Append(" ,");
                    }
                    else
                    {
                        orStrBuf.Append("UketsukeNo IN(");
                    }

                    orStrBuf.AppendFormat("'{0}'", input.uketsukeNoList[i]);
                }
                orStrBuf.Append(")");

                DataRow[] rows = table.Select(orStrBuf.ToString());

                Worksheet sheet = null;
                sheet = (Worksheet)book.Sheets[2];

                int DETAIL_OFFSET = 4;
                for (int i = 0; i < rows.Length; i++)
                {
                    DataRow row = rows[i];

                    CellOutput(sheet, DETAIL_OFFSET + i, 2, row["UketsukeNo"]);
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

    }
    #endregion
}
