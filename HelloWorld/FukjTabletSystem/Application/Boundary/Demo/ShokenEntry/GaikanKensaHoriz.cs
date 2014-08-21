using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.DataSet.Ce.ShokenMstDataSetTableAdapters;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiGroupMstDataSetTableAdapters;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiKensaJokyoMstDataSetTableAdapters;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiKensaJokyoTeidoMstDataSetTableAdapters;
using FukjTabletSystem.Application.DataSet.Ce.TaniSochiKensaKomokuMstDataSetTableAdapters;
using FukjTabletSystem.Properties;
using Zynas.Framework.Core.Common.Boundary;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class GaikanKensaHorizForm : TabBaseFormHoriz
    {
        #region フォームデータ定義

        public class GaikanKensaHorizFormData : FormData
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

        public GaikanKensaHorizForm()
        {
            InitializeComponent();

        }

        #endregion

        DataTable daiBunruiDataTable = null;
        DataTable chuBunruiDataTable = null;
        DataTable shouBunruiDataTable = null;
        DataTable teidoDataTable = null;
        DataTable shokenDataTable = null;

        public override FormData InitFormData()
        {
            FormData ret = new GaikanKensaHorizFormData();
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

            // 大分類
            {
                tables[0] = new TaniSochiGroupMstTableAdapter().GetData();
            }
            // 中分類
            {
                tables[1] = new TaniSochiKensaKomokuMstTableAdapter().GetData();
            }

            // 小分類
            {
                tables[2] = new TaniSochiKensaJokyoMstTableAdapter().GetData();
            }

            // 程度
            {
                tables[3] = new TaniSochiKensaJokyoTeidoMstTableAdapter().GetData();
            }

            // 所見
            {
                tables[4] = new ShokenMstTableAdapter().GetData();
            }
        }

        public override void SetTitle()
        {
            headerControl1.SetTitle("外観検査");
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
                    formData.SetValue(GaikanKensaHorizFormData.TANI_SOCHI_KENSA_KOMOKU_NM, ((Button)sender).Text);

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

        private void GaikanKensaHorizForm_Load(object sender, EventArgs e)
        {
            BoundaryUtility.StdLoadEventSequence(
                this, delegate()
                {
                    // 表示候補取得
                    FormData formData = InitFormData();

                    WindowState = FormWindowState.Maximized;

                    DataTable[] tables = new DataTable[5];
                    GetDBFormData(tables);

                    daiBunruiDataTable = tables[0];
                    chuBunruiDataTable = tables[1];
                    shouBunruiDataTable = tables[2];
                    teidoDataTable = tables[3];
                    shokenDataTable = tables[4];

                    SetTitle();

                    // 大分類一覧設定
                    daiListBox.DisplayMember = "TaniSochiGroupNm";
                    daiListBox.ValueMember = "TaniSochiGroupCd";
                    daiListBox.DataSource = daiBunruiDataTable.Select(string.Empty);
                    //daiListBox.DisplayMember = "TaniSochiGroupNm";
                });
        }

        private void soutiAddButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    // TODO 単位装置の追加を可能にする(現地で追加の構成装置が判明する場合がある)

                    // TODO 装置種別選択 -> 装置選択
                    // TODO 単位装置マスタから、一覧を取得・表示(単位装置グループとJOINしたもの)

                    // TODO 単位装置グループを選択すると、個々の単位装置が表示される
                    // TODO (カラムが2つある状態)

                    // 選択画面をダイアログ表示する
                    SoutiSentakuHorizForm dia = new SoutiSentakuHorizForm();

                    dia.ShowDialog(this);

                    // 選択された単位装置情報を追加
                    DataRow newRow = daiBunruiDataTable.NewRow();
                    newRow["TaniSochiGroupCd"] = "90";
                    //newRow["TaniSochiGroupCd"] = dia.TaniSotiGroupCd;
                    newRow["TaniSochiGroupNm"] = dia.TaniSotiNm;
                    //newRow["TaniSochiGroupNm"] = dia.TaniSotiGroupNm;
                    newRow["InsertDt"] = DateTime.Now;
                    newRow["InsertUser"] = "Dummy";
                    newRow["InsertTarm"] = "Dummy";
                    newRow["UpdateDt"] = DateTime.Now;
                    newRow["UpdateUser"] = "Dummy";
                    newRow["UpdateTarm"] = "Dummy";
                    // TODO 単位装置グループ名・単位装置名をそれぞれ保持しておく

                    daiBunruiDataTable.Rows.Add(newRow);
                    //daiBunruiDataTable.ImportRow(newRow);

                    daiListBox.DataSource = daiBunruiDataTable.Select(string.Empty);
                });
        }

        private void kakuteiButton_Click(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    // TODO 所見確定登録
                    // TODO デモ版では、メッセージボックス表示
                });
        }

        private void daiListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (daiListBox.SelectedValue == null) { return; }

                    // 以降の入力候補を絞る
                    chuListBox.DisplayMember = "TaniSochiKensaKomokuNm";
                    chuListBox.ValueMember = "TaniSochiKensaKomokuCd";
                    //string cd = (string)daiListBox.SelectedValue;
                    string cd = (string)daiListBox.SelectedValue;
                    //string cd = (string)((DataRow)daiListBox.SelectedValue)["TaniSochiGroupCd"];

                    chuListBox.BeginUpdate();
                    shouListBox.BeginUpdate();
                    teidoListBox.BeginUpdate();

                    chuListBox.DataSource = chuBunruiDataTable.Select(string.Format("KensaTaniSochiGroupCd = '{0}'", cd));

                    shouListBox.DataSource = null;
                    teidoListBox.DataSource = null;

                    // 無効な入力をクリア
                    chuListBox.SelectedIndex = -1;
                    shouListBox.SelectedIndex = -1;
                    teidoListBox.SelectedIndex = -1;

                    chuListBox.EndUpdate();
                    shouListBox.EndUpdate();
                    teidoListBox.EndUpdate();
                });
        }

        private void chuListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (chuListBox.SelectedValue == null) { return; }

                    // 以降の入力候補を絞る
                    shouListBox.DisplayMember = "TaniSochiKensaJokyoNm";
                    shouListBox.ValueMember = "TaniSochiKensaJokyoCd";
                    string cd = (string)daiListBox.SelectedValue;
                    //string cd = (string)((DataRow)daiListBox.SelectedValue)["TaniSochiGroupCd"];
                    string cd2 = (string)chuListBox.SelectedValue;
                    //string cd = (string)((DataRow)chuListBox.SelectedValue)["TaniSochiKensaKomokuCd"];

                    shouListBox.BeginUpdate();
                    teidoListBox.BeginUpdate();

                    shouListBox.DataSource = shouBunruiDataTable.Select(string.Format("KensaTaniSochiGroupCd = '{0}' AND TaniSochiKensaKomokuCd = '{1}'", cd, cd2));

                    teidoListBox.DataSource = null;

                    // 無効な入力をクリア
                    shouListBox.SelectedIndex = -1;
                    teidoListBox.SelectedIndex = -1;

                    shouListBox.EndUpdate();
                    teidoListBox.EndUpdate();
                });
        }

        private void shouListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (shouListBox.SelectedValue == null) { return; }

                    // 以降の入力候補を絞る
                    teidoListBox.DisplayMember = "TaniSochiKensaJokyoTeidoNm";
                    teidoListBox.ValueMember = "TaniSochiKensaJokyoTeidoCd";
                    string cd = (string)daiListBox.SelectedValue;
                    //string cd = (string)((DataRow)daiListBox.SelectedValue)["TaniSochiGroupCd"];
                    string cd2 = (string)chuListBox.SelectedValue;
                    string cd3 = (string)shouListBox.SelectedValue;
                    //string cd = (string)((DataRow)shouListBox.SelectedValue)["TaniSochiKensaJokyoCd"];

                    teidoListBox.BeginUpdate();

                    teidoListBox.DataSource = teidoDataTable.Select(string.Format("KensaTaniSochiGroupCd = '{0}' AND TaniSochiKensaKomokuCd = '{1}' AND TaniSochiKensaJokyoCd = '{2}'", cd, cd2, cd3));

                    // 無効な入力をクリア
                    teidoListBox.SelectedIndex = -1;

                    teidoListBox.EndUpdate();
                });
        }

        private void teidoListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            BoundaryUtility.StdEventSequence(
                delegate()
                {
                    if (teidoListBox.SelectedValue == null)
                    {
                        SetShoken(null);
                        return;
                    }

                    // 以降の入力候補を絞る

                    // TODO 所見も取得し、絞る

                    //string cd = (string)((DataRow)daiListBox.SelectedValue)["TaniSochiGroupCd"];
                    //string cd2 = (string)chuListBox.SelectedValue;
                    //string cd3 = (string)shouListBox.SelectedValue;
                    //string cd4 = (string)teidoListBox.SelectedValue;
                    //shokenDataTable.Select(string.Format("KensaTaniSochiGroupCd = '{0}' AND TaniSochiKensaKomokuCd = '{1}' AND TaniSochiKensaJokyoCd = '{2}'", cd, cd2, cd3));

                    string shokenCd = (string)((DataRow)teidoListBox.SelectedItem)["SentakuShokenCd"];

                    DataRow[] rows = shokenDataTable.Select(string.Format("ShokenCd = '{0}'", shokenCd));

                    // TODO 選択された所見1行の情報を表示する
                    if (rows != null && rows.Length > 0)
                    {
                        DataRow row = rows[0];

                        SetShoken(row);
                    }
                    else
                    {
                        SetShoken(null);
                    }

                    // 無効な入力をクリア
                }, true, false);
        }

        #endregion

        #region method

        private void SetShoken(DataRow row)
        {
            if (row != null)
            {
                string checkNo = ((string)row["ShokenGaikankensaKoumokuCd"]);
                string handan = ((string)row["ShokenGaikankensaKoumokuHandan"]);
                string level = ((string)row["ShokenGaikankensaKoumokuJuyodo"]);
                string judge = ((string)row["ShokenGaikankensaKoumokuHantei"]);
                // TODO 
                string autoCond = string.Empty;
                string desc = (string)row["ShokenWd"];

                checkNoLabel.Text = checkNo;
                handanLabel.Text = KbnUtility.GetHandanName(handan);
                levelLabel.Text = KbnUtility.GetLevelName(level);
                judgeLabel.Text = KbnUtility.GetJudgeName(judge);
                shokenDescLabel.Text = desc;
            }
            else
            {
                checkNoLabel.Text = string.Empty;
                handanLabel.Text = string.Empty;
                levelLabel.Text = string.Empty;
                judgeLabel.Text = string.Empty;
                shokenDescLabel.Text = string.Empty;
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
