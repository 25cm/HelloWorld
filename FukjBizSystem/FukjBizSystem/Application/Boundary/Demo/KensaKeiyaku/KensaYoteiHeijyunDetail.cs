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
    public partial class KensaYoteiHeijyunDetailForm : Form
    {
        DataTable table = null;

        // 画面起動引数
        public string kensainLeft = string.Empty;
        public string kensainRight = string.Empty;

        public KensaYoteiHeijyunDetailForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 閉じるボタン
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
        private void KensaYoteiHeijyunDetailForm_Load(object sender, EventArgs e)
        {
            table = KensaYoteiData.GetKensaYoteiData();

            // 検査員表示
            leftKensainTextBox.Text = kensainLeft;
            rightKensainTextBox.Text = kensainRight;

            // TODO 検査予定月も絞込み対象とする
            // TODO 検査予定日を変更可能にする

            // 検査員ごとに絞り込むこと(左と右、2通り)
            // 7条は対象外とする
            SetDataLeft(table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条'", kensainLeft)));
            SetDataRight(table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条'", kensainRight)));

            // 11条件数（50人槽以下、51人槽以上）をそれぞれ設定する
            leftMimanTextBox.Text = table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条' AND NINSOU <= '50'", kensainLeft)).Length.ToString();
            leftIzyouTextBox.Text = table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条' AND NINSOU >= '51'", kensainLeft)).Length.ToString();

            rightMimanTextBox.Text = table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条' AND NINSOU <= '50'", kensainRight)).Length.ToString();
            rightIzyouTextBox.Text = table.Select(string.Format("KENSAIN = '{0}' AND KENSA_SHUBETSU <> '7条' AND NINSOU >= '51'", kensainRight)).Length.ToString();
        }

        /// <summary>
        /// 左側ペインにデータを設定
        /// </summary>
        /// <param name="rows"></param>
        private void SetDataLeft(IEnumerable<DataRow> rows)
        {
            leftDataGridView.Rows.Clear();

            int i = 0;
            foreach (DataRow row in rows)
            {
                leftDataGridView.Rows.Add(
                     (string)row["KENSA_YOTEI_NEN"] + "/" + (string)row["KENSA_YOTEI_TSUKI"] + "/" + (string)row["KENSA_YOTEI_NITI"]
                    , (int)row["NINSOU"]
                    , (string)row["SETTI_BASHO"]
                    );
                i++;
            }
        }

        /// <summary>
        /// 右側ペインにデータを設定
        /// </summary>
        /// <param name="rows"></param>
        private void SetDataRight(IEnumerable<DataRow> rows)
        {
            rightDataGridView.Rows.Clear();

            int i = 0;
            foreach (DataRow row in rows)
            {
                rightDataGridView.Rows.Add(
                     (string)row["KENSA_YOTEI_NEN"] + "/" + (string)row["KENSA_YOTEI_TSUKI"] + "/" + (string)row["KENSA_YOTEI_NITI"]
                    , (int)row["NINSOU"]
                    , (string)row["SETTI_BASHO"]
                    );
                i++;
            }
        }

        /// <summary>
        /// 右移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightButton_Click(object sender, EventArgs e)
        {
            DataGridView fromGrid = leftDataGridView;
            TextBox fromMimanTextBox = leftMimanTextBox;
            TextBox fromIzyouTextBox = leftIzyouTextBox;
            DataGridView toGrid = rightDataGridView;
            TextBox toMimanTextBox = rightMimanTextBox;
            TextBox toIzyouTextBox = rightIzyouTextBox;

            // 選択行がない場合はキャンセル
            if (fromGrid.SelectedRows.Count == 0)
            {
                return;
            }

            // 検査予定振替
            // 画面表示振替
            toGrid.Rows.Add(
                fromGrid.SelectedRows[0].Cells[ColKensaYoteiDate.Index].Value
                , fromGrid.SelectedRows[0].Cells[ColNinsou.Index].Value
                , fromGrid.SelectedRows[0].Cells[ColSettiBasho.Index].Value
                );

            // 件数表示更新
            if (((int)fromGrid.SelectedRows[0].Cells[ColNinsou.Index].Value) <= 50)
            {
                fromMimanTextBox.Text = (int.Parse(fromMimanTextBox.Text) - 1).ToString();
                toMimanTextBox.Text = (int.Parse(toMimanTextBox.Text) + 1).ToString();
            }
            else
            {
                fromIzyouTextBox.Text = (int.Parse(fromIzyouTextBox.Text) - 1).ToString();
                toIzyouTextBox.Text = (int.Parse(toIzyouTextBox.Text) + 1).ToString();
            }

            fromGrid.Rows.Remove(fromGrid.SelectedRows[0]);
        }

        /// <summary>
        /// 左移動ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void leftButton_Click(object sender, EventArgs e)
        {
            DataGridView fromGrid = rightDataGridView;
            TextBox fromMimanTextBox = rightMimanTextBox;
            TextBox fromIzyouTextBox = rightIzyouTextBox;
            DataGridView toGrid = leftDataGridView;
            TextBox toMimanTextBox = leftMimanTextBox;
            TextBox toIzyouTextBox = leftIzyouTextBox;

            // 選択行がない場合はキャンセル
            if (fromGrid.SelectedRows.Count == 0)
            {
                return;
            }

            // 検査予定振替
            // 画面表示振替
            toGrid.Rows.Add(
                fromGrid.SelectedRows[0].Cells[ColKensaYoteiDate.Index].Value
                , fromGrid.SelectedRows[0].Cells[ColNinsou.Index].Value
                , fromGrid.SelectedRows[0].Cells[ColSettiBasho.Index].Value
                );


            // 件数表示更新
            if (((int)fromGrid.SelectedRows[0].Cells[ColNinsou.Index].Value) <= 50)
            {
                fromMimanTextBox.Text = (int.Parse(fromMimanTextBox.Text) - 1).ToString();
                toMimanTextBox.Text = (int.Parse(toMimanTextBox.Text) + 1).ToString();
            }
            else
            {
                fromIzyouTextBox.Text = (int.Parse(fromIzyouTextBox.Text) - 1).ToString();
                toIzyouTextBox.Text = (int.Parse(toIzyouTextBox.Text) + 1).ToString();
            }

            fromGrid.Rows.Remove(fromGrid.SelectedRows[0]);
        }

        /// <summary>
        /// 確定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kakuteiButton_Click(object sender, EventArgs e)
        {
            // データ更新
            // TODO データ更新(検査員の振替を行う)

            Close();
        }
    }
}
