using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.YoshiHanbaiKanri.TyumonShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.YoshiHanbaiKanri
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： SuishitsuMstShosaiForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class TyumonShosaiForm : Form
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
        /// 注文番号
        /// </summary>
        private string _yoshiHanbaiChumonNo = string.Empty;

        /// <summary>
        /// 用紙販売ヘッダテーブル
        /// </summary>
        private YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable _hdrTable = new YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable();

        /// <summary>
        /// 業者マスタ
        /// </summary>
        private GyoshaMstDataSet.GyoshaMstDataTable _gyoshaMst = new GyoshaMstDataSet.GyoshaMstDataTable();

        /// <summary>
        /// TyumonShosaiDataTable
        /// </summary>
        private YoshiHanbaiHdrTblDataSet.TyumonShosaiDataTable _dgvSource = new YoshiHanbaiHdrTblDataSet.TyumonShosaiDataTable();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： TyumonShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public TyumonShosaiForm()
        {
            InitializeComponent();
        }
        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： TyumonShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public TyumonShosaiForm(string yoshiHanbaiChumonNo)
        {
            this._yoshiHanbaiChumonNo = yoshiHanbaiChumonNo;
            InitializeComponent();
        }
        #endregion

        #region イベント

        #region TyumonShosaiForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： TyumonShosaiForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void TyumonShosaiForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Add mode title
                titleLabel.Text = "注文登録";

                // Detail mode
                if (!string.IsNullOrEmpty(this._yoshiHanbaiChumonNo))
                {
                    this._dispMode = DispMode.Detail;
                    titleLabel.Text = "注文詳細";
                }

                // Load and display default value
                DoFormLoad();

                // Title of screen
                SetScreenTitle();

                // Display/Input control
                ItemControl();

                // Focus to 支所(1)
                shishoNmComboBox.Focus();
                yoshiListDataGridView.Font = new Font("Meiryo", 17.75F, GraphicsUnit.Pixel);
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

        #region TyumonShosaiForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： TyumonShosaiForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void TyumonShosaiForm_KeyDown(object sender, KeyEventArgs e)
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

        #region gyosyaCdTextBox_Leave
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： gyosyaCdTextBox_Leave
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void gyosyaCdTextBox_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Avoid user fire this event without input
                if (string.IsNullOrEmpty(gyosyaCdTextBox.Text))
                {
                    // 業者名称(3)
                    gyosyaNmTextBox.Text = string.Empty;

                    // 担当者(4)
                    tantoTextBox.Text = string.Empty;

                    return;
                }

                // 業者名称
                string gyoshaNm = string.Empty;
                // 送付先担当者氏名
                string tantoNm = string.Empty;
                bool isCdExist = false;

                foreach (GyoshaMstDataSet.GyoshaMstRow row in
                    _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", gyosyaCdTextBox.Text)))
                {
                    gyoshaNm = row.GyoshaNm;
                    tantoNm = row.SofusakiTantoshaNm;

                    // Input code is exist
                    isCdExist = true;
                }

                // Input code does not exist
                if (!isCdExist)
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "業者データが存在しません。");
                    
                    // Clear code input
                    gyosyaCdTextBox.Text = string.Empty;
                }

                // 業者名称(3)
                gyosyaNmTextBox.Text = gyoshaNm;

                // 担当者(4)
                tantoTextBox.Text = tantoNm;
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

        #region gyosyaSrhButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： gyosyaSrhButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void gyosyaSrhButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Open gyoshaMst search form
                Common.GyoshaMstSearchForm frm = new Common.GyoshaMstSearchForm();
                frm.ShowDialog();

                // Avoid user close the form
                if (frm.DialogResult != DialogResult.OK) return;

                // No row was selected
                if (frm._selectedRow == null) return;

                // 業者コード(2)
                gyosyaCdTextBox.Text = (frm._selectedRow.Cells["GyoshaCdCol"].Value != null) ? frm._selectedRow.Cells["GyoshaCdCol"].Value.ToString() : string.Empty;

                // 業者名称(3)
                gyosyaNmTextBox.Text = (frm._selectedRow.Cells["GyoshaNmCol"].Value != null) ? frm._selectedRow.Cells["GyoshaNmCol"].Value.ToString() : string.Empty;

                // 担当者(4)
                tantoTextBox.Text = (frm._selectedRow.Cells["SofusakiTantoshaNmCol"].Value != null) ? frm._selectedRow.Cells["SofusakiTantoshaNmCol"].Value.ToString() : string.Empty;
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
        /// 2014/07/21　AnhNV　　    新規作成
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
        /// 2014/07/21　AnhNV　　    新規作成
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
        /// 2014/07/21　AnhNV　　    新規作成
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
                    delInput.YoshiHanbaiChumonNo = chumonNoTextBox.Text;
                    IDeleteBtnClickALOutput delOutput = new DeleteBtnClickApplicationLogic().Execute(delInput);

                    // SaisuiinCd does not exist
                    if (!string.IsNullOrEmpty(delOutput.ErrMsg))
                    {
                        MessageForm.Show2(MessageForm.DispModeType.Error, delOutput.ErrMsg);
                        return;
                    }

                    // Close this form
                    this.Close();
                    // Open the list form
                    TyumonListForm frm = new TyumonListForm();
                    frm.ShowDialog();
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
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void reInputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this._dispMode = string.IsNullOrEmpty(this._yoshiHanbaiChumonNo) ? DispMode.Add : DispMode.Edit;

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
        /// 2014/07/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void decisionButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                IDecisionBtnClickALInput alInput = new DecisionBtnClickALInput();
                alInput.UpdateData = MakeUpdateData();
                IDecisionBtnClickALOutput alOutput = new DecisionBtnClickApplicationLogic().Execute(alInput);

                // Update error
                if (!string.IsNullOrEmpty(alOutput.ErrMsg))
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, alOutput.ErrMsg);
                    return;
                }

                // Close this form
                this.Close();

                // Open the list form
                TyumonListForm frm = new TyumonListForm();
                frm.ShowDialog();
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
        /// 2014/07/21　AnhNV　　    新規作成
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
                if (string.IsNullOrEmpty(_yoshiHanbaiChumonNo))
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
                // Close this form
                this.Close();

                if (string.IsNullOrEmpty(_yoshiHanbaiChumonNo))
                {
                    TyumonMenu frm = new TyumonMenu();
                    frm.ShowDialog();
                }
                else
                {
                    // Open the list form
                    TyumonListForm frm = new TyumonListForm();
                    frm.ShowDialog();
                }
                //frm.ShowDialog();
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

        #region yoshiListDataGridView_EditingControlShowing
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： yoshiListDataGridView_EditingControlShowing
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/28　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void yoshiListDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (yoshiListDataGridView.CurrentCell.ColumnIndex == 7
                    || yoshiListDataGridView.CurrentCell.ColumnIndex == 8)
                {
                    e.Control.KeyPress += new KeyPressEventHandler(yoshiListDataGridView_ControlKeyPress);
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

        #region yoshiListDataGridView_DataError
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： yoshiListDataGridView_DataError
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void yoshiListDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (e.Exception is FormatException)
                {
                    e.ThrowException = false;
                    yoshiListDataGridView[e.ColumnIndex, e.RowIndex].Value = null;
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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            IFormLoadALInput alInput = new FormLoadALInput();
            alInput.YoshiHanbaiChumonNo = this._yoshiHanbaiChumonNo;
            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            // 業者マスタ
            this._gyoshaMst = alOutput.GyoshaMstDataTable;

            // 支所(1)
            Utility.Utility.SetComboBoxList(shishoNmComboBox, alOutput.ShishoMstDataTable, "ShishoNm", "ShishoCd", true);

            // Display default value in Detail mode
            if (this._dispMode == DispMode.Detail)
            {
                this._hdrTable = alOutput.YoshiHanbaiHdrTblDataTable;

                // Default value
                DisplayDefault();
            }

            // 用紙一覧グリッドビュー(9)
            _dgvSource = alOutput.TyumonShosaiDataTable;
            yoshiListDataGridView.DataSource = _dgvSource;
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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DisplayDefault()
        {
            // 支所(1)
            shishoNmComboBox.SelectedValue = _hdrTable[0].YoshiHanbaiShishoCd;

            // 業者コード(2)
            gyosyaCdTextBox.Text = _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", _hdrTable[0].YoshiHanbaisakiGyoshaCd))[0]["GyoshaCd"].ToString();

            // 業者名称(3)
            gyosyaNmTextBox.Text = _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", _hdrTable[0].YoshiHanbaisakiGyoshaCd))[0]["GyoshaNm"].ToString();

            // 担当者(4)
            tantoTextBox.Text = _hdrTable[0].YoshiHanbaisakiTantosha;

            // 販売日(5)
            hanbaiDtDateTimePicker.Value = DateTime.ParseExact(_hdrTable[0].YoshiHanbaiDt, "yyyyMMdd", CultureInfo.InvariantCulture);

            // 注文番号(7)
            chumonNoTextBox.Text = _hdrTable[0].YoshiHanbaiChumonNo;

            // 合計金額(8)
            totalKingakuTextBox.Text = _hdrTable[0].YoshiHanbaiGokeiKingaku.ToString("N0");
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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetScreenTitle()
        {
            switch (_dispMode)
            {
                case DispMode.Detail:
                    titleLabel.Text = "注文詳細";
                    break;
                case DispMode.Add:
                    titleLabel.Text = "注文登録";
                    break;
                case DispMode.Confirm:
                    titleLabel.Text = "注文入力確認";
                    break;
                case DispMode.Edit:
                    titleLabel.Text = "注文変更";
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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ItemControl()
        {
            // 支所(1)
            shishoNmComboBox.Enabled = (_dispMode == DispMode.Add) ? true : false;
            
            // 業者(2)
            gyosyaCdTextBox.ReadOnly = (_dispMode == DispMode.Add) ? false : true;

            // 担当者(4)
            tantoTextBox.ReadOnly = (_dispMode == DispMode.Add || _dispMode == DispMode.Edit) ? false : true;

            // 販売日(5)
            hanbaiDtDateTimePicker.Enabled = 

            // 業者検索ボタン(6)
            gyosyaSrhButton.Enabled = (_dispMode == DispMode.Add || _dispMode == DispMode.Edit) ? true : false;

            // バラ販売数(17)
            yoshiListDataGridView.Columns["HanbaiCnt"].ReadOnly =

            // セット販売数(18)
            yoshiListDataGridView.Columns["SetHanbaiCnt"].ReadOnly = (_dispMode == DispMode.Add || _dispMode == DispMode.Edit) ? false : true;

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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool DataCheck()
        {
            // Error messages
            StringBuilder errMsg = new StringBuilder();

            // 支所(1)
            if (shishoNmComboBox.SelectedIndex <= 0)
            {
                errMsg.Append("必須項目：支所が選択されていません。\r\n");
            }

            // 業者(2)
            if (string.IsNullOrEmpty(gyosyaCdTextBox.Text.Trim()))
            {
                errMsg.Append("必須項目：業者が入力されていません。\r\n");
            }
            else if (!Utility.Utility.IsDecimal(gyosyaCdTextBox.Text))
            {
                errMsg.Append("業者は半角数字で入力して下さい。\r\n\r\n");
            }
            else if (gyosyaCdTextBox.Text.Length != 4)
            {
                errMsg.Append("業者は4桁で入力して下さい。\r\n");
            }

            // 担当者(4)
            if (string.IsNullOrEmpty(tantoTextBox.Text.Trim()))
            {
                errMsg.Append("必須項目：担当者が入力されていません。\r\n");
            }
            else if (tantoTextBox.Text.Length > 20)
            {
                errMsg.Append("担当者は20文字以下で入力して下さい。\r\n");
            }

            #region 用紙一覧グリッドビュー check

            // Error messages for バラ販売数(17), セット販売数(18)
            int rowCnt = 0; bool isInputHanbaiCnt = false;
            string err17_1 = string.Empty;
            string err17_2 = string.Empty;
            string err17_3 = string.Empty;
            string err18_1 = string.Empty;
            string err18_2 = string.Empty;
            string err18_3 = string.Empty;
            string err18_4 = string.Empty;

            // 用紙一覧グリッドビュー(9)
            foreach (DataGridViewRow dgvr in yoshiListDataGridView.Rows)
            {
                // バラ販売数(17)
                if (dgvr.Cells["HanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["HanbaiCnt"].Value.ToString()))
                {
                    
                }
                else if (!Utility.Utility.IsDecimal(dgvr.Cells["HanbaiCnt"].Value.ToString()))
                {
                    err17_2 += rowCnt + 1 + ", ";
                }
                else
                {
                    isInputHanbaiCnt = true;
                }

                // セット販売数(18)
                if (dgvr.Cells["SetHanbaiCnt"].Value == null
                    || string.IsNullOrEmpty(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    
                }
                else if (!Utility.Utility.IsDecimal(dgvr.Cells["SetHanbaiCnt"].Value.ToString()))
                {
                    err18_2 += rowCnt + 1 + ", ";
                }
                else
                {
                    if (dgvr.Cells["SetBusuCol"].Value == null
                        || string.IsNullOrEmpty(dgvr.Cells["SetBusuCol"].Value.ToString())) // セット部数(16) is blank
                    {
                        err18_4 += rowCnt + 1 + ", ";
                    }

                    isInputHanbaiCnt = true;
                }

                // Next row
                rowCnt++;
            }

            //if (err17_1 != string.Empty)
            //{
            //    errMsg.Append(string.Format("行{0}: 販売数、セット販売数を入力して下さい。\r\n", err17_1.Remove(err17_1.Length - 2)));
            //}

            if (!isInputHanbaiCnt)
            {
                errMsg.Append("販売数、セット販売数を入力して下さい。\r\n");
            }

            if (err17_2 != string.Empty)
            {
                errMsg.Append(string.Format("行{0}: 販売数は半角数字で入力して下さい。\r\n", err17_2.Remove(err17_2.Length - 2)));
            }

            if (err17_3 != string.Empty)
            {
                //errMsg.Append(string.Format("行{0}: 販売数は4桁で入力して下さい。\r\n", err17_3.Remove(err17_3.Length - 2)));
                //errMsg.Append(string.Format("行{0}: 販売数は4文字以下で入力して下さい。\r\n", err17_3.Remove(err17_3.Length - 2)));
            }

            //if (err18_1 != string.Empty)
            //{
            //    errMsg.Append(string.Format("行{0}: セット販売数を入力して下さい。\r\n", err18_1.Remove(err18_1.Length - 2)));
            //}

            if (err18_2 != string.Empty)
            {
                errMsg.Append(string.Format("行{0}: セット販売数は半角数字で入力して下さい。\r\n", err18_2.Remove(err18_2.Length - 2)));
            }

            if (err18_3 != string.Empty)
            {
                //errMsg.Append(string.Format("行{0}: セット販売数は4桁で入力して下さい。\r\n", err18_3.Remove(err18_3.Length - 2)));
                errMsg.Append(string.Format("行{0}: セット販売数は4文字以下で入力して下さい。\r\n", err18_3.Remove(err18_3.Length - 2)));
            }

            if (err18_4 != string.Empty)
            {
                errMsg.Append(string.Format("行{0}: セット販売対象外の用紙にセット販売数が入力されています。\r\n", err18_4.Remove(err18_4.Length - 2)));
            }

            #endregion

            // Throw error messages
            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());
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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditCheck()
        {
            // 支所(1)
            if (shishoNmComboBox.SelectedValue.ToString() != _hdrTable[0].YoshiHanbaiShishoCd) return false;

            // 業者コード(2)
            if (gyosyaCdTextBox.Text !=
                _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", _hdrTable[0].YoshiHanbaisakiGyoshaCd))[0]["GyoshaCd"].ToString()) return false;
            
            // 担当者(4)
            if (tantoTextBox.Text != _hdrTable[0].YoshiHanbaisakiTantosha) return false;

            // 販売日(5)
            if (hanbaiDtDateTimePicker.Value != DateTime.ParseExact(_hdrTable[0].YoshiHanbaiDt, "yyyyMMdd", CultureInfo.InvariantCulture)) return false;

            // 用紙一覧グリッドビュー(9)
            foreach (DataGridViewRow dgvr in yoshiListDataGridView.Rows)
            {
                // 販売数(17)
                if (!dgvr.Cells["HanbaiCnt"].Value.Equals(_dgvSource[dgvr.Index].YoshiHanbaiSuryo)) return false;

                // セット販売数(18)
                if (!dgvr.Cells["SetHanbaiCnt"].Value.Equals(_dgvSource[dgvr.Index].YoshiHanbaiSetSuryo)) return false;
            }

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
        /// 2014/07/21  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool EditControl()
        {
            // Any item is edited
            if (shishoNmComboBox.SelectedIndex > 0
                || !string.IsNullOrEmpty(gyosyaCdTextBox.Text.Trim())
                || !string.IsNullOrEmpty(tantoTextBox.Text.Trim())
                || hanbaiDtDateTimePicker.Value.ToString("yyyyMMdd") != DateTime.Now.ToString("yyyyMMdd"))
            {
                return true;
            }

            // 用紙一覧グリッドビュー
            foreach (DataGridViewRow dgvr in yoshiListDataGridView.Rows)
            {
                if ((dgvr.Cells["HanbaiCnt"].Value != null && dgvr.Cells["HanbaiCnt"].Value.ToString() != string.Empty)
                    || (dgvr.Cells["SetHanbaiCnt"].Value != null && dgvr.Cells["SetHanbaiCnt"].Value.ToString() != string.Empty))
                {
                    return true;
                }
            }

            // No items is edited
            return false;
        }
        #endregion

        #region MakeUpdateData
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeUpdateData
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private UpdateData MakeUpdateData()
        {
            UpdateData update = new UpdateData();

            // 表示モード
            update.DispMode = string.IsNullOrEmpty(this._yoshiHanbaiChumonNo) ? DispMode.Add : DispMode.Edit;
            // Current datetime
            update.Now = Common.Common.GetCurrentTimestamp();
            // 注文番号
            string SaibanRenban = string.Empty;
            SaibanRenban = Common.Common.GetSaibanRenban(update.Now.Year.ToString(), "02");
            //SaibanRenban = update.Now.Year.ToString() + SaibanRenban;
            update.YoshiHanbaiChumonNo = SaibanRenban;
            // 合計金額
            update.YoshiHanbaiGokeiKingaku = !string.IsNullOrEmpty(totalKingakuTextBox.Text) ? Convert.ToDecimal(totalKingakuTextBox.Text) : 0;
            // 用紙販売ヘッダテーブル update
            update.YoshiHanbaiHdrTblDataTable = !string.IsNullOrEmpty(this._yoshiHanbaiChumonNo) ? CreateYoshiHanbaiHdrUpdate(this._hdrTable) 
                : new YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable();
            // 販売先業者コード
            update.YoshiHanbaisakiGyoshaCd = gyosyaCdTextBox.Text;
            // 販売先担当者
            update.YoshiHanbaisakiTantosha = tantoTextBox.Text;
            // 支所コード
            update.YoshiHanbaiShishoCd = shishoNmComboBox.SelectedValue.ToString();
            // 販売日
            update.YoshiHanbaiDt = hanbaiDtDateTimePicker.Value;
            // 会員区分
            update.KaiinKbn = _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", gyosyaCdTextBox.Text))[0]["KaiinKbn"].ToString();
            // 用紙一覧グリッドビュー
            update.YoshiListDgv = yoshiListDataGridView;

            return update;
        }
        #endregion

        #region CreateYoshiHanbaiHdrUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateYoshiHanbaiHdrUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable CreateYoshiHanbaiHdrUpdate(YoshiHanbaiHdrTblDataSet.YoshiHanbaiHdrTblDataTable table)
        {
            // 販売先担当者
            table[0].YoshiHanbaisakiTantosha = tantoTextBox.Text;

            // 販売合計金額
            table[0].YoshiHanbaiGokeiKingaku = Convert.ToDecimal(totalKingakuTextBox.Text);

            // 販売日
            table[0].YoshiHanbaiDt = hanbaiDtDateTimePicker.Value.ToString("yyyyMMdd");

            return table;
        }
        #endregion

        #region IsOKForDecimalTextBox
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsOKForDecimalTextBox
        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        /// <param name="textBox"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/28　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool IsOKForDecimalTextBox(char character, TextBox textBox)
        {
            if (!char.IsControl(character)
                && !char.IsDigit(character))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region yoshiListDataGridView_ControlKeyPress
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： yoshiListDataGridView_ControlKeyPress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/28　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void yoshiListDataGridView_ControlKeyPress(object sender, KeyPressEventArgs e)
        {
            if (yoshiListDataGridView.CurrentCell.ColumnIndex == 7
                || yoshiListDataGridView.CurrentCell.ColumnIndex == 8)
            {
                e.Handled = !IsOKForDecimalTextBox(e.KeyChar, sender as TextBox) ? true : false;
            }
        }
        #endregion

        #endregion
    }
    #endregion
}
