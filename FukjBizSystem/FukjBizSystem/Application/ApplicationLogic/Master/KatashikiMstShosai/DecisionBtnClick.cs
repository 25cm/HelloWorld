using System.Reflection;
using FukjBizSystem.Application.Boundary.Master;
using FukjBizSystem.Application.BusinessLogic.Master.KatashikiMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.ApplicationLogic.Master.KatashikiMstShosai
{
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
    /// 2014/07/08  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALInput : IBseALInput, 
                                            IUpdateKatashikiMstBLInput,
                                            IInsertKatashikiBurowaMstBLInput,
                                            IUpdateKatashikiBetsuTaniSochiMstBLInput
                
    {
        /// <summary>
        /// DispMode
        /// </summary>
        KatashikiMstShosaiForm.DispMode DispMode { get; set; }
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
    /// 2014/07/08  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALInput : IDecisionBtnClickALInput
    {
        /// <summary>
        /// DispMode
        /// </summary>
        public KatashikiMstShosaiForm.DispMode DispMode { get; set; }

        /// <summary>
        /// KatashikiMstDataTable
        /// </summary>
        public KatashikiMstDataSet.KatashikiMstDataTable KatashikiMstDT { get; set; }

        /// <summary>
        /// KatashikiBurowaMstDataTable
        /// </summary>
        public KatashikiBurowaMstDataSet.KatashikiBurowaMstDataTable KatashikiBurowaMstDT { get; set; }

        /// <summary>
        /// KatashikiBetsuTaniSochiMstDataTable
        /// </summary>
        public KatashikiBetsuTaniSochiMstDataSet.KatashikiBetsuTaniSochiMstDataTable KatashikiBetsuTaniSochiMstDT { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("DispMode[{0}], KatashikiMstDataTable[{1}], KatashikiBurowaMstDataTable[{2}], KatashikiBetsuTaniSochiMstDataTable[{3}]", 
                    new string[]{
                        DispMode.ToString(),
                        KatashikiMstDT[0].KatashikiCd,
                        KatashikiBurowaMstDT[0].BurowaKatashikiCd,
                        KatashikiBetsuTaniSochiMstDT[0].KatashikiCd
                    });
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
    /// 2014/07/08  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDecisionBtnClickALOutput
    {
        /// <summary>
        /// ErrorMessage
        /// </summary>
        string ErrorMessage { get; set; }
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
    /// 2014/07/08  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickALOutput : IDecisionBtnClickALOutput
    {
        /// <summary>
        /// ErrorMessage
        /// </summary>
        public string ErrorMessage { get; set; }
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
    /// 2014/07/08  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DecisionBtnClickApplicationLogic : BaseApplicationLogic<IDecisionBtnClickALInput, IDecisionBtnClickALOutput>
    {
        #region プロパティ

        /// <summary>
        /// 機能名
        /// </summary>
        private const string FunctionName = "KatashikiMstShosai：DecisionBtnClickApplicationLogic";

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
        /// 2014/07/08  DatNT　　    新規作成
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
        /// 2014/07/08  DatNT　　    新規作成
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
        /// 2014/07/08  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDecisionBtnClickALOutput Execute(IDecisionBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDecisionBtnClickALOutput output = new DecisionBtnClickALOutput();

            try
            {
                StartTransaction();

                string checkExist = CheckExist(input);

                if (!string.IsNullOrEmpty(checkExist))
                {
                    output.ErrorMessage = checkExist;

                    return output;
                }

                // update KatashikiMst
                IUpdateKatashikiMstBLInput mstInput = new UpdateKatashikiMstBLInput();
                mstInput.KatashikiMstDT = input.KatashikiMstDT;
                IUpdateKatashikiMstBLOutput mstOutput = new UpdateKatashikiMstBusinessLogic().Execute(mstInput);
                
                if (input.DispMode == KatashikiMstShosaiForm.DispMode.Edit)
                {
                    #region KatashikiBurowaMst

                    // delete KatashikiBurowaMst
                    IDeleteKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLInput delBuroInput = new DeleteKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLInput();
                    delBuroInput.BurowaKatashikiMakerCd     = input.KatashikiBurowaMstDT[0].BurowaKatashikiMakerCd;
                    delBuroInput.BurowaKatashikiCd          = input.KatashikiBurowaMstDT[0].BurowaKatashikiCd;
                    IDeleteKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLOutput delBuroOutput = new DeleteKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBusinessLogic().Execute(delBuroInput);
                    
                    // update KatashikiBurowaMst
                    IInsertKatashikiBurowaMstBLInput buroInput = new InsertKatashikiBurowaMstBLInput();
                    buroInput.KatashikiBurowaMstDT = input.KatashikiBurowaMstDT;
                    IInsertKatashikiBurowaMstBLOutput buroOutput = new UpdateKatashikiBurowaMstBusinessLogic().Execute(buroInput);

                    #endregion

                    #region KatashikiBetsuTaniSochiMst

                    // delete KatashikiBetsuTaniSochiMst
                    IDeleteKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLInput delSochiInput = new DeleteKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLInput();
                    delSochiInput.KatashikiMakerCd      = input.KatashikiBetsuTaniSochiMstDT[0].KatashikiMakerCd;
                    delSochiInput.KatashikiCd           = input.KatashikiBetsuTaniSochiMstDT[0].KatashikiCd;
                    IDeleteKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLOutput delSochiOutput = new DeleteKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBusinessLogic().Execute(delSochiInput);

                    // update KatashikiBetsuTaniSochiMst
                    IUpdateKatashikiBetsuTaniSochiMstBLInput sochiInput = new UpdateKatashikiBetsuTaniSochiMstBLInput();
                    sochiInput.KatashikiBetsuTaniSochiMstDT = input.KatashikiBetsuTaniSochiMstDT;
                    IUpdateKatashikiBetsuTaniSochiMstBLOutput sochiOutput = new UpdateKatashikiBetsuTaniSochiMstBusinessLogic().Execute(sochiInput);

                    #endregion
                }
                else
                {
                    // update KatashikiBurowaMst
                    IInsertKatashikiBurowaMstBLInput buroInput = new InsertKatashikiBurowaMstBLInput();
                    buroInput.KatashikiBurowaMstDT = input.KatashikiBurowaMstDT;
                    IInsertKatashikiBurowaMstBLOutput buroOutput = new UpdateKatashikiBurowaMstBusinessLogic().Execute(buroInput);

                    // update KatashikiBetsuTaniSochiMst
                    IUpdateKatashikiBetsuTaniSochiMstBLInput sochiInput = new UpdateKatashikiBetsuTaniSochiMstBLInput();
                    sochiInput.KatashikiBetsuTaniSochiMstDT = input.KatashikiBetsuTaniSochiMstDT;
                    IUpdateKatashikiBetsuTaniSochiMstBLOutput sochiOutput = new UpdateKatashikiBetsuTaniSochiMstBusinessLogic().Execute(sochiInput);
                }                              

                CompleteTransaction();
            }
            catch
            {
                throw;
            }
            finally
            {
                EndTransaction();

                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region CheckExist
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CheckExist
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/09  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private string CheckExist(IDecisionBtnClickALInput input)
        {
            string retStr = string.Empty;

            string katashikiMakerCd = input.KatashikiMstDT[0].KatashikiMakerCd;
            string katashikiCd = input.KatashikiMstDT[0].KatashikiCd;

            // KatashikiMst
            IGetKatashikiMstByKeyBLInput mstInput = new GetKatashikiMstByKeyBLInput();
            mstInput.KatashikiMakerCd = katashikiMakerCd;
            mstInput.KatashikiCd = katashikiCd;
            IGetKatashikiMstByKeyBLOutput mstOutput = new GetKatashikiMstByKeyBusinessLogic().Execute(mstInput);

            if (mstOutput.KatashikiMstDT != null && mstOutput.KatashikiMstDT.Count > 0)
            {
                if (input.DispMode == KatashikiMstShosaiForm.DispMode.Add)
                {
                    retStr += string.Format("既に登録済みです。[型式マスタ][メーカー業者コード：{0}、型式コード：{1}]\r\n",
                                                    new string[] { katashikiMakerCd, katashikiCd });
                }
            }
            else
            {
                if (input.DispMode == KatashikiMstShosaiForm.DispMode.Edit)
                {
                    retStr += string.Format("該当するデータは登録されていません。[型式マスタ][メーカー業者コード：{0}、型式コード：{1}]\r\n",
                                                new string[] { katashikiMakerCd, katashikiCd });

                    return retStr;
                }
            }

            if (input.DispMode == KatashikiMstShosaiForm.DispMode.Add)
            {
                // KatashikiBurowaMst
                IGetKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLInput buroInput = new GetKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLInput();
                buroInput.BurowaKatashikiMakerCd = katashikiMakerCd;
                buroInput.BurowaKatashikiCd = katashikiCd;
                IGetKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBLOutput buroOutput = new GetKatashikiBurowaMstByKatashikiMakerCdKatashikiCdBusinessLogic().Execute(buroInput);

                if (buroOutput.KatashikiBurowaMstDT != null && buroOutput.KatashikiBurowaMstDT.Count > 0)
                {
                    retStr += string.Format("既に登録済みです。[型式ブロワマスタ][メーカー業者コード：{0}、型式コード：{1}]\r\n",
                                                    new string[] { katashikiMakerCd, katashikiCd });
                }

                //KatashikiBetsuTaniSochiMst
                IGetKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLInput sochiInput = new GetKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLInput();
                sochiInput.KatashikiMakerCd = katashikiMakerCd;
                sochiInput.KatashikiCd = katashikiCd;
                IGetKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBLOutput sochiOutput = new GetKatashikiBetsuTaniSochiMstByKatashikiMakerCdKatashikiCdBusinessLogic().Execute(sochiInput);

                if (sochiOutput.KatashikiBetsuTaniSochiMstDT != null && sochiOutput.KatashikiBetsuTaniSochiMstDT.Count > 0)
                {
                    retStr += string.Format("既に登録済みです。[型式別単位装置マスタ][メーカー業者コード：{0}、型式コード：{1}]\r\n",
                                                    new string[] { katashikiMakerCd, katashikiCd });
                }
            }

            return retStr;
        }
        #endregion

        #endregion
    }
    #endregion
}
