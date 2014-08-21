using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;
namespace FukjBizSystem.Application.DataSet
{
    public partial class KensaIraiTblDataSet
    {
    }
}

namespace FukjBizSystem.Application.DataSet.KensaIraiTblDataSetTableAdapters
{
    #region KensaIraiTblKensakuTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensaIraiTblKensakuTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KensaIraiTblKensakuTableAdapter
    {

        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hokenjoCd"></param>
        /// <param name="kensaIraiNendo"></param>
        /// <param name="kensaIraiSetchishaNm"></param>
        /// <param name="kensaIraiShisetsuNm"></param>
        /// <param name="kensaIraiDtFrom"></param>
        /// <param name="kensaIraiDtTo"></param>
        /// <param name="kensaDtFrom"></param>
        /// <param name="kensaDtTo"></param>
        /// <param name="kensaIraiHoteiKbn"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal KensaIraiTblDataSet.KensaIraiTblKensakuDataTable GetDataBySearchCond(string hokenjoCd,
            string kensaIraiNendo,
            string kensaIraiSetchishaNm,
            string kensaIraiShisetsuNm,
            string kensaIraiDtFrom,
            string kensaIraiDtTo,
            string kensaDtFrom,
            string kensaDtTo,
            string kensaIraiHoteiKbn)
        {
            SqlCommand command = CreateSqlCommand(hokenjoCd,
                                                    kensaIraiNendo,
                                                    kensaIraiSetchishaNm,
                                                    kensaIraiShisetsuNm,
                                                    kensaIraiDtFrom,
                                                    kensaIraiDtTo,
                                                    kensaDtFrom,
                                                    kensaDtTo,
                                                    kensaIraiHoteiKbn);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            KensaIraiTblDataSet.KensaIraiTblKensakuDataTable dataTable = new KensaIraiTblDataSet.KensaIraiTblKensakuDataTable();
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
        /// <param name="hokenjoCd"></param>
        /// <param name="kensaIraiNendo"></param>
        /// <param name="kensaIraiSetchishaNm"></param>
        /// <param name="kensaIraiShisetsuNm"></param>
        /// <param name="kensaIraiDtFrom"></param>
        /// <param name="kensaIraiDtTo"></param>
        /// <param name="kensaDtFrom"></param>
        /// <param name="kensaDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(string hokenjoCd,
            string kensaIraiNendo,
            string kensaIraiSetchishaNm,
            string kensaIraiShisetsuNm,
            string kensaIraiDtFrom,
            string kensaIraiDtTo,
            string kensaDtFrom,
            string kensaDtTo,
            string kensaIraiHoteiKbn)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            //SELECT
            sqlContent.Append(" SELECT                                                                                   ");
            //sqlContent.Append(" (CASE kit.KensaIraiHoteiKbn                                                              ");
            //sqlContent.Append(" WHEN 1 THEN '7条'                                                                        ");
            //sqlContent.Append(" WHEN 2 THEN '11条'                                                                       ");
            //sqlContent.Append(" WHEN 3 THEN '11条'                                                                       ");
            //sqlContent.Append(" END) AS KensaIraiHoteiKbn,                                                               ");
            sqlContent.Append(" kit.KensaIraiHoteiKbn,                                                                   ");
            sqlContent.Append(" cm.ConstNm,                                                                              ");
            sqlContent.Append(" kit.KensaIraiHokenjoCd,                                                                  ");
            sqlContent.Append(" hm.HokenjoNm,                                                                            ");
            sqlContent.Append(" kit.KensaIraiNendo,                                                                      ");
            sqlContent.Append(" kit.KensaIraiRenban,                                                                     ");
            sqlContent.Append(" (CASE WHEN ISDATE(CONCAT(kit.KensaIraiNen,kit.KensaIraiTsuki,kit.KensaIraiBi)) = 0 then '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME,CONCAT(kit.KensaIraiNen,kit.KensaIraiTsuki,kit.KensaIraiBi)), 111) END) AS KensaIraiDt, ");
            sqlContent.Append(" (CASE WHEN ISDATE(CONCAT(kit.KensaIraiKensaNen,kit.KensaIraiKensaTsuki,kit.KensaIraiKensaBi)) = 0 then '' ELSE CONVERT(CHAR(10), CONVERT(DATETIME,CONCAT(kit.KensaIraiKensaNen,kit.KensaIraiKensaTsuki,kit.KensaIraiKensaBi)), 111) END) AS KensaDt, ");
            sqlContent.Append(" kit.KensaIraiSetchishaNm,                                                                ");
            sqlContent.Append(" kit.KensaIraiShisetsuNm,                                                                 ");
            sqlContent.Append(" kit.KensaIraiSetchibashoAdr,                                                             ");
            sqlContent.Append(" (CASE kkt.KensaKekkaHantei                                                               ");
			sqlContent.Append("     WHEN 1 THEN '〇'                                                                     ");
			sqlContent.Append("     WHEN 2 THEN '△'                                                                     ");
			sqlContent.Append("     WHEN 3 THEN '×'                                                                      ");
            sqlContent.Append(" END) AS KensaKekkaHantei                                                                 ");

            //FROM
            sqlContent.Append(" FROM KensaIraiTbl kit LEFT JOIN HokenjoMst hm ON kit.KensaIraiHokenjoCd = hm.HokenjoCd   ");
            sqlContent.Append(" LEFT JOIN KensaKekkaTbl kkt                                                              ");
            sqlContent.Append(" ON kit.KensaIraiHoteiKbn = kkt.KensaKekkaIraiHoteiKbn                                    ");
            sqlContent.Append(" AND kit.KensaIraiHokenjoCd = kkt.KensaKekkaIraiHokenjoCd                                 ");
            sqlContent.Append(" AND kit.KensaIraiNendo = kkt.KensaKekkaIraiNendo                                         ");
            sqlContent.Append(" AND kit.KensaIraiRenban = kkt.KensaKekkaIraiRenban                                       ");
            sqlContent.Append(" LEFT JOIN ConstMst cm ON kit.KensaIraiHoteiKbn = cm.ConstValue AND cm.ConstKbn = '006'   ");

            //WHERE
            sqlContent.Append(" WHERE 1 = 1 ");

            //検査区分
            if (!string.IsNullOrEmpty(kensaIraiHoteiKbn))
            {
                sqlContent.Append(" AND kit.KensaIraiHoteiKbn = @kensaIraiHoteiKbn                                       ");
                commandParams.Add("@kensaIraiHoteiKbn", SqlDbType.Char).Value = kensaIraiHoteiKbn;
            }

            //保健所コード
            if (!string.IsNullOrEmpty(hokenjoCd))
            {
                sqlContent.Append(" AND kit.KensaIraiHokenjoCd = @kensaIraiHokenjoCd ");
                commandParams.Add("@kensaIraiHokenjoCd", SqlDbType.Char).Value = hokenjoCd;
            }

            //検査依頼年度 
            if (!string.IsNullOrEmpty(kensaIraiNendo))
            {
                sqlContent.Append(" AND kit.KensaIraiNendo = @kensaIraiNendo ");
                commandParams.Add("@kensaIraiNendo", SqlDbType.Char).Value = kensaIraiNendo;
            }

            //設置者名（漢字） 
            if (!string.IsNullOrEmpty(kensaIraiSetchishaNm))
            {
                sqlContent.Append(" AND kit.KensaIraiSetchishaNm LIKE CONCAT('%', @kensaIraiSetchishaNm, '%') ");
                commandParams.Add("@kensaIraiSetchishaNm", SqlDbType.Char).Value = kensaIraiSetchishaNm;
            }

            //施設名称 
            if (!string.IsNullOrEmpty(kensaIraiShisetsuNm))
            {
                sqlContent.Append(" AND kit.KensaIraiShisetsuNm LIKE CONCAT('%', @kensaIraiShisetsuNm, '%') ");
                commandParams.Add("@kensaIraiShisetsuNm", SqlDbType.Char).Value = kensaIraiShisetsuNm;
            }

            //検査依頼日
            sqlContent.Append(" AND CONCAT(REPLACE(STR(kit.KensaIraiNen, 4), SPACE(1), '0'), ");
            sqlContent.Append(" REPLACE(STR(kit.KensaIraiTsuki, 2), SPACE(1), '0'),  ");
            sqlContent.Append(" REPLACE(STR(kit.KensaIraiBi, 2), SPACE(1), '0')) " + DataAccessUtility.SetBetweenCommand(kensaIraiDtFrom, kensaIraiDtTo, 8));

            //検査日
            sqlContent.Append(" AND CONCAT(REPLACE(STR(kit.KensaIraiKensaNen, 4), SPACE(1), '0'), ");
            sqlContent.Append(" REPLACE(STR(kit.KensaIraiKensaTsuki, 2), SPACE(1), '0'),  ");
            sqlContent.Append(" REPLACE(STR(kit.KensaIraiKensaBi, 2), SPACE(1), '0')) " + DataAccessUtility.SetBetweenCommand(kensaDtFrom, kensaDtTo, 8));

            // ORDER BY
            sqlContent.Append("ORDER BY kit.KensaIraiHoteiKbn, ");
            sqlContent.Append(" kit.KensaIraiHokenjoCd, ");
            sqlContent.Append(" kit.KensaIraiNendo, ");
            sqlContent.Append(" kit.KensaIraiRenban ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

    #region KensaJokyoListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensaJokyoListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/18　HuyTX　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    partial class KensaJokyoListTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="kensaIraiHoteiKbn"></param>
        /// <param name="jokasoSetchishaNm"></param>
        /// <param name="jokasoShisetsuNm"></param>
        /// <param name="settisyaCd"></param>
        /// <param name="kensaIraiDtFrom"></param>
        /// <param name="kensaIraiDtTo"></param>
        /// <param name="kensaDtFrom"></param>
        /// <param name="kensaDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18　HuyTX　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal KensaIraiTblDataSet.KensaJokyoListDataTable GetDataBySearchCond(
            List<string> kensaIraiHoteiKbn,
            string jokasoSetchishaNm,
            string jokasoShisetsuNm,
            string settisyaCd,
            string kensaIraiDtFrom,
            string kensaIraiDtTo,
            string kensaDtFrom,
            string kensaDtTo)
        {
            SqlCommand command = CreateSqlCommand(kensaIraiHoteiKbn,
                                                    jokasoSetchishaNm,
                                                    jokasoShisetsuNm,
                                                    settisyaCd,
                                                    kensaIraiDtFrom,
                                                    kensaIraiDtTo,
                                                    kensaDtFrom,
                                                    kensaDtTo);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            KensaIraiTblDataSet.KensaJokyoListDataTable dataTable = new KensaIraiTblDataSet.KensaJokyoListDataTable();
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
        /// <param name="kensaIraiHoteiKbn"></param>
        /// <param name="jokasoSetchishaNm"></param>
        /// <param name="jokasoShisetsuNm"></param>
        /// <param name="settisyaCd"></param>
        /// <param name="kensaIraiDtFrom"></param>
        /// <param name="kensaIraiDtTo"></param>
        /// <param name="kensaDtFrom"></param>
        /// <param name="kensaDtTo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18　HuyTX　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            List<string> kensaIraiHoteiKbn,
            string jokasoSetchishaNm,
            string jokasoShisetsuNm,
            string settisyaCd,
            string kensaIraiDtFrom,
            string kensaIraiDtTo,
            string kensaDtFrom,
            string kensaDtTo)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;
            StringBuilder sqlContent = new StringBuilder();

            string hoteiKbn = string.Empty;
            bool isSearchKensaDt = false;

            //get kensaIraiHoteiKbn
            foreach (var item in kensaIraiHoteiKbn)
            {
                hoteiKbn += "'" + item.ToString() + "', ";
            }

            sqlContent.Append(" SELECT * FROM  ");
            sqlContent.Append(" ( ");
            sqlContent.Append(" 		SELECT kit.KensaIraiHoteiKbn AS KensaIraiHoteiKbn, ");
            sqlContent.Append(" 				cm.ConstNm AS ConstNm, ");
            sqlContent.Append(" 				CONCAT(kit.KensaIraiJokasoHokenjoCd, '-', REPLACE(STR(kit.KensaIraiJokasoTorokuNendo - 1988, 2), SPACE(1), '0'), '-', kit.KensaIraiJokasoRenban) AS JokasoCd, ");
            sqlContent.Append(" 				jdm.JokasoSetchishaNm AS JokasoSetchishaNm, ");
            sqlContent.Append(" 				jdm.JokasoShisetsuNm AS JokasoShisetsuNm , ");
            sqlContent.Append(" 				hm.HokenjoNm AS HokenjoNm, ");
            sqlContent.Append(" 				(CASE ");
            sqlContent.Append(" 					WHEN ISDATE(CONCAT(kit.KensaIraiNen,kit.KensaIraiTsuki,kit.KensaIraiBi)) = 0 THEN '' ");
            sqlContent.Append(" 					ELSE CONVERT(CHAR(10), CONVERT(DATETIME,CONCAT(kit.KensaIraiNen,kit.KensaIraiTsuki,kit.KensaIraiBi)), 111) ");
            sqlContent.Append(" 				END) AS KensaIraiDt, ");
            sqlContent.Append(" 				CASE  ");
            sqlContent.Append(" 					WHEN ISNULL(kit.KensaIraiSuishitsuUketsukeDt, '') = '' THEN ''  ");
            sqlContent.Append(" 					ELSE CONVERT(CHAR(10), CONVERT(DATETIME, kit.KensaIraiSuishitsuUketsukeDt), 111)  ");
            sqlContent.Append(" 				END AS KensaUketsukeDt, ");
            sqlContent.Append(" 				(CASE ");
            sqlContent.Append(" 					WHEN ISDATE(CONCAT(kit.KensaIraiKensaNen,kit.KensaIraiKensaTsuki,kit.KensaIraiKensaBi)) = 0 THEN '' ");
            sqlContent.Append(" 					ELSE CONVERT(CHAR(10), CONVERT(DATETIME,CONCAT(kit.KensaIraiKensaNen,kit.KensaIraiKensaTsuki,kit.KensaIraiKensaBi)), 111) ");
            sqlContent.Append(" 				END) AS KensaDt, ");
            sqlContent.Append(" 				(CASE kkt.KensaKekkaHantei ");
            sqlContent.Append(" 					WHEN 1 THEN '○' ");
            sqlContent.Append(" 					WHEN 2 THEN '△' ");
            sqlContent.Append(" 					WHEN 3 THEN '×' ");
            sqlContent.Append(" 				END) AS Hantei ");


            sqlContent.Append(" 		FROM KensaIraiTbl kit  ");

            sqlContent.Append(" 		LEFT OUTER JOIN ConstMst cm ON kit.KensaIraiHoteiKbn = cm.ConstValue AND cm.ConstKbn = '006' ");
            sqlContent.Append(" 		LEFT OUTER JOIN JokasoDaichoMst jdm  ");
            sqlContent.Append(" 						ON kit.KensaIraiJokasoHokenjoCd = jdm.JokasoHokenjoCd  ");
            sqlContent.Append(" 						AND kit.KensaIraiJokasoTorokuNendo = jdm.JokasoTorokuNendo  ");
            sqlContent.Append(" 						AND kit.KensaIraiJokasoRenban = jdm.JokasoRenban ");

            sqlContent.Append(" 		LEFT OUTER JOIN HokenjoMst hm ON kit.KensaIraiHokenjoCd = hm.HokenjoCd ");
            sqlContent.Append(" 		LEFT OUTER JOIN KensaKekkaTbl kkt ON kit.KensaIraiHoteiKbn = kkt.KensaKekkaIraiHoteiKbn ");
            sqlContent.Append(" 		AND kit.KensaIraiHokenjoCd = kkt.KensaKekkaIraiHokenjoCd ");
            sqlContent.Append(" 		AND kit.KensaIraiNendo = kkt.KensaKekkaIraiNendo ");
            sqlContent.Append(" 		AND kit.KensaIraiRenban = kkt.KensaKekkaIraiRenban ");

            sqlContent.Append(" WHERE 1 = 1 ");
            if(kensaIraiHoteiKbn.Contains("1") || kensaIraiHoteiKbn.Contains("2"))
            {
                //検査依頼日
                sqlContent.Append(" AND CONCAT(REPLACE(STR(kit.KensaIraiNen, 4), SPACE(1), '0'), ");
                sqlContent.Append(" REPLACE(STR(kit.KensaIraiTsuki, 2), SPACE(1), '0'),  ");
                sqlContent.Append(" REPLACE(STR(kit.KensaIraiBi, 2), SPACE(1), '0')) " + DataAccessUtility.SetBetweenCommand(kensaIraiDtFrom, kensaIraiDtTo, 8));
                isSearchKensaDt = true;
            }
            if(kensaIraiHoteiKbn.Contains("3"))
            {
                sqlContent.Append(" AND kit.KensaIraiSuishitsuUketsukeDt " + DataAccessUtility.SetBetweenCommand(kensaIraiDtFrom, kensaIraiDtTo, 8));
                isSearchKensaDt = true;
            }

            if (isSearchKensaDt)
            {
                //検査日
                sqlContent.Append(" AND CONCAT(REPLACE(STR(kit.KensaIraiKensaNen, 4), SPACE(1), '0'), ");
                sqlContent.Append(" REPLACE(STR(kit.KensaIraiKensaTsuki, 2), SPACE(1), '0'),  ");
                sqlContent.Append(" REPLACE(STR(kit.KensaIraiKensaBi, 2), SPACE(1), '0')) " + DataAccessUtility.SetBetweenCommand(kensaDtFrom, kensaDtTo, 8));
            }

            if (kensaIraiHoteiKbn.Contains("4"))
            {
                //UNION
                sqlContent.Append(" UNION ");

                sqlContent.Append(" 	SELECT '4' AS KensaIraiHoteiKbn, ");
                sqlContent.Append(" 			'計量証明' AS ConstNm, ");
                sqlContent.Append(" 			CONCAT(ksit.KeiryoShomeiJokasoDaichoHokenjoCd, '-',  REPLACE(STR(ksit.KeiryoShomeiJokasoDaichoNendo - 1988, 2), SPACE(1), '0'), '-', ksit.KeiryoShomeiJokasoDaichoRenban) AS JokasoCd, ");
                sqlContent.Append(" 			jdm.JokasoSetchishaNm AS JokasoSetchishaNm, ");
                sqlContent.Append(" 			jdm.JokasoShisetsuNm AS JokasoShisetsuNm , ");
                sqlContent.Append(" 			hm.HokenjoNm AS HokenjoNm, ");
                sqlContent.Append(" 			'' AS KensaIraiDt, ");
                sqlContent.Append(" 			CASE  ");
                sqlContent.Append(" 				WHEN ISNULL(ksit.KeiryoShomeiIraiUketsukeDt, '') = '' THEN ''  ");
                sqlContent.Append(" 				ELSE CONVERT(CHAR(10), CONVERT(DATETIME, ksit.KeiryoShomeiIraiUketsukeDt), 111)  ");
                sqlContent.Append(" 			END AS KensaUketsukeDt, ");
                sqlContent.Append(" 			'' AS KensaDt, ");
			    sqlContent.Append(" 			CASE ");
                sqlContent.Append(" 				WHEN (kskt11.cnt IS NULL OR kskt11.cnt = '') AND (kskt22.cnt IS NOT NULL OR kskt22.cnt <> '')  THEN CONCAT('0/', kskt22.cnt) ");
                sqlContent.Append(" 				WHEN (kskt11.cnt IS NULL OR kskt11.cnt = '') AND (kskt22.cnt IS NULL OR kskt22.cnt = '') THEN '' ");
			    sqlContent.Append(" 				WHEN kskt11.cnt = kskt22.cnt THEN '済'  ");
			    sqlContent.Append(" 				ELSE CONCAT(kskt11.cnt, '/', kskt22.cnt)  ");
                sqlContent.Append(" 			END AS Hantei ");

                sqlContent.Append(" 	FROM KeiryoShomeiIraiTbl ksit  ");

                sqlContent.Append(" 	LEFT OUTER JOIN JokasoDaichoMst jdm  ");
                sqlContent.Append(" 					ON ksit.KeiryoShomeiJokasoDaichoHokenjoCd = jdm.JokasoHokenjoCd  ");
                sqlContent.Append(" 					AND ksit.KeiryoShomeiJokasoDaichoNendo = jdm.JokasoTorokuNendo  ");
                sqlContent.Append(" 					AND ksit.KeiryoShomeiJokasoDaichoRenban = jdm.JokasoRenban ");

	            sqlContent.Append("     LEFT OUTER JOIN HokenjoMst hm ON ksit.KeiryoShomeiJokasoDaichoHokenjoCd = hm.HokenjoCd ");

	            sqlContent.Append("     LEFT OUTER JOIN   ");
			    sqlContent.Append("             (SELECT KeiryoShomeiKekkaIraiNendo, KeiryoShomeiKekkaIraiShishoCd, KeiryoShomeiKekkaIraiNo, COUNT(*) AS cnt FROM KeiryoShomeiKekkaTbl  ");
				sqlContent.Append("     						            WHERE KeiryoShomeiKekkaNyuryoku = '1' ");
				sqlContent.Append("     						            GROUP BY KeiryoShomeiKekkaIraiNendo, KeiryoShomeiKekkaIraiShishoCd, KeiryoShomeiKekkaIraiNo ) AS kskt11 ");
			    sqlContent.Append("             ON ( ");
				sqlContent.Append("                 ksit.KeiryoShomeiIraiNendo = kskt11.KeiryoShomeiKekkaIraiNendo ");
				sqlContent.Append("                 AND ksit.KeiryoShomeiIraiSishoCd = kskt11.KeiryoShomeiKekkaIraiShishoCd ");
				sqlContent.Append("                 AND ksit.KeiryoShomeiIraiRenban = kskt11.KeiryoShomeiKekkaIraiNo ");

			    sqlContent.Append("             ) ");

	            sqlContent.Append("     LEFT OUTER JOIN ");

			    sqlContent.Append("             (SELECT KeiryoShomeiKekkaIraiNendo, KeiryoShomeiKekkaIraiShishoCd, KeiryoShomeiKekkaIraiNo, COUNT(*) AS cnt FROM KeiryoShomeiKekkaTbl  ");
				sqlContent.Append("     					            GROUP BY KeiryoShomeiKekkaIraiNendo, KeiryoShomeiKekkaIraiShishoCd, KeiryoShomeiKekkaIraiNo) AS kskt22 ");

			    sqlContent.Append("             ON ( ");
				sqlContent.Append("                 ksit.KeiryoShomeiIraiNendo = kskt22.KeiryoShomeiKekkaIraiNendo ");
				sqlContent.Append("                 AND ksit.KeiryoShomeiIraiSishoCd = kskt22.KeiryoShomeiKekkaIraiShishoCd ");
				sqlContent.Append("                 AND ksit.KeiryoShomeiIraiRenban = kskt22.KeiryoShomeiKekkaIraiNo ");

			    sqlContent.Append("             ) ");

                //WHERE
                sqlContent.Append(" WHERE ksit.KeiryoShomeiIraiUketsukeDt " + DataAccessUtility.SetBetweenCommand(kensaIraiDtFrom, kensaIraiDtTo, 8));
            }

			sqlContent.Append(" )  AS tbl ");


            /*----------WHERE-----------*/

            sqlContent.Append(" WHERE 1 = 1 ");

            if (kensaIraiHoteiKbn.Count != 0)
            {
                sqlContent.Append(" AND tbl.KensaIraiHoteiKbn IN ( " + hoteiKbn.Remove(hoteiKbn.Length - 2) +  " )");
            }

            if(!string.IsNullOrEmpty(settisyaCd))
            {
                sqlContent.Append(" AND tbl.JokasoCd = @jokasoCd ");
                commandParams.Add("@jokasoCd", SqlDbType.Char).Value = settisyaCd;
            }

            if (!string.IsNullOrEmpty(jokasoSetchishaNm))
            {
                sqlContent.Append(" AND tbl.JokasoSetchishaNm LIKE CONCAT('%', @jokasoSetchishaNm, '%') ");
                commandParams.Add("@jokasoSetchishaNm", SqlDbType.Char).Value = jokasoSetchishaNm;
            }

            if (!string.IsNullOrEmpty(jokasoShisetsuNm))
            {
                sqlContent.Append(" AND tbl.JokasoShisetsuNm LIKE CONCAT('%', @jokasoShisetsuNm, '%') ");
                commandParams.Add("@jokasoShisetsuNm", SqlDbType.Char).Value = jokasoShisetsuNm;
            }
            
            sqlContent.Append(" ORDER BY tbl.KensaIraiHoteiKbn, ");
            sqlContent.Append("         tbl.JokasoCd, ");
            sqlContent.Append("         tbl.HokenjoNm ");
            
            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

    #region EnkabutsuIonNodoHikakuListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： EnkabutsuIonNodoHikakuListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/21　DatNT　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    partial class EnkabutsuIonNodoHikakuListTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="saisuiDtFrom"></param>
        /// <param name="saisuiDtTo"></param>
        /// <param name="saisuiinNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal KensaIraiTblDataSet.EnkabutsuIonNodoHikakuListDataTable GetDataBySearchCond(
            string saisuiDtFrom,
            string saisuiDtTo,
            string saisuiinNm)
        {
            SqlCommand command = CreateSqlCommand(saisuiDtFrom, saisuiDtTo, saisuiinNm);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            KensaIraiTblDataSet.EnkabutsuIonNodoHikakuListDataTable dataTable = new KensaIraiTblDataSet.EnkabutsuIonNodoHikakuListDataTable();
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
        /// <param name="saisuiDtFrom"></param>
        /// <param name="saisuiDtTo"></param>
        /// <param name="saisuiinNm"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            string saisuiDtFrom,
            string saisuiDtTo,
            string saisuiinNm)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                                                                       ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiSaisuiinCd,                                                                                       ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiJokasoHokenjoCd,                                                                                  ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiJokasoTorokuNendo,                                                                                ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiJokasoRenban,                                                                                     ");
            sqlContent.Append("     CONCAT(KensaIraiTbl.KensaIraiJokasoHokenjoCd, '-',                                                                      ");
            sqlContent.Append("             KensaIraiTbl.KensaIraiJokasoTorokuNendo, '-',                                                                   ");
            sqlContent.Append("             KensaIraiTbl.KensaIraiJokasoRenban) AS JokasoNoCol,                                                             ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiSetchishaNm,                                                                                      ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiShorihoshikiKbn,                                                                                  ");

            sqlContent.Append("     CASE KensaIraiTbl.KensaIraiShorihoshikiKbn                                                                              ");
            sqlContent.Append("         WHEN '1' THEN '単独'                                                                                                ");
            sqlContent.Append("         WHEN '2' THEN '合併'                                                                                                ");
            sqlContent.Append("         WHEN '3' THEN '小合'                                                                                                ");
            sqlContent.Append("         ELSE '' END AS SyoriHoshikiCol,                                                                                     ");

            sqlContent.Append("     KensaKekkaTbl.KensaKekkaSaisuiDt,                                                                                       ");

            sqlContent.Append("     CASE                                                                                                                    ");
            sqlContent.Append("         WHEN ISNULL(KensaKekkaTbl.KensaKekkaSaisuiDt, '') = '' THEN ''                                                      ");
            sqlContent.Append("         ELSE CONCAT(SUBSTRING(KensaKekkaTbl.KensaKekkaSaisuiDt, 0, 4), '/',                                                 ");
            sqlContent.Append("                     SUBSTRING(KensaKekkaTbl.KensaKekkaSaisuiDt, 4, 2), '/',                                                 ");
            sqlContent.Append("                     SUBSTRING(KensaKekkaTbl.KensaKekkaSaisuiDt, 6, 2)) END AS SaisuiDtCol,                                  ");
            
            sqlContent.Append("     KensaKekkaTbl.KensaKekkaEnsoIonNodo,                                                                                    ");
            sqlContent.Append("     SaiSaisuiTbl.SaiSaisuiDt,                                                                                               ");

            sqlContent.Append("     CASE                                                                                                                    ");
            sqlContent.Append("         WHEN ISNULL(SaiSaisuiTbl.SaiSaisuiDt, '') = '' THEN ''                                                              ");
            sqlContent.Append("         ELSE CONCAT(SUBSTRING(SaiSaisuiTbl.SaiSaisuiDt, 0, 4), '/',                                                         ");
            sqlContent.Append("                     SUBSTRING(SaiSaisuiTbl.SaiSaisuiDt, 4, 2), '/',                                                         ");
            sqlContent.Append("                     SUBSTRING(SaiSaisuiTbl.SaiSaisuiDt, 6, 2)) END AS SaisaisuiDtCol,                                       ");

            sqlContent.Append("     SaiSaisuiTbl.SaiSaisuiEnkaIonNodo,                                                                                      ");

            sqlContent.Append("     CASE                                                                                                                    ");
            sqlContent.Append("         WHEN ISNULL(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo, '') = '' AND ISNULL(KensaKekkaTbl.KensaKekkaEnsoIonNodo, '') = ''    ");
            sqlContent.Append("             THEN 0                                                                                                          ");
            sqlContent.Append("         WHEN ISNULL(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo, '') = '' AND ISNULL(KensaKekkaTbl.KensaKekkaEnsoIonNodo, '') <> ''   ");
            sqlContent.Append("             THEN (0 - CAST(KensaKekkaTbl.KensaKekkaEnsoIonNodo AS INT))                                                     ");
            sqlContent.Append("         WHEN ISNULL(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo, '') <> '' AND ISNULL(KensaKekkaTbl.KensaKekkaEnsoIonNodo, '') = ''   ");
            sqlContent.Append("             THEN (CAST(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo AS INT) - 0)                                                       ");
            sqlContent.Append("         WHEN ISNULL(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo, '') <> '' AND ISNULL(KensaKekkaTbl.KensaKekkaEnsoIonNodo, '') <> ''  ");
            sqlContent.Append("             THEN (CAST(SaiSaisuiTbl.SaiSaisuiEnkaIonNodo AS INT) - CAST(KensaKekkaTbl.KensaKekkaEnsoIonNodo AS INT))        ");
            sqlContent.Append("         END AS SaCol,                                                                                                       ");

            sqlContent.Append("     SaisuiinMst.SaisuiinNm,                                                                                                 ");
            sqlContent.Append("     SaisuiinMst.SaisuiinShiteiNo,                                                                                           ");
            sqlContent.Append("     SaisuiinMst.SyozokuGyosyaCd,                                                                                            ");
            sqlContent.Append("     GyoshaMst.GyoshaNm                                                                                                      ");

            // FROM
            sqlContent.Append("FROM                                                                                                                         ");
            sqlContent.Append("     KensaIraiTbl                                                                                                            ");
            sqlContent.Append("INNER JOIN                                                                                                                   ");
            sqlContent.Append("     KensaKekkaTbl                                                                                                           ");
            sqlContent.Append("         ON KensaKekkaTbl.KensaKekkaIraiHoteiKbn = KensaIraiTbl.KensaIraiHoteiKbn                                            ");
            sqlContent.Append("         AND KensaKekkaTbl.KensaKekkaIraiHoteiKbn = KensaIraiTbl.KensaIraiHokenjoCd                                          ");
            sqlContent.Append("         AND KensaKekkaTbl.KensaKekkaIraiHoteiKbn = KensaIraiTbl.KensaIraiNendo                                              ");
            sqlContent.Append("         AND KensaKekkaTbl.KensaKekkaIraiHoteiKbn = KensaIraiTbl.KensaIraiRenban                                             ");
            sqlContent.Append("INNER JOIN                                                                                                                   ");
            sqlContent.Append("     SaiSaisuiTbl                                                                                                            ");
            sqlContent.Append("         ON SaiSaisuiTbl.SaiSaisuiIraiHoteiKbn = KensaIraiTbl.KensaIraiHoteiKbn                                              ");
            sqlContent.Append("         AND SaiSaisuiTbl.SaiSaisuiIraiHokenjoCd = KensaIraiTbl.KensaIraiHokenjoCd                                           ");
            sqlContent.Append("         AND SaiSaisuiTbl.SaiSaisuiIraiNendo = KensaIraiTbl.KensaIraiNendo                                                   ");
            sqlContent.Append("         AND SaiSaisuiTbl.SaiSaisuiIraiRrenban = KensaIraiTbl.KensaIraiRenban                                                ");
            sqlContent.Append("LEFT OUTER JOIN                                                                                                              ");
            sqlContent.Append("     SaisuiinMst                                                                                                             ");
            sqlContent.Append("         ON SaisuiinMst.SaisuiinCd = KensaIraiTbl.KensaIraiSaisuiinCd                                                        ");
            sqlContent.Append("LEFT OUTER JOIN                                                                                                              ");
            sqlContent.Append("     GyoshaMst                                                                                                               ");
            sqlContent.Append("         ON GyoshaMst.GyoshaCd = SaisuiinMst.SyozokuGyosyaCd                                                                 ");

            // WHERE
            sqlContent.Append("WHERE                                                                                ");
            sqlContent.Append("     1 = 1                                                                           ");

            sqlContent.Append("AND KensaKekkaTbl.KensaKekkaSaisuiDt " + DataAccessUtility.SetBetweenCommand(saisuiDtFrom, saisuiDtFrom, 8));

            if (!string.IsNullOrEmpty(saisuiinNm))
            {
                sqlContent.Append("AND SaisuiinMst.SaisuiinNm LIKE CONCAT('%', @saisuiinNm, '%') ");
                commandParams.Add("@saisuiinNm", SqlDbType.NVarChar).Value = saisuiinNm;
            }

            // ORDER BY
            sqlContent.Append("ORDER BY                                                                                                                     ");
            sqlContent.Append("     KensaIraiTbl.KensaIraiSaisuiinCd,                                                                                       ");
            sqlContent.Append("     SaisuiinMst.SaisuiinNm                                                                                                  ");

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

}
