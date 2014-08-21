using System;
using System.Windows.Forms;
using FukjTabletSystem.Properties;
using Microsoft.VisualBasic;
using Zynas.Framework.Core.Base.Boundary;
using FukjTabletSystem.Application.Boundary.MapWorks;

namespace FukjTabletSystem.Application.Boundary.Demo
{
    public partial class KensaYoteiListForm : BaseTabletForm2
    {
        #region KensaYoteiListForm()
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public KensaYoteiListForm()
        {
            InitializeComponent();
        }
        #endregion

        #region KensaYoteiListForm_Load(object sender, EventArgs e)
        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KensaYoteiListForm_Load(object sender, EventArgs e)
        {
            targetDateTimePicker.Value = DateTime.Today;

            #region 列の作成(イメージ列、ボタン列)

            //DataGridViewButtonColumnの作成
            DataGridViewImageColumn column = new DataGridViewImageColumn();
            //列の名前を設定
            column.Name = "状況";
            column.Image = Resources.Pin_Red; // TODO: データの検査状況に応じてピンの色を使い分ける
            //DataGridViewに追加する
            dataGridView.Columns.Add(column);

            ////DataGridViewButtonColumnの作成
            //DataGridViewButtonColumn column1 = new DataGridViewButtonColumn();
            ////列の名前を設定
            //column1.Name = "機能１";
            ////全てのボタンに"詳細閲覧"と表示する
            //column1.UseColumnTextForButtonValue = true;
            //column1.Text = "検査";
            ////DataGridViewに追加する
            //dataGridView.Columns.Add(column1);

            ////DataGridViewButtonColumnの作成
            //DataGridViewButtonColumn column2 = new DataGridViewButtonColumn();
            ////列の名前を設定
            //column2.Name = "機能２";
            ////全てのボタンに"詳細閲覧"と表示する
            //column2.UseColumnTextForButtonValue = true;
            //column2.Text = "地図";
            ////DataGridViewに追加する
            //dataGridView.Columns.Add(column2);

            //DataGridViewButtonColumnの作成
            DataGridViewImageColumn column3 = new DataGridViewImageColumn();
            //列の名前を設定
            column3.Name = "検査";
            column3.Image = Resources.Kensa;
            //DataGridViewに追加する
            dataGridView.Columns.Add(column3);

            //DataGridViewButtonColumnの作成
            DataGridViewImageColumn column4 = new DataGridViewImageColumn();
            //列の名前を設定
            column4.Name = "地図";
            column4.Image = Resources.Map;
            //DataGridViewに追加する
            dataGridView.Columns.Add(column4);

            #endregion

            #region 列幅（FillWeightでざっくり指定）

            dataGridView.Columns[0].FillWeight = 10;
            dataGridView.Columns[1].FillWeight = 60;
            dataGridView.Columns[2].FillWeight = 10;
            dataGridView.Columns[3].FillWeight = 15;
            dataGridView.Columns[4].FillWeight = 15;
            dataGridView.Columns[5].FillWeight = 15;

            #endregion

            #region デモ用データ入力

            for (int i = 1; i <= 20; i++)
            {
                KensaYoteiListDataSet.検査予定リストRow newRow = kensaYoteiListDataSet.検査予定リスト.New検査予定リストRow();
                newRow.順番 = i;
                newRow.検査箇所名 = string.Format("検査箇所{0}", Strings.StrConv(i.ToString(), VbStrConv.Wide));
                newRow.状況 = 0;
                kensaYoteiListDataSet.検査予定リスト.Add検査予定リストRow(newRow);
            }

            #endregion

            #region 行の高さ設定

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = Resources.Pin_Red.Height;
            }

            #endregion
        }
        #endregion

        #region closeButton_Click(object sender, EventArgs e)
        /// <summary>
        /// 閉じるボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        #endregion
                
        #region dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        /// <summary>
        /// セルクリック（ボタン押下の判定）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || (e.ColumnIndex != dataGridView.Columns["検査"].Index && e.ColumnIndex != dataGridView.Columns["地図"].Index))
            {
                return;
            }

            if(e.ColumnIndex == dataGridView.Columns["検査"].Index)
            {
                // TODO: 検査メニューを起動する
                KensaMenuForm frm = new KensaMenuForm(dataGridView[1, e.RowIndex].Value.ToString());
                frm.Show();

                return;
            }

            if (e.ColumnIndex == dataGridView.Columns["地図"].Index)
            {
                // TODO: 地図を起動する
                //JokasoMapForm frm = new JokasoMapForm(dataGridView[1, e.RowIndex].Value.ToString());
                MapWorksForm frm = new MapWorksForm();
                frm.Show();

                return;
            }
        }
        #endregion

        private void mapButton_Click(object sender, EventArgs e)
        {
            // TODO: 地図を起動する
            MapWorksForm frm = new MapWorksForm();
            frm.Show();

            return;
        }
    }
}
