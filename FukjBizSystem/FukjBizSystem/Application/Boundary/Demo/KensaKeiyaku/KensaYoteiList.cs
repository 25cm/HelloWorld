using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWorksViewer.MapWorks;

namespace KensaYoteiMapDemo
{
    public partial class KensaYoteiList : Form
    {
        #region 連携対象画面保持

        KensaYoteiMap mapForm;
        private static KensaMemoList memoForm;

        #endregion

        #region コンストラクタ

        public KensaYoteiList(KensaYoteiMap frm)
        {
            mapForm = frm;

            InitializeComponent();
        }

        #endregion

        DataTable table = null;

        private void KensaYoteiList_Load(object sender, EventArgs e)
        {
            table = KensaYoteiData.GetKensaYoteiData();

            kensaKbnComboBox.Items.Add("");
            kensaKbnComboBox.Items.Add("7条");
            kensaKbnComboBox.Items.Add("11条");

            SetData(table.Select(""));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //CellContentClickイベントハンドラ
        private void dataGridView1_CellContentClick_1(object sender,
            DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            //"Link"列ならば、ボタンがクリックされた
            if (e.ColumnIndex == ColMemo.Index)
            {

                if (memoForm == null || memoForm.IsDisposed)
                {
                    memoForm = new KensaMemoList(mapForm);
                }

                memoForm.Show();
            }
        }

        private void dataGridView1_CellFormatting(object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == this.dataGridView1.Columns["Rating"].Index)
                && e.Value != null)
            {
                DataGridViewCell cell =
                    this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow gridRow = dataGridView1.CurrentRow;

            if (string.IsNullOrEmpty((string)gridRow.Cells[ColKyokaiNo.Index].Value))
            {
                return;
            }

            SelectKensaYotei((string)gridRow.Cells[ColKyokaiNo.Index].Value);

            if (mapForm != null)
            {
                // 地図側の検査予定アイコンを選択
                mapForm.SelectKensaYotei((string)gridRow.Cells[ColKyokaiNo.Index].Value);
            }

            if (mapForm != null && mapForm.memoForm != null)
            {
                mapForm.memoForm.SelectKensaYotei((string)gridRow.Cells[ColKyokaiNo.Index].Value);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColKensaYoteiDate.Index)
            {
                string newDate = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string key = (string)dataGridView1.Rows[e.RowIndex].Cells[ColKyokaiNo.Index].Value;

                if (mapForm != null)
                {
                    mapForm.SetKensaYoteiDate(key, newDate);
                }

                if (mapForm != null && mapForm.memoForm != null)
                {
                    mapForm.memoForm.SetKensaYoteiDate(key, newDate);
                }
            }
        }

        private void SetData(DataRow[] rows)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < rows.Length; i++)
            {
                DataRow row = rows[i];
                dataGridView1.Rows.Add(
                    (i + 1).ToString()
                    , (string)row["KENSA_SHUBETSU"]
                    , (string)row["KYOKAI_NO"]
                    , (string)row["SETTISHA"]
                    , (string)row["SETTI_BASHO"]
                    , (string)row["MAP_NO"]
                    , (string)row["UNI_COMPOSIT"]
                    , (int)row["NINSOU"]
                    , (string)row["KENSAIN"]
                    , (string)row["KANRI_GYOSHA"]
                    , "○"
                    , "入力"
                    , "履歴"
                    , (string)row["KENSA_YOTEI_NEN"] + "/" + (string)row["KENSA_YOTEI_TSUKI"] + "/" + (string)row["KENSA_YOTEI_NITI"]
                    , "住宅・共同"
                    , "済"
                    , "済"
                    , "false"
                    );

                // メモ欄のツールチップ表示を設定
                dataGridView1[ColMemo.Index, i].ToolTipText = ((string)row["MEMO1"]) + "\r\n" + ((string)row["MEMO2"]) + "\r\n" + ((string)row["MEMO3"]);
            }
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
            StringBuilder buf = new StringBuilder();

            if (!string.IsNullOrEmpty(ninsouTextBox.Text))
            {
                if (buf.Length > 0) { buf.Append(" AND "); }
                buf.AppendFormat("NINSOU = '{0}'", ninsouTextBox.Text);
            }
            if (!string.IsNullOrEmpty(kensainTextBox.Text))
            {
                if (buf.Length > 0) { buf.Append(" AND "); }
                buf.AppendFormat("KENSAIN LIKE '%{0}%'", kensainTextBox.Text);
            }
            if (!string.IsNullOrEmpty(kensaKbnComboBox.Text))
            {
                if (buf.Length > 0) { buf.Append(" AND "); }
                buf.AppendFormat("KENSA_SHUBETSU = '{0}'", kensaKbnComboBox.Text);
            }
            if (kensaYoteiDateRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(kensaYoteiFromDateTextBox.Text))
                {
                    if (buf.Length > 0) { buf.Append(" AND "); }
                    buf.AppendFormat("KENSA_YOTEI_NEN + KENSA_YOTEI_TSUKI + KENSA_YOTEI_NITI >= '{0}'", kensaYoteiFromDateTextBox.Text);
                }
                if (!string.IsNullOrEmpty(kensaYoteiToDateTextBox.Text))
                {
                    if (buf.Length > 0) { buf.Append(" AND "); }
                    buf.AppendFormat("KENSA_YOTEI_NEN + KENSA_YOTEI_TSUKI + KENSA_YOTEI_NITI <= '{0}'", kensaYoteiToDateTextBox.Text);
                }
            }
            if (kensaYoteiMonthRadioButton.Checked)
            {
                if (!string.IsNullOrEmpty(kensaYoteiFromMonthTextBox.Text))
                {
                    if (buf.Length > 0) { buf.Append(" AND "); }
                    buf.AppendFormat("KENSA_YOTEI_NEN + KENSA_YOTEI_TSUKI + KENSA_YOTEI_NITI >= '{0}'", kensaYoteiFromMonthTextBox.Text + "01");
                }
                if (!string.IsNullOrEmpty(kensaYoteiToMonthTextBox.Text))
                {
                    if (buf.Length > 0) { buf.Append(" AND "); }
                    buf.AppendFormat("KENSA_YOTEI_NEN + KENSA_YOTEI_TSUKI + KENSA_YOTEI_NITI <= '{0}'", kensaYoteiToMonthTextBox.Text + "01");
                }
            }

            SetData(table.Select(buf.ToString()));
            
        }

        private void kensaYoteiDateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            kensaYoteiFromDateTextBox.Enabled = kensaYoteiDateRadioButton.Checked;
            kensaYoteiToDateTextBox.Enabled = kensaYoteiDateRadioButton.Checked;

            kensaYoteiFromMonthTextBox.Enabled = kensaYoteiMonthRadioButton.Checked;
            kensaYoteiToMonthTextBox.Enabled = kensaYoteiMonthRadioButton.Checked;
        }

        #region 表示連携用インターフェース

        public void RefreshDisp()
        {
            // TODO 
        }

        public void SelectKensaYotei(string key)
        {
            // 選択部分の行表示を変更する
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (((string)gridRow.Cells[ColKyokaiNo.Index].Value) == key)
                {
                    // スタイルを選択用に変更
                    gridRow.DefaultCellStyle.BackColor = Color.AliceBlue;
                }
                else
                {
                    // スタイルを通常に戻す
                    gridRow.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        // TODO 更新系は、元データを変更してリフレッシュをかける方がベター
        public void SetKensaYoteiDate(string key, string yoteiDate)
        {
            // 選択部分の検査予定日を更新する
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (((string)gridRow.Cells[ColKyokaiNo.Index].Value) == key)
                {
                    // 日付を更新
                    gridRow.Cells[ColKensaYoteiDate.Index].Value = yoteiDate;
                }
            }
        }

        #endregion

    }
}
