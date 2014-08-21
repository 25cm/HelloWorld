using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.DataSet.Ce;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiKensaKomokuMstDataSetTableAdapters;
using FukjTabletSystem.Properties;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class ChuBunruiSentakuForm : TabBaseForm
    {
        #region フォームデータ定義

        public class ChuBunruiSentakuFormData : FormData
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

        public ChuBunruiSentakuForm()
        {
            InitializeComponent();

        }

        #endregion

        public override FormData InitFormData()
        {
            FormData ret = new ChuBunruiSentakuFormData();
            ret.TransitionDispName = "";

            return ret;
            // TODO 
        }

        public override DataTable GetDBFormData()
        {
            // TODO DAを作成する
            TaniSochiKensaKomokuMstDataSet.TaniSochiKensaKomokuMstDataTable table;
            table = new TaniSochiKensaKomokuMstTableAdapter().GetData();

            // TODO GetDB Value

            //DataTable table = new DataTable();
            ////table.Columns.Add("TaniSochiCd", typeof(string));
            ////table.Columns.Add("TaniSochiNm", typeof(string));
            //table.Columns.Add("TaniSochiGroupCd", typeof(string));
            //table.Columns.Add("TaniSochiGroupNm", typeof(string));
            //table.Columns.Add("TaniSochiKensaKomokuCd", typeof(string));
            //table.Columns.Add("TaniSochiKensaKomokuNm", typeof(string));

            //// TODO DBからデータを取得する様にする
            //{
            //    DataRow row = table.NewRow();
            //    //row["TaniSochiCd"] = "01";
            //    //row["TaniSochiNm"] = "嫌気ろ床槽　第１槽";
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["TaniSochiGroupCd"] = "01";
            //    row["TaniSochiGroupNm"] = "接触ばっ気槽";
            //    row["TaniSochiKensaKomokuCd"] = "01";
            //    row["TaniSochiKensaKomokuNm"] = "汚泥・スカム";

            //    table.Rows.Add(row);
            //}

            return table;
        }

        public override void SetTitle()
        {
            string prevName = FormManager.GetInstance().GetFormData(typeof(DaiBunruiSentakuForm)).GetValue(DaiBunruiSentakuForm.DaiBunruiSentakuFormData.TANI_SOCHI_NM);

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
                    formData.SetValue(ChuBunruiSentakuFormData.TANI_SOCHI_KENSA_KOMOKU_NM, ((Button)sender).Text);

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

        private void ChuBunruiSentakuForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 表示候補取得
                FormData formData = InitFormData();

                DataTable table = GetDBFormData();

                SetTitle();

                string sochi = FormManager.GetInstance().GetFormData(typeof(DaiBunruiSentakuForm)).GetValue(DaiBunruiSentakuForm.DaiBunruiSentakuFormData.TANI_SOCHI_GRP_CD);

                // 前画面までの入力で、表示候補を絞る
                DataRow[] rows = table.Select(string.Format("KensaTaniSochiGroupCd = '{0}'", sochi));

                for (int i = 0; i < rows.Length; i++)
                {
                    string cd = (string)rows[i]["TaniSochiKensaKomokuCd"];
                    string name = (string)rows[i]["TaniSochiKensaKomokuNm"];

                    // ボタン追加
                    selectButtonPanel1.AddButton(name);
                    SetButtonValueCallBack(selectButtonPanel1.GetButton(i), ChuBunruiSentakuFormData.TANI_SOCHI_KENSA_KOMOKU_CD, cd, formData);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
    }
}
