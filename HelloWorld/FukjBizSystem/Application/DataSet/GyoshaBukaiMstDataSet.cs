using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FukjBizSystem.Application.DataAccess;

namespace FukjBizSystem.Application.DataSet {
        
    public partial class GyoshaBukaiMstDataSet {
    }
}

namespace FukjBizSystem.Application.DataSet.GyoshaBukaiMstDataSetTableAdapters {


    #region KaiinListTableAdapter
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KaiinListTableAdapter
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　　 新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KaiinListTableAdapter
    {
        #region GetDataBySearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  インターフェイス名 ： GetDataBySearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gyosyaCdFrom"></param>
        /// <param name="gyosyaCdTo"></param>
        /// <param name="gyosyaNm"></param>
        /// <param name="nyukaiDtUse"></param>
        /// <param name="nyukaiDtFrom"></param>
        /// <param name="nyukaiDtTo"></param>
        /// <param name="seizo"></param>
        /// <param name="koji"></param>
        /// <param name="hosyu"></param>
        /// <param name="seiso"></param>
        /// <param name="mikanyu"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　DatNT　　 新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        [DataObjectMethod(DataObjectMethodType.Select)]
        internal GyoshaBukaiMstDataSet.KaiinListDataTable GetDataBySearchCond(
            string gyosyaCdFrom,
            string gyosyaCdTo,
            string gyosyaNm,
            bool nyukaiDtUse,
            string nyukaiDtFrom,
            string nyukaiDtTo,
            bool seizo,
            bool koji,
            bool hosyu,
            bool seiso,
            bool mikanyu)
        {
            SqlCommand command = CreateSqlCommand(gyosyaCdFrom,
                                                    gyosyaCdTo,
                                                    gyosyaNm,
                                                    nyukaiDtUse,
                                                    nyukaiDtFrom,
                                                    nyukaiDtTo,
                                                    seizo,
                                                    koji,
                                                    hosyu,
                                                    seiso,
                                                    mikanyu);

            SqlDataAdapter adpt = new SqlDataAdapter(command);
            adpt.SelectCommand.Connection = this.Connection;

            GyoshaBukaiMstDataSet.KaiinListDataTable dataTable = new GyoshaBukaiMstDataSet.KaiinListDataTable();
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
        /// <param name="gyosyaCdFrom"></param>
        /// <param name="gyosyaCdTo"></param>
        /// <param name="gyosyaNm"></param>
        /// <param name="nyukaiDtUse"></param>
        /// <param name="nyukaiDtFrom"></param>
        /// <param name="nyukaiDtTo"></param>
        /// <param name="seizo"></param>
        /// <param name="koji"></param>
        /// <param name="hosyu"></param>
        /// <param name="seiso"></param>
        /// <param name="mikanyu"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　DatNT　　新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private SqlCommand CreateSqlCommand(
            string gyosyaCdFrom,
            string gyosyaCdTo,
            string gyosyaNm,
            bool nyukaiDtUse,
            string nyukaiDtFrom,
            string nyukaiDtTo,
            bool seizo,
            bool koji,
            bool hosyu,
            bool seiso,
            bool mikanyu)
        {
            SqlCommand command = new SqlCommand();
            SqlParameterCollection commandParams = command.Parameters;

            StringBuilder sqlContent = new StringBuilder();

            // SELECT
            sqlContent.Append("SELECT                                                                                                                   ");
            sqlContent.Append("     Tbl.GyoshaCd,                                                                                                       ");
            sqlContent.Append("     Tbl.BukaiGyoshaCd,                                                                                                  ");
            sqlContent.Append("     Tbl.GyoshaNm,                                                                                                       ");
            sqlContent.Append("     CASE                                                                                                                ");
            sqlContent.Append("         WHEN Tbl.SeizoCol <> 0                                                                                          ");
            sqlContent.Append("             THEN CONCAT(SUBSTRING(CAST(Tbl.SeizoCol AS CHAR),0,5), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.SeizoCol AS CHAR),5,2), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.SeizoCol AS CHAR),7,2)) END AS SeizoCol,                                     ");
            sqlContent.Append("     CASE                                                                                                                ");
            sqlContent.Append("         WHEN Tbl.KojiCol <> 0                                                                                           ");
            sqlContent.Append("             THEN CONCAT(SUBSTRING(CAST(Tbl.KojiCol AS CHAR),0,5), '/',                                                  ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.KojiCol AS CHAR),5,2), '/',                                                  ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.KojiCol AS CHAR),7,2)) END AS KojiCol,                                       ");
            sqlContent.Append("     CASE                                                                                                                ");
            sqlContent.Append("         WHEN Tbl.HosyuCol <> 0                                                                                          ");
            sqlContent.Append("             THEN CONCAT(SUBSTRING(CAST(Tbl.HosyuCol AS CHAR),0,5), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.HosyuCol AS CHAR),5,2), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.HosyuCol AS CHAR),7,2)) END AS HosyuCol,                                     ");
            sqlContent.Append("     CASE                                                                                                                ");
            sqlContent.Append("         WHEN Tbl.SeisoCol <> 0                                                                                          ");
            sqlContent.Append("             THEN CONCAT(SUBSTRING(CAST(Tbl.SeisoCol AS CHAR),0,5), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.SeisoCol AS CHAR),5,2), '/',                                                 ");
            sqlContent.Append("                         SUBSTRING(CAST(Tbl.SeisoCol AS CHAR),7,2)) END AS SeisoCol                                      ");

            // FROM
            sqlContent.Append("FROM                                                                                                                     ");
            sqlContent.Append("     (                                                                                                                   ");
            sqlContent.Append("     SELECT                                                                                                              ");
            sqlContent.Append("         GyoshaMst.GyoshaCd,                                                                                             ");
            sqlContent.Append("         GyoshaBukaiMst.BukaiGyoshaCd,                                                                                   ");
            sqlContent.Append("         GyoshaMst.GyoshaNm,                                                                                             ");
            sqlContent.Append("         SUM (CASE                                                                                                       ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '1'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') <> '' THEN CAST(GyoshaBukaiMst.BukaiNyukaiDt AS INT)  ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '1'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') = ''  THEN 0                                          ");
            sqlContent.Append("             END) AS SeizoCol,                                                                                           ");
            sqlContent.Append("         SUM (CASE                                                                                                       ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '2'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') <> '' THEN CAST(GyoshaBukaiMst.BukaiNyukaiDt AS INT)  ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '2'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') = ''  THEN 0                                          ");
            sqlContent.Append("             END) AS KojiCol,                                                                                            ");
            sqlContent.Append("         SUM (CASE                                                                                                       ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '3'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') <> '' THEN CAST(GyoshaBukaiMst.BukaiNyukaiDt AS INT)  ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '3'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') = ''  THEN 0                                          ");
            sqlContent.Append("             END) AS HosyuCol,                                                                                           ");
            sqlContent.Append("         SUM (CASE                                                                                                       ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '4'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') <> '' THEN CAST(GyoshaBukaiMst.BukaiNyukaiDt AS INT)  ");
            sqlContent.Append("                 WHEN GyoshaBukaiMst.BukaiKbn = '4'                                                                      ");
            sqlContent.Append("                      AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') = ''  THEN 0                                          ");
            sqlContent.Append("             END) AS SeisoCol                                                                                            ");
            sqlContent.Append("     FROM                                                                                                                ");
            sqlContent.Append("         GyoshaMst                                                                                                       ");
            sqlContent.Append("             LEFT OUTER JOIN                                                                                             ");
            sqlContent.Append("                 GyoshaBukaiMst                                                                                          ");
            sqlContent.Append("                     ON GyoshaMst.GyoshaCd = GyoshaBukaiMst.BukaiGyoshaCd                                                ");
            sqlContent.Append("     WHERE                                                                                                               ");
            sqlContent.Append("         1 = 1                                                                                                           ");

            sqlContent.Append("AND GyoshaMst.GyoshaCd " + DataAccessUtility.SetBetweenCommand(gyosyaCdFrom, gyosyaCdTo, 4));

            if (!string.IsNullOrEmpty(gyosyaNm))
            {
                sqlContent.Append("AND GyoshaMst.GyoshaNm LIKE CONCAT('%', @gyosyaNm, '%') ");
                commandParams.Add("@gyosyaNm", SqlDbType.NVarChar).Value = gyosyaNm;
            }

            if (nyukaiDtUse)
            {
                sqlContent.Append("AND GyoshaBukaiMst.BukaiNyukaiDt >= @nyukaiDtFrom ");
                sqlContent.Append("AND GyoshaBukaiMst.BukaiNyukaiDt <= @nyukaiDtTo ");
                commandParams.Add("@nyukaiDtFrom", SqlDbType.Char).Value = nyukaiDtFrom;
                commandParams.Add("@nyukaiDtTo", SqlDbType.Char).Value = nyukaiDtTo;
            }

            sqlContent.Append("AND ( ( ISNULL(GyoshaBukaiMst.BukaiTaikaiDt, '') = '' AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') <> '' )               ");
            sqlContent.Append("     OR (ISNULL(GyoshaBukaiMst.BukaiTaikaiDt, '') <> '' AND ISNULL(GyoshaBukaiMst.BukaiNyukaiDt, '') = '') )             ");

            sqlContent.Append("     GROUP BY                                                                                                            ");
            sqlContent.Append("         GyoshaMst.GyoshaCd,                                                                                             ");
            sqlContent.Append("         GyoshaBukaiMst.BukaiGyoshaCd,                                                                                   ");
            sqlContent.Append("         GyoshaMst.GyoshaNm                                                                                              ");
            sqlContent.Append("     ) Tbl                                                                                                               ");

            // WHERE 
            sqlContent.Append("WHERE                                                                                                                    ");
            sqlContent.Append("     1 = 1                                                                                                               ");
            
            #region seizo - koji - hosyu - seizo - mikanyu

            #region 1, 2, 3, 4
            // 1
            if (seizo && !koji && !hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (ISNULL(Tbl.SeizoCol, '') <> '' )                                        ");
                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            if (seizo && !koji && !hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND ISNULL(Tbl.SeizoCol, '') <> ''                                           ");
            }
            // 2
            else if (!seizo && koji && !hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (ISNULL(Tbl.KojiCol, '') <> '' )                                         ");
                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && koji && !hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND ISNULL(Tbl.KojiCol, '') <> ''                                            ");
            }
            // 3
            else if (!seizo && !koji && hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (ISNULL(Tbl.HosyuCol, '') <> '' )                                        ");
                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && !koji && hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND ISNULL(Tbl.HosyuCol, '') <> ''                                           ");
            }
            // 4
            else if (!seizo && !koji && !hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (ISNULL(Tbl.SeisoCol, '') <> '' )                                        ");
                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && !koji && !hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND ISNULL(Tbl.SeisoCol, '') <> ''                                           ");
            }
            // 
            else if (!seizo && !koji && !hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND ISNULL(Tbl.SeizoCol, '') = ''                                            ");
                sqlContent.Append("AND ISNULL(Tbl.KojiCol, '') = ''                                             ");
                sqlContent.Append("AND ISNULL(Tbl.HosyuCol, '') = ''                                            ");
                sqlContent.Append("AND ISNULL(Tbl.SeisoCol, '') = ''                                            ");
            }
            #endregion

            #region 12, 13, 14, 23, 24, 34
            // 12
            else if (seizo && koji && !hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && koji && !hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            // 13
            else if (seizo && !koji && hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && !koji && hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 14
            else if (seizo && !koji && !hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && !koji && !hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 23
            else if (!seizo && koji && hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && koji && hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 24
            else if (!seizo && koji && !hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && koji && !hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 34
            else if (!seizo && !koji && hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && !koji && hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            #endregion

            #region 123, 124, 134, 234
            // 123
            else if (seizo && koji && hosyu && !seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && koji && hosyu && !seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 124
            else if (seizo && koji && !hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && koji && !hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 134
            else if (seizo && !koji && hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && !koji && hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            // 234
            else if (!seizo && koji && hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (!seizo && koji && hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            #endregion

            #region 1234
            else if (seizo && koji && hosyu && seiso && mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");

                sqlContent.Append("OR  (        ISNULL(Tbl.SeizoCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.KojiCol, '') = ''                                    ");
                sqlContent.Append("         AND ISNULL(Tbl.HosyuCol, '') = ''                                   ");
                sqlContent.Append("         AND ISNULL(Tbl.SeisoCol, '') = ''                                   ");
                sqlContent.Append("     )                                                                       ");
            }
            else if (seizo && koji && hosyu && seiso && !mikanyu)
            {
                sqlContent.Append("AND (        ISNULL(Tbl.SeizoCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.KojiCol, '') <> ''                                   ");
                sqlContent.Append("        OR   ISNULL(Tbl.HosyuCol, '') <> ''                                  ");
                sqlContent.Append("        OR   ISNULL(Tbl.SeisoCol, '') <> ''                                  ");
                sqlContent.Append("     )                                                                       ");
            }
            #endregion

            #endregion

            // ORDER BY
            sqlContent.Append("ORDER BY                                                                                                                 ");
            sqlContent.Append("     Tbl.GyoshaCd                                                                                                        ");
            
            command.CommandText = sqlContent.ToString();

            return command;
        }
        #endregion
    }
    #endregion
}
