using System.Drawing;

namespace FukjBizSystem.Application.Utility
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： Constants
    /// <summary>
    /// 定数の定義を行うクラスです。
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2013/11/14　吉浦　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public class Constants
    {
        #region 項目タイトル、項目の背景色
        /// <summary>
        /// 必須入力用タイトル背景色
        /// </summary>
        public static Color RequiredTitleBackColor = Color.FromArgb(148, 203, 16);

        /// <summary>
        /// 必須入力用コントロール背景色
        /// </summary>
        public static Color RequiredControlBackColor = Color.PeachPuff;

        /// <summary>
        /// 入力用タイトル背景色
        /// </summary>
        public static Color InputTitleBackColor = Color.OliveDrab;

        /// <summary>
        /// 入力用コントロール背景色
        /// </summary>
        public static Color InputControlBackColor = SystemColors.Window;

        /// <summary>
        /// 読込専用タイトル背景色
        /// </summary>
        public static Color ReadOnlyTitleBackColor = Color.FromArgb(148, 203, 16);

        /// <summary>
        /// 読取専用コントロール背景色
        /// </summary>
        public static Color ReadOnlyContolBackColor = Color.LemonChiffon;

        /// <summary>
        /// 偶数行の背景色
        /// </summary>
        public static Color AlternatingRowsBackColor = Color.Beige;
        #endregion
        
        #region 名称マスタ
        ////////////////////////////////////////////////////////////////////////////
        //  クラス名 ： NameKbnConstant
        /// <summary>
        /// 名称識別区分
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/25　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static class NameKbnConstant
        {
            /// <summary>
            /// 000
            /// </summary>
            public static readonly string NAME_KBN_000 = "000";

            /// <summary>
            /// 005
            /// </summary>
            public static readonly string NAME_KBN_005 = "005";

            /// <summary>
            /// 006
            /// </summary>
            public static readonly string NAME_KBN_006 = "006";
        }
        #endregion

        #region 採番区分
        ////////////////////////////////////////////////////////////////////////////
        //  クラス名 ： SaibanKbnConstant
        /// <summary>
        /// 名称識別区分
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/25　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static class SaibanKbnConstant
        {
            /// <summary>
            /// 00
            /// </summary>
            public static readonly string SAIBAN_KBN_00 = "00";

            /// <summary>
            /// 01
            /// </summary>
            public static readonly string SAIBAN_KBN_01 = "01";

            /// <summary>
            /// 02
            /// </summary>
            public static readonly string SAIBAN_KBN_02 = "02";

            /// <summary>
            /// 03
            /// </summary>
            public static readonly string SAIBAN_KBN_03 = "03";

            /// <summary>
            /// 04
            /// </summary>
            public static readonly string SAIBAN_KBN_04 = "04";

            /// <summary>
            /// 05
            /// </summary>
            public static readonly string SAIBAN_KBN_05 = "05";

            /// <summary>
            /// 06
            /// </summary>
            public static readonly string SAIBAN_KBN_06 = "06";

            /// <summary>
            /// 07
            /// </summary>
            public static readonly string SAIBAN_KBN_07 = "07";

            /// <summary>
            /// 08
            /// </summary>
            public static readonly string SAIBAN_KBN_08 = "08";

            /// <summary>
            /// 09
            /// </summary>
            public static readonly string SAIBAN_KBN_09 = "09";
        }
        #endregion

        #region 定数マスタ

        #region 定数区分
        ////////////////////////////////////////////////////////////////////////////
        //  クラス名 ： ConstKbnConstanst
        /// <summary>
        /// 定数区分
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static class ConstKbnConstanst
        {
            /// <summary>
            /// 004
            /// </summary>
            public static readonly string CONST_KBN_004 = "004";

            /// <summary>
            /// 006
            /// </summary>
            public static readonly string CONST_KBN_006 = "006";
        }
        #endregion

        #region 定数連番
        ////////////////////////////////////////////////////////////////////////////
        //  クラス名 ： ConstRenbanConstanst
        /// <summary>
        /// 定数連番
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static class ConstRenbanConstanst
        {
            /// <summary>
            /// 001
            /// </summary>
            public static readonly string CONST_RENBAN_001 = "001";
        }
        #endregion

        #endregion

        #region 得意先の最大終了日

        /// <summary>
        /// 得意先の最大終了日
        /// </summary>
        public static decimal TokuisakiMaxShuryoDate = 99999999;

        #endregion

        #region 保証番号年度変換定数

        /// <summary>
        /// 西暦<->平成変換オフセット
        /// </summary>
        public static int HOSHOU_NENDO_OFFSET = 1988;

        #endregion

        #region プリンタ設定

        public static class PrinterConstant
        {
            // TODO 設定ファイル名は、app.configを参照する様にする
            public static readonly string PRINTER_SETTING_FILE_PATH = @"C:\FukjBizSystem\printer.xml";

            public static readonly string PRINTER_SETTING_SECTION = "printer";

            public static readonly string PRINT_TYPE_SEIKYU = "Seikyu";

            public static readonly string PRINT_TYPE_HAGAKI = "Hagaki";

            public static readonly string PRINT_TYPE_SOFUJO = "Sofujo";

            /// <summary>
            /// プリンタ設定ファイルキーリスト
            /// </summary>
            public static readonly string[] PRINTER_KEY_LIST = new string[] { 
                PRINT_TYPE_SEIKYU
                , PRINT_TYPE_HAGAKI
                , PRINT_TYPE_SOFUJO
            };

            /// <summary>
            /// プリンタ設定表示名リスト
            /// </summary>
            public static readonly string[] PRINTER_DISP_NAME_LIST = new string[] { 
                "請求書専用紙プリンター"
                , "はがき／ＤＭ用プリンター"
                , "送付状専用プリンター" 
            };
        }

        #endregion
    }
    #endregion
}
