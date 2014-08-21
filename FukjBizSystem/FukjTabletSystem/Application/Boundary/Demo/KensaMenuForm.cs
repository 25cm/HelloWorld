using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.MapWorks;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Base.Boundary;

namespace FukjTabletSystem.Application.Boundary.Demo
{
    public partial class KensaMenuForm : BaseTabletForm2
    {
        public KensaMenuForm(string kensaKashoName)
        {
            InitializeComponent();

            // 引数の保存

            //titleLabel.Text += string.Format(" : {0}", kensaKashoName);
        }

        #region closeButton_Click(object sender, EventArgs e)
        /// <summary>
        /// 閉じるボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region backButton_Click(object sender, EventArgs e)
        /// <summary>
        /// 戻るボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
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

        private void mapButton_Click(object sender, EventArgs e)
        {
            // TODO: 地図を起動する
            //JokasoMapForm frm = new JokasoMapForm(dataGridView[1, e.RowIndex].Value.ToString());
            MapWorksForm frm = new MapWorksForm();
            frm.Show();

            return;
        }

        #region gpsButton_Click(object sender, EventArgs e)
        /// <summary>
        /// GPSボタン（アイコン）クリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gpsButton_Click(object sender, EventArgs e)
        {
            object[] ret;

            using (ProgressDialog sg = new ProgressDialog(new DoWorkEventHandler(GetGPS_DoWork)))
            {
                //進行状況ダイアログを表示する
                DialogResult result = sg.ShowDialog(this);

                ret = (object[])sg.Result;
            }

            if (ret != null && (bool)ret[0])
            {
                TabMessageBox.Show2(string.Format("緯度[{0}], 経度[{1}]", ret[1], ret[2]));
            }
            else
            {
                TabMessageBox.Show2("タイムアウト");
            }
        }
        #endregion

        #region GetGPS_DoWork(object sender, DoWorkEventArgs e)
        /// <summary>
        /// GPS取得処理ワーカー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetGPS_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;

            // 緯度
            double latitude = 0;
            // 経度
            double longitude = 0;
            // 結果
            bool ret = false;

            //コントロールの表示を変更する
            bw.ReportProgress(90, null);

            // GPS入力の開始
            using (GPSInfo gps = new GPSInfo())
            {
                // 位置情報を取得
                ret = gps.GetLocation(ref latitude, ref longitude, Settings.Default.GpsWaitTimer);

                // GP入力の終了
                gps.Dispose();
            }

            //コントロールの表示を変更する
            bw.ReportProgress(100, null);

            //結果を設定する
            e.Result = new object[3] { ret, latitude, longitude };

        }
        #endregion
    }
}
