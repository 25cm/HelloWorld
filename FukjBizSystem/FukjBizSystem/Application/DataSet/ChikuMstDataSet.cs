using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {

    public partial class ChikuMstDataSet {

        partial class ChikuMstKensakuDataTable
        {
        }
    
        partial class ChikuMstDataTable
        {
        }
    }
}

namespace FukjBizSystem.Application.DataSet.ChikuMstDataSetTableAdapters
{
    #region ChikuMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ChikuMstKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/23　HuyTX　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    partial class ChikuMstKensakuTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chikuCdTo"></param>
        /// <param name="chikuCdFrom"></param>
        /// <param name="chikuNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　HuyTX　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal ChikuMstDataSet.ChikuMstKensakuDataTable GetDataBySearchCond(
            String chikuCdFrom,
            String chikuCdTo,
            String chikuNm)
        {
            SqlCommand command = CreateSqlCommand(chikuCdFrom, chikuCdTo, chikuNm);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            ChikuMstDataSet.ChikuMstKensakuDataTable dataTable = new ChikuMstDataSet.ChikuMstKensakuDataTable();
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
        /// <param name="chikuCdFrom"></param>
        /// <param name="chikuCdTo"></param>
        /// <param name="chikuNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　HuyTX　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            String chikuCdFrom,
            String chikuCdTo,
            String chikuNm)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();
            //SELECT
            sqlContent.Append("SELECT                                                                  ");
            sqlContent.Append("      ck.ChikuCd,                                                       ");
            sqlContent.Append("      ck.ChikuNm,                                                       ");
            sqlContent.Append("      ck.ChikuRyakusho,                                                 ");
            sqlContent.Append("      ck.KankatsuHokenjoCd,                                             ");
            sqlContent.Append("      hj.HokenjoNm,                                                     ");
            sqlContent.Append("      ck.HoteiTantoShishoCd,                                            ");
            sqlContent.Append("      ss.ShishoNm  AS HoteiShishoName,                                  ");
            sqlContent.Append("      ck.SuishitsuTantoShishoCd,                                        ");
            sqlContent.Append("      st.ShishoNm AS SuishitsuShishoName,                               ");
            sqlContent.Append("      ck.GaikanChikuwariCd,                                             ");
            sqlContent.Append("      ck.GaikanChikuwari2Cd,                                            ");
            sqlContent.Append("      ck.GappeigoChikuCd,                                               ");
            sqlContent.Append("      ck.InsertDt,                                                      ");
            sqlContent.Append("      ck.InsertUser,                                                    ");
            sqlContent.Append("      ck.InsertTarm,                                                    ");
            sqlContent.Append("      ck.UpdateDt,                                                      ");
            sqlContent.Append("      ck.UpdateUser,                                                    ");
            sqlContent.Append("      ck.UpdateTarm                                                     ");
            //FROM
            sqlContent.Append("FROM                                                                    ");
            sqlContent.Append("      ChikuMst ck                                                       ");
            //JOIN
            sqlContent.Append("LEFT JOIN                                                              ");
            sqlContent.Append("              HokenjoMst hj                                             ");
            sqlContent.Append("        ON    ck.KankatsuHokenjoCd = hj.HokenjoCd                       ");
            sqlContent.Append("LEFT JOIN                                                              ");
            sqlContent.Append("              ShishoMst ss                                              ");
            sqlContent.Append("        ON    ck.HoteiTantoShishoCd = ss.ShishoCd                       ");
            sqlContent.Append("LEFT JOIN                                                              ");
            sqlContent.Append("              ShishoMst st                                           ");
            sqlContent.Append("        ON    ck.SuishitsuTantoShishoCd = st.ShishoCd                ");
            //WHERE
            sqlContent.Append("WHERE 1 = 1                                                             ");

            //if (!String.IsNullOrEmpty(chikuCdFrom) && !String.IsNullOrEmpty(chikuCdTo))
            //{
            //    sqlContent.Append("AND ChikuCd >= @chikuCdFrom                                         ");
            //    sqlContent.Append("AND ChikuCd <= @chikuCdTo                                           ");
            //    commandParams.Add("@chikuCdFrom", SqlDbType.Char).Value = chikuCdFrom;
            //    commandParams.Add("@chikuCdTo", SqlDbType.Char).Value = chikuCdTo;
            //}
            sqlContent.Append("AND ChikuCd " + DataAccessUtility.SetBetweenCommand(chikuCdFrom, chikuCdTo, 5));

            if (!String.IsNullOrEmpty(chikuNm))
            {
                sqlContent.Append(" AND ChikuNm LIKE concat('%', @chikuNm, '%')                         ");
                commandParams.Add("@chikuNm", SqlDbType.Char).Value = chikuNm;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY                                                                ");
            sqlContent.Append("         ChikuCd                                                        ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }

    #endregion
}

namespace FukjBizSystem.Application.DataSet.ChikuMstDataSetTableAdapters
{
    
    
    public partial class ChikuMstTableAdapter {
    }
}
