using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KensaYoteiMapDemo
{
    public partial class KensaMemoList : Form
    {
        #region 連携対象画面保持

        KensaYoteiMap mapForm;

        #endregion

        public KensaMemoList(KensaYoteiMap frm)
        {
            mapForm = frm;

            InitializeComponent();

            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Aqua;
        }

        private void KensaMemoList_Load(object sender, EventArgs e)
        {
            DataTable table = KensaYoteiData.GetKensaYoteiData();

            SetData(table);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow gridRow = dataGridView1.CurrentRow;

            if(string.IsNullOrEmpty((string)gridRow.Cells[no.Index].Value))
            {
                return;
            }

            SelectKensaYotei((string)gridRow.Cells[no.Index].Value);

            if (mapForm != null)
            {
                // 地図側の検査予定アイコンを選択
                mapForm.SelectKensaYotei((string)gridRow.Cells[no.Index].Value);
            }

            if (mapForm != null && mapForm.yoteiForm != null)
            {
                mapForm.yoteiForm.SelectKensaYotei((string)gridRow.Cells[no.Index].Value);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == date.Index)
            {
                string newDate = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string key = (string)dataGridView1.Rows[e.RowIndex].Cells[no.Index].Value;

                if (mapForm != null)
                {
                    mapForm.SetKensaYoteiDate(key, newDate);
                }

                if (mapForm != null && mapForm.yoteiForm != null)
                {
                    mapForm.yoteiForm.SetKensaYoteiDate(key, newDate);
                }
            }
        }

        private void SetData(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                dataGridView1.Rows.Add(
                     (string)row["KYOKAI_NO"]
                    , (string)row["SETTISHA"]
                    , (string)row["SETTI_BASHO"]
                    , (string)row["KENSA_YOTEI_NEN"] + "/" + (string)row["KENSA_YOTEI_TSUKI"] + "/" + (string)row["KENSA_YOTEI_NITI"]
                    , (string)row["MEMO1"]
                    );
                dataGridView1.Rows.Add(
                     ""
                    , ""
                    , ""
                    , ""
                    , (string)row["MEMO2"]
                    );
                dataGridView1.Rows.Add(
                     ""
                    , ""
                    , ""
                    , ""
                    , (string)row["MEMO3"]
                    );

            }
        }

        #region 表示連携用インターフェース

        public void RefreshDisp()
        {
            // TODO 表示データの連携先画面からの更新など、再描画が必要な場合は適宜呼出
        }

        public void SelectKensaYotei(string key)
        {
            // 選択部分の行表示を変更する
            foreach (DataGridViewRow gridRow in dataGridView1.Rows)
            {
                if (((string)gridRow.Cells[no.Index].Value) == key)
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
                if (((string)gridRow.Cells[no.Index].Value) == key)
                {
                    // 日付を更新
                    gridRow.Cells[date.Index].Value = yoteiDate;
                }
            }
        }

        #endregion
    }
}
