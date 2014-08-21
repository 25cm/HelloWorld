using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjTabletSystem.Application.Boundary.Demo
{
    public partial class ShoruiKensaForm : TabBaseFormHoriz
    {
        #region フォームデータ定義

        public class ShoruiKensaFormData : FormData
        {
            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);
            }
        }

        #endregion

        string[] comboKirokuUmu = new string[] { "○", "△", "×", "－" };
        string[] comboNaiyou = new string[] { "内容１", "内容２", "内容３", "内容４", "内容５" };
        string[] comboKaisuu = new string[] { "１", "２", "３", "４", "５" };
        string[] comboKiteiKaisuu = new string[] { "１", "２", "３", "４", "５" };
        string[] comboJisshiKaisuu = new string[] { "１", "２", "３", "４", "５" };
        string[] comboZenkaiJisshiBi = new string[] { DateTime.Today.AddDays(-5).ToString("yyyy年MM月dd日"), 
            DateTime.Today.AddDays(-4).ToString("yyyy年MM月dd日"), 
            DateTime.Today.AddDays(-3).ToString("yyyy年MM月dd日"), 
            DateTime.Today.AddDays(-2).ToString("yyyy年MM月dd日"), 
            DateTime.Today.AddDays(-1).ToString("yyyy年MM月dd日") };

        public ShoruiKensaForm()
        {
            InitializeComponent();
        }

        public override FormData InitFormData()
        {
            FormData ret = new ShoruiKensaFormData();
            ret.TransitionDispName = "";

            return ret;
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("書類検査");
        }

        private void ShoruiKensaForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
                {
                    // 表示候補取得
                    FormData formData = InitFormData();

                    WindowState = FormWindowState.Maximized;
                    
                    SetTitle();
                });

            burowaGridView.Rows.Add("記録の有無", "", "");
            burowaGridView.Rows.Add("内容", "", "");
            burowaGridView.Rows.Add("回数", "", "");
            burowaGridView.Rows.Add("規定回数", "", "");
            burowaGridView.Rows.Add("実施回数", "", "");
            burowaGridView.Rows.Add("前回実施日", "", "");

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

        private void kakuteiButton_Click(object sender, EventArgs e)
        {
            TabMessageBox.Show2("機能説明：\n端末内に検査結果を登録します。");
            
            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(typeof(JokasoMenuForm));
            objNextForm.Show();

            // 次画面を閉じる
            Close();
        }
        
        private void burowaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == burowaGridView.Columns["HOSHU"].Index ||
                    e.ColumnIndex == burowaGridView.Columns["SEISOU"].Index)
                {
                    if (burowaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode)
                    {
                        return;
                    }

                    DataGridViewComboBoxCell cbc = (DataGridViewComboBoxCell)burowaGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    cbc.Items.Clear();

                    if (e.RowIndex == 0)
                    {
                        cbc.Items.AddRange(comboKirokuUmu);
                    }
                    else if (e.RowIndex == 1)
                    {
                        cbc.Items.AddRange(comboNaiyou);
                    }
                    else if (e.RowIndex == 2)
                    {
                        cbc.Items.AddRange(comboKaisuu);
                    }
                    else if (e.RowIndex == 3)
                    {
                        cbc.Items.AddRange(comboKiteiKaisuu);
                    }
                    else if (e.RowIndex == 4)
                    {
                        cbc.Items.AddRange(comboJisshiKaisuu);
                    }
                    else if (e.RowIndex == 5)
                    {
                        cbc.Items.AddRange(comboZenkaiJisshiBi);
                    }

                    GetKeybordAndSendF4();
                }
            }
            catch
            {
            }
        }
        
        private void GetKeybordAndSendF4()
        {
            try
            {
                ////OSの情報を取得する
                //System.OperatingSystem os = System.Environment.OSVersion;

                //// windows 8以前の場合
                //if (os.Version.Major < 6 || os.Version.Minor < 2)
                //{
                //    // TODO: とりあえず
                //    return;
                //}

                //System.Diagnostics.Process[] ps =
                //System.Diagnostics.Process.GetProcesses();

                //// 既に起動している場合は一度終了させる（非表示の場合が有るの為）
                //foreach (System.Diagnostics.Process p in ps)
                //{
                //    if (p.ProcessName == "TabTip")
                //    {
                //        p.Kill();
                //        break;
                //    }
                //}

                //// 起動
                //Process keybord = new Process();
                //keybord.StartInfo.FileName = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe";
                //keybord.Start();

                //this.Refresh();
            }
            finally
            {
                SendKeys.Send("{F4}");
            }
        }

        private void burowaGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
