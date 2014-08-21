using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Zynas.Framework.Core.Common.BusinessLogic.Print
{
    public class PrintHelper
    {
        #region public property

        /// <summary>
        /// 改ページにヘッダの実体を出力する(タイトル行を使用しない)
        /// </summary>
        public bool duplicateHeader = false;

        /// <summary>
        /// テンプレートシート名
        /// </summary>
        public string templateSheetName { get; set; }

        public ExcelBind excel { get; set; }

        #endregion

        #region private propterty

        private BaseSection detailSection = null;

        private BaseSection headerSection = null;

        private BaseSection footerSection = null;

        private IList<DataRow> outputDetailRowsList = null;
        private IEnumerable<DataRow> outputDetailRowsEnum = null;

        private IList<DataRow> outputHeaderRowsList = null;
        private IEnumerable<DataRow> outputHeaderRowsEnum = null;

        private IList<DataRow> outputFooterRowsList = null;
        private IEnumerable<DataRow> outputFooterRowsEnum = null;

        #endregion

        /// <summary>
        /// process real output
        /// </summary>
        public void Output()
        {
            // TODO PrintBLからの呼出しかたは検討（場合によってはこのメソッドの中身自体を移植する）

            // TODO テンプレートシートが複数の場合を考慮する

            // TODO 出力データ中のキーによる、ページ切替、シート切替を実装

            // TODO オプショナルでExcelオブジェクトを触れる方法を、なにかしら用意する

            // 出力開始

            // TODO データキーによる、ページブレーク・シートブレークを実装する

            // テンプレートシートをコピー(以降はコピーしたシートを出力先とする)
            excel.SheetCopy(excel.GetSheetIdx(templateSheetName));

            // TODO 出力先シート名を設定する（データに応じたものを使用できるようにする）

            // 出力明細行数カウント
            int rowCnt = 0;
            if (outputDetailRowsList != null)
            {
                rowCnt = outputDetailRowsList.Count;
            }
            else if (outputDetailRowsEnum != null)
            {
                rowCnt = outputDetailRowsEnum.Count<DataRow>();
            }

            // 最初のヘッダを出力
            OutputHeaderData(0);

            int idxPage = 0;
            for (int i = 0; i < rowCnt; i++)
            {
                // 1明細出力
                OutputDetailData(i);

                // ページ内行数算出
                int pageRowCnt = 0;
                if (footerSection != null)
                {
                    pageRowCnt = footerSection.sectionRowOrigin + footerSection.sectionRowCnt - 1;
                }
                else if (detailSection != null)
                {
                    pageRowCnt = detailSection.sectionRowOrigin + detailSection.sectionRowCnt - 1;
                }

                // ページ内出力済み行数算出
                int pageOutRowPos = 0;
                if (detailSection != null)
                {
                    pageOutRowPos = detailSection.sectionRowOrigin + detailSection.outRowCnt - 1;
                }

                // TODO フッタを明細行の最終出力位置の直下に出力できる方法を設ける(使用頻度は低いはずだが、、、)

                // 改ページ判定(フッタを出力できるスペースを残す)
                //int pageRowCnt = 25;
                //int pageRowCnt = detailSection.sectionRowOrigin + detailSection.outRowCnt
                //    + (headerSection.sectionRowOrigin + headerSection.outRowCnt)
                //    + (footerSection.sectionRowCnt);

                if (detailSection.IsDetailPageBreak())
                //if (pageRowCnt >= footerSection.sectionRowOrigin + footerSection.sectionRowCnt)
                {
                    // フッタ出力
                    OutputFooterData(0);

                    // TODO 現在ページを判定する処理を入れる

                    // TODO 改ページ処理
                    if (footerSection != null)
                    {
                        footerSection.SetPageBreak(0);
                    }
                    else if (detailSection != null)
                    {
                        detailSection.SetPageBreak(i);
                    }

                    // TODO タイトル行を使用する場合を考慮する事（ページ内行数が1ページ目とそれ以降で異なる）

                    // ページを進める
                    idxPage++;

                    int nextPageBase = (pageRowCnt + 1) * idxPage;

                    // 各セクションのPageOriginを更新する
                    headerSection.pageRowOrigin = nextPageBase;
                    detailSection.pageRowOrigin = nextPageBase;
                    footerSection.pageRowOrigin = nextPageBase;

                    // テンプレートシートから、内容をコピー
                    excel.RowCopy(excel.GetSheetIdx(templateSheetName), headerSection.sectionRowOrigin, excel.GetCurrentSheetIdx(), headerSection.sectionRowOrigin + nextPageBase, headerSection.sectionRowCnt);
                    excel.RowCopy(excel.GetSheetIdx(templateSheetName), detailSection.sectionRowOrigin, excel.GetCurrentSheetIdx(), detailSection.sectionRowOrigin + nextPageBase, detailSection.sectionRowCnt);
                    excel.RowCopy(excel.GetSheetIdx(templateSheetName), footerSection.sectionRowOrigin, excel.GetCurrentSheetIdx(), footerSection.sectionRowOrigin + nextPageBase, footerSection.sectionRowCnt);

                    // Excelのタイトル行を使用しない場合は、ヘッダの実体を出力する
                    if (duplicateHeader)
                    {
                        // ヘッダ出力
                        OutputHeaderData(0);
                    }
                }
            }

            // 最後のフッタを出力
            OutputFooterData(0);

            if (footerSection != null)
            {
                footerSection.SetPageBreak(0);
            }

            // テンプレートシートを削除する
            excel.SheetDelete(excel.GetSheetIdx(templateSheetName));
        }

        public void SetDetailSection(BaseSection section)
        {
            detailSection = section;
        }

        public void SetHeaderSection(BaseSection section)
        {
            headerSection = section;
        }

        public void SetFooterSection(BaseSection section)
        {
            footerSection = section;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// table data should be sorted to output order 
        /// </remarks>
        /// <param name="table"></param>
        public void SetDetailData(DataTable table)
        {
            outputDetailRowsEnum = table.Rows.OfType<DataRow>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// row data should be sorted to output order 
        /// </remarks>
        /// <param name="table"></param>
        public void SetDetailData(DataRow[] rows)
        {
            outputDetailRowsList = rows;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="table"></param>
        public void SetHeaderData(DataTable table)
        {
            outputHeaderRowsEnum = table.Rows.OfType<DataRow>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="table"></param>
        public void SetHeaderData(DataRow[] rows)
        {
            outputHeaderRowsList = rows;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="table"></param>
        public void SetFooterData(DataTable table)
        {
            outputFooterRowsEnum = table.Rows.OfType<DataRow>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="table"></param>
        public void SetFooterData(DataRow[] rows)
        {
            outputFooterRowsList = rows;
        }

        public BaseSection GetDetailSection()
        {
            if (detailSection == null)
            {
                detailSection = new BaseSection();
                detailSection.excel = excel;
            }

            return detailSection;
        }

        public BaseSection GetHeaderSection()
        {
            if (headerSection == null)
            {
                headerSection = new BaseSection();
                headerSection.excel = excel;
            }

            return headerSection;
        }

        public BaseSection GetFooterSection()
        {
            if (footerSection == null)
            {
                footerSection = new BaseSection();
                footerSection.excel = excel;
            }

            return footerSection;
        }

        public void SetPageBreakKey(List<string> keys)
        {
            // TODO detailSectionに対して設定する
        }

        public void SetSheetBreakKey(List<string> keys)
        {
            // TODO detailSectionに対して設定する
        }

        #region private

        private void OutputDetailData(int idx)
        {
            if (outputDetailRowsList != null && outputDetailRowsList.Count > idx)
            {
                detailSection.SetData(outputDetailRowsList[idx], idx);
            }
            else if (outputDetailRowsEnum != null && outputDetailRowsEnum.Count<DataRow>() > idx)
            {
                detailSection.SetData(outputDetailRowsEnum.ElementAt<DataRow>(idx), idx);
            }
        }

        private void OutputHeaderData(int idx)
        {
            if (outputHeaderRowsList != null && outputHeaderRowsList.Count > idx)
            {
                headerSection.SetData(outputHeaderRowsList[idx], idx);
            }
            else if (outputHeaderRowsEnum != null && outputHeaderRowsEnum.Count<DataRow>() > idx)
            {
                headerSection.SetData(outputHeaderRowsEnum.ElementAt<DataRow>(idx), idx);
            }
        }

        private void OutputFooterData(int idx)
        {
            if (outputFooterRowsList != null && outputFooterRowsList.Count > idx)
            {
                footerSection.SetData(outputFooterRowsList[idx], idx);
            }
            else if (outputFooterRowsEnum != null && outputFooterRowsEnum.Count<DataRow>() > idx)
            {
                footerSection.SetData(outputFooterRowsEnum.ElementAt<DataRow>(idx), idx);
            }
        }

        #endregion

    }
}
