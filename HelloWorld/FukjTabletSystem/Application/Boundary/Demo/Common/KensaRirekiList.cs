using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class KensaRirekiListForm : TabBaseForm
    {
        #region フォームデータ定義

        public class KensaRirekiListFormData : FormData
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

        public KensaRirekiListForm()
        {
            InitializeComponent();
        }

        private void KensaRirekiListForm_Load(object sender, EventArgs e)
        {
            // TODO 検査項目一覧(メニュー)に遷移

            // 

            // 表示候補取得
            FormData formData = InitFormData();

            formData = GetFormData();

            DataTable table = GetDBFormData();

            SetTitle();

            //for (int i = 0; i < 5; i++)
            {
                elementDataGridView.Rows.Add("7条", "25/06/07", "028:佐藤太郎", "適正", "6.9", "6.9", "6.9", "6.9", "6.9", "6.9", Resources.Photo, Resources.Pdf);
                elementDataGridView.Rows.Add("11条", "25/01/07", "028:佐藤太郎", "概ね", "6.9", "6.9", "6.9", "6.9", "6.9", "6.9", Resources.Photo, Resources.Pdf);
                elementDataGridView.Rows.Add("7条", "24/06/07", "028:佐藤太郎", "概ね", "6.9", "6.9", "6.9", "6.9", "6.9", "6.9", Resources.Photo, Resources.Pdf);
                elementDataGridView.Rows.Add("11条", "24/01/07", "036:鈴木次郎", "不適", "6.9", "6.9", "6.9", "6.9", "6.9", "6.9", Resources.Photo, Resources.Pdf);
            }

            /*
            DataRow[] rows = table.Select(string.Format(""));

            for (int i = 0; i < rows.Length; i++)
            {
                Panel newPanel = CreateElement(rows[i], formData);
                // TODO 自動で適切に動くなら良い
                //newPanel.TabIndex = i + 3;
                elementLayoutPanel.Controls.Add(newPanel);
            }
            */
        }

        public override FormData InitFormData()
        {
            FormData ret = new KensaRirekiListFormData();

            return ret;
            // TODO 
        }

        public override void SetFormData(FormData data)
        {
            // TODO フォームの作業データを設定する

            // TODO ボタンが押された単位装置のもののみ、設定する
            // TODO スカム厚等
        }

        public override FormData GetFormData()
        {
            FormData formData;
            FormData getFormData = FormManager.GetInstance().GetFormData(GetType());

            if (getFormData != null)
            {
                formData = getFormData;
            }
            else
            {
                formData = InitFormData();
            }

            return formData;
        }

        public override DataTable GetDBFormData()
        {
            // TODO GetDB Value

            DataTable table = new DataTable();
            table.Columns.Add("TaniSochiCd", typeof(string));
            table.Columns.Add("TaniSochiNm", typeof(string));
            table.Columns.Add("TaniSochiGroupCd", typeof(string));
            table.Columns.Add("TaniSochiGroupNm", typeof(string));
            /*
            table.Columns.Add("TaniSochiKensaKomokuCd", typeof(string));
            table.Columns.Add("TaniSochiKensaKomokuNm", typeof(string));
            */

            // TODO DBからデータを取得する様にする
            {
                DataRow row = table.NewRow();
                row["TaniSochiCd"] = "01";
                row["TaniSochiNm"] = "嫌気ろ床槽　第１槽";
                row["TaniSochiGroupCd"] = "01";
                row["TaniSochiGroupNm"] = "接触ばっ気槽";
                /*
                row["TaniSochiKensaKomokuCd"] = "01";
                row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
                */

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["TaniSochiCd"] = "02";
                row["TaniSochiNm"] = "嫌気ろ床槽　第２槽";
                row["TaniSochiGroupCd"] = "01";
                row["TaniSochiGroupNm"] = "接触ばっ気槽";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["TaniSochiCd"] = "03";
                row["TaniSochiNm"] = "接触ばっ気槽";
                row["TaniSochiGroupCd"] = "01";
                row["TaniSochiGroupNm"] = "接触ばっ気槽";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["TaniSochiCd"] = "04";
                row["TaniSochiNm"] = "沈殿槽";
                row["TaniSochiGroupCd"] = "01";
                row["TaniSochiGroupNm"] = "接触ばっ気槽";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["TaniSochiCd"] = "05";
                row["TaniSochiNm"] = "消毒槽";
                row["TaniSochiGroupCd"] = "01";
                row["TaniSochiGroupNm"] = "接触ばっ気槽";

                table.Rows.Add(row);
            }

            return table;
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("検査履歴");
        }

        private void SetSubTitle()
        {
            // TODO サブタイトル(パンくず)設定

            // TODO GetFormTransitionData

        }

        public void SetButtonValueCallBack(Button button, string formDatakey, string value, FormData formData)
        {
            button.Click +=
                delegate(object sender, EventArgs e)
                {
                    // TODO 入力済みの単位装置と、別の単位装置が選択された場合は、中分類以降の入力データを一旦無効にする（クリアする）

                    // 画面データの保存は、選択ボタン押下時のみ行う(次へボタン押下の場合は行わない)

                    #region 作業データ保存

                    // ボタン選択値を設定
                    formData.SetValue(formDatakey, value);

                    // TODO 汎用処理にする
                    formData.SetValue(KensaRirekiListFormData.TANI_SOCHI_NM, ((Button)sender).Text);

                    // 画面の現在入力内容の入力チェック(必要な場合)

                    // 画面の現在入力内容を保存する
                    SetFormData(formData);

                    // TODO 画面作業内容を保存
                    FormManager.GetInstance().SaveFormData(GetType(), formData);

                    #endregion

                    #region 画面遷移

                    ToNextForm();

                    #endregion
                };
        }

        /// <summary>
        /// OK(登録ボタン用)
        /// </summary>
        public void SetButtonEntryCallBack(Button button, string sochiCd, string sochiNm, TextBox value1, TextBox value2, FormData formData)
        {
            button.Click +=
                delegate(object sender, EventArgs e)
                {
                    // TODO 入力済みの単位装置と、別の単位装置が選択された場合は、中分類以降の入力データを一旦無効にする（クリアする）

                    // 画面データの保存は、選択ボタン押下時のみ行う(次へボタン押下の場合は行わない)

                    #region 作業データ保存

                    // 画面の現在入力内容の入力チェック(必要な場合)

                    // 画面の現在入力内容を保存する
                    // TODO 汎用処理にできるとベター
                    //SetFormData(formData);
                    (formData as KensaRirekiListFormData).SetTaniSochiScumValue(sochiCd, value1.Text, value2.Text);

                    // 画面作業内容を保存
                    FormManager.GetInstance().SaveFormData(GetType(), formData);

                    // TODO 実際には、DB登録を行うべき

                    #endregion

                    #region 画面遷移

                    // 画面遷移は行わない

                    // TODO メッセージは仮
                    TabMessageBox.Show2(sochiNm + "の登録を行いました。");

                    #endregion
                };
        }

        // TODO OKボタンを処理を記述する

        // TODO 装置種別によっては、追加の入力項目が発生する模様？(その場合は、引数を追加する)
        private Panel CreateElement(string taniSoutiName, string taniSoutiCd, string taniSoutiGrpCd, FormData formData)
        {
            #region デザインパラメータ設定

            Panel elementPanel = new Panel();
            Button taniSoutiButton = new Button();
            Panel scumPanel = new Panel();
            TextBox scumFromTextBox = new TextBox();
            TextBox scumToTextBox = new TextBox();
            Label scumLabel = new Label();
            Label scumBetLabel = new Label();
            Button taniSoutiOkButton = new Button();

            // 
            // elementPanel
            // 
            elementPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            elementPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            elementPanel.Controls.Add(taniSoutiOkButton);
            elementPanel.Controls.Add(scumPanel);
            elementPanel.Controls.Add(taniSoutiButton);
            elementPanel.Location = new System.Drawing.Point(13, 80);
            elementPanel.MinimumSize = new System.Drawing.Size(550, 100);
            elementPanel.Name = "elementPanel";
            elementPanel.Size = new System.Drawing.Size(700, 135);
            elementPanel.TabIndex = 1;
            // 
            // taniSoutiButton
            // 
            taniSoutiButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            taniSoutiButton.AutoSize = true;
            taniSoutiButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            taniSoutiButton.Location = new System.Drawing.Point(18, 32);
            taniSoutiButton.Margin = new System.Windows.Forms.Padding(20);
            taniSoutiButton.MinimumSize = new System.Drawing.Size(280, 86);
            taniSoutiButton.Name = "taniSoutiButton";
            taniSoutiButton.Size = new System.Drawing.Size(280, 60);
            taniSoutiButton.TabIndex = 0;
            taniSoutiButton.Text = "嫌気ろ床槽　第１槽";
            taniSoutiButton.UseVisualStyleBackColor = true;
            // 
            // scumPanel
            // 
            scumPanel.Controls.Add(scumToTextBox);
            scumPanel.Controls.Add(scumFromTextBox);
            scumPanel.Controls.Add(scumBetLabel);
            scumPanel.Controls.Add(scumLabel);
            scumPanel.Location = new System.Drawing.Point(317, 17);
            scumPanel.Name = "scumPanel";
            scumPanel.Size = new System.Drawing.Size(220, 110);
            scumPanel.TabIndex = 1;
            // 
            // scumFromTextBox
            // 
            scumFromTextBox.Location = new System.Drawing.Point(11, 46);
            scumFromTextBox.Name = "scumFromTextBox";
            scumFromTextBox.Size = new System.Drawing.Size(69, 47);
            scumFromTextBox.TabIndex = 1;
            // 
            // scumToTextBox
            // 
            scumToTextBox.Location = new System.Drawing.Point(136, 46);
            scumToTextBox.Name = "scumToTextBox";
            scumToTextBox.Size = new System.Drawing.Size(69, 47);
            scumToTextBox.TabIndex = 3;
            // 
            // scumLabel
            // 
            scumLabel.AutoSize = true;
            scumLabel.Location = new System.Drawing.Point(4, 5);
            scumLabel.Name = "scumLabel";
            scumLabel.Size = new System.Drawing.Size(126, 41);
            scumLabel.TabIndex = 0;
            scumLabel.Text = "スカム厚";
            // 
            // scumBetLabel
            // 
            scumBetLabel.AutoSize = true;
            scumBetLabel.Location = new System.Drawing.Point(86, 52);
            scumBetLabel.Name = "scumBetLabel";
            scumBetLabel.Size = new System.Drawing.Size(45, 41);
            scumBetLabel.TabIndex = 2;
            scumBetLabel.Text = "～";
            // 
            // taniSoutiOkButton
            // 
            taniSoutiOkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            taniSoutiOkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            taniSoutiOkButton.Location = new System.Drawing.Point(560, 32);
            taniSoutiOkButton.Margin = new System.Windows.Forms.Padding(20);
            taniSoutiOkButton.MinimumSize = new System.Drawing.Size(60, 60);
            taniSoutiOkButton.Name = "taniSoutiOkButton";
            taniSoutiOkButton.Size = new System.Drawing.Size(106, 86);
            taniSoutiOkButton.TabIndex = 2;
            taniSoutiOkButton.Text = "登録";
            taniSoutiOkButton.UseVisualStyleBackColor = true;

            #endregion

            // 個別パラメータ設定
            taniSoutiButton.Text = taniSoutiName;
            // TODO 消毒槽の消毒薬残量など、個別の外観検査結果を入力する場合がある模様？

            // TODO 実際には、DBの値を取得する
            string scumFrom;
            string scumTo;
            (formData as KensaRirekiListFormData).GetTaniSochiScumValue(taniSoutiCd, out scumFrom, out scumTo);

            scumFromTextBox.Text = scumFrom;
            scumToTextBox.Text = scumTo;

            // 単位装置ボタンイベント設定
            SetButtonValueCallBack(taniSoutiButton, KensaRirekiListFormData.TANI_SOCHI_CD, taniSoutiGrpCd, formData);

            // 登録ボタンイベント設定
            SetButtonEntryCallBack(taniSoutiOkButton, taniSoutiCd, taniSoutiName, scumFromTextBox, scumToTextBox, formData);

            return elementPanel;
        }

        private Panel CreateElement(DataRow row, FormData formData)
        {
            string tanisoutiCd = (string)row["TaniSochiCd"];
            string tanisoutiName = (string)row["TaniSochiNm"];
            string tanisoutiGrpCd = (string)row["TaniSochiGroupCd"];
            string tanisoutiGrpName = (string)row["TaniSochiGroupNm"];

            return CreateElement(tanisoutiName, tanisoutiCd, tanisoutiGrpCd, formData);
            //return CreateElement(tanisoutiName, tanisoutiCd);
        }

        private void elementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColKakkasho.Index)
            {
                TabMessageBox.Show2("機能説明:\n履歴の検査時の結果書を表示します。");
            }
        }

        private void elementDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == elementDataGridView.Columns["写真"].Index)
            {
                DirectoryInfo di = new DirectoryInfo(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE"));

                try
                {
                    FileInfo[] fi = di.GetFiles();

                    if (fi.Length > 0)
                    {
                        string path = Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE", fi[0].Name);

                        Process image = new Process();
                        image.StartInfo.FileName = path;
                        image.Start();

                        //Process myProcess = new Process();
                        //ProcessStartInfo myProcessStartInfo = new ProcessStartInfo("rundll32.exe");
                        //myProcessStartInfo.UseShellExecute = false;
                        //myProcessStartInfo.RedirectStandardOutput = true;
                        //myProcessStartInfo.Arguments = "\"C:\\Program Files\\Windows Photo Viewer\\PhotoViewer.dll\", ImageView_Fullscreen " + path;
                        //myProcess.StartInfo = myProcessStartInfo;
                        //myProcess.Start();
                    }
                    else
                    {
                        TabMessageBox.Show2("検査画像が保存されていません。");
                    }
                }
                catch
                {
                }

                return;
            }
        }
    }
}
