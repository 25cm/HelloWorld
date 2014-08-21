using System.Text;

namespace FukjTabletSystem.Application.DataAccess
{
    class DataAccessUtility
    {
        /// <summary>
        /// エスケープ対象文字列
        /// </summary>
        private static char[] sqlEscapeChar = { '_', '%', '[', '*', '\\' };

        /// <summary>
        /// SQL文字列中のエスケープ対象文字列をエスケープする
        /// </summary>
        /// <param name="paramStr">SQL文字列</param>
        /// <returns>エスケープ済SQL文字列</returns>
        public static string EscapeSQLString(string paramStr)
        {
            if (paramStr == null) { return null; }
            StringBuilder buf = new StringBuilder();
            foreach (char c in paramStr)
            {
                foreach (char escapeChar in sqlEscapeChar)
                {
                    if (c == escapeChar)
                    {
                        buf.Append('[');
                        buf.Append(c);
                        buf.Append(']');
                        goto FOUND_ESCAPE_CHAR;
                    }
                }
                buf.Append(c);
            FOUND_ESCAPE_CHAR: ;
            }
            return buf.ToString();
        }
    }
}