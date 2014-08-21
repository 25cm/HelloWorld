using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FukjTabletSystem.Application.Boundary.Common;
using FukjTabletSystem.Application.Utility;
using FukjTabletSystem.Controls;
using FukjTabletSystem.Properties;
using MapWorks50;
using MapWorksViewer.MapWorks;
using Microsoft.VisualBasic.PowerPacks;
using Zynas.Framework.Core.Base.Boundary;

namespace FukjTabletSystem.Application.Boundary.MapWorks
{
    public partial class MapWorksForm : BaseTabletForm
    {
        #region フィールド(private)
        
        /// <summary>
        /// 終了時の状態保存を判定
        /// </summary>
        private bool SaveConditions;

        /// <summary>
        /// 拡大ｽﾞｰﾑ率
        /// </summary>
        private int ZoomInRate = 0;

        /// <summary>
        /// 縮小ｽﾞｰﾑ率
        /// </summary>
        private int ZoomOutRate = 0;

        /// <summary>
        /// 浄化槽マスタ（仮）
        /// </summary>
        private MapPointMasterDataSet.MapPointDataTable MapInfo;

        #region フリーハンド処理関連

        /// <summary>
        /// フリーハンド描画用ピクチャボックス
        /// </summary>
        private TransparentPictureBox tp = null;

        /// <summary>
        /// Graphics オブジェクト
        /// </summary>
        private Graphics grfx;

        /// <summary>
        /// 描画線
        /// </summary>
        private Pen MyPen;

        /// <summary>
        /// shapeContainer
        /// </summary>
        private ShapeContainer shapeContainer;

        /// <summary>
        /// lineShape
        /// </summary>
        private LineShape lineShape;

        /// <summary>
        /// rectangleShape
        /// </summary>
        private RectangleShape rectangleShape;
        
        #endregion

        #region マウス座標

        private int start = 0;  // 1 = 描画中
        private int startX;     // Line X 起点
        private int startY;     // Line Y 起点
        private int maxX;
        private int minX;
        private int maxY;
        private int minY;

        #endregion

        #endregion

        #region 定数(private)

        #region ラベルを描画するためのレイヤー

        /// <summary>
        /// ラベルを描画するためのレイヤー(黒)
        /// </summary>
        private const int LAYER_NO_LABEL_BLACK = 70;

        /// <summary>
        /// ラベルを描画するためのレイヤー(青)
        /// </summary>
        private const int LAYER_NO_LABEL_BLUE = 71;

        /// <summary>
        /// ラベルを描画するためのレイヤー(赤)
        /// </summary>
        private const int LAYER_NO_LABEL_RED = 72;

        /// <summary>
        /// ラベルを描画するためのレイヤー(固定)
        /// </summary>
        private const int LAYER_NO_LABEL_TEMP = 79;

        #endregion

        #region イメージを描画するためのレイヤー

        /// <summary>
        /// イメージを描画するためのレイヤー(Base250)
        /// </summary>
        private const int LAYER_NO_IMAGE_250 = 80;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base500)
        /// </summary>
        private const int LAYER_NO_IMAGE_500 = 81;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base1000)
        /// </summary>
        private const int LAYER_NO_IMAGE_1000 = 82;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base1500)
        /// </summary>
        private const int LAYER_NO_IMAGE_1500 = 83;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base3000)
        /// </summary>
        private const int LAYER_NO_IMAGE_3000 = 84;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base5000)
        /// </summary>
        private const int LAYER_NO_IMAGE_5000 = 85;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base7500)
        /// </summary>
        private const int LAYER_NO_IMAGE_7500 = 86;

        /// <summary>
        /// イメージを描画するためのレイヤー(Base10000)
        /// </summary>
        private const int LAYER_NO_IMAGE_10000 = 87;

        /// <summary>
        /// イメージを描画するためのレイヤー(固定)
        /// </summary>
        private const int LAYER_NO_IMAGE_TEMP = 89;

        #endregion

        #region 線を描画するためのレイヤー

        /// <summary>
        /// 線を描画するためのレイヤー(黒)
        /// </summary>
        private const int LAYER_NO_LINE_BLACK = 90;

        /// <summary>
        /// 線を描画するためのレイヤー(青)
        /// </summary>
        private const int LAYER_NO_LINE_BLUE = 91;

        /// <summary>
        /// 線を描画するためのレイヤー(赤)
        /// </summary>
        private const int LAYER_NO_LINE_RED = 92;

        #endregion

        #endregion

        #region コンストラクタ

        #region MapWorksForm()
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MapWorksForm()
        {
            InitializeComponent();
        }
        #endregion

        #endregion

        #region イベントハンドラ

        #region MapWorksForm_Load(object sender, System.EventArgs e)
        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapWorksForm_Load(object sender, System.EventArgs e)
        {
            // XML（旧INI）ﾌｧｲﾙ をｸﾞﾛｰﾊﾞﾙ変数に読み込む
            string dirPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            SettingFile.ReadXml(Path.Combine(dirPath, SettingFile.xmlFileName));

            //終了時の状態保存を判定
            SaveConditions = SettingFile.xmlPara.Save;

            //拡大ｽﾞｰﾑ率
            ZoomInRate = SettingFile.xmlPara.ZoomInRate;

            //縮小ｽﾞｰﾑ率
            ZoomOutRate = SettingFile.xmlPara.ZoomOutRate;

            // 現在地追従を初期化（停止）
            gpsTimer.Interval = Settings.Default.GpsTimer;
            gpsTimer.Stop();
        }
        #endregion

        #region MapWorksForm_Shown(object sender, System.EventArgs e)
        /// <summary>
        /// 地図表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapWorksForm_Shown(object sender, System.EventArgs e)
        {
            // 運用設定名を取得
            string strEnv = SettingFile.xmlPara.Workspace;

            // MWViewｺﾝﾄﾛｰﾙの初期化
            bool bRet = mwView.Initialize(strEnv, "", "");
            if (bRet == false)
            {
                TabMessageBox.Show2(TabMessageBox.Type.Error, "エラー", "地図の初期化に失敗しました");

                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            if (mwView.MOverlays.Count == 0)
            {
                TabMessageBox.Show2(TabMessageBox.Type.Error, "エラー", "オーバーレイのの初期化に失敗しました");

                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }

            // ｶﾚﾝﾄｵｰﾊﾞﾚｲの設定
            mwView.MOverlays.SetCurrent(0);
            
            // 共有オーバレイからレイヤー情報を取得
            mwView.MOverlays[0].GetLayerInfo();

            #region レイヤーの追加

            #region レイヤー（線描画）

            // 線(黒)用
            if (mwView.MLayers.GetLayer(LAYER_NO_LINE_BLACK) == null)
            {
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LINE_BLACK;
                layer.LayerName = "LAYER_LINE_BLACK";
                layer.Name = "LAYER_LINE_BLACK";
                layer.Visible = true;
                layer.Search = true;

                layer.ForeColor = Color.Black;
                layer.LineWidth = 2;

                mwView.MLayers.Add(layer);
            }

            // 線(青)用
            if (mwView.MLayers.GetLayer(LAYER_NO_LINE_BLUE) == null)
            {
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LINE_BLUE;
                layer.LayerName = "LAYER_LINE_BLUE";
                layer.Name = "LAYER_LINE_BLUE";
                layer.Visible = true;
                layer.Search = true;

                layer.ForeColor = Color.Blue;
                layer.LineWidth = 2;

                mwView.MLayers.Add(layer);
            }

            // 線(赤)用
            if (mwView.MLayers.GetLayer(LAYER_NO_LINE_RED) == null)
            {
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LINE_RED;
                layer.LayerName = "LAYER_LINE_RED";
                layer.Name = "LAYER_LINE_RED";
                layer.Visible = true;
                layer.Search = true;

                layer.ForeColor = Color.Red;
                layer.LineWidth = 2;

                mwView.MLayers.Add(layer);
            }

            #endregion

            #region レイヤー（ラベル）

            // ラベル（黒）用
            if (mwView.MLayers.GetLayer(LAYER_NO_LABEL_BLACK) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LABEL_BLACK;
                layer.LayerName = "LAYER_LABEL_BLACK";
                layer.Name = "LAYER_LABEL_BLACK";
                layer.Visible = true;
                layer.Search = true;

                layer.FontName = "メイリオ";
                layer.FontHeight = 20;
                layer.ForeColor = Color.Black;
                layer.FontTransparent = true;

                mwView.MLayers.Add(layer);
            }

            // ラベル（青）用
            if (mwView.MLayers.GetLayer(LAYER_NO_LABEL_BLUE) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LABEL_BLUE;
                layer.LayerName = "LAYER_LABEL_BLUE";
                layer.Name = "LAYER_LABEL_BLUE";
                layer.Visible = true;
                layer.Search = true;

                layer.FontName = "メイリオ";
                layer.FontHeight = 20;
                layer.ForeColor = Color.Blue;
                layer.FontTransparent = true;

                mwView.MLayers.Add(layer);
            }

            // ラベル（赤）用
            if (mwView.MLayers.GetLayer(LAYER_NO_LABEL_RED) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LABEL_RED;
                layer.LayerName = "LAYER_LABEL_RED";
                layer.Name = "LAYER_LABEL_RED";
                layer.Visible = true;
                layer.Search = true;

                layer.FontName = "メイリオ";
                layer.FontHeight = 20;
                layer.ForeColor = Color.Red;
                layer.FontTransparent = true;

                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_LABEL_TEMP) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_LABEL_TEMP;
                layer.LayerName = "LAYER_LABEL_TEMP";
                layer.Name = "LAYER_LABEL_TEMP";
                layer.Visible = true;
                layer.Search = true;

                layer.FontName = "メイリオ";
                layer.FontHeight = 14;
                layer.ForeColor = Color.Black;
                layer.BackColor = Color.Yellow;
                layer.FontTransparent = false;
                layer.ScaleMode = 0;

                mwView.MLayers.Add(layer);
            }

            #endregion
            
            #region レイヤー（イメージ）

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_250) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_250;
                layer.LayerName = "LAYER_IMAGE_250";
                layer.Name = "LAYER_IMAGE_250";
                layer.BaseScale = 250;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_500) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_500;
                layer.LayerName = "LAYER_IMAGE_500";
                layer.Name = "LAYER_IMAGE_500";
                layer.BaseScale = 500;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_1000) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_1000;
                layer.LayerName = "LAYER_IMAGE_1000";
                layer.Name = "LAYER_IMAGE_1000";
                layer.BaseScale = 1000;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_1500) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_1500;
                layer.LayerName = "LAYER_IMAGE_1500";
                layer.Name = "LAYER_IMAGE_1500";
                layer.BaseScale = 1500;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_3000) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_3000;
                layer.LayerName = "LAYER_IMAGE_3000";
                layer.Name = "LAYER_IMAGE_3000";
                layer.BaseScale = 3000;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_5000) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_5000;
                layer.LayerName = "LAYER_IMAGE_5000";
                layer.Name = "LAYER_IMAGE_5000";
                layer.BaseScale = 5000;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_7500) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_7500;
                layer.LayerName = "LAYER_IMAGE_7500";
                layer.Name = "LAYER_IMAGE_7500";
                layer.BaseScale = 7500;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_10000) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_10000;
                layer.LayerName = "LAYER_IMAGE_10000";
                layer.Name = "LAYER_IMAGE_10000";
                layer.BaseScale = 10000;
                layer.MaxScale = layer.BaseScale * 4;
                layer.MinScale = layer.BaseScale / 4;
                layer.Visible = true;
                layer.Search = true;
                mwView.MLayers.Add(layer);
            }

            if (mwView.MLayers.GetLayer(LAYER_NO_IMAGE_TEMP) == null)
            {
                // 規定レイヤーの追加
                MLayer layer = new MLayer();
                layer.LayerNo = LAYER_NO_IMAGE_TEMP;
                layer.LayerName = "LAYER_IMAGE_TEMP";
                layer.Name = "LAYER_IMAGE_TEMP";
                layer.Visible = true;
                layer.Search = true;
                layer.ScaleMode = 0;
                mwView.MLayers.Add(layer);
            }

            #endregion

            #endregion

            // 共有オーバレイにレイヤー情報を反映
            mwView.MOverlays[0].UpdateLayerInfo();
            
            // ｶﾚﾝﾄﾚｲﾔ番号の設定
            mwView.CurLayerNo = LAYER_NO_LINE_BLACK;

            //ｽｸﾛｰﾙｲﾝﾀｰﾊﾞﾙ(ﾃﾞﾌｫﾙﾄ200)
            mwView.ScrollPeriod = (short)SettingFile.xmlPara.ScrollPeriod;

            //地図種別の設定
            mwView.MapType = (mwcMapType)SettingFile.xmlPara.MapType;

            //ﾙｰﾗｰの状態を設定する
            mwView.MRuler.Visible = SettingFile.xmlPara.Ruler;

            //地図描画ﾓｰﾄﾞを設定
            mwView.MapDrawMode = SettingFile.xmlPara.MapDrawMode;

            //ｽｸﾛｰﾙ時ｵｰﾊﾞﾚｲを表示(0:しない/1:表示)
            mwView.set_Option(2, SettingFile.xmlPara.DrawOverlayOnScroll);
            
            #region オーバレイ情報の更新

            // TODO: 運用設定に登録されていないオーバーレイを追加(画面で追加されたもの)
            // アプリの機能としてオーバーレイの追加を行わせないのであれば不要

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
                    Viewer.AddMOverlay(mwView, Viewer.Overlays[i].Name, Viewer.Overlays[i].Path);
                }
            }

            #endregion

            //地図種別を設定
            SetMapType();

            //前回の地図表示を復元する
            int X = SettingFile.xmlPara.X;
            int Y = SettingFile.xmlPara.Y;
            int nMapScale = SettingFile.xmlPara.MapScale;
            if (X != 0 & Y != 0)
            {
                mwView.DrawMap(X, Y, nMapScale);
            }

            #region 試験的に・・・

            MapInfo = CreateSamplePoint();
            SetMapPointInfo(MapInfo);

            #endregion
        }
        #endregion

        #region MapWorksForm_FormClosing(object sender, FormClosingEventArgs e)
        /// <summary>
        /// フォーム終了時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapWorksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 終了時の状態保存
            if (SaveConditions == true)
            {
                setXmlPara();
            }
            try
            {
                // XMLファイルに出力
                string dirPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
                SettingFile.WriteXml(Path.Combine(dirPath, SettingFile.xmlFileName));

                // MWViewｺﾝﾄﾛｰﾙの終了処理
                mwView.Terminate();
            }
            catch (Exception ex)
            {
                TabMessageBox.Show2(ex.Message);
                e.Cancel = true;
            }
        }
        #endregion

        #region backButton_Click(object sender, System.EventArgs e)
        /// <summary>
        /// 戻るボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region selectCheckBox_CheckedChanged(object sender, System.EventArgs e)
        /// <summary>
        /// 選択モード変更チェックボックス押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (selectCheckBox.Checked)
            {
                freeInputCheckBox.Enabled = false;
                textInputCheckBox.Enabled = false;
                lineInputCheckBox.Enabled = false;
                messageCheckBox.Enabled = false;
                gpsCheckBox.Enabled = false;

                //ｵﾌﾞｼﾞｪｸﾄ･ﾋﾟｯｸﾓｰﾄﾞの設定
                mwView.PickMode = mwcPickMode.PKM_NORMAL;
                //ﾏｳｽﾓｰﾄﾞの設定
                mwView.MouseMode = mwcMouseMode.MM_SELECT_OBJECT;
            }
            else
            {
                freeInputCheckBox.Enabled = true;
                textInputCheckBox.Enabled = true;
                lineInputCheckBox.Enabled = true;
                messageCheckBox.Enabled = true;
                gpsCheckBox.Enabled = true;

                //ｵﾌﾞｼﾞｪｸﾄ･ﾋﾟｯｸﾓｰﾄﾞの設定
                mwView.PickMode = mwcPickMode.PKM_NORMAL;
                //ﾏｳｽﾓｰﾄﾞの設定
                mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;
            }
        }
        #endregion

        #region messageCheckBox_CheckedChanged(object sender, EventArgs e)
        /// <summary>
        /// メモ表示切替
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void messageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (MapPointMasterDataSet.MapPointRow row in MapInfo)
            {
                if (messageCheckBox.Checked)
                {
                    if (row.IsInfoObjectIDNull())
                    {
                        MLabel label = new MLabel();

                        // レイヤ番号の指定
                        label.LayerNo = LAYER_NO_LABEL_TEMP;
                        label.Temporary = true;
                        label.LabelString = string.Format("検査箇所：{0}\r\n　　メモ：{1}", row.NAME, row.DATA);
                        label.X = GetMapPos(row.longitude);
                        label.Y = GetMapPos(row.latitude);
                        label.Style = 2;

                        mwView.CreateLabel(label);

                        // 作成中ｵﾌﾞｼﾞｪｸﾄを登録
                        object objectID = mwView.RegisterObject(true);
                        row.InfoObjectID = (Guid)objectID;
                    }
                }
                else
                {
                    if (!row.IsInfoObjectIDNull())
                    {
                        mwView.SelectObject(row.InfoObjectID);
                        mwView.UndoControl.Enabled = true;
                        mwView.Remove();
                        mwView.UndoControl.Enabled = false;
                        mwView.Refresh();

                        row.SetInfoObjectIDNull();
                    }
                }
            }
        }
        #endregion

        #region textInputCheckBox_CheckedChanged(object sender, EventArgs e)
        /// <summary>
        /// 文字入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (freeInputCheckBox.Checked)
            {
                if (textInputCheckBox.Checked)
                {
                    lineInputCheckBox.Enabled = false;
                }
                else
                {
                    lineInputCheckBox.Enabled = true;
                }
            }
            else
            {
                if (textInputCheckBox.Checked)
                {
                    using (ColorSelectDialog dlg = new ColorSelectDialog(textInputCheckBox, ColorSelectDialog.SelectMode.ColorAndStamp))
                    {
                        dlg.ShowDialog(this);

                        if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            if (dlg.SelectedColor() == ColorSelectDialog.ColorMode.StampB
                                || dlg.SelectedColor() == ColorSelectDialog.ColorMode.StampS)
                            {
                                selectCheckBox.Enabled = false;
                                messageCheckBox.Enabled = false;
                                lineInputCheckBox.Enabled = false;
                                freeInputCheckBox.Enabled = false;
                                zoomInButton.Enabled = false;
                                zoomOutButton.Enabled = false;
                                gpsCheckBox.Enabled = false;

                                //ﾏｳｽﾓｰﾄﾞの設定
                                mwView.MouseMode = mwcMouseMode.MM_NORMAL;

                                // 表示状態に応じてレイヤーを切り替える（試験的に）
                                int myBaseLayerNo;

                                if (mwView.MapScale < 375)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_250;
                                }
                                else if (mwView.MapScale < 750)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_500;
                                }
                                else if (mwView.MapScale < 1250)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_1000;
                                }
                                else if (mwView.MapScale < 2250)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_1500;
                                }
                                else if (mwView.MapScale < 4000)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_3000;
                                }
                                else if (mwView.MapScale < 6125)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_5000;
                                }
                                else if (mwView.MapScale < 8750)
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_7500;
                                }
                                else
                                {
                                    myBaseLayerNo = LAYER_NO_IMAGE_10000;
                                }

                                // ビットマップの登録
                                MBitmap bitmap = new MBitmap();
                                bitmap.LayerNo = myBaseLayerNo;
                                bitmap.Temporary = false;
                                bitmap.SetBitmap(dlg.SelectedColor() == ColorSelectDialog.ColorMode.StampB ? Resources.StampB_S : Resources.StampS_S);
                                bitmap.Height = Resources.StampB_S.Height;
                                bitmap.Width = Resources.StampB_S.Width;
                                bitmap.Style = 0;

                                mwView.CreateBitmap(bitmap);
                            }
                            else
                            {
                                using (TextInputDialog dlg2 = new TextInputDialog())
                                {
                                    dlg2.ShowDialog(this);

                                    if (dlg2.DialogResult == System.Windows.Forms.DialogResult.OK)
                                    {
                                        selectCheckBox.Enabled = false;
                                        messageCheckBox.Enabled = false;
                                        lineInputCheckBox.Enabled = false;
                                        freeInputCheckBox.Enabled = false;
                                        zoomInButton.Enabled = false;
                                        zoomOutButton.Enabled = false;
                                        gpsCheckBox.Enabled = false;

                                        //ﾏｳｽﾓｰﾄﾞの設定
                                        mwView.MouseMode = mwcMouseMode.MM_NORMAL;

                                        MLabel label = new MLabel();

                                        // レイヤ番号の指定
                                        label.LayerNo = dlg.SelectedColor() == ColorSelectDialog.ColorMode.Black ? LAYER_NO_LABEL_BLACK
                                                        : dlg.SelectedColor() == ColorSelectDialog.ColorMode.Blue ? LAYER_NO_LABEL_BLUE
                                                        : LAYER_NO_LABEL_RED;
                                        label.Temporary = false;
                                        label.LabelString = dlg2.InputText();

                                        mwView.CreateLabel(label);
                                    }
                                    else
                                    {
                                        textInputCheckBox.Checked = false;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // 「ｵﾌﾞｼﾞｪｸﾄ作成ﾓｰﾄﾞ」の場合
                    mwView.Cancel();
                    mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;

                    selectCheckBox.Enabled = true;
                    messageCheckBox.Enabled = true;
                    lineInputCheckBox.Enabled = true;
                    freeInputCheckBox.Enabled = true;
                    zoomInButton.Enabled = true;
                    zoomOutButton.Enabled = true;
                    gpsCheckBox.Enabled = true;
                }
            }
        }
        #endregion

        #region freeInputCheckBox_CheckedChanged(object sender, EventArgs e)
        /// <summary>
        /// 手書き入力チェック変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void freeInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (freeInputCheckBox.Checked)
            {
                using (ColorSelectDialog dlg = new ColorSelectDialog(freeInputCheckBox, ColorSelectDialog.SelectMode.Color))
                {
                    dlg.ShowDialog(this);

                    if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        selectCheckBox.Enabled = false;
                        messageCheckBox.Enabled = false;
                        zoomInButton.Enabled = false;
                        zoomOutButton.Enabled = false;
                        gpsCheckBox.Enabled = false;

                        tp = new TransparentPictureBox();

                        tp.Width = mwView.Width;
                        tp.Height = mwView.Height;
                        tp.Top = 0;
                        tp.Left = 0;
                        tp.Parent = mwView;

                        tp.MouseDown += new MouseEventHandler(TransparentPictureBox_MouseDown);
                        tp.MouseMove += new MouseEventHandler(TransparentPictureBox_MouseMove);
                        tp.MouseUp += new MouseEventHandler(TransparentPictureBox_MouseUp);

                        // PictureBoxと同サイズのBitmapオブジェクトを作成
                        tp.Image = new Bitmap(tp.Width, tp.Height);

                        maxX = 0;
                        minX = 0;
                        maxY = 0;
                        minY = 0;

                        grfx = Graphics.FromImage(tp.Image);

                        tp.Show();

                        // ペンの設定
                        MyPen = new Pen(Pens.Black.Color, 3);

                        // ペン色の切り換え
                        MyPen.Color = dlg.SelectedColor() == ColorSelectDialog.ColorMode.Black ? Pens.Black.Color
                                        : dlg.SelectedColor() == ColorSelectDialog.ColorMode.Blue ? Pens.Blue.Color
                                        : Pens.Red.Color;
                    }
                }
            }
            else
            {
                tp.Dispose();

                selectCheckBox.Enabled = true;
                messageCheckBox.Enabled = true;
                if (textInputCheckBox.Checked)
                {
                    textInputCheckBox.Checked = false;
                }
                if (lineInputCheckBox.Checked)
                {
                    lineInputCheckBox.Checked = false;
                }
                zoomInButton.Enabled = true;
                zoomOutButton.Enabled = true;
                gpsCheckBox.Enabled = true;
            }
        }
        #endregion
        
        #region lineInputCheckBox_CheckedChanged(object sender, EventArgs e)
        /// <summary>
        /// 直線入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lineInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (freeInputCheckBox.Checked)
            {
                if (lineInputCheckBox.Checked)
                {
                    textInputCheckBox.Enabled = false;
                }
                else
                {
                    textInputCheckBox.Enabled = true;
                }
            }
            else
            {
                if (lineInputCheckBox.Checked)
                {
                    using (LineSelectDialog dlg = new LineSelectDialog(lineInputCheckBox))
                    {
                        dlg.ShowDialog(this);

                        if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
                        {
                            using (ColorSelectDialog dlg2 = new ColorSelectDialog(lineInputCheckBox, ColorSelectDialog.SelectMode.Color))
                            {
                                dlg2.ShowDialog(this);

                                if (dlg2.DialogResult == System.Windows.Forms.DialogResult.OK)
                                {
                                    selectCheckBox.Enabled = false;
                                    messageCheckBox.Enabled = false;
                                    textInputCheckBox.Enabled = false;
                                    freeInputCheckBox.Enabled = false;
                                    zoomInButton.Enabled = false;
                                    zoomOutButton.Enabled = false;
                                    gpsCheckBox.Enabled = false;

                                    //ﾏｳｽﾓｰﾄﾞの設定
                                    mwView.MouseMode = mwcMouseMode.MM_NORMAL;

                                    // レイヤ番号の切り換え
                                    mwView.CurLayerNo = dlg2.SelectedColor() == ColorSelectDialog.ColorMode.Black ? LAYER_NO_LINE_BLACK
                                                    : dlg2.SelectedColor() == ColorSelectDialog.ColorMode.Blue ? LAYER_NO_LINE_BLUE
                                                    : LAYER_NO_LINE_RED;

                                    if (dlg.SelectedLine() == LineSelectDialog.LineMode.Straight)
                                    {
                                        // ﾎﾟﾘﾗｲﾝの作成(※ﾃﾝﾎﾟﾗﾘｵﾌﾞｼﾞｪｸﾄを使用しない)
                                        mwView.CreatePolyline(Viewer.PL_NOTARROW, false);
                                    }
                                    else if (dlg.SelectedLine() == LineSelectDialog.LineMode.Arrow)
                                    {
                                        // ﾎﾟﾘﾗｲﾝの作成(※ﾃﾝﾎﾟﾗﾘｵﾌﾞｼﾞｪｸﾄを使用しない)
                                        mwView.CreatePolyline(Convert.ToInt16(3), false);
                                    }
                                    else
                                    {
                                        // ﾎﾟﾘｺﾞﾝの作成(※ﾃﾝﾎﾟﾗﾘｵﾌﾞｼﾞｪｸﾄを使用しない)
                                        mwView.CreatePolygon(false);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    // 「ｵﾌﾞｼﾞｪｸﾄ作成ﾓｰﾄﾞ」の場合
                    mwView.Cancel();
                    mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;

                    selectCheckBox.Enabled = true;
                    messageCheckBox.Enabled = true;
                    textInputCheckBox.Enabled = true;
                    freeInputCheckBox.Enabled = true;
                    zoomInButton.Enabled = true;
                    zoomOutButton.Enabled = true;
                    gpsCheckBox.Enabled = true;
                }
            }
        }
        #endregion

        #region zoomInButton_Click(object sender, System.EventArgs e)
        /// <summary>
        /// 拡大ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomInButton_Click(object sender, System.EventArgs e)
        {
            // 拡大表示
            mwView.Zoom((short)ZoomInRate);
        }
        #endregion

        #region zoomOutButton_Click(object sender, System.EventArgs e)
        /// <summary>
        /// 縮小ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomOutButton_Click(object sender, System.EventArgs e)
        {
            // 縮小表示
            mwView.Zoom((short)ZoomOutRate);
        }
        #endregion

        #region gpsCheckBox_CheckedChanged(object sender, EventArgs e)
        /// <summary>
        /// 現在地取得及び現在地追従
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gpsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (gpsCheckBox.Checked)
            {
                freeInputCheckBox.Enabled = false;
                selectCheckBox.Enabled = false;
                messageCheckBox.Enabled = false;
                textInputCheckBox.Enabled = false;
                lineInputCheckBox.Enabled = false;

                setMyPos(1000);

                // ｶｰｿﾙﾀｲﾌﾟの設定(十字ｶｰｿﾙﾀｲﾌﾟ2)
                mwView.CursorType = mwcCursorType.CURSOR_TYPE2;
                // Pointedｲﾍﾞﾝﾄの起動
                mwView.GetPoint(mwcMousePointer.MP_NORMAL, "中心表示");

                // 追従を開始
                gpsTimer.Start();
            }
            else
            {
                freeInputCheckBox.Enabled = true;
                selectCheckBox.Enabled = true;
                messageCheckBox.Enabled = true;
                textInputCheckBox.Enabled = true;
                lineInputCheckBox.Enabled = true;

                // ｶｰｿﾙﾀｲﾌﾟの設定(十字ｶｰｿﾙﾀｲﾌﾟ2)
                mwView.CursorType = mwcCursorType.CURSOR_NONE;
                mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;

                // 追従を停止
                gpsTimer.Stop();
            }
        }
        #endregion

        #region gpsTimer_Tick(object sender, EventArgs e)
        /// <summary>
        /// 現在地追従タイマ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gpsTimer_Tick(object sender, EventArgs e)
        {
            setMyPos(mwView.MapScale);
        }
        #endregion
        
        #region mwView_Click(object sender, EventArgs e)
        /// <summary>
        /// オブジェクトクリックによるメモ表示切替
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mwView_Click(object sender, EventArgs e)
        {
            if (mwView.SelectedObjects.Count == 0)
            {
                return;
            }

            DataRow[] rows = MapInfo.Select(string.Format("ObjectID='{0}'", mwView.SelectedObjects[0].ObjectID));
            if (rows.Length > 0)
            {
                if (rows[0]["InfoObjectID"] != DBNull.Value)
                {
                    mwView.SelectObject((Guid)rows[0]["InfoObjectID"]);
                    mwView.UndoControl.Enabled = true;
                    mwView.Remove();
                    mwView.UndoControl.Enabled = false;
                    mwView.Refresh();

                    rows[0]["InfoObjectID"] = DBNull.Value;
                }
                else
                {
                    MLabel label = new MLabel();

                    // レイヤ番号の指定
                    label.LayerNo = LAYER_NO_LABEL_TEMP;
                    label.Temporary = true;
                    label.LabelString = string.Format("検査箇所：{0}\r\n　　メモ：{1}", rows[0]["NAME"].ToString(), rows[0]["DATA"].ToString());
                    label.X = GetMapPos((double)rows[0]["longitude"]);
                    label.Y = GetMapPos((double)rows[0]["latitude"]);
                    label.Style = 2;

                    mwView.CreateLabel(label);

                    // 作成中ｵﾌﾞｼﾞｪｸﾄを登録
                    object objectID = mwView.RegisterObject(true);
                    rows[0]["InfoObjectID"] = objectID;
                }
            }
        }
        #endregion

        #region mwView_MouseDown(object sender, MouseEventArgs e)
        /// <summary>
        /// 右クリックコンテキストメニュー制御
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mwView_MouseDown(object sender, MouseEventArgs e)
        {
            Point pos = new Point();

            // X座標
            pos.X = mwView.Left + e.X;
            // Y座標
            pos.Y = mwView.Top + e.Y;

            // 右ﾎﾞﾀﾝの場合､ﾎﾟｯﾌﾟｱｯﾌﾟﾒﾆｭｰを表示
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                switch (mwView.MouseMode)
                {
                    case mwcMouseMode.MM_SELECT_OBJECT:
                        // ｵﾌﾞｼﾞｪｸﾄ選択ﾓｰﾄﾞの場合
                        cntdelPopup.Show(this, pos);
                        break;

                    case mwcMouseMode.MM_CREATE_OBJECT:
                        // ｵﾌﾞｼﾞｪｸﾄ作成ﾓｰﾄﾞの場合
                        cntmnuPopup.Show(this, pos);
                        break;
                }
            }
        }
        #endregion

        #region mwView_DoubleClick(object sender, System.EventArgs e)
        /// <summary>
        /// ダブルクリックによる確定処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mwView_DoubleClick(object sender, System.EventArgs e)
        {
            object vObjectID = null;

            if ((mwView.MouseMode == mwcMouseMode.MM_CREATE_OBJECT && mwView.EditMode != mwcEditMode.EM_COPY_SECTION) ||
                mwView.EditMode == mwcEditMode.EM_EDIT_SECTION ||
                mwView.EditMode == mwcEditMode.EM_EDIT_VERTEX ||
                mwView.EditMode == mwcEditMode.EM_MOVE ||
                mwView.EditMode == mwcEditMode.EM_EXTEND_POLYLINE ||
                mwView.EditMode == mwcEditMode.EM_ADD_VERTEX ||
                mwView.EditMode == mwcEditMode.EM_DEL_VERTEX)
            {
                // ｵﾌﾞｼﾞｪｸﾄ作成中または部分編集ﾓｰﾄﾞ
                mwView.UndoControl.Enabled = true;

                // 登録
                vObjectID = mwView.RegisterObject(true);
                mwView.UndoControl.Enabled = false;
            }

            if (freeInputCheckBox.Checked)
            {
                freeInputCheckBox.Checked = false;
            }
            else if (lineInputCheckBox.Checked)
            {
                lineInputCheckBox.Checked = false;
            }
            else if (textInputCheckBox.Checked)
            {
                textInputCheckBox.Checked = false;
            }
            
            mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;
        }
        #endregion

        #region mnuPopupRegister_Click(object sender, System.EventArgs e)
        /// <summary>
        /// 登録メニュー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuPopupRegister_Click(object sender, System.EventArgs e)
        {
            if (freeInputCheckBox.Checked)
            {
                // 画像の保存
                Bitmap imageBase = (Bitmap)tp.Image;

                // 画像を切り抜く
                Rectangle rect = new Rectangle(minX - 3, minY - 3, maxX - minX + 6, maxY - minY + 6);
                Bitmap image = imageBase.Clone(rect, imageBase.PixelFormat);
                
                // イメージの中心地を計算
                int X = (((maxX - minX) / 2) + minX);
                int Y = imageBase.Height - (((maxY - minY) / 2) + minY);
                
                // マップの表示範囲を取得
                int rectMinX = 0;
                int rectMinY = 0;
                int rectMaxX = 0;
                int rectMaxY = 0;
                mwView.GetMapRect(ref rectMinX, ref rectMinY, ref rectMaxX, ref rectMaxY);

                // イメージの中心にあたるマップ座標を計算
                int centerX = ((rectMaxX - rectMinX) * X / imageBase.Width) + rectMinX;
                int centerY = ((rectMaxY - rectMinY) * Y / imageBase.Height) + rectMinY;

                // 表示状態に応じてレイヤーを切り替える（試験的に）
                int myBaseLayerNo;

                if (mwView.MapScale < 375)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_250;
                }
                else if (mwView.MapScale < 750)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_500;
                }
                else if (mwView.MapScale < 1250)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_1000;
                }
                else if (mwView.MapScale < 2250)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_1500;
                }
                else if (mwView.MapScale < 4000)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_3000;
                }
                else if (mwView.MapScale < 6125)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_5000;
                }
                else if (mwView.MapScale < 8750)
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_7500;
                }
                else
                {
                    myBaseLayerNo = LAYER_NO_IMAGE_10000;
                }
                
                // イメージのリサイズ倍率(BaseScale換算)
                // TODO: どうしてもサイズが合わないので暫定で調整(x0.742F)
                float resize = 1.0F / mwView.MLayers.GetLayer(myBaseLayerNo).BaseScale * mwView.MapScale * 0.742F;
                
                // 高画質リサイズ
                int w = (int)((float)image.Width * resize);
                int h = (int)((float)image.Height * resize);
                Bitmap dest = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(dest);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, w, h);

                //dest.Save("C:\\Users\\toyoda\\Desktop\\IMG_" + DateTime.Now.ToString("yyyyMMddyymmss") + ".png");
                
                // ビットマップの登録
                MBitmap bitmap = new MBitmap();
                bitmap.LayerNo = myBaseLayerNo;
                bitmap.Temporary = false;
                bitmap.SetBitmap(dest);
                bitmap.Height = dest.Height;
                bitmap.Width = dest.Width;
                bitmap.Style = 0;
                bitmap.X = centerX;
                bitmap.Y = centerY;

                mwView.CreateBitmap(bitmap);
            }

            // 作成中ｵﾌﾞｼﾞｪｸﾄを登録
            mwView_DoubleClick(mwView, e);

        }
        #endregion
        
        #region mnuPopupDelete_Click(object sender, System.EventArgs e)
        /// <summary>
        /// 削除メニュー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuPopupDelete_Click(object sender, System.EventArgs e)
        {
            if (mwView.GetSelectedObjectID(0) != null)
            {
                mwView.UndoControl.Enabled = true;
                mwView.Remove();
                mwView.UndoControl.Enabled = false;
                mwView.Refresh();
            }
        }
        #endregion

        #region mnuPopupCancel_Click(object sender, System.EventArgs e)
        /// <summary>
        /// キャンセルメニュー押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuPopupCancel_Click(object sender, System.EventArgs e)
        {
            if (freeInputCheckBox.Checked)
            {
                freeInputCheckBox.Checked = false;
            }
            else
            {
                // 「ｵﾌﾞｼﾞｪｸﾄ作成ﾓｰﾄﾞ」の場合
                mwView.Cancel();                
                mwView.MouseMode = mwcMouseMode.MM_HAND_SCROLL;
                
                if (lineInputCheckBox.Checked)
                {
                    lineInputCheckBox.Checked = false;
                }
                else if (textInputCheckBox.Checked)
                {
                    textInputCheckBox.Checked = false;
                }
            }
        }
        #endregion

        #region TransparentPictureBox_MouseDown(object sender, MouseEventArgs e)
        /// <summary>
        /// マウスダウン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparentPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // 右ﾎﾞﾀﾝの場合､ﾎﾟｯﾌﾟｱｯﾌﾟﾒﾆｭｰを表示
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                Point pos = new Point();

                // X座標
                pos.X = mwView.Left + e.X;
                // Y座標
                pos.Y = mwView.Top + e.Y;

                // ｵﾌﾞｼﾞｪｸﾄ作成ﾓｰﾄﾞの場合
                cntmnuPopup.Show(this, pos);
            }
            else
            {
                start = 1;
                startX = e.X;
                startY = e.Y;

                if (lineInputCheckBox.Checked)
                {
                    shapeContainer = new ShapeContainer();
                    lineShape = new LineShape();
                    shapeContainer.Parent = tp;
                    lineShape.Parent = shapeContainer;
                    lineShape.BorderColor = MyPen.Color;
                    lineShape.BorderWidth = 2;
                    lineShape.StartPoint = new Point(startX, startY);
                    lineShape.EndPoint = new Point(e.X, e.Y);
                }
                else if (textInputCheckBox.Checked)
                {
                    shapeContainer = new ShapeContainer();
                    rectangleShape = new RectangleShape();
                    shapeContainer.Parent = tp;
                    rectangleShape.Parent = shapeContainer;
                    rectangleShape.BorderColor = Color.Black;
                    rectangleShape.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    rectangleShape.BorderWidth = 1;
                    rectangleShape.Left = startX;
                    rectangleShape.Top = startY;
                    rectangleShape.Width = 0;
                    rectangleShape.Height = 0;
                }

                if (maxX == 0 || maxX < startX)
                {
                    maxX = startX;
                }

                if (minX == 0 || minX > startX)
                {
                    minX = startX;
                }

                if (maxY == 0 || maxY < startY)
                {
                    maxY = startY;
                }

                if (minY == 0 || minY > startY)
                {
                    minY = startY;
                }
            }
        }
        #endregion

        #region TransparentPictureBox_MouseUp(object sender, MouseEventArgs e)
        /// <summary>
        /// マウスアップ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparentPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (lineInputCheckBox.Checked && lineShape != null)
            {
                grfx.DrawLine(MyPen, startX, startY, e.X, e.Y);

                ((TransparentPictureBox)sender).Refresh();

                lineShape = null;

                shapeContainer = null;
            }
            else if (textInputCheckBox.Checked)
            {
                using (TextInputDialog dlg2 = new TextInputDialog())
                {
                    dlg2.ShowDialog(this);
                    
                    if (dlg2.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        //Fontを作成
                        Font fnt = new Font("メイリオ", rectangleShape.Height / 2 / dlg2.InputLineCount());

                        //文字列を表示する範囲を指定する
                        RectangleF rect = new RectangleF(rectangleShape.Left, rectangleShape.Top, rectangleShape.Width, rectangleShape.Height);
                        
                        //文字を書く
                        grfx.DrawString(dlg2.InputText(), fnt, Brushes.Black, rect);

                        ((TransparentPictureBox)sender).Refresh();
                    }
                }
                
                rectangleShape.Visible = false;

                rectangleShape = null;

                shapeContainer = null;

                //textInputCheckBox.Checked = false;
            }

            start = 0;
            startX = e.X;
            startY = e.Y;

            if (maxX == 0 || maxX < startX)
            {
                maxX = startX;
            }

            if (minX == 0 || minX > startX)
            {
                minX = startX;
            }

            if (maxY == 0 || maxY < startY)
            {
                maxY = startY;
            }

            if (minY == 0 || minY > startY)
            {
                minY = startY;
            }
        }
        #endregion

        #region TransparentPictureBox_MouseMove(object sender, MouseEventArgs e)
        /// <summary>
        /// マウス移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransparentPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (start == 0) return;

            if (lineInputCheckBox.Checked)
            {
                lineShape.EndPoint = new Point(e.X, e.Y);
            }
            else if (textInputCheckBox.Checked)
            {
                rectangleShape.Width = e.X - startX;
                rectangleShape.Height = e.Y - startY;
            }
            else
            {
                grfx.DrawLine(MyPen, startX, startY, e.X, e.Y);

                startX = e.X;
                startY = e.Y;

                if (maxX == 0 || maxX < startX)
                {
                    maxX = startX;
                }

                if (minX == 0 || minX > startX)
                {
                    minX = startX;
                }

                if (maxY == 0 || maxY < startY)
                {
                    maxY = startY;
                }

                if (minY == 0 || minY > startY)
                {
                    minY = startY;
                }

                ((TransparentPictureBox)sender).Refresh();
            }
        }
        #endregion

        #endregion

        #region メソッド(private)

        #region SetMapType()
        /// <summary>
        /// 地図種別を設定
        /// </summary>
        private void SetMapType()
        {
            int nUseableMapType;
            int nCurMapType;

            //ｶﾚﾝﾄ地図種別を取得
            nCurMapType = (int)mwView.MapType;
            
            //利用可能地図種別を取得
            nUseableMapType = mwView.GetUseableMap();

            if (nUseableMapType == 0)
            {
                //利用可能地図がない
                return;
            }

            //ｶﾚﾝﾄ地図種別が設定されていない場合は使用できる地図を検索し最初に見つかった地図をｶﾚﾝﾄ地図に設定します
            if (nCurMapType == 0)
            {
                nCurMapType = (int)mwView.MMapTypes[0].MapType;
                mwView.MapType = mwView.MMapTypes[0].MapType;
            }
        }
        #endregion

        #region setXmlPara()
        /// <summary>
        /// 表示状態を保存
        /// </summary>
        private void setXmlPara()
        {
            bool bRet = false;

            #region オーバレイ情報の更新

            // TODO: 運用設定に登録されていないオーバーレイを追加(画面で追加されたもの)
            // アプリの機能としてオーバーレイの追加を行わせないのであれば不要
            
            //ｵｰﾊﾞﾚｲ名称,ｵｰﾊﾞﾚｲﾊﾟｽ
            int nCount = 0;
            if (Viewer.Overlays != null)
            {
                nCount = Viewer.Overlays.Count;
            }
            if (nCount != 0)
            {
                SettingFile.xmlPara.Overlays = Viewer.Overlays.ToArray();
            }

            #endregion

            //地図
            //地図の中心座標を取得
            short iKNo = 0;
            int X = 0, Y = 0;
            bRet = mwView.GetCenterMapPoint(ref iKNo, ref X, ref Y);
            //系番号
            SettingFile.xmlPara.KNo = iKNo;
            //緯度経度座標
            SettingFile.xmlPara.X = X;
            //緯度経度座標
            SettingFile.xmlPara.Y = Y;
            //地図表示スケール
            SettingFile.xmlPara.MapScale = mwView.MapScale;

            //ﾙｰﾗ
            SettingFile.xmlPara.Ruler = mwView.MRuler.Visible;

            //ﾊﾟﾗﾒｰﾀ
            //ｽｸﾛｰﾙｲﾝﾀｰﾊﾞﾙ
            SettingFile.xmlPara.ScrollPeriod = mwView.ScrollPeriod;
            //ｽｸﾛｰﾙ時ｵｰﾊﾞﾚｲを表示(0:しない/1:表示)
            SettingFile.xmlPara.DrawOverlayOnScroll = (bool)mwView.get_Option(2);
            //地図種別
            SettingFile.xmlPara.MapType = (int)mwView.MapType;
            //利用可能地図種別
            SettingFile.xmlPara.UseableMap = mwView.GetUseableMap();
            //地図描画ﾓｰﾄﾞ
            SettingFile.xmlPara.MapDrawMode = mwView.MapDrawMode;
            //拡大ｽﾞｰﾑ率
            SettingFile.xmlPara.ZoomInRate = ZoomInRate;
            //縮小ｽﾞｰﾑ率
            SettingFile.xmlPara.ZoomOutRate = ZoomOutRate;
        }
        #endregion

        #region setMyPos(int mapScale)
        /// <summary>
        /// マップを現在位置に移動
        /// </summary>
        /// <param name="mapScale"></param>
        private void setMyPos(int mapScale)
        {
            //// 緯度
            //double latitude = 0;
            //// 経度
            //double longitude = 0;
            //// 結果
            //bool ret = false;

            //// GPS入力の開始
            //using (GPSInfo gps = new GPSInfo())
            //{
            //    // 位置情報を取得
            //    ret = gps.GetLocation(ref latitude, ref longitude, Settings.Default.GpsWaitTimer);

            //    // GP入力の終了
            //    gps.Dispose();
            //}

            //// 現在地が取得できない場合
            //if (!ret)
            //{
            //    return;
            //}

            if (Settings.Default.DemoMapArea == 0)
            {
                double longitude = 130.508163;
                double latitude = 33.319117;

                // X座標 Y座標に変換
                int xpos = GetMapPos(longitude);
                int ypos = GetMapPos(latitude);

                // とりあえず適当に座標を動かしてみる
                xpos += (DateTime.Now.Second * 10000 + DateTime.Now.Minute * 100 + DateTime.Now.Hour) / 1000;
                ypos += (DateTime.Now.Second * 10000 + DateTime.Now.Minute * 100 + DateTime.Now.Hour) / 1000;

                // カレント移動
                mwView.DrawMap(MWLib.GetKNo(xpos, ypos), xpos, ypos, mapScale);
            }
            else
            {
                double longitude = 139.703288;
                double latitude = 35.656782;

                // X座標 Y座標に変換
                int xpos = GetMapPos(longitude);
                int ypos = GetMapPos(latitude);

                // とりあえず適当に座標を動かしてみる
                xpos += (DateTime.Now.Second * 10000 + DateTime.Now.Minute * 100 + DateTime.Now.Hour) / 1000;
                ypos += (DateTime.Now.Second * 10000 + DateTime.Now.Minute * 100 + DateTime.Now.Hour) / 1000;

                // カレント移動
                mwView.DrawMap(MWLib.GetKNo(xpos, ypos), xpos, ypos, mapScale);
            }
        }
        #endregion

        #region GetMapPos(double gpsPos)
        /// <summary>
        /// GPS座標情報からMAP座標に変換する
        /// </summary>
        /// <param name="gpsPos"></param>
        /// <returns></returns>
        private int GetMapPos(double gpsPos)
        {
            int 度 = (int)gpsPos;
            int 分 = (int)((gpsPos - 度) * 60);
            double 秒 = (int)(((gpsPos - 度) * 60 - 分) * 60 * 1000) / (double)1000;

            return (int)((度 * 60 * 60 * 1000) + (分 * 60 * 1000) + (秒 * 1000));
        }
        #endregion

        #region CreateSamplePoint()
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private MapPointMasterDataSet.MapPointDataTable CreateSamplePoint()
        {
            MapPointMasterDataSet.MapPointDataTable data = new MapPointMasterDataSet.MapPointDataTable();

            MapPointMasterDataSet.MapPointRow newRow = data.NewMapPointRow();

            newRow.ID = 1;

            newRow.NAME = "検査箇所１";

            newRow.DATA = "備考、メモなどを入力しておく";

            // 20140819 habu デモ送付用に福岡/東京の切替を追加
            if (Settings.Default.DemoMapArea == 0)
            {
                newRow.longitude = 130.508163;

                newRow.latitude = 33.319117;
            }
            else
            {
                newRow.longitude = 139.703288;

                newRow.latitude = 35.656782;
            }

            data.AddMapPointRow(newRow);

            newRow = data.NewMapPointRow();

            newRow.ID = 2;

            newRow.NAME = "検査箇所２";

            newRow.DATA = "備考、メモなどを入力しておく";

            // 20140819 habu デモ送付用に福岡/東京の切替を追加
            if (Settings.Default.DemoMapArea == 0)
            {
                newRow.longitude = 130.509165;

                newRow.latitude = 33.318115;
            }
            else
            {
                newRow.longitude = 139.704288;

                newRow.latitude = 35.655782;
            }

            data.AddMapPointRow(newRow);
            
            return data;
        }
        #endregion

        #region SetMapPointInfo(MapPointMasterDataSet.MapPointDataTable data)
        /// <summary>
        /// 
        /// </summary>
        private void SetMapPointInfo(MapPointMasterDataSet.MapPointDataTable data)
        {
            foreach (MapPointMasterDataSet.MapPointRow row in data)
            {
                // ビットマップの登録
                MBitmap bitmap = new MBitmap();
                bitmap.LayerNo = LAYER_NO_IMAGE_TEMP;
                bitmap.Temporary = true;
                bitmap.SetBitmap(Resources.Pin);
                bitmap.Height = Resources.Pin.Height;
                bitmap.Width = Resources.Pin.Width;
                bitmap.Style = 0;
                bitmap.X = GetMapPos(row.longitude);
                bitmap.Y = GetMapPos(row.latitude);

                mwView.CreateBitmap(bitmap);

                // 作成中ｵﾌﾞｼﾞｪｸﾄを登録
                object objectID = mwView.RegisterObject(true);
                row.ObjectID = (Guid)objectID;
                row.SetInfoObjectIDNull();

            }
        }
        #endregion

        #endregion
    }
}
