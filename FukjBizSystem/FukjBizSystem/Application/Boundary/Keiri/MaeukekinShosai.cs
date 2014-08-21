using System;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Keiri.MaeukekinShosai;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Keiri
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： MaeukekinShosaiForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/07/21  DatNT　  新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class MaeukekinShosaiForm : Form
    {
        #region 定義(public)

        #region 表示モード
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

        #endregion

        #region プロパティ(private)

        /// <summary>
        /// Login User
        /// </summary>
        private string loginUser = Utility.ShokuinInfo.GetShokuinInfo().Shokuin.ShokuinNm;

        /// <summary>
        /// 端末
        /// </summary>
        private string pcUpdate = Dns.GetHostName();

        /// <summary>
        /// 前受照合番号１
        /// </summary>
        private string _maeukekinSyogoNo1 = string.Empty;

        /// <summary>
        /// 前受照合番号２
        /// </summary>
        private string _maeukekinSyogoNo2 = string.Empty;

        /// <summary>
        /// Display mode
        /// </summary>
        private DispMode _dispMode;

        /// <summary>
        /// Update mode
        /// </summary>
        private DispMode _updateMode;

        /// <summary>
        /// MaeukekinTblDataTable
        /// </summary>
        private MaeukekinTblDataSet.MaeukekinTblDataTable _dispDT;

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： MaeukekinShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public MaeukekinShosaiForm()
        {
            InitializeComponent();
        }
        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： MaeukekinShosaiForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="maeukekinSyogoNo1"></param>
        /// <param name="maeukekinSyogoNo2"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public MaeukekinShosaiForm(string maeukekinSyogoNo1, string maeukekinSyogoNo2)
        {
            InitializeComponent();

            this._maeukekinSyogoNo1 = maeukekinSyogoNo1;
            this._maeukekinSyogoNo2 = maeukekinSyogoNo2;
        }
        #endregion

        #region イベント

        #region MaeukekinShosaiForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： MaeukekinShosaiForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MaeukekinShosaiForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                kyoseiUriGakuTextBox.KeyPress       += new KeyPressEventHandler(NumberKeyPress);
                nyukingakuTextBox.KeyPress          += new KeyPressEventHandler(NumberKeyPress);
                zankinTextBox.KeyPress              += new KeyPressEventHandler(NumberKeyPress);
                henkingakuTextBox.KeyPress          += new KeyPressEventHandler(NumberKeyPress);
                nyukinDtTextBox.KeyPress            += new KeyPressEventHandler(NumberKeyPress);
                uriageDtTextBox.KeyPress            += new KeyPressEventHandler(NumberKeyPress);
                torisageDtTextBox.KeyPress          += new KeyPressEventHandler(NumberKeyPress);
                nyukinToriatukaiDtTextBox.KeyPress  += new KeyPressEventHandler(NumberKeyPress);
                henkinDtTextBox.KeyPress            += new KeyPressEventHandler(NumberKeyPress);

                if (string.IsNullOrEmpty(_maeukekinSyogoNo1) && string.IsNullOrEmpty(_maeukekinSyogoNo2))
                {
                    _dispMode = DispMode.Add;
                }
                else
                {
                    _dispMode = DispMode.Detail;
                }

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

        #region EntryButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： EntryButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void EntryButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!UnitCheck()) { return; }

                if (kisaiAriRadioButton.Checked)
                {
                    if (!CheckExist())
                    {
                        return;
                    }
                }

                // update mode
                _updateMode = _dispMode;

                // display mode
                _dispMode = DispMode.Confirm;

                SetControlModeView();

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

        #region ChangeButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ChangeButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (_dispMode == DispMode.Detail)
                {
                    _dispMode = DispMode.Edit;
                }
                else if (_dispMode == DispMode.Edit)
                {
                    if (!UnitCheck()) { return; }

                    if (!DeleteUpdateCheck())
                    {
                        MessageForm.Show2(MessageForm.DispModeType.Error, "既に処理されているため、変更・削除できません。");
                        return;
                    }

                    // update mode = EDIT
                    _updateMode = _dispMode;

                    // display mode
                    _dispMode = DispMode.Confirm;
                }

                SetControlModeView();
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

        #region DeleteButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： DeleteButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!DeleteUpdateCheck())
                {
                    MessageForm.Show2(MessageForm.DispModeType.Error, "既に処理されているため、変更・削除できません。");
                    return;
                }

                // データを削除する際に、警告を表示する。
                if (MessageForm.Show2(MessageForm.DispModeType.Question, "表示されているデータが削除されます。よろしいですか？")
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    IDeleteBtnClickALInput alInput = new DeleteBtnClickALInput();
                    alInput.MaeukekinSyogoNo1 = _maeukekinSyogoNo1;
                    alInput.MaeukekinSyogoNo2 = _maeukekinSyogoNo2;
                    IDeleteBtnClickALOutput alOutput = new DeleteBtnClickApplicationLogic().Execute(alInput);

                    if (alOutput.Result)
                    {
                        MaeukekinListForm form = new MaeukekinListForm();
                        Program.mForm.ShowForm(form);
                    }
                    else
                    {
                        MessageForm.Show2(MessageForm.DispModeType.Error,
                            string.Format("該当するデータは登録されていません。[前受金No：{0}]",
                            new string[] { _maeukekinSyogoNo1 + "-" + _maeukekinSyogoNo2 }));
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

        #region ReInputButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： ReInputButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void ReInputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (_updateMode == DispMode.Add)
                {
                    _dispMode = DispMode.Add;
                }
                else if (_updateMode == DispMode.Edit)
                {
                    _dispMode = DispMode.Edit;
                }

                SetControlModeView();
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

        #region DecisionButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： DecisionButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DecisionButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                DoUpdate();
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

        #region CloseButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： CloseButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void CloseButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (_dispMode != DispMode.Detail)
                {
                    if (!CheckEdit())
                    {
                        if (MessageForm.Show2(MessageForm.DispModeType.Question, "編集内容が破棄されます。よろしいですか？")
                                == System.Windows.Forms.DialogResult.Yes)
                        {
                            MaeukekinListForm frm = new MaeukekinListForm();
                            Program.mForm.ShowForm(frm);
                        }
                    }
                    else
                    {
                        MaeukekinListForm frm = new MaeukekinListForm();
                        Program.mForm.ShowForm(frm);
                    }
                }
                else
                {
                    MaeukekinListForm frm = new MaeukekinListForm();
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

        #region kisaiAriRadioButton_CheckedChanged
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kisaiAriRadioButton_CheckedChanged
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kisaiAriRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (kisaiAriRadioButton.Checked)
                {
                    maeukeNoTextBox.Enabled = true;
                }
                else
                {
                    maeukeNoTextBox.Enabled = false;
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

        #region MaeukekinShosaiForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： MaeukekinShosaiForm_KeyDown
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void MaeukekinShosaiForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyData)
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

        #region NumberKeyPress
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： NumberKeyPress
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/22  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void NumberKeyPress(object sender, KeyPressEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
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
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            IFormLoadALInput alInput    = new FormLoadALInput();
            alInput.MaeukekinSyogoNo1   = _maeukekinSyogoNo1;
            alInput.MaeukekinSyogoNo2   = _maeukekinSyogoNo2;
            alInput.NameKbn             = Utility.Constants.NameKbnConstant.NAME_KBN_006;
            IFormLoadALOutput alOutput  = new FormLoadApplicationLogic().Execute(alInput);

            Utility.Utility.SetComboBoxList(kinyuNmComboBox, alOutput.NameMstDT, "NAME", "NAMECD", true);

            if (alOutput.MaeukekinTblDT != null && alOutput.MaeukekinTblDT.Count > 0)
            {
                SetValues(alOutput.MaeukekinTblDT[0]);

                _dispDT = alOutput.MaeukekinTblDT;
            }

            SetControlModeView();
        }
        #endregion

        #region SetValues
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： SetValues
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetValues(MaeukekinTblDataSet.MaeukekinTblRow row)
        {
            if (row.MaeukekinSyogoNo1 == "0")
            {
                // 振込用紙記載No
                kisaiAriRadioButton.Checked = true;
            }
            else if (row.MaeukekinSyogoNo1 == "1")
            {
                // 自動採番
                kisaiNashiRadioButton.Checked = true;
            }

            // 振込用紙記載No
            maeukeNoTextBox.Text = row.MaeukekinSyogoNo2;

            // 金融機関
            kinyuNmComboBox.SelectedValue = row.MaeukekinKinyukikan.ToString();

            // 入金日
            nyukinDtTextBox.Text = row.MaeukekinNyukinDt;

            // 入金額
            nyukingakuTextBox.Text = row.MaeukekinNyukinAmt.ToString("N0");

            // 振込人
            furikomiNmTextBox.Text = row.MaeukekinFurikomininNm;

            // 振込人カナ
            furikomiKanaTextBox.Text = row.MaeukekinFurikomininKana;

            // 備考
            bikoTextBox.Text = row.MaeukekinBiko;

            // 売上日付
            uriageDtTextBox.Text = row.MaeukekinUriageDt;

            // 取下日付
            torisageDtTextBox.Text = row.MaeukekinTorisageDt;

            // 検査依頼法定区分
            hoteiKbnTextBox.Text = row.MaeukekinKensaIraiHoteiKbn;

            // 検査依頼保健所コード
            hokenjoCdTextBox.Text = row.MaeukekinKensaIraiHokenjoCd;

            // 検査依頼年度
            iraiNendoTextBox.Text = row.MaeukekinKensaIraiNendo;

            // 検査依頼連番
            iraiRenbanTextBox.Text = row.MaeukekinKensaIraiRenban;

            // 強制売上金額
            kyoseiUriGakuTextBox.Text = row.MaeukekinKyoseiUriageAmt.ToString("N0");

            // 強制売上フラグ
            if (row.MaeukekinKyoseiUriageFlg == "1") 
            {
                kyoseiUriCheckBox.Checked = true;
            }
            else if (row.MaeukekinKyoseiUriageFlg == "0")
            {
                kyoseiUriCheckBox.Checked = false;
            }

            // 入金取扱日付
            nyukinToriatukaiDtTextBox.Text = row.MaeukekinNyukintoriatukaiDt;

            // 一部返金日
            henkinDtTextBox.Text = row.MaeukekinIchibuHenkinDt;

            // 一部返金額
            henkingakuTextBox.Text = row.MaeukekinIchibuHenkinAmt.ToString("N0");

            // 残金
            zankinTextBox.Text = row.MaeukekinZanAmt.ToString("N0");

            // 浄化槽台帳保健所コード
            daichoHokenjoTextBox.Text = row.IsMaeukekinJokasoHokenjoCdNull() ? string.Empty : row.MaeukekinJokasoHokenjoCd;

            // 浄化槽台帳登録年月
            daichoNendoTextBox.Text = row.IsMaeukekinJokasoTorokuNengetsuNull() ? string.Empty : row.MaeukekinJokasoTorokuNengetsu;

            // 浄化槽台帳連番
            daichoRenbanTextBox.Text = row.IsMaeukekinJokasoRenbanNull() ? string.Empty : row.MaeukekinJokasoRenban;
        }
        #endregion

        #region SetControlModeView
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoFormLoad
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetControlModeView()
        {
            switch (_dispMode)
            {
                case DispMode.Add:

                    // 前受金No区分
                    kisaiAriRadioButton.Enabled = true;
                    kisaiNashiRadioButton.Enabled = true;

                    // 前受金No
                    maeukeNoTextBox.ReadOnly = false;

                    // 金融機関
                    kinyuNmComboBox.Enabled = true;

                    // 入金日
                    nyukinDtTextBox.ReadOnly = false;

                    // 入金額
                    nyukingakuTextBox.ReadOnly = false;

                    // 振込人名
                    furikomiNmTextBox.ReadOnly = false;

                    // 振込人カナ
                    furikomiKanaTextBox.ReadOnly = false;

                    // 備考
                    bikoTextBox.ReadOnly = false;

                    // 売上日付
                    uriageDtTextBox.ReadOnly = false;

                    // 取下日付
                    torisageDtTextBox.ReadOnly = false;

                    // 法定区分
                    hoteiKbnTextBox.ReadOnly = true;

                    // 保健所コード
                    hokenjoCdTextBox.ReadOnly = true;

                    // 依頼年度
                    iraiNendoTextBox.ReadOnly = true;

                    // 依頼連番
                    iraiRenbanTextBox.ReadOnly = true;

                    // 保健所コード
                    daichoHokenjoTextBox.ReadOnly = true;

                    // 登録年月
                    daichoNendoTextBox.ReadOnly = true;

                    // 台帳連番
                    daichoRenbanTextBox.ReadOnly = true;

                    // 強制売上
                    kyoseiUriCheckBox.Enabled = true;
                    kyoseiUriGakuTextBox.ReadOnly = false;

                    // 入金取扱日
                    nyukinToriatukaiDtTextBox.ReadOnly = false;

                    // 一部返金日
                    henkinDtTextBox.ReadOnly = false;

                    // 一部返金額
                    henkingakuTextBox.ReadOnly = false;

                    // 残金
                    zankinTextBox.ReadOnly = false;

                    // 登録ボタン 
                    entryButton.Visible = true;

                    // 変更ボタン 
                    changeButton.Visible = false;

                    // 削除ボタン
                    deleteButton.Visible = false;

                    // 再入力ボタン
                    reInputButton.Visible = false;

                    // 確定ボタン
                    decisionButton.Visible = false;

                    // 閉じるボタン
                    closeButton.Visible = true;

                    this.Text = "前受金登録";
                    Program.mForm.Text = "前受金登録";

                    break;

                case DispMode.Edit:

                    // 前受金No区分
                    kisaiAriRadioButton.Enabled = false;
                    kisaiNashiRadioButton.Enabled = false;

                    // 前受金No
                    maeukeNoTextBox.ReadOnly = true;

                    // 金融機関
                    kinyuNmComboBox.Enabled = true;

                    // 入金日
                    nyukinDtTextBox.ReadOnly = false;

                    // 入金額
                    nyukingakuTextBox.ReadOnly = false;

                    // 振込人名
                    furikomiNmTextBox.ReadOnly = false;

                    // 振込人カナ
                    furikomiKanaTextBox.ReadOnly = false;

                    // 備考
                    bikoTextBox.ReadOnly = false;

                    // 売上日付
                    uriageDtTextBox.ReadOnly = false;

                    // 取下日付
                    torisageDtTextBox.ReadOnly = false;

                    // 法定区分
                    hoteiKbnTextBox.ReadOnly = true;

                    // 保健所コード
                    hokenjoCdTextBox.ReadOnly = true;

                    // 依頼年度
                    iraiNendoTextBox.ReadOnly = true;

                    // 依頼連番
                    iraiRenbanTextBox.ReadOnly = true;

                    // 保健所コード
                    daichoHokenjoTextBox.ReadOnly = true;

                    // 登録年月
                    daichoNendoTextBox.ReadOnly = true;

                    // 台帳連番
                    daichoRenbanTextBox.ReadOnly = true;

                    // 強制売上
                    kyoseiUriCheckBox.Enabled = true;
                    kyoseiUriGakuTextBox.ReadOnly = false;

                    // 入金取扱日
                    nyukinToriatukaiDtTextBox.ReadOnly = false;

                    // 一部返金日
                    henkinDtTextBox.ReadOnly = false;

                    // 一部返金額
                    henkingakuTextBox.ReadOnly = false;

                    // 残金
                    zankinTextBox.ReadOnly = false;

                    // 登録ボタン 
                    entryButton.Visible = false;

                    // 変更ボタン 
                    changeButton.Visible = true;

                    // 削除ボタン
                    deleteButton.Visible = false;

                    // 再入力ボタン
                    reInputButton.Visible = false;

                    // 確定ボタン
                    decisionButton.Visible = false;

                    // 閉じるボタン
                    closeButton.Visible = true;

                    this.Text = "前受金変更";
                    Program.mForm.Text = "前受金変更";

                    break;

                case DispMode.Detail:

                    // 前受金No区分
                    kisaiAriRadioButton.Enabled = false;
                    kisaiNashiRadioButton.Enabled = false;

                    // 前受金No
                    maeukeNoTextBox.ReadOnly = true;

                    // 金融機関
                    kinyuNmComboBox.Enabled = false;

                    // 入金日
                    nyukinDtTextBox.ReadOnly = true;

                    // 入金額
                    nyukingakuTextBox.ReadOnly = true;

                    // 振込人名
                    furikomiNmTextBox.ReadOnly = true;

                    // 振込人カナ
                    furikomiKanaTextBox.ReadOnly = true;

                    // 備考
                    bikoTextBox.ReadOnly = true;

                    // 売上日付
                    uriageDtTextBox.ReadOnly = true;

                    // 取下日付
                    torisageDtTextBox.ReadOnly = true;

                    // 法定区分
                    hoteiKbnTextBox.ReadOnly = true;

                    // 保健所コード
                    hokenjoCdTextBox.ReadOnly = true;

                    // 依頼年度
                    iraiNendoTextBox.ReadOnly = true;

                    // 依頼連番
                    iraiRenbanTextBox.ReadOnly = true;

                    // 保健所コード
                    daichoHokenjoTextBox.ReadOnly = true;

                    // 登録年月
                    daichoNendoTextBox.ReadOnly = true;

                    // 台帳連番
                    daichoRenbanTextBox.ReadOnly = true;

                    // 強制売上
                    kyoseiUriCheckBox.Enabled = false;
                    kyoseiUriGakuTextBox.ReadOnly = true;

                    // 入金取扱日
                    nyukinToriatukaiDtTextBox.ReadOnly = true;

                    // 一部返金日
                    henkinDtTextBox.ReadOnly = true;

                    // 一部返金額
                    henkingakuTextBox.ReadOnly = true;

                    // 残金
                    zankinTextBox.ReadOnly = true;

                    // 登録ボタン 
                    entryButton.Visible = false;

                    // 変更ボタン 
                    changeButton.Visible = true;

                    // 削除ボタン
                    deleteButton.Visible = true;

                    // 再入力ボタン
                    reInputButton.Visible = false;

                    // 確定ボタン
                    decisionButton.Visible = false;

                    // 閉じるボタン
                    closeButton.Visible = true;

                    this.Text = "前受金詳細";
                    Program.mForm.Text = "前受金詳細";

                    break;

                case DispMode.Confirm:

                    // 前受金No区分
                    kisaiAriRadioButton.Enabled = false;
                    kisaiNashiRadioButton.Enabled = false;

                    // 前受金No
                    maeukeNoTextBox.ReadOnly = true;

                    // 金融機関
                    kinyuNmComboBox.Enabled = false;

                    // 入金日
                    nyukinDtTextBox.ReadOnly = true;

                    // 入金額
                    nyukingakuTextBox.ReadOnly = true;

                    // 振込人名
                    furikomiNmTextBox.ReadOnly = true;

                    // 振込人カナ
                    furikomiKanaTextBox.ReadOnly = true;

                    // 備考
                    bikoTextBox.ReadOnly = true;

                    // 売上日付
                    uriageDtTextBox.ReadOnly = true;

                    // 取下日付
                    torisageDtTextBox.ReadOnly = true;

                    // 法定区分
                    hoteiKbnTextBox.ReadOnly = true;

                    // 保健所コード
                    hokenjoCdTextBox.ReadOnly = true;

                    // 依頼年度
                    iraiNendoTextBox.ReadOnly = true;

                    // 依頼連番
                    iraiRenbanTextBox.ReadOnly = true;

                    // 保健所コード
                    daichoHokenjoTextBox.ReadOnly = true;

                    // 登録年月
                    daichoNendoTextBox.ReadOnly = true;

                    // 台帳連番
                    daichoRenbanTextBox.ReadOnly = true;

                    // 強制売上
                    kyoseiUriCheckBox.Enabled = false;
                    kyoseiUriGakuTextBox.ReadOnly = true;

                    // 入金取扱日
                    nyukinToriatukaiDtTextBox.ReadOnly = true;

                    // 一部返金日
                    henkinDtTextBox.ReadOnly = true;

                    // 一部返金額
                    henkingakuTextBox.ReadOnly = true;

                    // 残金
                    zankinTextBox.ReadOnly = true;

                    // 登録ボタン
                    entryButton.Visible = false;

                    // 変更ボタン
                    changeButton.Visible = false;

                    // 削除ボタン
                    deleteButton.Visible = false;

                    // 再入力ボタン 
                    reInputButton.Visible = true;

                    // 確定ボタン　
                    decisionButton.Visible = true;

                    // 閉じるボタン 
                    closeButton.Visible = true;

                    this.Text = "前受金入力確認";
                    Program.mForm.Text = "前受金入力確認";

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region DoUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoUpdate()
        {
            MaeukekinTblDataSet.MaeukekinTblDataTable updateDT = new MaeukekinTblDataSet.MaeukekinTblDataTable();

            if (_updateMode == DispMode.Add)
            {
                updateDT = CreateDataInsert();
            }
            else
            {
                updateDT = CreateDataUpdate(_dispDT);
            }

            IDecisionBtnClickALInput alInput = new DecisionBtnClickALInput();
            alInput.DispMode = _updateMode;
            alInput.MaeukekinTblDT = updateDT;
            IDecisionBtnClickALOutput alOutput = new DecisionBtnClickApplicationLogic().Execute(alInput);

            if (!string.IsNullOrEmpty(alOutput.ErrMessage))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, alOutput.ErrMessage);
                return;
            }
            else
            {
                MaeukekinListForm frm = new MaeukekinListForm();
                Program.mForm.ShowForm(frm);
            }
        }
        #endregion

        #region CreateDataInsert
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateDataInsert
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private MaeukekinTblDataSet.MaeukekinTblDataTable CreateDataInsert()
        {
            DateTime now = Common.Common.GetCurrentTimestamp();

            MaeukekinTblDataSet.MaeukekinTblDataTable insertDT = new MaeukekinTblDataSet.MaeukekinTblDataTable();

            MaeukekinTblDataSet.MaeukekinTblRow insertRow = insertDT.NewMaeukekinTblRow();

            insertRow.MaeukekinSyogoNo1 = kisaiAriRadioButton.Checked ? "0" : "1";

            // 前受照合番号２
            if (kisaiAriRadioButton.Checked)
            {
                insertRow.MaeukekinSyogoNo2 = maeukeNoTextBox.Text;
            }
            else
            {
                insertRow.MaeukekinSyogoNo2 = Common.Common.GetSaibanRenban(now.Year.ToString(), Utility.Constants.SaibanKbnConstant.SAIBAN_KBN_03);
            }

            // 入金先金融機関
            insertRow.MaeukekinKinyukikan = kinyuNmComboBox.SelectedValue.ToString();

            // 入金日付
            insertRow.MaeukekinNyukinDt = nyukinDtTextBox.Text;

            // 入金額
            insertRow.MaeukekinNyukinAmt = Convert.ToDecimal(nyukingakuTextBox.Text);

            // 振込人名
            insertRow.MaeukekinFurikomininNm = furikomiNmTextBox.Text.Trim();

            // 振込人名カナ
            insertRow.MaeukekinFurikomininKana = furikomiKanaTextBox.Text.Trim();

            // 備考
            insertRow.MaeukekinBiko = bikoTextBox.Text.Trim();

            // 売上日付
            insertRow.MaeukekinUriageDt = uriageDtTextBox.Text;

            // 取下日付
            insertRow.MaeukekinTorisageDt = torisageDtTextBox.Text;

            // 検査依頼法定区分
            insertRow.MaeukekinKensaIraiHoteiKbn = hoteiKbnTextBox.Text;

            // 検査依頼保健所コード
            insertRow.MaeukekinKensaIraiHokenjoCd = hokenjoCdTextBox.Text;

            // 検査依頼年度
            insertRow.MaeukekinKensaIraiNendo = iraiNendoTextBox.Text;

            // 検査依頼連番
            insertRow.MaeukekinKensaIraiRenban = iraiRenbanTextBox.Text;

            // 強制売上金額
            insertRow.MaeukekinKyoseiUriageAmt = string.IsNullOrEmpty(kyoseiUriGakuTextBox.Text) ? 0 : Convert.ToDecimal(kyoseiUriGakuTextBox.Text);

            // 強制売上フラグ
            insertRow.MaeukekinKyoseiUriageFlg = (kyoseiUriCheckBox.Checked) ? "1" : "0";

            // 入金取扱日付
            insertRow.MaeukekinNyukintoriatukaiDt = nyukinToriatukaiDtTextBox.Text;

            // 一部返金日
            insertRow.MaeukekinIchibuHenkinDt = henkinDtTextBox.Text;

            // 一部返金額
            insertRow.MaeukekinIchibuHenkinAmt = string.IsNullOrEmpty(henkingakuTextBox.Text) ? 0 : Convert.ToDecimal(henkingakuTextBox.Text);

            // 残金
            insertRow.MaeukekinZanAmt = string.IsNullOrEmpty(zankinTextBox.Text) ? 0 : Convert.ToDecimal(zankinTextBox.Text);

            insertRow.InsertDt = now;
            insertRow.InsertTarm = pcUpdate;
            insertRow.InsertUser = loginUser;
            insertRow.UpdateDt = now;
            insertRow.UpdateTarm = pcUpdate;
            insertRow.UpdateUser = loginUser;

            // 行を挿入
            insertDT.AddMaeukekinTblRow(insertRow);

            // 行の状態を設定
            insertRow.AcceptChanges();

            // 行の状態を設定（新規）
            insertRow.SetAdded();

            return insertDT;
        }
        #endregion

        #region CreateDataUpdate
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CreateDataUpdate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private MaeukekinTblDataSet.MaeukekinTblDataTable CreateDataUpdate(
            MaeukekinTblDataSet.MaeukekinTblDataTable dataTable)
        {
            // 入金先金融機関
            dataTable[0].MaeukekinKinyukikan = kinyuNmComboBox.SelectedValue.ToString();

            // 入金日付
            dataTable[0].MaeukekinNyukinDt = nyukinDtTextBox.Text;

            // 入金額
            dataTable[0].MaeukekinNyukinAmt = Convert.ToDecimal(nyukingakuTextBox.Text);

            // 振込人名
            dataTable[0].MaeukekinFurikomininNm = furikomiNmTextBox.Text.Trim();

            // 振込人名カナ
            dataTable[0].MaeukekinFurikomininKana = furikomiKanaTextBox.Text.Trim();

            // 備考
            dataTable[0].MaeukekinBiko = bikoTextBox.Text.Trim();

            // 売上日付
            dataTable[0].MaeukekinUriageDt = uriageDtTextBox.Text;

            // 取下日付
            dataTable[0].MaeukekinTorisageDt = torisageDtTextBox.Text;

            // 検査依頼法定区分
            dataTable[0].MaeukekinKensaIraiHoteiKbn = hoteiKbnTextBox.Text;

            // 検査依頼保健所コード
            dataTable[0].MaeukekinKensaIraiHokenjoCd = hokenjoCdTextBox.Text;

            // 検査依頼年度
            dataTable[0].MaeukekinKensaIraiNendo = iraiNendoTextBox.Text;

            // 検査依頼連番
            dataTable[0].MaeukekinKensaIraiRenban = iraiRenbanTextBox.Text;

            // 強制売上金額
            dataTable[0].MaeukekinKyoseiUriageAmt = Convert.ToDecimal(kyoseiUriGakuTextBox.Text);

            // 強制売上フラグ
            dataTable[0].MaeukekinKyoseiUriageFlg = (kyoseiUriCheckBox.Checked) ? "1" : "0";

            // 入金取扱日付
            dataTable[0].MaeukekinNyukintoriatukaiDt = nyukinToriatukaiDtTextBox.Text;

            // 一部返金日
            dataTable[0].MaeukekinIchibuHenkinDt = henkinDtTextBox.Text;

            // 一部返金額
            dataTable[0].MaeukekinIchibuHenkinAmt = Convert.ToDecimal(henkingakuTextBox.Text);

            // 残金
            dataTable[0].MaeukekinZanAmt = Convert.ToDecimal(zankinTextBox.Text);

            return dataTable;
        }
        #endregion

        #region UnitCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： UnitCheck
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool UnitCheck()
        {
            StringBuilder errMess = new StringBuilder();

            // 前受金No 
            if (kisaiAriRadioButton.Checked && !string.IsNullOrEmpty(maeukeNoTextBox.Text) && maeukeNoTextBox.Text.Length != 6)
            {
                errMess.Append("前受金は6桁で入力して下さい。\r\n");
            }

            if (kisaiAriRadioButton.Checked && string.IsNullOrEmpty(maeukeNoTextBox.Text))
            {
                errMess.Append("振込用紙記載Noを入力してくだいさい。\r\n");
            }
            
            // 金融機関
            if (kinyuNmComboBox.SelectedIndex == 0 || kinyuNmComboBox.SelectedIndex == -1)
            {
                errMess.Append("必須項目：金融機関が選択されていません。\r\n");
            }

            // 入金日
            if (string.IsNullOrEmpty(nyukinDtTextBox.Text))
            {
                errMess.Append("必須項目：入金日が入力されていません。\r\n");
            }
            else
            {
                if (nyukinDtTextBox.Text.Length != 8)
                {
                    errMess.Append("入金日は8桁で入力して下さい。\r\n");
                }
            }

            // 入金額
            if (string.IsNullOrEmpty(nyukingakuTextBox.Text.Trim()))
            {
                errMess.Append("必須項目：入金額が入力されていません。\r\n");
            }

            // 振込人名
            if (string.IsNullOrEmpty(furikomiNmTextBox.Text.Trim()))
            {
                errMess.Append("必須項目：振込人が入力されていません。\r\n");
            }
            else
            {
                if (furikomiNmTextBox.Text.Trim().Length > 20)
                {
                    errMess.Append("振込人名は20文字以下で入力して下さい。\r\n");
                }
            }

            // 振込人名カナ
            if (string.IsNullOrEmpty(furikomiKanaTextBox.Text.Trim()))
            {
                errMess.Append("必須項目：振込人カナが入力されていません。\r\n");
            }
            else
            {
                if (furikomiKanaTextBox.Text.Trim().Length > 20)
                {
                    errMess.Append("振込人名カナは20文字以下で入力して下さい。\r\n");
                }
            }

            // 備考
            if (bikoTextBox.Text.Trim().Length > 40)
            {
                errMess.Append("備考は40文字以下で入力して下さい。\r\n");
            }

            // 売上日付
            if (!string.IsNullOrEmpty(uriageDtTextBox.Text) && uriageDtTextBox.Text.Length != 8)
            {
                errMess.Append("売上日付は8桁で入力して下さい。\r\n");
            }

            // 取下日付
            if (!string.IsNullOrEmpty(torisageDtTextBox.Text) && torisageDtTextBox.Text.Length != 8)
            {
                errMess.Append("取下日付は8桁で入力して下さい。\r\n");
            }

            // 強制売上
            if (kyoseiUriCheckBox.Checked && string.IsNullOrEmpty(kyoseiUriGakuTextBox.Text))
            {
                errMess.Append("必須項目：強制売上金額が入力されていません。");
            }

            // 入金取扱日付
            if (!string.IsNullOrEmpty(nyukinToriatukaiDtTextBox.Text) && nyukinToriatukaiDtTextBox.Text.Length != 8)
            {
                errMess.Append("入金取扱日付は8桁で入力して下さい。\r\n");
            }

            // 一部返金日
            if (!string.IsNullOrEmpty(henkinDtTextBox.Text) && henkinDtTextBox.Text.Length != 8)
            {
                errMess.Append("一部返金日は8桁で入力して下さい。\r\n");
            }

            if (!string.IsNullOrEmpty(errMess.ToString()))
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, errMess.ToString());
                return false;
            }

            return true;
        }
        #endregion

        #region CheckEdit
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CheckEdit
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/21  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckEdit()
        {
            //check edit mode add
            if (string.IsNullOrEmpty(_maeukekinSyogoNo1) && string.IsNullOrEmpty(_maeukekinSyogoNo2))
            {
                if (maeukeNoTextBox.Text != string.Empty
                    || nyukinDtTextBox.Text != string.Empty
                    || furikomiNmTextBox.Text != string.Empty
                    || furikomiKanaTextBox.Text != string.Empty
                    || bikoTextBox.Text != string.Empty
                    || uriageDtTextBox.Text != string.Empty
                    || torisageDtTextBox.Text != string.Empty
                    || kyoseiUriGakuTextBox.Text != string.Empty
                    || nyukinToriatukaiDtTextBox.Text != string.Empty
                    || henkinDtTextBox.Text != string.Empty
                    || henkingakuTextBox.Text != string.Empty
                    || zankinTextBox.Text != string.Empty
                    )
                {
                    return false;
                }
            }

            if (_dispDT != null && _dispDT.Count > 0)
            {
                if (maeukeNoTextBox.Text != _dispDT[0].MaeukekinSyogoNo2
                        || nyukinDtTextBox.Text != _dispDT[0].MaeukekinNyukinDt
                        || furikomiNmTextBox.Text != _dispDT[0].MaeukekinFurikomininNm
                        || furikomiKanaTextBox.Text != _dispDT[0].MaeukekinFurikomininKana
                        || bikoTextBox.Text != _dispDT[0].MaeukekinBiko
                        || uriageDtTextBox.Text != _dispDT[0].MaeukekinUriageDt
                        || torisageDtTextBox.Text != _dispDT[0].MaeukekinTorisageDt
                        || kyoseiUriGakuTextBox.Text.Equals(_dispDT[0].MaeukekinKyoseiUriageAmt.ToString())
                        || nyukinToriatukaiDtTextBox.Text != _dispDT[0].MaeukekinNyukintoriatukaiDt
                        || henkinDtTextBox.Text!= _dispDT[0].MaeukekinIchibuHenkinDt.Trim()
                        || henkingakuTextBox.Text.Equals(_dispDT[0].MaeukekinIchibuHenkinAmt.ToString())
                        || zankinTextBox.Text.Equals(_dispDT[0].MaeukekinZanAmt.ToString())
                    )
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region DeleteUpdateCheck
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DeleteCheck
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/23  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool DeleteUpdateCheck()
        {
            // 検査依頼法定区分
            if (!string.IsNullOrEmpty(hoteiKbnTextBox.Text.Trim()))
            {
                return false;
            }

            // 検査依頼保健所コード
            if (!string.IsNullOrEmpty(hokenjoCdTextBox.Text.Trim()))
            {
                return false;
            }

            // 検査依頼年度
            if (!string.IsNullOrEmpty(iraiNendoTextBox.Text.Trim()))
            {
                return false;
            }

            // 検査依頼連番
            if (!string.IsNullOrEmpty(iraiRenbanTextBox.Text.Trim()))
            {
                return false;
            }

            // 浄化槽台帳保健所コード
            if (!string.IsNullOrEmpty(daichoHokenjoTextBox.Text.Trim()))
            {
                return false;
            }

            // 浄化槽台帳登録年月
            if (!string.IsNullOrEmpty(daichoNendoTextBox.Text.Trim()))
            {
                return false;
            }

            // 浄化槽台帳連番
            if (!string.IsNullOrEmpty(daichoRenbanTextBox.Text.Trim()))
            {
                return false;
            }

            return true;
        }
        #endregion

        #region CheckExist
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CheckExist
        /// <summary>
        /// 
        /// </summary>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/29  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckExist()
        {
            IEntryBtnClickBLInput alInput   = new EntryBtnClickBLInput();
            alInput.MaeukekinSyogoNo1       = "0";
            alInput.MaeukekinSyogoNo2       = maeukeNoTextBox.Text;
            IEntryBtnClickBLOutput alOutput = new EntryBtnClickBusinessLogic().Execute(alInput);

            if (!alOutput.Result)
            {
                MessageForm.Show2(MessageForm.DispModeType.Error, string.Format("既に登録済みです。[前受金No：{0}-{1}]",
                                    new string[] { alInput.MaeukekinSyogoNo1, alInput.MaeukekinSyogoNo2 }));
                return false;
            }

            return true;
        }
        #endregion

        #endregion

    }
    #endregion
}
