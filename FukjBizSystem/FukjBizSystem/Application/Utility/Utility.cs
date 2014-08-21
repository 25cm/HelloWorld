using System;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjBizSystem.Application.Utility
{
    class Utility
    {
        #region OpenFormCheck

        #region OpenFormCheck
        ///////////////////////////////////////////////////////////////
        /// メソッド：OpenFormCheck
        /// <summary>
        /// ウィンドウが開かれているかをチェック
        /// 開かれている場合はフォーカスをあてる
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2012/07/21　吉浦  　    攻玉寮流用
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static Boolean OpenFormCheck(String formName)
        {
            return OpenFormCheck(formName, false);
        }
        #endregion

        #region OpenFormCheck
        ///////////////////////////////////////////////////////////////
        /// メソッド：OpenFormCheck
        /// <summary>
        /// ウィンドウが開かれているかをチェック
        /// 開かれている場合はフォーカスをあてる
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2012/07/21　吉浦  　    攻玉寮流用
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static Boolean OpenFormCheck(String formName, Boolean messageFlag)
        {
            try
            {
                // 開かれているフォームを取得
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                {
                    if (form.Name.Equals(formName))
                    {
                        // フォームが開かれている
                        form.Focus();

                        if (messageFlag)
                        {
                            MessageForm.Show2(MessageForm.DispModeType.Error,
                                "別のウィンドウが開いています。\r\n" +
                                "ウィンドウを閉じてから作業を行ってください。");
                        }

                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, ex.Message);
                return true;
            }
        }
        #endregion

        #endregion

        #region SetComboBoxList
        /// <summary>
        /// データテーブルのデータをコンボボックスに設定する
        /// </summary>
        /// <param name="targetComboBox">設定するコンボボックス</param>
        /// <param name="dataTable">設定するデータテーブル</param>
        /// <param name="DisplayMember">コンボボックスに表示するカラム</param>
        /// <param name="ValueMember">SelectedValueでコンボボックスより取得するカラム</param>
        /// <param name="addEmpty">~行を追加するか</param>
        public static void SetComboBoxList(
            System.Windows.Forms.ComboBox targetComboBox,
            DataTable dataTable,
            string DisplayMember,
            string ValueMember,
            bool addEmpty)
        {
            // 初回のIndexを保持
            object selectedvalue = targetComboBox.SelectedValue;

            // 表示用にデータテーブルを作成（NULL制約を外す）
            DataTable dt = new DataTable();
            foreach (DataColumn col in dataTable.Columns)
            {
                dt.Columns.Add(col.ColumnName, col.DataType);
            }

            // 行データの詰め替え（MERGEは制約も移るため）
            foreach (DataRow row in dataTable.Rows)
            {
                dt.ImportRow(row);
            }

            // 空行追加（値を設定しない）
            if (addEmpty)
            {
                DataRow row = dt.NewRow();
                row[DisplayMember] = string.Empty;
                dt.Rows.InsertAt(row, 0);
            }

            // コンボボックスにデータを設定
            targetComboBox.DataSource = dt;
            targetComboBox.DisplayMember = DisplayMember;
            targetComboBox.ValueMember = ValueMember;
            // 2012/03/16 taniguchi 変更
            if (selectedvalue != null)
            {
                targetComboBox.SelectedValue = selectedvalue;
            }
            //targetComboBox.SelectedIndex = -1;
        }
        #endregion

        #region SetListBoxSource
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetListBoxSource
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="dataTable"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/08  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static void SetListBoxSource(ListBox listBox, DataTable dataTable, string displayMember, string valueMember)
        {
            listBox.DataSource = dataTable;
            listBox.DisplayMember = displayMember;
            listBox.ValueMember = valueMember;
        }
        #endregion

        #region IsDecimal
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsDecimal
        /// <summary>
        /// Is decimal or not?
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// TRUE: decimal
        /// FALSE: Not decimal
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsDecimal(string input)
        {
            decimal num;

            return Decimal.TryParse(input, out num) ? true : false;
        }
        #endregion

        #region IsDateFormat
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsDateFormat
        /// <summary>
        /// Is Date time format or not?
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// TRUE: datetime format
        /// FALSE: Not a datetime format
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsDateFormat(string input)
        {
            DateTime date;

            return DateTime.TryParseExact(input, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) ? true : false;
        }
        #endregion

        #region IsZipCode
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsZipCode
        /// <summary>
        /// Is zipcode format or not?
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// TRUE: zipcode format
        /// FALSE: Not a zipcode format
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsZipCode(string input)
        {
            string zipRegex = @"^[0-9]{3}[-][0-9]{4}$";

            if (!Regex.Match(input, zipRegex).Success)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region IsPhoneNumber
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsPhoneNumber
        /// <summary>
        /// Is phone number format or not?
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// TRUE: phone number format
        /// FALSE: Not a phone number format
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/24  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsPhoneNumber(string input)
        {
            //string phoneRegex = @"^[0-9]{3}[-][0-9]{4}[-][0-9]{4}$";
            string phoneRegex = @"^0\d{1,4}-\d{1,4}-\d{4}$";


            if (!Regex.Match(input, phoneRegex).Success)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region IsNumAndNegative
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsNumAndNegative
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsNumAndNegative(string input)
        {
            string regEx = @"^[0-9\-]*$";

            if (!Regex.Match(input, regEx).Success)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region ConvertToHeisei
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： ConvertToHeisei
        /// <summary>
        ///
        /// </summary>
        /// <param name="nendo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  HuyTX　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string ConvertToHeisei(int nendo)
        {
            CultureInfo culture = new CultureInfo("ja-JP", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            DateTime target = new DateTime(nendo, 8, 1);
            return target.ToString("yy", culture);
        }
        #endregion

        #region ConvertToSeireki
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： ConvertToSeireki
        /// <summary>
        ///
        /// </summary>
        /// <param name="nendo"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  HuyTX　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string ConvertToSeireki(int nendo)
        {
            if (nendo == 0) { nendo = 1; }

            CultureInfo ci = new CultureInfo("ja-JP");
            ci.DateTimeFormat.Calendar = new JapaneseCalendar();
            DateTime dt = DateTime.ParseExact("" + nendo, "yy", ci);
            return dt.Year.ToString();
        }
        #endregion

        #region IsNumAndSlash
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsNumAndSlash
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/15  HuyTX　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool IsNumAndSlash(string input)
        {
            string regEx = @"^[0-9\/\b]*$";

            if (!Regex.Match(input, regEx).Success)
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
