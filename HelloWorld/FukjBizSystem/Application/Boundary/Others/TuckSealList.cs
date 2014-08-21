using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Others.TuckSealList;
using FukjBizSystem.Application.Boundary.Common;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Others
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： TuckSealListForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/07　AnhNV　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class TuckSealListForm : Form
    {
        #region プロパティ(private)

        /// <summary>
        /// 検索条件の表示・非表示フラグ(初期値：表示）
        /// </summary>
        private bool _searchShowFlg = true;
        private int _defaultSearchPanelTop = 0;
        private int _defaultSearchPanelHeight = 0;
        private int _defaultListPanelTop = 0;
        private int _defaultListPanelHeight = 0;

        // Data property names
        private const string KBNCOL = "KbnCol";
        private const string CDCOL = "CdCol";
        private const string HOKENJONMCOL = "HokenjoNmCol";
        private const string NMCOL = "NmCol";
        private const string NENGETSUCOL = "NengetsuCol";
        private const string RENBANCOL = "RenbanCol";
        private const string ZIPNOCOL = "ZipNoCol";
        private const string ADRCOL = "AdrCol";

        /// <summary>
        /// Is datasource change?
        /// </summary>
        private bool _isDgvEit;

        /// <summary>
        /// Dgv is ready change?
        /// </summary>
        private bool _isDgvLoadOK = false;

        /// <summary>
        /// Radio button before checked changed
        /// </summary>
        RadioButton _lastRdChecked;

        /// <summary>
        /// 業者マスタ
        /// </summary>
        private GyoshaMstDataSet.GyoshaMstDataTable _gyoshaMst;

        /// <summary>
        /// 保健所マスタ
        /// </summary>
        private HokenjoMstDataSet.HokenjoMstDataTable _hokenjoMst;

        /// <summary>
        /// 浄化槽台帳マスタ
        /// </summary>
        private JokasoDaichoMstDataSet.JokasoDaichoMstDataTable _jokasoDaichoMst;

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： TuckSealListForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public TuckSealListForm()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント

        #region TuckSealListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： TuckSealListForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void TuckSealListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Load default value
                DoFormLoad();

                // 発行区分/業者 is checked
                GyoshaRdCheckedChanged();

                // Load completed
                _isDgvLoadOK = true;
                _lastRdChecked = gyosyaRadioButton;
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

        #region TuckSealListForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： TuckSealListForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void TuckSealListForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyData)
                {
                    case Keys.F1:
                        printButton.PerformClick();
                        break;
                    case Keys.F2:
                        printSofujoButton.PerformClick();
                        break;
                    case Keys.F6:
                        outputButton.PerformClick();
                        break;
                    case Keys.F7:
                    case Keys.Alt | Keys.C:
                        clearButton.PerformClick();
                        break;
                    case Keys.F8:
                    case Keys.Alt | Keys.F:
                        kensakuButton.PerformClick();
                        busuTextBox.Focus();
                        listDataGridView.Focus();
                        break;
                    case Keys.F12:
                    case Keys.Alt | Keys.X:
                        tojiruButton.PerformClick();
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

        #region clearButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： clearButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void clearButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // 発行区分/業者(3)
                gyosyaRadioButton.Checked = true;

                // Clear all input
                ClearSearchCond();
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

        #region kensakuButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kensakuButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensakuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Input check + relation check
                if (!DataCheck(cdFromTextBox.MaxLength,
                    gyosyaRadioButton.Checked ? "業者コード" : (hokenjoRadioButton.Checked ? "保健所コード" : "浄化槽台帳連番")))
                {
                    return;
                }

                // Dgv is loading
                _isDgvLoadOK = false;

                // Do search
                DoSearch();

                // Dgv load completed
                _isDgvLoadOK = true;
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

        #region printButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： printButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void printButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Dgv row count = 0
                if (listDataGridView.Rows.Count == 0) return;

                // No row selected
                if (!PrintCheck())
                {
                    //MessageForm.Show2(MessageForm.DispModeType.Error, "印刷する内容がありません。");
                    return;
                }

                // Confirmation message
                if (MessageForm.Show2(MessageForm.DispModeType.Question, "タックシールを印刷します。よろしいですか？") == DialogResult.Yes)
                {
                    IPrintBtnClickALInput alInput = new PrintBtnClickALInput();
                    alInput.CopyNumber = !string.IsNullOrEmpty(busuTextBox.Text.Trim()) ? Convert.ToInt32(busuTextBox.Text) : 1;
                    alInput.PrintPosition = Convert.ToInt32(printPositionComboBox.SelectedIndex.ToString()) + 1;
                    alInput.TuckSealListDataTable = GetDataTableFromDgv();
                    new PrintBtnClickApplicationLogic().Execute(alInput);
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

        #region printSofujoButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： printSofujoButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/15　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void printSofujoButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Dgv row count = 0
                if (listDataGridView.Rows.Count == 0) return;

                // No row selected
                if (!PrintCheck())
                {
                    return;
                }

                // Printer is not installed or not connected
                string defaultPrinter = Common.Common.GetDefaultPrinter();
                if (string.IsNullOrEmpty(defaultPrinter) || !Common.Common.PrinterIsReady(defaultPrinter))
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "印刷先のプリンターが設定されていません。");
                    return;
                }

                // Confirmation message
                if (MessageForm.Show2(MessageForm.DispModeType.Question, "送付状を印刷します。よろしいですか？") == DialogResult.Yes)
                {
                    IPrintSofujoBtnClickALInput alInput = new PrintSofujoBtnClickALInput();
                    alInput.CopyNumber = !string.IsNullOrEmpty(busuTextBox.Text.Trim()) ? Convert.ToInt32(busuTextBox.Text) : 1;
                    alInput.TuckSealListDataTable = GetDataTableFromDgv();
                    new PrintSofujoBtnClickApplicationLogic().Execute(alInput);
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

        #region outputButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： outputButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void outputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Dgv row count = 0
                if (listDataGridView.Rows.Count == 0) return;

                // Make a copy of listDataGridView
                DataGridView printDgv = Common.Common.CopyDataGridView(listDataGridView);

                // Get hidden, button and combobox columns
                List<string> hiddenColNm = new List<string>();
                foreach (DataGridViewColumn dgvc in printDgv.Columns)
                {
                    if (dgvc.Visible == false
                        || dgvc.GetType() == typeof(DataGridViewButtonColumn))
                    {
                        hiddenColNm.Add(dgvc.Name);
                    }
                }

                // Remove hidden, button and combobox columns
                foreach (var col in hiddenColNm)
                {
                    printDgv.Columns.Remove(col);
                }

                // File name
                string fileName = "タックシール・送付状印刷";
                Common.Common.FlushGridviewDataToExcel(printDgv, fileName);
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

        #region viewChangeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： viewChangeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void viewChangeButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this._searchShowFlg = !this._searchShowFlg;
                if (this._searchShowFlg)//検索条件を開く
                {
                    this.viewChangeButton.Text = "▲";
                }
                else////検索条件を閉じる
                {
                    this.viewChangeButton.Text = "▼";
                }
                Common.Common.SwitchSearchPanel(
                    this._searchShowFlg,
                    this.searchPanel,
                    this._defaultSearchPanelTop,
                    this._defaultSearchPanelHeight,
                    this.srhListPanel,
                    this._defaultListPanelTop,
                    this._defaultListPanelHeight);
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

        #region gyosyaRadioButton_CheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： gyosyaRadioButton_CheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void gyosyaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Avoid CheckedChanged event fires twice
                RadioButton rd = sender as RadioButton;
                if (!rd.Checked || _lastRdChecked == rd) return;

                if (_isDgvEit)
                {
                    // 一覧クリアチェック
                    if (MessageForm.Show2(MessageForm.DispModeType.Question, "一覧内容がクリアされます。よろしいですか？") == DialogResult.Yes)
                    {
                        // Reset the dgv
                        ResetDgv();

                        // Checked changed
                        GyoshaRdCheckedChanged();

                        // Control the data property names
                        SetDataProperties();

                        // Reset search cond
                        ClearSearchCond();

                        _isDgvEit = false;
                        _lastRdChecked = gyosyaRadioButton;
                    }
                    else if (_lastRdChecked != null)
                    {
                        _lastRdChecked.Checked = true;
                    }
                }
                else
                {
                    // Reset the dgv
                    ResetDgv();

                    // Checked changed
                    GyoshaRdCheckedChanged();

                    // Control the data property names
                    SetDataProperties();

                    // Reset search cond
                    ClearSearchCond();

                    _isDgvEit = false;
                    _lastRdChecked = gyosyaRadioButton;
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

        #region hokenjoRadioButton_CheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： hokenjoRadioButton_CheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void hokenjoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Avoid CheckedChanged event fires twice
                RadioButton rd = sender as RadioButton;
                if (!rd.Checked || _lastRdChecked == rd) return;

                if (_isDgvEit)
                {
                    // 一覧クリアチェック
                    if (MessageForm.Show2(MessageForm.DispModeType.Question, "一覧内容がクリアされます。よろしいですか？") == DialogResult.Yes)
                    {
                        // Reset the dgv
                        ResetDgv();

                        // Checked changed
                        HokenjoRdCheckedChanged();

                        // Control the data property names
                        SetDataProperties();

                        // Reset search cond
                        ClearSearchCond();

                        _isDgvEit = false;
                        _lastRdChecked = hokenjoRadioButton;
                    }
                    else
                    {
                        _lastRdChecked.Checked = true;
                    }
                }
                else
                {
                    // Reset the dgv
                    ResetDgv();

                    // Checked changed
                    HokenjoRdCheckedChanged();

                    // Control the data property names
                    SetDataProperties();

                    // Reset search cond
                    ClearSearchCond();

                    _isDgvEit = false;
                    _lastRdChecked = hokenjoRadioButton;
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

        #region settisyaRadioButton_CheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： settisyaRadioButton_CheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void settisyaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Avoid CheckedChanged event fires twice
                RadioButton rd = sender as RadioButton;
                if (!rd.Checked || _lastRdChecked == rd) return;

                if (_isDgvEit)
                {
                    // 一覧クリアチェック
                    if (MessageForm.Show2(MessageForm.DispModeType.Question, "一覧内容がクリアされます。よろしいですか？") == DialogResult.Yes)
                    {
                        // Reset the dgv
                        ResetDgv();

                        // Checked changed
                        SettisyaRdCheckedChanged();

                        // Control the data property names
                        SetDataProperties();

                        // Reset search cond
                        ClearSearchCond();

                        _lastRdChecked = settisyaRadioButton;
                        _isDgvEit = false;
                    }
                    else
                    {
                        _lastRdChecked.Checked = true;
                    }
                }
                else
                {
                    // Reset the dgv
                    ResetDgv();

                    // Checked changed
                    SettisyaRdCheckedChanged();

                    // Control the data property names
                    SetDataProperties();

                    // Reset search cond
                    ClearSearchCond();

                    _isDgvEit = false;
                    _lastRdChecked = settisyaRadioButton;
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
        /// 2014/08/07　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void tojiruButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                OthersMenuForm frm = new OthersMenuForm();
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

        #region listDataGridView_CellLeave
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： listDataGridView_CellLeave
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void listDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Gyosha search
                if (e.ColumnIndex == 3)
                {
                    listDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Current 業者コード
                    string gyoshaCd = listDataGridView.CurrentRow.Cells["GyosyaCdCol"].Value != null
                        ? listDataGridView.CurrentRow.Cells["GyosyaCdCol"].Value.ToString() : string.Empty;

                    // 業者コード(17) not equal 4 digits
                    if (!string.IsNullOrEmpty(gyoshaCd) && gyoshaCd.Length != 4)
                    {
                        MessageForm.Show2(MessageForm.DispModeType.Error, "業者コードは4桁で入力して下さい。");
                        // 業者コード(17)
                        listDataGridView.CurrentRow.Cells["GyosyaCdCol"].Value = string.Empty;
                        // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                        SetNmZipCdAdr(string.Empty, string.Empty, string.Empty);

                        return;
                    }

                    // Search in GyoshaMst
                    GyoshaSearch(gyoshaCd);
                }
                else if (e.ColumnIndex == 4 || e.ColumnIndex == 5) // JokasoDaichoMst search
                {
                    listDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // 保健所名(18)
                    string hokenjoCd = listDataGridView.CurrentRow.Cells["HokenjoNmCol"].Value != null
                        ? listDataGridView.CurrentRow.Cells["HokenjoNmCol"].Value.ToString() : string.Empty;
                    // 年月(19)
                    string nengetsu = listDataGridView.CurrentRow.Cells["NengetsuCol"].Value != null
                        ? listDataGridView.CurrentRow.Cells["NengetsuCol"].Value.ToString() : string.Empty;
                    // 連番(20)
                    string renban = listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value != null
                        ? listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value.ToString() : string.Empty;

                    // Search in JokasoDaichoMst
                    JokasoDaichoSearch(hokenjoCd, nengetsu, renban);
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

        #region listDataGridView_EditingControlShowing
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： listDataGridView_EditingControlShowing
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void listDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Prevent from input non-integer value to datagridview cells
                switch (listDataGridView.Columns[listDataGridView.CurrentCell.ColumnIndex].Name)
                {
                    case "GyosyaCdCol":
                    case "NengetsuCol":
                    case "RenbanNoCol":
                    case "ZipNoCol":
                        e.Control.KeyPress += new KeyPressEventHandler(listDataGridView_ControlKeyPress);
                        break;
                    default:
                        break;
                }

                // Click to 保健所 combobox
                if ((hokenjoRadioButton.Checked || settisyaRadioButton.Checked)
                    && listDataGridView.CurrentCell.ColumnIndex == 1)
                {
                    listDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    ComboBox cbo = e.Control as ComboBox;
                    if (cbo != null)
                    {
                        cbo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                        cbo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
                    }
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

        #region listDataGridView_CellClick
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： listDataGridView_CellClick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void listDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Avoid user click to header
                if (e.RowIndex == -1) return;

                // Gyosha search
                if (gyosyaRadioButton.Checked && listDataGridView.CurrentCell.ColumnIndex == 2)
                {
                    // Open gyoshaMst search form
                    GyoshaMstSearchForm gFrm = new GyoshaMstSearchForm();
                    gFrm.ShowDialog();

                    // User close the form without selection
                    if (gFrm.DialogResult != DialogResult.OK) return;

                    // No row was selected
                    if (gFrm._selectedRow == null) return;

                    // 業者コード(17)
                    listDataGridView.CurrentRow.Cells["GyosyaCdCol"].Value = gFrm._selectedRow.Cells["GyoshaCdCol"].Value.ToString();
                    // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                    SetNmZipCdAdr(
                        gFrm._selectedRow.Cells["GyoshaNmCol"].Value.ToString(),
                        gFrm._selectedRow.Cells["GyoshaZipCdCol"].Value.ToString(),
                        gFrm._selectedRow.Cells["GyoshaAdrCol"].Value.ToString());
                }
                else if (settisyaRadioButton.Checked && listDataGridView.CurrentCell.ColumnIndex == 2) // Setchisa search
                {
                    // Open JokasoMstSearchForm
                    JokasoDaichoSearchForm jFrm = new JokasoDaichoSearchForm();
                    jFrm.ShowDialog();

                    // User close the form without selection
                    if (jFrm.DialogResult != DialogResult.OK) return;

                    // No row was selected
                    if (jFrm._selectedRow == null) return;

                    // 保健所名(18)
                    listDataGridView.CurrentRow.Cells["HokenjoNmCol"].Value = jFrm._selectedRow.Cells["HokenjoCdCol"].Value.ToString();
                    // 年月(19)
                    listDataGridView.CurrentRow.Cells["NengetsuCol"].Value = jFrm._selectedRow.Cells["TorokuNendoCol"].Value.ToString();
                    // 連番(20)
                    listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value = jFrm._selectedRow.Cells["RenbanCol"].Value.ToString();
                    // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                    SetNmZipCdAdr(
                        jFrm._selectedRow.Cells["SetchishaNmCol"].Value.ToString(),
                        jFrm._selectedRow.Cells["SetchishaZipCdCol"].Value.ToString(),
                        jFrm._selectedRow.Cells["SetchishaAdrCol"].Value.ToString());
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

        #region listDataGridView_CellValueChanged
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： listDataGridView_CellValueChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void listDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                // Datagridview was finished loading and edited?
                if (_isDgvLoadOK)
                {
                    _isDgvEit = true;
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
        /// 2014/08/07  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            this._searchShowFlg = true;
            this._defaultSearchPanelTop = this.searchPanel.Top;
            this._defaultSearchPanelHeight = this.searchPanel.Height;
            this._defaultListPanelTop = this.srhListPanel.Top;
            this._defaultListPanelHeight = this.srhListPanel.Height;

            TuckSealSearchCond searchCond = new TuckSealSearchCond();
            searchCond.RdSelect = "1";

            IFormLoadALInput alInput = new FormLoadALInput();
            alInput.SearchCond = searchCond;
            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            // Result tables
            _gyoshaMst = alOutput.GyoshaMstDataTable;
            _hokenjoMst = alOutput.HokenjoMstDataTable;
            _jokasoDaichoMst = alOutput.JokasoDaichoMstDataTable;
            //_dispTable = alOutput.TuckSealListDataTable;

            // 検索結果件数
            //srhListCountLabel.Text = string.Concat(alOutput.TuckSealListDataTable.Count, "件");

            // 保健所(6)
            Utility.Utility.SetComboBoxList(hokenjoComboBox, alOutput.HokenjoMstDataTable, "HokenjoNm", "HokenjoCd", true);

            // タックシール印刷位置(28)
            printPositionComboBox.SelectedIndex = 0;

            // Binding source to dgv
            SetDataProperties();
            //listDataGridView.DataSource = alOutput.TuckSealListDataTable;

            // Control the display of dgv
            DgvControl(_hokenjoMst);
        }
        #endregion

        #region DoSearch
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoSearch
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoSearch()
        {
            // Load the initial status of datagridview
            ResetDgv();

            ISearchBtnClickALInput searchInput = new SearchBtnClickALInput();
            searchInput.SearchCond = SetSearchCond();
            ISearchBtnClickALOutput alOutput = new SearchBtnClickApplicationLogic().Execute(searchInput);

            // No records was found
            if (alOutput.TuckSealListDataTable.Count == 0)
            {
                // 検索結果件数
                srhListCountLabel.Text = "0件";
                MessageForm.Show2(MessageForm.DispModeType.Infomation, "表示データがありません。");
                return;
            }

            // 検索結果件数
            srhListCountLabel.Text = string.Concat(alOutput.TuckSealListDataTable.Count, "件");

            // Binding source to dgv
            SetDataProperties();
            listDataGridView.DataSource = alOutput.TuckSealListDataTable;

            // Control the display of dgv
            DgvControl(_hokenjoMst);
        }
        #endregion

        #region DgvControl
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DgvControl
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cbSource"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DgvControl(HokenjoMstDataSet.HokenjoMstDataTable cbSource)
        {
            // 印刷(16)
            listDataGridView.Columns["KbnCol"].DisplayIndex = 0;

            // 業者コード(17)
            listDataGridView.Columns["GyosyaCdCol"].DisplayIndex = 1;

            // 保健所名(18)
            listDataGridView.Columns["HokenjoNmCol"].DisplayIndex = 2;

            // 年月(19)
            listDataGridView.Columns["NengetsuCol"].DisplayIndex = 3;

            // 連番(20)
            listDataGridView.Columns["RenbanNoCol"].DisplayIndex = 4;

            // 検索ボタン(21)
            listDataGridView.Columns["SrhBtnCol"].DisplayIndex = 5;

            // 業者名/保健所名/設置者名(22)
            listDataGridView.Columns["NmCol"].DisplayIndex = 6;

            // 郵便番号(23)
            listDataGridView.Columns["ZipNoCol"].DisplayIndex = 7;

            // 住所(24)
            listDataGridView.Columns["AdrCol"].DisplayIndex = 8;

            foreach (DataGridViewRow dgvr in listDataGridView.Rows)
            {
                // Checkbox column
                DataGridViewCheckBoxCell ckCell = (DataGridViewCheckBoxCell)dgvr.Cells["KbnCol"];
                ckCell.FalseValue = "0";
                ckCell.TrueValue = "1";
                ckCell.Value = "1";

                // Text for button column
                DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvr.Cells["SrhBtnCol"];
                cell.Value = "検索";

                // Source for hokenjoNm combobox
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)dgvr.Cells["HokenjoNmCol"];
                cbCell.DataSource = cbSource;
                cbCell.DisplayMember = "HokenjoNm";
                cbCell.ValueMember = "HokenjoCd";
                cbCell.Value = dgvr.Cells["GyosyaCdCol"].Value.ToString();
            }
        }
        #endregion

        #region ClearSearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ClearSearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ClearSearchCond()
        {
            // 保健所(6)
            hokenjoComboBox.SelectedIndex = 0;

            // 登録年月(7)
            nengetsuTextBox.Text = string.Empty;

            // コード（開始）(8)
            cdFromTextBox.Text = string.Empty;

            // コード（終了）(9)
            cdToTextBox.Text = string.Empty;

            // Name textbox(29)
            furikomiNmTextBox.Text = string.Empty;
        }
        #endregion

        #region SetSearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetSearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private TuckSealSearchCond SetSearchCond()
        {
            TuckSealSearchCond searchCond = new TuckSealSearchCond();

            // 発行区分
            searchCond.RdSelect = (gyosyaRadioButton.Checked) ? "1" : (hokenjoRadioButton.Checked ? "2" : "3");

            // 保健所コード
            searchCond.HokenjoCd = hokenjoComboBox.SelectedValue != null ? hokenjoComboBox.SelectedValue.ToString() : string.Empty;

            // 登録年月
            searchCond.Nengetsu = nengetsuTextBox.Text;

            // コード（開始）
            searchCond.CdFrom = cdFromTextBox.Text;

            // コード（終了）
            searchCond.CdTo = cdToTextBox.Text;

            // 業者名称/保健所名/設置者氏名
            searchCond.SearchNm = furikomiNmTextBox.Text.Trim();

            return searchCond;
        }
        #endregion

        #region GyoshaRdCheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GyoshaRdCheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void GyoshaRdCheckedChanged()
        {
            // 検索結果件数
            srhListCountLabel.Text = "0件";

            // 保健所コンボボックス(6)
            hokenjoComboBox.Enabled = false;

            // 登録年月(7)
            nengetsuTextBox.ReadOnly = true;

            // コードFrom(8)
            cdFromTextBox.ReadOnly = false;
            cdFromTextBox.MaxLength = 4;

            // コードTo(9)
            cdToTextBox.ReadOnly = false;
            cdToTextBox.MaxLength = 4;

            // 名称(29)
            furikomiNmTextBox.ReadOnly = false;

            // 印刷(16)
            listDataGridView.Columns["KbnCol"].Visible = true;

            // 業者コード(17)
            listDataGridView.Columns["GyosyaCdCol"].Visible = true;

            // 保健所名(18)
            listDataGridView.Columns["HokenjoNmCol"].Visible = false;

            // 年月(19)
            listDataGridView.Columns["NengetsuCol"].Visible = false;

            // 連番(20)
            listDataGridView.Columns["RenbanNoCol"].Visible = false;

            // 検索ボタン(21)
            listDataGridView.Columns["SrhBtnCol"].Visible = true;
        }
        #endregion

        #region HokenjoRdCheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： HokenjoRdCheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void HokenjoRdCheckedChanged()
        {
            // 検索結果件数
            srhListCountLabel.Text = "0件";

            // 保健所コンボボックス(6)
            hokenjoComboBox.Enabled = true;

            // 登録年月(7)
            nengetsuTextBox.ReadOnly = true;

            // コードFrom(8)
            cdFromTextBox.ReadOnly = false;
            cdFromTextBox.MaxLength = 2;

            // コードTo(9)
            cdToTextBox.ReadOnly = false;
            cdToTextBox.MaxLength = 2;

            // 名称(29)
            furikomiNmTextBox.ReadOnly = false;

            // 印刷(16)
            listDataGridView.Columns["KbnCol"].Visible = true;

            // 業者コード(17)
            listDataGridView.Columns["GyosyaCdCol"].Visible = false;

            // 保健所名(18)
            listDataGridView.Columns["HokenjoNmCol"].Visible = true;

            // 年月(19)
            listDataGridView.Columns["NengetsuCol"].Visible = false;

            // 連番(20)
            listDataGridView.Columns["RenbanNoCol"].Visible = false;

            // 検索ボタン(21)
            listDataGridView.Columns["SrhBtnCol"].Visible = false;
        }
        #endregion

        #region SettisyaRdCheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SettisyaRdCheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SettisyaRdCheckedChanged()
        {
            // 検索結果件数
            srhListCountLabel.Text = "0件";

            // 保健所コンボボックス(6)
            hokenjoComboBox.Enabled = true;

            // 登録年月(7)
            nengetsuTextBox.ReadOnly = false;

            // コードFrom(8)
            cdFromTextBox.ReadOnly = false;
            cdFromTextBox.MaxLength = 5;

            // コードTo(9)
            cdToTextBox.ReadOnly = false;
            cdToTextBox.MaxLength = 5;

            // 名称(29)
            furikomiNmTextBox.ReadOnly = false;

            // 印刷(16)
            listDataGridView.Columns["KbnCol"].Visible = true;

            // 業者コード(17)
            listDataGridView.Columns["GyosyaCdCol"].Visible = false;

            // 保健所名(18)
            listDataGridView.Columns["HokenjoNmCol"].Visible = true;

            // 年月(19)
            listDataGridView.Columns["NengetsuCol"].Visible = true;

            // 連番(20)
            listDataGridView.Columns["RenbanNoCol"].Visible = true;

            // 検索ボタン(21)
            listDataGridView.Columns["SrhBtnCol"].Visible = true;
        }
        #endregion

        #region SetDataProperties
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetDataProperties
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDataProperties()
        {
            // 業者コード(17)
            listDataGridView.Columns["GyosyaCdCol"].DataPropertyName = CDCOL;

            // 保健所名(18)
            //listDataGridView.Columns["HokenjoNmCol"].DataPropertyName = HOKENJONMCOL;

            // 年月(19)
            listDataGridView.Columns["NengetsuCol"].DataPropertyName = NENGETSUCOL;

            // 連番(20)
            listDataGridView.Columns["RenbanNoCol"].DataPropertyName = RENBANCOL;

            // 業者名/保健所名/設置者名(22)
            listDataGridView.Columns["NmCol"].DataPropertyName = NMCOL;

            // 郵便番号(23)
            listDataGridView.Columns["ZipNoCol"].DataPropertyName = ZIPNOCOL;

            // 住所(24)
            listDataGridView.Columns["AdrCol"].DataPropertyName = ADRCOL;
        }
        #endregion

        #region GyoshaSearch
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GyoshaCdColLeave
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gyoshaCd"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void GyoshaSearch(string gyoshaCd)
        {
            string gyoshaNm = string.Empty;
            string gyoshaZipCd = string.Empty;
            string gyoshaAdr = string.Empty;
            DataRow[] row = _gyoshaMst.Select(string.Format("GyoshaCd = '{0}'", gyoshaCd), string.Empty);

            // No record was found
            if (row.Length == 0)
            {
                // 業者コード(17)
                listDataGridView.CurrentRow.Cells["GyosyaCdCol"].Value = string.Empty;
                // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                SetNmZipCdAdr(string.Empty, string.Empty, string.Empty);

                MessageForm.Show2(MessageForm.DispModeType.Error, "入力された業者コードは存在しません。");
                return;
            }

            gyoshaNm = row[0]["GyoshaNm"].ToString();
            gyoshaZipCd = row[0]["GyoshaZipCd"].ToString();
            gyoshaAdr = row[0]["GyoshaAdr"].ToString();

            // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
            SetNmZipCdAdr(gyoshaNm, gyoshaZipCd, gyoshaAdr);
        }
        #endregion

        #region JokasoDaichoSearch
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： HokenjoSearch
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hokenjoCd"></param>
        /// <param name="nengetsu"></param>
        /// <param name="renban"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void JokasoDaichoSearch(string hokenjoCd, string nengetsu, string renban)
        {
            // Error message
            StringBuilder errMsg = new StringBuilder();
            // 設置者氏名
            string name = string.Empty;
            // 設置者郵便番号
            string zipNo = string.Empty;
            // 浄化槽設置者住所
            string adr = string.Empty;

            // 年月(19) not equal 4 digits
            if (!string.IsNullOrEmpty(nengetsu) && nengetsu.Length != 4)
            {
                errMsg.Append("年月は4桁で入力して下さい。\r\n");
            }

            // 連番(20) not equal 5 digits
            if (!string.IsNullOrEmpty(renban) && renban.Length != 5)
            {
                errMsg.Append("連番は5桁で入力して下さい。");
            }

            // Throw a new exception
            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());

                // Clear input
                // 保健所名(18)
                listDataGridView.CurrentRow.Cells["HokenjoNmCol"].Value = string.Empty;
                // 年月(19)
                listDataGridView.CurrentRow.Cells["NengetsuCol"].Value = string.Empty;
                // 連番(20)
                listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value = string.Empty;
                // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                SetNmZipCdAdr(string.Empty, string.Empty, string.Empty);

                return;
            }

            // Key pair is not valid
            if (string.IsNullOrEmpty(hokenjoCd)
                || string.IsNullOrEmpty(nengetsu)
                || string.IsNullOrEmpty(renban))
            {
                return;
            }

            DataRow[] row = _jokasoDaichoMst.
                Select(string.Format("JokasoHokenjoCd = '{0}' and JokasoTorokuNendo = '{1}' and JokasoRenban = '{2}'", hokenjoCd, nengetsu, renban));

            // No record was found
            if (row.Length == 0)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, "入力された設置者は存在しません。");

                // 保健所名(18)
                listDataGridView.CurrentRow.Cells["HokenjoNmCol"].Value = string.Empty;
                // 年月(19)
                listDataGridView.CurrentRow.Cells["NengetsuCol"].Value = string.Empty;
                // 連番(20)
                listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value = string.Empty;
                // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                SetNmZipCdAdr(string.Empty, string.Empty, string.Empty);

                return;
            }

            name = row[0]["JokasoSetchishaNm"].ToString();
            zipNo = row[0]["JokasoSetchishaZipCd"].ToString();
            adr = row[0]["JokasoSetchishaAdr"].ToString();

            // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
            SetNmZipCdAdr(name, zipNo, adr);
        }
        #endregion

        #region ComboBox_SelectedIndexChanged
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ComboBox_SelectedIndexChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            // No change in combobox
            if (cb.SelectedValue == null || cb.SelectedValue is System.Data.DataRowView)
            {
                return;
            }

            // 保健所コード
            string hokenjoCd = cb.SelectedValue.ToString();

            // Hokenjo search
            if (hokenjoRadioButton.Checked)
            {
                // Hokenjo datarow
                DataRow[] row = _hokenjoMst.Select(string.Format("HokenjoCd = '{0}'", hokenjoCd), string.Empty);

                // 保健所名
                string hokenjoNm = row[0]["HokenjoNm"].ToString();
                // 保健所郵便番号
                string hokenjoZipCd = row[0]["HokenjoZipCd"].ToString();
                // 保健所住所
                string hokenjoAdr = row[0]["HokenjoAdr"].ToString();
                // 業者名/保健所名/設置者名(22) + 郵便番号(23) + 住所(24)
                SetNmZipCdAdr(hokenjoNm, hokenjoZipCd, hokenjoAdr);
            }
            else if (settisyaRadioButton.Checked)
            {
                // 年月(19)
                string nengetsu = listDataGridView.CurrentRow.Cells["NengetsuCol"].Value != null
                    ? listDataGridView.CurrentRow.Cells["NengetsuCol"].Value.ToString() : string.Empty;
                // 連番(20)
                string renban = listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value != null
                    ? listDataGridView.CurrentRow.Cells["RenbanNoCol"].Value.ToString() : string.Empty;

                JokasoDaichoSearch(hokenjoCd, nengetsu, renban);
            }
        }
        #endregion

        #region InitDgv
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： InitDgv
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void InitDgv()
        {
            // 
            // KbnCol
            // 
            DataGridViewCheckBoxColumn ckCol = new DataGridViewCheckBoxColumn();
            ckCol.FalseValue = "0";
            ckCol.HeaderText = "印刷";
            ckCol.MinimumWidth = 65;
            ckCol.Name = "KbnCol";
            ckCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            ckCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            ckCol.TrueValue = "1";
            ckCol.Width = 65;
            listDataGridView.Columns.Add(ckCol);
            // 
            // GyosyaCdCol
            // 
            DataGridViewTextBoxColumn gyosyaCdCol = new DataGridViewTextBoxColumn();
            gyosyaCdCol.HeaderText = "業者ｺｰﾄﾞ";
            gyosyaCdCol.MinimumWidth = 80;
            gyosyaCdCol.MaxInputLength = 4;
            gyosyaCdCol.Name = "GyosyaCdCol";
            gyosyaCdCol.Width = 80;
            gyosyaCdCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            listDataGridView.Columns.Add(gyosyaCdCol);
            // 
            // HokenjoNmCol
            // 
            DataGridViewComboBoxColumn hokenjoNmCol = new DataGridViewComboBoxColumn();
            hokenjoNmCol.HeaderText = "保健所名";
            hokenjoNmCol.MinimumWidth = 120;
            hokenjoNmCol.Name = "HokenjoNmCol";
            hokenjoNmCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            hokenjoNmCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            hokenjoNmCol.Width = 120;
            listDataGridView.Columns.Add(hokenjoNmCol);
            // 
            // NengetsuCol
            // 
            DataGridViewTextBoxColumn nengetsuCol = new DataGridViewTextBoxColumn();
            nengetsuCol.HeaderText = "年月";
            nengetsuCol.MinimumWidth = 60;
            nengetsuCol.MaxInputLength = 4;
            nengetsuCol.Name = "NengetsuCol";
            nengetsuCol.Width = 60;
            nengetsuCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            listDataGridView.Columns.Add(nengetsuCol);
            // 
            // RenbanNoCol
            // 
            DataGridViewTextBoxColumn renbanCol = new DataGridViewTextBoxColumn();
            renbanCol.HeaderText = "連番";
            renbanCol.MinimumWidth = 60;
            renbanCol.MaxInputLength = 5;
            renbanCol.Name = "RenbanNoCol";
            renbanCol.Width = 60;
            renbanCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            listDataGridView.Columns.Add(renbanCol);
            // 
            // SrhBtnCol
            // 
            DataGridViewButtonColumn srhBtnCol = new DataGridViewButtonColumn();
            srhBtnCol.HeaderText = "検索";
            srhBtnCol.MinimumWidth = 65;
            srhBtnCol.Name = "SrhBtnCol";
            srhBtnCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            srhBtnCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            srhBtnCol.Width = 65;
            listDataGridView.Columns.Add(srhBtnCol);
            // 
            // NmCol
            // 
            DataGridViewTextBoxColumn nmCol = new DataGridViewTextBoxColumn();
            nmCol.HeaderText = "宛先名称";
            nmCol.MinimumWidth = 200;
            nmCol.Name = "NmCol";
            //nmCol.ReadOnly = true;
            nmCol.Width = 200;
            nmCol.MaxInputLength = gyosyaRadioButton.Checked ? 40 : (hokenjoRadioButton.Checked ? 24 : 60);
            nmCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //nmCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            listDataGridView.Columns.Add(nmCol);
            // 
            // ZipNoCol
            // 
            DataGridViewTextBoxColumn zipNoCol = new DataGridViewTextBoxColumn();
            zipNoCol.HeaderText = "郵便番号";
            zipNoCol.MinimumWidth = 90;
            zipNoCol.Name = "ZipNoCol";
            //zipNoCol.ReadOnly = true;
            zipNoCol.Width = 90;
            zipNoCol.MaxInputLength = 8;
            zipNoCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //zipNoCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            listDataGridView.Columns.Add(zipNoCol);
            // 
            // AdrCol
            // 
            DataGridViewTextBoxColumn adrCol = new DataGridViewTextBoxColumn();
            adrCol.HeaderText = "住所";
            adrCol.MinimumWidth = 360;
            adrCol.Name = "AdrCol";
            //adrCol.ReadOnly = true;
            adrCol.Width = 360;
            adrCol.MaxInputLength = 80;
            adrCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //adrCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            listDataGridView.Columns.Add(adrCol);
        }
        #endregion

        #region ResetDgv
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： ResetDgv
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ResetDgv()
        {
            listDataGridView.DataSource = null;
            listDataGridView.Rows.Clear();
            listDataGridView.Columns.Clear();
            InitDgv();
            
            if (gyosyaRadioButton.Checked)
            {
                GyoshaRdCheckedChanged();
            }
            else if (hokenjoRadioButton.Checked)
            {
                HokenjoRdCheckedChanged();
            }
            else
            {
                SettisyaRdCheckedChanged();
            }
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
        /// 2014/08/12　AnhNV　　    新規作成
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

        #region IsOKForDecimalWithNegativeTextBox
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsOKForDecimalWithNegativeTextBox
        /// <summary>
        /// 
        /// </summary>
        /// <param name="character"></param>
        /// <param name="textBox"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/19　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool IsOKForDecimalWithNegativeTextBox(char character, TextBox textBox)
        {
            if (!char.IsControl(character)
                && !char.IsDigit(character)
                && (character != '-'))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region listDataGridView_ControlKeyPress
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： listDataGridView_ControlKeyPress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void listDataGridView_ControlKeyPress(object sender, KeyPressEventArgs e)
        {
            switch (listDataGridView.Columns[listDataGridView.CurrentCell.ColumnIndex].Name)
            {
                case "GyosyaCdCol":
                case "NengetsuCol":
                case "RenbanNoCol":
                    e.Handled = !IsOKForDecimalTextBox(e.KeyChar, sender as TextBox) ? true : false;
                    break;
                case "ZipNoCol":
                    e.Handled = !IsOKForDecimalWithNegativeTextBox(e.KeyChar, sender as TextBox) ? true : false;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region PrintCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： PrintCheck
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool PrintCheck()
        {
            bool result = false;
            int rowCnt = 0;
            string err58_1 = string.Empty;
            string err58_2 = string.Empty;
            string err58_3 = string.Empty;
            string errMsg = string.Empty;

            foreach (DataGridViewRow dgvr in listDataGridView.Rows)
            {
                // Any row is checked!
                if ((bool)dgvr.Cells["KbnCol"].FormattedValue == true
                    && !result)
                {
                    result = true;
                }

                if (dgvr.Cells["ZipNoCol"].Value == null ||
                    string.IsNullOrEmpty(dgvr.Cells["ZipNoCol"].Value.ToString().Trim()))
                {

                }
                else if (dgvr.Cells["ZipNoCol"].Value.ToString().Length != 8)
                {
                    err58_1 += rowCnt + 1 + ", ";
                }
                else if (!Utility.Utility.IsNumAndNegative(dgvr.Cells["ZipNoCol"].Value.ToString()))
                {
                    err58_2 += rowCnt + 1 + ", ";
                }
                else if (!Utility.Utility.IsZipCode(dgvr.Cells["ZipNoCol"].Value.ToString()))
                {
                    err58_3 += rowCnt + 1 + ", ";
                }

                rowCnt++;
            }

            // No row is checked
            if (!result)
            {
                errMsg += "印刷する内容がありません。\r\n";
            }

            if (err58_1 != string.Empty)
            {
                errMsg += string.Format("行{0}: 郵便番号は8桁で入力して下さい。\r\n", err58_1.Remove(err58_1.Length - 2));
            }

            if (err58_2 != string.Empty)
            {
                errMsg += string.Format("行{0}: 郵便番号は半角数字、及び\" - (半角ハイフン)\"で入力して下さい。\r\n", err58_2.Remove(err58_2.Length - 2));
            }

            if (err58_3 != string.Empty)
            {
                errMsg += string.Format("行{0}: 郵便番号の形式が不正です。\r\n", err58_3.Remove(err58_3.Length - 2));
            }

            // Data check fail
            if (!string.IsNullOrEmpty(errMsg.Replace(Environment.NewLine, string.Empty)))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg);
                result = false;
            }

            return result;
        }
        #endregion

        #region GetDataTableFromDgv
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GetDataTableFromDgv
        /// <summary>
        /// Get DataTable from selected dgv rows
        /// </summary>
        /// <param name=""></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private JokasoDaichoMstDataSet.TuckSealListDataTable GetDataTableFromDgv()
        {
            JokasoDaichoMstDataSet.TuckSealListDataTable table = new JokasoDaichoMstDataSet.TuckSealListDataTable();

            var rows = listDataGridView.Rows.OfType<DataGridViewRow>()
                            .Where(r => r.Cells["KbnCol"].Value.ToString() == "1")
                            .Select(r => ((DataRowView)r.DataBoundItem).Row);
            foreach (var row in rows)
            {
                table.ImportRow(row);
            }

            return table;
        }
        #endregion

        #region DataCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DataCheck
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdLen"></param>
        /// <param name="labelCd"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool DataCheck(int cdLen, string labelCd)
        {
            // Error messages
            StringBuilder errMsg = new StringBuilder();
            bool lenCheckFail = false;

            // コード（開始）
            if (!string.IsNullOrEmpty(cdFromTextBox.Text)
                && cdFromTextBox.Text.Length != cdLen)
            {
                errMsg.Append(string.Format("{0}（開始）は{1}桁で入力して下さい。\r\n", labelCd, cdLen));
                lenCheckFail = true;
            }

            // コード（終了）
            if (!string.IsNullOrEmpty(cdToTextBox.Text)
                && cdToTextBox.Text.Length != cdLen)
            {
                errMsg.Append(string.Format("{0}（終了）は{1}桁で入力して下さい。\r\n", labelCd, cdLen));
                lenCheckFail = true;
            }

            // 関連チェック
            if (!lenCheckFail
                && !string.IsNullOrEmpty(cdFromTextBox.Text)
                && !string.IsNullOrEmpty(cdToTextBox.Text)
                && Convert.ToDecimal(cdFromTextBox.Text) > Convert.ToDecimal(cdToTextBox.Text))
            {
                errMsg.Append("範囲指定が正しくありません。コードの大小関係を確認してください。\r\n");
            }

            // Throw error messages
            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #region SetNmZipCdAdr
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetNmZipCdAdr
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="zipCd"></param>
        /// <param name="adr"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetNmZipCdAdr(string name, string zipCd, string adr)
        {
            // 業者名/保健所名/設置者名(22)
            listDataGridView.CurrentRow.Cells["NmCol"].Value = name;

            // 郵便番号(23)
            listDataGridView.CurrentRow.Cells["ZipNoCol"].Value = zipCd;
            
            // 住所(24)
            listDataGridView.CurrentRow.Cells["AdrCol"].Value = adr;
        }
        #endregion

        #endregion
    }
    #endregion
}