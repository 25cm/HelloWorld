using System;
using System.Reflection;
using FukjBizSystem.Application.BusinessLogic.Others.KensaKeihatsuSuishinhiList;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.Others.KensaKeihatsuSuishinhiList
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IIkkatsuPrintBtnClickALInput
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
    interface IIkkatsuPrintBtnClickALInput : IBseALInput
    {
        /// <summary>
        /// 支払票印刷第○号
        /// </summary>
        string PrintNo { get; set; }

        /// <summary>
        /// System datetime
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
    //  クラス名 ： IkkatsuPrintBtnClickALInput
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
    class IkkatsuPrintBtnClickALInput : IIkkatsuPrintBtnClickALInput
    {
        /// <summary>
        /// 支払票印刷第○号
        /// </summary>
        public string PrintNo { get; set; }

        /// <summary>
        /// System datetime
        /// </summary>
        public DateTime SystemDt { get; set; }

        /// <summary>
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        public KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable KensaKeihatsuSuishinListDataTable { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("支払票印刷第○号[{0}]", PrintNo);
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IIkkatsuPrintBtnClickALOutput
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
    interface IIkkatsuPrintBtnClickALOutput
    {
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： IkkatsuPrintBtnClickALOutput
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
    class IkkatsuPrintBtnClickALOutput : IIkkatsuPrintBtnClickALOutput
    {
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： IkkatsuPrintBtnClickApplicationLogic
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
    class IkkatsuPrintBtnClickApplicationLogic : BaseApplicationLogic<IIkkatsuPrintBtnClickALInput, IIkkatsuPrintBtnClickALOutput>
    {
        #region プロパティ

        /// <summary>
        /// 機能名
        /// </summary>
        private const string FunctionName = "KensaKeihatsuSuishinhiList：IkkatsuBtnClick";

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： IkkatsuPrintBtnClickApplicationLogic
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
        public IkkatsuPrintBtnClickApplicationLogic()
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
        /// 2014/08/21　HuyTX　　    新規作成
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
        /// 2014/08/21　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IIkkatsuPrintBtnClickALOutput Execute(IIkkatsuPrintBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IIkkatsuPrintBtnClickALOutput output = new IkkatsuPrintBtnClickALOutput();

            try
            {
                //print MochikomiGyosha (019)
                if (input.KensaKeihatsuSuishinListDataTable.Select("ToriatsukaiGyoshaKbn = 2 AND ToriatsukaiGyoshaCd = ''").Length > 0)
                {
                    IPrintMochikomiGyoshaBLInput printMochikomiGyoshaBLInput = new PrintMochikomiGyoshaBLInput();
                    printMochikomiGyoshaBLInput.PrintDirectory = Properties.Settings.Default.PrintDirectory;
                    printMochikomiGyoshaBLInput.FormatPath = Properties.Settings.Default.PrintFormatFolder + Properties.Settings.Default.MoshiKomiGyoshaFormatFile;
                    printMochikomiGyoshaBLInput.AfterPrintFlg = true;

                    printMochikomiGyoshaBLInput.KensaKeihatsuSuishinListDataTable = input.KensaKeihatsuSuishinListDataTable;
                    printMochikomiGyoshaBLInput.PrintNo = input.PrintNo;
                    printMochikomiGyoshaBLInput.SystemDt = input.SystemDt;

                    new PrintMochikomiGyoshaBusinessLogic().Execute(printMochikomiGyoshaBLInput);
                }

                //print ShushuToriatsukaiGyosha (020)
                if (input.KensaKeihatsuSuishinListDataTable.Select("ToriatsukaiGyoshaKbn <> 2 AND ToriatsukaiGyoshaCd <> ''").Length > 0)
                {
                    IPrintShushuToriatsukaiGyoshaBLInput printShushuToriatsukaiGyoshaBLInput = new PrintShushuToriatsukaiGyoshaBLInput();
                    printShushuToriatsukaiGyoshaBLInput.PrintDirectory = Properties.Settings.Default.PrintDirectory;
                    printShushuToriatsukaiGyoshaBLInput.FormatPath = Properties.Settings.Default.PrintFormatFolder + Properties.Settings.Default.ShushuToriatsukaiGyoshaFormatFile;
                    printShushuToriatsukaiGyoshaBLInput.AfterPrintFlg = true;

                    printShushuToriatsukaiGyoshaBLInput.KensaKeihatsuSuishinListDataTable = input.KensaKeihatsuSuishinListDataTable;
                    printShushuToriatsukaiGyoshaBLInput.PrintNo = input.PrintNo;
                    printShushuToriatsukaiGyoshaBLInput.SystemDt = input.SystemDt;

                    new PrintShushuToriatsukaiGyoshaBusinessLogic().Execute(printShushuToriatsukaiGyoshaBLInput);
                }

                //TODO Print 021

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
