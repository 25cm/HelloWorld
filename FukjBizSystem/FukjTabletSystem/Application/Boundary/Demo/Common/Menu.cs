using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Boundary.Demo.ShokenEntry;
using FukjTabletSystem.Application.Utility;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public partial class MenuForm : TabBaseForm
    {
        #region フォームデータ定義

        public class MenuFormData : FormData
        {
            public static string TANI_SOCHI_CD = "TaniSochiCd";
            public static string TANI_SOCHI_NM = "TaniSochiNm";

            string taniSoutiCd = string.Empty;

            class ScumValue
            {
                public string taniSochiCd;
                public string value1;
                public string value2;
            }

            Dictionary<string, ScumValue> scumValueMap = new Dictionary<string, ScumValue>();

            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);

                if (dataKey == TANI_SOCHI_CD)
                {
                    taniSoutiCd = value;
                }
            }

            public void SetTaniSochiScumValue(string souchiCd, string value1, string value2)
            {
                ScumValue newVal = new ScumValue();
                newVal.taniSochiCd = souchiCd;
                newVal.value1 = value1;
                newVal.value2 = value2;

                if (scumValueMap.ContainsKey(souchiCd))
                {
                    scumValueMap[souchiCd] = newVal;
                }
                else
                {
                    scumValueMap.Add(souchiCd, newVal);
                }
            }

            public void GetTaniSochiScumValue(string souchiCd, out string value1, out string value2)
            {
                if (scumValueMap.ContainsKey(souchiCd))
                {
                    value1 = scumValueMap[souchiCd].value1;
                    value2 = scumValueMap[souchiCd].value2;
                }
                else
                {
                    value1 = string.Empty;
                    value2 = string.Empty;
                }
            }
        }

        #endregion

        public MenuForm()
        {
            InitializeComponent();

        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            // 表示候補取得
            FormData formData = InitFormData();

            formData = GetFormData();

            DataTable table = GetDBFormData();

            SetTitle();

            // メニューボタン追加
            selectButtonPanel1.AddButton("検査一覧");
            selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(0), typeof(KensaTaishoListForm), this);

            selectButtonPanel1.AddButton("水質検査帳票");
            selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(1), typeof(SuishitsuKensa.SuishitsuKensaOutputForm), this);

            selectButtonPanel1.AddButton("終了");
            selectButtonPanel1.GetButton(2).Click +=
                delegate(object sender2, EventArgs e2)
                {
                    if (TabMessageBox.Show2(TabMessageBox.Type.YesNo, "アプリケーションを終了しますか？") != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }

                    this.Close();

                    if (DummyForm._instanse != null)
                    {
                        DummyForm._instanse.Close();
                    }

                    // TODO DummyFormなしで起動できるようにすること
                    System.Windows.Forms.Application.Exit();
                };
            //selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(0), typeof(KensaTaishoListForm), this);
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("メニュー");
        }
    }
}
