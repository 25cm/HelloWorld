using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Master.ShishoMstShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Master
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： ShishoMstShosaiForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/20　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class ShishoMstShosaiForm : Form
    {
        #region 定義(public)

        /// <summary>
        /// 表示モード
        /// </summary>
        public enum DispMode
        {
            Add,        // 登録モード
            Edit,       // 編集モード
            Detail,     // 詳細
            Confirm,    // 入力確認
        }

        #endregion

        #region プロパティ(public)

        /// <summary>
        /// Display mode
        /// </summary>
        public DispMode _dispMode = DispMode.Add;

        #endregion

        #region プロパティ(private)

        /// <summary>
        /// 支所コード
        /// </summary>
        private string _shishoCd;

        /// <summary>
        /// ShishoMstDataTable
        /// </summary>
        private ShishoMstDataSet.ShishoMstDataTable _dispTable = new ShishoMstDataSet.ShishoMstDataTable();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： ShishoMstShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public ShishoMstShosaiForm()
        {
            InitializeComponent();
        }
        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： ShishoMstShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public ShishoMstShosaiForm(string shishoCd)
        {
            this._shishoCd = shishoCd;
            InitializeComponent();
        }
        #endregion

        #region イベント

        #region ShishoMstShosaiForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ShishoMstShosaiForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ShishoMstShosaiForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Add mode title
                this.Text = "支所マスタ登録";

                // Detail mode
                if (!string.IsNullOrEmpty(this._shishoCd))
                {
                    this._dispMode = DispMode.Detail;
                    this.Text = "支所マスタ詳細";
                }

                // Load and display default value
                DoFormLoad();

                // Title of screen
                SetScreenTitle();

                // Display/Input control
                ItemControl();
            }
            catch (Exception ex)
            {
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), ex.ToString());
                MessageForm.Show(MessageForm.DispModeType.Error, MessageResouce.MSGID_E00001, ex.Message);

                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            finally
            {
                Cursor.Current = preCursor;
                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }
        }
        #endregion

        #region entryButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： entryButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void entryButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 単項目チェック + 入力内容チェック
                if (!DataCheck()) return;

                // Switches to confirm mode
                this._dispMode = DispMode.Confirm;

                // Set screen title
                SetScreenTitle();

                // Set input/read only property
                ItemControl();
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
        #endregion

        #region changeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： changeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void changeButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (this._dispMode == DispMode.Detail)
                {
                    // Switches to confirm mode
                    this._dispMode = DispMode.Edit;
                }
                else if (this._dispMode == DispMode.Edit)
                {
                    // 単項目チェック + 入力内容チェック
                    if (!DataCheck()) return;

                    // Switches to confirm mode
                    this._dispMode = DispMode.Confirm;
                }

                // Set screen title
                SetScreenTitle();

                // Set input/read only property
                ItemControl();
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
        #endregion

        #region deleteButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： deleteButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void deleteButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (MessageForm.Show2(MessageForm.DispModeType.Question, "表示されているデータが削除されます。よろしいですか？") == DialogResult.Yes)
                {
                    IDeleteBtnClickALInput delInput = new DeleteBtnClickALInput();
                    delInput.ShishoCd = sishoCdTextBox.Text;
                    IDeleteBtnClickALOutput delOutput = new DeleteBtnClickApplicationLogic().Execute(delInput);

                    // SaisuiinCd does not exist
                    if (!string.IsNullOrEmpty(delOutput.ErrMsg))
                    {
                        MessageForm.Show2(MessageForm.DispModeType.Error, delOutput.ErrMsg);
                        return;
                    }

                    // Close this screen and back to ShishoMst form
                    ShishoMstListForm frm = new ShishoMstListForm();
                    Program.mForm.ShowForm(frm);
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
        #endregion

        #region reInputButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： reInputButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void reInputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this._dispMode = string.IsNullOrEmpty(this._shishoCd) ? DispMode.Add : DispMode.Edit;

                // Screen title
                SetScreenTitle();

                // Item control display
                ItemControl();
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
        #endregion

        #region decisionButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： decisionButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void decisionButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this._dispMode = string.IsNullOrEmpty(this._shishoCd) ? DispMode.Add : DispMode.Edit;

                IDecisionBtnClickALInput decInput = new DecisionBtnClickALInput();
                decInput.DispMode = this._dispMode;
                decInput.ShishoMstDataTable = (this._dispMode == DispMode.Add) ? CreateShishoMstInsert() : CreateShishoMstUpdate(_dispTable);
                IDecisionBtnClickALOutput decOutput = new DecisionBtnClickApplicationLogic().Execute(decInput);

                // Edit mode
                if (!string.IsNullOrEmpty(decOutput.ErrMsg))
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, decOutput.ErrMsg);
                    return;
                }

                ShishoMstListForm frm = new ShishoMstListForm();
                Program.mForm.ShowForm(frm);
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
        #endregion

        #region closeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： closeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void closeButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Detail mode
                if (this._dispMode == DispMode.Detail)
                {
                    goto SHOWFORM;
                }

                // Add mode
                if (string.IsNullOrEmpty(_shishoCd))
                {
                    if (!EditControl() || MessageForm.Show2(MessageForm.DispModeType.Question, "編集内容が破棄されます。よろしいですか？") == DialogResult.Yes)
                    {
                        goto SHOWFORM;
                    }

                    return;
                }

                // Other modes
                if (!EditCheck())
                {
                    if (MessageForm.Show2(MessageForm.DispModeType.Question, "編集内容が破棄されます。よろしいですか？") == DialogResult.Yes)
                    {
                        goto SHOWFORM;
                    }

                    return;
                }

                SHOWFORM:
                ShishoMstListForm frm = new ShishoMstListForm();
                Program.mForm.ShowForm(frm);
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
        #endregion

        #region ShishoMstShosaiForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ShishoMstShosaiForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ShishoMstShosaiForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyCode)
                {
                    case Keys.F1:
                        entryButton.PerformClick();
                        break;
                    case Keys.F2:
                        changeButton.PerformClick();
                        break;
                    case Keys.F3:
                        deleteButton.PerformClick();
                        break;
                    case Keys.F4:
                        reInputButton.PerformClick();
                        break;
                    case Keys.F5:
                        decisionButton.PerformClick();
                        break;
                    case Keys.F12:
                        closeButton.PerformClick();
                        break;
                    default:
                        break;
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
        #endregion

        #region zipCdTextBox_KeyPress
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： zipCdTextBox_KeyPress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/30　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void zipCdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '-')
                {
                    e.Handled = true;
                }

                // only allow one negative sign
                if (e.KeyChar == '-'
                    && (sender as TextBox).Text.IndexOf('-') > -1)
                {
                    e.Handled = true;
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
        #endregion

        #region telCommonTextBox_KeyPress
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： telCommonTextBox_KeyPress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/30　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void telCommonTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '-')
                {
                    e.Handled = true;
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
        #endregion

        #endregion

        #region メソッド(private)

        #region DoFormLoad
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoFormLoad
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            IFormLoadALInput alInput = new FormLoadALInput();
            alInput.ShishoCd = (this._dispMode == DispMode.Add) ? string.Empty : this._shishoCd;
            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            // Display default value in Detail mode
            if (this._dispMode == DispMode.Detail)
            {
                this._dispTable = alOutput.ShishoMstDataTable;

                // Default value
                DisplayDefault();
            }
        }
        #endregion

        #region DisplayDefault
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DisplayDefault
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DisplayDefault()
        {
            // 支所コード(2)
            sishoCdTextBox.Text = _dispTable[0].ShishoCd;

            // 支所名称(3)
            sishoNmTextBox.Text = _dispTable[0].ShishoNm;

            // 郵便番号(4)
            zipCdTextBox.Text = _dispTable[0].ShishoZipCd;

            // 住所(5)
            sishoAdrTextBox.Text = _dispTable[0].ShishoAdr;

            // 電話番号(6)
            telTextBox.Text = _dispTable[0].ShishoTelNo;

            // ファックス(7)
            faxTextBox.Text = _dispTable[0].ShishoFaxNo;

            // フリーダイヤル(8)
            furidaiaruTextBox.Text = _dispTable[0].ShishoFreeDial;
        }
        #endregion

        #region SetScreenTitle
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetScreenTitle
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetScreenTitle()
        {
            // Hide/unhide required mark(*)
            RequiredMarkControl();

            switch (_dispMode)
            {
                case DispMode.Detail:
                    Program.mForm.Text = "支所マスタ詳細";
                    break;
                case DispMode.Add:
                    Program.mForm.Text = "支所マスタ登録";
                    break;
                case DispMode.Confirm:
                    Program.mForm.Text = "支所マスタ入力確認";
                    break;
                case DispMode.Edit:
                    Program.mForm.Text = "支所マスタ変更";
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region ItemControl
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ItemControl
        /// <summary>
        /// Control the input/display property of all items
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ItemControl()
        {
            // 支所コード(2)
            // UPD 20140724 START ZynasSou
            //sishoCdTextBox.ReadOnly = (_dispMode == DispMode.Add) ? false : true;
            sishoCdTextBox.ReadOnly = true;
            // UPD 20140724 END ZynasSou

            // 支所名称(3)
            sishoNmTextBox.ReadOnly =

            // 郵便番号(4)
            zipCdTextBox.ReadOnly =

            // 住所(5)
            sishoAdrTextBox.ReadOnly =

            // 電話番号(6)
            telTextBox.ReadOnly =

            // ファックス(7)
            faxTextBox.ReadOnly =

            // フリーダイヤル(8)
            furidaiaruTextBox.ReadOnly = (_dispMode == DispMode.Add || _dispMode == DispMode.Edit) ? false : true;

            // 登録ボタン(19)
            entryButton.Visible = (this._dispMode == DispMode.Add) ? true : false;

            // 変更ボタン(20)
            changeButton.Visible = (this._dispMode == DispMode.Detail || this._dispMode == DispMode.Edit) ? true : false;

            // 削除ボタン(21)
            deleteButton.Visible = (this._dispMode == DispMode.Detail) ? true : false;

            // 再入力ボタン(22)
            reInputButton.Visible =

            // 確定ボタン(23)
            decisionButton.Visible = (this._dispMode == DispMode.Confirm) ? true : false;
        }
        #endregion

        #region DataCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DataCheck
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool DataCheck()
        {
            // Error messages
            StringBuilder errMsg = new StringBuilder();

            // UPD 20140724 START ZynasSou
            //// 支所コード(2)
            //if (string.IsNullOrEmpty(sishoCdTextBox.Text))
            //{
            //    errMsg.Append("必須項目：支所コードが入力されていません。\r\n");
            //}
            //else if (!Utility.Utility.IsDecimal(sishoCdTextBox.Text))
            //{
            //    errMsg.Append("支所コードは半角数字で入力して下さい。\r\n");
            //}
            //else if (sishoCdTextBox.Text.Length > 1)
            //{
            //    errMsg.Append("支所コードは1桁で入力して下さい。\r\n");
            //}
            // UPD 20140724 END ZynasSou

            // 支所名称(3)
            if (string.IsNullOrEmpty(sishoNmTextBox.Text))
            {
                errMsg.Append("必須項目：支所名称が入力されていません。\r\n");
            }
            else if (sishoNmTextBox.Text.Length > 10)
            {
                errMsg.Append("支所名称は10文字以下で入力して下さい。\r\n");
            }

            // 郵便番号(4)
            if (string.IsNullOrEmpty(zipCdTextBox.Text))
            {
                errMsg.Append("必須項目：郵便番号が入力されていません。\r\n");
            }
            else if (zipCdTextBox.Text.Length != 8)
            {
                errMsg.Append("郵便番号は8桁で入力して下さい。\r\n");
            }
            else if (!Utility.Utility.IsNumAndNegative(zipCdTextBox.Text))
            {
                errMsg.Append("郵便番号は半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }
            else if (!Utility.Utility.IsZipCode(zipCdTextBox.Text))
            {
                errMsg.Append("郵便番号の形式が不正です。\r\n");
            }

            // 住所(5)
            if (string.IsNullOrEmpty(sishoAdrTextBox.Text))
            {
                errMsg.Append("必須項目：住所が入力されていません。\r\n");
            }
            else if (sishoAdrTextBox.Text.Length > 80)
            {
                errMsg.Append("住所は80文字以下で入力して下さい。\r\n");
            }

            // 電話番号(6)
            if (string.IsNullOrEmpty(telTextBox.Text))
            {
                errMsg.Append("必須項目：電話番号が入力されていません。\r\n");
            }
            else if (telTextBox.Text.Length < 12)
            {
                errMsg.Append("電話番号は12～13桁で入力して下さい。\r\n");
            }
            //else if (telTextBox.Text.Length != 13)
            //{
            //    errMsg.Append("電話番号は13桁で入力して下さい。\r\n");
            //}
            else if (!Utility.Utility.IsNumAndNegative(telTextBox.Text.Trim()))
            {
                errMsg.Append("電話番号は半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }
            //else if (!Utility.Utility.IsPhoneNumber(telTextBox.Text))
            //{
            //    errMsg.Append("電話番号の形式が不正です。\r\n");
            //}

            // ファックス(7)
            if (string.IsNullOrEmpty(faxTextBox.Text))
            {
                errMsg.Append("必須項目：ファックスが入力されていません。\r\n");
            }
            else if (faxTextBox.Text.Length < 12)
            {
                errMsg.Append("ファックスは12～13桁で入力して下さい。\r\n");
            }
            //else if (faxTextBox.Text.Length != 13)
            //{
            //    errMsg.Append("ファックスは13桁で入力して下さい。\r\n");
            //}
            else if (!Utility.Utility.IsNumAndNegative(faxTextBox.Text.Trim()))
            {
                errMsg.Append("ファックスは半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }
            //else if (!Utility.Utility.IsPhoneNumber(faxTextBox.Text))
            //{
            //    errMsg.Append("ファックスの形式が不正です。\r\n");
            //}

            // フリーダイヤル(8)
            if (string.IsNullOrEmpty(furidaiaruTextBox.Text))
            {
                errMsg.Append("必須項目：フリーダイヤルが入力されていません。\r\n");
            }
            else if (furidaiaruTextBox.Text.Length < 12)
            {
                errMsg.Append("フリーダイヤルは12桁で入力して下さい。\r\n");
            }
            else if (!Utility.Utility.IsNumAndNegative(furidaiaruTextBox.Text.Trim()))
            {
                errMsg.Append("フリーダイヤルは半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }
            //else if (!IsFuridairu(furidaiaruTextBox.Text))
            //{
            //    errMsg.Append("フリーダイヤルの形式が不正です。\r\n");
            //}

            // Throw error messages
            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #region InputCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： InputCheck
        /// <summary>
        /// Validate the data type
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool InputCheck()
        {
            // UPD 20140724 START ZynasSou
            //// 支所コード(2)
            //if (!Utility.Utility.IsDecimal(sishoCdTextBox.Text))
            //{
            //    MessageForm.Show2(MessageForm.DispModeType.Error, "支所コードは半角数字で入力して下さい。");
            //    return false;
            //}
            // UPD 20140724 END ZynasSou

            // UPD 20140724 START ZynasSou
            //// 支所コード(2)
            //if (sishoCdTextBox.Text.Length > 1)
            //{
            //    MessageForm.Show2(MessageForm.DispModeType.Error, "支所コードは1桁で入力して下さい。");
            //    return false;
            //}
            // UPD 20140724 END ZynasSou

            // 支所名称(3)
            if (sishoNmTextBox.Text.Length > 10)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "支所名称は10文字以下で入力して下さい。");
                return false;
            }

            // 郵便番号(4)
            if (!Utility.Utility.IsZipCode(zipCdTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "郵便番号は半角数字と-(半角ハイフン)で入力して下さい。");
                return false;
            }

            // 住所(5)
            if (sishoAdrTextBox.Text.Length > 80)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "住所は80文字以下で入力して下さい。");
                return false;
            }

            // 電話番号(6)
            if (!Utility.Utility.IsPhoneNumber(telTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "電話番号は半角数字と-(半角ハイフン)で入力して下さい。");
                return false;
            }

            // ファックス(7)
            if (!Utility.Utility.IsPhoneNumber(faxTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "ファックスは半角数字と-(半角ハイフン)で入力して下さい。");
                return false;
            }

            // フリーダイヤル(8)
            if (!Utility.Utility.IsPhoneNumber(furidaiaruTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "フリーダイヤルは半角数字と-(半角ハイフン)で入力して下さい。");
                return false;
            }

            return true;
        }
        #endregion

        #region EditCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： EditCheck
        /// <summary>
        /// Trigger when any item is modified
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditCheck()
        {
            // 支所コード(2)
            if (sishoCdTextBox.Text != _dispTable[0].ShishoCd) return false;

            // 支所名称(3)
            if (sishoNmTextBox.Text != _dispTable[0].ShishoNm) return false;

            // 郵便番号(4)
            if (zipCdTextBox.Text != _dispTable[0].ShishoZipCd) return false;

            // 住所(5)
            if (sishoAdrTextBox.Text != _dispTable[0].ShishoAdr) return false;

            // 電話番号(6)
            if (telTextBox.Text != _dispTable[0].ShishoTelNo) return false;

            // ファックス(7)
            if (faxTextBox.Text != _dispTable[0].ShishoFaxNo) return false;

            // フリーダイヤル(8)
            if (furidaiaruTextBox.Text != _dispTable[0].ShishoFreeDial) return false;

            return true;
        }
        #endregion

        #region EditControl
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： EditControl
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// TRUE: Control is edited
        /// FALSE: Control is not edited
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditControl()
        {
            // Any item is edited
            if (!string.IsNullOrEmpty(sishoCdTextBox.Text)
                || !string.IsNullOrEmpty(sishoNmTextBox.Text)
                || !string.IsNullOrEmpty(zipCdTextBox.Text)
                || !string.IsNullOrEmpty(sishoAdrTextBox.Text)
                || !string.IsNullOrEmpty(telTextBox.Text)
                || !string.IsNullOrEmpty(faxTextBox.Text)
                || !string.IsNullOrEmpty(furidaiaruTextBox.Text))
            {
                return true;
            }

            // No items is edited
            return false;
        }
        #endregion

        #region RequiredMarkControl
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： RequiredMarkControl
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void RequiredMarkControl()
        {
            //bool visibleFlg = true;

            //if (this._dispMode == DispMode.Detail || this._dispMode == DispMode.Confirm)
            //{
            //    visibleFlg = false;
            //}

            //foreach (System.Windows.Forms.Control c in this.Controls)
            //{
            //    if (c.GetType() != typeof(Label)) continue;
            //    if (c.Name == "keyCode")
            //    {
            //        if (this._dispMode == DispMode.Add)
            //        {
            //            c.Visible = true;
            //        }
            //        else
            //        {
            //            c.Visible = false;
            //        }
            //    }
            //    else if (c.Text == "*")
            //    {
            //        c.Visible = visibleFlg;
            //    }
            //}
        }
        #endregion

        #region IsFuridairu
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsFuridairu
        /// <summary>
        /// Is phone number format or not?
        /// </summary>
        /// <param name="input"></param>
        /// <returns>
        /// TRUE: phone number format
        /// FALSE: Not a phone number format
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/30  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool IsFuridairu(string input)
        {
            string phoneRegex = @"^0\d{1,4}-\d{1,3}-\d{3}$";

            if (!Regex.Match(input, phoneRegex).Success)
            {
                return false;
            }

            return true;
        }
        #endregion

        #region CreateShishoMstInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateShishoMstInsert
        /// <summary>
        /// 
        /// </summary>
        /// <returns>ShishoMstDataSet.ShishoMstDataTable</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private ShishoMstDataSet.ShishoMstDataTable CreateShishoMstInsert()
        {
            // Instances a new table
            ShishoMstDataSet.ShishoMstDataTable table = new ShishoMstDataSet.ShishoMstDataTable();
            ShishoMstDataSet.ShishoMstRow newRow = table.NewShishoMstRow();

            // 支所コード(2)
            string key = Common.Common.GetKeyRenban("ShishoMst", "", "", "");
            newRow.ShishoCd = key.Length >= 2 ? " " : key;

            // 支所名称(3)
            newRow.ShishoNm = sishoNmTextBox.Text;

            // 郵便番号(4)
            newRow.ShishoZipCd = zipCdTextBox.Text;

            // 住所(5)
            newRow.ShishoAdr = sishoAdrTextBox.Text;

            // 電話番号(6)
            newRow.ShishoTelNo = telTextBox.Text;

            // ファックス(7)
            newRow.ShishoFaxNo = faxTextBox.Text;

            // フリーダイヤル(8)
            newRow.ShishoFreeDial = furidaiaruTextBox.Text;

            // 登録日
            newRow.InsertDt =

            // 更新日
            newRow.UpdateDt = Common.Common.GetCurrentTimestamp();

            // 登録者
            newRow.InsertUser =

            // 更新者
            newRow.UpdateUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

            // 登録端末
            newRow.InsertTarm =

            // 更新端末
            newRow.UpdateTarm = Dns.GetHostName();

            // 行を挿入
            table.AddShishoMstRow(newRow);

            // 行の状態を設定
            newRow.AcceptChanges();

            // 行の状態を設定（新規）
            newRow.SetAdded();

            return table;
        }
        #endregion

        #region CreateShishoMstUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateShishoMstUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <returns>ShishoMstDataSet.ShishoMstDataTable</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private ShishoMstDataSet.ShishoMstDataTable CreateShishoMstUpdate(ShishoMstDataSet.ShishoMstDataTable table)
        {
            // 支所コード(2)
            table[0].ShishoCd = sishoCdTextBox.Text;

            // 支所名称(3)
            table[0].ShishoNm = sishoNmTextBox.Text;

            // 郵便番号(4)
            table[0].ShishoZipCd = zipCdTextBox.Text;

            // 住所(5)
            table[0].ShishoAdr = sishoAdrTextBox.Text;

            // 電話番号(6)
            table[0].ShishoTelNo = telTextBox.Text;

            // ファックス(7)
            table[0].ShishoFaxNo = faxTextBox.Text;

            // フリーダイヤル(8)
            table[0].ShishoFreeDial = furidaiaruTextBox.Text;

            return table;
        }
        #endregion

        #endregion
    }
    #endregion
}
