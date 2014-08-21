using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MapWorks50;
using MapWorksViewer.MapWorks;

namespace KensaYoteiMapDemo
{
    public partial class KensaYoteiMap : Form
    {
        #region enum

        // NOTICE 順番は通常アイコン , 同点滅アイコンの順にすること
        public enum YOTEI_ICON_TYPE
        {
            /// <summary>
            /// 本日検査予定
            /// </summary>
            YOTEI_TODAY,
            /// <summary>
            /// 本日検査予定
            /// </summary>
            YOTEI_TODAY_BLINK,
        }

        public enum MAP_MODE
        {
            /// <summary>
            /// 通常
            /// </summary>
            NORMAL,
            /// <summary>
            /// 検査予定アイコン移動用
            /// </summary>
            MOVE,
        }

        #endregion

        #region 定数

        /// <summary>
        /// アイコンにフキダシ表示する際の、マウスカーソル検知範囲
        /// </summary>
        private const int MOUSE_MOVE_RANGE = 500;

        /// <summary>
        /// アイコン表示レイヤ番号
        /// </summary>
        private const int ICON_LAYER_NO = 1;

        #endregion

        #region プロパティ

        /// <summary>
        /// 画面モード
        /// </summary>
        private MAP_MODE mode = MAP_MODE.NORMAL;

        /// <summary>
        /// 選択された、移動対象の検査予定アイコン
        /// </summary>
        private Guid currentMoveTraget;

        #endregion

        #region 連携対象画面

        public KensaMemoList memoForm;
        public KensaYoteiCalender calenderForm;
        public KensaYoteiList yoteiForm;

        #endregion

        // オブジェクトを後で操作・削除する場合は、ObjectID(or ラッパーオブジェクト)を保持しておく必要がある
        // MObject系のクラスを保持するか、ObjectIDそのものを保持するかは検討
        // データキー指定参照用
        private Dictionary<string, KensaYoteiIcon> yoteiIconDataKeyMap = new Dictionary<string, KensaYoteiIcon>();
        // オブジェクトID指定参照用
        private Dictionary<object, KensaYoteiIcon> yoteiIconObjectIDMap = new Dictionary<object, KensaYoteiIcon>();

        // 同じアイコンのインスタンスは共有する
        private static System.Drawing.Image imgKensaToday = global::FukjBizSystem.Properties.Resources.yoteiIcon1;
        private static System.Drawing.Image imgKensaTodayBlink = global::FukjBizSystem.Properties.Resources.yoteiIcon1b;

        //拡大ｽﾞｰﾑ率
        private int ZoomInRate = 0;
        //縮小ｽﾞｰﾑ率
        private int ZoomOutRate = 0;

        const int DEFAULT_SCALE = 2000;

        // TODO この辺の挙動はもう少し検討
        /// <summary>
        /// 初期状態での縮尺
        /// </summary>
        private int stdMapScale = 0;
        /// <summary>
        /// 予定アイコン表示位置に移動する際の縮尺
        /// </summary>
        private int yoteiIconMapScale = 0;

        #region 内部クラス

        /// <summary>
        /// 検査予定アイコンデータ一式
        /// </summary>
        private class KensaYoteiIcon
        {
            /// <summary>
            /// 検査予定データキー
            /// </summary>
            public string key;

            /// <summary>
            /// 検査予定アイコン
            /// </summary>
            public MBitmap kensaYoteiIconBitMap;
            /// <summary>
            /// 検査予定アイコン(点滅用)
            /// </summary>
            public MBitmap kensaYoteiIconBitMapBlink;
            /// <summary>
            /// 検査予定日ラベル
            /// </summary>
            public MLabel kensaYoteiDateLabel;
            /// <summary>
            /// 検査予定内容フキダシ
            /// </summary>
            public MLabel kensaYoteiMemoLabel;
            //public MRect kensaYoteiSelectRect;

            public void GetIconPos(out int x, out int y)
            {
                x = kensaYoteiIconBitMap.X;
                y = kensaYoteiIconBitMap.Y;
            }

            public string GetKensaYoteiDate()
            {
                return kensaYoteiDateLabel.LabelString;
            }

            public MLabel SetKensaYoteiDate(string date)
            {
                kensaYoteiDateLabel.LabelString = date;
                kensaYoteiDateLabel.Update();

                return kensaYoteiDateLabel;
            }

            public MBitmap SetKensaYoteiBlink(bool blink)
            {
                // SetBitmapでの差し替えが機能しないため、点滅用画像の差し替えで対応する
                if (blink)
                {
                    //kensaYoteiIconBitMap.SetBitmap(imgKensaTodayBlink);
                    kensaYoteiIconBitMap.Visible = false;
                    kensaYoteiIconBitMapBlink.Visible = true;
                    kensaYoteiIconBitMap.FileName = "blink";
                }
                else
                {
                    //kensaYoteiIconBitMap.SetBitmap(imgKensaToday);
                    kensaYoteiIconBitMap.Visible = true;
                    kensaYoteiIconBitMapBlink.Visible = false;
                    kensaYoteiIconBitMap.FileName = "normal";
                }

                return kensaYoteiIconBitMap;
            }

            /// <summary>
            /// フキダシ表示状態取得
            /// </summary>
            /// <returns></returns>
            public bool GetKensaYoteiMemoVisible()
            {
                return kensaYoteiMemoLabel.Visible;
            }

            /// <summary>
            /// フキダシ表示状態設定
            /// </summary>
            /// <remarks>
            /// 設定後呼出側で、オーバーレイの再描画を行う必要がある
            /// </remarks>
            /// <param name="isVisible"></param>
            /// <returns></returns>
            public MLabel SetKensaYoteiMemoVisible(bool isVisible)
            {
                if (isVisible)
                {
                    kensaYoteiMemoLabel.Visible = true;
                }
                else
                {
                    kensaYoteiMemoLabel.Visible = false;
                }

                return kensaYoteiMemoLabel;
            }

            //public MRect SetKensaYoteiSelected(bool isSelected)
            //{
            //    if (isSelected)
            //    {
            //        //kensaYoteiSelectRect.LineWidth = 3;
            //        kensaYoteiSelectRect.Visible = true;
            //    }
            //    else
            //    {
            //        //kensaYoteiSelectRect.LineWidth = 0;
            //        kensaYoteiSelectRect.Visible = false;
            //    }

            //    return kensaYoteiSelectRect;
            //}
        }

        #endregion

        #region コンストラクタ

        public KensaYoteiMap()
        {
            InitializeComponent();

        }

        #endregion

        #region イベント

        #region KensaYoteiMap_Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KensaYoteiMap_Load(object sender, EventArgs e)
        {
            // MapWorks初期化
            InitMapWorks();

            // １番目のオーバーレイを指定
            MOverlay objMOverlay = mwView1.MOverlays[0];

            // アイコン用レイヤーが存在しない場合は生成
            if (objMOverlay.MLayers.GetLayer(ICON_LAYER_NO) == null)
            {
                objMOverlay.MLayers.Add(CreateNewLayer());
            }

            // MapWorksオブジェクトコレクションを取得
            MObjects objects = objMOverlay.MObjects;

            // TODO この辺の扱いは改めて検討する(アイコン等をテンポラリオブジェクトにすれば、起動時に毎回の削除は必要ないが、、、)
            // TODO MapWorksViewerでアイコンの表示が確認できるので、デバッグ時はテンポラリでない方が便利か
            //オブジェクトを一旦全て削除
            //objects.RemoveAll();
            objects.RemoveOnLayer(ICON_LAYER_NO);

            #region 表示データ設定

            DataTable table = KensaYoteiData.GetKensaYoteiData();

            int addrX = 0;
            int addrY = 0;
            // 表示データがない場合は固定位置に移動
            if (table.Rows.Count == 0)
            {
                // TODO 仮で設定位置に移動(福岡県久留米市中央町を初期値とする）
                mwView1.DrawMap(469816053, 119937081, 1000 * 4);
            }
            else
            {


                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];

                    // 住所文字列から、座標を取得
                    short kno = 0;
                    int nMapScale = GetInitMapScale();
                    short gt = mwView1.GetAddressCoord(0, (string)row["SETTI_BASHO"], "", "", ref kno, ref addrX, ref addrY);

                    // キー、座標、予定日から、アイコンを生成・表示
                    // TODO 予定日の年の表示は不要か、、、？
                    string tooltipStr =
                          "検査種別:" + (string)row["KENSA_SHUBETSU"] + "\r\n"
                        + "設置者:" + (string)row["SETTISHA"] + "\r\n"
                        + "設定場所:" + (string)row["SETTI_BASHO"] + "\r\n"
                        + "メモ:" + (string)row["MEMO1"] + "\r\n" + (string)row["MEMO2"] + "\r\n" + (string)row["MEMO3"]
                        ;
                    CreateKensaYoteiIcon(objects, (string)row["KYOKAI_NO"], addrX + i * 400, addrY - i * 400, (string)row["KENSA_YOTEI_NEN"] + "/" + (string)row["KENSA_YOTEI_TSUKI"] + "/" + (string)row["KENSA_YOTEI_NITI"], tooltipStr, YOTEI_ICON_TYPE.YOTEI_TODAY);

                    // TODO 仮で設定位置に移動
                    mwView1.DrawMap(addrX, addrY, nMapScale * 4);

                }
            }

            #endregion

            // 地図の再描画
            mwView1.Refresh();

            ////広域図の表示
            //mnuDispArea.Checked = false;

            // 初回は通常モードで表示
            ToNormalMode();
        }
        #endregion

        private void memoListButton_Click(object sender, EventArgs e)
        {
            if (memoForm == null || memoForm.IsDisposed)
            {
                memoForm = new KensaMemoList(this);
            }
            memoForm.Show();
        }

        private void calenderButton_Click(object sender, EventArgs e)
        {
            if (calenderForm == null || calenderForm.IsDisposed)
            {
                calenderForm = new KensaYoteiCalender();
            }
            calenderForm.Show();
        }

        private void yoteiListButton_Click(object sender, EventArgs e)
        {
            if (yoteiForm == null || yoteiForm.IsDisposed)
            {
                yoteiForm = new KensaYoteiList(this);
            }
            yoteiForm.Show();
        }

        private void heijyunkaButton_Click(object sender, EventArgs e)
        {
            KensaYoteiHeijyunForm frm = new KensaYoteiHeijyunForm();
            frm.Show();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            if (memoForm == null || memoForm.IsDisposed)
            {
                memoForm = new KensaMemoList(this);
            }
            memoForm.Show();
            if (calenderForm == null || calenderForm.IsDisposed)
            {
                calenderForm = new KensaYoteiCalender();
            }
            calenderForm.Show();
            if (yoteiForm == null || yoteiForm.IsDisposed)
            {
                yoteiForm = new KensaYoteiList(this);
            }
            yoteiForm.Show();

            KensaYoteiHeijyunForm frm = new KensaYoteiHeijyunForm();
            frm.Show();
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            // 拡大表示
            mwView1.Zoom((short)ZoomInRate);
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            // 縮小表示
            mwView1.Zoom((short)ZoomOutRate);
        }

        private void mwView1_Click(object sender, EventArgs e)
        {
            // 選択されたｵﾌﾞｼﾞｪｸﾄ
            object vObjectID = mwView1.GetSelectedObjectID(0);

            // アイコン選択処理
            if (vObjectID != null)
            {
                foreach (string key in yoteiIconDataKeyMap.Keys)
                {
                    // TODO この比較方法でよいか？(ネットワーク版とスタンドアローン版で、IDの型の実体が異なる)
                    if (yoteiIconDataKeyMap[key].kensaYoteiIconBitMap.ObjectID.Equals(vObjectID))
                    {
                        //フキダシの表示を切替え
                        SetKensaYoteiSelected(key, true);

                        // 検査予定一覧の表示を同期
                        if (yoteiForm != null)
                        {
                            yoteiForm.SelectKensaYotei(key);
                        }

                        // メモ一覧の表示を同期
                        if (memoForm != null)
                        {
                            memoForm.SelectKensaYotei(key);
                        }
                    }
                }
            }
            else
            {
                //foreach (string key in yoteiIconMap.Keys)
                //{
                //  SetKensaYoteiSelected(key, false);
                //}
            }

            // TODO 移動時は、当面1アイコンずつの移動のみとする
            // アイコン移動処理(移動モードのみ)
            if (mode == MAP_MODE.MOVE)
            {
                // TODO アイコンの位置を移動する

                if (currentMoveTraget != null)
                {
                    // OSスクリーン座標をMapWorksコントロール内のクライアント座標に変換
                    Point clientPt = mwView1.PointToClient(Cursor.Position);

                    // MapWorksクライアント座標をMapWorks地図座標に変換
                    Point mapPt = mwView1.ScreenToMap(clientPt);

                    foreach (KensaYoteiIcon icon in yoteiIconDataKeyMap.Values)
                    {
                        if (icon.kensaYoteiIconBitMap.ObjectID == currentMoveTraget)
                        {
                            // アイコンを移動
                            icon.kensaYoteiIconBitMap.X = mapPt.X;
                            icon.kensaYoteiIconBitMap.Y = mapPt.Y;

                            // 予定日を移動
                            icon.kensaYoteiDateLabel.X = mapPt.X;
                            icon.kensaYoteiDateLabel.Y = mapPt.Y + 500;

                            // フキダシを移動
                            icon.kensaYoteiMemoLabel.X = mapPt.X;
                            icon.kensaYoteiMemoLabel.Y = mapPt.Y + 750;

                            icon.kensaYoteiIconBitMap.Update();
                            icon.kensaYoteiDateLabel.Update();
                            icon.kensaYoteiMemoLabel.Update();
                            mwView1.MOverlays[0].MObjects.Update(icon.kensaYoteiIconBitMap);
                            mwView1.MOverlays[0].MObjects.Update(icon.kensaYoteiDateLabel);
                            mwView1.MOverlays[0].MObjects.Update(icon.kensaYoteiMemoLabel);

                            mwView1.Redraw(0);

                            string addr1 = string.Empty;
                            string addr2 = string.Empty;
                            string addrName = string.Empty;
                            short kind = 0;

                            // TODO テスト：移動後の住所を表示->保持データを更新する様にすること
                            mwView1.GetAddressName(mapPt.X, mapPt.Y, ref addr1, ref addr2, ref addrName, ref kind);

                            //MessageBox.Show(addr1 + addr2 + addrName);

                            break;
                        }
                    }
                }

                // TODO 移動先に合わせて、メモリ保持データの住所を修正する
            }
        }

        private void mwView1_ObjectSelected(object sender, ObjectSelectedEventArgs e)
        {
            // TODO Clickイベントとの使い分けは検討
            // アイコン移動操作用に選択オブジェクトを保持
            currentMoveTraget = (Guid)e.ObjectID;

            // 選択アイコン点滅タイマーを起動
            iconBlinkTimer.Enabled = true;
        }

        private void mwView1_ObjectUnselected(object sender, ObjectUnselectedEventArgs e)
        {
            // TODO アイコン以外が選択されている場合を考慮する
            // 1つも選択されていなければ、選択アイコン点滅タイマーを無効化
            if (mwView1.SelectedObjects == null || mwView1.SelectedObjects.Count == 0)
            {
                iconBlinkTimer.Enabled = false;
            }
        }

        private void mwView1_MouseHover(object sender, EventArgs e)
        {
            // NOTICE
            // MouseHoverイベントの仕様として、コントロール内(mwView全体)に
            // 最初にマウスが侵入した直後にしか発生しない
            // (再度発生させるには、一旦mwViewの外にカーソルを移動させる必要がある)
            // なのでMouseMoveイベントを使用する
        }

        private void mwView1_MouseMove(object sender, MouseEventArgs e)
        {
            // MouseHoverイベントは、該当ウィンドウにMouseEnterした初回しか発生しないため、
            // 同じMapWorkウィンドウ内で複数回作動しない（ので、MouseMoveイベントを使用）

            // OSスクリーン座標をMapWorksコントロール内のクライアント座標に変換
            Point clientPt = e.Location;

            // MapWorksクライアント座標をMapWorks地図座標に変換
            Point mapPt = mwView1.ScreenToMap(clientPt);

            // アイコンが無ければ何もしない
            foreach (KensaYoteiIcon icon in yoteiIconDataKeyMap.Values)
            {
                // マウスカーソル範囲内の検査予定アイコンなら、フキダシを表示
                if (mapPt.X >= icon.kensaYoteiIconBitMap.X - MOUSE_MOVE_RANGE
                 && mapPt.X <= icon.kensaYoteiIconBitMap.X + MOUSE_MOVE_RANGE
                 && mapPt.Y >= icon.kensaYoteiIconBitMap.Y - MOUSE_MOVE_RANGE
                 && mapPt.Y <= icon.kensaYoteiIconBitMap.Y + MOUSE_MOVE_RANGE
                   )
                // TODO IsInnerPointだと範囲内と判定されない？(ひとまず、座標毎に個別に判定)
                //if (icon.kensaYoteiIconBitMap.IsInnerPoint(mapPt))
                {
                    ShowYoteiMemo(icon.key, true);
                }
                else
                {
                    // 選択中で無いこと
                    if (mwView1.SelectedObjects == null
                        || mwView1.SelectedObjects.Count == 0
                        || mwView1.SelectedObjects[0].ObjectID != icon.kensaYoteiIconBitMap.ObjectID)
                    {
                        // 選択中でない検査予定のフキダシを非表示にする
                        ShowYoteiMemo(icon.key, false);
                    }
                }
            }
        }

        private void modeNormalButton_Click(object sender, EventArgs e)
        {
            ToNormalMode();
        }

        private void modeMoveButton_Click(object sender, EventArgs e)
        {
            ToMoveMode();
        }

        private bool blinkFlg = false;
        private void iconBlinkTimer_Tick(object sender, EventArgs e)
        {
            // TODO ビットマップオブジェクトの画像を切り替えても、表示に反映されない＞切替方法を見直す
            //return;

            if (mwView1.SelectedObjects != null && mwView1.SelectedObjects.Count > 0)
            {
                foreach (KensaYoteiIcon icon in yoteiIconDataKeyMap.Values)
                {
                    if (mwView1.SelectedObjects == null || mwView1.SelectedObjects.Count == 0)
                    {
                        break;
                    }
            
                    if (mwView1.SelectedObjects[0].ObjectID == icon.kensaYoteiIconBitMap.ObjectID)
                    {
                        //icon.kensaYoteiIconBitMap = mwView1.MOverlays[0].MObjects.GetBitmap(mwView1.SelectedObjects[0].ObjectID);

                        MBitmap mb = icon.SetKensaYoteiBlink(blinkFlg);
                        //mb.Update();
                        //mwView1.MOverlays[0].MObjects.Update(mb);

                        icon.kensaYoteiIconBitMap.Update();
                        mwView1.MOverlays[0].MObjects.Update(icon.kensaYoteiIconBitMap);
                        icon.kensaYoteiIconBitMapBlink.Update();
                        mwView1.MOverlays[0].MObjects.Update(icon.kensaYoteiIconBitMapBlink);

                        mwView1.MOverlays.Update(mwView1.MOverlays[0]);

                        // 選択が解除されるので、再選択する
                        if (blinkFlg)
                        {
                            mwView1.SelectObject(icon.kensaYoteiIconBitMap.ObjectID);
                        }
                        else
                        {
                            mwView1.SelectObject(icon.kensaYoteiIconBitMapBlink.ObjectID);
                        }

                        mwView1.Redraw(0);
                        //mwView1.Refresh();
                    }
                }

                blinkFlg = !blinkFlg;
            }
        }

        #endregion

        #region MapWorks初期化

        private void InitMapWorks()
        {
            // XML（旧INI）ﾌｧｲﾙ をｸﾞﾛｰﾊﾞﾙ変数に読み込む
            string dirPath = Path.GetDirectoryName(Application.ExecutablePath);
            SettingFile.ReadXml(Path.Combine(dirPath, SettingFile.xmlFileName));

            //拡大ｽﾞｰﾑ率
            ZoomInRate = SettingFile.xmlPara.ZoomInRate;
            //縮小ｽﾞｰﾑ率
            ZoomOutRate = SettingFile.xmlPara.ZoomOutRate;

            // 運用設定名を取得
            string strEnv = SettingFile.xmlPara.Workspace;

            // MWViewｺﾝﾄﾛｰﾙの初期化
            bool bRet = mwView1.Initialize(strEnv, "", "");

            if (bRet == false)
            {
                // MessageBox.Show("MWView の初期化に失敗しました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //ｽｸﾛｰﾙｶｰｿﾙを有効に設定
            mwView1.ScrollCursor = true;
            //ｶｰｿﾙ表示
            //mwView1.CursorType = 1;
            //ﾃﾝｷｰによるｽｸﾛｰﾙ､縮尺ｺﾝﾄﾛｰﾙを使用
            mwView1.TenKeyControl = true;
            //ｽｸﾛｰﾙの単位を指定(ｺﾝﾄﾛｰﾙの縦を100とした割合)
            mwView1.ScrollRange = 10;
            //ｽｸﾛｰﾙｲﾝﾀｰﾊﾞﾙ(ﾃﾞﾌｫﾙﾄ200)
            mwView1.ScrollPeriod = 200;
            //ｷｬｯｼｭｻｲｽﾞ(ﾃﾞﾌｫﾙﾄ32)
            mwView1.MapCache = 32;
            //地図種別の設定
            mwView1.MapType = (mwcMapType)SettingFile.xmlPara.MapType;
            //ﾙｰﾗｰの状態を設定する
            //mwView1.MRuler.Visible = SettingFile.xmlPara.Ruler;
            //mwcMapType sMapType = new mwcMapType();

            //コンパス表示設定
            mwView1.MCompass.Visible = true;
            mwView1.MCompass.Position = 3;

            //bRet = mwView1.DrawMap(502926855, 128377357, 1000);

            // TODO 仮で選択モードにする
            mwView1.MouseMode = mwcMouseMode.MM_HAND_SCROLL_AND_SELECT;

            //地図描画ﾓｰﾄﾞを設定
            mwView1.MapDrawMode = SettingFile.xmlPara.MapDrawMode;

            //ｽｸﾛｰﾙ時ｵｰﾊﾞﾚｲを表示(0:しない/1:表示)
            mwView1.set_Option(2, SettingFile.xmlPara.DrawOverlayOnScroll);

            // オーバレイ情報リストにセット
            Viewer.Overlays.Clear();
            if (SettingFile.xmlPara.Overlays != null)
            {
                Viewer.Overlays.AddRange(SettingFile.xmlPara.Overlays);
            }

            // 地図に反映
            if (Viewer.Overlays.Count != 0)
            {
                for (int i = 0; i < Viewer.Overlays.Count; i++)
                {
                    Viewer.AddMOverlay(mwView1, Viewer.Overlays[i].Name, Viewer.Overlays[i].Path);
                }
            }

            ////' ｵｰﾊﾞﾚｲ ｺﾝﾎﾞﾎﾞｯｸｽの設定(ｵｰﾊﾞﾚｲ ｺﾝﾎﾞﾎﾞｯｸｽﾁｪﾝｼﾞｲﾍﾞﾝﾄが発生しﾚｲﾔ ｺﾝﾎﾞﾎﾞｯｸにもｾｯﾄされる)
            //ComboBox cboOverlayCombo = cboOverlay.ComboBox;
            //Viewer.SetOverlayComboBox(cboOverlayCombo, mwView1);

            ////地図倍率の設定
            //CurMapScale = 0;

            ////地図種別を設定
            //SetMapType();
            ////ﾒｲﾝ画面のｷｬﾌﾟｼｮﾝにｶﾚﾝﾄの地図種別とｽｹｰﾙを表示する
            //ShowCaption();

            ////MWView1をﾘｻｲｽﾞ
            //ResizeMWView1();

            //前回の地図表示を復元する
            int X = SettingFile.xmlPara.X;
            int Y = SettingFile.xmlPara.Y;

            if (X != 0 & Y != 0)
            {
                int nMapScale = GetInitMapScale();
                mwView1.DrawMap(X, Y, nMapScale);
                //mwView1.DrawMap(X, Y + 500, nMapScale);
            }
        }

        #endregion

        #region MObject(MBitmap , MLabel)生成用

        private MBitmap CreateYoteiIconBitmap(int x, int y, int width, int height, YOTEI_ICON_TYPE type)
        {
            //ビットマップを宣言
            MBitmap m_bitmap = new MBitmap();

            if (type == YOTEI_ICON_TYPE.YOTEI_TODAY)
            {
                //イメージをセット
                m_bitmap.SetBitmap(imgKensaToday);
            }
            else if (type == YOTEI_ICON_TYPE.YOTEI_TODAY_BLINK)
            {
                //イメージをセット
                m_bitmap.SetBitmap(imgKensaTodayBlink);
                m_bitmap.Visible = false;
            }
            // TODO その他のアイコンも用意・表示する

            m_bitmap.LayerNo = ICON_LAYER_NO;
            //m_bitmap.Style = 2;  //白抜き部分をBackColor,黒色部分をForeColorで表示する
            m_bitmap.Style = 0;  //0だと色変わらない(Bitmapをそのまま表示)
            if (type == YOTEI_ICON_TYPE.YOTEI_TODAY)
            {
                m_bitmap.ForeColor = Color.Red;
                m_bitmap.BackColor = Color.Aqua;
            }
            m_bitmap.X = x;
            m_bitmap.Y = y;
            m_bitmap.Height = height;
            m_bitmap.Width = width;

            m_bitmap.MinX = m_bitmap.X - 1000;
            m_bitmap.MaxX = m_bitmap.X + 1000;
            m_bitmap.MinY = m_bitmap.Y - 1000;
            m_bitmap.MaxY = m_bitmap.Y + 1000;

            return m_bitmap;
        }

        private MLabel CreateYoteiDateLabel(string labelText, int x, int y)
        {
            MLabel ml = new MLabel();

            // TODO 日付表示向けに、スタイルを調整する
            // TODO 曜日を指定する必要がある(曜日によって、ラベルの色が変わる)

            ml.LayerNo = ICON_LAYER_NO;
            ml.BackColor = Color.Yellow;
            ml.ForeColor = Color.Black;
            ml.FontHeight = 11;
            // TODO 開発版では10だと正常に表示されない（原因は後日調査）
            ml.FontWidth = 1;
            //ml.FontWidth = 11;
            ml.LabelString = labelText;
            ml.X = x;
            ml.Y = y;
            ml.FontStyle = mwcFontStyle.FS_BOLD;
            ml.Style = 0;
            ml.UseLayerAttrib = false;//レイヤ設定使うか

            return ml;
        }

        private MLabel CreateToolTipLabel(string labelText, int x, int y)
        {
            MLabel ml = new MLabel();

            ml.LayerNo = ICON_LAYER_NO;
            ml.BackColor = Color.YellowGreen;
            ml.ForeColor = Color.Black;
            ml.FontHeight = 10;
            // TODO 開発版では10だと正常に表示されない（原因は後日調査）
            ml.FontWidth = 1;
            //ml.FontWidth = 10;
            ml.LabelString = labelText;
            ml.X = x;
            ml.Y = y;
            ml.FontStyle = mwcFontStyle.FS_BOLD;
            ml.Style = 1001;  //吹き出し風
            //ml.Style = 4;  //吹き出し風
            ml.UseLayerAttrib = false;//レイヤ設定使うか
            // 初期表示では表示しない
            ml.Visible = false;

            return ml;
        }

        private MLabel CreateToolTipLabel(string labelText, MBitmap parentBitMap)
        {
            return CreateToolTipLabel(labelText, parentBitMap.X, parentBitMap.Y + 250);
        }

        private MRect CreateSelectRect(int x, int y)
        {
            MRect mr = new MRect();

            mr.LayerNo = ICON_LAYER_NO;
            mr.BackColor = Color.Blue;
            //mr.LineWidth = 0;
            mr.LineWidth = 3;
            mr.X = x;
            mr.Y = y;
            mr.MinX = x - 500;
            mr.MaxX = x + 500;
            mr.MinY = y - 500;
            mr.MaxY = y + 500;
            mr.Visible = false;

            return mr;
        }

        // 指定検査予定のアイコンを生成する
        private KensaYoteiIcon CreateKensaYoteiIcon(MObjects objects, string key, int x, int y, string yoteiDate, string yoteiMemo, YOTEI_ICON_TYPE type)
        {
            KensaYoteiIcon icon = new KensaYoteiIcon();

            icon.key = key;

            // TODO 表示スケールに応じてサイズを調整する場合は、ここで細工をする(+,KenyaYotei内部クラスに、スケール更新用メソッドを設ける)
            icon.kensaYoteiIconBitMap = CreateYoteiIconBitmap(x, y, 40, 40, type);
            icon.kensaYoteiIconBitMapBlink = CreateYoteiIconBitmap(x, y, 40, 40, type + 1);
            icon.kensaYoteiDateLabel = CreateYoteiDateLabel(yoteiDate, x, y + 500);
            icon.kensaYoteiMemoLabel = CreateToolTipLabel(yoteiMemo, x, y + 750);
            //icon.kensaYoteiSelectRect = CreateSelectRect(x, y);

            // アイコンのビットマップオブジェクトをマップに設定
            object id = objects.Add(icon.kensaYoteiIconBitMap);
            objects.Add(icon.kensaYoteiIconBitMapBlink);
            // 予定日ラベルのオブジェクトをマップに設定
            objects.Add(icon.kensaYoteiDateLabel);
            // メモラベルのオブジェクトをマップに設定
            objects.Add(icon.kensaYoteiMemoLabel);
            // 選択矩形を設定
            //objects.Add(icon.kensaYoteiSelectRect);

            yoteiIconDataKeyMap.Add(key, icon);
            yoteiIconObjectIDMap.Add(id, icon);

            return icon;
        }

        #endregion

        #region アイコン移動用

        private void ToNormalMode()
        {
            // 通常モードに遷移
            mode = MAP_MODE.NORMAL;
        }

        private void ToMoveMode()
        {
            // 移動モードに遷移
            mode = MAP_MODE.MOVE;
        }

        #endregion

        #region 表示連携用インターフェース

        public void SelectKensaYotei(string key)
        {
            // アイコン位置まで表示を移動
            MoveToKensaYoteiIcon(key);

            // アイコンを選択状態にする
            SetKensaYoteiSelected(key, true);

            // TODO 多角形での、複数選択に対応する
        }

        // 検査予定アイコンまで、地図の表示を移動する
        private void MoveToKensaYoteiIcon(string key)
        {
            if (yoteiIconDataKeyMap.ContainsKey(key))
            {
                int x = 0;
                int y = 0;
                yoteiIconDataKeyMap[key].GetIconPos(out x, out y);

                int nMapScale = GetInitMapScale();

                // TODO 縮尺の自動変更は、要検討
                // TODO 縮尺に応じて、アイコンサイズを変えるか？（全アイコンについて）
                mwView1.DrawMap(x, y, (int)(nMapScale * 1.5));

                // 移動の場合、表示更新は不要
            }
        }

        // 指定検査予定のアイコンの表示を変える（選択時強調表示）
        private void SetKensaYoteiSelected(string key, bool isSelected)
        {
            if (yoteiIconDataKeyMap.ContainsKey(key))
            {
                foreach (string mapKey in yoteiIconDataKeyMap.Keys)
                {
                    //MRect mr;
                    MLabel ml = null;
                    if (mapKey == key)
                    {
                        mwView1.SelectObject(yoteiIconDataKeyMap[mapKey].kensaYoteiIconBitMap.ObjectID);
                        //mr = yoteiIconMap[mapKey].SetKensaYoteiSelected(isSelected);
                        if (yoteiIconDataKeyMap[mapKey].GetKensaYoteiMemoVisible() != isSelected)
                        {
                            ml = yoteiIconDataKeyMap[mapKey].SetKensaYoteiMemoVisible(isSelected);
                        }
                    }
                    else
                    {
                        mwView1.UnselectObject(yoteiIconDataKeyMap[mapKey].kensaYoteiIconBitMap.ObjectID);

                        //mr = yoteiIconMap[mapKey].SetKensaYoteiSelected(!isSelected);
                        if (yoteiIconDataKeyMap[mapKey].GetKensaYoteiMemoVisible() != !isSelected)
                        {
                            ml = yoteiIconDataKeyMap[mapKey].SetKensaYoteiMemoVisible(!isSelected);
                        }
                    }

                    //mr.Update();
                    //mwView1.MOverlays[0].MObjects.Update(mr);

                    // 実際に表示状態が変更されたオブジェクトをのみ、表示更新する
                    if (ml != null)
                    {
                        ml.Update();
                        mwView1.MOverlays[0].MObjects.Update(ml);
                    }
                }

                // オーバーレイ表示を更新（地図表示は不要なら更新しない）
                mwView1.Redraw(0);

            }
        }

        private void ShowYoteiMemo(string key, bool isSelected)
        {
            if (yoteiIconDataKeyMap.ContainsKey(key))
            {
                foreach (string mapKey in yoteiIconDataKeyMap.Keys)
                {
                    MLabel ml = null;

                    if (mapKey == key)
                    {
                        if (yoteiIconDataKeyMap[mapKey].GetKensaYoteiMemoVisible() != isSelected)
                        {
                            ml = yoteiIconDataKeyMap[mapKey].SetKensaYoteiMemoVisible(isSelected);
                        }
                    }

                    // 実際に表示状態が変更されたオブジェクトをのみ、表示更新する
                    if (ml != null)
                    {
                        ml.Update();
                        mwView1.MOverlays[0].MObjects.Update(ml);

                        break;
                    }
                }

                // オーバーレイ表示を更新（地図表示は不要なら更新しない）
                mwView1.Redraw(0);
            }
        }

        // 指定検査予定のアイコンの予定日の表示を更新する
        public void SetKensaYoteiDate(string key, string yoteiDate)
        {
            if (yoteiIconDataKeyMap.ContainsKey(key))
            {
                MLabel ml = yoteiIconDataKeyMap[key].SetKensaYoteiDate(yoteiDate);
                ml.Update();
                mwView1.MOverlays[0].MObjects.Update(ml);

                // オーバーレイを更新（地図は不要なら更新しない）
                mwView1.Redraw(0);
                //mwView1.Refresh();
            }
        }

        #endregion

        /// <summary>
        /// アイコン表示用レイヤーを生成する
        /// </summary>
        /// <returns></returns>
        private MLayer CreateNewLayer()
        {
            MLayer newLayer = new MLayer();
            newLayer.LayerName = "KensaKeiyakuIconLayer";
            newLayer.Name = "KensaKeiyakuIconLayer";
            newLayer.LayerNo = ICON_LAYER_NO;

            newLayer.BaseScale = 2000;
            newLayer.MaxScale = newLayer.BaseScale * 4;
            newLayer.MinScale = newLayer.BaseScale / 4;
            newLayer.Visible = true;
            newLayer.Search = true;

            return newLayer;
        }

        private int GetInitMapScale()
        {
            int nMapScale = SettingFile.xmlPara.MapScale;

            if (nMapScale == 0)
            {
                nMapScale = DEFAULT_SCALE;
            }

            return nMapScale;
        }

        // TODO 縮尺を変更した際に、アイコン類の表示サイズを調整する必要があるか？

    }
}
