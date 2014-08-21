using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Zynas.Framework.Core.Common.BusinessLogic.Print
{
    public class BaseSection
    {
        // TODO シート内で保持するべき項目(保持位置は別クラスにするか？)
        // セル数でなく、実寸でのカウントが望ましい

        // TODO レイアウトからのフォーマット自動生成は別途
        // TODO （当面は既存フォーマットのセル単位出力）

        // TODO マッピング設定部は独立した処理とする（レイアウト情報のファイルからの読込も考慮して）
        // TODO タイトル出力（シート内で一回のみ）
        // TODO 列単位での改ページは後回しでよい
        // TODO 実寸での扱いは後回しでよい
        // TODO TableAdapter, メソッド名をDataSouceとして指定するバリエーションも用意する（後で）

        /// <summary>
        /// Excel操作用オブジェクト
        /// </summary>
        public ExcelBind excel;

        #region セクション設定値変数

        // TODO 変数分類する

        /// <summary>
        /// 1レコード分の出力行数
        /// </summary>
        public int unitRowCnt = 1;
        /// <summary>
        /// セクション内の最大行数
        /// </summary>
        public int maxRowCnt = 0;
        /// <summary>
        /// セクションの最大の高さ
        /// </summary>
        public int maxRowHeight = 0;

        /// <summary>
        /// ページ内の開始位置
        /// </summary>
        public int pageRowOrigin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int pageColOrigin { get; set; }

        /// <summary>
        /// セクションのシート内行開始位置
        /// </summary>
        public int sectionRowOrigin { get; set; }
        /// <summary>
        /// セクションのシート内列開始位置
        /// </summary>
        public int sectionColOrigin { get; set; }

        /// <summary>
        /// セクションの行数
        /// </summary>
        public int sectionRowCnt { get; set; }

        /// <summary>
        /// セクションの列数
        /// </summary>
        public int sectionColCnt;

        // TODO 同じ値を複数の場所に出力する場合も一応考慮する

        private Dictionary<string, DataMapping> mappingMap;

        private List<string> pageBreakKeys = new List<string>();

        private List<int> mergeKeyCols = new List<int>();

        #endregion

        #region 内部状態変数

        // TODO 変数分類する

        /// <summary>
        /// 出力済み行数(マルチ行単位でなく、Excel行単位)
        /// </summary>
        public int outRowCnt { get; set; }

        #endregion

        #region 内部クラス

        // TODO 単票ならこれだけでよいが、、
        /// <summary>
        /// マッピング情報保持用内部クラス
        /// </summary>
        public class DataMapping
        {
            public int rowOffset;
            public int colOffset;
            public string propertyName;
        }

        // TODO セル出力用、オブジェクト出力用出力先指定クラス（Mappingで保持するのは、こちらの方が良い）
        public class OutputTarget
        {

        }

        #endregion

        public BaseSection()
        {
            // TODO コンストラクタ引数を渡す事

            // TODO 仮の値を設定
            unitRowCnt = 1;
            maxRowCnt = 100;
            maxRowHeight = 10000;

            mappingMap = new Dictionary<string, DataMapping>();
            pageBreakKeys = new List<string>();
            mergeKeyCols = new List<int>();
        }

        // TODO 出力日付など、ページ内で共通の項目はこちらで設定する
        public void SetFixData(object value, int rowOffset, int colOffset)
        {
            // TODO 早めに
        }

        /// <summary>
        /// データの出力先情報を指定
        /// </summary>
        /// <param name="col"></param>
        /// <param name="rowOffset"></param>
        /// <param name="colOffset"></param>
        public void SetMapping(DataColumn col, int rowOffset, int colOffset)
        {
            SetMapping(col.ColumnName, rowOffset, colOffset);
        }

        /// <summary>
        /// データの出力先情報を指定
        /// </summary>
        /// <param name="propName"></param>
        /// <param name="rowOffset"></param>
        /// <param name="colOffset"></param>
        public void SetMapping(string propName, int rowOffset, int colOffset)
        {
            // TODO UnitRowはここで自動設定しても良い（後で）

            // TODO 
            DataMapping map = new DataMapping();
            map.propertyName = propName;
            map.rowOffset = rowOffset;
            map.colOffset = colOffset;

            mappingMap.Add(propName, map);
        }

        /// <summary>
        /// データの出力先情報を指定
        /// </summary>
        /// <param name="propName"></param>
        /// <param name="colOffset"></param>
        public void SetMapping(string propName, int colOffset)
        {
            SetMapping(propName, 0, colOffset);
        }

        //public void SetMappingAnchor(string colName, string anchorStr)
        //{
        //    // TODO セル中の置換文字列を出力位置とする

        //    // TODO セルを検索して、位置を特定する

        //    // TODO 複数ある場合は、複数分を出力先とする
        //}

        //public void SetMappingCellName(string colName, string cellName)
        //{
        //    // TODO セル名を出力位置とする

        //    // TODO セルを検索して、位置を特定する
        //}

        // TODO 出力後の実寸を取得(自動改行などでサイズが変わる場合があるため、セル出力後に行う事)

        // TODO セクション内の実寸を累積

        // TODO 行数又は実寸のいずれかが上限を超えた場合は改ページを行う

        /// <summary>
        /// セクションのページ内領域を指定
        /// </summary>
        /// <param name="rowOrigin"></param>
        /// <param name="colOrigin"></param>
        /// <param name="rowCnt"></param>
        /// <param name="colCnt"></param>
        public void SetPageArea(int rowOrigin, int colOrigin, int rowCnt, int colCnt)
        {
            sectionRowOrigin = rowOrigin;
            sectionColOrigin = colOrigin;

            sectionRowCnt = rowCnt;
            sectionColCnt = colCnt;
        }

        // TODO 改ページなどの制御を親側で行う必要があるため、ここでは難しい
        //public void SetData(DataTable table)
        //{
        //    // TODO tableの各行の出力を実行

        //    int rowIdx = 0;
        //    foreach (DataRow row in table.Rows)
        //    {
        //        SetData(row, rowIdx);

        //        // TODO 改ページ時のヘッダ、フッタの扱いはどうする？

        //        rowIdx++;
        //    }
        //}

        /// <summary>
        /// セクションのページ内領域を指定
        /// </summary>
        /// <param name="rowOrigin"></param>
        /// <param name="rowCnt"></param>
        public void SetPageArea(int rowOrigin, int rowCnt)
        {
            SetPageArea(rowOrigin, 0, rowCnt, 0);
        }

        /// <summary>
        /// mm単位でのセクションの高さを設定
        /// </summary>
        public void SetSectionHeightmm(double mmHeight)
        {
            // TODO
        }

        public void SetRowHeightmm(double mmHeight, int idxRow)
        {
            // TODO 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mmLength">mm単位での長さ</param>
        /// <returns>pt単位での長さ</returns>
        private double mmToPt(double mmLength)
        {
            // TODO 

            return 0;
        }

        /// <summary>
        /// データを出力
        /// </summary>
        /// <param name="row"></param>
        /// <param name="idxRowOffset"></param>
        public void SetData(DataRow row, int idxRowOffset)
        {
            // TODO とりあえず、Excelメソッド呼び出しは、ベタでよい

            int idxInPage = idxRowOffset % maxRowCnt;

            // 各列ごとのデータ出力実行
            foreach (DataMapping map in mappingMap.Values)
            {
                try
                {
                    if (row.Table == null || row.Table.Columns.Contains(map.propertyName))
                    {
                        object value = row[map.propertyName];
                        // TODO ブロック出力も検討する
                        // セル出力実行
                        excel.CellOutput(pageRowOrigin + sectionRowOrigin + map.rowOffset + (idxInPage * unitRowCnt), pageColOrigin + sectionColOrigin + map.colOffset, value);
                    }
                }
                catch
                {
                    // 対象列がない場合は無効として、処理継続
                }
            }

            // 1レコード複数行の場合も、後で対応する
            outRowCnt += unitRowCnt;
        }

        /// <summary>
        /// 改ページ設定
        /// </summary>
        /// <param name="rowIdx"></param>
        public void SetPageBreak(int rowIdx)
        {
            // TODO 複数行の場合に正常に動作するか？
            // 複数行を考慮する
            SetPageBreakBare(pageRowOrigin + sectionRowOrigin + rowIdx + (unitRowCnt - 1), false);
        }

        /// <summary>
        /// 改ページ設定
        /// </summary>
        /// <param name="rowIdx"></param>
        /// <param name="splitMultiRow"></param>
        public void SetPageBreakBare(int rowIdx, bool splitMultiRow)
        {
            int breakRowIdx = 0;

            if ((rowIdx + 1) % unitRowCnt == 0)
            {
                breakRowIdx = rowIdx;
                // 普通に改ページ
                excel.SetPageRowBreak(breakRowIdx);
            }
            else
            {
                if (!splitMultiRow)
                {
                    breakRowIdx = rowIdx;
                    // 普通に改ページ
                    excel.SetPageRowBreak(breakRowIdx);
                }
                else
                {
                    breakRowIdx = (rowIdx + 1) / unitRowCnt * unitRowCnt - 1;
                    // マルチ行単位での改ページ
                    excel.SetPageRowBreak(breakRowIdx);
                }
            }
        }

        // TODO セクション種別毎の専用のメソッドは、専用にクラスに分ける

        /// <summary>
        /// 値が同じ場合にマージするカラムを設定
        /// </summary>
        /// <param name="colIdx"></param>
        public void SetMergeKeyCol(int colIdx)
        {
            mergeKeyCols.Add(colIdx);
        }

        public bool IsDetailPageBreak()
        {
            // 出力行数がページ内上限に達した場合
            if (outRowCnt > 0 && outRowCnt % maxRowCnt == 0)
            {
                return true;
            }
            else
            {
                // キー項目が切り替わった場合
                // TODO キー項目判定処理


                return false;
            }
        }

        public bool IsMaxRowHeightOver()
        {
            // TODO 
            return false;
        }

        // TODO 後で
        public void Reset()
        {
            // TODO 内部状態のリセット（変数の再初期化）
        }
    }
}
