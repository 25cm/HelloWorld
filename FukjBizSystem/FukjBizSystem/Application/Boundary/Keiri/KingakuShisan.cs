using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SaisuiinMstList;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class KingakuShisanForm : Form
    {

        public KingakuShisanForm()
        {
            InitializeComponent();
            this.dataGridView1.Rows.Add("5～10", "9,000", "4,000", "5,600");
            this.dataGridView1.Rows.Add("11～20", "9,500", "4,500", "6,500");
            this.dataGridView1.Rows.Add("21～50", "12,000", "7,000", "8,000");
            this.dataGridView1.Rows.Add("51～100", "14,000", "9,000", "13,600");
            this.dataGridView1.Rows.Add("101～300", "17,000", "11,000", "16,600");
            this.dataGridView1.Rows.Add("301～500", "20,000", "14,000", "19,600");
            this.dataGridView1.Rows.Add("501～1000", "23,000", "17,000", "22,600");
            this.dataGridView1.Rows.Add("1001～5000", "26,000", "20,000", "25,600");
            this.dataGridView1.Rows.Add("5001以上", "29,000", "23,000", "28,600");

            this.SuishistuListDataGridView.Rows.Add("false", "単", "1","透視度", "540");
            this.SuishistuListDataGridView.Rows.Add("false", "単", "2", "pH", "648");
            this.SuishistuListDataGridView.Rows.Add("false", "セット", "1", "放流水検査(10人槽以下)A", "4,860");
            this.SuishistuListDataGridView.Rows.Add("false", "セット", "2", "放流水検査(10人槽以下)B", "6,480");

            this.YoshiListDataGridView.Rows.Add("01", "浄化槽設置届出・計画書", "150", "510", "", "", "", "", "");
            this.YoshiListDataGridView.Rows.Add("02", "浄化槽を設置しない旨の届出書", "30", "40", "500", "750", "25", "", "");

        
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
        }

        private void viewChangeButton_Click(object sender, EventArgs e)
        {
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
        }

        private void saisuiinMstListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void torokuButton_Click(object sender, EventArgs e)
        {
            int selcol = 0;
            int selrow = 0;
            String temp = "";

            foreach (DataGridViewCell c in dataGridView1.SelectedCells)
            {
                selcol = c.ColumnIndex;
                selrow = c.RowIndex;
            }
            int hotei = 0;
            if (selcol>0)
            {
                temp = (String)dataGridView1.Rows[selrow].Cells[selcol].Value;
                hotei = int.Parse(temp, System.Globalization.NumberStyles.AllowThousands);
            }

            int suishitsu = 0;
            for(int i=0;i < SuishistuListDataGridView.RowCount;i++){
                temp = Convert.ToString(SuishistuListDataGridView.Rows[i].Cells[0].Value);
                if (temp == "True")
                 {
                     suishitsu = suishitsu + int.Parse((String)SuishistuListDataGridView.Rows[i].Cells[4].Value, System.Globalization.NumberStyles.AllowThousands);
                }
             }

            int yoshi = 0;
            for (int i = 0; i < YoshiListDataGridView.RowCount; i++)
            {
                if ((string)YoshiListDataGridView.Rows[i].Cells[7].Value != "")
                {
                    if (radioButton1.Checked)
                    {
                        yoshi = yoshi + int.Parse((String)YoshiListDataGridView.Rows[i].Cells[2].Value, System.Globalization.NumberStyles.AllowThousands) * int.Parse((String)YoshiListDataGridView.Rows[i].Cells[7].Value, System.Globalization.NumberStyles.AllowThousands);
                    }
                    else
                    {
                        yoshi = yoshi + int.Parse((String)YoshiListDataGridView.Rows[i].Cells[3].Value, System.Globalization.NumberStyles.AllowThousands) * int.Parse((String)YoshiListDataGridView.Rows[i].Cells[7].Value, System.Globalization.NumberStyles.AllowThousands);
                    }
                }
                if ((string)YoshiListDataGridView.Rows[i].Cells[8].Value != "" && (string)YoshiListDataGridView.Rows[i].Cells[6].Value != "")
                {
                    if (radioButton1.Checked)
                    {
                        yoshi = yoshi + int.Parse((String)YoshiListDataGridView.Rows[i].Cells[4].Value, System.Globalization.NumberStyles.AllowThousands) * int.Parse((String)YoshiListDataGridView.Rows[i].Cells[8].Value, System.Globalization.NumberStyles.AllowThousands);
                    }
                    else
                    {
                        yoshi = yoshi + int.Parse((String)YoshiListDataGridView.Rows[i].Cells[5].Value, System.Globalization.NumberStyles.AllowThousands) * int.Parse((String)YoshiListDataGridView.Rows[i].Cells[8].Value, System.Globalization.NumberStyles.AllowThousands);
                    }
                }

            }

            int total = hotei + suishitsu + yoshi;

            zTextBox1.Text = total.ToString("#,0");
        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            KeiriMenuForm frm = new KeiriMenuForm();
            Program.mForm.ShowForm(frm);
        }

        private void SaisuiinMstListForm_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }



    }
}
