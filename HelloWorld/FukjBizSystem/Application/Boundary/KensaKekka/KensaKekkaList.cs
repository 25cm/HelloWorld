using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.KensaKekka.KensaKekkaList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.KensaKekka
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensaKekkaListForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/08　HuyTX     新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KensaKekkaListForm : Form
    {
        #region 定義(public)

        /// <summary>
        /// PrintMode
        /// </summary>
        public enum PrintMode
        {
            FaxMk,        // FaxMk
            FaxHosyu,     // FaxHosyu
            FaxKoji,      // FaxKoji
            FaxHoken      // FaxHoken
        }
        #endregion

        #region プロパティ(private)
        /// <summary>
        /// 検索条件の表示・非表示フラグ(初期値：表示）
        /// </summary>
        private bool _searchShowFlg = true;
        private int _defaultSearchPanelTop = 0;
        private int _defaultSearchPanelHeight = 0;
        private int _defaultListPanelTop = 0;
        private int _defaultListPanelHeight = 0;

        /// <summary>
        /// currentDateTime
        /// </summary>
        private DateTime _currentDateTime = Common.Common.GetCurrentTimestamp();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： KensaKekkaListForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public KensaKekkaListForm()
        {
            InitializeComponent();
            //this.kekkaListDataGridView.Rows.Add("7条", "01", "○○保健所", "2014", "000001", "2014/07/01", "2014/07/15", "浄化槽太郎", "○○施設", "福岡市○○区○○１","○");
            //this.kekkaListDataGridView.Rows.Add("11条", "01", "○○保健所", "2014", "000002", "2014/07/01", "2014/07/22", "浄化槽次郎", "△△施設", "福岡市○○区○○２", "△");
            //this.kekkaListDataGridView.Rows.Add("11条", "01", "○○保健所", "2014", "000003", "2014/07/01", "2014/07/23", "浄化槽三郎", "□□施設", "福岡市○○区○○３", "×");

        }
        #endregion

        #region イベント

        #region KensaKekkaListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensaKekkaListForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KensaKekkaListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DoFormLoad();

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

        #region viewChangeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： viewChangeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
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
                    this.kekkaListPanel,
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

        #region clearButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： clearButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void clearButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //ryohoRadioButton.Checked = true;
                //kensa7JoRadioButton.Checked = kensa11JoRadioButton.Checked = false;
                kensaKbnComboBox.SelectedIndex = 0;
                hokenjoComboBox.SelectedIndex = 0;
                iraiNendoTextBox.Text = string.Empty;
                settisyaTextBox.Text = string.Empty;
                shisetsuNmTextBox.Text = string.Empty;
                kensaIraiDtUseCheckBox.Checked = false;
                kensaDtUseCheckBox.Checked = true;
                kensaIraiDtToDateTimePicker.ResetText();
                kensaDtToDateTimePicker.ResetText();

                kensaIraiDtUseCheckBox_Click(null, null);
                kensaDtUseCheckBox_Click(null, null);

                // set default datetime
                SetValueDateTimePicker();

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
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensakuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!IsValidInput()) return;

                DoSearch();
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

        #region kekkasyoButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kekkasyoButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kekkasyoButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0 || MessageForm.Show2(MessageForm.DispModeType.Question, "結果書を印刷します。よろしいですか？") != DialogResult.Yes) return;

                //TODO

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

        #region faxMkButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： faxMkButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void faxMkButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0 || MessageForm.Show2(MessageForm.DispModeType.Question, "FAX送付書(メーカー)を印刷します。よろしいですか？") != DialogResult.Yes) return;

                //print data
                PrintSouShinhyoInfo(PrintMode.FaxMk);

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

        #region faxHosyuButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： faxHosyuButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void faxHosyuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0 || MessageForm.Show2(MessageForm.DispModeType.Question, "FAX送付書(保守点検業者)を印刷します。よろしいですか？") != DialogResult.Yes) return;

                //print data
                PrintSouShinhyoInfo(PrintMode.FaxHosyu);

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

        #region faxKojiButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： faxKojiButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void faxKojiButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0 || MessageForm.Show2(MessageForm.DispModeType.Question, "FAX送付書(工事業者)を印刷します。よろしいですか？") != DialogResult.Yes) return;

                //print data
                PrintSouShinhyoInfo(PrintMode.FaxKoji);
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

        #region faxHokenButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： faxHokenButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void faxHokenButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0 || MessageForm.Show2(MessageForm.DispModeType.Question, "FAX送付書(保健所)を印刷します。よろしいですか？") != DialogResult.Yes) return;

                //print data
                PrintSouShinhyoInfo(PrintMode.FaxHoken);
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
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void outputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kekkaListDataGridView.RowCount == 0) return;

                //DataGridViewのデータをExcelへ出力する
                string outputFilename = "検査結果一覧";
                Common.Common.FlushGridviewDataToExcel(kekkaListDataGridView, outputFilename);

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
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void tojiruButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                KekkaMenuForm frm = new KekkaMenuForm();
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

        #region KensaKekkaListForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensaKekkaListForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KensaKekkaListForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyData)
                {
                    case Keys.F1:
                        kekkasyoButton.PerformClick();
                        break;
                    case Keys.F2:
                        faxMkButton.PerformClick();
                        break;
                    case Keys.F3:
                        faxHosyuButton.PerformClick();
                        break;
                    case Keys.F4:
                        faxKojiButton.PerformClick();
                        break;
                    case Keys.F5:
                        faxHokenButton.PerformClick();
                        break;
                    case Keys.F6:
                        outputButton.PerformClick();
                        break;
                    case Keys.F7:
                        clearButton.PerformClick();
                        break;
                    case Keys.F8:
                        kensakuButton.PerformClick();
                        break;
                    case Keys.F12:
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

        #region kekkaListDataGridView_CellDoubleClick
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kekkaListDataGridView_CellDoubleClick
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kekkaListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;


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

        #region kensaIraiDtUseCheckBox_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kensaIraiDtUseCheckBox_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensaIraiDtUseCheckBox_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                kensaIraiDtFromDateTimePicker.Enabled = kensaIraiDtToDateTimePicker.Enabled = kensaIraiDtUseCheckBox.Checked;
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

        #region kensaDtUseCheckBox_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kensaDtUseCheckBox_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensaDtUseCheckBox_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                kensaDtFromDateTimePicker.Enabled = kensaDtToDateTimePicker.Enabled = kensaDtUseCheckBox.Checked;
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
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            this._searchShowFlg = true;
            this._defaultSearchPanelTop = this.searchPanel.Top;
            this._defaultSearchPanelHeight = this.searchPanel.Height;
            this._defaultListPanelTop = this.kekkaListPanel.Top;
            this._defaultListPanelHeight = this.kekkaListPanel.Height;

            // set default datetime
            SetValueDateTimePicker();

            IFormLoadALInput alInput = new FormLoadALInput();
            alInput.KensaDtFrom = kensaDtFromDateTimePicker.Value.ToString("yyyyMMdd");
            alInput.KensaDtTo = kensaDtToDateTimePicker.Value.ToString("yyyyMMdd");
            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            //set data for Hokenjo Combobox
            Utility.Utility.SetComboBoxList(hokenjoComboBox, alOutput.HokenjoMstDataTable, "HokenjoNm", "HokenjoCd", true);

            //set data for KensaKbn Combobox
            Utility.Utility.SetComboBoxList(kensaKbnComboBox, Common.Common.GetConstTable(Utility.Constants.ConstKbnConstanst.CONST_KBN_006), "ConstNm", "ConstValue", true);

            //検索結果件数
            kekkaListCountLabel.Text = alOutput.KensaIraiTblKensakuDataTable.Count + "件";

            //set data for display gridview
            kekkaListDataGridView.DataSource = alOutput.KensaIraiTblKensakuDataTable;

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
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoSearch()
        {
            kekkaListDataGridView.DataSource = null;

            IKensakuBtnClickALInput alInput = new KensakuBtnClickALInput();

            //make search condition
            MakeSearchCond(alInput);

            IKensakuBtnClickALOutput alOutput = new KensakuBtnClickApplicationLogic().Execute(alInput);

            kekkaListCountLabel.Text = alOutput.KensaIraiTblKensakuDataTable.Count + "件";

            if (alOutput.KensaIraiTblKensakuDataTable.Count == 0)
            {
                MessageForm.Show2(MessageForm.DispModeType.Infomation, "表示データがありません。");
                return;
            }

            //set data for display gridview
            kekkaListDataGridView.DataSource = alOutput.KensaIraiTblKensakuDataTable;

        }
        #endregion

        #region IsValidInput
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： IsValidInput
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool IsValidInput()
        {
            StringBuilder errMsg = new StringBuilder();

            #region UnitCheck

            #endregion

            #region RelationCheck

            //検査依頼日（開始＆終了）
            if (kensaIraiDtUseCheckBox.Checked
                && Int32.Parse(kensaIraiDtFromDateTimePicker.Value.ToString("yyyyMMdd")) > Int32.Parse(kensaIraiDtToDateTimePicker.Value.ToString("yyyyMMdd")))
            {
                errMsg.AppendLine("範囲指定が正しくありません。検査依頼日の大小関係を確認してください。");
            }

            //検査日（開始＆終了）
            if (kensaDtUseCheckBox.Checked
                && Int32.Parse(kensaDtFromDateTimePicker.Value.ToString("yyyyMMdd")) > Int32.Parse(kensaDtToDateTimePicker.Value.ToString("yyyyMMdd")))
            {
                errMsg.AppendLine("範囲指定が正しくありません。検査日の大小関係を確認してください。");
            }

            #endregion

            if (!string.IsNullOrEmpty(errMsg.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMsg.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #region MakeSearchCond
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeSearchCond
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alInput"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/08　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MakeSearchCond(IKensakuBtnClickALInput alInput)
        {
            if (kensaKbnComboBox.SelectedIndex != 0)
            {
                alInput.KensaIraiHoteiKbn = kensaKbnComboBox.SelectedValue.ToString();
            }
            
            if (hokenjoComboBox.SelectedIndex != 0)
            {
                alInput.HokenjoCd = hokenjoComboBox.SelectedValue.ToString();
            }

            alInput.KensaIraiNendo = iraiNendoTextBox.Text.Trim();
            alInput.KensaIraiSetchishaNm = settisyaTextBox.Text.Trim();
            alInput.KensaIraiShisetsuNm = shisetsuNmTextBox.Text.Trim();

            if (kensaIraiDtUseCheckBox.Checked)
            {
                alInput.KensaIraiDtFrom = kensaIraiDtFromDateTimePicker.Value.ToString("yyyyMMdd");
                alInput.KensaIraiDtTo = kensaIraiDtToDateTimePicker.Value.ToString("yyyyMMdd");
            }

            if (kensaDtUseCheckBox.Checked)
            {
                alInput.KensaDtFrom = kensaDtFromDateTimePicker.Value.ToString("yyyyMMdd");
                alInput.KensaDtTo = kensaDtToDateTimePicker.Value.ToString("yyyyMMdd");
            }

            //if (kensa7JoRadioButton.Checked)
            //{
            //    alInput.KensaIraiHoteiKbn = "1";
            //}

            //if (kensa11JoRadioButton.Checked)
            //{
            //    alInput.KensaIraiHoteiKbn = "2, 3";
            //}
        }
        #endregion

        #region SetValueDateTimePicker
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetValueDateTimePicker
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/12　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetValueDateTimePicker()
        {
            kensaIraiDtFromDateTimePicker.Value = _currentDateTime;
            kensaIraiDtFromDateTimePicker.Value = new DateTime(_currentDateTime.Year, _currentDateTime.Month, 1);

            kensaDtFromDateTimePicker.Value = _currentDateTime;
            kensaDtFromDateTimePicker.Value = new DateTime(_currentDateTime.Year, _currentDateTime.Month, 1);
        }
        #endregion

        #region SetValueDateTimePicker
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetValueDateTimePicker
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/15　HuyTX    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void PrintSouShinhyoInfo(PrintMode printMode)
        {
            DataGridViewRow printRow = kekkaListDataGridView.CurrentRow;

            IFaxPrintBtnClickALInput alInput = new FaxPrintBtnClickALInput();
            alInput.PrintMode = printMode;

            alInput.KensaIraiHoteiKbn = printRow.Cells["KensaIraiHoteiKbnCol"].Value.ToString();
            alInput.KensaIraiHokenjoCd = printRow.Cells["HokenjoCdCol"].Value.ToString();
            alInput.KensaIraiNendo = printRow.Cells["NendoCol"].Value.ToString();
            alInput.KensaIraiRenban = printRow.Cells["RenbanNoCol"].Value.ToString();

            new FaxPrintBtnClickApplicationLogic().Execute(alInput);


        }
        #endregion

        #endregion

    }

    #endregion

}
