using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FukjTabletSystem.Application.Boundary.Demo.ShokenEntry;
using FukjTabletSystem.Application.Boundary.Demo.JokasouInfo;
using FukjTabletSystem.Application.Boundary.Demo.SuishitsuKensa;
using FukjTabletSystem.Application.Boundary.Demo.ShoruiKensa;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    /// <summary>
    /// パンくずとか表示するなら、必要
    /// </summary>
    public class FormManager
    {
        /// <summary>
        /// 
        /// </summary>
        private Stack<FormData> FormTransitionStack = new Stack<FormData>();
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<Type, FormData> formDataMap = new Dictionary<Type, FormData>();

        // TODO staticにするかは検討する
        private static FormManager _instance;

        public FormManager()
        {
            InitTransitionData();
        }

        public static FormManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FormManager();
            }

            return _instance;
        }

        #region 画面入力情報管理

        public FormData LoadFormData(Type formType)
        {
            FormData ret = null;

            // TODO 該当画面の入力情報を持っている場合は、
            // 返す
            if (formDataMap.ContainsKey(formType))
            {
                ret = formDataMap[formType];
            }

            return ret;
        }

        public void SaveFormData(Type formType, FormData data)
        {
            // TODO メモリ上の画面入力値を保存する
            if (formDataMap.ContainsKey(formType))
            {
                formDataMap[formType] = data;
            }
            else
            {
                formDataMap.Add(formType, data);
            }
        }

        public FormData GetFormData(Type formType)
        {
            FormData ret = null;

            // TODO 該当画面の入力情報を持っている場合は、
            // 返す
            if (formDataMap.ContainsKey(formType))
            {
                ret = formDataMap[formType];
            }

            return ret;
        }

        /// <summary>
        /// フォームデータをクリアする
        /// </summary>
        /// <param name="formType"></param>
        public void ClearFormData(Type formType)
        {
            if (formDataMap.ContainsKey(formType))
            {
                formDataMap.Remove(formType);
            }
        }

        #endregion

        #region 画面遷移管理

        #region 内部処理用クラス

        class FormTransitionTreeNode
        {
            // TODO 具体的なデータ構成は、遷移決定後に見直し
            public Type formType;
            public Type nextForm;
            public Type prevForm;
            //FormTransitionTreeNode nextForm;
            //FormTransitionTreeNode prevForm;

            public FormTransitionTreeNode(Type formType, Type nextForm, Type prevForm)
            {
                this.formType = formType;
                this.nextForm = nextForm;
                this.prevForm = prevForm;
            }
        }

        #endregion

        private Dictionary<Type, FormTransitionTreeNode> transitionMap = new Dictionary<Type, FormTransitionTreeNode>();

        private void InitTransitionData()
        {
            // TODO 随時、画面遷移をメンテする
            AddTransitionData(typeof(DaiBunruiSentakuForm), typeof(ChuBunruiSentakuForm), typeof(JokasoMenuForm));
            AddTransitionData(typeof(ChuBunruiSentakuForm), typeof(ShouBunruiSentakuForm), typeof(DaiBunruiSentakuForm));
            AddTransitionData(typeof(ShouBunruiSentakuForm), typeof(TeidoSentakuForm), typeof(ChuBunruiSentakuForm));
            AddTransitionData(typeof(TeidoSentakuForm), typeof(ShokenKakuteiForm), typeof(ShouBunruiSentakuForm));
            AddTransitionData(typeof(ShokenKakuteiForm), null, typeof(TeidoSentakuForm));

            //AddTransitionData(typeof(MenuForm), null, typeof(KensaTaishoListForm));
            AddTransitionData(typeof(KensaTaishoListForm), null, typeof(MenuForm));
            AddTransitionData(typeof(KensaRirekiListForm), null, typeof(KensaTaishoListForm));
            AddTransitionData(typeof(JokasouInfoMenuForm), null, typeof(KensaTaishoListForm));
            AddTransitionData(typeof(SuishitsuKensaOutputForm), null, typeof(MenuForm));

            // TODO この画面は仮
            AddTransitionData(typeof(GaikanKensaHorizForm), null, typeof(JokasoMenuForm));

            AddTransitionData(typeof(JokasoMenuForm), null, typeof(KensaTaishoListForm));

            AddTransitionData(typeof(SuishitsuKensaEntryForm), null, typeof(JokasoMenuForm));
            AddTransitionData(typeof(ShoruiKensaEntryForm), null, typeof(JokasoMenuForm));

        }

        private void AddTransitionData(Type formType, Type nextForm, Type prevForm)
        {
            transitionMap.Add(formType, new FormTransitionTreeNode(formType, nextForm, prevForm));
        }

        public Type GetNextForm(Type currentForm)
        {
            Type ret = null;

            // 次の画面を返す
            if (transitionMap.ContainsKey(currentForm))
            {
                ret = transitionMap[currentForm].nextForm;
            }

            return ret;
        }

        public Type GetLastForm(Type currentForm)
        {
            Type ret = null;

            // TODO 作業フロー中の最後の画面を返す
            if (transitionMap.ContainsKey(currentForm))
            {
                ret = transitionMap[currentForm].nextForm;
            }

            return ret;
        }

        public Type GetPrevForm(Type currentForm)
        {
            Type ret = null;

            // 前の画面を返す
            if (transitionMap.ContainsKey(currentForm))
            {
                ret = transitionMap[currentForm].prevForm;
            }

            return ret;
        }

        public Type GetFirstForm(Type currentForm)
        {
            Type ret = null;

            // TODO 作業フロー中の最初の画面を返す(仮でトップメニューとする)
            if (transitionMap.ContainsKey(currentForm))
            {
                ret = transitionMap[currentForm].prevForm;
            }

            return ret;
        }

        #endregion
    }
}
