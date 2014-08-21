using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Boundary.Others
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： KensainSyuhoListForm
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2014/08/14  DatNT　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public partial class KensainSyuhoListForm : Form
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
        private DateTime today = Common.Common.GetCurrentTimestamp();

        #endregion

        #region コンストラクタ
        ////////////////////////////////////////////////////////////////////////////
        //  コンストラクタ名 ： KensainSyuhoListForm
        /// <summary>
        /// コンストラクタ(終了時イベントなし)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public KensainSyuhoListForm()
        {
            InitializeComponent();
            syuhoListDataGridView.DefaultCellStyle.Font = new Font(syuhoListDataGridView.Font.Name, 9);
            syuhoListDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(syuhoListDataGridView.Font.Name, 9);
            syuhoListDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            this.syuhoListDataGridView.Rows.Add("福　岡", "塚中光一", "", "", "", "", "8", "8", "3", "3", "6", "2", "2", "4", "1", "6", "7", "", "", "", "6", "19", "25","6.2");
            this.syuhoListDataGridView.Rows.Add("福　岡", "古賀大智", "", "", "", "", "8", "8", "", "8", "8", "", "7", "7", "", "9", "9", "", "", "", "", "32", "32", "8.0");
            this.syuhoListDataGridView.Rows.Add("福　岡", "安部隆", "", "", "", "2", "5", "7", "3", "3", "6", "", "7", "7", "", "9", "9", "", "", "", "5", "24", "28", "7.2");
            //this.SyuhoListDataGridView.Rows.Add("", "センター計", "", "", "", "2", "21", "23", "6", "14", "20", "2", "16", "18", "1", "24", "25", "", "", "", "11", "75", "86", "7.2");

            this.syuhoListDataGridView.Rows.Add("筑　後", "野上裕文", "", "", "", "", "", "", "", "6", "6", "", "11", "11", "", "9", "9", "", "", "", "", "26", "26", "8.7");
            this.syuhoListDataGridView.Rows.Add("筑　後", "原　賀一", "", "", "", "", "", "", "", "7", "7", "", "", "", "", "", "", "", "", "", "", "7", "7", "7.0");
            this.syuhoListDataGridView.Rows.Add("筑　後", "椛島和寿", "", "", "", "8", "", "8", "", "10", "10", "3", "5", "8", "", "", "", "", "", "", "11", "15", "26", "8.7");
            this.syuhoListDataGridView.Rows.Add("筑　後", "濱崎博美", "", "", "", "", "11", "11", "", "9", "9", "", "11", "11", "3", "6", "9", "", "", "", "3", "37", "40", "10.0");
            this.syuhoListDataGridView.Rows.Add("筑　後", "諏訪省三", "", "", "", "5", "2", "7", "", "8", "8", "10", "1", "11", "", "11", "11", "", "", "", "15", "22", "37", "9.2");
            this.syuhoListDataGridView.Rows.Add("筑　後", "古賀和英", "", "", "", "", "9", "9", "4", "4", "8", "", "9", "9", "", "12", "12", "", "", "", "4", "34", "38", "9.5");
            this.syuhoListDataGridView.Rows.Add("筑　後", "佐藤崇", "", "", "", "", "11", "11", "", "8", "8", "", "12", "12", "", "", "", "", "", "", "", "31", "31", "10.3");
            this.syuhoListDataGridView.Rows.Add("筑　後", "岩元淳", "", "", "", "", "", "", "3", "4", "7", "9", "1", "10", "", "11", "11", "", "", "", "12", "16", "28", "9.3");
            this.syuhoListDataGridView.Rows.Add("筑　後", "下川竜毅", "", "", "", "", "8", "8", "", "7", "7", "3", "5", "8", "", "6", "6", "", "", "", "3", "26", "29", "7.2");
            //this.SyuhoListDataGridView.Rows.Add("", "センター計", "", "", "", "13", "41", "54", "7", "63", "70", "25", "55", "80", "3", "55", "58", "", "", "", "48", "214", "262", "9.0");

            this.syuhoListDataGridView.Rows.Add("筑　豊", "久保寛宣", "", "", "", "9", "", "9", "1", "7", "8", "", "11", "11", "", "8", "8", "", "", "", "10", "26", "36", "9.0");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "牛嶋恒博", "", "", "", "", "5", "5", "", "5", "5", "", "4", "4", "", "12", "12", "", "", "", "", "26", "26", "6.5");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "浅野隆二", "", "", "", "", "9", "9", "1", "7", "8", "6", "2", "8", "", "8", "8", "", "", "", "7", "26", "33", "8.2");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "川上史人", "", "", "", "", "9", "9", "", "10", "10", "", "8", "8", "4", "2", "6", "", "", "", "4", "29", "33", "8.2");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "山田耕作", "", "", "", "2", "10", "12", "", "12", "12", "", "11", "11", "1", "6", "7", "", "", "", "3", "39", "42", "10.5");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "桜木秀憲", "", "", "", "", "10", "10", "", "11", "11", "", "11", "11", "", "11", "11", "", "", "", "", "43", "43", "10.8");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "奥村陸矢", "", "", "", "10", "", "10", "", "12", "12", "", "10", "10", "", "", "", "", "", "", "10", "22", "32", "10.7");
            this.syuhoListDataGridView.Rows.Add("筑　豊", "萩原広大", "", "", "", "", "10", "10", "1", "7", "8", "", "3", "3", "", "7", "7", "", "", "", "1", "27", "28", "7.0");
            //this.SyuhoListDataGridView.Rows.Add("", "センター計", "", "", "", "21", "53", "74", "3", "71", "74", "6", "60", "66", "5", "54", "59", "", "", "", "35", "238", "273", "8.8");

            //this.SyuhoListDataGridView.Rows.Add("", "☆総合計☆", "", "", "", "36", "115", "151", "16", "148", "164", "33", "131", "164", "9", "133", "142", "", "", "", "94", "527", "621", "8.6");

        
        }
        #endregion

        #region イベント

        #region KensainSyuhoListForm_Load
        ////////////////////////////////////////////////////////////////////////////
        //  イベント名 ： KensainSyuhoListForm_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void KensainSyuhoListForm_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //SetDefaultValues();

                //DoFormLoad();
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
        /// 2014/08/14  DatNT　  新規作成
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
                    this.syuhoListPanel,
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
        //  イベント名 ： outputButton_Click
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="sender"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void clearButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //SetDefaultValues();
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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void kensakuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                //if (!CheckCondition()) { return; }

                //DoSearch(true);
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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void outputButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (syuhoListDataGridView.RowCount == 0) { return; }

                string outputFilename = "検査員週報一覧_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                Common.Common.FlushGridviewDataToExcel(this.syuhoListDataGridView, outputFilename);
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
        /// 2014/08/14  DatNT　  新規作成
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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoFormLoad()
        {
            //// Clear datagirdview
            //fileKanriTblDataSet.Clear();

            //IFormLoadALInput alInput = new FormLoadALInput();
            //IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            //// Display data
            //fileKanriTblDataSet.Merge(alOutput.FileKanriTblKensakuDT);

            //if (alOutput.FileKanriTblKensakuDT == null || alOutput.FileKanriTblKensakuDT.Count == 0)
            //{
            //    fileListCountLabel.Text = "0件";
            //}
            //else
            //{
            //    fileListCountLabel.Text = alOutput.FileKanriTblKensakuDT.Count.ToString() + "件";
            //}

            this._searchShowFlg = true;
            this._defaultSearchPanelTop = this.searchPanel.Top;
            this._defaultSearchPanelHeight = this.searchPanel.Height;
            this._defaultListPanelTop = this.syuhoListPanel.Top;
            this._defaultListPanelHeight = this.syuhoListPanel.Height;
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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        //private void MakeSearchCond(IKensakuBtnClickALInput alInput)
        //{
        //    // ファイル名
        //    alInput.FileName = fileNmTextBox.Text.Trim();

        //    // 登録日検索使用区分
        //    alInput.TorokuDtUse = torokuDtUseCheckBox.Checked;

        //    // 登録日（開始）
        //    alInput.TorokuDtFrom = torokuDtFromDateTimePicker.Value;

        //    // 登録日（終了）
        //    alInput.TorokuDtTo = torokuDtToDateTimePicker.Value.AddDays(1);
        //}
        #endregion

        #region DoSearch
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： DoSearch
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clickBtnSearch"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void DoSearch()
        {
            //// Clear datagirdview
            //fileKanriTblDataSet.Clear();

            //IKensakuBtnClickALInput alInput = new KensakuBtnClickALInput();

            //// Create conditions
            //MakeSearchCond(alInput);

            //IKensakuBtnClickALOutput alOutput = new KensakuBtnClickApplicationLogic().Execute(alInput);

            //// Display data
            //fileKanriTblDataSet.Merge(alOutput.FileKanriTblKensakuDT);

            //if (alOutput.FileKanriTblKensakuDT == null || alOutput.FileKanriTblKensakuDT.Count == 0)
            //{
            //    fileListCountLabel.Text = "0件";

            //    if (clickBtnSearch)
            //    {
            //        // 保健所一覧 : リスト数 = 0
            //        MessageForm.Show2(MessageForm.DispModeType.Infomation, "表示データがありません。");
            //    }
            //}
            //else
            //{
            //    fileListCountLabel.Text = alOutput.FileKanriTblKensakuDT.Count.ToString() + "件";
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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private bool CheckCondition()
        {
            StringBuilder errMess = new StringBuilder();

            

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
        /// 2014/08/14  DatNT　  新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        private void SetDefaultValues()
        {
            //// ファイル名
            //fileNmTextBox.Clear();

            //// 登録日検索使用区分
            //torokuDtUseCheckBox.Checked = false;

            //// 登録日（開始）
            //torokuDtFromDateTimePicker.Value = new DateTime(today.Year, today.Month, 1);
            //torokuDtFromDateTimePicker.Enabled = false;

            //// 登録日（終了）
            //torokuDtToDateTimePicker.Value = today;
            //torokuDtToDateTimePicker.Enabled = false;
        }
        #endregion

        #endregion

    }
    #endregion
}
