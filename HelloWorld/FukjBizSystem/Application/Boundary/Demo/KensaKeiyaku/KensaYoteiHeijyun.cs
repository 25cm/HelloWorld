using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KensaYoteiMapDemo
{
    /// <summary>
    /// 
    /// </summary>
    public partial class KensaYoteiHeijyunForm : Form
    {
        DataTable table = null;

        public KensaYoteiHeijyunForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 初期ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KensaYoteiHeijyunForm_Load(object sender, EventArgs e)
        {
            table = KensaYoteiData.GetKensaYoteiData();

            // TODO 一旦、作業用のDataRowに格納する形とする（暫定）
            DataTable aggrTable = new DataTable();
            aggrTable.Columns.Add("KENSAIN", typeof(string));
            aggrTable.Columns.Add("KADOU_YOTEI", typeof(double));
            aggrTable.Columns.Add("7JouCount", typeof(int));
            aggrTable.Columns.Add("11Jou50MimanCount", typeof(int));
            aggrTable.Columns.Add("11JouIkaDiff", typeof(int));
            aggrTable.Columns.Add("11Jou50IzyouCount", typeof(int));
            aggrTable.Columns.Add("11JouIzyouDiff", typeof(int));

            // 予定件数合計値
            int ikaSum = 0;
            int izyouSum = 0;
            double kensainCnt = 0;

            // TODO 集計を行う事（デモなので、ためらわずにLINQを使用して集計する）
            // 検査員ごとに予定件数を集計
            var yoteiRowsGroup7 = from yoteiRows in table.AsEnumerable()
                                  group yoteiRows by yoteiRows["KENSAIN"];

            foreach (var yoteiGroup in yoteiRowsGroup7)
            {
                {
                    DataRow newRow = aggrTable.NewRow();

                    // 稼働率初期値は0
                    newRow["KADOU_YOTEI"] = 1.0f;

                    newRow["11JouIkaDiff"] = 0;
                    newRow["11JouIzyouDiff"] = 0;

                    newRow["KENSAIN"] = yoteiGroup.Key;
                    // 検査種別ごとの集計数を設定する
                    newRow["7JouCount"] = yoteiGroup.Count<DataRow>((x) => { return (string)x["KENSA_SHUBETSU"] == "7条"; });
                    newRow["11Jou50MimanCount"] = yoteiGroup.Count<DataRow>((x) => { return (string)x["KENSA_SHUBETSU"] == "11条" && (int)x["NINSOU"] <= 50; });
                    newRow["11Jou50IzyouCount"] = yoteiGroup.Count<DataRow>((x) => { return (string)x["KENSA_SHUBETSU"] == "11条" && (int)x["NINSOU"] >= 51; });

                    // 合計値に加算
                    ikaSum += (int)newRow["11Jou50MimanCount"];
                    izyouSum += (int)newRow["11Jou50IzyouCount"];

                    kensainCnt += (double)newRow["KADOU_YOTEI"];

                    aggrTable.Rows.Add(newRow);
                }
            }

            //// TODO 以下は編集後に再実行する（稼働予定率変更後、振替画面終了後）
            //// 平均値算出(50人以下、51人以上)
            //int ikaAvg = (int)(ikaSum / kensainCnt);
            //int izyouAvg = (int)(izyouSum / kensainCnt);

            //avg11JouIkaTextBox.Text = ikaAvg.ToString();
            //avg11JouIzyouTextBox.Text = izyouAvg.ToString();

            //// 各検査員ごとの平均値との差の算出
            //foreach (DataRow row in aggrTable.Rows)
            //{
            //    row["11JouIkaDiff"] = (int)row["11Jou50MimanCount"] - ikaAvg;
            //    row["11JouIzyouDiff"] = (int)row["11Jou50IzyouCount"] - izyouAvg;
            //}

            // 集計結果を表示
            SetData(aggrTable.Select(""));

            // 平均値を算出・表示
            SetAvg();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void furikaeButton_Click(object sender, EventArgs e)
        {
            // 2行選択されていない場合は、処理できない
            if (dataGridView1.SelectedRows.Count < 2)
            {
                return;
            }

            // 選択中の検査員2名を取得
            string kensainLeft = (string)dataGridView1.SelectedRows[0].Cells[ColKensaIn.Index].Value;
            string kensainRight = (string)dataGridView1.SelectedRows[1].Cells[ColKensaIn.Index].Value;

            // 明細画面に遷移し、2検査員間の予定を振替える
            KensaYoteiHeijyunDetailForm form = new KensaYoteiHeijyunDetailForm();

            form.kensainLeft = kensainLeft;
            form.kensainRight = kensainRight;

            form.ShowDialog(this);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows"></param>
        private void SetData(IEnumerable<DataRow> rows)
        {
            // 集計結果を設定する
            dataGridView1.Rows.Clear();

            int i = 0;
            foreach (DataRow row in rows)
            {
                dataGridView1.Rows.Add(
                    (string)row["KENSAIN"]
                    , (double)row["KADOU_YOTEI"]
                    , (int)row["11Jou50MimanCount"]
                    , (int)row["11JouIkaDiff"]
                    , (int)row["11Jou50IzyouCount"]
                    , (int)row["11JouIzyouDiff"]
                    , (int)row["7JouCount"]
                    );
                i++;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetAvg()
        {
            // 予定件数合計値
            int ikaSum = 0;
            int izyouSum = 0;
            double kensainCnt = 0;
            
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                // 合計値に加算
                ikaSum += (int)gridRow.Cells[Col11JouIka.Index].Value;
                izyouSum += (int)gridRow.Cells[Col11JouIzyou.Index].Value;

                kensainCnt += (double)gridRow.Cells[ColKadouRitsu.Index].Value;
            }

            // 平均値算出(50人以下、51人以上)
            int ikaAvg = (int)(ikaSum / kensainCnt);
            int izyouAvg = (int)(izyouSum / kensainCnt);

            avg11JouIkaTextBox.Text = ikaAvg.ToString();
            avg11JouIzyouTextBox.Text = izyouAvg.ToString();
            
            // 各検査員ごとの平均値との差の算出
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                gridRow.Cells[Col11JouIkaDiff.Index].Value = (int)gridRow.Cells[Col11JouIka.Index].Value - ikaAvg;
                gridRow.Cells[Col11JouIzyouDiff.Index].Value = (int)gridRow.Cells[Col11JouIzyou.Index].Value - izyouAvg;
            }
        }
    }
}
