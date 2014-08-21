using System;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.Common;
using FukjBizSystem.Application.BusinessLogic.Common;
using FukjBizSystem.Application.BusinessLogic.Master.BushoMstList;
using FukjBizSystem.Application.BusinessLogic.Master.GyoshaMstShosai;
using FukjBizSystem.Application.DataSet;
using FukjBizSystem.Application.Utility;
using FukjBizSystem.Control;
using Zynas.Control;
using Zynas.Control.ZDataGridView;
using Zynas.Framework.Utility;
using Excel = Microsoft.Office.Interop.Excel;

namespace FukjBizSystem.Application.Boundary.Common
{
    #region クラス定義
    ////////////////////////////////////////////////////////////////////////////
    //  クラス名 ： Common
    /// <summary>
    /// 共通機能のユーティリティです
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <history>
    /// 日付　　　　担当者　　　内容
    /// 2013/12/27　吉浦　　    新規作成
    /// </history>
    ////////////////////////////////////////////////////////////////////////////
    public class Common
    {
        #region 定義(private)

        

        #endregion

        #region 静的メソッド(public)

        #region データグリッド初期化
        public static void initDgv(DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region allSelectDgv
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： allSelectDgv
        /// <summary>
        /// Check ON for checkbox column in gridview
        /// </summary>
        /// <param name="dgv">Specify datagridview</param>
        /// <param name="colNo">Index of checkbox column</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/03/27　AnhNV　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void allSelectDgv(DataGridView dgv, int colNo)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[colNo];
                    chk.Value = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region allSelectClearDgv
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： allSelectClearDgv
        /// <summary>
        /// Check OFF for checkbox column in gridview
        /// </summary>
        /// <param name="dgv">Specify datagridview</param>
        /// <param name="colNo">Index of checkbox column</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/03/27　AnhNV　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void allSelectClearDgv(DataGridView dgv, int colNo)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[colNo];
                    chk.Value = false;
                }
            }
            catch
            {
                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region DataGridExcelOutput
        public static bool DataGridViewExcelOutput(string title, DataGridView dg)
        {
            bool excelOutput = false;

            try
            {
                // 保存確認ダイアログの表示
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.FileName = title;
                dlg.Filter = "excel files (*.xls)|*.xls";
                dlg.FilterIndex = 1;

                // ＯＫボタンで終了した場合
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    #region Execl出力
                    
                    // EXCEL起動
                    Excel.Application objExcel = null;
                    Excel.Workbook objWorkBook = null;
                    Excel.Worksheet objWorkSheet = null;
                    objExcel = new Excel.Application();
                    objWorkBook = objExcel.Workbooks.Add(
                        Excel.XlWBATemplate.xlWBATWorksheet);

                    // DataGridViewのセルのデータ取得
                    String[,] v = new String[
                        dg.Rows.Count, dg.Columns.Count];
                    for (int r = 0; r <= dg.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= dg.Columns.Count - 1; c++)
                        {
                            String dt = "";
                            if (dg.Rows[r].Cells[c].Value != null)
                            {
                                dt = dg.Rows[r].Cells[c].Value.
                                    ToString();
                            }
                            v[r, c] = dt;
                        }
                    }

                    // EXCELにデータ転送
                    objWorkSheet = (Excel.Worksheet)objWorkBook.Sheets[1];
                    objWorkSheet.get_Range(
                        objWorkSheet.Cells[1, 1], objWorkSheet.Cells[
                        dg.Rows.Count, dg.Columns.Count]).Value2 = v;

                    // エクセル表示
                    objExcel.Visible = true;

                    // EXCEL解放
                    Marshal.ReleaseComObject(objWorkBook);
                    Marshal.ReleaseComObject(objExcel);
                    Marshal.ReleaseComObject(objWorkSheet);
                    objWorkSheet = null;
                    objWorkBook = null;
                    objExcel = null;

                    #endregion

                    excelOutput = true;
                }

            }
            catch
            {
                throw;
            }
            finally
            {
            }
            return excelOutput;
        }
        #endregion

        #region SendHanyoMail
        ///////////////////////////////////////////////////////////////
        /// メソッド：SendHanyoMail
        /// <summary>
        /// 汎用メール機能
        /// </summary>
        /// <param name="smtpServer">SMTPサーバ名</param>
        /// <param name="smtpPort">SMTPサーバポート</param>
        /// <param name="user">送信元アカウント</param>
        /// <param name="pass">送信元アカウントパス</param>
        /// <param name="fromMailAddress">送信元アドレス</param>
        /// <param name="toMailAddress">送信先アドレス</param>
        /// <param name="subject">メールタイトル</param>
        /// <param name="body">メール本文</param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2013/12/20　吉浦  　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static bool SendHanyoMail(string smtpServer,
                                            int smtpPort,
                                            string user,
                                            string pass,
                                            string fromMailAddress,
                                            string toMailAddress,
                                            string subject,
                                            string body)
        {
            bool sendMail = false;

            try
            {
                // 送信サーバーの設定
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = smtpServer;
                smtp.Port = smtpPort;

                // TODO: toyoda 認証が必要であれば・・・
                smtp.Credentials = new NetworkCredential(user, pass);

                MailMessage mail = new MailMessage(fromMailAddress,
                                                   toMailAddress,
                                                   subject,
                                                   body);

                // BCC
                mail.Bcc.Add(fromMailAddress);

                // 送信実行
                smtp.Send(mail);
                mail.Dispose();

                sendMail = true;
            }
            catch (Exception e)
            {
                // ログ出力
                TraceLog.FatalWrite(MethodInfo.GetCurrentMethod(), e.ToString());

                // 例外をスロー
                throw new CustomException(ResultCode.OtherError, 0, "メールの送信に失敗しました。");
            }
            finally
            {
                TraceLog.EndWrite(MethodInfo.GetCurrentMethod());
            }

            return sendMail;
        }
        #endregion

        #region ExportCSVFromDataGridView
        ///////////////////////////////////////////////////////////////
        /// メソッド：ExportCSVFromDataGridView
        /// <summary>
        /// ExportCSVFromDataTable
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="gridViewInput"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/02/27　CuongNT  　   新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string ExportCSVFromDataGridView(string fileName, DataGridView gridViewInput)
        {
            string messageError = "";
            
            StringBuilder dataTable = new StringBuilder();
            
            var headerCol = from DataGridViewColumn col in gridViewInput.Columns
                            where col.Visible == true
                            select col.HeaderText;

            dataTable.AppendLine(string.Join(",", headerCol.ToArray()));

            foreach (DataGridViewRow row in gridViewInput.Rows)
            {
                var data = from DataGridViewCell cell in row.Cells
                           where cell.Visible == true
                           select cell.Value;
                var arrayData = data.ToArray();
                
                var arrayDataString = from object item in arrayData
                             select (item == null ? "" : item.ToString());

                dataTable.AppendLine(string.Join(",", arrayDataString.ToArray()));
            }

            // export file 
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.FileName = fileName;
            ofd.Filter = "CSV (*.csv)|*.csv";
            DialogResult dr = ofd.ShowDialog();
            string filename = "";
            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                try
                {
                    using (var sw = new StreamWriter(filename, false, Encoding.UTF8))
                    {
                        sw.Write(dataTable.ToString());
                    }
                }
                catch (Exception e)
                {
                    messageError = e.Message.ToString();
                }
            }

            return messageError;
        }
        #endregion

        #region ExportCSVFromSelectedRowsDataGridView
        ///////////////////////////////////////////////////////////////
        /// メソッド：ExportCSVFromSelectedRowsDataGridView
        /// <summary>
        /// ExportCSVFromSelectedRowsDataGridView
        /// </summary>
        /// <param name="fileName">file name</param>
        /// <param name="checkBoxColNm">Name of checkbox column</param>
        /// <param name="gridViewInput"></param>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/03/26　AnhNV  　   新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string ExportCSVFromSelectedRowsDataGridView(string fileName, string checkBoxColNm, DataGridView gridViewInput)
        {
            string messageError = "";

            StringBuilder dataTable = new StringBuilder();

            // Remove invisible columns
            var headerCol = from DataGridViewColumn col in gridViewInput.Columns
                            where col.Visible == true
                            select col.HeaderText;

            dataTable.AppendLine(string.Join(",", headerCol.ToArray()));

            foreach (DataGridViewRow row in gridViewInput.Rows)
            {
                // Skip rows without checked
                if ((bool)row.Cells[checkBoxColNm].FormattedValue == false) continue;
                // Get row datas
                var data = from DataGridViewCell cell in row.Cells
                           where cell.Visible == true
                           select cell.Value;

                var arrayData = data.ToArray();

                var arrayDataString = from object item in arrayData
                                      select (item == null ? "" : item.ToString());

                dataTable.AppendLine(string.Join(",", arrayDataString.ToArray()));
            }

            // export file 
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.FileName = fileName;
            ofd.Filter = "CSV (*.csv)|*.csv";
            DialogResult dr = ofd.ShowDialog();
            string filename = "";
            if (dr == DialogResult.OK)
            {
                filename = ofd.FileName;
                try
                {
                    using (var sw = new StreamWriter(filename, false, Encoding.UTF8))
                    {
                        sw.Write(dataTable.ToString());
                    }
                }
                catch (Exception e)
                {
                    messageError = e.Message.ToString();
                }
            }

            return messageError;
        }
        #endregion

        #region ChildControlEnableChange
        ///////////////////////////////////////////////////////////////
        /// メソッド：ChildControlEnableChange
        /// <summary>
        /// 子コントロールの一括活性制御
        /// </summary>
        /// <param name="ctl">親コントロール</param>
        /// <param name="enable">活性状態</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/06　和田  　 新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void ChildControlEnableChange(System.Windows.Forms.Control ctl, bool enable)
        {
            foreach (System.Windows.Forms.Control childCtl in ctl.Controls)
            {
                // Zテキスト
                if (childCtl is ZTextBox)
                {
                    ((ZTextBox)childCtl).CustomReadOnly = !enable;
                }
                // NumberTextBox
                else if (childCtl is NumberTextBox)
                {
                    ((NumberTextBox)childCtl).ReadOnly = !enable;
                }
                // ZDate
                else if (childCtl is ZDate)
                {
                    ((ZDate)childCtl).Enabled = enable;
                }
                // ZDataGridView
                else if (childCtl is ZDataGridView)
                {
                    ((ZDataGridView)childCtl).Enabled = enable;
                }
                // ZButton
                else if (childCtl is ZButton)
                {
                    ((ZButton)childCtl).Enabled = enable;
                }
                // ラジオボタン
                else if (childCtl is RadioButton)
                {
                    ((RadioButton)childCtl).Enabled = enable;
                }
                // コンボボックス
                else if (childCtl is ComboBox)
                {
                    ((ComboBox)childCtl).Enabled = enable;
                }

                // 自コントロールの子コントロールの活性制御
                ChildControlEnableChange(childCtl, enable);
            }
        }
        #endregion

        #region GetShokuinMstByShokuinCdShokuinPassword
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetShokuinMstByShokuinCdShokuinPassword
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shokuinCd">ログインID</param>
        /// <param name="shokuinPassword">ログインパスワード</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/19　DatNT　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static ShokuinMstDataSet.ShokuinMstDataTable GetShokuinMstByShokuinCdShokuinPassword(
            string shokuinCd, 
            string shokuinPassword)
        {
            ShokuinMstDataSet.ShokuinMstDataTable ShokuinMstDT = null;

            try
            {
                IGetShokuinMstByShokuinCdShokuinPasswordALInput alInput = new GetShokuinMstByShokuinCdShokuinPasswordALInput();
                alInput.ShokuinCd = shokuinCd;
                alInput.ShokuinPassword = shokuinPassword;
                IGetShokuinMstByShokuinCdShokuinPasswordALOutput output = new GetShokuinMstByShokuinCdShokuinPasswordApplicationLogic().Execute(alInput);

                ShokuinMstDT = output.ShokuinMstDT;

            }
            catch
            {
                throw;
            }
            finally
            {
            }

            return ShokuinMstDT;
        }
        #endregion

        #region GetCurrentTimestamp
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetCurrentTimestamp
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Server date time</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20　DatNT　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static DateTime GetCurrentTimestamp()
        {
            DateTime currentTime = DateTime.Now;

            try
            {
                IGetCurrentTimestampALInput alInput = new GetCurrentTimestampALInput();
                IGetCurrentTimestampALOutput alOutput = new GetCurrentTimestampApplicationLogic().Execute(alInput);

                currentTime = alOutput.CurrentTimestamp;
            }
            catch
            {
                throw;
            }
            finally
            {
            }

            return currentTime;
        }
        #endregion

        #region SwitchSearchPanel
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： SwitchSearchPanel
        /// <summary>
        ///  検索条件パネルの表示・非表示の切り替え
        /// </summary>
        /// <param name="switchFlg">TRUE：表示　FALSE:非表示</param>
        /// <param name="searchPanel">検索条件パネル</param>
        /// <param name="defSearchPanelTop">検索条件パネルTOP（初期値）</param>
        /// <param name="defSearchPanelHeight">検索条件パネルHEIGHT（初期値）</param>
        /// <param name="listPanel">検索結果リストパネル</param>
        /// <param name="defSearchPanelTop">検索結果リストパネルTOP（初期値）</param>
        /// <param name="defSearchPanelHeight">検索結果リストパネルHEIGHT（初期値）</param>
        /// <param name="colNo">Index of checkbox column</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　YS.CHEW　　 新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void SwitchSearchPanel(
            bool switchFlg,
            Panel searchPanel,
            int defSearchPanelTop,
            int defSearchPanelHeight,
            Panel listPanel,
            int defListPanelTop,
            int defListPanelHeight
            )
        {
            try
            {
                if (switchFlg)//検索条件を開く
                {
                    searchPanel.Top = defSearchPanelTop;
                    searchPanel.Height = defSearchPanelHeight;
                    listPanel.Top = defListPanelTop;
                    listPanel.Height = defListPanelHeight;
                }
                else////検索条件を閉じる
                {
                    searchPanel.Height = 30;
                    listPanel.Top = searchPanel.Top + searchPanel.Height;
                    listPanel.Height += (defSearchPanelHeight - searchPanel.Height);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
            }
        }
        #endregion

        #region FlushGridviewDataToExcel
        #region releaseObject
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： releaseObject
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/20  DatNT　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static void releaseObject(object obj)
        {
            try
            {
                if (null == obj) return;

                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

        ///////////////////////////////////////////////////////////////
        //メソッド名 ： FlushGridviewDataToExcel
        /// <summary>
        ///  指定GridviewのデータをExcelに出力する
        /// </summary>
        /// <param name="targetDataGridView">対象DataGridView</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/06/23　YS.CHEW　　 新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void FlushGridviewDataToExcel(
            DataGridView targetDataGridView,
            string outputFilename

            )
        {
            Microsoft.Office.Interop.Excel.Application xlApp = null;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = null;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = null;

            try
            {
                // 保存確認ダイアログの表示
                SaveFileDialog dlg = new SaveFileDialog();

                dlg.FileName =  outputFilename + "_" + Common.GetCurrentTimestamp().ToString("yyyyMMddHHmmss");
                dlg.Filter = "Excel files (*.xls)|*.xls";
                dlg.FilterIndex = 1;

                // ＯＫボタンで終了した場合
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    object misValue = System.Reflection.Missing.Value;

                    xlApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    int i = 0;
                    int j = 0;

                    for (i = 0; i <= targetDataGridView.RowCount - 1; i++)
                    {
                        for (j = 0; j <= targetDataGridView.ColumnCount - 1; j++)
                        {
                            // Skip hidden columns
                            if (!targetDataGridView.Columns[j].Visible) continue;

                            DataGridViewCell cell = targetDataGridView[j, i];

                            if (i == 0)
                            {
                                DataGridViewHeaderCell h = targetDataGridView.Columns[j].HeaderCell;
                                xlWorkSheet.Cells[i + 1, j + 1] = h.Value;
                            }

                            // Code & No columns format
                            if (targetDataGridView.Columns[j].Name.Length > 5
                                && (targetDataGridView.Columns[j].Name.Substring(targetDataGridView.Columns[j].Name.Length - 5) == "CdCol"
                                || targetDataGridView.Columns[j].Name.Substring(targetDataGridView.Columns[j].Name.Length - 5) == "NoCol"))
                            {
                                xlWorkSheet.Cells[i + 2, j + 1] = "'" + cell.Value;
                                Excel.Range rng = (Excel.Range)xlWorkSheet.Cells[i + 2, j + 1];
                                //rng.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;

                                continue;
                            }

                            // Date columns format
                            if (targetDataGridView.Columns[j].Name.Length > 5
                                && targetDataGridView.Columns[j].Name.Substring(targetDataGridView.Columns[j].Name.Length - 5) == "DtCol")
                            {
                                xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                                Excel.Range rng = (Excel.Range)xlWorkSheet.Cells[i + 2, j + 1];
                                rng.EntireColumn.NumberFormat = "yyyy/MM/dd";

                                continue;
                            }

                            xlWorkSheet.Cells[i + 2, j + 1] = cell.Value;
                        }
                    }

                    xlWorkBook.SaveAs(dlg.FileName,
                                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                                        misValue,
                                        misValue,
                                        misValue,
                                        misValue,
                                        Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                                        misValue,
                                        misValue,
                                        misValue,
                                        misValue,
                                        misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                }
            }
            catch
            {
                throw;
            }
            finally
            {
                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
        }
        #endregion

        #region GetSaibanRenban
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetSaibanRenban
        /// <summary>
        /// 
        /// </summary>
        /// <input>採番年度</input>
        /// <input>採番区分</input>
        /// <returns>採番連番</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/18  宗　　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string GetSaibanRenban(string SaibanNendo, string SaibanKbn)
        {
            string SaibanRenban = "";

            try
            {
                // 採番
                IGetSaibanTblByKeyBLInput blInput = new GetSaibanTblByKeyBLInput();
                blInput.SaibanNendo = SaibanNendo;
                blInput.SaibanKbn = SaibanKbn;
                blInput.SaibanCnt = 1;
                IGetSaibanTblByKeyBLOutput blOutput = new GetSaibanTblByKeyBusinessLogic().Execute(blInput);

                // 0埋め
                if (blOutput.SaibanTblDT.Rows.Count > 0)
                {
                    SaibanRenban = blOutput.SaibanTblDT[0].SaibanRenban.Trim().PadLeft(blOutput.SaibanTblDT[0].SaibanKetasu, '0');
                }
            }
            catch
            {
                throw;
            }
            finally
            {
            }

            return SaibanRenban;
        }
        #endregion

        #region GetSaibanRenban
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetSaibanRenban
        /// <summary>
        /// 
        /// </summary>
        /// <input>採番年度</input>
        /// <input>採番区分</input>
        /// <returns>採番連番</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  宗　　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string GetSaibanRenban(string SaibanNendo, string SaibanKbn, int SaibanCnt)
        {
            string SaibanRenban = "";

            try
            {
                // 採番
                IGetSaibanTblByKeyBLInput blInput = new GetSaibanTblByKeyBLInput();
                blInput.SaibanNendo = SaibanNendo;
                blInput.SaibanKbn = SaibanKbn;
                blInput.SaibanCnt = SaibanCnt;
                IGetSaibanTblByKeyBLOutput blOutput = new GetSaibanTblByKeyBusinessLogic().Execute(blInput);

                // 0埋め
                if (blOutput.SaibanTblDT.Rows.Count > 0)
                {
                    SaibanRenban = blOutput.SaibanTblDT[0].SaibanRenban.Trim().PadLeft(blOutput.SaibanTblDT[0].SaibanKetasu, '0');
                }
            }
            catch
            {
                throw;
            }
            finally
            {
            }

            return SaibanRenban;
        }
        #endregion

        #region GetSaibanNendo
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetSaibanNendo
        /// <summary>
        /// 
        /// </summary>
        /// <input>採番年月日</input>
        /// <input>採番区分</input>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  宗　　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string GetSaibanNendo(string SaibanDt, string SaibanKbn)
        {
            DateTime dt;
            string Nendo = "";
            string Saiban = "";

            // 年度取得
            if(DateTime.TryParseExact(SaibanDt, "yyyyMMdd",
                System.Globalization.DateTimeFormatInfo.InvariantInfo,
                System.Globalization.DateTimeStyles.None, out dt))
            {
                if (dt.Month <= 3)
                {
                    Nendo = (dt.Year - 1).ToString();
                }
                else
                {
                    Nendo = dt.Year.ToString();
                }
            }

            // 採番
            if (Nendo != "")
            {
                Saiban = GetSaibanRenban(Nendo, SaibanKbn);
                if (Saiban != "")
                {
                    Saiban = Nendo + Saiban;
                }
            }

            return Saiban;
        }
        #endregion

        #region GetKeyRenban
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetKeyRenban
        /// <summary>
        /// 
        /// </summary>
        /// <input>マスタ物理名称</input>
        /// <input>キー項目値１</input>
        /// <input>キー項目値２</input>
        /// <input>キー項目値３</input>
        /// <returns>キー連番</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/24  宗　　　    新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static string GetKeyRenban(string MstNm, string MstKey1, string MstKey2, string MstKey3)
        {
            string KeyRenban = "";

            try
            {
                // 採番
                IGetMstKeySaibanTblByKeyBLInput blInput = new GetMstKeySaibanTblByKeyBLInput();
                blInput.MstButsuriNm = MstNm;
                blInput.MstKeyValue1 = MstKey1;
                blInput.MstKeyValue2 = MstKey2;
                blInput.MstKeyValue3 = MstKey3;
                IGetMstKeySaibanTblByKeyBLOutput blOutput = new GetMstKeySaibanTblByKeyBusinessLogic().Execute(blInput);

                // 採番結果取得
                if (blOutput.MstKeySaibanTblDT.Rows.Count > 0)
                {
                    KeyRenban = blOutput.MstKeySaibanTblDT[0].MstKeyRenban.ToString();
                }

            }
            catch
            {
                throw;
            }
            finally
            {
            }

            return KeyRenban;
        }
        #endregion

        #region SetGyoshaNmByCd
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： GetGyoshaNmByCd
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gyoshaCd">業者コード</param>
        /// <param name="gyoshaCdTextBox">業者コードコントロール</param>
        /// <param name="gyoshaNmTextBox">業者名称コントロール</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/24  HuyTX　　　新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void SetGyoshaNmByCd(string gyoshaCd, TextBox gyoshaCdTextBox, TextBox gyoshaNmTextBox)
        {
            try
            {
                if (string.IsNullOrEmpty(gyoshaCd)) return;

                IGetGyoshaMstByKeyBLInput blInput = new GetGyoshaMstByKeyBLInput();
                blInput.GyoshaCd = gyoshaCd;

                IGetGyoshaMstByKeyBLOutput blOutput = new GetGyoshaMstByKeyBusinessLogic().Execute(blInput);

                if (blOutput.GyoshaMstDataTable.Count == 0)
                {
                    gyoshaCdTextBox.Text = string.Empty;
                    gyoshaNmTextBox.Text = string.Empty;
                }
                else 
                {
                    gyoshaCdTextBox.Text = blOutput.GyoshaMstDataTable[0].GyoshaCd;
                    gyoshaNmTextBox.Text = blOutput.GyoshaMstDataTable[0].GyoshaNm;
                }
            }
            catch
            {
                throw;
            }

        }
        #endregion

        #region GetConstValue
        /// <summary>
        /// get const value by kbn , renban
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  habu　　    新規作成
        /// </history>
        public static string GetConstValue(string constKbn, string constRenban)
        {
            string value = string.Empty;

            IGetConstMstByKeyBLInput input = new GetConstMstByKeyBLInput();
            input.ConstKbn = constKbn;
            input.ConstRenban = constRenban;

            IGetConstMstByKeyBLOutput output = new GetConstMstByKeyBusinessLogic().Execute(input);

            if (output.DataTable.Count > 0)
            {
                value = output.DataTable[0].ConstValue;
            }

            return value;
        }
        #endregion

        #region GetConstTable
        /// <summary>
        /// get const value by kbn , renban
        /// </summary>
        /// <returns></returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  habu　　    新規作成
        /// </history>
        public static DataTable GetConstTable(string constKbn)
        {
            ConstMstDataSet.ConstMstDataTable table;

            IGetConstMstByKbnBLInput input = new GetConstMstByKbnBLInput();
            input.ConstKbn = constKbn;
            IGetConstMstByKbnBLOutput output = new GetConstMstByKbnBusinessLogic().Execute(input);

            table = output.DataTable;

            return table;
        }
        #endregion

        #region 保証番号年度変換処理

        /// <summary>
        /// 西暦年度を和暦年度(平成)に変換
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 元号は常に平成とする
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  habu　　    新規作成
        /// </history>
        public static string ConvertToHoshouNendoWareki(string seirekiYear)
        {
            string retYear = string.Empty;

            int numYear = 0;
            if (!int.TryParse(seirekiYear, out numYear))
            {
                // エラーログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), string.Format("引数が不正です。:{0}", seirekiYear));

                return retYear;
            }

            numYear = numYear - Constants.HOSHOU_NENDO_OFFSET;

            if(numYear < 0)
            {
                // エラーログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod() , string.Format("引数が不正です。:{0}",seirekiYear));

                return retYear;
            }

            retYear = numYear.ToString();

            return retYear;
        }

        /// <summary>
        /// 和暦年度(平成)を西暦年度に変換
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// 元号は常に平成とする
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/07  habu　　    新規作成
        /// </history>
        public static string ConvertToHoshouNendoSeireki(string warekiYear)
        {
            string retYear = string.Empty;

            int numYear = 0;
            if (!int.TryParse(warekiYear, out numYear))
            {
                // エラーログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod() , string.Format("引数が不正です。:{0}",warekiYear));

                return retYear;
            }

            numYear = numYear + Constants.HOSHOU_NENDO_OFFSET;

            if(numYear < 0)
            {
                // エラーログ出力
                TraceLog.ErrorWrite(MethodInfo.GetCurrentMethod(), string.Format("引数が不正です。:{0}", warekiYear));

                return retYear;
            }

            retYear = numYear.ToString();

            return retYear;
        }

        #endregion

        #region SwitchSearchPanelTouch
        ///////////////////////////////////////////////////////////////
        //メソッド名 ： SwitchSearchPanelTouch
        /// <summary>
        ///  検索条件パネルの表示・非表示の切り替え
        /// </summary>
        /// <param name="switchFlg">TRUE：表示　FALSE:非表示</param>
        /// <param name="searchPanel">検索条件パネル</param>
        /// <param name="defSearchPanelTop">検索条件パネルTOP（初期値）</param>
        /// <param name="defSearchPanelHeight">検索条件パネルHEIGHT（初期値）</param>
        /// <param name="listPanel">検索結果リストパネル</param>
        /// <param name="defSearchPanelTop">検索結果リストパネルTOP（初期値）</param>
        /// <param name="defSearchPanelHeight">検索結果リストパネルHEIGHT（初期値）</param>
        /// <param name="colNo">Index of checkbox column</param>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/28　HuyTX　　 新規作成
        /// </history>
        ///////////////////////////////////////////////////////////////
        public static void SwitchSearchPanelTouch(
            bool switchFlg,
            Panel searchPanel,
            int defSearchPanelTop,
            int defSearchPanelHeight,
            Panel listPanel,
            int defListPanelTop,
            int defListPanelHeight
            )
        {
            try
            {
                if (switchFlg)//検索条件を開く
                {
                    searchPanel.Top = defSearchPanelTop;
                    searchPanel.Height = defSearchPanelHeight;
                    listPanel.Top = defListPanelTop;
                    listPanel.Height = defListPanelHeight;
                }
                else////検索条件を閉じる
                {
                    searchPanel.Height = 40;
                    listPanel.Top = searchPanel.Top + searchPanel.Height;
                    listPanel.Height += (defSearchPanelHeight - searchPanel.Height);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
            }
        }
        #endregion

        #region MakeSetchishaAdr
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： MakeSetchishaAdr
        /// <summary>
        /// Concat todofuken, shikuChoson and choikiNm as address
        /// </summary>
        /// <param name="choikiNm"></param>
        /// <param name="shikuChoson"></param>
        /// <param name="todofuken"></param>
        /// <returns>todofuken, shikuChoson, choikiNm</returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/07/29  AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static string MakeSetchishaAdr(string todofuken, string shikuChoson, string choikiNm)
        {
            string result = string.Empty;
            string[] setchishaAdr = new string[3] { todofuken, shikuChoson, choikiNm };

            for (int i = 0; i < 3; i++)
            {
                if (string.IsNullOrEmpty(setchishaAdr[i])) continue;
                result += setchishaAdr[i] + ", ";
            }

            return (result.Length > 2) ? result.Remove(result.Length - 2, 2) : result;
        }
        #endregion

        #region CopyDataGridView
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： CopyDataGridView
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvSource"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/20　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static DataGridView CopyDataGridView(DataGridView dgvSource)
        {
            DataGridView dgvCopy = new DataGridView();

            try
            {
                if (dgvCopy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgvSource.Columns)
                    {
                        dgvCopy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgvSource.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgvSource.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgvSource.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }

                    dgvCopy.Rows.Add(row);
                }

                dgvCopy.AllowUserToAddRows = false;
                dgvCopy.Refresh();
            }
            catch
            {
                throw;
            }

            return dgvCopy;
        }
        #endregion

        #region Printer working check

        #region GetDefaultPrinter
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： GetDefaultPrinter
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;

                // Default printer?
                if (settings.IsDefaultPrinter)
                {
                    return printer;
                }
            }

            return string.Empty;
        }
        #endregion

        #region PrinterIsReady
        ////////////////////////////////////////////////////////////////////////////
        //  メソッド名 ： PrinterIsReady
        /// <summary>
        /// 
        /// </summary>
        /// <param name="printerToCheck"></param>
        /// <remarks>
        /// 
        /// </remarks>
        /// <returns>
        /// TRUE: printer is working properly
        /// FALSE: printer is not working
        /// </returns>
        /// <history>
        /// 日付　　　　担当者　　　内容
        /// 2014/08/21　AnhNV　　    新規作成
        /// </history>
        ////////////////////////////////////////////////////////////////////////////
        public static bool PrinterIsReady(string printerToCheck)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Printer");

            bool IsReady = true;
            foreach (ManagementObject printer in searcher.Get())
            {
                if (printer["Name"].ToString().Equals(printerToCheck))
                {
                    // Printer is offline
                    if (printer["WorkOffline"].ToString().ToLower().Equals("false"))
                    {
                        IsReady = false;
                        break;
                    }
                }
            }

            return IsReady;
        }
        #endregion

        #endregion

        #endregion
    }
    #endregion
}
