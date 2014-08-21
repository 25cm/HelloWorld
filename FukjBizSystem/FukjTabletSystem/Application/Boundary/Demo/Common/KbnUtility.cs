using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    /// <summary>
    /// 区分値から区分名称を取得
    /// </summary>
    /// <remarks>
    /// 名称マスタで管理されないものはこちらで区分値、区分名称を管理する
    /// 必要であれば名称マスタに管理を移設する
    /// </remarks>
    public class KbnUtility
    {
        public static string GetHandanName(string kbn)
        {
            string name = string.Empty;

            if (kbn == "0")
            {
                name = string.Empty;
            }
            else if (kbn == "1")
            {
                name = "○";
            }
            else if (kbn == "2")
            {
                name = "△";
            }
            else if (kbn == "3")
            {
                name = "×";
            }

            return name;
        }

        public static string GetLevelName(string kbn)
        {
            string name = string.Empty;

            if (kbn == "0")
            {
                name = string.Empty;
            }
            else if (kbn == "1")
            {
                name = "AA";
            }
            else if (kbn == "2")
            {
                name = "A";
            }
            else if (kbn == "3")
            {
                name = "B";
            }
            else if (kbn == "4")
            {
                name = "C";
            }

            return name;
        }

        public static string GetJudgeName(string kbn)
        {
            string name = string.Empty;

            if (kbn == "0")
            {
                name = string.Empty;
            }
            else if (kbn == "1")
            {
                name = "適正";
            }
            else if (kbn == "2")
            {
                name = "概ね適正";
            }
            else if (kbn == "3")
            {
                name = "不適正";
            }

            return name;
        }
    }
}
