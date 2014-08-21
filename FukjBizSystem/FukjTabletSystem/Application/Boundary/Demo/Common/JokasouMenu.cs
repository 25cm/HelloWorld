using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.ShokenEntry;
using FukjTabletSystem.Application.Boundary.Demo.ShoruiKensa;
using FukjTabletSystem.Application.Boundary.Demo.SuishitsuKensa;
using FukjTabletSystem.Application.Boundary.MapWorks;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public partial class JokasoMenuForm : TabBaseForm
    {
        #region フォームデータ定義

        public class JokasoMenuFormData : FormData
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

        public JokasoMenuForm()
        {
            InitializeComponent();
        }

        private void JokasoMenuForm_Load(object sender, EventArgs e)
        {
            // 表示候補取得
            FormData formData = InitFormData();

            formData = GetFormData();

            DataTable table = GetDBFormData();

            SetTitle();

            // TODO 実際の各画面クラスを指定する
            // TODO 仕様確定後、必要であれば、固定呼出に焼き付ける
            // TODO 起動パラメータ（浄化槽）を遷移先画面に引き渡す
            // TODO モックの段階なので、ほどほどで
            // メニューボタン追加
            {
                selectButtonPanel1.AddButton("検査開始");
                selectButtonPanel1.GetButton(0).Click +=
                    delegate(object sender2, EventArgs e2)
                    {
                        DateTime now = DateTime.Now;

                        if (TabMessageBox.Show2(TabMessageBox.Type.YesNo, "確認", string.Format("開始時刻:{0}\r\n\r\n検査時間の計測を開始します。よろしいですか？", now.ToString("HH時mm分ss秒"))) == System.Windows.Forms.DialogResult.Yes)
                        {
                            AppData.SetStartTime(now);

                            selectButtonPanel1.GetButton(0).Enabled = false;
                            selectButtonPanel1.GetButton(1).Enabled = true;
                            selectButtonPanel1.GetButton(2).Enabled = true;
                            selectButtonPanel1.GetButton(3).Enabled = true;
                            selectButtonPanel1.GetButton(4).Enabled = true;
                            selectButtonPanel1.GetButton(5).Enabled = true;
                            selectButtonPanel1.GetButton(6).Enabled = true;
                            selectButtonPanel1.GetButton(7).Enabled = true;
                            selectButtonPanel1.GetButton(8).Enabled = true;
                            selectButtonPanel1.GetButton(9).Enabled = true;
                        }
                    };
            }
            {
                selectButtonPanel1.AddButton("水質検査");
                Dictionary<string, string> paramMap = new Dictionary<string, string>();
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(1), typeof(SuishitsuKensaEntryForm), this);
            }
            {
                selectButtonPanel1.AddButton("外観検査");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(2), typeof(DaiBunruiSentakuForm), this);
            }
            {
                selectButtonPanel1.AddButton("書類検査");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(3), typeof(ShoruiKensaEntryForm), this);
                selectButtonPanel1.GetButton(3).Visible = false;
            }
            /*
            {
                selectButtonPanel1.AddButton("浄化槽情報");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(3), typeof(DaiBunruiSentakuForm), this);
            }
            */
            /*
            {
                selectButtonPanel1.AddButton("検査履歴");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(4), typeof(DaiBunruiSentakuForm), this);
            }
            {
                selectButtonPanel1.AddButton("手書き");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(5), typeof(DaiBunruiSentakuForm), this);
            }
            */
            {
                selectButtonPanel1.AddButton("結果書プレビュー");
                selectButtonPanel1.GetButton(4).Click +=
                    delegate(object sender2, EventArgs e2)
                    {
                        TabMessageBox.Show2("機能説明:\n入力済みの検査結果から、結果書の出力プレビューを表示します");
                    };

                //selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(6), typeof(DaiBunruiSentakuForm), this);
            }
            // TODO 仮画面（別途起動も検討する）
            {
                selectButtonPanel1.AddButton("外観検査(横)");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(5), typeof(GaikanKensaHorizForm), this);
            }
            {
                selectButtonPanel1.AddButton("数値入力");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(6), typeof(KensaKekkaNumEntryForm), this);
            }
            {
                selectButtonPanel1.AddButton("書類検査");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(7), typeof(ShoruiKensaForm), this);
            }
            {
                selectButtonPanel1.AddButton("モニタリング");
                selectButtonPanel1.SetButtonStdTransitionCallBack(selectButtonPanel1.GetButton(8), typeof(MonitoringForm), this);
            }
            {
                selectButtonPanel1.AddButton("検査終了");
                selectButtonPanel1.GetButton(9).Click +=
                    delegate(object sender2, EventArgs e2)
                    {
                        DateTime now = DateTime.Now;

                        if (TabMessageBox.Show2(TabMessageBox.Type.YesNo, "確認", string.Format("終了時刻:{0}\r\n\r\n検査を終了します。原状回復しましたか？\r\n(操作スイッチ・マンホール・制御盤、\r\n　照明、フェンス類の施錠等)", now.ToString("HH時mm分ss秒")), Color.Yellow, Color.Red) == System.Windows.Forms.DialogResult.Yes)
                        {
                            TabMessageBox.Show2(string.Format("検査時間は{0}時間{1}分{2}秒です。", (now - AppData.GetStartTime().Value).Hours, (now - AppData.GetStartTime().Value).Minutes, (now - AppData.GetStartTime().Value).Seconds));

                            selectButtonPanel1.GetButton(0).Enabled = true;
                            selectButtonPanel1.GetButton(1).Enabled = false;
                            selectButtonPanel1.GetButton(2).Enabled = false;
                            selectButtonPanel1.GetButton(3).Enabled = false;
                            selectButtonPanel1.GetButton(4).Enabled = false;
                            selectButtonPanel1.GetButton(5).Enabled = false;
                            selectButtonPanel1.GetButton(6).Enabled = false;
                            selectButtonPanel1.GetButton(7).Enabled = false;
                            selectButtonPanel1.GetButton(8).Enabled = false;
                            selectButtonPanel1.GetButton(9).Enabled = false;

                            AppData.SetStartTime(null);
                        }
                    };
            }

            if (AppData.GetStartTime().HasValue)
            {
                selectButtonPanel1.GetButton(0).Enabled = false;
                selectButtonPanel1.GetButton(1).Enabled = true;
                selectButtonPanel1.GetButton(2).Enabled = true;
                selectButtonPanel1.GetButton(3).Enabled = true;
                selectButtonPanel1.GetButton(4).Enabled = true;
                selectButtonPanel1.GetButton(5).Enabled = true;
                selectButtonPanel1.GetButton(6).Enabled = true;
                selectButtonPanel1.GetButton(7).Enabled = true;
                selectButtonPanel1.GetButton(8).Enabled = true;
                selectButtonPanel1.GetButton(9).Enabled = true;
            }
            else
            {
                selectButtonPanel1.GetButton(0).Enabled = true;
                selectButtonPanel1.GetButton(1).Enabled = false;
                selectButtonPanel1.GetButton(2).Enabled = false;
                selectButtonPanel1.GetButton(3).Enabled = false;
                selectButtonPanel1.GetButton(4).Enabled = false;
                selectButtonPanel1.GetButton(5).Enabled = false;
                selectButtonPanel1.GetButton(6).Enabled = false;
                selectButtonPanel1.GetButton(7).Enabled = false;
                selectButtonPanel1.GetButton(8).Enabled = false;
                selectButtonPanel1.GetButton(9).Enabled = false;
            }
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("検査メニュー");
        }

        private void mapButton_Click(object sender, EventArgs e)
        {
            // TODO: 地図を起動する
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
                //MessageBox.Show(string.Format("緯度[{0}], 経度[{1}]", ret[1], ret[2]));
                TabMessageBox.Show2(TabMessageBox.Type.Info, "GPS情報", string.Format("緯度[{0}], 経度[{1}]", ret[1], ret[2]));
            }
            else
            {
                //MessageBox.Show("タイムアウト");
                TabMessageBox.Show2(TabMessageBox.Type.Warn, "タイムアウトしました");
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
