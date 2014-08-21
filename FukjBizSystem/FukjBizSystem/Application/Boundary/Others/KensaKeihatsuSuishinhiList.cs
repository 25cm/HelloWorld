using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Others.KensaKeihatsuSuishinhiList;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Others
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensaKeihatsuSuishinhiListForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/18  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KensaKeihatsuSuishinhiListForm : Form
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

        /// <summary>
        /// DateTime Today
        /// </summary>
        private DateTime _today = Common.Common.GetCurrentTimestamp();

        /// <summary>
        /// 職員名
        /// </summary>
        private string _loginNm = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

        /// <summary>
        /// KensaKeihatsuSuishinListDataTable
        /// </summary>
        private KensaKeihatsuSuishinHiShukeiTblDataSet.KensaKeihatsuSuishinListDataTable _printTable;

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： KensaKeihatsuSuishinhiListForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public KensaKeihatsuSuishinhiListForm()
        {
            InitializeComponent();
        }
        #endregion

        #region イベント

        #region KensaKeihatsuSuishinhiListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensaKeihatsuSuishinhiListForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KensaKeihatsuSuishinhiListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                SetDefaultValues();

                ikkatsuPrintButton.Enabled = false;
                kobetsuGyosyaButton.Enabled = false;
                kobetsuKumiaiButton.Enabled = false;
                outputButton.Enabled = false;

                DoFormLoad();
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

        #region ViewChangeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ViewChangeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ViewChangeButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this._searchShowFlg = !this._searchShowFlg;
                if (this._searchShowFlg) // 検索条件を開く
                {
                    this.viewChangeButton.Text = "▲";
                }
                else // 検索条件を閉じる
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
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void clearButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                SetDefaultValues();
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
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensakuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!CheckCondition()) { return; }

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

        #region syukeiButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： syukeiButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void syukeiButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                KensaKeihatsuSuishinhiSyukeiForm frm = new KensaKeihatsuSuishinhiSyukeiForm();
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

        #region ikkatsuPrintButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ikkatsuPrintButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ikkatsuPrintButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (srhListDataGridView.RowCount == 0)
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "印刷可能なデータが検索されていません。");
                    return;
                }

                // 一覧印刷時に集計年度が未入力、上下期区分が全件だった場合
                if (string.IsNullOrEmpty(syukeiNendoTextBox.Text) && kamikiRadioButton.Checked)
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "一覧印刷は、集計年度、上期・下期を指定して検索したデータしか印刷できません。");
                    return;
                }
                
                if (!RequiredCheck()) { return; }

                if (MessageForm.Show2(MessageForm.DispModeType.Question, "検索結果一覧から支払票を一括印刷します。よろしいですか？") == System.Windows.Forms.DialogResult.Yes)
                {
                    IIkkatsuPrintBtnClickALInput alInput = new IkkatsuPrintBtnClickALInput();
                    alInput.KensaKeihatsuSuishinListDataTable = _printTable;
                    alInput.PrintNo = printNoTextBox.Text.Trim();
                    alInput.SystemDt = _today;

                    new IkkatsuPrintBtnClickApplicationLogic().Execute(alInput);
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

        #region kobetsuGyosyaButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kobetsuGyosyaButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kobetsuGyosyaButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (srhListDataGridView.RowCount == 0) { return; }

                // 選択行の業者が組合一括支払の場合
                if (!string.IsNullOrEmpty(srhListDataGridView.CurrentRow.Cells["KumiaiCdCol"].Value.ToString()))
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "選択された業者は組合一括支払いになるため、個別印刷はできません。");
                    return;
                }

                if (!RequiredCheck()) { return; }

                if (MessageForm.Show2(MessageForm.DispModeType.Question, "選択した業者の個別業者支払票を印刷します。よろしいですか？") == System.Windows.Forms.DialogResult.Yes)
                {
                    // TODO
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

        #region kobetsuKumiaiButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kobetsuKumiaiButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kobetsuKumiaiButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (srhListDataGridView.RowCount == 0) { return; }

                if (string.IsNullOrEmpty(srhListDataGridView.CurrentRow.Cells["KumiaiCdCol"].Value.ToString()))
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "選択された業者は組合に加入していないため、一括印刷対象外です。");
                    return;
                }

                if (!RequiredCheck()) { return; }

                if (MessageForm.Show2(MessageForm.DispModeType.Question, "選択した組合の個別業者支払票を印刷します。(検索結果分のみ)よろしいですか？") == System.Windows.Forms.DialogResult.Yes)
                {
                    // Export 021
                    IKobetsuKumiaiBtnClickALInput alInput = new KobetsuKumiaiBtnClickALInput();
                    alInput.PrintNo = printNoTextBox.Text.Trim();
                    alInput.SystemDt = _today;
                    alInput.LoginNm = _loginNm;
                    alInput.KensaKeihatsuSuishinListDataTable = _printTable;
                    new KobetsuKumiaiBtnClickApplicationLogic().Execute(alInput);
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
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/11  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void outputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (srhListDataGridView.RowCount == 0) { return; }

                // DataGridViewのデータをExcelへ出力する
                string outputFilename = "検査員月報";
                Common.Common.FlushGridviewDataToExcel(this.srhListDataGridView, outputFilename);
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
        /// 2014/08/18  DatNT　  新規作成
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

        #region KensaKeihatsuSuishinhiListForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensaKeihatsuSuishinhiListForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KensaKeihatsuSuishinhiListForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyData)
                {
                    case Keys.F1:
                        syukeiButton.PerformClick();
                        break;

                    case Keys.F2:
                        ikkatsuPrintButton.PerformClick();
                        break;

                    case Keys.F3:
                        kobetsuGyosyaButton.PerformClick();
                        break;

                    case Keys.F4:
                        kobetsuKumiaiButton.PerformClick();
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
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            // Clear datagirdview
            kensaKeihatsuSuishinHiShukeiTblDataSet.Clear();

            IFormLoadALInput alInput    = new FormLoadALInput();
            alInput.SuishinhiNendo      = syukeiNendoTextBox.Text;
            alInput.KamiShimoKbn        = "1";
            alInput.Mochikomi           = mochikomiCheckBox.Checked;
            alInput.Syusyu              = syusyuCheckBox.Checked;
            alInput.Toriatsukai         = toriatsukaiCheckBox.Checked;
            IFormLoadALOutput alOutput  = new FormLoadApplicationLogic().Execute(alInput);
            _printTable = alOutput.KensaKeihatsuSuishinListDT;

            // 共同組合
            Utility.Utility.SetComboBoxList(kyodoKumiaiComboBox, alOutput.KyodoKumiaiMstInfoDT, "KumiaiNm", "KumiaiCd", true);

            // Display data
            kensaKeihatsuSuishinHiShukeiTblDataSet.Merge(alOutput.KensaKeihatsuSuishinListDT);

            if (alOutput.KensaKeihatsuSuishinListDT == null || alOutput.KensaKeihatsuSuishinListDT.Count == 0)
            {
                srhListCountLabel.Text = "0件";
            }
            else
            {
                srhListCountLabel.Text = alOutput.KensaKeihatsuSuishinListDT.Count.ToString() + "件";
            }

            this._searchShowFlg = true;
            this._defaultSearchPanelTop = this.searchPanel.Top;
            this._defaultSearchPanelHeight = this.searchPanel.Height;
            this._defaultListPanelTop = this.srhListPanel.Top;
            this._defaultListPanelHeight = this.srhListPanel.Height;
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
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MakeSearchCond(IKensakuBtnClickALInput alInput)
        {
            // 集計年度
            alInput.SuishinhiNendo = syukeiNendoTextBox.Text;

            // 上下期区分 
            if (kamikiRadioButton.Checked)
            {
                alInput.KamiShimoKbn = "1";
            }
            else if (shimokiRadioButton.Checked)
            {
                alInput.KamiShimoKbn = "2";
            }

            // 業者コード（開始）
            alInput.GyosyaCdFrom = gyosyaCdFromTextBox.Text;

            // 業者コード（終了）
            alInput.GyosyaCdTo = gyosyaCdToTextBox.Text;

            // 組合CD
            if (kyodoKumiaiComboBox.SelectedValue != null)
            {
                alInput.KumiaiCd = kyodoKumiaiComboBox.SelectedValue.ToString();
            }

            // 対象業者/持込
            alInput.Mochikomi = mochikomiCheckBox.Checked;

            // 対象業者/収集
            alInput.Syusyu = syusyuCheckBox.Checked;

            // 対象業者/取扱
            alInput.Toriatsukai = toriatsukaiCheckBox.Checked;
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
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoSearch()
        {
            // Clear datagirdview
            kensaKeihatsuSuishinHiShukeiTblDataSet.Clear();

            IKensakuBtnClickALInput alInput = new KensakuBtnClickALInput();

            // Create conditions
            MakeSearchCond(alInput);

            IKensakuBtnClickALOutput alOutput = new KensakuBtnClickApplicationLogic().Execute(alInput);
            _printTable = alOutput.KensaKeihatsuSuishinListDT;

            // Display data
            kensaKeihatsuSuishinHiShukeiTblDataSet.Merge(alOutput.KensaKeihatsuSuishinListDT);

            if (alOutput.KensaKeihatsuSuishinListDT == null || alOutput.KensaKeihatsuSuishinListDT.Count == 0)
            {
                srhListCountLabel.Text = "0件";

                // 保健所一覧 : リスト数 = 0
                MessageForm.Show2(MessageForm.DispModeType.Infomation, "表示データがありません。");
            }
            else
            {
                srhListCountLabel.Text = alOutput.KensaKeihatsuSuishinListDT.Count.ToString() + "件";

                ikkatsuPrintButton.Enabled = true;
                kobetsuGyosyaButton.Enabled = true;
                kobetsuKumiaiButton.Enabled = true;
                outputButton.Enabled = true;
            }
        }
        #endregion

        #region CheckCondition
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CheckCondition
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckCondition()
        {
            StringBuilder errMess = new StringBuilder();

            // 業者コード（開始）
            if (!string.IsNullOrEmpty(gyosyaCdFromTextBox.Text) && gyosyaCdFromTextBox.Text.ToString().Trim().Length != 4)
            {
                errMess.Append("業者コード（開始）は4桁で入力して下さい。\r\n");
            }

            // 業者コード（終了）
            if (!string.IsNullOrEmpty(gyosyaCdToTextBox.Text) && gyosyaCdToTextBox.Text.ToString().Trim().Length != 4)
            {
                errMess.Append("業者コード（終了）は4桁で入力して下さい。\r\n");
            }

            if(string.IsNullOrEmpty(errMess.ToString()))
            {
                if (!string.IsNullOrEmpty(gyosyaCdFromTextBox.Text) && !string.IsNullOrEmpty(gyosyaCdToTextBox.Text))
                {
                    if (Convert.ToInt32(gyosyaCdFromTextBox.Text) > Convert.ToInt32(gyosyaCdToTextBox.Text))
                    {
                        errMess.Append("範囲指定が正しくありません。業者コードの大小関係を確認してください。\r\n");
                    }
                }
            }

            // 対象業者のチェックが全てOFFの場合
            if (!mochikomiCheckBox.Checked && !syusyuCheckBox.Checked && !toriatsukaiCheckBox.Checked)
            {
                errMess.Append("対象業者を選択してください。\r\n");
            }

            if (!string.IsNullOrEmpty(errMess.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMess.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #region SetDefaultValues
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetDefaultValues
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDefaultValues()
        {
            // 集計年度
            if (_today.Month > 3)
            {
                syukeiNendoTextBox.Text = _today.Year.ToString();
            }
            else
            {
                syukeiNendoTextBox.Text = (_today.Year - 1).ToString();
            }

            if (_today.Month >= 4 && _today.Month <= 10)
            {
                // 上下期区分/上期
                kamikiRadioButton.Checked = true;
            }
            else
            {
                // 上下期区分/下期
                shimokiRadioButton.Checked = true;
            }

            // 業者コード（開始）
            gyosyaCdFromTextBox.Clear();

            // 業者コード（終了）
            gyosyaCdToTextBox.Clear();

            // 共同組合
            kyodoKumiaiComboBox.SelectedIndex = -1;

            // 対象業者/持込
            mochikomiCheckBox.Checked = true;

            // 対象業者/収集
            syusyuCheckBox.Checked = true;

            // 対象業者/取扱
            toriatsukaiCheckBox.Checked = true;

            // 支払票印刷第○号
            printNoTextBox.Clear();
        }
        #endregion

        #region RequiredCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： RequiredCheck
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/18  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool RequiredCheck()
        {
            StringBuilder errMess = new StringBuilder();

            // 支払票印刷時に支払票番号が未入力
            if (string.IsNullOrEmpty(printNoTextBox.Text))
            {
                errMess.Append("支払票印刷時は支払票番号は必須です。");
            }

            if (!string.IsNullOrEmpty(errMess.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMess.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #endregion
    }
    #endregion
}
