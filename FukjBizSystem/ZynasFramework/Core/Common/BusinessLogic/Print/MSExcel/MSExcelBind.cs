using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace Zynas.Framework.Core.Common.BusinessLogic.Print.MSExcel
{
    public class MSExcelBind : ExcelBind
    {
        // TODO MSExcelUtilityのメソッドを呼び出す
        Worksheet currentSheet = null;
        Workbook book = null;

        // TODO オーバーロード系のメソッドは、ベースクラスに逃がす

        public MSExcelBind(Microsoft.Office.Interop.Excel.Workbook book)
        {
            this.book = book;
        }

        public override void SetCurrentSheet(int sheetIdx)
        {
            if (currentSheet != null)
            {
                Marshal.ReleaseComObject(currentSheet);
            }

            currentSheet = (Worksheet)book.Sheets[sheetIdx + MSExcelUtility.IDX_OFFSET];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        public override void CellOutput(int row, int col, object value)
        {
            MSExcelUtility.CellOutput(currentSheet, row, col, value);
        }

        public override void RowCopy(int fromSheetIdx, int fromRowIdx, int toSheetIdx, int toRowIdx, int rowCnt)
        {
            Worksheet fromSheet = null;
            Worksheet toSheet = null;
            Sheets sheets = null;

            try
            {
                sheets = book.Sheets;

                fromSheet = (Worksheet)sheets[fromSheetIdx + MSExcelUtility.IDX_OFFSET];
                toSheet = (Worksheet)sheets[toSheetIdx + MSExcelUtility.IDX_OFFSET];

                MSExcelUtility.RowCopy(fromSheet, fromRowIdx, toSheet, toRowIdx, rowCnt);
            }
            finally
            {
                if (fromSheet != null)
                {
                    Marshal.ReleaseComObject(fromSheet);
                }
                if (toSheet != null)
                {
                    Marshal.ReleaseComObject(toSheet);
                }
                if (sheets != null)
                {
                    Marshal.ReleaseComObject(sheets);
                }
            }
        }

        /*
        public override void RowCopy(int fromRowIdx, int toRowIdx, int rowCnt)
        {
            MSExcelUtility.RowCopy(currentSheet, fromRowIdx, currentSheet, toRowIdx, rowCnt);
        }
        */

        public override void SheetCopy(int fromSheetIdx)
        {
            MSExcelUtility.SheetCopy(book, fromSheetIdx);

            // 現在のシートを設定
            // TODO ここで(カレントシート設定を)自動でやるべきかは、再度検討
            SetCurrentSheet(MSExcelUtility.GetSheetCount(book) - 1);
        }

        public override void SheetDelete(int sheetIdx)
        {
            MSExcelUtility.SheetDelete(book, sheetIdx);
        }

        public override void SetPageRowBreak(int rowIdx)
        {
            MSExcelUtility.SetPageBreak(currentSheet, rowIdx);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public override int GetSheetIdx(string sheetName)
        {
            return MSExcelUtility.GetSheetIndex(book, sheetName);
        }

        public override int GetCurrentSheetIdx()
        {
            if (currentSheet != null)
            {
                return GetSheetIdx(currentSheet.Name);
            }
            else
            {
                return -1;
            }
        }

    }
}
