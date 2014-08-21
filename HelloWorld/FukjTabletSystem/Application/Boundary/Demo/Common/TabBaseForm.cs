using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FukjTabletSystem.Application.Boundary.Demo.Common
{
    public class TabBaseForm : Form
    {
        #region コンストラクタ

        public TabBaseForm()
        {
            InitializeComponent();
        }

        #endregion
        
        #region 

        public virtual void SetTitle()
        {

        }

        #endregion

        #region 画面データ関連

        public  virtual FormData InitFormData()
        {
            FormData ret = new FormData();

            ret.FormType = GetType();

            return ret;
        }

        public virtual void SetFormData(FormData data)
        {
            // TODO フォームの作業データを設定する

            // TODO ボタンが押された単位装置のもののみ、設定する
        }

        public virtual FormData GetFormData()
        {
            // TODO フォームの作業データを設定する

            // TODO ボタンが押された単位装置のもののみ、設定する

            return new FormData();
        }

        #endregion

        #region 画面データ(DB)関連

        public virtual DataTable GetDBFormData()
        {
            return new DataTable();
        }

        public virtual void SetDBFormData(DataTable table)
        {

        }

        #endregion

        #region 画面遷移関連

        public virtual void ToNextForm()
        {
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetNextForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return;
            }

            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
            objNextForm.Show();

            // 画面を閉じる
            Close();
        }

        public virtual void ToLastForm()
        {
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetLastForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return;
            }

            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
            objNextForm.Show();

            // 画面を閉じる
            Close();
        }

        public virtual void ToPrevForm()
        {
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetPrevForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return;
            }

            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
            objNextForm.Show();

            // 画面を閉じる
            Close();
        }

        public virtual void ToFirstForm()
        {
            // TODO 仮で、トップメニューに遷移する
            Type nextFormType = typeof(MenuForm);
            /*
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetFirstForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return;
            }
            */

            // 次の画面に遷移
            Form objNextForm = (Form)Activator.CreateInstance(nextFormType);
            objNextForm.Show();

            // 画面を閉じる
            Close();
        }

        public virtual bool HasNextForm()
        {
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetNextForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return false;
            }

            // TODO 現在画面が未入力で遷移できない等の場合は、falseとする(継承先で実装する)

            return true;
        }

        public virtual bool HasPrevForm()
        {
            // 次の画面を取得
            Type nextFormType = FormManager.GetInstance().GetPrevForm(this.GetType());

            // 次の画面が定義されていない
            if (nextFormType == null)
            {
                return false;
            }

            // TODO 現在画面が未入力で遷移できない等の場合は、falseとする(継承先で実装する)

            return true;
        }

        #endregion

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TabBaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Font = new System.Drawing.Font("メイリオ", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 858);
            this.Name = "TabBaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

    }
}
