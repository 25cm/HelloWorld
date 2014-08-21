using System.Drawing;

namespace FukjTabletSystem.Application.Utility
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

        #region 消費税課税区分
        /// <summary>
        /// 消費税課税区分
        /// </summary>
        public enum ShohizeiKazeiKbn
        {
            /// <summary>
            /// 外税
            /// </summary>
            Sotozei = 1,
            /// <summary>
            /// 内税
            /// </summary>
            Uchizei = 2,
            /// <summary>
            /// 非課税
            /// </summary>
            Hikazei = 3
        }
        #endregion

        #region 消費税端数計算区分
        /// <summary>
        /// 消費税端数計算区分
        /// </summary>
        public enum ShohizeiHasuKeisanKbn
        {
            /// <summary>
            /// 四捨五入
            /// </summary>
            Shishagonyu = 1,
            /// <summary>
            /// 切り捨て
            /// </summary>
            Kirisute = 2,
            /// <summary>
            /// 切り上げ
            /// </summary>
            Kiriage = 3,
            /// 小数第２位以下四捨五入（小数１ケタ、偶数丸め無し）
            /// </summary>
            Shosu2iShishagonyu = 4
        }
        #endregion

        #region 単価端数計算区分
        /// <summary>
        /// 単価端数計算区分
        /// </summary>
        public enum TankaHasuKeisanKbn
        {
            /// <summary>
            /// 四捨五入
            /// </summary>
            Shishagonyu = 1,
            /// <summary>
            /// 切り捨て
            /// </summary>
            Kirisute = 2,
            /// <summary>
            /// 切り上げ
            /// </summary>
            Kiriage = 3,
            /// 小数第３位以下四捨五入（小数２ケタ、偶数丸め無し）
            /// </summary>
            Shosu3iShishagonyu = 4
        }
        #endregion

        #region 採番区分
        /// <summary>
        /// 採番区分
        /// </summary>
        public static class SaibanKbn
        {
            /// <summary>
            /// 預券伝票番号
            /// </summary>
            public static readonly string YokenNo = "01";
            /// <summary>
            /// 預券請求伝票番号
            /// </summary>
            public static readonly string YokenSeikyuNo = "02";
            /// <summary>
            /// 預券精算伝票番号
            /// </summary>
            public static readonly string YokenSeisanNo = "03";
            /// <summary>
            /// 入庫伝票番号
            /// </summary>
            public static readonly string NyukoNo = "04";
            /// <summary>
            /// 在庫移動番号
            /// </summary>
            public static readonly string ZaikoIdoNo = "05";
            /// <summary>
            /// 在庫増減番号
            /// </summary>
            public static readonly string ZaikoZogenNo = "06";
            /// <summary>
            /// 着券精算伝票番号
            /// </summary>
            public static readonly string ChakkenSeisanNo = "07";
            /// <summary>
            /// 販売手数料請求伝票番号
            /// </summary>
            public static readonly string HanbaiTesuryoSeikyuNo = "08";
            /// <summary>
            /// 受託精算伝票番号
            /// </summary>
            public static readonly string JutakuSeisanNo = "09";
            /// <summary>
            /// ムビチケ伝票番号
            /// </summary>
            public static readonly string MovieTickeNo = "10";
            /// <summary>
            /// 出庫伝票
            /// </summary>
            public static readonly string ShukkoNo = "11";
            /// <summary>
            /// 残券受領証番号
            /// </summary>
            public static readonly string ZankenJuryoshoNo = "12";
            /// <summary>
            /// 作品コード
            /// </summary>
            public static readonly string SakuhinCd = "13";
            /// <summary>
            /// 得意先コード
            /// </summary>
            public static readonly string TokuisakiCd = "14";
            /// <summary>
            /// 未着券精算伝票番号
            /// </summary>
            public static readonly string MiChakkenSeisanNo = "14";
        }
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
        }
        #endregion
        
        #region 振込手数料
        /// <summary>
        /// 振込手数料
        /// </summary>
        public static class TransferFee
        {
            /// <summary>
            /// 当行同一支店あて & AMOUNT < 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_SAME_BANK_SAME_BRANCH_LESS_30000 = 105;

            /// <summary>
            /// 当行同一支店あて & AMOUNT > 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_SAME_BANK_SAME_BRANCH_MORE_30000 = 315;

            /// <summary>
            /// 当行他支店あて < 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_SAME_BANK_DIFFERENT_BRANCH_LESS_30000 = 105;

            /// <summary>
            /// 当行他支店あて & AMOUNT > 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_SAME_BANK_DIFFERENT_BRANCH_MORE_30000 = 315;

            /// <summary>
            /// 他行あて & AMOUNT < 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_DIFFERENT_BANK_LESS_30000 = 525;

            /// <summary>
            /// 他行あて & AMOUNT > 30000
            /// </summary>
            public static readonly int TRANSFER_FEE_DIFFERENT_BANK_MORE_30000 = 735;

        }
        #endregion

        #region 得意先の最大終了日

        /// <summary>
        /// 得意先の最大終了日
        /// </summary>
        public static decimal TokuisakiMaxShuryoDate = 99999999;

        #endregion

        #region 部署

        /// <summary>
        /// 営業
        /// </summary>
        public const string BushoEigyo = "01";

        /// <summary>
        /// 事務
        /// </summary>
        public const string BushoJimu = "02";

        /// <summary>
        /// 経理
        /// </summary>
        public const string BushoKeiri = "03";

        #endregion

        #region 仮登録フラグ

        /// <summary>
        /// 本登録
        /// </summary>
        public const string KariTorokuHon = "0";

        /// <summary>
        /// 仮登録
        /// </summary>
        public const string KariTorokuKari = "1";

        #endregion
    }
    #endregion

}
