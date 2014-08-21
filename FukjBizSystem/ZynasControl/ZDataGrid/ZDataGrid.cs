using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Zynas.Control.Common;

namespace Zynas.Control.ZDataGridView
{
    /// <summary>
    /// ZDataGridViewコントロールクラス
    /// 継承元:DataGridViewコントロール
    /// </summary>
    public partial class ZDataGridView : DataGridView
    {
        #region セルマージ用内部クラス

        /// <summary>
        /// マージ範囲情報保持クラス
        /// </summary>
        protected class MergeRange
        {
            // TODO 機能追加する場合、データ保持形式は随時検討・見直しする
            public int rowIdx = -1;
            public int colMergeUnit = 1;
            public int colIdx = -1;
            public int rowMergeUnit = 1;
            public bool isAutoMerge = false;
        }

        #endregion

        #region ドメイン制御用プロパティ

        /// <summary>
        /// ドメイン設定値保持データ
        /// </summary>
        Dictionary<int, ZControlDomain> ColumnControlDomain = new Dictionary<int, ZControlDomain>();

        Dictionary<int, int> ColumnLengthMap = new Dictionary<int, int>();

        #endregion

        #region セルマージ用プロパティ

        // TODO CellEditイベントも操作するか、検討（自動マージセルに、常に同じ値が設定される様、維持する）

        /// <summary>
        /// 縦方向(列)マージ範囲情報
        /// </summary>
        protected Dictionary<int, MergeRange> colMergeRangeMap = new Dictionary<int, MergeRange>();
        /// <summary>
        /// 横方向(行)マージ範囲情報
        /// </summary>
        protected Dictionary<int, MergeRange> rowMergeRangeMap = new Dictionary<int, MergeRange>();

        #endregion

        #region コンストラクタ
        /// <summary>
        /// デザイナで表示時のコンストラクタ
        /// </summary>
        public ZDataGridView()
        {
            #region デザイナによる初期化
            InitializeComponent();
            #endregion

            // マージセル用カスタム描画イベント
            CellPainting += dgv_CellPainting;
        }

        /// <summary>
        /// プログラム実行時のコンストラクタ
        /// </summary>
        /// <param name="container"></param>
        public ZDataGridView(IContainer container)
        {
            #region デザイナによる初期化
            container.Add(this);

            InitializeComponent();
            #endregion

            // マージセル用カスタム描画イベント
            CellPainting += dgv_CellPainting;
        }
        #endregion

        #region キーイベント追加 yoshiura 20120807 攻玉寮流用
        private void ZFlexGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enterキーの場合

            if (e.KeyChar == '\r')
            {
                //// Noneの場合は次の行に移行する。
                //if (this.KeyActionEnter == C1.Win.C1FlexGrid.KeyActionEnum.None)
                //{
                //    // キー入力を無効にし、列を移動
                //    e.Handled = true;
                //    int col = this.ColSel + 1;
                //    int row = this.RowSel;

                //    // 
                //    while (true)
                //    {
                //        if (col == this.Cols.Count)
                //        {
                //            col = 0;
                //            row++;
                //            if (row == this.Rows.Count)
                //            {
                //                break;
                //            }
                //            continue;
                //        }

                //        // MOD START 20130218 編集不可列はフォーカス移動 yoshiura
                //        //if (this.Cols[col].Visible == true &&
                //        //    this.Cols.Fixed <= col)
                //        if (this.Cols[col].Visible == true &&
                //            this.Cols.Fixed <= col &&
                //            this.Cols[col].AllowEditing)
                //        // MOD  END  20130218 編集不可列はフォーカス移動 yoshiura
                //        {
                //            this.Select(row, col);
                //            break;
                //        }

                //        col++;
                //    }
                //}
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZFlexGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //if (this.Rows.Fixed <= this.RowSel &&
                //    this.Cols.Fixed <= this.ColSel)
                //{
                //    if (this.AllowEditing == true &&
                //        this.Cols[this.ColSel].AllowEditing == true)
                //    {
                //        // 編集できる場合
                //        try
                //        {
                //            this.Rows[this.RowSel][this.ColSel] = String.Empty;
                //        }
                //        catch (Exception ex)
                //        {

                //            try
                //            {
                //                this.Rows[this.RowSel][this.ColSel] = DBNull.Value;
                //            }
                //            catch (Exception ex2)
                //            {
                //                // DBNullを入れれない場合は処理しない

                //            }
                //        }

                //        // イベントパラメータを生成
                //        RowColEventArgs arg = new RowColEventArgs(this.RowSel, this.ColSel);
                //        // 変更後のイベント
                //        this.OnAfterEdit(arg);
                //    }
                //}
            }
        }
        #endregion

        #region セルマージ用メソッド

        #region セルマージ範囲設定

        #region AddMergeRange
        /// <summary>
        /// セルマージ範囲設定
        /// </summary>
        /// <param name="rowIdx"></param>
        /// <param name="colMergeUnit"></param>
        /// <param name="colIdx"></param>
        /// <param name="rowMergeUnit"></param>
        /// <param name="autoMerge"></param>
        public void AddMergeRange(int rowIdx, int colMergeUnit, int colIdx, int rowMergeUnit, bool autoMerge)
        {
            MergeRange range = new MergeRange();

            range.rowIdx = rowIdx;
            range.colMergeUnit = colMergeUnit;
            range.colIdx = colIdx;
            range.rowMergeUnit = rowMergeUnit;
            range.isAutoMerge = autoMerge;

            if (!colMergeRangeMap.ContainsKey(colIdx))
            {
                colMergeRangeMap.Add(colIdx, range);
            }
            if (!rowMergeRangeMap.ContainsKey(rowIdx))
            {
                rowMergeRangeMap.Add(rowIdx, range);
            }
        }
        #endregion

        #region OverLoads
        #region AddAutoMergeCol
        /// <summary>
        /// セルマージ範囲設定(オーバーロード)
        /// </summary>
        /// <param name="colIdx"></param>
        /// <param name="rowMergeUnit"></param>
        protected void AddAutoMergeCol(int colIdx, int rowMergeUnit)
        {
            AddMergeRange(-1, 1, colIdx, rowMergeUnit, true);
        }
        #endregion

        #region AddAutoMergeCol
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colIdx"></param>
        public void AddAutoMergeCol(int colIdx)
        {
            AddAutoMergeCol(colIdx, 2);
        }
        #endregion

        #region AddMergeCol
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colIdx"></param>
        /// <param name="rowMergeUnit"></param>
        public void AddMergeCol(int colIdx, int rowMergeUnit)
        {
            AddMergeRange(-1, 1, colIdx, rowMergeUnit, false);
        }
        #endregion
        #endregion

        /// <summary>
        /// 列ヘッダマージ範囲設定
        /// </summary>
        /// <param name="colIdxFrom"></param>
        /// <param name="colIdxTo"></param>
        public void AddAutoMergeColHeader(int colIdxFrom, int colIdxTo)
        {
            // TODO ヘッダのマージは、できれば（一応可能な模様（カスタム描画で））必要な画面があれば実装する
        }
        #endregion

        #region ClearMergeCol
        /// <summary>
        /// 
        /// </summary>
        public void ClearMergeCol()
        {
            colMergeRangeMap.Clear();
            rowMergeRangeMap.Clear();
        }
        #endregion

        #region セルマージ用イベント
        /// <summary>
        /// マージセル用イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // セルの下側の境界線を「境界線なし」に設定
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            // 1行目や列ヘッダ、行ヘッダの場合は何もしない
            if (e.RowIndex < 1 || e.ColumnIndex < 0) { return; }

            // 1行上と同じ値の場合
            if (IsBeMergedCell((DataGridView)sender, e.ColumnIndex, e.RowIndex))
            {
                // セルの上側の境界線を「境界線なし」に設定
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

                e.PaintBackground(e.ClipBounds, true);
            }
            else
            {
                // セルの上側の境界線を既定の境界線に設定
                e.AdvancedBorderStyle.Top = ((DataGridView)sender).AdvancedCellBorderStyle.Top;

                e.PaintBackground(e.ClipBounds, true);
                e.PaintContent(e.ClipBounds);
            }

            e.Handled = true;
        }
        #endregion

        #region セルマージ判定用メソッド
        /// <summary>
        /// 被マージセル判定
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        protected bool IsBeMergedCell(DataGridView dgv, int col, int row)
        {
            MergeRange range = null;

            // マージ対象でない場合は、常に無効
            if (rowMergeRangeMap.ContainsKey(row))
            {
                range = rowMergeRangeMap[row];

                if (col % range.colMergeUnit == 0)
                {
                    return false;
                }
            }
            else if (colMergeRangeMap.ContainsKey(col))
            {
                range = colMergeRangeMap[col];

                // マージベースセルの場合は、対象外
                if (row % range.rowMergeUnit == 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            // 自動マージでない場合は、指定マージ範囲内で常にマージ
            if (!range.isAutoMerge)
            {
                return true;
            }
            // 自動マージの場合は、値のチェックを行い、同じ値であればマージ
            else
            {
                // マージベースセル位置算出
                int baseRowIdx = row / range.rowMergeUnit * range.rowMergeUnit;
                int baseColIdx = col / range.colMergeUnit * range.colMergeUnit;

                // マージベースセル
                DataGridViewCell cellMergeBase = dgv[baseColIdx, baseRowIdx];
                // 被マージセル
                DataGridViewCell cellBeMerged = dgv[col, row];

                // 両方ともnullの場合は同じ値とみなす
                if (cellBeMerged.Value == null && cellMergeBase.Value == null)
                {
                    return true;
                }
                // 片方のみnullの場合は異なる値とみなす
                else if (cellBeMerged.Value == null)
                {
                    return false;
                }
                else
                {
                    // カスタムクラスの場合、Equalsメソッドは適切に実装されている必要がある
                    if (cellBeMerged.Value.Equals(cellMergeBase.Value))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        #endregion

        #endregion

        #region ドメイン制御

        #region SetControlDomain
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colIdx"></param>
        /// <param name="domain"></param>
        public void SetControlDomain(int colIdx, ZControlDomain domain)
        {
            if (!ColumnControlDomain.ContainsKey(colIdx))
            {
                ColumnControlDomain.Add(colIdx, domain);
            }
            else
            {
                ColumnControlDomain[colIdx] = domain;
            }

            SetControlProperty(colIdx);
        }
        #endregion

        #region SetStdControlDomain
        /// <summary>
        /// 
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="maxLength"></param>
        public void SetStdControlDomain(int colIdx, ZControlDomain domain, int maxLength)
        {
            if (!ColumnControlDomain.ContainsKey(colIdx))
            {
                ColumnControlDomain.Add(colIdx, domain);
            }
            else
            {
                ColumnControlDomain[colIdx] = domain;
            }

            if (!ColumnLengthMap.ContainsKey(colIdx))
            {
                ColumnLengthMap.Add(colIdx, maxLength);
            }
            else
            {
                ColumnLengthMap[colIdx] = maxLength;
            }

            SetControlProperty(colIdx);
        }
        #endregion

        #region SetControlProperty
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colIdx"></param>
        public void SetControlProperty(int colIdx)
        {
            // ドメインが未設定の場合は無効
            if (!ColumnControlDomain.ContainsKey(colIdx))
            {
                return;
            }

            // 指定列のドメインを取得
            ZControlDomain conDomain = ColumnControlDomain[colIdx];

            // TODO マルチ行の場合の対応は別途検討する（使用頻度は低いはず）

            DataGridViewEditingControlShowingEventHandler stdEvent;
            stdEvent = CreateStdEditorHandler(colIdx, conDomain);

            if (conDomain == ZControlDomain.NONE)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                // 登録済みのハンドラを一旦削除(2重登録の防止)
                // TODO ここで削除するのは必要か？
                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;

            }
            else if (conDomain == ZControlDomain.ZG_STD_NAME)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;
            }
            else if (conDomain == ZControlDomain.ZG_STD_CD)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;
            }
            else if (conDomain == ZControlDomain.ZG_STD_NUM)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;
            }
            else if (conDomain == ZControlDomain.ZG_TEL_NO)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;
            }
            else if (conDomain == ZControlDomain.ZG_ZIP_CD)
            {
                Columns[colIdx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

                EditingControlShowing -= stdEvent;
                EditingControlShowing += stdEvent;
            }
        }
        #endregion

        #region CreateStdEditorHandler
        /// <summary>
        /// 
        /// </summary>
        /// <param name="colIdx"></param>
        /// <param name="domain"></param>
        /// <returns></returns>
        protected DataGridViewEditingControlShowingEventHandler CreateStdEditorHandler(int colIdx, ZControlDomain domain)
        {
            #region 個別パラメータ宣言

            int maxLength = int.MaxValue;
            ImeMode imeMode = System.Windows.Forms.ImeMode.On;

            #endregion

            DataGridViewEditingControlShowingEventHandler stdEvent;
            stdEvent = delegate(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                // カラムインデックスチェック
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Index != colIdx)
                {
                    return;
                }

                // TODO イベントハンドラを追加する場合は、2重登録防止を考慮する

                if (e.Control is DataGridViewTextBoxEditingControl)
                {
                    (e.Control as DataGridViewTextBoxEditingControl).MaxLength = maxLength;
                    (e.Control as DataGridViewTextBoxEditingControl).ImeMode = imeMode;
                }
                else if (e.Control is DataGridViewComboBoxEditingControl)
                {
                    (e.Control as DataGridViewComboBoxEditingControl).MaxLength = maxLength;
                    (e.Control as DataGridViewComboBoxEditingControl).ImeMode = imeMode;

                    // TODO これは必要か検討する（多分不要）
                    //(e.Control as DataGridViewComboBoxEditingControl).DropDownStyle = ComboBoxStyle.DropDownList;
                }
            };

            #region カラム毎、個別イベントパラメータ設定

            if (domain == ZControlDomain.NONE)
            {
                // NONE
            }
            else if (domain == ZControlDomain.ZG_STD_NAME)
            {
                maxLength = ColumnLengthMap[colIdx];
                imeMode = ImeMode.Hiragana;
            }
            else if (domain == ZControlDomain.ZG_STD_CD)
            {
                maxLength = ColumnLengthMap[colIdx];
                imeMode = ImeMode.Off;
            }
            else if (domain == ZControlDomain.ZG_STD_NUM)
            {
                maxLength = ColumnLengthMap[colIdx];
                imeMode = ImeMode.Off;
            }
            else if (domain == ZControlDomain.ZG_TEL_NO)
            {
                maxLength = 13;
                imeMode = ImeMode.Off;
            }
            else if (domain == ZControlDomain.ZG_ZIP_CD)
            {
                maxLength = 8;
                imeMode = ImeMode.Off;
            }

            #endregion

            return stdEvent;
        }
        #endregion

        #region DoValidate
        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="autoFocus"></param>
        /// <param name="isNessesary"></param>
        public bool DoValidate(int rowIdx, int colIdx, bool isNesessary, string controlDispName, out string errorMsg, bool autoFocus)
        {
            bool validateOk = true;
            errorMsg = string.Empty;

            // 指定列のドメインを取得
            ZControlDomain controlDomain = ColumnControlDomain[colIdx];

            string checkValue = string.Empty;

            if (this[rowIdx, colIdx].Value == null)
            {
                checkValue = string.Empty;
            }
            // NOTICE currentry supports only string values
            else if (!(this[rowIdx, colIdx].Value is string))
            {
                return true;
            }
            else
            {
                checkValue = (string)this[rowIdx, colIdx].Value;
            }

            // 必須チェック
            if (isNesessary && string.IsNullOrEmpty(checkValue))
            {
                validateOk = false;
                errorMsg = string.Format("必須項目：{0}が入力されていません。", controlDispName);
            }

            if (controlDomain == ZControlDomain.ZT_STD_NAME)
            {

            }
            else if (controlDomain == ZControlDomain.ZT_STD_CD)
            {
                validateOk = InputValidateUtility.ValidateString(checkValue, "9");
                if (!validateOk) { errorMsg = controlDispName + "は半角数字で入力して下さい。"; }
            }
            else if (controlDomain == ZControlDomain.ZT_STD_NUM)
            {
                validateOk = InputValidateUtility.ValidateString(checkValue, "9");
                if (!validateOk) { errorMsg = controlDispName + "は半角数字で入力して下さい。"; }
            }

            // 該当コントロールにフォーカス
            if (!validateOk && autoFocus)
            {
                Focus();

                this[rowIdx, colIdx].Selected = true;
            }

            return validateOk;
        }
        #endregion

        #endregion
    }
}
