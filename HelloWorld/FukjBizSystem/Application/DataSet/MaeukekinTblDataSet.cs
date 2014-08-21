using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {
    
    public partial class MaeukekinTblDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.MaeukekinTblDataSetTableAdapters
{
    #region MaeukekinTblKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： MaeukekinTblKensakuTableAdapter
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
    public partial class MaeukekinTblKensakuTableAdapter 
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saibanKbn"></param>
        /// <param name="maeukeNoFrom"></param>
        /// <param name="maeukeNoTo"></param>
        /// <param name="furikomininNm"></param>
        /// <param name="nyukinDtUse"></param>
        /// <param name="nyukinDtFrom"></param>
        /// <param name="nyukinDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal MaeukekinTblDataSet.MaeukekinTblKensakuDataTable GetDataBySearchCond(
            String saibanKbn,
            String maeukeNoFrom,
            String maeukeNoTo,
            String furikomininNm,
            bool nyukinDtUse,
            String nyukinDtFrom,
            String nyukinDtTo)
        {
            SqlCommand command = CreateSqlCommand(saibanKbn, maeukeNoFrom, maeukeNoTo, furikomininNm, nyukinDtUse, nyukinDtFrom, nyukinDtTo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            MaeukekinTblDataSet.MaeukekinTblKensakuDataTable dataTable = new MaeukekinTblDataSet.MaeukekinTblKensakuDataTable();
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
        /// <param name="saibanKbn"></param>
        /// <param name="maeukeNoFrom"></param>
        /// <param name="maeukeNoTo"></param>
        /// <param name="furikomininNm"></param>
        /// <param name="nyukinDtUse"></param>
        /// <param name="nyukinDtFrom"></param>
        /// <param name="nyukinDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            String saibanKbn,
            String maeukeNoFrom,
            String maeukeNoTo,
            String furikomininNm,
            bool nyukinDtUse,
            String nyukinDtFrom,
            String nyukinDtTo)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                                                   ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinSyogoNo1,                                                                     ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinSyogoNo2,                                                                     ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinNyukinDt,                                                                     ");
            
            sqlContent.Append("     CASE                                                                                                ");
            sqlContent.Append("         WHEN ISNULL(MaeukekinTbl.MaeukekinNyukinDt, '') = '' THEN ''                                    ");
            sqlContent.Append("         ELSE CONCAT(                                                                                    ");
            sqlContent.Append("                 SUBSTRING(MaeukekinTbl.MaeukekinNyukinDt,0,5), '/',                                     ");
            sqlContent.Append("                 SUBSTRING(MaeukekinTbl.MaeukekinNyukinDt,5,2), '/',                                     ");
            sqlContent.Append("                 SUBSTRING(MaeukekinTbl.MaeukekinNyukinDt,7,2)) END AS MaeukekinNyukinDtCol,             ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinNyukinAmt,                                                                    ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinFurikomininNm,                                                                ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinFurikomininKana,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinBiko,                                                                         ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinUriageDt,                                                                     ");
            sqlContent.Append("     CASE                                                                                                ");
            sqlContent.Append("         WHEN ISNULL(MaeukekinTbl.MaeukekinUriageDt, '') = '' THEN ''                                    ");
            sqlContent.Append("         ELSE CONCAT(                                                                                    ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinUriageDt,0,5), '/',                                         ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinUriageDt,5,2), '/',                                         ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinUriageDt,7,2)) END AS MaeukekinUriageDtCol,                 ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinTorisageDt,                                                                   ");
            sqlContent.Append("     CASE                                                                                                ");
            sqlContent.Append("         WHEN ISNULL(MaeukekinTbl.MaeukekinTorisageDt, '') = '' THEN ''                                  ");
            sqlContent.Append("         ELSE CONCAT(                                                                                    ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinTorisageDt,0,5), '/',                                       ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinTorisageDt,5,2), '/',                                       ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinTorisageDt,7,2)) END AS MaeukekinTorisageDtCol,             ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKensaIraiHoteiKbn,                                                            ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKensaIraiHokenjoCd,                                                           ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKensaIraiNendo,                                                               ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKensaIraiRenban,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKyoseiUriageAmt,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinKyoseiUriageFlg,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinNyukintoriatukaiDt,                                                           ");
            sqlContent.Append("     CASE                                                                                                ");
            sqlContent.Append("         WHEN ISNULL(MaeukekinTbl.MaeukekinNyukintoriatukaiDt, '') = '' THEN ''                          ");
            sqlContent.Append("         ELSE CONCAT(                                                                                    ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinNyukintoriatukaiDt,0,5), '/',                               ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinNyukintoriatukaiDt,5,2), '/',                               ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinNyukintoriatukaiDt,7,2)) END AS MaeukekinNyukintoriatukaiDtCol, ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinIchibuHenkinDt,                                                               ");
            sqlContent.Append("     CASE                                                                                                ");
            sqlContent.Append("         WHEN ISNULL(MaeukekinTbl.MaeukekinIchibuHenkinDt, '') = '' THEN ''                              ");
            sqlContent.Append("         ELSE CONCAT(                                                                                    ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinIchibuHenkinDt,0,5), '/',                                   ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinIchibuHenkinDt,5,2), '/',                                   ");
            sqlContent.Append("             SUBSTRING(MaeukekinTbl.MaeukekinIchibuHenkinDt,7,2)) END AS MaeukekinIchibuHenkinDtCol,     ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinIchibuHenkinAmt,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinZanAmt,                                                                       ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinJokasoHokenjoCd,                                                              ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinJokasoTorokuNengetsu,                                                         ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinJokasoRenban,                                                                 ");
            sqlContent.Append("     NameMst.Name                                                                                        ");

            // FROM
            sqlContent.Append("FROM                                                                                                     ");
            sqlContent.Append("     MaeukekinTbl                                                                                        ");
            sqlContent.Append("INNER JOIN                                                                                               ");
            sqlContent.Append("     NameMst                                                                                             ");
            sqlContent.Append("         ON NameMst.NameCd = MaeukekinTbl.MaeukekinKinyukikan                                            ");
            sqlContent.Append("         AND NameMst.NameKbn = '006'                                                                     ");
            // WHERE
            sqlContent.Append("WHERE                                                                                                    ");
            sqlContent.Append("     1 = 1                                                                                               ");

            if (!string.IsNullOrEmpty(saibanKbn))
            {
                if (saibanKbn == "0")
                {
                    sqlContent.Append(" AND MaeukekinSyogoNo1 = '0'                                                                     ");
                }
                else if (saibanKbn == "1")
                {
                    sqlContent.Append(" AND MaeukekinSyogoNo1 = '1'                                                                     ");
                }
            }

            sqlContent.Append("AND MaeukekinTbl.MaeukekinSyogoNo2 " + DataAccessUtility.SetBetweenCommand(maeukeNoFrom, maeukeNoTo, 6));
            //if (!String.IsNullOrEmpty(maeukeNoFrom) && !String.IsNullOrEmpty(maeukeNoTo))
            //{
            //    sqlContent.Append("AND MaeukekinTbl.MaeukekinSyogoNo2 >= CAST(@maeukeNoFrom AS INT) AND MaeukekinTbl.MaeukekinSyogoNo2 <= CAST(@maeukeNoTo AS INT) ");
            //    commandParams.Add("@maeukeNoFrom", SqlDbType.Char).Value = maeukeNoFrom;
            //    commandParams.Add("@maeukeNoTo", SqlDbType.Char).Value = maeukeNoTo;
            //}

            if (!String.IsNullOrEmpty(furikomininNm))
            {
                sqlContent.Append("AND MaeukekinTbl.MaeukekinFurikomininNm LIKE CONCAT('%', @furikomininNm, '%')     ");
                commandParams.Add("@furikomininNm", SqlDbType.VarChar).Value = furikomininNm;
            }

            if (nyukinDtUse)
            {
                sqlContent.Append("AND MaeukekinTbl.MaeukekinNyukinDt >= CAST(@nyukinDtFrom AS INT) AND MaeukekinTbl.MaeukekinNyukinDt <= CAST(@nyukinDtTo AS INT) ");
                commandParams.Add("@nyukinDtFrom", SqlDbType.Char).Value = nyukinDtFrom;
                commandParams.Add("@nyukinDtTo", SqlDbType.Char).Value = nyukinDtTo;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinSyogoNo1,                                                             ");
            sqlContent.Append("     MaeukekinTbl.MaeukekinSyogoNo2                                                              ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
