using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;
using System.Threading;

namespace FukjTabletSystem.Application.Boundary.Demo
{
    public partial class KensaKekkaNumEntryForm : TabBaseFormHoriz
    {
        #region フォームデータ定義

        public class KensaKekkaNumEntryFormData : FormData
        {
            public override void SetValue(string dataKey, string value)
            {
                base.SetValue(dataKey, value);
            }
        }

        #endregion

        public KensaKekkaNumEntryForm()
        {
            InitializeComponent();
        }

        public override FormData InitFormData()
        {
            FormData ret = new KensaKekkaNumEntryFormData();
            ret.TransitionDispName = "";

            return ret;
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("検査結果入力（数値入力）");
        }

        private void KensaKekkaNumEntryForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
                {
                    // 表示候補取得
                    FormData formData = InitFormData();

                    WindowState = FormWindowState.Maximized;
                    
                    SetTitle();
                });

            burowaGridView.Rows.Add("ブロワ１", 100, "Ｌ/分", 100, "Ｌ/分");
            burowaGridView.Rows.Add("ブロワ２", 200, "Ｌ/分", 200, "Ｌ/分");
            burowaGridView.Rows.Add("ブロワ３", 300, "Ｌ/分", 300, "Ｌ/分");
            burowaGridView.Rows.Add("ブロワ４", 400, "Ｌ/分", 400, "Ｌ/分");
            burowaGridView.Rows.Add("ブロワ５", 500, "Ｌ/分", 500, "Ｌ/分");

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
                if (e.ColumnIndex == burowaGridView.Columns["KITEI"].Index ||
                    e.ColumnIndex == burowaGridView.Columns["SECCHI"].Index)
                {
                    GetKeybordAndSendF2(true);
                }
            }
            catch
            {
            }
        }

        private void burowaGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (burowaGridView.CurrentCell.ColumnIndex == burowaGridView.Columns["KITEI"].Index ||
                    burowaGridView.CurrentCell.ColumnIndex == burowaGridView.Columns["SECCHI"].Index)
                {
                    GetKeybordAndSendF2(true);
                }
            }
            catch
            {
            }
        }

        private void GetKeybordAndSendF2(bool f2)
        {
            try
            {
                //OSの情報を取得する
                System.OperatingSystem os = System.Environment.OSVersion;

                // windows 8以前の場合
                if (os.Version.Major < 6 || os.Version.Minor < 2)
                {
                    // TODO: とりあえず
                    return;
                }

                System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcesses();

                // 既に起動している場合は一度終了させる（非表示の場合が有るの為）
                foreach (System.Diagnostics.Process p in ps)
                {
                    if (p.ProcessName == "TabTip")
                    {
                        p.Kill();
                                                
                        break;
                    }
                }


                // 起動
                Process keybord = new Process();
                keybord.StartInfo.FileName = @"C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe";
                keybord.Start();
            }
            finally
            {
                if (f2)
                {
                    SendKeys.Send("{F2}");
                }
            }
        }

        private void HideKeybord()
        {
            try
            {
                System.Diagnostics.Process[] ps =
                System.Diagnostics.Process.GetProcesses();

                // 既に起動している場合は終了させる
                foreach (System.Diagnostics.Process p in ps)
                {
                    if (p.ProcessName == "TabTip")
                    {
                        p.Kill();

                        System.Diagnostics.Process[] ps2 =
                        System.Diagnostics.Process.GetProcesses();

                        foreach (System.Diagnostics.Process p2 in ps2)
                        {
                            if (p2.ProcessName == "TabTip")
                            {
                                Thread.Sleep(500);

                                HideKeybord();
                            }
                        }
                    }
                }

            }
            finally
            {
            }
        }

        private void burowaGridView_Leave(object sender, EventArgs e)
        {
            try
            {
                HideKeybord();
            }
            catch
            {
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            try
            {
                GetKeybordAndSendF2(false);
            }
            catch
            {
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                HideKeybord();
            }
            catch
            {
            }
        }

    }
}
