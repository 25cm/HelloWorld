using System;
using System.Net;
using System.Reflection;
using FukjBizSystem.Application.BusinessLogic.KinoHoshoKanri.HoshoNoPrint;
using FukjBizSystem.Application.BusinessLogic.KinoHoshoKanri.HoshoShinseiShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.KinoHoshoKanri.HoshoNoPrint
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintBtnClickALInput : IBseALInput, IGetHoshoTorokuTblByKeyBetweenBLInput
    {
        /// <summary>
        /// HoshoTorokuTblDataTable Insert
        /// </summary>
        HoshoTorokuTblDataSet.HoshoTorokuTblDataTable HoshoTorokuTblInsertDT { get; set; }

        /// <summary>
        /// HoshoTorokuTblDataTable Update
        /// </summary>
        HoshoTorokuTblDataSet.HoshoTorokuTblDataTable HoshoTorokuTblUpdateDT { get; set; }

        /// <summary>
        /// TRUE  : Update data
        /// FALSE : Get data
        /// </summary>
        bool IsUpdate { get; set; }

        /// <summary>
        /// HoshoNoPrintInfoDataTable
        /// </summary>
        HoshoTorokuTblDataSet.HoshoNoPrintInfoDataTable HoshoNoPrintInfoDataTable { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintBtnClickALInput : IPrintBtnClickALInput
    {
        /// <summary>
        /// HoshoTorokuTblDataTable Insert
        /// </summary>
        public HoshoTorokuTblDataSet.HoshoTorokuTblDataTable HoshoTorokuTblInsertDT { get; set; }

        /// <summary>
        /// HoshoTorokuTblDataTable Update
        /// </summary>
        public HoshoTorokuTblDataSet.HoshoTorokuTblDataTable HoshoTorokuTblUpdateDT { get; set; }

        /// <summary>
        /// 保証登録検査機関（開始）, 保証登録年度（開始）, 保証登録年度（終了）
        /// </summary>
        public string KensakikanNendoRenbanFrom { get; set; }

        /// <summary>
        /// 保証登録検査機関（終了）, 保証登録連番（終了）, 保証登録連番（終了）
        /// </summary>
        public string KensakikanNendoRenbanTo { get; set; }

        /// <summary>
        /// TRUE  : Update data
        /// FALSE : Get data
        /// </summary>
        public bool IsUpdate { get; set; }

        /// <summary>
        /// HoshoNoPrintInfoDataTable
        /// </summary>
        public HoshoTorokuTblDataSet.HoshoNoPrintInfoDataTable HoshoNoPrintInfoDataTable { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("HoshoTorokuTblInsertDataTable[{0}],HoshoTorokuTblUpdateDataTable[{1}], IsNewIssues[{1}]", 
                    new string[] { 
                        HoshoTorokuTblInsertDT[0].HoshoTorokuKensakikan,
                        HoshoTorokuTblUpdateDT[0].HoshoTorokuKensakikan,
                        IsUpdate.ToString()
                    });
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IPrintBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IPrintBtnClickALOutput : IGetHoshoTorokuTblByKeyBetweenBLOutput
    {
        /// <summary>
        /// Result Update
        /// </summary>
        bool Result { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintBtnClickALOutput : IPrintBtnClickALOutput
    {
        /// <summary>
        /// Result Update
        /// </summary>
        public bool Result { get; set; }

        /// <summary>
        /// HoshoTorokuTblDataTable
        /// </summary>
        public HoshoTorokuTblDataSet.HoshoTorokuTblDataTable HoshoTorokuTblDT { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： PrintBtnClickApplicationLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class PrintBtnClickApplicationLogic : BaseApplicationLogic<IPrintBtnClickALInput, IPrintBtnClickALOutput>
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
        private const string FunctionName = "HoshoNoPrint：PrintBtnClickApplicationLogic";

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： PrintBtnClickApplicationLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/17  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public PrintBtnClickApplicationLogic()
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
        /// 2014/07/17  DatNT　  新規作成
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
        /// 2014/07/17  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IPrintBtnClickALOutput Execute(IPrintBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IPrintBtnClickALOutput output = new PrintBtnClickALOutput();

            try
            {

                if (!input.IsUpdate)
                {
                    output.HoshoTorokuTblDT = new GetHoshoTorokuTblByKeyBetweenBusinessLogic().Execute(input).HoshoTorokuTblDT;

                    if (output.HoshoTorokuTblDT == null || output.HoshoTorokuTblDT.Count == 0)
                    {
                        output.Result = false;

                        return output;
                    }
                }
                else
                {
                    if (input.HoshoTorokuTblUpdateDT != null && input.HoshoTorokuTblUpdateDT.Count > 0)
                    {
                        IUpdateHoshoTorokuTblBLInput blInput = new UpdateHoshoTorokuTblBLInput();
                        blInput.HoshoTorokuTblDT = CreateDataUpdate(input.HoshoTorokuTblUpdateDT);
                        IUpdateHoshoTorokuTblBLOutput blOutput = new UpdateHoshoTorokuTblBusinessLogic().Execute(blInput);
                    }

                    if (input.HoshoTorokuTblInsertDT != null && input.HoshoTorokuTblInsertDT.Count > 0)
                    {
                        IUpdateHoshoTorokuTblBLInput blInput = new UpdateHoshoTorokuTblBLInput();
                        blInput.HoshoTorokuTblDT = input.HoshoTorokuTblInsertDT;
                        IUpdateHoshoTorokuTblBLOutput blOutput = new UpdateHoshoTorokuTblBusinessLogic().Execute(blInput);
                    }

                    output.Result = true;

                    //ADD HuyTX START
                    IPrintHoshoNoInfoBLInput printBLInput = new PrintHoshoNoInfoBLInput();

                    printBLInput.PrintDirectory = Properties.Settings.Default.PrintDirectory;
                    printBLInput.AfterPrintFlg = true;
                    printBLInput.FormatPath = Properties.Settings.Default.PrintFormatFolder + Properties.Settings.Default.HoshoNoFormatFile;
                    printBLInput.HoshoNoPrintInfoDataTable = input.HoshoNoPrintInfoDataTable;

                    new PrintHoshoNoInfoBusinessLogic().Execute(printBLInput);

                    //ADD HuyTX END
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

        #region メソッド(private)

        #region CreateDataUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateDataUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="dataTable"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/24  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private HoshoTorokuTblDataSet.HoshoTorokuTblDataTable CreateDataUpdate(HoshoTorokuTblDataSet.HoshoTorokuTblDataTable dataTable)
        {
            DateTime now = Boundary.Common.Common.GetCurrentTimestamp();
            string loginUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;
            string pcUpdate = Dns.GetHostName();

            HoshoTorokuTblDataSet.HoshoTorokuTblDataTable updateDT = new HoshoTorokuTblDataSet.HoshoTorokuTblDataTable();

            for (int i = 0; i < dataTable.Count; i++)
            {
                IGetHoshoTorokuTblByKeyBLInput blInput = new GetHoshoTorokuTblByKeyBLInput();
                blInput.HoshoTorokuKensakikan = dataTable[i].HoshoTorokuKensakikan;
                blInput.HoshoTorokuNendo = dataTable[i].HoshoTorokuNendo;
                blInput.HoshoTorokuRenban = dataTable[i].HoshoTorokuRenban;
                IGetHoshoTorokuTblByKeyBLOutput blOutput = new GetHoshoTorokuTblByKeyBusinessLogic().Execute(blInput);

                HoshoTorokuTblDataSet.HoshoTorokuTblRow row = blOutput.HoshoTorokuTblDataTable[0];

                // 更新日が違うか？
                if (row.UpdateDt != dataTable[i].UpdateDt)
                {
                    throw new CustomException((int)ResultCode.LockError, (int)OperationErr.RakkanLock, string.Empty);
                }

                // 更新日
                blOutput.HoshoTorokuTblDataTable[0].UpdateDt = now;

                // 更新者
                blOutput.HoshoTorokuTblDataTable[0].UpdateUser = loginUser;

                // 更新端末
                blOutput.HoshoTorokuTblDataTable[0].UpdateTarm = pcUpdate;

                // 設置場所
                blOutput.HoshoTorokuTblDataTable[0].HoshoTorokuSetchibashoAdr = dataTable[i].HoshoTorokuSetchibashoAdr;

                // 補助市町村
                blOutput.HoshoTorokuTblDataTable[0].HoshoTorokuHojoShichosonCd = dataTable[i].HoshoTorokuHojoShichosonCd;

                // 浄化槽検査機関
                blOutput.HoshoTorokuTblDataTable[0].HoshoTorokuJokasoKensakikan = dataTable[i].HoshoTorokuJokasoKensakikan;

                updateDT.ImportRow(blOutput.HoshoTorokuTblDataTable[0]);

            }

            return updateDT;
        }
        #endregion

        #endregion
    }
    #endregion
}
