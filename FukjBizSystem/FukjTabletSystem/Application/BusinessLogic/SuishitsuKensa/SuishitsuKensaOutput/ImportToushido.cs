using System;
using System.Reflection;
using System.Runtime.InteropServices;
using FukjTabletSystem.Application.DataSet;
using Zynas.Framework.Core.Base.BusinessLogic;
using Zynas.Framework.Utility;

namespace FukjTabletSystem.Application.BusinessLogic.SuishitsuKensa.SuishitsuKensaOutput
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IImportToushidoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15  habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IImportToushidoBLInput
    {
        string FilePath { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ImportToushidoBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15  habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class ImportToushidoBLInput : IImportToushidoBLInput
    {
        public string FilePath { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IImportToushidoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15  habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IImportToushidoBLOutput
    {
        
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ImportToushidoBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15  habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class ImportToushidoBLOutput : IImportToushidoBLOutput
    {

    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ImportToushidoBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/15  habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class ImportToushidoBusinessLogic : BaseBusinessLogic<IImportToushidoBLInput, IImportToushidoBLOutput>
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： ImportToushidoBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/15  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public ImportToushidoBusinessLogic()
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
        /// 2014/07/15  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IImportToushidoBLOutput Execute(IImportToushidoBLInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IImportToushidoBLOutput output = new ImportToushidoBLOutput();

            // Ｅｘｃｅｌのアプリケーションオブジェクトを定義
            Microsoft.Office.Interop.Excel.Application excel = null;
            // Ｅｘｃｅｌのブックオブジェクトを定義
            Microsoft.Office.Interop.Excel.Workbook book = null;

            try
            {
                // Ｅｘｃｅｌのアプリケーションオブジェクトを作成
                excel = new Microsoft.Office.Interop.Excel.Application();

                // 非表示状態に設定
                excel.Visible = false;
                // 20130218 abe シート削除対応のため追加 Start
                // 警告メッセージを非表示
                excel.DisplayAlerts = false;
                // 20130218 abe シート削除対応のため追加 End
                // Ｅｘｃｅｌを開いてブックオブジェクトを取得
                book = excel.Workbooks.Open(
                    input.FilePath,
                    Type.Missing,
                    true,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing,
                    Type.Missing);

                // 再度非表示状態に設定
                excel.Visible = false;
                // 20130218 abe シート削除対応のため追加 Start
                // 警告メッセージを非表示
                excel.DisplayAlerts = false;
                // 20130218 abe シート削除対応のため追加 End

                // TODO Excelの内容をDataTableに保持する
                // TODO 汎用化できるとベター
                // TODO COMオブジェクト解放処理を入れること

                for (int i = 0; i < 100; i ++ )
                {

                }

                // TODO 既定プロパティを継承先で上書きする場合はどうするか？


                // ＥＸＥＣＬを終了
                excel.Quit();

            }
            //2012.03.22 habu MOD Start CustomException発生時にResultCodeが書き換わるのに対応
            catch (CustomException ce)
            {
                if (excel != null)
                {
                    // 2011/08/02 Hieda Mod Start 例外処理時に例外が発生した場合にユーザー操作により書式が上書きされる可能性があるのを修正
                    try
                    {
                        // 確認ダイアログを表示させない
                        excel.DisplayAlerts = false;
                    }
                    catch (Exception e2)
                    {
                        // トレースログ出力
                        TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), e2.ToString());
                    }

                    try
                    {
                        // ＥＸＥＣＬを終了
                        excel.Quit();
                    }
                    catch (Exception e3)
                    {
                        // トレースログ出力
                        TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), e3.ToString());
                    }

                    //// 確認ダイアログを表示させない
                    //excel.DisplayAlerts = false;
                    //// ＥＸＥＣＬを終了
                    //excel.Quit();

                    // 2011/08/02 Hieda Mod End
                }

                // トレースログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), ce.ToString());
                // CustomExceptionを上位ロジックに返す
                throw ce;
            }
            //2012.03.22 habu MOD Start End
            catch (Exception e)
            {
                if (excel != null)
                {
                    // 2011/08/02 Hieda Mod Start 例外処理時に例外が発生した場合にユーザー操作により書式が上書きされる可能性があるのを修正
                    try
                    {
                        // 確認ダイアログを表示させない
                        excel.DisplayAlerts = false;
                    }
                    catch (Exception e2)
                    {
                        // トレースログ出力
                        TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), e2.ToString());
                    }

                    try
                    {
                        // ＥＸＥＣＬを終了
                        excel.Quit();
                    }
                    catch (Exception e3)
                    {
                        // トレースログ出力
                        TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), e3.ToString());
                    }

                    //// 確認ダイアログを表示させない
                    //excel.DisplayAlerts = false;
                    //// ＥＸＥＣＬを終了
                    //excel.Quit();

                    // 2011/08/02 Hieda Mod End

                }

                // トレースログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), e.ToString());
                // ＤＢエラー
                throw new CustomException(ResultCode.OtherError, string.Format("エラー内容:{0}", e.Message));
            }
            finally
            {
                // Ｅｘｃｅｌのブックオブジェクトを解放
                if (book != null) Marshal.ReleaseComObject(book);

                if (excel != null) Marshal.ReleaseComObject(excel);

                GC.Collect();

                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

    }
    #endregion
}
