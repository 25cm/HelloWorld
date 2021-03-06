﻿using System.Reflection;
using FukjBizSystem.Application.BusinessLogic.Master.ShokuinMstShosai;
using FukjBizSystem.Application.BusinessLogic.Master.ShozokuShosaiMst;
using Zynas.Framework.Core.Base.ApplicationLogic;
using Zynas.Framework.Utility;
using FukjBizSystem.Application.BusinessLogic.Master.ShozokuMstShosai;

namespace FukjBizSystem.Application.ApplicationLogic.Master.ShokuinMstShosai
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDeleteBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDeleteBtnClickALInput : IBseALInput, IDeleteShokuinMstByKeyBLInput
    {
        /// <summary>
        /// BushoCd
        /// </summary>
        string BushoCd { get; set; }

        /// <summary>
        /// YakushokuCd
        /// </summary>
        string YakushokuCd { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickALInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickALInput : IDeleteBtnClickALInput
    {
        /// <summary>
        /// ShokuinCd
        /// </summary>
        public string ShokuinCd { get; set; }

        /// <summary>
        /// BushoCd
        /// </summary>
        public string BushoCd { get; set; }

        /// <summary>
        /// YakushokuCd
        /// </summary>
        public string YakushokuCd { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("職員コード[{0}]", ShokuinCd);
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IDeleteBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IDeleteBtnClickALOutput
    {
        /// <summary>
        /// ErrMessage
        /// </summary>
        string ErrMessage { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickALOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickALOutput : IDeleteBtnClickALOutput
    {
        /// <summary>
        /// ErrMessage
        /// </summary>
        public string ErrMessage { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： DeleteBtnClickApplicationLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class DeleteBtnClickApplicationLogic : BaseApplicationLogic<IDeleteBtnClickALInput, IDeleteBtnClickALOutput>
    {
        #region プロパティ

        /// <summary>
        /// 機能名
        /// </summary>
        private const string FunctionName = "ShokuinMstShosai：DeleteBtnClick";

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： DeleteBtnClickApplicationLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/07　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public DeleteBtnClickApplicationLogic()
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
        /// 2014/07/07　HuyTX　　    新規作成
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
        /// 2014/07/07　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IDeleteBtnClickALOutput Execute(IDeleteBtnClickALInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IDeleteBtnClickALOutput output = new DeleteBtnClickALOutput();

            try
            {
                // トランザクション開始
                StartTransaction();

                if (!isExistKey(input.ShokuinCd))
                {
                    output.ErrMessage = string.Format("該当するデータは登録されていません。[職員コード：{0}]", input.ShokuinCd);
                    return output;
                }

                //delete ShokuinMst
                new DeleteShokuinMstByKeyBusinessLogic().Execute(input);

                //delete ShozokuMst
                IDeleteShozokuMstByShokuinCdBLInput blInput = new DeleteShozokuMstByShokuinCdBLInput();
                blInput.ShokuinCd = input.ShokuinCd;

                new DeleteShozokuMstByShokuinCdBusinessLogic().Execute(blInput);

                // コミット
                CompleteTransaction();

            }
            catch
            {
                throw;
            }
            finally
            {
                // トランザクション終了
                EndTransaction();

                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return output;
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region isExistKey
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： isExistKey
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shokuinCd"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/07  HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool isExistKey(string shokuinCd)
        {
            IGetShokuinMstByKeyBLInput blInput = new GetShokuinMstByKeyBLInput();
            blInput.ShokuinCd = shokuinCd;

            IGetShokuinMstByKeyBLOutput blOutput = new GetShokuinMstByKeyBusinessLogic().Execute(blInput);

            if (blOutput.ShokuinMstDT.Count != 0)
            {
                return true;
            }

            return false;
        }
        #endregion

        #endregion
    }
    #endregion
}
