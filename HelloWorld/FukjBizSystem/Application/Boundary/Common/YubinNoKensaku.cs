using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Common;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Utility;
using Zynas.Framework.Core.Common.Boundary;
using System.Reflection;



namespace FukjBizSystem.Application.Boundary.Common
{
    public partial class YubinNoKensaku : Form
    {

        public string ZipCd { get; set; }

        public string Adr { get; set; }

        public YubinNoKensaku()
        {
            InitializeComponent();
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                IGetYubinNoAdrMstByTodofukenAdrALInput alInput = new GetYubinNoAdrMstByTodofukenAdrALInput();
                alInput.TodofukenNm = todofukenComboBox.Text;
                alInput.AdrNm = "%" + adrTextBox.Text + "%";
                IGetYubinNoAdrMstByTodofukenAdrALOutput alOutput = new GetYubinNoAdrMstByTodofukenAdrApplicationLogic().Execute(alInput);

                if (alOutput.YubinNoAdrMstDT.Columns.Count > 0)
                {
                    yubinNoAdrMstDataGridView.DataSource = alOutput.YubinNoAdrMstDT;
                }
            }
            catch (Exception ex)
            {
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), ex.ToString());
                MessageForm.Show(MessageForm.DispModeType.Error, MessageResouce.MSGID_E00001, ex.Message);
            }
            finally
            {
                Cursor.Current = preCursor;
                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in yubinNoAdrMstDataGridView.SelectedRows)
            {
                this.ZipCd = row.Cells[0].Value.ToString();
                this.Adr = row.Cells[2].Value.ToString() + row.Cells[3].Value.ToString();
            }
            this.Close();
        }

        private void YubinNoKensaku_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'yubinNoAdrMstDataSet.TodofukenInfo' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.todofukenInfoTableAdapter.Fill(this.yubinNoAdrMstDataSet.TodofukenInfo);
            adrTextBox.Text = this.Adr;
            todofukenComboBox.Text = "福岡県";
        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            this.ZipCd = string.Empty;
            this.Adr = string.Empty;
            this.Close();
        }
    }
}
