using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.SqlServerCe;

namespace FukjTabletSystem.Application.DataSet.Ce
{
    public partial class GaikankensaKomokuMstDataSet {
    }
}

namespace FukjTabletSystem.Application.DataSet.Ce.GaikankensaKomokuMstDataSetTableAdapters
{

    #region GaikankensaKomokuMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： GaikankensaKomokuMstKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/01　DatNT　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class GaikankensaKomokuMstKensakuTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gaikankensaKomokuCdFrom"></param>
        /// <param name="gaikankensaKomokuCdTo"></param>
        /// <param name="gaikankensaKomokuNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/01　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal GaikankensaKomokuMstDataSet.GaikankensaKomokuMstKensakuDataTable GetDataBySearchCond(
            String gaikankensaKomokuCdFrom,
            String gaikankensaKomokuCdTo,
            String gaikankensaKomokuNm)
        {
            SqlCeCommand command = CreateSqlCommand(gaikankensaKomokuCdFrom, gaikankensaKomokuCdTo, gaikankensaKomokuNm);

            SqlCeDataAdapter adpt = new SqlCeDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            GaikankensaKomokuMstDataSet.GaikankensaKomokuMstKensakuDataTable dataTable = new GaikankensaKomokuMstDataSet.GaikankensaKomokuMstKensakuDataTable();
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
        /// <param name="gaikankensaKomokuCdFrom"></param>
        /// <param name="gaikankensaKomokuCdTo"></param>
        /// <param name="gaikankensaKomokuNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/01　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCeCommand CreateSqlCommand(
            String gaikankensaKomokuCdFrom,
            String gaikankensaKomokuCdTo,
            String gaikankensaKomokuNm)
        {
            SqlCeCommand command = new SqlCeCommand();
            SqlCeParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                   ");
            sqlContent.Append("     GaikankensaKomokuCd,                                ");
            sqlContent.Append("     GaikankensaKomokuNm,                                ");
            sqlContent.Append("     ZenGaikankensaKomokuCd,                             ");
            sqlContent.Append("     ZenGaikankensaKomokuRyakumei,                       ");
            sqlContent.Append("     InsertDt,                                           ");
            sqlContent.Append("     InsertUser,                                         ");
            sqlContent.Append("     InsertTarm,                                         ");
            sqlContent.Append("     UpdateDt,                                           ");
            sqlContent.Append("     UpdateUser,                                         ");
            sqlContent.Append("     UpdateTarm                                          ");

            // FROM
            sqlContent.Append("FROM                                                     ");
            sqlContent.Append("     GaikankensaKomokuMst                                ");

            // WHERE
            sqlContent.Append("WHERE                                                    ");
            sqlContent.Append("     1 = 1                                               ");

            if (!String.IsNullOrEmpty(gaikankensaKomokuCdFrom) && !String.IsNullOrEmpty(gaikankensaKomokuCdTo))
            {
                sqlContent.Append("AND GaikankensaKomokuCd >= CAST(@gaikankensaKomokuCdFrom AS INT) AND GaikankensaKomokuCd <= CAST(@gaikankensaKomokuCdTo AS INT) ");
                commandParams.Add("@gaikankensaKomokuCdFrom", SqlDbType.Char).Value = gaikankensaKomokuCdFrom;
                commandParams.Add("@gaikankensaKomokuCdTo", SqlDbType.Char).Value = gaikankensaKomokuCdTo;
            }

            if (!String.IsNullOrEmpty(gaikankensaKomokuNm))
            {
                sqlContent.Append("AND GaikankensaKomokuNm LIKE concat('%', @gaikankensaKomokuNm, '%')     ");
                commandParams.Add("@gaikankensaKomokuNm", SqlDbType.VarChar).Value = gaikankensaKomokuNm;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     GaikankensaKomokuCd                                 ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
