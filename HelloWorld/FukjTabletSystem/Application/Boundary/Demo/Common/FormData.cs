using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public class FormData
    {
        #region 共通プロパティ

        /// <summary>
        /// 画面クラス型情報
        /// </summary>
        public Type FormType;

        /// <summary>
        /// タイトル文字列
        /// </summary>
        public string DispName;

        /// <summary>
        /// サブタイトル表示文字列
        /// </summary>
        public string TransitionDispName;

        protected Dictionary<string, string> formMap = new Dictionary<string, string>();

        #endregion

        #region 共通メソッド

        public virtual void SetValue(string dataKey, string value)
        {
            // TODO こちら側は必須処理(final)とし、Privateデータ用のメソッドを設けるか？

            if (formMap.ContainsKey(dataKey))
            {
                formMap[dataKey] = value;
            }
            else
            {
                formMap.Add(dataKey, value);
            }
        }

        public virtual string GetValue(string dataKey)
        {
            string ret = string.Empty;

            if (formMap.ContainsKey(dataKey))
            {
                ret = formMap[dataKey];
            }

            return ret;
        }

        #endregion

        // TODO 継承クラスで、画面固有のデータを記載する

    }
}
