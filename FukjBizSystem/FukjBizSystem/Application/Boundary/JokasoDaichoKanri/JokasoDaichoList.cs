using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FukjBizSystem.Application.Boundary.JokasoDaichoKanri;
using FukjBizSystem.Application.ApplicationLogic.JokasoDaichoKanri.JokasoDaichoList;
using FukjBizSystem.Application.DataSet;
using Zynas.Framework.Utility;
using Zynas.Framework.Core.Common.Boundary;
using System.Reflection;

namespace FukjBizSystem.Application.Boundary.JokasoDaichoKanri
{
    public partial class JokasoDaichoList : Form
    {
        public JokasoDaichoList()
        {
            InitializeComponent();
        }

        private void JokasoDaichoList_KeyDown(object sender, KeyEventArgs e)
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

        private void torokuButton_Click(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                JokasoDaichoShosai frm = new JokasoDaichoShosai();
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

        private void JokasoDaichoList_Load(object sender, EventArgs e)
        {
            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                IFormLoadALInput alInput = new FormLoadALInput();
                IFormLoadALOutput alOutput = new FormLoadApplicationLogic().Execute(alInput);

                jokasoDaichoListCountLabel.Text = alOutput.JokasoDaichoMstDT.Count + "件";            
                jokasoDaichoListDataGridView.DataSource = alOutput.JokasoDaichoMstDT;
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

        private void jokasoDaichoListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string hokenjoCd, torokuNengetsu, renban;

            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (e.RowIndex > -1)
                {
                    hokenjoCd = jokasoDaichoListDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    torokuNengetsu = jokasoDaichoListDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    renban = jokasoDaichoListDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

                    JokasoDaichoShosai frm = new JokasoDaichoShosai(hokenjoCd, torokuNengetsu, renban);
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

        private void tojiruButton_Click(object sender, EventArgs e)
        {
            JokasoDaichoKanriMenu frm = new JokasoDaichoKanriMenu();
            Program.mForm.ShowForm(frm);
        }

        private void shosaiButton_Click(object sender, EventArgs e)
        {
            string hokenjoCd, torokuNengetsu, renban;

            hokenjoCd = string.Empty;
            torokuNengetsu = string.Empty;
            renban = string.Empty;

            TraceLog.StartWrite(MethodInfo.GetCurrentMethod());
            Cursor preCursor = Cursor.Current;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                foreach (DataGridViewRow row in jokasoDaichoListDataGridView.SelectedRows)
                {
                    hokenjoCd = row.Cells[0].Value.ToString();
                    torokuNengetsu = row.Cells[1].Value.ToString();
                    renban = row.Cells[2].Value.ToString();
                }

                JokasoDaichoShosai frm = new JokasoDaichoShosai(hokenjoCd, torokuNengetsu, renban);
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
    }
}
