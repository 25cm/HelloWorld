﻿using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet
{
    public partial class SuishitsuKensaSetMstDataSet
    {
    }

}

namespace FukjBizSystem.Application.DataSet.SuishitsuKensaSetMstDataSetTableAdapters
{
    #region SuishitsuKensaSetMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SuishitsuKensaSetMstKensakuTableAdapter
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
    public partial class SuishitsuKensaSetMstKensakuTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="setCdFrom"></param>
        /// <param name="setCdTo"></param>
        /// <param name="setNm"></param>
        /// <param name="setNmRyakusho"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal SuishitsuKensaSetMstDataSet.SuishitsuKensaSetMstKensakuDataTable GetDataBySearchCond(
            String setCdFrom,
            String setCdTo,
            String setNm,
            String setNmRyakusho)
        {
            SqlCommand command = CreateSqlCommand(setCdFrom, setCdTo, setNm, setNmRyakusho);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            SuishitsuKensaSetMstDataSet.SuishitsuKensaSetMstKensakuDataTable dataTable = new SuishitsuKensaSetMstDataSet.SuishitsuKensaSetMstKensakuDataTable();
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
        /// <param name="setCdFrom"></param>
        /// <param name="setCdTo"></param>
        /// <param name="setNm"></param>
        /// <param name="setNmRyakusho"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            String setCdFrom,
            String setCdTo,
            String setNm,
            String setNmRyakusho)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                   ");
            sqlContent.Append("     SetCd,                                              ");
            sqlContent.Append("     SetRyoukin,                                         ");
            sqlContent.Append("     SetNm,                                              ");
            sqlContent.Append("     SetNmRyakusho,                                      ");
            sqlContent.Append("     InsertDt,                                           ");
            sqlContent.Append("     InsertUser,                                         ");
            sqlContent.Append("     InsertTarm,                                         ");
            sqlContent.Append("     UpdateDt,                                           ");
            sqlContent.Append("     UpdateUser,                                         ");
            sqlContent.Append("     UpdateTarm                                          ");

            // FROM
            sqlContent.Append("FROM                                                     ");
            sqlContent.Append("     SuishitsuKensaSetMst                                ");

            // WHERE
            sqlContent.Append("WHERE                                                    ");
            sqlContent.Append("     1 = 1                                               ");

            sqlContent.Append("AND SetCd " + DataAccessUtility.SetBetweenCommand(setCdFrom, setCdTo, 3));

            if (!String.IsNullOrEmpty(setNm))
            {
                sqlContent.Append("AND SetNm LIKE concat('%', @setNm, '%')     ");
                commandParams.Add("@setNm", SqlDbType.VarChar).Value = setNm;
            }

            if (!String.IsNullOrEmpty(setNmRyakusho))
            {
                sqlContent.Append("AND SetNmRyakusho LIKE concat('%', @setNmRyakusho, '%')     ");
                commandParams.Add("@setNmRyakusho", SqlDbType.VarChar).Value = setNmRyakusho;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     SetCd                                               ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}