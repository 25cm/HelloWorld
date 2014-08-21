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

            // �����w��Ȃ��̏ꍇ�͏��OK�Ƃ���
            if (string.IsNullOrEmpty(validFormat))
            {
                return true;
            }

            // �e�������ƂɃ`�F�b�N
            foreach (char c in text)
            {
                bool charOk = false;

                // TODO �������x�Ȃǂ����ł���΁A�K�X�����̌��������s��

                // �w�菑�������̑S�ĂŃ`�F�b�N�G���[�ƂȂ�΁A���͕�����S�̂��G���[�Ƃ���
                // ���p�p���`�F�b�N
                if (validFormat.Contains('A'))
                {
                    if (((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')))
                    {
                        charOk = true;
                    }
                }
                // ���l�`�F�b�N
                if (validFormat.Contains('9'))
                {
                    string charList = "1234567890";

                    if (charList.Contains(c))
                    {
                        charOk = true;
                    }
                }
                // �L���`�F�b�N
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
