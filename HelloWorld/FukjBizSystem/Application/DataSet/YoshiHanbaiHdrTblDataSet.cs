using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {   
    
    public partial class YoshiHanbaiHdrTblDataSet {
        
    }
}

namespace FukjBizSystem.Application.DataSet.YoshiHanbaiHdrTblDataSetTableAdapters
{

    #region YoshiUriageListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： YoshiUriageListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/18  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class YoshiUriageListTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupByDay"></param>
        /// <param name="yoshiHanbaiDtFrom"></param>
        /// <param name="yoshiHanbaiDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal YoshiHanbaiHdrTblDataSet.YoshiUriageListDataTable GetDataBySearchCond(
            bool groupByDay,
            String yoshiHanbaiDtFrom,
            String yoshiHanbaiDtTo)
        {
            SqlCommand command = CreateSqlCommand(groupByDay, yoshiHanbaiDtFrom, yoshiHanbaiDtTo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            YoshiHanbaiHdrTblDataSet.YoshiUriageListDataTable dataTable = new YoshiHanbaiHdrTblDataSet.YoshiUriageListDataTable();
            adpt.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region CreateSqlCommand
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： CreateSqlCommand
        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupByDay"></param>
        /// <param name="yoshiHanbaiDtFrom"></param>
        /// <param name="yoshiHanbaiDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            bool groupByDay,
            String yoshiHanbaiDtFrom,
            String yoshiHanbaiDtTo)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                               ");
            sqlContent.Append("     GyoshaMst.GyoshaNm,                                                             ");
            sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                      ");

            if (groupByDay)
            {
                sqlContent.Append("YoshiHanbaiHdrTbl.YoshiHanbaiDt,                                                 ");
            }
            else
            {
                sqlContent.Append("CONCAT(YoshiHanbaiHdrTbl.YoshiHanbaiDt, '00') AS   YoshiHanbaiDt ,               ");
            }
            
            sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaiGokeiKingaku                                       ");

            // FROM
            sqlContent.Append("FROM                                                                                 ");
            sqlContent.Append("     GyoshaMst                                                                       ");
            sqlContent.Append("LEFT OUTER JOIN                                                                      ");

            if (groupByDay)
            {
                sqlContent.Append("(SELECT                                                                          ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                  ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaiDt,                                            ");
                sqlContent.Append("     SUM(YoshiHanbaiHdrTbl.YoshiHanbaiGokeiKingaku) AS YoshiHanbaiGokeiKingaku   ");
                sqlContent.Append("FROM                                                                             ");
                sqlContent.Append("     YoshiHanbaiHdrTbl                                                           ");
                sqlContent.Append("GROUP BY                                                                         ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                  ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaiDt                                             ");
                sqlContent.Append(") AS YoshiHanbaiHdrTbl                                                           ");
                sqlContent.Append("ON YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd = GyoshaMst.GyoshaCd                ");
            }
            else
            {
                sqlContent.Append("(SELECT                                                                          ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                  ");
                sqlContent.Append("     SUBSTRING(YoshiHanbaiHdrTbl.YoshiHanbaiDt, 0, 7) AS YoshiHanbaiDt,          ");
                sqlContent.Append("     SUM(YoshiHanbaiHdrTbl.YoshiHanbaiGokeiKingaku) AS YoshiHanbaiGokeiKingaku   ");
                sqlContent.Append("FROM                                                                             ");
                sqlContent.Append("     YoshiHanbaiHdrTbl                                                           ");
                sqlContent.Append("GROUP BY                                                                         ");
                sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                  ");
                sqlContent.Append("     SUBSTRING(YoshiHanbaiHdrTbl.YoshiHanbaiDt, 0, 7)                            ");
                sqlContent.Append(") AS YoshiHanbaiHdrTbl                                                           ");
                sqlContent.Append("ON YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd = GyoshaMst.GyoshaCd                ");
            }

            // WHERE
            sqlContent.Append("WHERE                                                                                ");
            sqlContent.Append("     1 = 1                                                                           ");
            sqlContent.Append("     AND ISNULL(YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd, '') <> ''                 ");

            sqlContent.Append("AND YoshiHanbaiHdrTbl.YoshiHanbaiDt >= @yoshiHanbaiDtFrom                            ");
            commandParams.Add("@yoshiHanbaiDtFrom", SqlDbType.Char).Value = yoshiHanbaiDtFrom;

            sqlContent.Append("AND YoshiHanbaiHdrTbl.YoshiHanbaiDt <= @yoshiHanbaiDtTo                              ");                
            commandParams.Add("@yoshiHanbaiDtTo", SqlDbType.Char).Value = yoshiHanbaiDtTo;
            

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaisakiGyoshaCd,                                      ");
            sqlContent.Append("     YoshiHanbaiHdrTbl.YoshiHanbaiDt                                                 ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

    #region TyumonShosaiTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： TyumonShosaiTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/22  AnhNV　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class TyumonShosaiTableAdapter
    {
        #region GetDataByYoshiHanbaiChumonNo
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataByYoshiHanbaiChumonNo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yoshiHanbaiChumonNo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal YoshiHanbaiHdrTblDataSet.TyumonShosaiDataTable GetDataByYoshiHanbaiChumonNo(string yoshiHanbaiChumonNo)
        {
            SqlCommand command = CreateSqlCommand(yoshiHanbaiChumonNo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            YoshiHanbaiHdrTblDataSet.TyumonShosaiDataTable dataTable = new YoshiHanbaiHdrTblDataSet.TyumonShosaiDataTable();
            adpt.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region CreateSqlCommand
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： CreateSqlCommand
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yoshiHanbaiChumonNo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(string yoshiHanbaiChumonNo)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // Sql for add mode
            if (string.IsNullOrEmpty(yoshiHanbaiChumonNo))
            {
                sqlContent.Append(" select                                                                              ");
                sqlContent.Append("     ym.YoshiCd,                                                                     ");
                sqlContent.Append("     ym.YoshiNm,                                                                     ");
                sqlContent.Append("     ym.YoshiKaiinUp,                                                                ");
                sqlContent.Append("     ym.YoshiHiKaiinUp,                                                              ");
                sqlContent.Append("     ym.YoshiKaiinSetKakaku,                                                         ");
                sqlContent.Append("     ym.YoshiHiKaiinSetKakaku,                                                       ");
                sqlContent.Append("     ym.YoshiSetBusu                                                                 ");
                sqlContent.Append(" from YoshiMst ym                                                                    ");
            }
            else // Update mode
            {
                sqlContent.Append(" select                                                                              ");
                sqlContent.Append("     ym.YoshiCd,                                                                     ");
                sqlContent.Append("     ym.YoshiNm,                                                                     ");
                sqlContent.Append("     ym.YoshiKaiinUp,                                                                ");
                sqlContent.Append("     ym.YoshiHiKaiinUp,                                                              ");
                sqlContent.Append("     ym.YoshiKaiinSetKakaku,                                                         ");
                sqlContent.Append("     ym.YoshiHiKaiinSetKakaku,                                                       ");
                sqlContent.Append("     ym.YoshiSetBusu,                                                                ");
                sqlContent.Append("     yoshiTbl.YoshiHanbaiYoshiCd,                                                    ");
                sqlContent.Append("     yoshiTbl.YoshiHanbaiSuryo,                                                      ");
                sqlContent.Append("     yoshiTbl.YoshiHanbaiSetSuryo,                                                   ");
                sqlContent.Append("     yoshiTbl.YoshiHanbaiKakaku                                                      ");
                sqlContent.Append(" from YoshiMst ym                                                                    ");
                sqlContent.Append(" inner join                                                                          ");
                sqlContent.Append(" (                                                                                   ");
	            sqlContent.Append("     select ym.YoshiCd,                                                              ");
		        sqlContent.Append("         yhdt.YoshiHanbaiYoshiCd,                                                    ");
		        sqlContent.Append("         sum(yhdt.YoshiHanbaiSuryo) YoshiHanbaiSuryo,                                ");
		        sqlContent.Append("         sum(yhdt.YoshiHanbaiSetSuryo) YoshiHanbaiSetSuryo,                          ");
		        sqlContent.Append("         sum(yhdt.YoshiHanbaiKakaku) YoshiHanbaiKakaku                               ");
	            sqlContent.Append("     from YoshiHanbaiHdrTbl yhht                                                     ");
	            sqlContent.Append("     inner join YoshiHanbaiDtlTbl yhdt                                               ");
		        sqlContent.Append("         on yhht.YoshiHanbaiChumonNo = yhdt.YoshiHanbaiChumonNo                      ");
	            sqlContent.Append("     inner join YoshiMst ym                                                          ");
		        sqlContent.Append("         on yhdt.YoshiHanbaiYoshiCd = ym.YoshiCd                                     ");
                sqlContent.Append("     where yhht.YoshiHanbaiChumonNo = @YoshiHanbaiChumonNo                           ");
	            sqlContent.Append("     group by ym.YoshiCd, yhdt.YoshiHanbaiYoshiCd                                    ");
                sqlContent.Append(" ) yoshiTbl                                                                          ");
                sqlContent.Append(" on ym.YoshiCd = yoshiTbl.YoshiCd                                                    ");

                // Param
                commandParams.Add("@YoshiHanbaiChumonNo", SqlDbType.Char).Value = yoshiHanbaiChumonNo;
            }

            // ORDER
            sqlContent.Append(" order by ym.YoshiCd                                                                     ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

    #region YoshiHanbaiHdrTblKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： YoshiHanbaiHdrTblKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/23  HuyTX　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    partial class YoshiHanbaiHdrTblKensakuTableAdapter
    {

        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yoshiHanbaiChumonNoFrom"></param>
        /// <param name="yoshiHanbaiChumonNoTo"></param>
        /// <param name="yoshiHanbaiDtFrom"></param>
        /// <param name="yoshiHanbaiDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  HuyTX　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblKensakuDataTable GetDataBySearchCond(string gyoshaCd,
            string yoshiHanbaiChumonNoFrom,
            string yoshiHanbaiChumonNoTo,
            string yoshiHanbaiDtFrom,
            string yoshiHanbaiDtTo)
        {
            SqlCommand command = CreateSqlCommand(gyoshaCd,
                                                yoshiHanbaiChumonNoFrom,
                                                yoshiHanbaiChumonNoTo,
                                                yoshiHanbaiDtFrom,
                                                yoshiHanbaiDtTo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblKensakuDataTable dataTable = new YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblKensakuDataTable();
            adpt.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region CreateSqlCommand
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： CreateSqlCommand
        /// <summary>
        /// 
        /// </summary>
        /// <param name="yoshiHanbaiChumonNoFrom"></param>
        /// <param name="yoshiHanbaiChumonNoTo"></param>
        /// <param name="yoshiHanbaiDtFrom"></param>
        /// <param name="yoshiHanbaiDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  HuyTX　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(string gyoshaCd,
            string yoshiHanbaiChumonNoFrom,
            string yoshiHanbaiChumonNoTo,
            string yoshiHanbaiDtFrom,
            string yoshiHanbaiDtTo)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            //SELECT
            sqlContent.Append("SELECT ");
            sqlContent.Append("LTRIM(yhht.YoshiHanbaiChumonNo) AS YoshiHanbaiChumonNo, ");
            sqlContent.Append("CONVERT(CHAR(10), CONVERT(DATETIME, yhht.YoshiHanbaiDt), 111) as YoshiHanbaiDt , ");
            sqlContent.Append("gm.GyoshaNm, ");
            sqlContent.Append("yhht.YoshiHanbaiGokeiKingaku ");

            //FROM
            sqlContent.Append("FROM YoshiHanbaiHdrTbl yhht ");

            //JOIN
            sqlContent.Append("LEFT JOIN GyoshaMst gm ");
            sqlContent.Append("ON gm.GyoshaCd = yhht.YoshiHanbaisakiGyoshaCd ");

            //WHERE
            sqlContent.Append(" WHERE 1 = 1  ");

            if (!string.IsNullOrEmpty(gyoshaCd))
            {
                sqlContent.Append(" AND yhht.YoshiHanbaisakiGyoshaCd = @gyoshaCd ");
                commandParams.Add("@gyoshaCd", SqlDbType.Char).Value = gyoshaCd;
            }

            //if (!string.IsNullOrEmpty(yoshiHanbaiChumonNoFrom) && !string.IsNullOrEmpty(yoshiHanbaiChumonNoTo))
            //{
            //    sqlContent.Append(" AND yhht.YoshiHanbaiChumonNo BETWEEN @yoshiHanbaiChumonNoFrom AND @yoshiHanbaiChumonNoTo ");
            //    commandParams.Add("@yoshiHanbaiChumonNoFrom", SqlDbType.NVarChar).Value = yoshiHanbaiChumonNoFrom;
            //    commandParams.Add("@yoshiHanbaiChumonNoTo", SqlDbType.NVarChar).Value = yoshiHanbaiChumonNoTo;
            //}

            sqlContent.Append(" AND yhht.YoshiHanbaiChumonNo " + DataAccessUtility.SetBetweenCommand(yoshiHanbaiChumonNoFrom, yoshiHanbaiChumonNoTo, 10));

            if (!string.IsNullOrEmpty(yoshiHanbaiDtFrom) && !string.IsNullOrEmpty(yoshiHanbaiDtTo))
            {
                sqlContent.Append(" AND YoshiHanbaiDt BETWEEN CAST(@yoshiHanbaiDtFrom AS DATE) AND CAST(@yoshiHanbaiDtTo AS DATE) ");
                commandParams.Add("@yoshiHanbaiDtFrom", SqlDbType.Char).Value = yoshiHanbaiDtFrom;
                commandParams.Add("@yoshiHanbaiDtTo", SqlDbType.Char).Value = yoshiHanbaiDtTo;
            }

            //ORDER BY
            sqlContent.Append(" ORDER BY yhht.YoshiHanbaiChumonNo ");

            command.CommandText = sqlContent.ToString();
            return command;
        }
    }
        #endregion

    #endregion
}


namespace FukjBizSystem.Application.DataSet.YoshiHanbaiHdrTblDataSetTableAdapters
{
    
    
    
}
