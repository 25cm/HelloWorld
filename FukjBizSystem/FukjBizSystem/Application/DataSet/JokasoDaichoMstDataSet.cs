using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet
{


    #region TuckSealSearchCond
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： TuckSealSearchCond
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public class TuckSealSearchCond
    {
        /// <summary>
        /// 1: 発行区分/業者(3)
        /// 2: 発行区分/保健所(4)
        /// 3: 発行区分/設置者(5)
        /// </summary>
        public string RdSelect { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        public string SearchNm { get; set; }

        /// <summary>
        /// 登録年月
        /// </summary>
        public string Nengetsu { get; set; }

        /// <summary>
        /// 保健所コード
        /// </summary>
        public string HokenjoCd { get; set; }

        /// <summary>
        /// コード（開始）
        /// </summary>
        public string CdFrom { get; set; }

        /// <summary>
        /// コード（終了）
        /// </summary>
        public string CdTo { get; set; }
    }
    #endregion

    #region JokasoDaichoMstSearchCond
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： JokasoDaichoMstSearchCond
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/12　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public class JokasoDaichoMstSearchCond
    {
        /// <summary>
        /// 保健所コード
        /// </summary>
        public string HokenjoCd { get; set; }

        /// <summary>
        /// 浄化槽台帳登録年月 
        /// </summary>
        public string JokasoTorokuNendo {get; set; }

        /// <summary>
        /// 浄化槽台帳連番FROM
        /// </summary>
        public string RenbanFrom { get; set; }

        /// <summary>
        /// 浄化槽台帳連番TO
        /// </summary>
        public string RenbanTo { get; set; }

        /// <summary>
        /// 設置者名
        /// </summary>
        public string SettisyaNm { get; set; }

        /// <summary>
        /// 設置住所
        /// </summary>
        public string SettiAdr { get; set; }
    }
    #endregion

    public partial class JokasoDaichoMstDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.JokasoDaichoMstDataSetTableAdapters
{
    #region JokasoDaichoMstSearchTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： JokasoDaichoMstSearchTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/12　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    partial class JokasoDaichoMstSearchTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchCond"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal JokasoDaichoMstDataSet.JokasoDaichoMstSearchDataTable GetDataBySearchCond(JokasoDaichoMstSearchCond searchCond)
        {
            SqlCommand command = CreateSqlCommand(searchCond);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            JokasoDaichoMstDataSet.JokasoDaichoMstSearchDataTable dataTable = new JokasoDaichoMstDataSet.JokasoDaichoMstSearchDataTable();
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
        /// <param name="searchCond"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(JokasoDaichoMstSearchCond searchCond)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append(" select                                                                                                                       ");
	        sqlContent.Append("     jdm.JokasoHokenjoCd,                                                                                                     ");
	        sqlContent.Append("     hm.HokenjoNm,                                                                                                            ");
            sqlContent.Append("     jdm.JokasoTorokuNendo,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoRenban,                                                                                                        ");
            sqlContent.Append("     jdm.JokasoKbn,                                                                                                           ");
            sqlContent.Append("     jdm.JokasoSetchishaKbn,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoSetchishaCd,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoSetchishaKana,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoKensakuKana,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoSetchishaNm,                                                                                                   ");
	        //sqlContent.Append("     -- jdm.JokasoSetchishaShikuchoson,                                                                                       ");
            sqlContent.Append("     jdm.JokasoSetchishaAdr,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoSetchishaZipCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoSetchishaTelCd,                                                                                                ");
	        //sqlContent.Append("     -- jdm.JokasoSetchiBashoShikuchoson,                                                                                     ");
            sqlContent.Append("     jdm.JokasoSetchiBashoAdr,                                                                                                ");
            sqlContent.Append("     jdm.JokasoSetchiBashoZipCd,                                                                                              ");
            sqlContent.Append("     jdm.JokasoSetchiBashoTelCd,                                                                                              ");
            sqlContent.Append("     jdm.JokasoShisetsuNm,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoSetchiBashoHokenjoCd,                                                                                          ");
            sqlContent.Append("     jdm.JokasoKyuChikuCd,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoHoteiSishoCd,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoSuisitsuSishoCd,                                                                                               ");
            sqlContent.Append("     jdm.JokasoSaisuiGyoshaCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoSeikyuGyoshaCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoMochikomiGyoshaCd,                                                                                             ");
            sqlContent.Append("     jdm.JokasoKatashikiCd,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoShoriHosikiKbn,                                                                                                ");
            sqlContent.Append("     jdm.JokasoShoriHosikiCd,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoShoriHosikiShubetu,                                                                                            ");
            sqlContent.Append("     jdm.JokasoSyoriMokuhyoBOD,                                                                                               ");
            sqlContent.Append("     jdm.JokasoShohinNm,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoShoriTaishoJinin,                                                                                              ");
            sqlContent.Append("     jdm.JokasoHiHeikinOsuiRyo,                                                                                               ");
            sqlContent.Append("     jdm.JokasoJitsuSiyoJinin,                                                                                                ");
            sqlContent.Append("     jdm.JokasoJitsuHiHeikinOsuiRyo,                                                                                          ");
            sqlContent.Append("     jdm.JokasoSuisitsuKensaKaisu,                                                                                            ");
            sqlContent.Append("     jdm.JokasoHojokinKoufuFlg,                                                                                               ");
            sqlContent.Append("     concat(jdm.JokasoSiyokaisiNen, jdm.JokasoSiyokaisiTsuki, jdm.JokasoSiyokaisiBi) as JokasoSiyokaisiNenTsukiBi,            ");
            sqlContent.Append("     concat(jdm.JokasoSetchiNen, jdm.JokasoSetchiTsuki, jdm.JokasoSetchiBi) as JokasoSetchiNenTsukiBi,                        ");
            sqlContent.Append("     jdm.JokasoTorikesiKbn,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoShodokuSetsubiUmuFlg,                                                                                          ");
            sqlContent.Append("     jdm.JokasoGaikanTikuwariKbn,                                                                                             ");
            sqlContent.Append("     jdm.JokasoRiyuKbn,                                                                                                       ");
            sqlContent.Append("     jdm.JokasoSaishuKensaBi,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoSoufusakiNm,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoSoufusakiZipCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoSoufusakiAdr,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoSoufusakiTelNo,                                                                                                ");
            sqlContent.Append("     jdm.JokasoSeikyusakiNm,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoSeikyusakiZipCd,                                                                                               ");
            sqlContent.Append("     jdm.JokasoSeikyusakiAdr,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoSeikyusakiTelNo,                                                                                               ");
            sqlContent.Append("     jdm.JokasoRenrakusakiNm,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoRenrakusakiZipCd,                                                                                              ");
            sqlContent.Append("     jdm.JokasoRenrakusakiAdr,                                                                                                ");
            sqlContent.Append("     jdm.JokasoRenrakusakiTelNo,                                                                                              ");
            sqlContent.Append("     jdm.JokasoItkatsuSoufuGyoshaCd,                                                                                          ");
            sqlContent.Append("     jdm.JokasoItkatsuSeikyuGyoshaCd,                                                                                         ");
            sqlContent.Append("     jdm.JokasoBettoSoufuGyoshaCd1,                                                                                           ");
            sqlContent.Append("     jdm.JokasoBettoSoufuGyoshaCd2,                                                                                           ");
            sqlContent.Append("     jdm.JokasoBettoSoufuGyoshaCd3,                                                                                           ");
            sqlContent.Append("     jdm.JokasoTorisageBi,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoKentikuYoutoCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoJokasoTorokuNo,                                                                                                ");
            sqlContent.Append("     jdm.JokasoMekaGyoshaCd,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoKojiGyoshaKbn,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoHoshutenkenGyoshaCd,                                                                                           ");
            sqlContent.Append("     jdm.JokasoSeisouGyoshaCd,                                                                                                ");
            sqlContent.Append("     jdm.JokasoHoryusakiCd,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoJokasoKumitateKbn,                                                                                             ");
            sqlContent.Append("     jdm.JokasoHoshoNoKensakikan,                                                                                             ");
            sqlContent.Append("     jdm.JokasoHoshoNoNendo,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoHoshoNoRenban,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoHouKonkyoKbn,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoHokenjoJuriNoHokenCd,                                                                                          ");
            sqlContent.Append("     jdm.JokasoHokenjoJuriNoNendo,                                                                                            ");
            sqlContent.Append("     jdm.JokasoHokenjoJuriNoSichosonCd,                                                                                       ");
            sqlContent.Append("     jdm.JokasoHokenjoJuriNoRenban,                                                                                           ");
            sqlContent.Append("     jdm.JokasoChizuNo,                                                                                                       ");
            sqlContent.Append("     jdm.JokasoKensaHitsuyoJinin,                                                                                             ");
            sqlContent.Append("     jdm.Jokaso11JoJissiKbn,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoHagakiSoufusakiKbn,                                                                                            ");
            sqlContent.Append("     jdm.Jokaso７JoKensaBi,                                                                                                   ");
            sqlContent.Append("     jdm.Jokaso11JokensaBi,                                                                                                   ");
            sqlContent.Append("     jdm.Jokaso7JoKensaJokyoKbn,                                                                                              ");
            sqlContent.Append("     jdm.Jokaso11JoKensaJokyoKbn,                                                                                             ");
            sqlContent.Append("     jdm.Jokaso7JoKensaRyokin,                                                                                                ");
            sqlContent.Append("     jdm.Jokaso11JoKensaRyokin,                                                                                               ");
            sqlContent.Append("     jdm.Jokaso3JiShoriFlg,                                                                                                   ");
            sqlContent.Append("     jdm.Jokaso3JiShoriType,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoGensuiPonpuFlg,                                                                                                ");
            sqlContent.Append("     jdm.JokasoHoryuPonpuFlg,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoDisupozaFlg,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoKoujiKbn,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoKoujiNen,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoKoujiNo,                                                                                                       ");
            sqlContent.Append("     jdm.JokasoNinteiNo,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoDMHassouKbn,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoDMKekkaKbn,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoSichosonSetchiKbn,                                                                                             ");
            sqlContent.Append("     jdm.JokasoJukenKeihatsuDMHassouKbn,                                                                                      ");
            sqlContent.Append("     jdm.JokasoJukenKeihatsuDMKekkaKbn,                                                                                       ");
            sqlContent.Append("     jdm.JokasoShogouSetchishaCd,                                                                                             ");
            sqlContent.Append("     jdm.JokasoShuyakumaeSuisitsuSetchishaCd,                                                                                 ");
            sqlContent.Append("     jdm.JokasoTegakiMemo,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoTegakiMemo2,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoTatemonoNobeMenseki,                                                                                           ");
            sqlContent.Append("     jdm.JokasoSinSichosonCd,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoJitsuSiyouJininSuchi,                                                                                          ");
            sqlContent.Append("     jdm.JokasoKasaageTakasa,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoChizuNendo,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoChizuPageNo,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoUketsukeBi,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoJuriBi,                                                                                                        ");
            sqlContent.Append("     jdm.JokasoChosaBi,                                                                                                       ");
            sqlContent.Append("     jdm.JokasoKanrishaHenkouBi,                                                                                              ");
            sqlContent.Append("     jdm.JokasoHenkoumaeKanrishaNm,                                                                                           ");
            sqlContent.Append("     jdm.JokasoHenkoumaeSetchiBashoAdr,                                                                                       ");
            sqlContent.Append("     jdm.JokasoJotaiKbn,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoHaishiBi,                                                                                                      ");
            sqlContent.Append("     jdm.JokasoJohogenKbn,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoRyunyuTairyuTakasa,                                                                                            ");
            sqlContent.Append("     jdm.JokasoHouryuTairyuTakasa,                                                                                            ");
            sqlContent.Append("     jdm.JokasoKensaTantoshaNm,                                                                                               ");
            sqlContent.Append("     jdm.JokasoChizuNendo1,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoChizuPageNo1,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoHagakiKbn,                                                                                                     ");
            sqlContent.Append("     jdm.JokasoGenChikuCd,                                                                                                    ");
            sqlContent.Append("     jdm.JokasoZenrinLinkCd,                                                                                                  ");
            sqlContent.Append("     jdm.JokasoZenrinIdoCd,                                                                                                   ");
            sqlContent.Append("     jdm.JokasoZenrinKeidoCd,                                                                                                 ");
            sqlContent.Append("     jdm.JokasoChizuShutokuAdr,                                                                                               ");
            sqlContent.Append("     jdm.JokasoChizuShutokuNm                                                                                                 ");
            // FROM
            sqlContent.Append(" from JokasoDaichoMst jdm                                                                                                     ");
            sqlContent.Append(" left outer join HokenjoMst hm                                                                                                ");
            sqlContent.Append("     on jdm.JokasoHokenjoCd = hm.HokenjoCd                                                                                    ");
            // WHERE
            sqlContent.Append(" where ");

            // 台帳連番（開始）~ 台帳連番（終了）
            sqlContent.Append("     jdm.JokasoRenban " + DataAccessUtility.SetBetweenCommand(searchCond.RenbanFrom, searchCond.RenbanTo, 5));

            // 保健所コード
            if (!string.IsNullOrEmpty(searchCond.HokenjoCd))
            {
                sqlContent.Append(" and jdm.JokasoHokenjoCd = @JokasoHokenjoCd");
                commandParams.Add("@JokasoHokenjoCd", SqlDbType.Char).Value = (string)searchCond.HokenjoCd;
            }

            // 登録年月
            if (!string.IsNullOrEmpty(searchCond.JokasoTorokuNendo))
            {
                sqlContent.Append(" and jdm.JokasoTorokuNendo = @JokasoTorokuNendo");
                commandParams.Add("@JokasoTorokuNendo", SqlDbType.Char).Value = (string)searchCond.JokasoTorokuNendo;
            }

            // 設置者名
            if (!string.IsNullOrEmpty(searchCond.SettisyaNm))
            {
                sqlContent.Append(" and (jdm.JokasoSetchishaKana like concat('%', @JokasoSetchishaNm1, '%')");
                sqlContent.Append("   or jdm.JokasoKensakuKana like concat('%', @JokasoSetchishaNm2, '%')");
                sqlContent.Append("   or jdm.JokasoSetchishaNm like concat('%', @JokasoSetchishaNm3, '%'))");
                commandParams.Add("@JokasoSetchishaNm1", SqlDbType.Char).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SettisyaNm);
                commandParams.Add("@JokasoSetchishaNm2", SqlDbType.Char).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SettisyaNm);
                commandParams.Add("@JokasoSetchishaNm3", SqlDbType.Char).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SettisyaNm);
            }

            // 設置住所
            if (!string.IsNullOrEmpty(searchCond.SettiAdr))
            {
                sqlContent.Append(" and jdm.JokasoSetchishaAdr like concat('%', @JokasoSetchishaAdr, '%')");
                commandParams.Add("@JokasoSetchishaAdr", SqlDbType.Char).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SettiAdr);
            }

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion

    #region TuckSealListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： TuckSealListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　AnhNV　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class TuckSealListTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchCond"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　AnhNV　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal JokasoDaichoMstDataSet.TuckSealListDataTable GetDataBySearchCond(TuckSealSearchCond searchCond)
        {
            SqlCommand command = CreateSqlCommand(searchCond);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            JokasoDaichoMstDataSet.TuckSealListDataTable dataTable = new JokasoDaichoMstDataSet.TuckSealListDataTable();
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
        /// <param name="searchCond"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　AnhNV　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(TuckSealSearchCond searchCond)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // 業者マスタ search
            if (searchCond.RdSelect == "1")
            {
                sqlContent.Append(" select                                                                                                                          ");
                sqlContent.Append("     gm.GyoshaCd as CdCol,                                                                                                       ");
                sqlContent.Append("     '' as NengetsuCol,                                                                                                          ");
                sqlContent.Append("     '' as RenbanCol,                                                                                                            ");
                sqlContent.Append("     gm.GyoshaNm as NmCol,                                                                                                       ");
                sqlContent.Append("     gm.GyoshaZipCd as ZipNoCol,                                                                                                 ");
                sqlContent.Append("     gm.GyoshaAdr as AdrCol                                                                                                      ");
                sqlContent.Append(" from GyoshaMst gm                                                                                                               ");
                sqlContent.Append(" where                                                                                                                           ");
                // 業者コードFROM ~ TO
                sqlContent.Append("     gm.GyoshaCd " + DataAccessUtility.SetBetweenCommand(searchCond.CdFrom, searchCond.CdTo, 4));
                if (!string.IsNullOrEmpty(searchCond.SearchNm))
                {
                    // 業者名称
                    sqlContent.Append(" and gm.GyoshaNm like concat('%', @GyoshaNm, '%')");
                    commandParams.Add("@GyoshaNm", SqlDbType.VarChar).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SearchNm);
                }

                // ORDER BY
                sqlContent.Append(" order by gm.GyoshaCd");
            }
            else if (searchCond.RdSelect == "2") // 保健所マスタ search
            {
                sqlContent.Append(" select                                                                                                                          ");
                sqlContent.Append("     hm.HokenjoCd as CdCol,                                                                                                      ");
                sqlContent.Append("     '' as NengetsuCol,                                                                                                          ");
                sqlContent.Append("     '' as RenbanCol,                                                                                                            ");
                sqlContent.Append("     hm.HokenjoNm as NmCol,                                                                                                      ");
                sqlContent.Append("     hm.HokenjoZipCd as ZipNoCol,                                                                                                ");
                sqlContent.Append("     hm.HokenjoAdr as AdrCol                                                                                                     ");
                sqlContent.Append(" from HokenjoMst hm                                                                                                              ");
                sqlContent.Append(" where 1=1                                                                                                                       ");
                
                // 保健所コードFROM ~ TO
                if (!string.IsNullOrEmpty(searchCond.HokenjoCd))
                {
                    sqlContent.Append("     and hm.HokenjoCd = @HokenjoCd ");
                    commandParams.Add("@HokenjoCd", SqlDbType.Char).Value = (string)searchCond.HokenjoCd;
                }
                else
                {
                    sqlContent.Append("     and hm.HokenjoCd " + DataAccessUtility.SetBetweenCommand(searchCond.CdFrom, searchCond.CdTo, 2));
                }

                if (!string.IsNullOrEmpty(searchCond.SearchNm))
                {
                    // 設置者氏名
                    sqlContent.Append(" and hm.HokenjoNm like concat('%', @HokenjoNm, '%')");
                    commandParams.Add("@HokenjoNm", SqlDbType.VarChar).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SearchNm);
                }

                // ORDER BY
                sqlContent.Append(" order by hm.HokenjoCd");
            }
            else // 浄化槽台帳マスタ search
            {
                sqlContent.Append(" select                                                                                                                          ");
                sqlContent.Append("     jdm.JokasoHokenjoCd as CdCol,                                                                                               ");
                sqlContent.Append("     jdm.JokasoTorokuNendo as NengetsuCol,                                                                                       ");
                sqlContent.Append("     jdm.JokasoRenban as RenbanCol,                                                                                              ");
                sqlContent.Append("     jdm.JokasoSetchishaNm as NmCol,                                                                                             ");
                sqlContent.Append("     jdm.JokasoSetchishaZipCd as ZipNoCol,                                                                                       ");
                sqlContent.Append("     jdm.JokasoSetchishaAdr as AdrCol                                                                                            ");
                sqlContent.Append(" from JokasoDaichoMst jdm                                                                                                        ");
                sqlContent.Append(" where                                                                                                                           ");
                // 浄化槽台帳連番
                sqlContent.Append("     jdm.JokasoRenban " + DataAccessUtility.SetBetweenCommand(searchCond.CdFrom, searchCond.CdTo, 5));
                if (!string.IsNullOrEmpty(searchCond.HokenjoCd))
                {
                    // 浄化槽台帳保健所コード
                    sqlContent.Append(" and jdm.JokasoHokenjoCd = @JokasoHokenjoCd");
                    commandParams.Add("@JokasoHokenjoCd", SqlDbType.VarChar).Value = (string)searchCond.HokenjoCd;
                }
                if (!string.IsNullOrEmpty(searchCond.Nengetsu))
                {
                    // 浄化槽台帳年度
                    sqlContent.Append(" and jdm.JokasoTorokuNendo = @JokasoTorokuNengetsu");
                    commandParams.Add("@JokasoTorokuNengetsu", SqlDbType.VarChar).Value = (string)searchCond.Nengetsu;
                }
                if (!string.IsNullOrEmpty(searchCond.SearchNm))
                {
                    // 設置者氏名
                    sqlContent.Append(" and jdm.JokasoSetchishaNm like concat('%', @JokasoSetchishaNm, '%')");
                    commandParams.Add("@JokasoSetchishaNm", SqlDbType.VarChar).Value = (string)DataAccessUtility.EscapeSQLString(searchCond.SearchNm);
                }

                // ORDER BY
                sqlContent.Append(" order by jdm.JokasoHokenjoCd, jdm.JokasoTorokuNendo, jdm.JokasoRenban");
            }

            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
