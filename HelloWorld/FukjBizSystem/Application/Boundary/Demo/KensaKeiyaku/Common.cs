using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace KensaYoteiMapDemo
{
    public class Common
    {

    }

    // TODO 実体をクラスにするか、DataTableにするかは、要検討
    /// <summary>
    /// 検査予定データ
    /// </summary>
    public class KensaYoteiData
    {
        //// TODO プロトタイプなので、ひとまず協会Noをキーとする
        // TODO 実際には、受付Noあたりを使用するか？
        //string KyokaiNo;
        //string Settisha;
        //string SettiBasho;
        //string MapNo;
        //string UniComposit;
        //string Ninsou;
        //string KanriGyosha;
        //string Kensain;
        //string HagakiShubetsu;

        //string Memo1;
        //string Memo2;
        //string Memo3;

        //// 以下、各回の検査ごとデータ(今回のモックではどちらでも関係ない)
        //string KensaYoteiDate;
        //string KensaShubetsu;

        // TODO 現状、staticとしているが、実際に使用するのであれば、
        // TODO 関連クラス間にインスタンスを持たせること
        public static DataTable KensaYoteiData2 = null;

        /// <summary>
        /// テスト用データを取得
        /// </summary>
        /// <returns></returns>
        public static DataTable GetKensaYoteiData()
        {
            if (KensaYoteiData2 == null)
            {
                KensaYoteiData2 = CreateKensaYoteiData();
            }

            return KensaYoteiData2;
        }

        public static DataTable CreateKensaYoteiData()
        {
            DataTable table = new DataTable();

            table.Columns.Add("KYOKAI_NO" , typeof(string));
            table.Columns.Add("SETTISHA", typeof(string));
            table.Columns.Add("SETTI_BASHO", typeof(string));
            table.Columns.Add("MAP_NO", typeof(string));
            table.Columns.Add("UNI_COMPOSIT", typeof(string));
            table.Columns.Add("NINSOU", typeof(int));
            table.Columns.Add("KANRI_GYOSHA", typeof(string));
            table.Columns.Add("KENSAIN", typeof(string));
            table.Columns.Add("HAGAKI_SHUBETSU", typeof(string));
            table.Columns.Add("MEMO1", typeof(string));
            table.Columns.Add("MEMO2", typeof(string));
            table.Columns.Add("MEMO3", typeof(string));
            table.Columns.Add("KENSA_YOTEI_NEN", typeof(string));
            table.Columns.Add("KENSA_YOTEI_TSUKI", typeof(string));
            table.Columns.Add("KENSA_YOTEI_NITI", typeof(string));
            table.Columns.Add("KENSA_SHUBETSU", typeof(string));

            // TODO テスト用データ生成
            // TODO デモに必要な分だけ、生成する
            {
                DataRow row = table.NewRow();

                row["KYOKAI_NO"] = "16-27-001894";
                row["SETTISHA"] = "山田 太郎";
                // TODO 適当な住所を設定（評価版に含まれる地域（渋谷駅周辺））
                row["SETTI_BASHO"] = "東京都渋谷区道玄坂2丁目";
                row["MAP_NO"] = "7GH1";
                row["UNI_COMPOSIT"] = "小型合併";
                row["NINSOU"] = 7;
                row["KANRI_GYOSHA"] = "管理業者A";
                row["KENSAIN"] = "012:鈴木次郎";
                row["HAGAKI_SHUBETSU"] = "";
                row["MEMO1"] = "上部浄化槽(開店前に検査実施)";
                row["MEMO2"] = "開店時刻９時";
                row["MEMO3"] = "電話連絡必要";
                row["KENSA_YOTEI_NEN"] = "26";
                row["KENSA_YOTEI_TSUKI"] = "10";
                row["KENSA_YOTEI_NITI"] = "01";
                row["KENSA_SHUBETSU"] = "11条";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["KYOKAI_NO"] = "16-27-001895";
                row["SETTISHA"] = "山田 太郎";
                row["SETTI_BASHO"] = "東京都渋谷区宇田川町";
                row["MAP_NO"] = "7GH1";
                row["UNI_COMPOSIT"] = "小型合併";
                row["NINSOU"] = 51;
                row["KANRI_GYOSHA"] = "管理業者A";
                row["KENSAIN"] = "012:鈴木次郎";
                row["HAGAKI_SHUBETSU"] = "";
                row["MEMO1"] = "点検日に合わせ検査実施";
                row["MEMO2"] = "検査時刻１３時";
                row["MEMO3"] = "";
                row["KENSA_YOTEI_NEN"] = "26";
                row["KENSA_YOTEI_TSUKI"] = "10";
                row["KENSA_YOTEI_NITI"] = "02";
                row["KENSA_SHUBETSU"] = "11条";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["KYOKAI_NO"] = "16-27-001896";
                row["SETTISHA"] = "山田 太郎";
                row["SETTI_BASHO"] = "東京都渋谷区道玄坂1丁目2-2";
                row["MAP_NO"] = "7GH1";
                row["UNI_COMPOSIT"] = "小型合併";
                row["NINSOU"] = 50;
                row["KANRI_GYOSHA"] = "管理業者A";
                row["KENSAIN"] = "012:鈴木次郎";
                row["HAGAKI_SHUBETSU"] = "";
                row["MEMO1"] = "門施錠有(連絡必要)";
                row["MEMO2"] = "";
                row["MEMO3"] = "";
                row["KENSA_YOTEI_NEN"] = "26";
                row["KENSA_YOTEI_TSUKI"] = "10";
                row["KENSA_YOTEI_NITI"] = "03";
                row["KENSA_SHUBETSU"] = "11条";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["KYOKAI_NO"] = "16-27-001897";
                row["SETTISHA"] = "山田 太郎";
                row["SETTI_BASHO"] = "東京都渋谷区渋谷";
                row["MAP_NO"] = "7GH1";
                row["UNI_COMPOSIT"] = "小型合併";
                row["NINSOU"] = 7;
                row["KANRI_GYOSHA"] = "管理業者A";
                row["KENSAIN"] = "012:鈴木次郎";
                row["HAGAKI_SHUBETSU"] = "";
                row["MEMO1"] = "上部浄化槽(開店前に検査実施)";
                row["MEMO2"] = "開店時刻９時";
                row["MEMO3"] = "電話連絡必要";
                row["KENSA_YOTEI_NEN"] = "26";
                row["KENSA_YOTEI_TSUKI"] = "10";
                row["KENSA_YOTEI_NITI"] = "04";
                row["KENSA_SHUBETSU"] = "11条";

                table.Rows.Add(row);
            }
            {
                DataRow row = table.NewRow();

                row["KYOKAI_NO"] = "16-27-001898";
                row["SETTISHA"] = "山田 太郎";
                row["SETTI_BASHO"] = "東京都渋谷区渋谷";
                row["MAP_NO"] = "7GH1";
                row["UNI_COMPOSIT"] = "小型合併";
                row["NINSOU"] = 7;
                row["KANRI_GYOSHA"] = "管理業者A";
                row["KENSAIN"] = "013:鈴木三郎";
                row["HAGAKI_SHUBETSU"] = "";
                row["MEMO1"] = "上部浄化槽(開店前に検査実施)";
                row["MEMO2"] = "開店時刻９時";
                row["MEMO3"] = "電話連絡必要";
                row["KENSA_YOTEI_NEN"] = "26";
                row["KENSA_YOTEI_TSUKI"] = "10";
                row["KENSA_YOTEI_NITI"] = "04";
                row["KENSA_SHUBETSU"] = "11条";

                table.Rows.Add(row);
            }

            return table;
        }

        public static void SetKensaYoteiDate(string keyValue , string newYoteiDate)
        {
            // メモリ保持データの検査予定日を更新する
            // TODO キーは何にするか？ -> 協会Noで寄り合えず

            DataTable currentKensaData = GetKensaYoteiData();

            // TODO .Selectでも良い
            foreach (DataRow row in currentKensaData.Rows)
            {
                if ((string)row["KYOKAI_NO"] == keyValue)
                {
                    // TODO
                    //row["KENSA_YOTEI_DATE"] = newYoteiDate;
                }
            }
        }
    }

}
