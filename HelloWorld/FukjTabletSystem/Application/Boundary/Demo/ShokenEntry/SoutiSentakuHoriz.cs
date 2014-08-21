using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiGroupMstDataSetTableAdapters;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiMstDataSetTableAdapters;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class SoutiSentakuHorizForm : TabBaseFormHoriz
    {
        #region フォームデータ定義

        public class SoutiSentakuHorizFormData : FormData
        {
            public static string TANI_SOCHI_KENSA_KOMOKU_CD = "TaniSochiKensaKomokuCd";
            public static string TANI_SOCHI_KENSA_KOMOKU_NM = "TaniSochiKensaKomokuNm";

            string taniSoutiCd = string.Empty;

            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);

                if (dataKey == TANI_SOCHI_KENSA_KOMOKU_CD)
                {
                    taniSoutiCd = value;
                }
            }
        }

        #endregion

        #region

        public string TaniSotiGroupCd;
        public string TaniSotiGroupNm;
        public string TaniSotiNm;

        #endregion

        #region

        public SoutiSentakuHorizForm()
        {
            InitializeComponent();

        }

        #endregion

        DataTable soutiGroupDataTable = null;
        DataTable soutiDataTable = null;

        public override FormData InitFormData()
        {
            FormData ret = new SoutiSentakuHorizFormData();
            ret.TransitionDispName = "";

            return ret;
            // TODO 
        }

        public void GetDBFormData(DataTable[] tables)
        {
            // TODO 仮画面につき、生成データの表示・動作のみでよい

            // TODO GetDB Value

            // 大分類

            //{
            //    DataTable table = new DataTable();
            //    table.TableName = "TaniSochiGroupMst";
            //    table.Columns.Add("TaniSochiCd", typeof(string));
            //    table.Columns.Add("TaniSochiNm", typeof(string));
            //    table.Columns.Add("TaniSochiGroupCd", typeof(string));
            //    table.Columns.Add("TaniSochiGroupNm", typeof(string));
            //    /*
            //    table.Columns.Add("TaniSochiKensaKomokuCd", typeof(string));
            //    table.Columns.Add("TaniSochiKensaKomokuNm", typeof(string));
            //    */

            //    tables[0] = table;

            //    // TODO DBからデータを取得する様にする
            //    {
            //        DataRow row = table.NewRow();
            //        row["TaniSochiCd"] = "01";
            //        row["TaniSochiNm"] = "嫌気ろ床槽　第１槽";
            //        row["TaniSochiGroupCd"] = "01";
            //        row["TaniSochiGroupNm"] = "嫌気ろ床槽（類似）";
            //        /*
            //        row["TaniSochiKensaKomokuCd"] = "01";
            //        row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //        */

            //        table.Rows.Add(row);
            //    }
            //    /*
            //    {
            //        DataRow row = table.NewRow();
            //        row["TaniSochiCd"] = "02";
            //        row["TaniSochiNm"] = "嫌気ろ床槽　第２槽";
            //        row["TaniSochiGroupCd"] = "01";
            //        row["TaniSochiGroupNm"] = "嫌気ろ床槽（類似）２";

            //        table.Rows.Add(row);
            //    }
            //    {
            //        DataRow row = table.NewRow();
            //        row["TaniSochiCd"] = "03";
            //        row["TaniSochiNm"] = "接触ばっ気槽";
            //        row["TaniSochiGroupCd"] = "01";
            //        row["TaniSochiGroupNm"] = "ばっ気型二次処理槽";

            //        table.Rows.Add(row);
            //    }
            //    {
            //        DataRow row = table.NewRow();
            //        row["TaniSochiCd"] = "04";
            //        row["TaniSochiNm"] = "沈殿槽";
            //        row["TaniSochiGroupCd"] = "01";
            //        row["TaniSochiGroupNm"] = "沈殿槽等";

            //        table.Rows.Add(row);
            //    }
            //    {
            //        DataRow row = table.NewRow();
            //        row["TaniSochiCd"] = "05";
            //        row["TaniSochiNm"] = "消毒槽";
            //        row["TaniSochiGroupCd"] = "01";
            //        row["TaniSochiGroupNm"] = "消毒槽";

            //        table.Rows.Add(row);
            //    }
            //    */

            //    table.AcceptChanges();
            //}

            // 単位装置グループ
            {
                tables[0] = new TaniSochiGroupMstTableAdapter().GetData();
            }

            // TODO 単位装置マスタは廃止予定
            // 単位装置
            {
                tables[1] = new TaniSochiMstTableAdapter().GetData();
            }
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("単位装置選択");
        }

        public void SetButtonValueCallBack(Button button, string formDatakey, string value, FormData formData)
        {
            button.Click +=
                delegate(object sender, EventArgs e)
                {

                    #region 作業データ保存

                    // ボタン選択値を設定
                    formData.SetValue(formDatakey, value);

                    // TODO 汎用処理にする
                    formData.SetValue(SoutiSentakuHorizFormData.TANI_SOCHI_KENSA_KOMOKU_NM, ((Button)sender).Text);

                    // 画面の現在入力内容の入力チェック(必要な場合)

                    // 画面の現在入力内容を保存する
                    SetFormData(formData);

                    FormManager.GetInstance().SaveFormData(GetType(), formData);

                    #endregion

                    #region 画面遷移

                    ToNextForm();

                    #endregion
                };
        }

        #region イベント

        private void SoutiSentakuHorizForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
                {
                    // 表示候補取得
                    FormData formData = InitFormData();

                    WindowState = FormWindowState.Maximized;

                    DataTable[] tables = new DataTable[2];
                    GetDBFormData(tables);

                    soutiGroupDataTable = tables[0];
                    soutiDataTable = tables[1];

                    SetTitle();

                    // 大分類一覧設定
                    soutiGroupListBox.DisplayMember = "TaniSochiGroupNm";
                    soutiGroupListBox.ValueMember = "TaniSochiGroupCd";
                    soutiGroupListBox.DataSource = soutiGroupDataTable.Select(string.Empty);
                    //daiListBox.DisplayMember = "TaniSochiGroupNm";
                });
        }

        private void soutiAddButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    // TODO 選択装置グループを呼出元に返す
                    DataRow row = (DataRow)soutiGroupListBox.SelectedItem;

                    TaniSotiGroupCd = (string)row["TaniSochiGroupCd"];
                    TaniSotiGroupNm = (string)row["TaniSochiGroupNm"];
                    TaniSotiNm = soutiNmTextBox.Text;

                    Close();
                });
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    // TODO 所見確定登録
                    // TODO デモ版では、メッセージボックス表示
                    Close();
                });
        }

        private void daiListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (soutiGroupListBox.SelectedValue == null) { return; }

                    // 装置グループ名を単位装置名のデフォルトとして使用
                    DataRow row = (DataRow)soutiGroupListBox.SelectedItem;

                    soutiNmTextBox.Text = (string)row["TaniSochiGroupNm"];
                });
        }

        #endregion

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

        #region method


        #endregion
    }
}
