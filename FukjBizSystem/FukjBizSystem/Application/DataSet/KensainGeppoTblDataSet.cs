using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {
        
    public partial class KensainGeppoTblDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.KensainGeppoTblDataSetTableAdapters
{

    #region KensainGeppoListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensainGeppoListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/20  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KensainGeppoListTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="taisyoYMFrom"></param>
        /// <param name="taisyoYMTo"></param>
        /// <param name="shishoCd"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal FileKanriTblDataSet.FileKanriTblKensakuDataTable GetDataBySearchCond(
            string taisyoYMFrom,
            string taisyoYMTo,
            string shishoCd)
        {
            SqlCommand command = CreateSqlCommand(taisyoYMFrom, taisyoYMTo, shishoCd);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            FileKanriTblDataSet.FileKanriTblKensakuDataTable dataTable = new FileKanriTblDataSet.FileKanriTblKensakuDataTable();
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
        /// <param name="taisyoYMFrom"></param>
        /// <param name="taisyoYMTo"></param>
        /// <param name="shishoCd"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            string taisyoYMFrom,
            string taisyoYMTo,
            string shishoCd)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                                       ");
            sqlContent.Append("     KensainGeppoTbl.ShukeiNengetsu,                                                         ");
            sqlContent.Append("     KensainGeppoTbl.KensainCd,                                                              ");
            sqlContent.Append("     KensainGeppoTbl.Kensa7JoCnt,                                                            ");
            sqlContent.Append("     KensainGeppoTbl.Kensa7JoAmt,                                                            ");
            sqlContent.Append("     KensainGeppoTbl.Kensa11JoCnt,                                                           ");
            sqlContent.Append("     KensainGeppoTbl.Kensa11JoAmt,                                                           ");
            sqlContent.Append("     KensainGeppoTbl.YakushokuFlg,                                                           ");
            sqlContent.Append("     ShokuinMst.ShokuinCd,                                                                   ");
            sqlContent.Append("     ShokuinMst.ShokuinShozokuShishoCd,                                                      ");
            sqlContent.Append("     ShokuinMst.ShokuinNm,                                                                   ");
            sqlContent.Append("     ShishoMst.ShishoNm                                                                      ");

            // FROM
            sqlContent.Append("FROM                                                                                         ");
            sqlContent.Append("     KensainGeppoTbl                                                                         ");
            sqlContent.Append("INNER JOIN                                                                                   ");
            sqlContent.Append("     ShokuinMst ON ShokuinMst.ShokuinCd = KensainGeppoTbl.KensainCd                          ");
            sqlContent.Append("INNER JOIN                                                                                   ");
            sqlContent.Append("     ShishoMst ON ShishoMst.ShishoCd = ShokuinMst.ShokuinShozokuShishoCd                     ");

            // WHERE
            sqlContent.Append("WHERE                                                                                        ");
            sqlContent.Append("     1 = 1                                                                                   ");

            sqlContent.Append("AND KensainGeppoTbl.ShukeiNengetsu " + DataAccessUtility.SetBetweenCommand(taisyoYMFrom, taisyoYMTo, 6));

            if (!string.IsNullOrEmpty(shishoCd))
            {
                sqlContent.Append("AND ShokuinMst.ShokuinShozokuShishoCd = @shishoCd                                        ");
                commandParams.Add("@shishoCd", SqlDbType.Char).Value = shishoCd;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY                                                                                     ");
            sqlContent.Append("     ShokuinMst.ShokuinShozokuShishoCd,                                                      ");
            sqlContent.Append("     KensainGeppoTbl.KensainCd,                                                              ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

}
