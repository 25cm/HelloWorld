using System;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Master;
using FukjBizSystem.Application.Boundary.KinoHoshoKanri;
using FukjBizSystem.Application.Boundary.YoshiHanbaiKanri;
using FukjBizSystem.Application.Boundary.SaisuiinKanri;
using FukjBizSystem.Application.Boundary.KaiinKanri;
using FukjBizSystem.Application.Boundary.Keiri;
using FukjBizSystem.Application.Boundary.JokasoDaichoKanri;
using FukjBizSystem.Application.Boundary.KensaIraiKanri;
using FukjBizSystem.Application.Boundary.KensaKekka;
using FukjBizSystem.Application.Boundary.Others;
using Zynas.Control;
using FukjBizSystem.Application.Boundary.GaikanKensa;

namespace FukjBizSystem.Application.Boundary.Common
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： MenuForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/19  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class MenuForm : Form
    {
        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： MenuForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/19  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public MenuForm()
            : base()
        {
            InitializeComponent();
        }
        #endregion
        
        public void ShowForm(Form frm)
        {
            this.formPanel.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            //frm.Parent=this;
            formPanel.Controls.Add(frm);
            this.Text = frm.Text;
            frm.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MstMenuForm frm = new MstMenuForm();
            this.ShowForm(frm);
        }

        // TODO test code
        private void button3_Click(object sender, EventArgs e)
        {
            WorkListForm frm = new WorkListForm();
            this.ShowForm(frm);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KinoMenuForm frm = new KinoMenuForm();
            this.ShowForm(frm);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            //ログイン者の氏名を設定する
            this.strShokuinNm.Text = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;
            // TODO 初期表示メニューを表示する
            WorkListForm frm = new WorkListForm();
            this.ShowForm(frm);
            //MstMenuForm frm = new MstMenuForm();
            //this.ShowForm(frm);

            //this.dynButtonMenu();
        }

        #region　動的にメニューボタン配置サンプル
        private Button[] buttons;
        private void dynButtonMenu()
        {
            //ボタンコントロール配列の作成
            this.buttons = new Button[10];
            for (int i = 0; i < buttons.Length; i++)
            {
                //ボタンコントロールのインスタンス作成
                this.buttons[i] = new ZButton();

                //プロパティ設定
                this.buttons[i].Name = "FukjBizSystem.Application.Boundary.Master.HokenjoMstListForm";// +i.ToString();
                this.buttons[i].Text = "機能名" + i.ToString();
                this.buttons[i].Top = i * 30;
                //this.buttons[i].Image = GetImageFromResource("FukjBizSystem.Application.Boundary.Master.HokenjoMstListForm");
                this.buttons[i].Image = GetImageFromResource("icon_end");

                //コントロールをフォームに追加
                this.panel2.Controls.Add(this.buttons[i]);
                this.buttons[i].Click += new System.EventHandler(btnclick);
            }
            MstMenuForm frm = new MstMenuForm();
            this.ShowForm(frm);
        }
        private void btnclick(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            string formTypeName = btn.Name;
            Type formType = Type.GetType(formTypeName);
            Form objForm = (Form)Activator.CreateInstance(formType);
            this.ShowForm(objForm);
        }

        private System.Drawing.Image GetImageFromResource(string propertyName)
        {
            System.Drawing.Image img = null;

            System.Resources.ResourceManager rm = new System.Resources.ResourceManager("FukjBizSystem.Properties.Resources", this.GetType().Assembly);
            img = (System.Drawing.Image)rm.GetObject(propertyName);

            return img;

        }

        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YoshiMenuForm frm = new YoshiMenuForm();
            this.ShowForm(frm);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaisuiinMenuForm frm = new SaisuiinMenuForm();
            this.ShowForm(frm);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            KaiinMenuForm frm = new KaiinMenuForm();
            this.ShowForm(frm);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            KeiriMenuForm frm = new KeiriMenuForm();
            this.ShowForm(frm);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            JokasoDaichoKanriMenu frm = new JokasoDaichoKanriMenu();
            this.ShowForm(frm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KensaIraiKanriMenu frm = new KensaIraiKanriMenu();
            this.ShowForm(frm);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KekkaMenuForm frm = new KekkaMenuForm();
            this.ShowForm(frm);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OthersMenuForm frm = new OthersMenuForm();
            this.ShowForm(frm);
        }

        private void kensaKeisakuDemoButton_Click(object sender, EventArgs e)
        {
            KensaYoteiMapDemo.KensaYoteiMap frm = new KensaYoteiMapDemo.KensaYoteiMap();
            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GaikanKensaMenuForm frm = new GaikanKensaMenuForm();
            this.ShowForm(frm);
        }

    }
    #endregion
}
