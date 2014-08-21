using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FukjBizSystem.Application.DataSet {
       
    public partial class MemoMstDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.MemoMstDataSetTableAdapters
{

    #region MemoMstKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： MemoMstKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/12  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class MemoMstKensakuTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memoDaibunruiCd"></param>
        /// <param name="memo"></param>
        /// <param name="juyo"></param>
        /// <param name="hutsu"></param>
        /// <param name="sentakuKa"></param>
        /// <param name="sentakuHuka"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal MemoMstDataSet.MemoMstKensakuDataTable GetDataBySearchCond(
            string memoDaibunruiCd,
            string memo,
            bool juyo,
            bool hutsu,
            bool sentakuKa,
            bool sentakuHuka)
        {
            SqlCommand command = CreateSqlCommand(memoDaibunruiCd, memo, juyo, hutsu, sentakuKa, sentakuHuka);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            MemoMstDataSet.MemoMstKensakuDataTable dataTable = new MemoMstDataSet.MemoMstKensakuDataTable();
            adpt.Fill(dataTable);

            return dataTable;
        }
        #endregion

        #region CreateSqlCommand
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： CreateHokenjoMstKensakuSqlCommand
        /// <summary>
        /// 
        /// </summary>
        /// <param name="memoDaibunruiCd"></param>
        /// <param name="memo"></param>
        /// <param name="juyo"></param>
        /// <param name="hutsu"></param>
        /// <param name="sentakuKa"></param>
        /// <param name="sentakuHuka"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            string memoDaibunruiCd,
            string memo,
            bool juyo,
            bool hutsu,
            bool sentakuKa,
            bool sentakuHuka)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                                                   ");
            sqlContent.Append("     MemoMst.MemoDaibunruiCd,                                                                            ");
            sqlContent.Append("     MemoMst.MemoCd,                                                                                     ");
            sqlContent.Append("     MemoMst.Memo,                                                                                       ");
            sqlContent.Append("     MemoMst.MemoJuyoFlg,                                                                                ");
            sqlContent.Append("     MemoMst.MemoSelectFlg,                                                                              ");
            sqlContent.Append("     MemoDaibunruiMst.MemoDaibunruiNm                                                                                        ");

            // FROM
            sqlContent.Append("FROM                                                                                                     ");
            sqlContent.Append("     MemoMst                                                                                             ");
            sqlContent.Append("LEFT OUTER JOIN                                                                                          ");
            sqlContent.Append("     MemoDaibunruiMst                                                                                    ");
            sqlContent.Append("         ON MemoDaibunruiMst.MemoDaibunruiCd = MemoMst.MemoDaibunruiCd                                   ");

            // WHERE
            sqlContent.Append("WHERE                                                                                                    ");
            sqlContent.Append("     1 = 1                                                                                               ");

            if (!string.IsNullOrEmpty(memoDaibunruiCd))
            {
                sqlContent.Append("AND MemoDaibunruiMst.MemoDaibunruiCd = @memoDaibunruiCd ");
                commandParams.Add("@memoDaibunruiCd", SqlDbType.Char).Value = memoDaibunruiCd;
            }

            if (!string.IsNullOrEmpty(memo))
            {
                sqlContent.Append("AND MemoMst.Memo LIKE CONCAT('%', @memo, '%')     ");
                commandParams.Add("@memo", SqlDbType.NVarChar).Value = memo;
            }

            if (juyo && !hutsu)
            {
                sqlContent.Append("AND MemoMst.MemoJuyoFlg = '1' ");
            }
            else if (!juyo && hutsu)
            {
                sqlContent.Append("AND MemoMst.MemoJuyoFlg = '0' ");
            }
            if ((juyo && hutsu) || (!juyo && !hutsu))
            {
                sqlContent.Append("AND (MemoMst.MemoJuyoFlg = '1' OR MemoMst.MemoJuyoFlg = '0') ");
            }

            if (sentakuKa && !sentakuHuka)
            {
                sqlContent.Append("AND MemoMst.MemoSelectFlg = '0' ");
            }
            else if (!sentakuKa && sentakuHuka)
            {
                sqlContent.Append("AND MemoMst.MemoSelectFlg = '1' ");
            }
            if ((sentakuKa && sentakuHuka) || (!sentakuKa && !sentakuHuka))
            {
                sqlContent.Append("AND (MemoMst.MemoSelectFlg = '0' OR MemoMst.MemoSelectFlg = '1') ");
            }
            
            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     MemoMst.MemoDaibunruiCd,                                                                            ");
            sqlContent.Append("     MemoMst.MemoCd                                                                                      ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

}
