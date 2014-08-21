using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {
    
    
    public partial class ShishoMstDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.ShishoMstDataSetTableAdapters
{
    #region ShishoMstTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ShishoMstTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/25　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class ShishoMstTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shishoCdFrom"></param>
        /// <param name="shishoCdTo"></param>
        /// <param name="shishoNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　AnhNV　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal ShishoMstDataSet.ShishoMstDataTable GetDataBySearchCond
            (
                string shishoCdFrom,
                string shishoCdTo,
                string shishoNm
            )
        {
            SqlCommand command = CreateSqlCommand(shishoCdFrom, shishoCdTo, shishoNm);
            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            ShishoMstDataSet.ShishoMstDataTable dataTable = new ShishoMstDataSet.ShishoMstDataTable();
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
        /// <param name="shishoCdFrom"></param>
        /// <param name="shishoCdTo"></param>
        /// <param name="shishoNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　AnhNV　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand
            (
                string shishoCdFrom,
                string shishoCdTo,
                string shishoNm
            )
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SQL content
            sqlContent.Append(" select                                             ");
            sqlContent.Append("     sm.ShishoCd,                                   ");
            sqlContent.Append("     sm.ShishoNm,                                   ");
            sqlContent.Append("     sm.ShishoZipCd,                                ");
            sqlContent.Append("     sm.ShishoAdr,                                  ");
            sqlContent.Append("     sm.ShishoTelNo,                                ");
            sqlContent.Append("     sm.ShishoFaxNo,                                ");
            sqlContent.Append("     sm.ShishoFreeDial,                             ");
            sqlContent.Append("     sm.InsertDt,                                   ");
            sqlContent.Append("     sm.InsertUser,                                 ");
            sqlContent.Append("     sm.InsertTarm,                                 ");
            sqlContent.Append("     sm.UpdateDt,                                   ");
            sqlContent.Append("     sm.UpdateUser,                                 ");
            sqlContent.Append("     sm.UpdateTarm                                  ");
            sqlContent.Append(" from ShishoMst sm                                  ");
            sqlContent.Append(" where 1 = 1                                        ");

            // 支所コード FROM ~ TO
            sqlContent.Append(" and sm.ShishoCd " + DataAccessUtility.SetBetweenCommand(shishoCdFrom, shishoCdTo, 1));

            //if (!string.IsNullOrEmpty(shishoCdFrom) && !string.IsNullOrEmpty(shishoCdTo))
            //{
            //    // 支所コード FROM ~ TO
            //    sqlContent.Append(" and cast(sm.ShishoCd as int) >= @shishoCdFrom and cast(sm.ShishoCd as int) <= @shishoCdTo");
            //    commandParams.Add("@shishoCdFrom", System.Data.SqlDbType.Int).Value = shishoCdFrom;
            //    commandParams.Add("@shishoCdTo", System.Data.SqlDbType.Int).Value = shishoCdTo;
            //}

            if (!string.IsNullOrEmpty(shishoNm))
            {
                // 支所名称
                sqlContent.Append(" and sm.ShishoNm like concat('%', @shishoNm, '%')");
                commandParams.Add("@shishoNm", System.Data.SqlDbType.VarChar).Value = shishoNm;
            }

            // ORDER BY
            sqlContent.Append(" order by sm.ShishoCd");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
namespace FukjBizSystem.Application.DataSet.ShishoMstDataSetTableAdapters
{

    
}
