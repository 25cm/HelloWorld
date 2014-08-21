using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Zynas.Framework.Core.Base.Boundary
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： BaseTabletForm
    /// <summary>
    /// フォームの基本クラス
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/07　豊田　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class BaseTabletForm : Form
    {
        #region 定義

        /// <summary>
        /// フォーム終了時のデリゲート
        /// </summary>
        /// <param name="form"></param>
        public delegate void FormEnd(Form form);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="form"></param>
        private delegate void InvokeDelegete(Form form);

        #endregion
                
        #region プロパティ(private)

        /// <summary>
        /// モーダル制御フラグ
        /// </summary>
        private bool ModalFlg = false;

        /// <summary>
        /// フォーム終了時のデリゲート
        /// </summary>
        private event FormEnd FormEndEvent = null;
        
        #endregion

        #region コンストラクタ

        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： BaseTabletForm
        /// <summary>
        /// クラスの構築を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/08　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public BaseTabletForm()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： BaseTabletForm
        /// <summary>
        /// クラスの構築を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="formEnd">画面終了イベント</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/08　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        protected BaseTabletForm(FormEnd formEnd)
        {
            // フォーム終了時イベントを設定
            FormEndEvent = formEnd;

            InitializeComponent();
        }

        #endregion

        #region メソッド(public)

        #region ShowDialog
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ShowDialog
        /// <summary>
        /// フォームをモーダルダイアログボックスとして表示します
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/03/18　和田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        new public void ShowDialog()
        {
            // モーダル制御フラグＯＮ
            ModalFlg = true;
            // フォームをモードレスで表示
            Show(ActiveForm);
        }
        #endregion

        #region ShowDialog
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ShowDialog
        /// <summary>
        /// フォームをモーダルダイアログボックスとして表示します
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="owner">親フォーム</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/03/18　和田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        new public void ShowDialog(IWin32Window owner)
        {
            // モーダル制御フラグＯＮ
            ModalFlg = true;
            // フォームをモードレスで表示
            Show(owner);
        }
        #endregion


        /// <summary>
        /// フォームを表示する
        /// </summary>
        delegate void ShowFormDelegate();
        public void ShowForm()
        {
            if (InvokeRequired)
            {
                // 別スレッドから呼び出された場合
                this.BeginInvoke(new ShowFormDelegate(ShowForm));
                return;
            }
            this.ShowDialog();
        }

        /// <summary>
        /// フォームをクローズする
        /// </summary>
        delegate void CloseFormDelegate();
        public void CloseForm()
        {
            if (InvokeRequired)
            {
                // 別スレッドから呼び出された場合
                this.BeginInvoke(new CloseFormDelegate(CloseForm));
                return;
            }
            this.Close();
        }

        #endregion

        #region メソッド(protected)

        #endregion

        #region メソッド(private)

        #region CloseChildForm
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CloseChildForm
        /// <summary>
        /// 子画面(イメージ画面以外)を閉じる
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/08/17　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void CloseChildForm()
        {
            try
            {
                // 所有する子画面を全て確認
                foreach (Form form in OwnedForms)
                {
                    try
                    {
                        // 子画面を終了
                        form.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("CloseChildForm1 {0}{1}", ex.Message, form.Name));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("CloseChildForm {0}", ex.Message));
            }
        }
        #endregion

        #endregion

        #region イベント

        #region BaseTabletForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： BaseTabletForm_Load
        /// <summary>
        /// 初期ロードの処理を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/08　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void BaseTabletForm_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region BaseTabletForm_Shown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： BaseTabletForm_Shown
        /// <summary>
        /// フォームが最初に表示された際の処理を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/13　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void BaseTabletForm_Shown(object sender, EventArgs e)
        {
            // モーダル制御フラグがＯＮの場合
            if (ModalFlg)
            {
                // 親フォームを無効にする
                Owner.Enabled = false;
            }
        }
        #endregion

        #region BaseTabletForm_FormClosing
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： BaseTabletForm_FormClosing
        /// <summary>
        /// フォームが閉じられる際の処理を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/08　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void BaseTabletForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine(string.Format("BaseTabletForm_FormClosing {0}", this.Text));

            try
            {
                // 子画面が存在する場合
                CloseChildForm();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("BaseTabletForm_FormClosing {0}", ex.Message));
            }

        }
        #endregion

        #region BaseTabletForm_FormClosed
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： BaseTabletForm_FormClosed
        /// <summary>
        /// フォームが閉じられた際の処理を行います
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2010/04/13　稗田　　    新規作成
        /// 2014/07/07　豊田　　    タブレット画面向けに修正
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void BaseTabletForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine(string.Format("BaseTabletForm_FormClosed {0}", this.Text));

            // モーダル制御フラグがＯＮの場合
            if (ModalFlg)
            {
                // 親フォームを有効にする
                Owner.Enabled = true;
            }

            // フォーム終了時イベントを呼び出す
            if (FormEndEvent != null)
            {
                if (Owner != null)
                {
                    Owner.BeginInvoke(new InvokeDelegete(FormEndEvent), this);
                }
                else
                {
                    FormEndEvent(this);
                }
            }
        }
        #endregion
        
        #endregion

    }
    #endregion
}
