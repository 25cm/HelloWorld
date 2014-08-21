using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zynas.Control.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class InputValidateUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="validFormat"></param>
        /// <returns></returns>
        public static bool ValidateString(string text, string validFormat)
        {
            bool result = true;

            // 書式指定なしの場合は常にOKとする
            if (string.IsNullOrEmpty(validFormat))
            {
                return true;
            }

            // 各文字ごとにチェック
            foreach (char c in text)
            {
                bool charOk = false;

                // TODO 処理速度などが問題であれば、適宜処理の見直しを行う

                // 指定書式文字の全てでチェックエラーとなれば、入力文字列全体をエラーとする
                // 半角英字チェック
                if (validFormat.Contains('A'))
                {
                    if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        charOk = true;
                    }
                }
                // 数値チェック
                if (validFormat.Contains('9'))
                {
                    string charList = "1234567890";

                    if (charList.Contains(c))
                    {
                        charOk = true;
                    }
                }
                // 記号チェック
                if (validFormat.Contains('#'))
                {
                    string charList = "-()";

                    if (charList.Contains(c))
                    {
                        charOk = true;
                    }
                }

                if (!charOk)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool ValidateZipCd(string text)
        {
            if (!ValidateString(text, "9#"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool ValidateTelNo(string text)
        {
            if (!ValidateString(text, "9#"))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="validFormat"></param>
        /// <returns></returns>
        public static KeyPressEventHandler CreateKeyPressFilter(string validFormat)
        {
            KeyPressEventHandler handler = delegate(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !ValidateString(e.KeyChar.ToString(), validFormat))
                {
                    e.Handled = true;
                }
            };

            return handler;
        }
    }
}
