using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.BusinessLogic.SuishitsuKensa.SuishitsuKensaOutput;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjTabletSystem.Application.Boundary.Demo.SuishitsuKensa
{
    public partial class SuishitsuKensaOutputForm : TabBaseForm
    {
        #region フォームデータ定義

        public class SuishitsuKensaOutputFormData : FormData
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

        public SuishitsuKensaOutputForm()
        {
            InitializeComponent();
        }

        private void SuishitsuKensaOutputForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
            {
                // 表示候補取得
                FormData formData = InitFormData();

                // コンボボックス設定
                // 検査種別は必須条件とする
                //kensaKbnComboBox.Items.Add("");
                kensaKbnComboBox.Items.Add("9条");
                kensaKbnComboBox.Items.Add("11条");

                // 9条を初期選択する
                kensaKbnComboBox.SelectedIndex = 0;

                formData = GetFormData();

                SetTitle();

                DoSearch();
            });
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {

                    DoSearch();

                });
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (elementDataGridView.Rows.Count == 0)
                    {
                        TabMessageBox.Show2("出力対象の検査予定が存在しません。");
                        return;
                    }

                    using (ProgressDialog sg = new ProgressDialog(new DoWorkEventHandler(OutputReport_DoWork)))
                    {
                        //進行状況ダイアログを表示する
                        DialogResult result = sg.ShowDialog(this);
                    }

                });
        }

        #region OutputReport_DoWork(object sender, DoWorkEventArgs e)
        /// <summary>
        /// 処理ワーカー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputReport_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;

            // TODO 出力帳票チェックリストを表示する
            // TODO 出来れば、帳票の一般名と、帳票フォーマット名の対応付けを整理する

            // TODO 稼動モジュールに於いては、AL呼出とする
            // TODO 
            IPrintToushidoBLInput input = new PrintToushidoBLInput();

            List<string> noList = new List<string>();
            foreach (DataGridViewRow gridRow in elementDataGridView.Rows)
            {
                noList.Add((string)gridRow.Cells[ColUketsukeNo.Index].Value);
            }

            //コントロールの表示を変更する
            bw.ReportProgress(90, null);

            input.uketsukeNoList = noList;
            input.AfterDispFlg = true;
            input.PrintDirectory = Properties.Settings.Default.PrintDirectory;
            // TODO 実環境では、フォーマット名は定数値を使用する
            input.FormatPath = Path.GetFullPath(Path.Combine(Properties.Settings.Default.PrintFormatFolder, "9条_透視度1001.xls"));
            IPrintToushidoBLOutput output = new PrintToushidoBusinessLogic().Execute(input);
                        
            //コントロールの表示を変更する
            bw.ReportProgress(100, null);
        }
        #endregion

        private void importButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    // TODO 取込んだ場合は受付番号（キー）を基準に更新する
                    // TODO デモの場合は、仮想テーブル（結合済みの状態を想定）に対して更新を行う

                    // TODO 7/29デモ時点では、運用イメージが示せればよい

                    // ディレクトリ存在チェック
                    string printDir = @"C:\Fukj\Print\Suishitsu";

                    // TODO 仮でここで作成
                    if (!Directory.Exists(printDir))
                    {
                        Directory.CreateDirectory(printDir);
                    }

                    // TODO ダイアログのフォントサイズを変更する場合は、システムフォントのサイズを変更する必要がある。。。（アプリケーションで勝手に変更するのはよろしくない）
                    // 取込フォルダ選択ダイアログを表示
                    //FolderBrowserDialog dia = new FolderBrowserDialog();
                    FolderDialog dia = new FolderDialog();
                    dia.SelectedPath = printDir;
                    dia.ShowDialog();

                    // TODO 7/29デモ時点では、機能説明ダイアログを表示
                    TabMessageBox.Show2("機能説明:\n選択したフォルダ内の帳票をシステムに取込、検査情報を更新します。");

                    if (table == null)
                    {
                        return;
                    }

                    // TODO Excelからのデータを保持する

                    // TODO Excelからの取込データを仮想テーブルに反映する
                    foreach (DataRow row in new DataTable().Rows)
                    {
                        // TODO 
                    }
                });
        }

        public override FormData InitFormData()
        {
            FormData ret = new SuishitsuKensaOutputFormData();

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
            table.Columns.Add("UketsukeNo", typeof(string));
            table.Columns.Add("KensaKbn", typeof(string));
            table.Columns.Add("SetchibashoAdr", typeof(string));
            table.Columns.Add("KensaYoteiNen", typeof(string));
            table.Columns.Add("KensaYoteiTsuki", typeof(string));
            table.Columns.Add("KensaYoteiBi", typeof(string));

            // TODO DBからデータを取得する様にする
            {
                DataRow row = table.NewRow();
                row["UketsukeNo"] = "1001";
                row["KensaKbn"] = "9条";
                row["SetchibashoAdr"] = "福岡県博多";
                row["KensaYoteiNen"] = "2014";
                row["KensaYoteiTsuki"] = "07";
                row["KensaYoteiBi"] = "15";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["UketsukeNo"] = "1002";
                row["KensaKbn"] = "9条";
                row["SetchibashoAdr"] = "福岡県博多";
                row["KensaYoteiNen"] = "2014";
                row["KensaYoteiTsuki"] = "07";
                row["KensaYoteiBi"] = "15";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["UketsukeNo"] = "1003";
                row["KensaKbn"] = "11条";
                row["SetchibashoAdr"] = "福岡県博多";
                row["KensaYoteiNen"] = "2014";
                row["KensaYoteiTsuki"] = "07";
                row["KensaYoteiBi"] = "29";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();
                row["UketsukeNo"] = "1004";
                row["KensaKbn"] = "9条";
                row["SetchibashoAdr"] = "福岡県博多";
                row["KensaYoteiNen"] = "2014";
                row["KensaYoteiTsuki"] = "07";
                row["KensaYoteiBi"] = "30";

                table.Rows.Add(row);
            }

            return table;
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("水質検査帳票");
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
                    formData.SetValue(SuishitsuKensaOutputFormData.TANI_SOCHI_NM, ((Button)sender).Text);

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
                    (formData as SuishitsuKensaOutputFormData).SetTaniSochiScumValue(sochiCd, value1.Text, value2.Text);

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

        // TODO デモ用のテストデータ
        private DataTable table = null;

        private void DoSearch()
        {
            table = GetDBFormData();

            // 対象の水質検査一覧を表示する

            // TODO 実環境では、DBサーバーから取得する方向だが、デモ環境では、ローカルDBから取得する

            StringBuilder buf = new StringBuilder();
            if (!string.IsNullOrEmpty(uketsukeNoFromTextBox.Text))
            {
                if (buf.Length > 0)
                {
                    buf.Append(" AND ");
                }
                buf.Append(string.Format("UketsukeNo >= '{0}'", uketsukeNoFromTextBox.Text));
            }
            if (!string.IsNullOrEmpty(uketsukeNoToTextBox.Text))
            {
                if (buf.Length > 0)
                {
                    buf.Append(" AND ");
                }
                buf.Append(string.Format("UketsukeNo <= '{0}'", uketsukeNoToTextBox.Text));
            }
            if (!string.IsNullOrEmpty(kensaKbnComboBox.Text))
            {
                if (buf.Length > 0)
                {
                    buf.Append(" AND ");
                }
                buf.Append(string.Format("KensaKbn = '{0}'", kensaKbnComboBox.Text));
            }

            DataRow[] rows = table.Select(buf.ToString());

            elementDataGridView.Rows.Clear();

            for (int i = 0; i < rows.Length; i++)
            {
                string dateStr = (string)rows[i]["KensaYoteiNen"] + "/" + (string)rows[i]["KensaYoteiTsuki"] + "/" + (string)rows[i]["KensaYoteiBi"];
                elementDataGridView.Rows.Add(rows[i]["UketsukeNo"], rows[i]["KensaKbn"], rows[i]["SetchibashoAdr"], dateStr);
            }
        }

        #region cameraButton_Click(object sender, EventArgs e)
        /// <summary>
        /// カメラボタン（アイコン）クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraButton_Click(object sender, EventArgs e)
        {
            //using (CaptureDialog frm = new CaptureDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            //{
            //    frm.ShowDialog();
            //}

            using (GetPhotoDialog frm = new GetPhotoDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            {
                frm.ShowDialog();
            }
        }
        #endregion

        #region inputButton_Click(object sender, EventArgs e)
        /// <summary>
        /// 手書きメモボタン（アイコン）クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputButton_Click(object sender, EventArgs e)
        {
            using (InkCanvasDialog frm = new InkCanvasDialog(Path.Combine(Settings.Default.PicDataRootDirectory, "SAVE")))
            {
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
