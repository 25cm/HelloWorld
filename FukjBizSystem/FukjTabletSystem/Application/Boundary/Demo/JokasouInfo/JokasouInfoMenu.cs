using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Utility;

namespace FukjTabletSystem.Application.Boundary.Demo.JokasouInfo
{
    public partial class JokasouInfoMenuForm : TabBaseForm
    {
        #region フォームデータ定義

        public class JokasouInfoMenuFormData : FormData
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

        public JokasouInfoMenuForm()
        {
            InitializeComponent();
        }

        private void JokasouInfoMenuForm_Load(object sender, EventArgs e)
        {
            // 表示候補取得
            FormData formData = InitFormData();

            formData = GetFormData();

            DataTable table = GetDBFormData();

            SetTitle();

            // TODO 画面クラスを指定()
            // TODO 仮でメッセージボックスを表示する

            // メニューボタン追加
            selectButtonPanel1.AddButton("メモ・注意事項");
            selectButtonPanel1.GetButton(0).Click += new EventHandler(test_Click);
            selectButtonPanel1.AddButton("浄化槽の特性");
            selectButtonPanel1.GetButton(1).Click += new EventHandler(test_Click);
            selectButtonPanel1.AddButton("添付書類");
            selectButtonPanel1.GetButton(2).Click += new EventHandler(test_Click);
            selectButtonPanel1.AddButton("その他特記事項");
            selectButtonPanel1.GetButton(3).Click += new EventHandler(test_Click);
        }

        private void test_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                TabMessageBox.Show2("機能説明:\n検査対象浄化槽の、" + ((Button)sender).Text + "を表示します");
            }
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("浄化槽基本情報");
        }
    }
}
