using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;
namespace FukjBizSystem.Application.DataSet {
    
    
    public partial class HoshoTorokuTblDataSet {
        partial class HoshoTorokuTblKensakuDataTable
        {
        }
    
        partial class HoshoTorokuTblDataTable
        {
        }
    }
}

namespace FukjBizSystem.Application.DataSet.HoshoTorokuTblDataSetTableAdapters
{
    #region HoshoTorokuTblKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： HoshoTorokuTblKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/17　HuyTX　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class HoshoTorokuTblKensakuTableAdapter {

        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="kenshakikanFrom"></param>
        /// <param name="kenshakikanTo"></param>
        /// <param name="nendoFrom"></param>
        /// <param name="nendoTo"></param>
        /// <param name="renbanFrom"></param>
        /// <param name="renbanTo"></param>
        /// <param name="kakuninDtFrom"></param>
        /// <param name="kakuninDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/17　HuyTX　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal HoshoTorokuTblDataSet.HoshoTorokuTblKensakuDataTable GetDataBySearchCond(
            string kenshakikanFrom, 
            string kenshakikanTo, 
            string nendoFrom, 
            string nendoTo, 
            string renbanFrom, 
            string renbanTo,
            string kakuninDtFrom,
            string kakuninDtTo
            )
        {
            SqlCommand command = CreateSqlCommand(kenshakikanFrom, kenshakikanTo, nendoFrom, nendoTo, renbanFrom, renbanTo, kakuninDtFrom, kakuninDtTo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            HoshoTorokuTblDataSet.HoshoTorokuTblKensakuDataTable dataTable = new HoshoTorokuTblDataSet.HoshoTorokuTblKensakuDataTable();
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
        /// <param name="kenshakikanFrom"></param>
        /// <param name="kenshakikanTo"></param>
        /// <param name="nendoFrom"></param>
        /// <param name="nendoTo"></param>
        /// <param name="renbanFrom"></param>
        /// <param name="renbanTo"></param>
        /// <param name="kakuninDtFrom"></param>
        /// <param name="kakuninDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/17　HuyTX　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            string kenshakikanFrom,
            string kenshakikanTo,
            string nendoFrom,
            string nendoTo,
            string renbanFrom,
            string renbanTo,
            string kakuninDtFrom,
            string kakuninDtTo
            )
        {
            SqlCommand command = new SqlCommand();

            StringBuilder sqlContent = new StringBuilder();

            //SELECT
            sqlContent.Append("SELECT                                                                                                                                                                         ");

            sqlContent.Append("htt.HoshoTorokuKensakikan,                                                                                                                                                     ");
            sqlContent.Append("htt.HoshoTorokuNendo,                                                                                                                                                          ");
            sqlContent.Append("htt.HoshoTorokuRenban,                                                                                                                                                         ");
            sqlContent.Append("gm1.GyoshaCd AS HoshoTorokuKojiGyosha,                                                                                                                                         ");
            sqlContent.Append("gm1.GyoshaNm,                                                                                                                                                                  ");
            sqlContent.Append("gm1.GyoshaAdr,                                                                                                                                                                 ");
            sqlContent.Append("gm1.GyoshaTelNo,                                                                                                                                                               ");
            sqlContent.Append("gm1.KoujiTorokuNo,                                                                                                                                                             ");
            sqlContent.Append("htt.HoshoTorokuSetchishaKana,                                                                                                                                                  ");
            sqlContent.Append("htt.HoshoTorokuSetchishaNm,                                                                                                                                                    ");
            sqlContent.Append("htt.HoshoTorokuSetchishaZipCd,                                                                                                                                                 ");
            sqlContent.Append("htt.HoshoTorokuSetchishaAdr,                                                                                                                                                   ");
            sqlContent.Append("htt.HoshoTorokuSetchibashoZipCd,                                                                                                                                               ");
            sqlContent.Append("htt.HoshoTorokuSetchibashoAdr,                                                                                                                                                 ");
            sqlContent.Append("htt.HoshoTorokuTatemonoyoto,                                                                                                                                                   ");
            sqlContent.Append("htt.HoshoTorokuHojoShichosonCd ,                                                                                                                                               ");
            sqlContent.Append("htt.HoshoTorokuJokasoTorokuNo ,                                                                                                                                                ");
            sqlContent.Append("jm.JokasoKatashikiNm,                                                                                                                                                          ");

            sqlContent.Append("CASE WHEN ISNULL(jm.JokasoTorokuDt, '') = '' THEN '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME, jm.JokasoTorokuDt), 111) END as JokasoTorokuDt,                                  ");
            sqlContent.Append("htt.HoshoTorokuNinso,                                                                                                                                                          ");
            sqlContent.Append("gm2.GyoshaCd AS HoshoTorokuMakerCd,                                                                                                                                            ");
            sqlContent.Append("gm2.GyoshaNm AS SeizogyoshaNm,                                                                                                                                                 ");
            sqlContent.Append("htt.HoshoTorokuJokasoKensakikan,                                                                                                                                               ");
            sqlContent.Append("hkm.JimukyokuNm,                                                                                                                                                               ");
            sqlContent.Append("CASE WHEN ISNULL(htt.HoshoTorokuShiyokaishiDt, '') = '' THEN '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME, htt.HoshoTorokuShiyokaishiDt), 111) END as HoshoTorokuShiyokaishiDt,  ");
            sqlContent.Append("htt.HoshoTorokuHokenjoCd,                                                                                                                                                      ");
            sqlContent.Append("htt.HoshoTorokuHokenjoNendo,                                                                                                                                                   ");
            sqlContent.Append("htt.HoshoTorokuHokenjoShichosonCd,                                                                                                                                             ");
            sqlContent.Append("htt.HoshoTorokuHokenjoRenban,                                                                                                                                                  ");
            sqlContent.Append("CASE WHEN ISNULL(htt.HoshoTorokuJyuriDt, '') = '' THEN '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME, htt.HoshoTorokuJyuriDt), 111) END as HoshoTorokuJyuriDt,                      ");
            sqlContent.Append("CASE WHEN ISNULL(htt.HoshoTorokuTorokuKakuninDt, '') = '' THEN '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME, htt.HoshoTorokuTorokuKakuninDt), 111) END as HoshoTorokuTorokuKakuninDt  ");

            //FROM
            sqlContent.Append("FROM HoshoTorokuTbl htt                                                                                  ");

            //JOIN
            sqlContent.Append("LEFT JOIN GyoshaMst gm1 ON htt.HoshoTorokuKojiGyosha = gm1.GyoshaCd AND gm1.KojiGyoshaKbn = '1'          ");
            sqlContent.Append("LEFT JOIN JokasoMst jm ON htt.HoshoTorokuJokasoTorokuNo = jm.JokasoTorokuNo                              ");
            sqlContent.Append("LEFT JOIN GyoshaMst gm2 ON htt.HoshoTorokuMakerCd = gm2.GyoshaCd AND gm2.SeizoGyoShaKbn = '1'            ");
            sqlContent.Append("LEFT JOIN HoteiKanriMst hkm ON htt.HoshoTorokuJokasoKensakikan = hkm.JimukyokuKbn                        ");

            //WHERE
            sqlContent.Append("WHERE htt.HoshoTorokuDeleteFlg = 0                                                    ");

            sqlContent.Append(" AND                                                                                  ");

            //search by HoshoTorokuNo
            sqlContent.Append("CONCAT(htt.HoshoTorokuKensakikan,                                                     ");
            sqlContent.Append("REPLACE(STR(htt.HoshoTorokuNendo - 1988, 2), SPACE(1), '0'),                          ");
            sqlContent.Append("REPLACE(STR(htt.HoshoTorokuRenban, 5), SPACE(1), '0'))                                ");
                
            sqlContent.Append(DataAccessUtility.SetBetweenCommand(string.Concat(kenshakikanFrom, nendoFrom, renbanFrom), string.Concat(kenshakikanTo, nendoTo, renbanTo), 11));


            if (!string.IsNullOrEmpty(kakuninDtFrom) && !string.IsNullOrEmpty(kakuninDtTo))
            {
                sqlContent.Append(" AND htt.HoshoTorokuTorokuKakuninDt BETWEEN @kakuninFrom AND @kakuninTo              ");
                command.Parameters.Add("@kakuninFrom", SqlDbType.Char).Value = kakuninDtFrom;
                command.Parameters.Add("@kakuninTo", SqlDbType.Char).Value = kakuninDtTo;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY                                                                                 ");
            sqlContent.Append("         htt.HoshoTorokuKensakikan, htt.HoshoTorokuNendo, htt.HoshoTorokuRenban          ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}

