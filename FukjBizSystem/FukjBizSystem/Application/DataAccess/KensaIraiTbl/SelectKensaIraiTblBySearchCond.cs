using System;
using System.Reflection;
using FukjBizSystem.Application.DataSet;
using FukjBizSystem.Application.DataSet.KensaIraiTblDataSetTableAdapters;
using Zynas.Framework.Core.Base.DataAccess;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.DataAccess.KensaIraiTbl
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： ISelectKensaIraiTblBySearchCondDAInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface ISelectKensaIraiTblBySearchCondDAInput
    {
        /// <summary>
        /// HokenjoCd
        /// </summary>
        string HokenjoCd { get; set; }

        /// <summary>
        /// KensaIraiNendo
        /// </summary>
        string KensaIraiNendo { get; set; }

        /// <summary>
        /// KensaIraiSetchishaNm
        /// </summary>
        string KensaIraiSetchishaNm { get; set; }

        /// <summary>
        /// KensaIraiShisetsuNm
        /// </summary>
        string KensaIraiShisetsuNm { get; set; }

        /// <summary>
        /// KensaIraiDtFrom
        /// </summary>
        string KensaIraiDtFrom { get; set; }

        /// <summary>
        /// KensaIraiDtTo
        /// </summary>
        string KensaIraiDtTo { get; set; }

        /// <summary>
        /// KensaDtFrom
        /// </summary>
        string KensaDtFrom { get; set; }

        /// <summary>
        /// KensaDtTo
        /// </summary>
        string KensaDtTo { get; set; }

        /// <summary>
        /// KensaIraiHoteiKbn
        /// </summary>
        string KensaIraiHoteiKbn { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectKensaIraiTblBySearchCondDAInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectKensaIraiTblBySearchCondDAInput : ISelectKensaIraiTblBySearchCondDAInput
    {
        /// <summary>
        /// HokenjoCd
        /// </summary>
        public string HokenjoCd { get; set; }

        /// <summary>
        /// KensaIraiNendo
        /// </summary>
        public string KensaIraiNendo { get; set; }

        /// <summary>
        /// KensaIraiSetchishaNm
        /// </summary>
        public string KensaIraiSetchishaNm { get; set; }

        /// <summary>
        /// KensaIraiShisetsuNm
        /// </summary>
        public string KensaIraiShisetsuNm { get; set; }

        /// <summary>
        /// KensaIraiDtFrom
        /// </summary>
        public string KensaIraiDtFrom { get; set; }

        /// <summary>
        /// KensaIraiDtTo
        /// </summary>
        public string KensaIraiDtTo { get; set; }

        /// <summary>
        /// KensaDtFrom
        /// </summary>
        public string KensaDtFrom { get; set; }

        /// <summary>
        /// KensaDtTo
        /// </summary>
        public string KensaDtTo { get; set; }

        /// <summary>
        /// KensaIraiHoteiKbn
        /// </summary>
        public string KensaIraiHoteiKbn { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： ISelectKensaIraiTblBySearchCondDAOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface ISelectKensaIraiTblBySearchCondDAOutput
    {
        /// <summary>
        /// KensaIraiTblKensakuDataTable
        /// </summary>
        KensaIraiTblDataSet.KensaIraiTblKensakuDataTable KensaIraiTblKensakuDataTable { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectKensaIraiTblBySearchCondDAOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectKensaIraiTblBySearchCondDAOutput : ISelectKensaIraiTblBySearchCondDAOutput
    {
        /// <summary>
        /// KensaIraiTblKensakuDataTable
        /// </summary>
        public KensaIraiTblDataSet.KensaIraiTblKensakuDataTable KensaIraiTblKensakuDataTable { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectKensaIraiTblBySearchCondDataAccess
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectKensaIraiTblBySearchCondDataAccess : BaseDataAccess<ISelectKensaIraiTblBySearchCondDAInput, ISelectKensaIraiTblBySearchCondDAOutput>
    {
        #region プロパティ(private)

        /// <summary>
        /// テーブルアダプタ
        /// </summary>
        private KensaIraiTblKensakuTableAdapter tableAdapter = new KensaIraiTblKensakuTableAdapter();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： SelectKensaIraiTblBySearchCondDataAccess
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public SelectKensaIraiTblBySearchCondDataAccess()
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
        /// 2014/08/08　HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override ISelectKensaIraiTblBySearchCondDAOutput Execute(ISelectKensaIraiTblBySearchCondDAInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            ISelectKensaIraiTblBySearchCondDAOutput output = new SelectKensaIraiTblBySearchCondDAOutput();

            try
            {
                // 接続の解決
                tableAdapter.Connection = AddSqlConnection(tableAdapter.Connection);

                output.KensaIraiTblKensakuDataTable = tableAdapter.GetDataBySearchCond(input.HokenjoCd, 
                                                                                        input.KensaIraiNendo, 
                                                                                        DataAccessUtility.EscapeSQLString(input.KensaIraiSetchishaNm), 
                                                                                        DataAccessUtility.EscapeSQLString(input.KensaIraiShisetsuNm), 
                                                                                        input.KensaIraiDtFrom, 
                                                                                        input.KensaIraiDtTo, 
                                                                                        input.KensaDtFrom, 
                                                                                        input.KensaDtTo,
                                                                                        input.KensaIraiHoteiKbn);

            }
            catch (Exception e)
            {
                // トレースログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), string.Format("エラー内容:{0}", e.Message));

                // ＤＢエラー
                throw new CustomException(ResultCode.DBError, string.Format("エラー内容:{0}", e.Message));
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
