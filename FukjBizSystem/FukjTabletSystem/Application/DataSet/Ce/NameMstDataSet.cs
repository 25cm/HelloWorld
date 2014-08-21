using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.SqlServerCe;

namespace FukjTabletSystem.Application.DataSet.Ce
{

    public partial class NameMstDataSet
    {
    }
}

namespace FukjTabletSystem.Application.DataSet.Ce.NameMstDataSetTableAdapters
{
    #region NameMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： NameMstKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/25　DatNT　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class NameMstKensakuTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameKbn"></param>
        /// <param name="nameCdFrom"></param>
        /// <param name="nameCdTo"></param>
        /// <param name="name"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/25　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal NameMstDataSet.NameMstKensakuDataTable GetDataBySearchCond(
            String nameKbn,
            String nameCdFrom,
            String nameCdTo,
            String name)
        {
            SqlCeCommand command = CreateNameMstKensakuSqlCommand(nameKbn, nameCdFrom, nameCdTo, name);

            SqlCeDataAdapter adpt = new SqlCeDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            NameMstDataSet.NameMstKensakuDataTable dataTable = new NameMstDataSet.NameMstKensakuDataTable();
            adpt.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region CreateNameMstKensakuSqlCommand
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： CreateNameMstKensakuSqlCommand
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameKbn"></param>
        /// <param name="nameCdFrom"></param>
        /// <param name="nameCdTo"></param>
        /// <param name="name"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCeCommand CreateNameMstKensakuSqlCommand(
            String nameKbn,
            String nameCdFrom,
            String nameCdTo,
            String name)
        {
            SqlCeCommand command = new SqlCeCommand();
            SqlCeParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                   ");
            sqlContent.Append("     NameKbn,                                            ");
            sqlContent.Append("     NameCd,                                             ");
            sqlContent.Append("     Name,                                               ");
            sqlContent.Append("     DeleteFlg,                                          ");
            sqlContent.Append("     InsertDt,                                           ");
            sqlContent.Append("     InsertUser,                                         ");
            sqlContent.Append("     InsertTarm,                                         ");
            sqlContent.Append("     UpdateDt,                                           ");
            sqlContent.Append("     UpdateUser,                                         ");
            sqlContent.Append("     UpdateTarm                                          ");

            // FROM
            sqlContent.Append("FROM                                                     ");
            sqlContent.Append("     NameMst                                             ");

            // WHERE
            sqlContent.Append("WHERE                                                    ");
            sqlContent.Append("     1 = 1                                               ");

            if (!String.IsNullOrEmpty(nameKbn))
            {
                sqlContent.Append("AND NameKbn = @nameKbn                                ");
                commandParams.Add("@nameKbn", SqlDbType.Char).Value = nameKbn;
            }
            else
            {
                sqlContent.Append("AND NameKbn <> '000'                                 ");
            }

            if (!String.IsNullOrEmpty(nameCdFrom) && !String.IsNullOrEmpty(nameCdTo))
            {
                sqlContent.Append("AND NameCd >= CAST(@nameCdFrom AS INT) AND NameCd <= CAST(@nameCdTo AS INT) ");
                commandParams.Add("@nameCdFrom", SqlDbType.Char).Value = nameCdFrom;
                commandParams.Add("@nameCdTo", SqlDbType.Char).Value = nameCdTo;
            }

            if (!String.IsNullOrEmpty(name))
            {
                sqlContent.Append("AND Name LIKE concat('%', @name, '%')                ");
                commandParams.Add("@name", SqlDbType.VarChar).Value = name;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     NameKbn, NameCd                                     ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}