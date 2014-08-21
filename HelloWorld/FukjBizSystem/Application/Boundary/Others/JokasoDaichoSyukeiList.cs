using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Others
{
    public partial class JokasoDaichoSyukeiListForm : Form
    {
        public JokasoDaichoSyukeiListForm()
        {
            InitializeComponent();
            this.JokasoListDataGridView.Rows.Add("○○保健所", "25-00123", "2012/07/01", "2014/08/01", "11条検査", "浄化槽太郎", "○○市○○町３丁目１", "080-9999-9999", "合併", "20", "90", "送風機が故障", "","有", "株式会社○○環境設備", "有限会社○○衛生","送風機の交換","");
            this.JokasoListDataGridView.Rows.Add("○○保健所", "25-00124", "2012/07/22", "2014/08/02", "11条検査", "浄化槽次郎", "○○市○○町４丁目２", "092-888-8888", "合併", "12", "20", "流入升破損、漏水あり", "", "有", "(有)○○環境", "株式会社△△", "破損個所のコーキング", "");
            this.JokasoListDataGridView.Rows.Add("○○保健所", "25-00128", "2012/09/01", "2014/08/12", "11条検査", "浄化槽三郎", "○○市○○町５丁目３", "092-777-7777", "合併", "7", "31", "嫌気ろ床槽、ろ材浮上", "", "有", "(有)○○設備", "株式会社□□", "清掃実施時にろ材押させ補修", "");

            this.JokasoListDataGridView.Columns["Biko"].Visible = false;

        }

        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            if (searchPanel.Height == 30)
            {
                searchPanel.Height = 136;
                MaeukekinListPanel.Top = 139;
                MaeukekinListPanel.Height = 399;
                viewChangeButton.Text = "▲";
            }
            else
            {
                searchPanel.Height = 30;
                MaeukekinListPanel.Top = 30;
                MaeukekinListPanel.Height = 505;
                viewChangeButton.Text = "▼";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
        }

        private void kensakuButton_Click(object sender, EventArgs e)
        {
        }

        private void torokuButton_Click(object sender, EventArgs e)
        {
        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
        }

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            OthersMenuForm frm = new OthersMenuForm();
            Program.mForm.ShowForm(frm);
        }

        private void FutekiseiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (FutekiseiRadioButton.Checked)
            {
                this.JokasoListDataGridView.Columns["KensaKbn"].Visible = true;
                this.JokasoListDataGridView.Columns["HoryuBod"].Visible = true;
                this.JokasoListDataGridView.Columns["Shiteki"].Visible = true;
                this.JokasoListDataGridView.Columns["SyashinUmu"].Visible = true;
                this.JokasoListDataGridView.Columns["KaizenHoho"].Visible = true;
                this.JokasoListDataGridView.Columns["Biko"].Visible = false;

            }
        }

        private void MukanriRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MukanriRadioButton.Checked)
            {
                this.JokasoListDataGridView.Columns["KensaKbn"].Visible = false;
                this.JokasoListDataGridView.Columns["HoryuBod"].Visible = false;
                this.JokasoListDataGridView.Columns["Shiteki"].Visible = false;
                this.JokasoListDataGridView.Columns["SyashinUmu"].Visible = false;
                this.JokasoListDataGridView.Columns["KaizenHoho"].Visible = false;

                this.JokasoListDataGridView.Columns["Biko"].Visible = true;
            }
        }

        private void MijukenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MijukenRadioButton.Checked)
            {
                this.JokasoListDataGridView.Columns["KensaKbn"].Visible = false;
                this.JokasoListDataGridView.Columns["HoryuBod"].Visible = false;
                this.JokasoListDataGridView.Columns["Shiteki"].Visible = false;
                this.JokasoListDataGridView.Columns["SyashinUmu"].Visible = false;
                this.JokasoListDataGridView.Columns["KaizenHoho"].Visible = false;
                this.JokasoListDataGridView.Columns["Biko"].Visible = false;

            }

        }

        private void IkoJokyoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }



    }

}
