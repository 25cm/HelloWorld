using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public partial class SelectButtonPanel : ZFlowLayoutPanel
    {
        private Dictionary<int , Button>buttonMap = new Dictionary<int,Button>();

        public SelectButtonPanel()
        {
            InitializeComponent();

            // VSデザイナ表示時はサンプルを表示
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                AddButton("ボタンサンプル1");
                AddButton("ボタンサンプル2");
                AddButton("ボタンサンプル3");
                AddButton("ボタンサンプル4");
                AddButton("ボタンサンプル5");
                AddButton("ボタンサンプル6");
                AddButton("ボタンサンプル7");
                AddButton("ボタンサンプル8");
                AddButton("ボタンサンプル9");
                AddButton("ボタンサンプル10");
                AddButton("ボタンサンプル11");
                AddButton("ボタンサンプル12");
            }
        }

        public void AddButton(string text)
        {
            Button newButton = CreateNewButton();

            int newButtonIdx = this.Controls.Count;

            //newButton.Location = new System.Drawing.Point(100, 30);
            newButton.Name = "button_" + newButtonIdx;
            newButton.TabIndex = newButtonIdx;
            newButton.Text = text;

            buttonMap.Add(newButtonIdx, newButton);

            this.Controls.Add(newButton);
        }

        public Button GetButton(int buttonIdx)
        {
            return buttonMap[buttonIdx];
        }

        public void ClearButton()
        {
            // TODO ボタンのみ削除する実装が望ましい
            this.Controls.Clear();

            buttonMap.Clear();
        }

        private Button CreateNewButton()
        {
            Button newButton = new Button();

            // ボタン雛形の設定
            newButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            newButton.AutoSize = true;
            newButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            newButton.Margin = new System.Windows.Forms.Padding(20);
            newButton.MinimumSize = new System.Drawing.Size(400, 120);
            newButton.Size = new System.Drawing.Size(400, 120);
            newButton.UseVisualStyleBackColor = true;

            return newButton;
        }

        public void SetButtonStdTransitionCallBack(Button button, Type nextFormType, Form parentForm)
        {
            button.Click +=
                delegate(object sender, EventArgs e)
                {
                    // TODO 入力済みの単位装置と、別の単位装置が選択された場合は、中分類以降の入力データを一旦無効にする（クリアする）

                    // 画面データの保存は、選択ボタン押下時のみ行う(次へボタン押下の場合は行わない)

                    #region 画面遷移

                    // 次の画面に遷移
                    Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
                    objNextForm.Show();

                    // 画面を閉じる
                    parentForm.Close();

                    #endregion
                };
        }

        public void SetButtonStdTransitionCallBack(DataGridView grid , DataGridViewColumn buttonCol, Type nextFormType, Form parentForm)
        {
            grid.CellContentClick +=
                delegate(object sender, DataGridViewCellEventArgs e)
                {
                    if (e.ColumnIndex == buttonCol.Index)
                    {
                        #region 画面遷移

                        // 次の画面に遷移
                        Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
                        objNextForm.Show();

                        // 画面を閉じる
                        parentForm.Close();

                        #endregion
                    }
                };
        }

        public void SetButtonStdTransitionCallBack(Button button, Type nextFormType, Form parentForm, Dictionary<string, string> paramMap)
        {
            button.Click +=
                delegate(object sender, EventArgs e)
                {
                    // TODO 入力済みの単位装置と、別の単位装置が選択された場合は、中分類以降の入力データを一旦無効にする（クリアする）

                    // 画面データの保存は、選択ボタン押下時のみ行う(次へボタン押下の場合は行わない)

                    #region 画面遷移

                    // 画面起動引数を設定
                    FormData formData = FormManager.GetInstance().LoadFormData(nextFormType);

                    foreach (string key in paramMap.Keys)
                    {
                        formData.SetValue(key, paramMap[key]);
                    }

                    FormManager.GetInstance().SaveFormData(nextFormType, formData);

                    // 次の画面に遷移
                    TabBaseForm objNextForm = (TabBaseForm)Activator.CreateInstance(nextFormType);

                    objNextForm.Show();

                    // 画面を閉じる
                    parentForm.Close();

                    #endregion
                };
        }
            
        #region 福岡浄化槽タブレット向け処理


        #endregion
    }
}
