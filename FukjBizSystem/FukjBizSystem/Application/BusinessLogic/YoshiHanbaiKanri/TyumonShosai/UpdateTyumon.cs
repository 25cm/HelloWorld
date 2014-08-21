using System.Reflection;
using FukjBizSystem.Application.DataAccess.YoshiHanbaiDtlTbl;
using FukjBizSystem.Application.DataAccess.YoshiHanbaiHdrTbl;
using FukjBizSystem.Application.DataAccess.YoshiZaikoTbl;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Base.BusinessLogic;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.BusinessLogic.YoshiHanbaiKanri.TyumonShosai
{
    #region TyumonDataTable
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： TyumonDataTable
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class TyumonDataTable
    {
        /// <summary>
        /// 用紙販売ヘッダテーブル
        /// </summary>
        public YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable YoshiHanbaiHdrTblDataTable { get; set; }

        /// <summary>
        /// 用紙販売明細テーブル
        /// </summary>
        public YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblDataTable YoshiHanbaiDtlTblDataTable { get; set; }

        /// <summary>
        /// 用紙在庫テーブル
        /// </summary>
        public YoshiZaikoTblDataSet.YoshiZaikoTblDataTable YoshiZaikoTblDataTable { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TyumonDataTable()
        {
            YoshiHanbaiHdrTblDataTable = new YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable();
            YoshiHanbaiDtlTblDataTable = new YoshiHanbaiDtlTblDataSet.YoshiHanbaiDtlTblDataTable();
            YoshiZaikoTblDataTable = new YoshiZaikoTblDataSet.YoshiZaikoTblDataTable();
        }
    }
    #endregion

    #region 入力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IUpdateTyumonBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IUpdateTyumonBLInput
    {
        /// <summary>
        /// Update data tables
        /// </summary>
        TyumonDataTable TyumonDataTable { get; set; }
    }
    #endregion

    #region 入力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： UpdateTyumonBLInput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class UpdateTyumonBLInput : IUpdateTyumonBLInput
    {
        /// <summary>
        /// Update data tables
        /// </summary>
        public TyumonDataTable TyumonDataTable { get; set; }
    }
    #endregion

    #region 出力インターフェイス定義
    ////////////////////////////////////////////////////////////////////////////
    //  インターフェイス名 ： IUpdateTyumonBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    interface IUpdateTyumonBLOutput
    {
        
    }
    #endregion

    #region 出力クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： UpdateTyumonBLOutput
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class UpdateTyumonBLOutput : IUpdateTyumonBLOutput
    {
        
    }
    #endregion

    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： UpdateTyumonBusinessLogic
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    class UpdateTyumonBusinessLogic : BaseBusinessLogic<IUpdateTyumonBLInput, IUpdateTyumonBLOutput>
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： UpdateTyumonBusinessLogic
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public UpdateTyumonBusinessLogic()
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
        /// 2014/07/22　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public override IUpdateTyumonBLOutput Execute(IUpdateTyumonBLInput input)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());

            // 出力クラスの実体作成
            IUpdateTyumonBLOutput output = new UpdateTyumonBLOutput();

            try
            {
                // Update 用紙販売ヘッダテーブル
                IUpdateYoshiHanbaiHdrTblDAInput hdrInp = new UpdateYoshiHanbaiHdrTblDAInput();
                hdrInp.YoshiHanbaiHdrTblDataTable = input.TyumonDataTable.YoshiHanbaiHdrTblDataTable;
                new UpdateYoshiHanbaiHdrTblDataAccess().Execute(hdrInp);

                // Update 用紙販売明細テーブル
                IUpdateYoshiHanbaiDtlTblDAInput dtlInp = new UpdateYoshiHanbaiDtlTblDAInput();
                dtlInp.YoshiHanbaiDtlTblDataTable = input.TyumonDataTable.YoshiHanbaiDtlTblDataTable;
                new UpdateYoshiHanbaiDtlTblDataAccess().Execute(dtlInp);

                // Update 用紙在庫テーブル
                IUpdateYoshiZaikoTblDAInput zaikoInp = new UpdateYoshiZaikoTblDAInput();
                zaikoInp.YoshiZaikoTblDataTable = input.TyumonDataTable.YoshiZaikoTblDataTable;
                new UpdateYoshiZaikoTblDataAccess().Execute(zaikoInp);
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
