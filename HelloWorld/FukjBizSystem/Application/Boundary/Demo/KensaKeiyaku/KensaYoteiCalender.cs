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
    public partial class KensaYoteiCalender : Form
    {
        //private String m7jo;
        //private String m11jo1;
        //private String m11jo2;

        public KensaYoteiCalender()
        {
            InitializeComponent();
        }

        //TextBox1.Textを取得、設定するためのプロパティ
        public string TextBoxText
        {
            get
            {
                return textBox10.Text;
            }
            set
            {
                textBox10.Text = value;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // -------- textBox1 ---------
        private void textBox42_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //this.textBox1.SelectAll();
            this.DoDragDrop("1", DragDropEffects.Copy);
        }

        private void textBox42_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("DragEnter");
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox42_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("DragEnter");
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox42_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            //Debug.WriteLine("DragDrop");
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if (this.textBox42.Text != "")
                {
                    //メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("加算しますか？",
                        "確認",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.Yes)
                    {
                        this.textBox42.Text = "\r\n7条 03件\r\n11条 05件\r\n11条 03件";
                        this.textBox46.Text = "";
                    }

                }
                else
                {
                    this.textBox42.Text = "\r\n7条 03件\r\n11条 05件\r\n11条 03件";
                    this.textBox46.Text = "";
                }
                //this.textBox42.Text = (string)e.Data.GetData(DataFormats.Text);
            }
        }

        // -------- textBox2 ---------
        private void textBox46_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //this.textBox2.SelectAll();
            this.DoDragDrop("2", DragDropEffects.Copy);
        }

        private void textBox46_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("DragDrop");
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                if (this.textBox46.Text != "")
                {
                    //メッセージボックスを表示する
                    DialogResult result = MessageBox.Show("加算しますか？",
                        "確認",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);

                    //何が選択されたか調べる
                    if (result == DialogResult.Yes)
                    {
                        this.textBox46.Text = "\r\n7条 03件\r\n11条 05件\r\n11条 03件";
                        this.textBox42.Text = "";
                    }
                }
                else
                {
                    this.textBox46.Text = "\r\n7条 03件\r\n11条 05件\r\n11条 03件";
                    this.textBox42.Text = "";
                }
                //this.textBox46.Text = (string)e.Data.GetData(DataFormats.Text);
            }
        }

        private void textBox46_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("DragEnter");
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void textBox46_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            Debug.WriteLine("DragEnter");
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }
    }
}
