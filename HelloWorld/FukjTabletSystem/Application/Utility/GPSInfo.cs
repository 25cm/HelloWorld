using System;
using System.Device.Location;
using System.Threading;

namespace FukjTabletSystem.Application.Utility
{
    #region GPSInfo
    /// <summary>
    /// GPS位置情報取得クラス
    /// </summary>
    public class GPSInfo : IDisposable
    {
        #region フィールド(private)

        /// <summary>
        /// 位置情報サービス
        /// </summary>
        private GeoCoordinateWatcher wtc;

        /// <summary>
        /// 緯度
        /// </summary>
        private double Latitude = double.MinValue;

        /// <summary>
        /// 経度
        /// </summary>
        private double Longitude = double.MinValue;

        /// <summary>
        /// 位置情報更新済み
        /// </summary>
        private bool IsComplete = false;

        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GPSInfo()
        {
            IsComplete = false;

            // GPS入力を開始
            wtc = new GeoCoordinateWatcher();
            wtc.PositionChanged += new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(wtc_PositionChanged);
            wtc.Start();
        }
        #endregion

        #region デストラクタ
        /// <summary>
        /// デストラクタ
        /// </summary>
        ~GPSInfo()
        {
            Dispose();
        }
        #endregion

        #region Dispose
        /// <summary>
        /// 開放処理
        /// </summary>
        public void Dispose()
        {
            if (wtc != null)
            {
                wtc.Dispose();
            }
        }
        #endregion

        #region イベントハンドラ

        #region wtc_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        /// <summary>
        /// イベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wtc_PositionChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            // 位置情報を更新
            Latitude = e.Position.Location.Latitude;            
            Longitude = e.Position.Location.Longitude;
            
            IsComplete = true;
        }
        #endregion

        #endregion

        #region メソッド(public)

        #region GetLocation(ref double latitude, ref double longitude, int timeout)
        /// <summary>
        /// 位置情報を取得する
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool GetLocation(ref double latitude, ref double longitude, int timeout)
        {
            int timer = 0;

            // 位置情報が更新されるまで待つ
            while (true)
            {
                if (IsComplete)
                {
                    latitude = Latitude;
                    longitude = Longitude;

                    return true;
                }

                if (timer > timeout * 1000)
                {
                    return false;
                }

                timer += 500;

                Thread.Sleep(500);
            }
        }
        #endregion

        #endregion
    }
    #endregion
}
