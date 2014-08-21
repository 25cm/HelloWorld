using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Demo
{
    public partial class SuishitsuKensaDaichoForm : Form
    {
        // 下線付きフォント
        private Font underLineFont;

        public SuishitsuKensaDaichoForm()
        {
            InitializeComponent();

            // フォームのフォントのベースに下線付きフォントを生成
            underLineFont = new Font(this.Font, this.Font.Style | FontStyle.Strikeout);

            // マージ対象を設定
            listDataGridView.AddMergeCol(IraiNoCol.Index, 2);
            listDataGridView.AddMergeCol(IzyouCol.Index, 2);
            listDataGridView.AddMergeCol(HanteiCol.Index, 2);
            listDataGridView.AddMergeCol(SyoriCol.Index, 2);

            listDataGridView.AddMergeCol(HistCol.Index, 2);
            listDataGridView.AddMergeCol(EnkaIonHistCol.Index, 2);
            listDataGridView.AddMergeCol(SaisuiinCol.Index, 2);
            listDataGridView.AddMergeCol(keninCol.Index, 2);
        }

        private void SuishitsuKensaDaichoForm_Load(object sender, EventArgs e)
        {
            // 初期条件設定
            kensa11JouRadioButton.Checked = true;
        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            // TODO この辺の処理は全体的に汎用化する
            if (viewChangeButton.Text == "▼")
            //if (searchPanel.Height == 30)
            {
                searchPanel.Height = 110;
                //listPanel.Top = 187;
                //listPanel.Height = 339;
                viewChangeButton.Text = "▲";
            }
            else
            {
                searchPanel.Height = 30;
                //listPanel.Top = 30;
                //listPanel.Height = 475;
                viewChangeButton.Text = "▼";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void torokuButton_Click(object sender, EventArgs e)
        {

        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {

        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            // TODO 
            KensaKekka.KekkaMenuForm frm = new KensaKekka.KekkaMenuForm();
            Program.mForm.ShowForm(frm);
        }

        private void kakuninOutputButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("機能説明:確認検査対象の帳票(Excel)を出力します");
        }

        private void keninTuorokuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("機能説明:採用値変更、検印後に登録を行います。\n課長の検印後は検査台帳が確定済みとなり。以後の変更は出来ません。\n確定直後であれば、確定の解除が可能です。");
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("機能説明:画面表示内容に対応する検査台帳を出力します\n(内容確認用の帳票として)");
        }

        private void DoSearch()
        {
            // 既存データクリア
            listDataGridView.Rows.Clear();

            DataTable table = GetData();

            StringBuilder cond = new StringBuilder();
            if (!string.IsNullOrEmpty(nendoTextBox.Text))
            {
                if (cond.Length > 0) { cond.Append(" AND "); }
                cond.AppendFormat("IraiNendo = '{0}'", nendoTextBox.Text);
            }
            if (!string.IsNullOrEmpty(noFromTextBox.Text))
            {
                if (cond.Length > 0) { cond.Append(" AND "); }
                cond.AppendFormat("IraiRenban >= '{0}'", noFromTextBox.Text);
            }
            if (!string.IsNullOrEmpty(noToTextBox.Text))
            {
                if (cond.Length > 0) { cond.Append(" AND "); }
                cond.AppendFormat("IraiRenban <= '{0}'", noToTextBox.Text);
            }

            // TODO 製品版では、クエリ内でフィルタを行う
            foreach (DataRow row in table.Select(cond.ToString()))
            {
                SetData(row);
            }
        }

        private DataTable GetData()
        {
            // TODO 製品版ではALを実行・取得する

            DataTable table = new DataTable();

            table.Columns.Add("IraiNendo", typeof(string));
            table.Columns.Add("IraiRenban", typeof(string));

            // TODO 異常判定の取得方法は別途検討
            table.Columns.Add("IzyouKbn", typeof(string));
            table.Columns.Add("HanteiKbn", typeof(string));
            table.Columns.Add("SyoriKbn", typeof(string));

            table.Columns.Add("Ph", typeof(decimal));
            table.Columns.Add("Celsius", typeof(decimal));
            table.Columns.Add("Toushido", typeof(int));
            table.Columns.Add("Bod", typeof(decimal));
            table.Columns.Add("Zanen", typeof(decimal));
            table.Columns.Add("EnkaIon", typeof(decimal));

            // TODO データ取得ロジックで、2レコードに分けるか、横持にするかは検討
            // TODO 縦持ちにする場合は、取得データに再検査回数の保持が必要
            table.Columns.Add("SaikensaKaisu", typeof(int));

            // TODO とりあえず、横持で
            table.Columns.Add("Ph2", typeof(decimal));
            table.Columns.Add("Celsius2", typeof(decimal));
            table.Columns.Add("Toushido2", typeof(int));
            table.Columns.Add("Bod2", typeof(decimal));
            table.Columns.Add("Zanen2", typeof(decimal));
            table.Columns.Add("EnkaIon2", typeof(decimal));

            // TODO 過去5年分を取得・表示する
            table.Columns.Add("EnkaIonHist", typeof(string));

            {
                DataRow row = table.NewRow();

                row["IraiNendo"] = "2014";
                row["IraiRenban"] = "0001";
                row["IzyouKbn"] = "●";
                row["HanteiKbn"] = "";
                row["SyoriKbn"] = "合併";

                row["Ph"] = 6.1m;
                row["Celsius"] = 21.4m;
                row["Toushido"] = 12;
                row["Bod"] = 120m;
                row["Zanen"] = 0.1m;
                row["EnkaIon"] = 88m;

                row["EnkaIonHist"] = "";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["IraiNendo"] = "2014";
                row["IraiRenban"] = "0002";
                row["IzyouKbn"] = "";
                row["HanteiKbn"] = "適正";
                row["SyoriKbn"] = "合併";

                row["Ph"] = 6.1m;
                row["Celsius"] = 21.4m;
                row["Toushido"] = 21;
                row["Bod"] = 5m;
                row["Zanen"] = 1m;
                //row["EnkaIon"] = 48m;

                row["Toushido2"] = 30;

                row["EnkaIonHist"] = "";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["IraiNendo"] = "2014";
                row["IraiRenban"] = "0003";
                row["IzyouKbn"] = "☆";
                row["HanteiKbn"] = "適正";
                row["SyoriKbn"] = "合併";

                row["Ph"] = 6.1m;
                row["Celsius"] = 21.4m;
                row["Toushido"] = 30;
                row["Bod"] = 2m;
                row["Zanen"] = 0.5m;
                row["EnkaIon"] = 23m;

                row["EnkaIon2"] = 19m;

                row["EnkaIonHist"] = "43 51 49 39 48";

                table.Rows.Add(row);
            }

            return table;
        }

        private void SetData(DataRow row)
        {
            // 未入力項目は、該当項目を、黄色で表示する
            // 確定検査対象の場合は、該当項目を、青色で表示する

            // 初回検査結果表示
            listDataGridView.Rows.Add(
                row["IraiRenban"]
                , row["IzyouKbn"]
                , row["HanteiKbn"]
                , row["SyoriKbn"]
                , "情報"
                , row["Ph"]
                , row["Celsius"]
                , row["Toushido"]
                , ""
                , false
                , row["Bod"]
                , ""
                , false
                , row["Zanen"]
                , ""
                , false
                , row["EnkaIon"]
                , ""
                , false
                , row["EnkaIonHist"]
                , "情報"
                , false
                );

            // 確定検査結果表示
            listDataGridView.Rows.Add(
                row["IraiRenban"]
                , row["IzyouKbn"]
                , row["HanteiKbn"]
                , row["SyoriKbn"]
                , "情報"
                , row["Ph2"]
                , row["Celsius2"]
                , row["Toushido2"]
                , ""
                , false
                , row["Bod2"]
                , ""
                , false
                , row["Zanen2"]
                , ""
                , false
                , row["EnkaIon2"]
                , ""
                , false
                , row["EnkaIonHist"]
                , "情報"
                , false
                );

            // TODO 検査結果値以外の列は、2行分のマージを行う
            // TODO 標準ではマージできないので、カスタム処理の実装が必要(ZDataGridViewなどを作成（AddAutoMergeCol,ClearAutoMergeColなどのメソッドを作成する）)
            // TODO ヘッダのマージ定義はデータ部とは別途指定とする

            // セル背景色設定
            DataGridViewRow newGridRow1 = listDataGridView.Rows[listDataGridView.Rows.Count - 2];
            DataGridViewRow newGridRow2 = listDataGridView.Rows[listDataGridView.Rows.Count - 1];

            // 未入力
            if (row["Ph"] == DBNull.Value)
            {
                // TODO
                //SetColorTemp(listDataGridView.Rows.Count - 2, phCol.Index, Color.Yellow);
            }
            else if (row["Toushido"] == DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, ToushidoCol.Index, Color.Yellow);
            }
            else if (row["Bod"] == DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, BodCol.Index, Color.Yellow);
            }
            else if (row["Zanen"] == DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, ZanenCol.Index, Color.Yellow);
            }
            else if (row["EnkaIon"] == DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, EnkaIonCol.Index, Color.Yellow);
            }

            // 確認検査対象
            if (row["Ph2"] != DBNull.Value)
            {
                // TODO 
                //SetColorTemp(listDataGridView.Rows.Count - 2, phCol.Index, Color.LightBlue);
            }
            else if (row["Toushido2"] != DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, ToushidoCol.Index, Color.LightBlue);
            }
            else if (row["Bod2"] != DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, BodCol.Index, Color.LightBlue);
            }
            else if (row["Zanen2"] != DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, ZanenCol.Index, Color.LightBlue);
            }
            else if (row["EnkaIon2"] != DBNull.Value)
            {
                SetColorTemp(listDataGridView.Rows.Count - 2, EnkaIonCol.Index, Color.LightBlue);
            }
        }

        private void SetColorTemp(int rowIdx, int colIdx, Color color)
        {
            DataGridViewRow newGridRow1 = listDataGridView.Rows[rowIdx];
            DataGridViewRow newGridRow2 = listDataGridView.Rows[rowIdx + 1];

            newGridRow1.Cells[colIdx].Style.BackColor = color;
            newGridRow1.Cells[colIdx + 1].Style.BackColor = color;
            newGridRow1.Cells[colIdx + 2].Style.BackColor = color;
            newGridRow2.Cells[colIdx].Style.BackColor = color;
            newGridRow2.Cells[colIdx + 1].Style.BackColor = color;
            newGridRow2.Cells[colIdx + 2].Style.BackColor = color;
        }

        private void listDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO ボタン処理

            if (e.ColumnIndex == HistCol.Index)
            {
                MessageBox.Show("該当浄化槽の、過去5年間の検査履歴を表示します。\n(確認検査を行った場合、最終結果値・判定を表示)");
            }
            else if (e.ColumnIndex == SaisuiinCol.Index)
            {
                MessageBox.Show("該当検査の採水員情報を表示します。");
            }

            // チェックボックスセルの場合は、直ちに編集を終了する(直ちにValueChangedイベントを発生させるため)
            if (listDataGridView.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                listDataGridView.EndEdit();
            }
        }

        private void listDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Toushido3Col.Index
                || e.ColumnIndex == Bod3Col.Index
                || e.ColumnIndex == Zanen3Col.Index
                || e.ColumnIndex == EnkaIon3Col.Index
               )
            {
                // チェックされた場合
                if (listDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(true))
                {
                    // 初回検査(偶数行)の場合
                    if (e.RowIndex % 2 == 0)
                    {
                        listDataGridView.Rows[e.RowIndex + 1].Cells[e.ColumnIndex].Value = false;

                        listDataGridView.Rows[e.RowIndex + 1].Cells[e.ColumnIndex - 2].Style.Font = underLineFont;

                        listDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Style.Font = listDataGridView.DefaultCellStyle.Font;
                    }
                    // 確認検査(奇数行)の場合
                    else
                    {
                        listDataGridView.Rows[e.RowIndex - 1].Cells[e.ColumnIndex].Value = false;

                        listDataGridView.Rows[e.RowIndex - 1].Cells[e.ColumnIndex - 2].Style.Font = underLineFont;

                        listDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex - 2].Style.Font = listDataGridView.DefaultCellStyle.Font;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow gridRow in listDataGridView.Rows)
            {
                gridRow.Cells[keninCol.Index].Value = kenin2CheckBox.Checked;
            }
        }

    }
}
