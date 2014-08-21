using System.Drawing;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using Zynas.Framework.Utility;

namespace FukjTabletSystem.Application.Utility
{
    public static class TabMessageBox
    {
        public enum Type
        {
            Info,

            Warn,

            Error,

            YesNo,
        }

        public static DialogResult Show(Type type, string title, string msgId, params string[] strList)
        {
            DialogResult ret = DialogResult.Cancel;

            // メッセージ文字列の作成
            string dispMsg = string.Format(MessageResouce.GetMessage(msgId), strList);

            using (MessageForm form = new MessageForm(dispMsg, title, (int)type, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show(Type type, string msgId, params string[] strList)
        {
            DialogResult ret = DialogResult.Cancel;

            // メッセージ文字列の作成
            string dispMsg = string.Format(MessageResouce.GetMessage(msgId), strList);

            using (MessageForm form = new MessageForm(dispMsg, System.Windows.Forms.Application.ProductName, (int)type, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show(string msgId, params string[] strList)
        {
            DialogResult ret = DialogResult.Cancel;

            // メッセージ文字列の作成
            string dispMsg = string.Format(MessageResouce.GetMessage(msgId), strList);

            using (MessageForm form = new MessageForm(dispMsg, System.Windows.Forms.Application.ProductName, (int)Type.Info, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show2(Type type, string title, string message, Color bgColor, Color fColor)
        {
            DialogResult ret = DialogResult.Cancel;

            using (MessageForm form = new MessageForm(message, title, (int)type, bgColor, fColor))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show2(Type type, string title, string message)
        {
            DialogResult ret = DialogResult.Cancel;

            using (MessageForm form = new MessageForm(message, title, (int)type, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show2(Type type, string message)
        {
            DialogResult ret = DialogResult.Cancel;

            using (MessageForm form = new MessageForm(message, System.Windows.Forms.Application.ProductName, (int)type, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }

        public static DialogResult Show2(string message)
        {
            DialogResult ret = DialogResult.Cancel;

            using (MessageForm form = new MessageForm(message, System.Windows.Forms.Application.ProductName, (int)Type.Info, null, null))
            {
                ret = form.ShowDialog();
            }

            return ret;
        }
    }
}
