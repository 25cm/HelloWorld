using System;
using System.Data;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.Master;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Common
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： WorkListForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/06/20　habu　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class WorkListForm : Form
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

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： WorkListForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public WorkListForm()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント

        #region WorkListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： WorkListForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void WorkListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.Text = "作業一覧";

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (e.RowIndex < 0)
                {
                    return;
                }

                if (e.ColumnIndex != ColDtl.Index)
                {
                    return;
                }

                DataGridViewRow gridRow = workListDataGridView.Rows[e.RowIndex];

                // TODO 具体的な画面名を表記する
                MessageBox.Show("下記画面に遷移します。\n" 
                    + "作業名:" + ((string)gridRow.Cells[ColDesc.Index].Value).ToString() + "\n"
                    + "画面ID:" + ((string)gridRow.Cells[ColFormId.Index].Value).ToString() + "\n"
                    + "機能ID:" + ((string)gridRow.Cells[ColFuncId.Index].Value).ToString() + "\n"
                    );

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

        #region tojiruButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： tojiruButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void tojiruButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                //TODO 作業一覧はサブメニュー内で1つのみなので、閉じる必要はないか？
                // Back to master menu
                // MstMenuForm frm = new MstMenuForm();
                // Program.mForm.ShowForm(frm);
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

        #region WorkListForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： WorkListForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26　habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void WorkListForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyCode)
                {
                        // TODO write Func Key Event
                       /*
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
                        * */
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            // TODO Mock Up Code begin
            DataTable workListData = new DataTable();
            workListData.Columns.Add("WORK_NAME");
            workListData.Columns.Add("WORK_CNT");
            workListData.Columns.Add("WORK_FORM_ID");
            workListData.Columns.Add("WORK_FORM_FUNC_ID");

            // TODO 作業一覧を切り替える場合はここを調整
            int WORK_KBN = 1;

            if (WORK_KBN == 1)
            {
                DataRow newRow = null;
                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "昨日までの検査結果未入力";
                newRow["WORK_CNT"] = 23;
                newRow["WORK_FORM_ID"] = 1;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "担当者未割当検査依頼";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 2;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
            }
            else if (WORK_KBN == 2)
            {
                DataRow newRow = null;
                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "担当センター内検査結果未入力";
                newRow["WORK_CNT"] = 23;
                newRow["WORK_FORM_ID"] = 3;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "検印対象";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 4;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "担当者未割当検査依頼";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 5;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
            }
            else if (WORK_KBN == 3)
            {
                DataRow newRow = null;
                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "本日の法定検査受付予定";
                newRow["WORK_CNT"] = 23;
                newRow["WORK_FORM_ID"] = 6;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "昨日までの検査結果未入力";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 7;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
            }
            else if (WORK_KBN == 4)
            {
                DataRow newRow = null;
                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "未請求";
                newRow["WORK_CNT"] = 23;
                newRow["WORK_FORM_ID"] = 8;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "未入金";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 9;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
            }
            else if (WORK_KBN == 5)
            {
                DataRow newRow = null;
                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "結果書発送(前日検印完了分)";
                newRow["WORK_CNT"] = 23;
                newRow["WORK_FORM_ID"] = 10;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);

                newRow = workListData.NewRow();
                newRow["WORK_NAME"] = "昨日までの検査結果未入力";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 11;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
                newRow = workListData.NewRow();

                newRow["WORK_NAME"] = "担当者未割当検査依頼";
                newRow["WORK_CNT"] = 32;
                newRow["WORK_FORM_ID"] = 12;
                newRow["WORK_FORM_FUNC_ID"] = 1;
                workListData.Rows.Add(newRow);
            }

            //workListDataGridView.RowCount = workListData.Rows.Count;
            int addRow = workListData.Rows.Count - workListDataGridView.RowCount;
            for (int i = 0; i < addRow; i++)
            {
                workListDataGridView.Rows.Add();
            }

            for (int i = 0; i < workListData.Rows.Count; i++)
            {
                DataRow tableRow = workListData.Rows[i];
                DataGridViewRow row = workListDataGridView.Rows[i];
                row.Cells[ColDesc.Index].Value = tableRow["WORK_NAME"];
                row.Cells[ColNum.Index].Value = tableRow["WORK_CNT"];
                row.Cells[ColDtl.Index].Value = "詳細";
                // TODO shoud contain target form className (or get className by FormId)
                row.Cells[ColFormId.Index].Value = tableRow["WORK_FORM_ID"];
                row.Cells[ColFuncId.Index].Value = tableRow["WORK_FORM_FUNC_ID"];
            }

            // TODO MOCK end

            // TODO get Initial Data for form(work list data)
            // TODO param : shokuinCd , 

            // TODO set gridRows for each work list data
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DisplayDefault()
        {
            // TODO remove if not nesessary
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetScreenTitle()
        {
            Program.mForm.Text = "作業一覧";

            // TODO remove below if not nesessary

            /*
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
            */
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ItemControl()
        {
            // TODO remove if not nesessary
            /*
            // 支所コード(2)
            sishoCdTextBox.ReadOnly = (_dispMode == DispMode.Add) ? false : true;

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

            // フリーダイアル(8)
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
             * */
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool DataCheck()
        {
            // TODO remove if not nesessary
            /*
            // Error messages
            StringBuilder errMsg = new StringBuilder();

            // 支所コード(2)
            if (string.IsNullOrEmpty(sishoCdTextBox.Text))
            {
                errMsg.Append("必須項目：支所コードが入力されていません。\r\n");
            }
            else if (!Utility.Utility.IsDecimal(sishoCdTextBox.Text))
            {
                errMsg.Append("支所コードは半角数字で入力して下さい。\r\n");
            }
            else if (sishoCdTextBox.Text.Length > 1)
            {
                errMsg.Append("支所コードは1桁で入力して下さい。\r\n");
            }

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
            else if (!Utility.Utility.IsZipCode(zipCdTextBox.Text))
            {
                errMsg.Append("郵便番号は半角数字と-(半角ハイフン)で入力して下さい。\r\n");
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
            else if (!Utility.Utility.IsPhoneNumber(telTextBox.Text))
            {
                errMsg.Append("電話番号は半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }

            // ファックス(7)
            if (string.IsNullOrEmpty(faxTextBox.Text))
            {
                errMsg.Append("必須項目：ファックスが入力されていません。\r\n");
            }
            else if (!Utility.Utility.IsPhoneNumber(faxTextBox.Text))
            {
                errMsg.Append("ファックスは半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }

            // フリーダイアル(8)
            if (string.IsNullOrEmpty(furidaiaruTextBox.Text))
            {
                errMsg.Append("必須項目：フリーダイアルが入力されていません。\r\n");
            }
            else if (!Utility.Utility.IsPhoneNumber(furidaiaruTextBox.Text))
            {
                errMsg.Append("フリーダイアルは半角数字と-(半角ハイフン)で入力して下さい。\r\n");
            }

            // Throw error messages
            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());
                return false;
            }
             * */

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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool InputCheck()
        {
            // TODO remove if not nesessary
            /*
            // 支所コード(2)
            if (!Utility.Utility.IsDecimal(sishoCdTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "支所コードは半角数字で入力して下さい。");
                return false;
            }

            // 支所コード(2)
            if (sishoCdTextBox.Text.Length > 1)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "支所コードは1桁で入力して下さい。");
                return false;
            }

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

            // フリーダイアル(8)
            if (!Utility.Utility.IsPhoneNumber(furidaiaruTextBox.Text))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "フリーダイアルは半角数字と-(半角ハイフン)で入力して下さい。");
                return false;
            }
             * */

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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditCheck()
        {
            /*
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

            // フリーダイアル(8)
            if (furidaiaruTextBox.Text != _dispTable[0].ShishoFreeDial) return false;

             * */
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditControl()
        {
            // TODO remove if not nesessary
            /*
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

             * */
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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void RequiredMarkControl()
        {
            // TODO remove if not nesessary
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

        #region CreateShishoMstInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateShishoMstInsert
        /// <summary>
        /// 
        /// </summary>
        /// <returns>ShishoMstDataSet.ShishoMstDataTable</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private ShishoMstDataSet.ShishoMstDataTable CreateShishoMstInsert()
        {
            // TODO remove if not nesessary
            // Instances a new table
            ShishoMstDataSet.ShishoMstDataTable table = new ShishoMstDataSet.ShishoMstDataTable();
            ShishoMstDataSet.ShishoMstRow newRow = table.NewShishoMstRow();
            /*

            // 支所コード(2)
            newRow.ShishoCd = sishoCdTextBox.Text;

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

            // フリーダイアル(8)
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
            */

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
        /// 2014/06/26  habu　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private ShishoMstDataSet.ShishoMstDataTable CreateShishoMstUpdate(ShishoMstDataSet.ShishoMstDataTable table)
        {
            // TODO remove if not nesessary
            /*
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

            // フリーダイアル(8)
            table[0].ShishoFreeDial = furidaiaruTextBox.Text;
            */
            return table;
        }
        #endregion

        #endregion
    }
    #endregion
}
