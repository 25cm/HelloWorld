﻿using System;
using System.Reflection;
using FukjBizSystem.Application.DataSet;
using FukjBizSystem.Application.DataSet.MstKeySaibanTblDataSetTableAdapters;
using Zynas.Framework.Core.Base.DataAccess;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.DataAccess.MstKeySaibanTbl
{
    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： ISelectMstKeySaibanTblByKeyDAInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/24  宗　　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface ISelectMstKeySaibanTblByKeyDAInput
    {
        /// <summary>
        /// マスタ物理名称
        /// </summary>
        String MstButsuriNm { get; set; }

        /// <summary>
        /// キー項目値１
        /// </summary>
        String MstKeyValue1 { get; set; }

        /// <summary>
        /// キー項目値２
        /// </summary>
        String MstKeyValue2 { get; set; }

        /// <summary>
        /// キー項目値３
        /// </summary>
        String MstKeyValue3 { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectMstKeySaibanTblByKeyDAInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/24  宗　　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectMstKeySaibanTblByKeyDAInput : ISelectMstKeySaibanTblByKeyDAInput
    {
        /// <summary>
        /// マスタ物理名称
        /// </summary>
        public String MstButsuriNm { get; set; }

        /// <summary>
        /// キー項目値１
        /// </summary>
        public String MstKeyValue1 { get; set; }

        /// <summary>
        /// キー項目値２
        /// </summary>
        public String MstKeyValue2 { get; set; }

        /// <summary>
        /// キー項目値３
        /// </summary>
        public String MstKeyValue3 { get; set; }

        /// <summary>
        /// ログ出力用データ文字列取得
        /// </summary>
        public string DataString
        {
            get
            {
                return string.Format("マスタ物理名称[{0}], キー項目値１[{1}], キー項目値２[{2}], キー項目値３[{3}]",
                    new string[]{
                        MstButsuriNm,
                        MstKeyValue1,
                        MstKeyValue2,
                        MstKeyValue3
                    });
            }
        }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： ISelectMstKeySaibanTblByKeyDAOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/24  宗　　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface ISelectMstKeySaibanTblByKeyDAOutput
    {
        /// <summary>
        /// MstKeySaibanTblDataTable
        /// </summary>
        MstKeySaibanTblDataSet.MstKeySaibanTblDataTable MstKeySaibanTblDT { get; set; }
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectMstKeySaibanTblByKeyDAOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/24  宗　　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectMstKeySaibanTblByKeyDAOutput : ISelectMstKeySaibanTblByKeyDAOutput
    {
        /// <summary>
        /// MstKeySaibanTblDataTable
        /// </summary>
        public MstKeySaibanTblDataSet.MstKeySaibanTblDataTable MstKeySaibanTblDT { get; set; }
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SelectMstKeySaibanTblByKeyDataAccess
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/24  宗　　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class SelectMstKeySaibanTblByKeyDataAccess : BaseDataAccess<ISelectMstKeySaibanTblByKeyDAInput, ISelectMstKeySaibanTblByKeyDAOutput>
    {
        #region プロパティ(private)

        /// <summary>
        /// テーブルアダプタ
        /// </summary>
        private MstKeySaibanTblTableAdapter tableAdapter = new MstKeySaibanTblTableAdapter();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： SelectMstKeySaibanTblByKeyDataAccess
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/24  宗　　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public SelectMstKeySaibanTblByKeyDataAccess()
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
        /// 2014/07/24  宗　　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override ISelectMstKeySaibanTblByKeyDAOutput Execute(ISelectMstKeySaibanTblByKeyDAInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            ISelectMstKeySaibanTblByKeyDAOutput output = new SelectMstKeySaibanTblByKeyDAOutput();

            try
            {
                // 接続の解決
                tableAdapter.Connection = AddSqlConnection(tableAdapter.Connection);

                output.MstKeySaibanTblDT = tableAdapter.GetDataByKey(input.MstButsuriNm, input.MstKeyValue1, input.MstKeyValue2, input.MstKeyValue3);

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
