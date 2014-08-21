using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
//using FukjBizSystem.Application.ApplicationLogic.Master.SuishitsuMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;
using System.Drawing;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    public partial class KaikeiMakeFileForm : Form
    {
        int stepCnt = 0;

        public KaikeiMakeFileForm()
        {
            InitializeComponent();
            this.SrhDtFromTextBox.Value = DateTime.ParseExact("2014/07/01", "yyyy/MM/dd", null);
        }
        private void EntryButton_Click(object sender, EventArgs e)
        {
            //モック専用メッセージ確認のため
            switch (stepCnt)
            {
                case 0:
                    textBox1.Text = "処理を開始します";
                    textBox1.ForeColor = Color.Blue;
                    break;
                case 1:
                    textBox1.Text = "処理中：1/234";
                    textBox1.ForeColor = Color.Blue;
                    break;
                case 2:
                    textBox1.Text = "処理中：123/234";
                    textBox1.ForeColor = Color.Blue;
                    break;
                case 3:
                    textBox1.Text = "正常に処理が完了しました。";
                    textBox1.ForeColor = Color.Blue;
                    break;
                default:
                    textBox1.Text = "";
                    //String buff = "会計連動作成処理でエラーが発生しました。\r\n";
                    //buff += "1234:株式会社○○環境開発工業:日報が未作成です\r\n";
                    //buff += "2345:株式会社△△△△:日報が未作成です\r\n";
                    //buff += "3456:株式会社■■■■:日報が未作成です\r\n";
                    //textBox1.Text = buff;
                    //textBox1.ForeColor = Color.Red;
                    break;
            }
            stepCnt += 1;
            //MessageForm.Show2(MessageForm.DispModeType.Warning, "日報未提出のため");

        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
        }

        private void ReInputButton_Click(object sender, EventArgs e)
        {
        }

        private void DecisionButton_Click(object sender, EventArgs e)
        {
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
