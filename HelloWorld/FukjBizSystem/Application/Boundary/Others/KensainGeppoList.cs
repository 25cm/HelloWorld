using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Others.KensainGeppoList;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Others
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensainGeppoListForm
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
    public partial class KensainGeppoListForm : Form
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
        /// DateTime today
        /// </summary>
        private DateTime today = Common.Common.GetCurrentTimestamp();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： KensainGeppoListForm
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
        public KensainGeppoListForm()
        {
            InitializeComponent();

            this.geppoListDataGridView.Rows.Add("筑　後", "001", "原　賀一","7条", "",  "","", "", "");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "50", "46", "32", "", "", "", "", "", "", "", "", "", "128", "788,400");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "50", "46", "32", "", "", "", "", "", "", "", "", "", "128", "788,400");
            this.geppoListDataGridView.Rows.Add("", "002", "椛島和寿", "7条", "28", "16", "20", "", "", "", "", "", "", "", "", "", "64", "582,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "134", "117", "123", "", "", "", "", "", "", "", "", "", "374", "2,123,800");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "162", "133", "143", "", "", "", "", "", "", "", "", "", "438", "2,706,300");
            this.geppoListDataGridView.Rows.Add("", "003", "野上裕文", "7条", "26", "3", "2", "", "", "", "", "", "", "", "", "", "31", "290,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "151", "150", "138", "", "", "", "", "", "", "", "", "", "439", "2,270,600");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "177", "153", "140", "", "", "", "", "", "", "", "", "", "470", "2,561,100");
            this.geppoListDataGridView.Rows.Add("", "005", "佐藤崇", "7条", "26", "3", "2", "", "", "", "", "", "", "", "", "", "31", "290,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "151", "150", "138", "", "", "", "", "", "", "", "", "", "439", "2,270,600");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "177", "153", "140", "", "", "", "", "", "", "", "", "", "470", "2,561,100");
            this.geppoListDataGridView.Rows.Add("福　岡", "013", "古賀大智", "7条", "28", "16", "20", "", "", "", "", "", "", "", "", "", "64", "582,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "134", "117", "123", "", "", "", "", "", "", "", "", "", "374", "2,123,800");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "162", "133", "143", "", "", "", "", "", "", "", "", "", "438", "2,706,300");
            this.geppoListDataGridView.Rows.Add("", "015", "安部隆", "7条", "28", "16", "20", "", "", "", "", "", "", "", "", "", "64", "582,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "134", "117", "123", "", "", "", "", "", "", "", "", "", "374", "2,123,800");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "162", "133", "143", "", "", "", "", "", "", "", "", "", "438", "2,706,300");
            this.geppoListDataGridView.Rows.Add("", "017", "塚中光一", "7条", "28", "16", "20", "", "", "", "", "", "", "", "", "", "64", "582,500");
            this.geppoListDataGridView.Rows.Add("", "", "", "11条", "134", "117", "123", "", "", "", "", "", "", "", "", "", "374", "2,123,800");
            this.geppoListDataGridView.Rows.Add("", "", "", "合計", "162", "133", "143", "", "", "", "", "", "", "", "", "", "438", "2,706,300");
        }
        #endregion

        #region イベント

        #region KensainGeppoListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensainGeppoListForm_Load
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
        private void KensainGeppoListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                SetDefaultValues();

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
                    this.jokyoListPanel,
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

        #region kensaKensuButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： kensaKensuButton_Click
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
        private void kensaKensuButton_Click(object sender, EventArgs e)
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

        #region gaikanGeppoButton_Click
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： gaikanGeppoButton_Click
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
        private void gaikanGeppoButton_Click(object sender, EventArgs e)
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

        #region KensainGeppoListForm_KeyDown
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensainGeppoListForm_KeyDown
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
        private void KensainGeppoListForm_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                switch (e.KeyData)
                {
                    case Keys.F1:
                        kensaKensuButton.PerformClick();
                        break;

                    case Keys.F2:
                        gaikanGeppoButton.PerformClick();
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
            //fileKanriTblDataSet.Clear();

            IFormLoadALInput alInput = new FormLoadALInput();
            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            // 支所
            Utility.Utility.SetComboBoxList(shisyoComboBox, alOutput.ShishoMstDT, "ShishoNm", "ShishoCd", true);

            // Display data
            //fileKanriTblDataSet.Merge(alOutput.FileKanriTblKensakuDT);

            //if (alOutput.KensaKeihatsuSuishinListDT == null || alOutput.KensaKeihatsuSuishinListDT.Count == 0)
            //{
            //    srhListCountLabel.Text = "0件";
            //}
            //else
            //{
            //    srhListCountLabel.Text = alOutput.KensaKeihatsuSuishinListDT.Count.ToString() + "件";
            //}

            this._searchShowFlg = true;
            this._defaultSearchPanelTop = this.searchPanel.Top;
            this._defaultSearchPanelHeight = this.searchPanel.Height;
            this._defaultListPanelTop = this.jokyoListPanel.Top;
            this._defaultListPanelHeight = this.jokyoListPanel.Height;
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
            //fileKanriTblDataSet.Clear();

            //IKensakuBtnClickALInput alInput = new KensakuBtnClickALInput();

            //// Create conditions
            //MakeSearchCond(alInput);

            //IKensakuBtnClickALOutput alOutput = new KensakuBtnClickApplicationLogic().Execute(alInput);

            //// Display data
            ////fileKanriTblDataSet.Merge(alOutput.FileKanriTblKensakuDT);

            //if (alOutput.KensaKeihatsuSuishinListDT == null || alOutput.KensaKeihatsuSuishinListDT.Count == 0)
            //{
            //    srhListCountLabel.Text = "0件";

            //    // 保健所一覧 : リスト数 = 0
            //    MessageForm.Show2(MessageForm.DispModeType.Infomation, "表示データがありません。");
            //}
            //else
            //{
            //    srhListCountLabel.Text = alOutput.KensaKeihatsuSuishinListDT.Count.ToString() + "件";
            //}
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

            // 対象範囲（開始＆終了）
            if (string.IsNullOrEmpty(taisyoYMFromTextBox.Text))
            {
                errMess.Append("必須項目：対象範囲（開始）が入力されていません。\r\n");
            }
            else if (string.IsNullOrEmpty(taisyoYMToTextBox.Text))
            {
                errMess.Append("必須項目：対象範囲（終了）が入力されていません。\r\n");
            }
            else
            {
                if (Convert.ToInt32(taisyoYMFromTextBox.Text) > Convert.ToInt32(taisyoYMToTextBox.Text))
                {
                    errMess.Append("範囲指定が正しくありません。対象範囲の大小関係を確認してください。\r\n");
                }
                else
                {
                    int yearFrom = Convert.ToInt32(taisyoYMFromTextBox.Text.Substring(0, 4));
                    int yearTo = Convert.ToInt32(taisyoYMToTextBox.Text.Substring(0, 4));
                    int monthFrom = Convert.ToInt32(taisyoYMFromTextBox.Text.Substring(4, 2));
                    int monthTo = Convert.ToInt32(taisyoYMToTextBox.Text.Substring(4, 2));

                    if ((yearTo * 12 + monthTo) - (yearFrom * 12 + monthFrom) > 11)
                    {
                        errMess.Append("対象範囲は1年を超えて指定できません。\r\n");
                    }
                }
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
            // 対象範囲
            if (today.Month < 4)
            {
                taisyoYMFromTextBox.Text = today.Year - 1 + "04";
            }
            else
            {
                taisyoYMFromTextBox.Text = today.Year + "04";
            }

            string month = (today.Month < 10) ? ("0" + (today.Month - 1).ToString()) : (today.Month - 1).ToString();

            taisyoYMToTextBox.Text = today.Year + string.Empty + month;

            // 支所
            shisyoComboBox.SelectedIndex = -1;

            // 集計処理区分/未作成月のみ集計
            misakuseiRadioButton.Checked = true;
        }
        #endregion

        #endregion



    }
    #endregion
}
