using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using FukjBizSystem.Application.ApplicationLogic.JokasoDaichoKanri.JokasoDaichoShosai;
using FukjBizSystem.Application.Boundary.Common;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Core.Common.Boundary;
using Zynas.Framework.Utility;


namespace FukjBizSystem.Application.Boundary.JokasoDaichoKanri
{
    public partial class JokasoDaichoShosai : Form
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

        #region プロパティ(public)

        /// <summary>
        /// displayMode
        /// </summary>
        private DispMode _displayMode = DispMode.Add;

        #endregion

        #region プロパティ(private)

        /// <summary>
        /// hokenjoCd
        /// </summary>
        private string _hokenjoCd = string.Empty;

        /// <summary>
        /// torokuNengetsu
        /// </summary>
        private string _torokuNengetsu = string.Empty;

        /// <summary>
        /// renban
        /// </summary>
        private string _renban = string.Empty;

        /// <summary>
        /// jokasoDaichoMstDT
        /// </summary>
        private JokasoDaichoMstDataSet.JokasoDaichoMstDataTable _jokasoDaichoMstDT = new JokasoDaichoMstDataSet.JokasoDaichoMstDataTable();

        #endregion

        #region コンストラクタ

        public JokasoDaichoShosai()
        {
            InitializeComponent();
        }

        #endregion

        #region コンストラクタ

        public JokasoDaichoShosai(string hokenjoCd,string torokuNengetsu, string renban)
        {
            this._hokenjoCd = hokenjoCd;
            this._torokuNengetsu = torokuNengetsu;
            this._renban = renban;
            InitializeComponent();
        }

        #endregion

        #region イベント

        private void JokasoDaichoShosai_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrEmpty(this._hokenjoCd) || string.IsNullOrEmpty(this._torokuNengetsu) || string.IsNullOrEmpty(this._renban))
                {
                    this._displayMode = DispMode.Add;
                }
                else
                {
                    GetJokasoDaichoMst();
                    SetControlData();
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

        private void JokasoDaichoShosai_KeyDown(object sender, KeyEventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;


                if (e.KeyCode == Keys.Enter)
                {
                    bool forward = e.Modifiers != Keys.Shift;
                    this.SelectNextControl(this.ActiveControl, forward, true, true, true);
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

        private void setchishaZipCdTextBox_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrEmpty(setchishaAdrTextBox.Text))
                {

                    YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable yuibinNoAdrDt = GetYubinNoAdr(setchishaZipCdTextBox.Text);

                    foreach (YubinNoAdrMstKensakuDataSet.YubinNoAdrMstRow rows in yuibinNoAdrDt)
                    {
                        setchishaAdrTextBox.Text = rows.ShikuchosonNm + rows.ChoikiNm;
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

        private void setchibashoZipCdTextBox_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrEmpty(setchibashoAdrTextBox.Text))
                {

                    YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable yuibinNoAdrDt = GetYubinNoAdr(setchibashoZipCdTextBox.Text);
                    foreach (YubinNoAdrMstKensakuDataSet.YubinNoAdrMstRow rows in yuibinNoAdrDt)
                    {
                        setchibashoAdrTextBox.Text = rows.ShikuchosonNm + rows.ChoikiNm;
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

        private void zTextBox16_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable yuibinNoAdrDt = GetYubinNoAdr(zTextBox16.Text);
                foreach (YubinNoAdrMstKensakuDataSet.YubinNoAdrMstRow rows in yuibinNoAdrDt)
                {
                    zTextBox17.Text = rows.ShikuchosonNm + rows.ChoikiNm;
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

        private void zTextBox9_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;


                YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable yuibinNoAdrDt = GetYubinNoAdr(zTextBox9.Text);
                foreach (YubinNoAdrMstKensakuDataSet.YubinNoAdrMstRow rows in yuibinNoAdrDt)
                {
                    zTextBox10.Text = rows.ShikuchosonNm + rows.ChoikiNm;
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

        private void zTextBox15_Leave(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;


                YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable yuibinNoAdrDt = GetYubinNoAdr(zTextBox15.Text);
                foreach (YubinNoAdrMstKensakuDataSet.YubinNoAdrMstRow rows in yuibinNoAdrDt)
                {
                    zTextBox18.Text = rows.ShikuchosonNm + rows.ChoikiNm;
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

        private void sanjishoriCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sanjishoriCheckBox.Checked == true)
            {
                sanjishoriTypeTextBox.Enabled = true;
            }
            else
            {
                sanjishoriTypeTextBox.Text = string.Empty;
                sanjishoriTypeTextBox.Enabled = false;
            }
        }

        private void setchishaZipKensakuButton_Click(object sender, EventArgs e)
        {
            YubinNoKensaku yubin = new YubinNoKensaku();
            yubin.Adr = setchishaAdrTextBox.Text;
            yubin.ShowDialog();

            if (!string.IsNullOrEmpty(yubin.ZipCd))
            {
                setchishaZipCdTextBox.Text = yubin.ZipCd;
                setchishaAdrTextBox.Text = yubin.Adr;
            }

        }

        private void chakkoNenTextBox_Leave(object sender, EventArgs e)
        {
            int i;

            if (int.TryParse(chakkoNenTextBox.Text, out i))
            {
                if (int.Parse(chakkoNenTextBox.Text) > 1868)
                {
                    JapaneseCalendar jpCalender = new JapaneseCalendar();
                    //jpCalender.GetEra(DateTime.Parse(chakkoNenTextBox.Text + "-01-01"));

                    string[] Gengo = { "M", "T", "S", "H" };

                    chakkoNenTextBox.Text = Gengo[jpCalender.GetEra(DateTime.Parse(chakkoNenTextBox.Text + "-12-31")) - 1] + jpCalender.GetYear(DateTime.Parse(chakkoNenTextBox.Text + "-12-31")).ToString();
                }
                else
                {
                    chakkoNenTextBox.Text = "H" + chakkoNenTextBox.Text;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            JokasoDaichoList frm = new JokasoDaichoList();
            Program.mForm.ShowForm(frm);
        }

        private void shiyoshaZipKensakuButton_Click(object sender, EventArgs e)
        {
            YubinNoKensaku yubin = new YubinNoKensaku();
            yubin.Adr = shiyoshaAdrTextBox.Text;
            yubin.ShowDialog();

            if (!string.IsNullOrEmpty(yubin.ZipCd))
            {
                shiyoshaZipCdTextBox.Text = yubin.ZipCd;
                shiyoshaAdrTextBox.Text = yubin.Adr;
            }
        }

        private void setchibashoZipKensakuButton_Click(object sender, EventArgs e)
        {
            YubinNoKensaku yubin = new YubinNoKensaku();
            yubin.Adr = setchibashoAdrTextBox.Text;
            yubin.ShowDialog();

            if (!string.IsNullOrEmpty(yubin.ZipCd))
            {
                setchibashoZipCdTextBox.Text = yubin.ZipCd;
                setchibashoAdrTextBox.Text = yubin.Adr;
            }
        }

        private void shiyokaishiNenTextBox_Leave(object sender, EventArgs e)
        {
            int i;

            if (int.TryParse(shiyokaishiNenTextBox.Text, out i))
            {
                if (int.Parse(shiyokaishiNenTextBox.Text) > 1868)
                {
                    JapaneseCalendar jpCalender = new JapaneseCalendar();
                    //jpCalender.GetEra(DateTime.Parse(chakkoNenTextBox.Text + "-01-01"));

                    string[] Gengo = { "M", "T", "S", "H" };

                    shiyokaishiNenTextBox.Text = Gengo[jpCalender.GetEra(DateTime.Parse(shiyokaishiNenTextBox.Text + "-12-31")) - 1] + jpCalender.GetYear(DateTime.Parse(shiyokaishiNenTextBox.Text + "-12-31")).ToString();
                }
                else
                {
                    shiyokaishiNenTextBox.Text = "H" + shiyokaishiNenTextBox.Text;
                }
            }
        }

        #endregion

        #region メソッド(privete)

        private YubinNoAdrMstKensakuDataSet.YubinNoAdrMstDataTable GetYubinNoAdr(string ZipCd)
        {
            IZipCdTextBoxLeaveALInput alInput = new ZipCdTextBoxLeaveALInput();
            alInput.ZipCd = ZipCd;
            IZipCdTextBoxLeaveALOutput alOutput = new ZipCdTextBoxLeaveApplicationLogic().Execute(alInput);

            return  alOutput.YubinNoAdrMstDT;
        }

        private void GetJokasoDaichoMst()
        {
            IFormLoadALInput alInput = new FormLoadALInput();
            alInput.HokenjoCd = this._hokenjoCd;
            alInput.TorokuNengetsu = this._torokuNengetsu;
            alInput.Renban = this._renban;

            IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

            this._jokasoDaichoMstDT = alOutput.JokasoDaichoMstDT;

        }

        private void SetControlData()
        {
            if (this._jokasoDaichoMstDT.Rows.Count > 0)
            {
                foreach (JokasoDaichoMstDataSet.JokasoDaichoMstRow rows in this._jokasoDaichoMstDT)
                {
                    hokenjoCdTextBox.Text= rows.JokasoHokenjoCd;
                    torokuNengetsuTextBox.Text = rows.JokasoTorokuNendo;
                    renbanFromTextBox.Text = rows.JokasoRenban;

                    if (!rows.IsJokasoSetchishaNmNull()) setchishaNmTextBox.Text = rows.JokasoSetchishaNm;
                    if (!rows.IsJokasoSetchishaKanaNull()) setchishaKanaTextBox.Text = rows.JokasoSetchishaKana;
                    if (!rows.IsJokasoKensakuKanaNull()) kensakuKanaTextBox.Text = rows.JokasoKensakuKana;

                    if (!rows.IsJokasoSetchishaZipCdNull()) setchishaZipCdTextBox.Text = rows.JokasoSetchishaZipCd;
                    if (!rows.IsJokasoSetchishaAdrNull()) setchishaAdrTextBox.Text = rows.JokasoSetchishaAdr;
                    if (!rows.IsJokasoSetchishaTelCdNull()) setchishaTelNoTextBox.Text = rows.JokasoSetchishaTelCd;

                    if (!rows.IsJokasoShisetsuNmNull()) shisetsuNmTextBox.Text = rows.JokasoShisetsuNm;
                    if (!rows.IsJokasoSetchiBashoZipCdNull()) setchibashoZipCdTextBox.Text = rows.JokasoSetchiBashoZipCd;
                    if (!rows.IsJokasoSetchiBashoAdrNull()) setchibashoAdrTextBox.Text = rows.JokasoSetchiBashoAdr;
                    if (!rows.IsJokasoSetchiBashoTelCdNull()) setchibashoTelNoTextBox.Text = rows.JokasoSetchiBashoTelCd;
                    if (!rows.IsJokasoKyuChikuCdNull()) oldChikuCdTextBox.Text = rows.JokasoKyuChikuCd;

                }
            }
        }

        #endregion

    }
}
