using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Boundary.Demo.Common;
using FukjTabletSystem.Application.DataSet.Ce;
using FukjTabletSystem.Application.DataSet.Ce.ShokenMstDataSetTableAdapters;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Properties;

namespace FukjTabletSystem.Application.Boundary.Demo.ShokenEntry
{
    public partial class ShokenKakuteiForm : TabBaseForm
    {
        public ShokenKakuteiForm()
        {
            InitializeComponent();

            // TODO 
            // VSデザイナ表示時はサンプルを表示
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                Panel newPanel = CreateElement(
                    24
                    , "1"
                    , "1"
                    , "1"
                    , ""
                    , "サンプル"
                    );
                elementLayoutPanel.Controls.Add(newPanel);
            }
        }

        private void ShokenKakuteiForm_Load(object sender, EventArgs e)
        {
            // 画面遷移時の登録処理も自動生成する
            // TODO 確定ボタン押下時に、今までの画面遷移の入力結果を
            // TODO 登録する

            // TODO 既に登録済みの場合はUPDATEにすること

            // TODO 一旦所見入力したものを、○に訂正したい場合があるかもしれないので、中分類から、○も選択できるようにする

            SetTitle();

            // 最下段に表示するので、一旦削除
            elementLayoutPanel.Controls.Remove(kakuteiButton);

            // デザイナのサンプル表示を削除
            elementLayoutPanel.Controls.Remove(elementPanel1);

            // 表示候補取得
            DataTable table = GetDBFormData();

            string soutiCd = FormManager.GetInstance().GetFormData(typeof(DaiBunruiSentakuForm)).GetValue(DaiBunruiSentakuForm.DaiBunruiSentakuFormData.TANI_SOCHI_GRP_CD);
            string koumokuCd = FormManager.GetInstance().GetFormData(typeof(ChuBunruiSentakuForm)).GetValue(ChuBunruiSentakuForm.ChuBunruiSentakuFormData.TANI_SOCHI_KENSA_KOMOKU_CD);
            string jyokyoCd = FormManager.GetInstance().GetFormData(typeof(ShouBunruiSentakuForm)).GetValue(ShouBunruiSentakuForm.ShouBunruiSentakuFormData.TANI_SOCHI_KENSA_JOKYO_CD);

            string shokenCd = FormManager.GetInstance().GetFormData(typeof(TeidoSentakuForm)).GetValue(TeidoSentakuForm.TeidoSentakuFormData.SHOKEN_CD);

            // TODO （未確定だが、）所見区分も考慮
            // 前画面までの入力で、表示候補を絞る
            //DataRow[] rows = table.Select(string.Format(""));
            DataRow[] rows = table.Select(string.Format("ShokenCd = '{0}'", shokenCd));
            //DataRow[] rows = table.Select(string.Format("ShokenHyoujiIchiDaiCd = '{0}' AND ShokenHyoujiIchiChuCd = '{1}'AND ShokenHyoujiIchiShoCd = '{2}'", soutiCd, koumokuCd, jyokyoCd));
            //DataRow[] rows = table.Select(string.Format("ShokenTanisouchiCd = '{0}' AND ShokenHyoujiIchiChuCd = '{1}'AND ShokenHyoujiIchiShoCd = '{2}'", soutiCd, koumokuCd, jyokyoCd));

            for (int i = 0; i < rows.Length; i++)
            {
                Panel newPanel = CreateElement(rows[i]);
                // TODO 自動で適切に動くなら良い
                //newPanel.TabIndex = i + 3;
                elementLayoutPanel.Controls.Add(newPanel);
            }

            // 最下段に追加
            elementLayoutPanel.Controls.Add(kakuteiButton);

       }

        private void kakuteiButton_Click(object sender, EventArgs e)
        {
            TabMessageBox.Show2("機能説明：\n端末内に所見自動判定結果を登録します。");
           
            // TODO DB LocalDB登録
            
            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(typeof(DaiBunruiSentakuForm));
            objNextForm.Show();

            // 次画面を閉じる
            Close();
        }

        public override FormData InitFormData()
        {
            return null;
            // TODO 
        }

        private void SetFormData()
        {
            // TODO フォームの作業データを設定する
        }

        public override DataTable GetDBFormData()
        {
            // TODO DAを作成する
            ShokenMstDataSet.ShokenMstDataTable table;
            table = new ShokenMstTableAdapter().GetData();

            //DataTable table = new DataTable();
            //table.Columns.Add("ShokenKbn", typeof(string));
            //table.Columns.Add("ShokenCd", typeof(string));
            //table.Columns.Add("ShokenWd", typeof(string));
            //table.Columns.Add("ShokenGaikankensaKoumokuCd", typeof(string));
            //table.Columns.Add("ShokenGaikankensaKoumokuHandan", typeof(string));
            //table.Columns.Add("ShokenGaikankensaKoumokuJuyodo", typeof(string));
            //table.Columns.Add("ShokenGaikankensaKoumokuHantei", typeof(string));
            //table.Columns.Add("ShokenGaikankensaCd", typeof(string));
            //table.Columns.Add("ShokenTanisouchiCd", typeof(string));
            //table.Columns.Add("ShokenHyoujiIchiDaiCd", typeof(string));
            //table.Columns.Add("ShokenHyoujiIchiChuCd", typeof(string));
            //table.Columns.Add("ShokenHyoujiIchiShoCd", typeof(string));

            //// TODO DBからデータを取得する様にする
            //{
            //    DataRow row = table.NewRow();
            //    row["ShokenKbn"] = "01";
            //    row["ShokenCd"] = "01";
            //    row["ShokenWd"] = "ばっ気槽において、槽内の隔壁が破損又は変形しています。処理機能に影響を与えるので改善が望まれます。";
            //    row["ShokenGaikankensaKoumokuCd"] = "01";
            //    row["ShokenGaikankensaKoumokuHandan"] = "01";
            //    row["ShokenGaikankensaKoumokuJuyodo"] = "01";
            //    row["ShokenGaikankensaKoumokuHantei"] = "01";
            //    row["ShokenGaikankensaCd"] = "01";
            //    row["ShokenTanisouchiCd"] = "01";
            //    row["ShokenHyoujiIchiDaiCd"] = "01";
            //    row["ShokenHyoujiIchiChuCd"] = "01";
            //    row["ShokenHyoujiIchiShoCd"] = "01";

            //    table.Rows.Add(row);
            //}
            //{
            //    DataRow row = table.NewRow();
            //    row["ShokenKbn"] = "01";
            //    row["ShokenCd"] = "02";
            //    row["ShokenWd"] = "ばっ気槽において、槽内の隔壁が破損又は変形しています。処理機能に影響を与えるので改善が望まれます。";
            //    row["ShokenGaikankensaKoumokuCd"] = "02";
            //    row["ShokenGaikankensaKoumokuHandan"] = "02";
            //    row["ShokenGaikankensaKoumokuJuyodo"] = "02";
            //    row["ShokenGaikankensaKoumokuHantei"] = "02";
            //    row["ShokenGaikankensaCd"] = "02";
            //    row["ShokenTanisouchiCd"] = "01";
            //    row["ShokenHyoujiIchiDaiCd"] = "01";
            //    row["ShokenHyoujiIchiChuCd"] = "01";
            //    row["ShokenHyoujiIchiShoCd"] = "01";

            //    table.Rows.Add(row);
            //}

            return table;
        }

        public override void SetTitle()
        {
            // TODO タイトル設定
            headerControl1.SetTitle("所見表記");
        }

        private void SetSubTitle()
        {
            // TODO サブタイトル(パンくず)設定

            // TODO GetFormTransitionData
        }

        private Panel CreateElement(int checkNo, string handan, string level, string judge, string autoCond, string desc)
        {
            #region デザインパラメータ設定

            FlowLayoutPanel elementLayoutPanel = new FlowLayoutPanel();
            TableLayoutPanel shokenItemLayoutPanel = new TableLayoutPanel();
            Label shokenCheckNoLabel = new Label();
            Label shokenHandanLabel = new Label();
            Label shokenLevelLabel = new Label();
            Label shokenJudgeLabel = new Label();
            Label shokenAutoCondLabel = new Label();
            Label checkNoLabel = new Label();
            Label handanLabel = new Label();
            Label levelLabel = new Label();
            Label judgeLabel = new Label();
            Label autoCondLabel = new Label();
            Label shokenDescLabel = new Label();

            // 
            // elementLayoutPanel
            // 
            elementLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            elementLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            elementLayoutPanel.Controls.Add(shokenItemLayoutPanel);
            elementLayoutPanel.Controls.Add(shokenDescLabel);
            elementLayoutPanel.Font = new System.Drawing.Font("メイリオ", 12F);
            elementLayoutPanel.Location = new System.Drawing.Point(13, 80);
            elementLayoutPanel.Name = "shokenLayoutPanel";
            elementLayoutPanel.Size = new System.Drawing.Size(713, 297);
            elementLayoutPanel.TabIndex = 1;
            // 
            // shokenItemLayoutPanel
            // 
            shokenItemLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenItemLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            shokenItemLayoutPanel.ColumnCount = 5;
            shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            shokenItemLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            shokenItemLayoutPanel.Controls.Add(shokenCheckNoLabel, 0, 0);
            shokenItemLayoutPanel.Controls.Add(shokenHandanLabel, 1, 0);
            shokenItemLayoutPanel.Controls.Add(shokenLevelLabel, 2, 0);
            shokenItemLayoutPanel.Controls.Add(shokenJudgeLabel, 3, 0);
            shokenItemLayoutPanel.Controls.Add(shokenAutoCondLabel, 4, 0);
            shokenItemLayoutPanel.Controls.Add(checkNoLabel, 0, 1);
            shokenItemLayoutPanel.Controls.Add(handanLabel, 1, 1);
            shokenItemLayoutPanel.Controls.Add(levelLabel, 2, 1);
            shokenItemLayoutPanel.Controls.Add(judgeLabel, 3, 1);
            shokenItemLayoutPanel.Controls.Add(autoCondLabel, 4, 1);
            shokenItemLayoutPanel.Font = new System.Drawing.Font("メイリオ", 16F);
            shokenItemLayoutPanel.Location = new System.Drawing.Point(3, 3);
            shokenItemLayoutPanel.MinimumSize = new System.Drawing.Size(550, 100);
            shokenItemLayoutPanel.Name = "shokenItemLayoutPanel";
            shokenItemLayoutPanel.RowCount = 2;
            shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            shokenItemLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            shokenItemLayoutPanel.Size = new System.Drawing.Size(700, 185);
            shokenItemLayoutPanel.TabIndex = 0;
            // 
            // shokenCheckNoLabel
            // 
            shokenCheckNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenCheckNoLabel.AutoSize = true;
            shokenCheckNoLabel.Location = new System.Drawing.Point(12, 21);
            shokenCheckNoLabel.Name = "shokenCheckNoLabel";
            shokenCheckNoLabel.Size = new System.Drawing.Size(147, 33);
            shokenCheckNoLabel.TabIndex = 0;
            shokenCheckNoLabel.Text = "チェック番号";
            // 
            // shokenHandanLabel
            // 
            shokenHandanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenHandanLabel.AutoSize = true;
            shokenHandanLabel.Location = new System.Drawing.Point(227, 21);
            shokenHandanLabel.Name = "shokenHandanLabel";
            shokenHandanLabel.Size = new System.Drawing.Size(59, 33);
            shokenHandanLabel.TabIndex = 1;
            shokenHandanLabel.Text = "判断";
            // 
            // shokenLevelLabel
            // 
            shokenLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenLevelLabel.AutoSize = true;
            shokenLevelLabel.Location = new System.Drawing.Point(374, 21);
            shokenLevelLabel.Name = "shokenLevelLabel";
            shokenLevelLabel.Size = new System.Drawing.Size(81, 33);
            shokenLevelLabel.TabIndex = 2;
            shokenLevelLabel.Text = "重要度";
            // 
            // shokenJudgeLabel
            // 
            shokenJudgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenJudgeLabel.AutoSize = true;
            shokenJudgeLabel.Location = new System.Drawing.Point(503, 21);
            shokenJudgeLabel.Name = "shokenJudgeLabel";
            shokenJudgeLabel.Size = new System.Drawing.Size(59, 33);
            shokenJudgeLabel.TabIndex = 3;
            shokenJudgeLabel.Text = "判定";
            // 
            // shokenAutoCondLabel
            // 
            shokenAutoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            shokenAutoCondLabel.AutoSize = true;
            shokenAutoCondLabel.Location = new System.Drawing.Point(592, 5);
            shokenAutoCondLabel.Name = "shokenAutoCondLabel";
            shokenAutoCondLabel.Size = new System.Drawing.Size(103, 66);
            shokenAutoCondLabel.TabIndex = 4;
            shokenAutoCondLabel.Text = "自動判定基準";
            // 
            // checkNoLabel
            // 
            checkNoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            checkNoLabel.AutoSize = true;
            checkNoLabel.Location = new System.Drawing.Point(64, 112);
            checkNoLabel.Name = "checkNoLabel";
            checkNoLabel.Size = new System.Drawing.Size(43, 33);
            checkNoLabel.TabIndex = 5;
            // 
            // handanLabel
            // 
            handanLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            handanLabel.AutoSize = true;
            handanLabel.Location = new System.Drawing.Point(196, 104);
            handanLabel.Name = "handanLabel";
            handanLabel.Size = new System.Drawing.Size(121, 49);
            handanLabel.TabIndex = 6;
            // 
            // levelLabel
            // 
            levelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            levelLabel.AutoSize = true;
            levelLabel.Location = new System.Drawing.Point(354, 104);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(121, 49);
            levelLabel.TabIndex = 7;
            // 
            // judgeLabel
            // 
            judgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            judgeLabel.AutoSize = true;
            judgeLabel.Location = new System.Drawing.Point(492, 112);
            judgeLabel.Name = "judgeLabel";
            judgeLabel.Size = new System.Drawing.Size(81, 33);
            judgeLabel.TabIndex = 8;
            // 
            // autoCondLabel
            // 
            autoCondLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            autoCondLabel.AutoSize = true;
            autoCondLabel.Location = new System.Drawing.Point(632, 112);
            autoCondLabel.Name = "autoCondLabel";
            autoCondLabel.Size = new System.Drawing.Size(22, 33);
            autoCondLabel.TabIndex = 9;
            // 
            // shokenDescLabel
            // 
            shokenDescLabel.AutoSize = true;
            shokenDescLabel.Font = new System.Drawing.Font("メイリオ", 16F);
            shokenDescLabel.Location = new System.Drawing.Point(3, 191);
            shokenDescLabel.Name = "shokenDescLabel";
            shokenDescLabel.Size = new System.Drawing.Size(697, 66);
            shokenDescLabel.TabIndex = 1;

            #endregion

            // 個別パラメータ設定
            checkNoLabel.Text = checkNo.ToString();
            handanLabel.Text = KbnUtility.GetHandanName(handan);
            levelLabel.Text = KbnUtility.GetLevelName(level);
            judgeLabel.Text = KbnUtility.GetJudgeName(judge);
            autoCondLabel.Text = autoCond;

            // 文章内の(大分類)などを置き換える
            // TODO 

            shokenDescLabel.Text = desc;

            return elementLayoutPanel;
        }

        private Panel CreateElement(DataRow row)
        {
            int checkNo = int.Parse(((string)row["ShokenGaikankensaKoumokuCd"]));
            string handan = ((string)row["ShokenGaikankensaKoumokuHandan"]);
            string level = ((string)row["ShokenGaikankensaKoumokuJuyodo"]);
            string judge = ((string)row["ShokenGaikankensaKoumokuHantei"]);
            // TODO 
            string autoCond = string.Empty;
            string desc = (string)row["ShokenWd"];

            return CreateElement(checkNo, handan, level, judge, autoCond, desc);
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
