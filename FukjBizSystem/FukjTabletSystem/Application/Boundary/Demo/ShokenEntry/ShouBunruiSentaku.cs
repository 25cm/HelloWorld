using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.DataSet.Ce;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiKensaJokyoMstDataSetTableAdapters;
using FukjTabletSystem.Properties;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class ShouBunruiSentakuForm : TabBaseForm
    {
        #region フォームデータ定義

        public class ShouBunruiSentakuFormData : FormData
        {
            public static string TANI_SOCHI_KENSA_JOKYO_CD = "TaniSochiKensaJokyoCd";
            public static string TANI_SOCHI_KENSA_JOKYO_NM = "TaniSochiKensaJokyoNm";

            string taniSoutiCd = string.Empty;

            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);

                if (dataKey == TANI_SOCHI_KENSA_JOKYO_CD)
                {
                    taniSoutiCd = value;
                }
            }
        }

        #endregion

        public ShouBunruiSentakuForm()
        {
            InitializeComponent();
        }

        public override DataTable GetDBFormData()
        {
            // TODO DAを作成する
            TaniSochiKensaJokyoMstDataSet.TaniSochiKensaJokyoMstDataTable table;
            table = new TaniSochiKensaJokyoMstTableAdapter().GetData();

            //DataTable table = new DataTable();
            ////table.Columns.Add("TaniSochiCd", typeof(string));
            ////table.Columns.Add("TaniSochiNm", typeof(string));
            //table.Columns.Add("TaniSochiGroupCd", typeof(string));
            //table.Columns.Add("TaniSochiGroupNm", typeof(string));
            //table.Columns.Add("TaniSochiKensaKomokuCd", typeof(string));
            //table.Columns.Add("TaniSochiKensaKomokuNm", typeof(string));
            //table.Columns.Add("TaniSochiKensaJokyoCd", typeof(string));
            //table.Columns.Add("TaniSochiKensaJokyoNm", typeof(string));
            

            //// TODO DBからデータを取得する様にする
            //{
            //    DataRow row = table.NewRow();
            //    //row["TaniSochiCd"] = "01";
            //    //row["TaniSochiNm"] = "嫌気ろ床槽　第１槽";
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //    row["TaniSochiKensaJokyoCd"] = "01";
            //    row["TaniSochiKensaJokyoNm"] = "堆積・浮上";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //    row["TaniSochiKensaJokyoCd"] = "02";
            //    row["TaniSochiKensaJokyoNm"] = "接合部隙間";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //    row["TaniSochiKensaJokyoCd"] = "02";
            //    row["TaniSochiKensaJokyoNm"] = "接合部隙間";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //    row["TaniSochiKensaJokyoCd"] = "02";
            //    row["TaniSochiKensaJokyoNm"] = "接合部隙間";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";
            //    row["TaniSochiKensaJokyoCd"] = "02";
            //    row["TaniSochiKensaJokyoNm"] = "接合部隙間";

            //    table.Rows.Add(row);
            //}

            return table;
        }

        public override void SetTitle()
        {
            string prevName = FormManager.GetInstance().GetFormData(typeof(ChuBunruiSentakuForm)).GetValue(ChuBunruiSentakuForm.ChuBunruiSentakuFormData.TANI_SOCHI_KENSA_KOMOKU_NM);

            headerControl1.SetTitle(prevName);
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
                    formData.SetValue(ShouBunruiSentakuFormData.TANI_SOCHI_KENSA_JOKYO_NM, ((Button)sender).Text);

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

        private void ShouBunruiSentakuForm_Load(object sender, EventArgs e)
        {
            // 表示候補取得
            FormData formData = InitFormData();

            DataTable table = GetDBFormData();

            SetTitle();

            string sochi = FormManager.GetInstance().GetFormData(typeof(DaiBunruiSentakuForm)).GetValue(DaiBunruiSentakuForm.DaiBunruiSentakuFormData.TANI_SOCHI_GRP_CD);
            string komoku = FormManager.GetInstance().GetFormData(typeof(ChuBunruiSentakuForm)).GetValue(ChuBunruiSentakuForm.ChuBunruiSentakuFormData.TANI_SOCHI_KENSA_KOMOKU_CD);

            // 前画面までの入力で、表示候補を絞る
            DataRow[] rows = table.Select(string.Format("KensaTaniSochiGroupCd = '{0}' AND TaniSochiKensaKomokuCd = '{1}'", sochi, komoku));

            for (int i = 0; i < rows.Length; i++)
            {
                string cd = (string)rows[i]["TaniSochiKensaJokyoCd"];
                string name = (string)rows[i]["TaniSochiKensaJokyoNm"];

                // ボタン追加
                buttonLayoutPanel.AddButton(name);
                SetButtonValueCallBack(buttonLayoutPanel.GetButton(i), ShouBunruiSentakuFormData.TANI_SOCHI_KENSA_JOKYO_CD, cd, formData);
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
