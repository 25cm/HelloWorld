using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {
    
    public partial class ShokuinMstDataSet {
        partial class ShokuinMstDataTable
        {
        }
    }
}

namespace FukjBizSystem.Application.DataSet.ShokuinMstDataSetTableAdapters
{
    #region ShokuinMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ShokuinMstKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/04　DatNT　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class ShokuinMstKensakuTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shishoCd"></param>
        /// <param name="shokuinCdFrom"></param>
        /// <param name="shokuinCdTo"></param>
        /// <param name="shokuinNm"></param>
        /// <param name="shokuinKana"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/04　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal ShokuinMstDataSet.ShokuinMstKensakuDataTable GetDataBySearchCond(
            String shishoCd,
            String shokuinCdFrom,
            String shokuinCdTo,
            String shokuinNm,
            String shokuinKana)
        {
            SqlCommand command = CreateSqlCommand(shishoCd,
                                                    shokuinCdFrom,
                                                    shokuinCdTo,
                                                    shokuinNm,
                                                    shokuinKana
                                                    );

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            ShokuinMstDataSet.ShokuinMstKensakuDataTable dataTable = new ShokuinMstDataSet.ShokuinMstKensakuDataTable();
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
        /// <param name="shishoCd"></param>
        /// <param name="shokuinCdFrom"></param>
        /// <param name="shokuinCdTo"></param>
        /// <param name="shokuinNm"></param>
        /// <param name="shokuinKana"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            String shishoCd,
            String shokuinCdFrom,
            String shokuinCdTo,
            String shokuinNm,
            String shokuinKana)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                               ");
            sqlContent.Append("     ShokuinMst.ShokuinShozokuShishoCd,                              ");
            sqlContent.Append("     ShokuinMst.ShokuinCd,                                           ");
            sqlContent.Append("     ShokuinMst.ShokuinNm,                                           ");
            sqlContent.Append("     ShokuinMst.ShokuinKana,                                         ");
            sqlContent.Append("     ShokuinMst.ShokuinSeinengappi,                                  ");
            sqlContent.Append("     ShokuinMst.ShokuinNyushaDt,                                     ");
            sqlContent.Append("     ShokuinMst.ShokuinTaishokuDt,                                   ");
            sqlContent.Append("     ShokuinMst.ShokuinTaishokuFlg,                                  ");
            sqlContent.Append("     ShokuinMst.ShokuinPassword,                                     ");
            sqlContent.Append("     ShokuinMst.ShokuinInjiJun,                                      ");
            sqlContent.Append("     ShishoMst.ShishoNm                                              ");
            
            // FROM
            sqlContent.Append("FROM                                                                 ");
            sqlContent.Append("     ShokuinMst                                                 ");
            sqlContent.Append("LEFT OUTER JOIN                                                      ");
            sqlContent.Append("     ShishoMst                                                       ");
            sqlContent.Append("         ON ShishoMst.ShishoCd = ShokuinMst.ShokuinShozokuShishoCd   ");

            // WHERE
            sqlContent.Append("WHERE                                                                ");
            sqlContent.Append("     1 = 1                                                           ");
            
            if (!String.IsNullOrEmpty(shishoCd))
            {
                sqlContent.Append("AND ShokuinMst.ShokuinShozokuShishoCd = @shishoCd                ");
                commandParams.Add("@shishoCd", SqlDbType.Char).Value = shishoCd;
            }

            sqlContent.Append("AND ShokuinMst.ShokuinCd " + DataAccessUtility.SetBetweenCommand(shokuinCdFrom, shokuinCdTo, 3));

            if (!String.IsNullOrEmpty(shokuinNm))
            {
                sqlContent.Append("AND ShokuinMst.ShokuinNm LIKE concat('%', @shokuinNm, '%') ");
                commandParams.Add("@shokuinNm", SqlDbType.NVarChar).Value = shokuinNm;
            }

            if (!String.IsNullOrEmpty(shokuinKana))
            {
                sqlContent.Append("AND ShokuinMst.ShokuinKana LIKE concat('%', @shokuinKana, '%') ");
                commandParams.Add("@shokuinKana", SqlDbType.NVarChar).Value = shokuinKana;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     ShokuinMst.ShokuinShozokuShishoCd, ShokuinMst.ShokuinCd        ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
