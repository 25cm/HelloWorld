﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Zynas.Control.Common;

namespace Zynas.Control
{

    /// <summary>
    /// ZDateコントロールクラス
    /// 継承元:GcDateコントロール
    /// </summary>
    public partial class ZDate : DateTimePicker 
    {
        #region フィールド

        #region static変数
        // 休日定義ファイルのパス
        private static string holidayFilePath;
        #endregion

        #region private定数
        private const string DEFAULT_CALENDAR_TITLE_FORMAT = "yyyy/MM";
        private const string DEFAULT_FIELD_FORMAT = "yyyy/MM/dd";
        private const string DEFAULT_DISPLAY_FIELD_FORMAT = "";
        private const string DEFAULT_YEAR_MONTH_CALENDAR_TITLE_FORMAT = "yyyy";

        private static readonly DateTime DEFAULT_MAX_DATE = new DateTime(9999, 12, 31, 23, 59, 59);
        private static readonly DateTime DEFAULT_MIN_DATE = new DateTime(1868, 9, 8, 0, 0, 0);
        private const bool DEFAULT_ALLOW_NULL = true;
        private const bool DEFAULT_ALLOW_SPIN = true;

        private const string EXCEPTION_MSG_MINDATEVALUE = "MinDateValueをMaxDateValueより大きくすることはできません。";
        private const string EXCEPTION_MSG_MAXDATEVALUE = "MaxDateValueをMinDateValueより小さくすることはできません。";
        private const string EXCEPTION_MSG_ALLOWNULL = "値がNull時にAllowNullをfalseにすることはできません。";
        #endregion

        #region CustomReadOnly用変数
        // 背景色を変える読み取り専用にするフラグ
        private bool customReadOnly = false;

        // 背景色退避用
        private Color enabledBackColor;

        // 背景色を変える読み取り専用時に、背景色を変更するフラグ
        //private bool shownColorChangeFlg = false;
        #endregion

        // スピン機能を使用するかどうかのフラグ
        //private bool allowSpinFlg = DEFAULT_ALLOW_SPIN;

        // カレンダーの色変更用
        //private HolidayStyle saturdayHoliday = new HolidayStyle();
        //private HolidayStyle sundayHoliday = new HolidayStyle();

        // 入力・表示用フィールドのフォーマット
        //private string fieldsFormat;
        //private string displayFieldsFormat;

        #region 入力制限設定用変数
        // 入力可能最小日付
        private DateTime minDateValue;

        // 入力可能最大日付
        private DateTime maxDateValue;

        // Nullを許可するかのフラグ
        //private bool allowNullFlg;
        #endregion

        //#region 日付検証コンポーネント
        //// 日付検証コンポーネント本体
        //private GcDateValidator dateValidator;

        //// 指定の範囲内にあるか検証
        //private GcDateValidator.InvalidRange dateValidatorInvalidRange;

        //// 検証アクションを設定
        //private ValueProcess dateValidatorValueProcess;
        //#endregion

        #region イベント定義用
        /// <summary>
        /// 背景色を変える読み取り専用プロパティ変更のイベントハンドラデリゲート
        /// </summary>
        /// <param name="sender">送信元</param>
        /// <param name="e">現在の読み取り専用状態を含む</param>
        public delegate void CustomReadOnlyChangedEventHandler(object sender, CustomReadOnlyChangedEventArgs e);

        /// <summary>
        /// 背景色を変える読み取り専用プロパティ変更時のイベント
        /// </summary>
        [Description("背景色を変える読み取り専用プロパティが変更されたときに発生します。"), Category("プロパティ変更")]
        private event CustomReadOnlyChangedEventHandler CustomReadOnlyChanged;

        #endregion

        // ドメイン対応 s_abe 2012/07/17
        //private ZControlDomain controlDomain;

        #endregion

        #region プロパティ

        #region staticプロパティ
        /// <summary>
        /// 休日定義ファイルのパス
        /// </summary>
        public static string HolidayFilePath
        {
            get { return holidayFilePath; }
            set { holidayFilePath = value; }
        }
        #endregion

        ///// <summary>
        ///// スピンボタンを表示するSpinオブジェクトを取得または設定します。
        ///// </summary>
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        //public new Spin Spin
        //{
        //    get { return base.Spin; }
        //}

        ///// <summary>
        ///// スピン機能を使用するかどうかを取得または設定します。
        ///// </summary>
        //[Description("スピン機能の有効または無効を取得または設定します。"), Category("動作")]
        //public bool AllowSpin
        //{
        //    get { return allowSpinFlg; }
        //    set
        //    {
        //        if (allowSpinFlg == value)
        //        {
        //            return;
        //        }
        //        allowSpinFlg = value;
        //        this.Spin.AllowSpin = value;
        //    }

        //}
        ///// <summary>
        ///// 背景色を変える読み取り専用プロパティ
        ///// </summary>
        //[Description("読み取り専用にするかどうかを取得または設定し、背景色を変更します。"), Category("動作")]
        //public bool CustomReadOnly
        //{
        //    get { return customReadOnly; }
        //    set
        //    {
        //        if (customReadOnly == value)
        //        {
        //            return;
        //        }

        //        customReadOnly = value;
        //        // イベント発行準備
        //        raiseCustomReadOnlyChanged(value);

        //    }
        //}

        //// ドメイン対応 s_abe 2012/07/17
        ///// <summary>
        ///// TODO
        ///// </summary>
        //public ZControlDomain CustomControlDomain
        //{
        //    set
        //    {
        //        if (controlDomain == value)
        //        {
        //            return;
        //        }
        //        controlDomain = value;
        //        raiseCustomControlDomainChanged(value);
        //    }
        //    get { return controlDomain; }
        //}

        ///// <summary>
        ///// TODO
        ///// </summary>
        //public void UpdateDynamicProperties()
        //{
        //    // ドメイン対応 s_abe 2012/07/17
        //    raiseCustomControlDomainChanged(controlDomain);

        //    raiseCustomReadOnlyChanged(customReadOnly);
        //}

        //#region 背景色プロパティのオーバーライド
        ///// <summary>
        ///// オーバーライド 無効時の背景色
        ///// </summary>
        //public override Color DisabledBackColor
        //{
        //    get
        //    {
        //        // 無効時の背景色を返す
        //        return base.DisabledBackColor;
        //    }
        //    set
        //    {
        //        // 無効時の背景色を与えられた色にする
        //        base.DisabledBackColor = value;

        //        if (customReadOnly)
        //        {
        //            // 背景色を変更する読み取り専用状態のとき

        //            // 表示される背景色を変更するフラグを立てる
        //            shownColorChangeFlg = true;

        //            // 背景色を与えられた色にする
        //            this.BackColor = value;

        //            // フラグを戻す
        //            shownColorChangeFlg = false;
        //        }
        //    }
        //}

        ///// <summary>
        ///// オーバーライド 背景色
        ///// </summary>
        //public override Color BackColor
        //{
        //    get
        //    {
        //        // バックカラープロパティ読み取り時
        //        if (customReadOnly)
        //        {
        //            // 背景色を変更する読み取り専用状態のとき
        //            if (shownColorChangeFlg)
        //            {
        //                // 表示される背景色を変更するフラグが立っているとき
        //                // 現在の背景色を返す(背景色を変える読み取り専用プロパティ変更時用)
        //                return base.BackColor;
        //            }
        //            else
        //            {
        //                // 表示される背景色を変更するフラグが降りているとき
        //                // 退避している背景色を返す
        //                return enabledBackColor;
        //            }
        //        }
        //        else
        //        {
        //            // 背景色を変更する読み取り専用状態でないとき
        //            // 現在の背景色を返す
        //            return base.BackColor;
        //        }
        //    }
        //    set
        //    {
        //        // バックカラープロパティ変更時
        //        if (customReadOnly)
        //        {
        //            // 背景色を変更する読み取り専用状態のとき
        //            if (shownColorChangeFlg)
        //            {
        //                // 表示される背景色を変更するフラグが立っているとき

        //                // 背景色を与えられた値に変更する
        //                if (base.BackColor != value)
        //                {
        //                    base.BackColor = value;
        //                }
        //            }
        //            else
        //            {
        //                // 表示される背景色を変更するフラグが降りているとき
        //                // 退避している背景色を変更する
        //                enabledBackColor = value;

        //                // 背景色変更イベント発行
        //                //EventArgs ea = new EventArgs();
        //                //this.OnBackColorChanged(ea);
        //            }
        //        }
        //        else
        //        {
        //            // 背景色を変更する読み取り専用状態でないとき

        //            // 待避している背景色を更新
        //            if (!shownColorChangeFlg)
        //            {
        //                enabledBackColor = value;
        //            }
        //            // 背景色を変更する
        //            if (base.BackColor != value)
        //            {
        //                base.BackColor = value;
        //            }
        //        }
        //    }
        //}
        //#endregion

        //#region フィールドのプロパティ
        ///// <summary>
        ///// 入力用フィールドコレクションを取得します。
        ///// </summary>
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        //public new DateFieldCollection Fields
        //{
        //    get { return base.Fields; }
        //}

        ///// <summary>
        ///// 表示用のフィールドコレクションを取得します。
        ///// </summary>
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        //public new DateDisplayFieldCollection DisplayFields
        //{
        //    get { return base.DisplayFields; }
        //}

        ///// <summary>
        ///// 入力用フィールドコレクションのフォーマットを設定または取得します。
        ///// </summary>
        //[Description("入力用フィールドコレクションのフォーマットを設定または取得します。"), Category("フィールド")]
        //public string FieldsFormat
        //{
        //    get { return fieldsFormat; }
        //    set
        //    {
        //        // 値を保持して表示に反映させる
        //        fieldsFormat = value;
        //        this.Fields.Clear();
        //        this.Fields.AddRange(value);
        //    }
        //}
        ///// <summary>
        ///// 表示用フィールドコレクションのフォーマットを設定または取得します。
        ///// </summary>
        //[Description("表示用フィールドコレクションのフォーマットを設定または取得します。"), Category("フィールド")]
        //public string DisplayFieldsFormat
        //{
        //    get { return displayFieldsFormat; }
        //    set
        //    {
        //        // 値を保持して表示に反映させる
        //        displayFieldsFormat = value;
        //        this.DisplayFields.Clear();
        //        this.DisplayFields.AddRange(value);
        //    }
        //}

        //#endregion

        //#region 入力制限設定
        ///// <summary>
        ///// 入力可能な日付の最小値の取得または設定
        ///// </summary>
        //[Description("入力可能な日付の最小値を取得または設定します。"), Category("値")]
        //public DateTime MinDateValue
        //{
        //    get { return minDateValue; }
        //    set
        //    {
        //        // 値が等しいとき処理を終了
        //        if (minDateValue == value)
        //        {
        //            return;
        //        }
        //        // 最大値より大きいとき例外を投げる
        //        if (value > maxDateValue)
        //        {
        //            throw new ArgumentOutOfRangeException(EXCEPTION_MSG_MINDATEVALUE);
        //        }

        //        minDateValue = value;
        //        // 現在設定されている日付を最小値と最大値の間に入るように設定
        //        if (this.Value.HasValue)
        //        {
        //            this.Value = fixDateValue(this.Value.Value, minDateValue, maxDateValue);
        //        }
        //        // カレンダーの制限値を変更
        //        this.DropDownCalendar.MinDate = value;
        //        // 検証コンポーネントの最小値を変更
        //        dateValidatorInvalidRange.MinValue = value;
        //    }
        //}

        ///// <summary>
        ///// 入力可能な日付の最大値の取得または設定
        ///// </summary>
        //[Description("入力可能な日付の最大値を取得または設定します。"), Category("値")]
        //public DateTime MaxDateValue
        //{
        //    get { return maxDateValue; }
        //    set
        //    {
        //        // 値が等しいとき処理を終了
        //        if (maxDateValue == value)
        //        {
        //            return;
        //        }
        //        // 最小値より小さいとき例外を投げる
        //        if (value < minDateValue)
        //        {
        //            throw new ArgumentOutOfRangeException(EXCEPTION_MSG_MAXDATEVALUE);
        //        }


        //        maxDateValue = value;
        //        // 現在設定されている日付を最小値と最大値の間に入るように設定
        //        if (this.Value.HasValue)
        //        {
        //            this.Value = fixDateValue(this.Value.Value, minDateValue, maxDateValue);
        //        }
        //        // カレンダーの制限値を変更
        //        this.DropDownCalendar.MaxDate = value;
        //        // 検証コンポーネントの最小値を変更
        //        dateValidatorInvalidRange.MaxValue = value;
        //    }
        //}

        ///// <summary>
        ///// Nullを入力可能にするかどうかの取得または設定
        ///// </summary>
        //[Description("Nullを入力可能にするかどうかを取得または設定します。"), Category("値")]
        //public bool AllowNull
        //{
        //    get { return allowNullFlg; }
        //    set
        //    {
        //        // 値が等しいとき処理を終了
        //        if (allowNullFlg == value)
        //        {
        //            return;
        //        }
        //        // Null拒否にするときで、現在の値がNullの場合に例外を投げる
        //        if (!value && !this.Value.HasValue)
        //        {
        //            throw new ArgumentOutOfRangeException(EXCEPTION_MSG_ALLOWNULL);
        //        }

        //        allowNullFlg = value;
        //        dateValidatorInvalidRange.NullIsValid = value;
        //    }
        //}

        ///// <summary>
        ///// 日付の値を取得または設定します
        ///// </summary>
        //[Description("日付の値を取得または設定します。AllowNullがtrueのときのみNullを設定できます。"), Category("値")]
        //public new DateTime? Value
        //{
        //    get
        //    {
        //        if (this.DropDownCalendar.CalendarType == CalendarType.YearMonth && base.Value.HasValue)
        //        {
        //            // 年月カレンダーで値がnullでないとき日付を1日とした値を返す
        //            DateTime? dt = new DateTime(base.Value.Value.Year, base.Value.Value.Month, 1);
        //            return dt;
        //        }
        //        else
        //        {
        //            return base.Value;
        //        }
        //    }
        //    set
        //    {
        //        if (!allowNullFlg && !value.HasValue)
        //        {
        //            throw new ArgumentNullException("Value", "AllowNullがfalseのときにはNullを設定できません。");
        //        }

        //        if (value.HasValue)
        //        {
        //            value = fixDateValue(value.Value, minDateValue, maxDateValue);
        //        }

        //        base.Value = value;
        //    }
        //}
        //#endregion

        #endregion

        #region コンストラクタ
        /// <summary>
        /// デザイナで表示時のコンストラクタ
        /// </summary>
        public ZDate()
        {
            #region デザイナによる初期化
            InitializeComponent();
            #endregion

            // 共通の初期化
            commonUserInitilization();

            // コンストラクタで反映されないFieldプロパティを別のタイミングで設定するため
            //this.FieldPaint += new EventHandler<FieldPaintEventArgs>(ZDate_FieldPaintFirst);
        }

        /// <summary>
        /// プログラム実行時のコンストラクタ
        /// </summary>
        /// <param name="container"></param>
        public ZDate(IContainer container)
        {
            #region デザイナによる初期化
            container.Add(this);

            InitializeComponent();
            #endregion

            // コレクションのクリア(サイドボタンが勝手に表示される不具合への対応)
            //this.SideButtons.Clear();
            this.Controls.Clear();

            // 共通の初期化
            commonUserInitilization();

            // 休日キー保持用
            List<string> holidayKeys = new List<string>();

            // 休日定義ファイルの読み込み
            try
            {
                if (!string.IsNullOrEmpty(holidayFilePath))
                {
                    if (File.Exists(holidayFilePath))
                    {
                        //this.DropDownCalendar.HolidayStyles = HolidayStyleCollection.Load(holidayFilePath);
                        //holidayKeys.AddRange(this.DropDownCalendar.HolidayStyles.Keys);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("休日定義ファイル読み込みエラー", this.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // 休日定義によりカレンダーの祝日の色を変更
            //this.DropDownCalendar.ActiveHolidayStyles = holidayKeys.ToArray();

            // RecomendedValueに本日日付を設定
            // (日付を手入力したときに予期せぬ時刻が設定される現象への対応)
            //this.RecommendedValue = DateTime.Today;
        }

        /// <summary>
        /// ユーザーによる共通の初期化処理
        /// </summary>
        private void commonUserInitilization()
        {
            // 背景色を変える読み取り専用でないとき
            // 現在のBackColorを保持
            if (!customReadOnly)
            {
                enabledBackColor = this.BackColor;
            }

            // スピン機能の初期設定
            //this.Spin.AllowSpin = allowSpinFlg;

            // フィールドフォーマットのデフォルト値
            //fieldsFormat = DEFAULT_FIELD_FORMAT;
            //displayFieldsFormat = DEFAULT_DISPLAY_FIELD_FORMAT;

            //// ドロップダウンカレンダーのタイトル年月表示
            //this.DropDownCalendar.HeaderFormat = DEFAULT_CALENDAR_TITLE_FORMAT;
            //this.DropDownCalendar.UseHeaderFormat = true;

            //// 年-月カレンダー時の年表示
            //this.DropDownCalendar.YearMonthFormat.YearFormat = DEFAULT_YEAR_MONTH_CALENDAR_TITLE_FORMAT;

            //// ドロップダウンカレンダーの入力可能範囲を設定
            //this.DropDownCalendar.MinDate = DEFAULT_MIN_DATE;
            //this.DropDownCalendar.MaxDate = DEFAULT_MAX_DATE;

            //// 表示フォーマット
            //this.FieldsFormat = fieldsFormat;
            //this.DisplayFieldsFormat = displayFieldsFormat;

            //this.DropDownCalendar.Weekdays = new WeekdaysStyle(
            //    new DayOfWeekStyle("日", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Red), WeekFlags.All),
            //    new DayOfWeekStyle("月", ReflectTitle.ForeColor, new SubStyle(), WeekFlags.All),
            //    new DayOfWeekStyle("火", ReflectTitle.ForeColor, new SubStyle(), WeekFlags.All),
            //    new DayOfWeekStyle("水", ReflectTitle.ForeColor, new SubStyle(), WeekFlags.All),
            //    new DayOfWeekStyle("木", ReflectTitle.ForeColor, new SubStyle(), WeekFlags.All),
            //    new DayOfWeekStyle("金", ReflectTitle.ForeColor, new SubStyle(), WeekFlags.All),
            //    new DayOfWeekStyle("土", ReflectTitle.ForeColor, new SubStyle(SystemColors.Window, Color.Blue), WeekFlags.All)
            //    );

            // 日付検証コンポーネントの初期化
            minDateValue = DEFAULT_MIN_DATE;
            maxDateValue = DEFAULT_MAX_DATE;
            //allowNullFlg = DEFAULT_ALLOW_NULL;

            //// 入力可能値の設定
            //dateValidatorInvalidRange = new GcDateValidator.InvalidRange();
            //dateValidatorInvalidRange.MinValue = minDateValue;
            //dateValidatorInvalidRange.MaxValue = maxDateValue;
            //dateValidatorInvalidRange.NullIsValid = allowNullFlg;

            //// 異常値のとき元に戻す動作を行う
            //dateValidatorValueProcess = new ValueProcess(ValueProcessOption.Restore);

            //// 検証コンポーネント本体に入力可能値と動作を設定
            //dateValidator = new GcDateValidator();
            //dateValidator.GetValidateItems(this).Add(dateValidatorInvalidRange);
            //dateValidator.GetValidateActions(this).Add(dateValidatorValueProcess);


            // 読み取り専用プロパティ変更時のイベントを登録
            this.CustomReadOnlyChanged += new CustomReadOnlyChangedEventHandler(this.ZDate_CustomReadOnlyChanged);

        }
        #endregion

        #region イベント定義用
        /// <summary>
        /// イベント時の引数を準備する処理
        /// </summary>
        /// <param name="readOnlyValue">読み取り専用プロパティの値</param>
        private void raiseCustomReadOnlyChanged(bool readOnlyValue)
        {
            // イベント引数
            CustomReadOnlyChangedEventArgs e = new CustomReadOnlyChangedEventArgs(readOnlyValue);

            // イベント発行関数に渡す
            OnCustomReadOnlyChanged(e);
        }

        /// <summary>
        /// イベント発行処理
        /// </summary>
        /// <param name="eArgs">読み取り専用フラグを含むイベント引数</param>
        protected virtual void OnCustomReadOnlyChanged(CustomReadOnlyChangedEventArgs eArgs)
        {
            if (CustomReadOnlyChanged != null)
            {
                // イベントハンドラが登録されているときイベントを発行
                CustomReadOnlyChanged(this, eArgs);
            }
        }

        #endregion

        #region イベントハンドラ
        /// <summary>
        /// 背景色を含む読み取り専用プロパティが変更されたとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">読み取り専用フラグを含むイベント引数</param>
        private void ZDate_CustomReadOnlyChanged(object sender, CustomReadOnlyChangedEventArgs e)
        {
            // 読み取り専用プロパティを与えられた値に変更
            //this.ReadOnly = e.ReadOnly;

            if (e.ReadOnly == true)
            {
                // 読み取り専用状態になるとき

                // タブストップ変更
                this.TabStop = false;

                // ドロップダウンの設定
                //this.DropDown.AllowDrop = false;

                // 背景色を変更するフラグを立てる
                //shownColorChangeFlg = true;

                // 現在の背景色を退避する
                enabledBackColor = this.BackColor;

                // 背景色を無効時の背景色に変更する
                //this.BackColor = this.DisabledBackColor;

                // フラグを戻す
                //shownColorChangeFlg = false;
            }
            else
            {
                // 読み取り専用でなくなるとき

                // タブストップ変更
                this.TabStop = true;

                // ドロップダウンの設定
                //this.DropDown.AllowDrop = true;

                // 背景色更新フラグ
                //shownColorChangeFlg = true;
                // 背景色を退避している背景色に変更する
                this.BackColor = enabledBackColor;
                // フラグを戻す
                //shownColorChangeFlg = false;
            }
        }

        /// <summary>
        /// 初めてフィールドが描写されるときの処理
        /// コンストラクタで反映されないフィールドフォーマットの設定を行うイベントハンドラです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZDate_FieldPaintFirst(object sender, EventArgs e)
        {
            //// フィールドフォーマットの適用
            //this.FieldsFormat = fieldsFormat;
            //this.DisplayFieldsFormat = displayFieldsFormat;

            //// イベントから除去
            //this.FieldPaint -= new EventHandler<FieldPaintEventArgs>(ZDate_FieldPaintFirst);
        }
        #endregion

        #region protectedメソッドオーバーライド
        /// <summary>
        /// フィールドからフォーカスが外れたとき日時の検証を行います。
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLeave(EventArgs e)
        {
            //dateValidator.Validate(this);
            base.OnLeave(e);
        }

        /// <summary>
        /// マウスホイールイベント処理
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            //マウスホイールを無効にする
            return;
        }

        ///// <summary>
        ///// リソースの解放を行います。
        ///// </summary>
        ///// <param name="disposing"></param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (dateValidator != null)
        //    {
        //        // 検証インスタンスがnullでないときのみ解放
        //        dateValidator.Dispose();
        //        dateValidator = null;
        //    }

        //    base.Dispose(disposing);
        //}
        #endregion

        #region ユーザーメソッド(private)
        /// <summary>
        /// 与えられた日付が最小値より小さいとき最小値を
        /// 最大値より大きいとき最大値を
        /// 最小値と最大値の間にあるときそのままの日付を返します。
        /// </summary>
        /// <param name="date">判定する日付</param>
        /// <param name="minDate">日付の最小値</param>
        /// <param name="maxDate">日付の最大値</param>
        /// <returns>日付が最小値より小さいとき最小値の日付、
        /// 最大値より大きいとき最大値の日付、
        /// それ以外はそのままの日付を返します。</returns>
        private static DateTime fixDateValue(DateTime date, DateTime minDate, DateTime maxDate)
        {
            if (date < minDate)
            {
                return minDate;
            }
            else if (date > maxDate)
            {
                return maxDate;
            }
            else
            {
                return date;
            }
        }
        #endregion

        #region C1FlexGridのインターフェイス
        /// <summary>
        /// FlexGridに埋め込まれたときの初期化を行います。
        /// </summary>
        /// <param name="value">FlexGridに設定する値</param>
        /// <param name="attributes">編集するセルのスタイル要素の名と値に対応するキーを含む辞書</param>
        public void C1EditorInitialize(object value, System.Collections.IDictionary attributes)
        {
            // ボーダースタイルを変更
            //this.BorderStyle = BorderStyle.None;

            // 表示値を初期化
            if (value != null)
            {
                this.Value = (DateTime)value;
            }
            else
            {
                //if (this.AllowNull)
                //{
                //    this.Value = null;
                //}
                //else
                //{
                //    this.Value = RecommendedValue;
                //}
            }
        }

        /// <summary>
        /// FlexGridに渡す値を決定します。
        /// </summary>
        /// <returns>現在の値</returns>
        public object C1EditorGetValue()
        {
            // 入力値の検証
            //this.dateValidator.Validate(this);
            // 現在の値を返す
            return this.Value;
        }

        /// <summary>
        /// FlexGridに渡す値が有効かどうかを決定します。
        /// </summary>
        /// <returns>常に有効</returns>
        public bool C1EditorValueIsValid()
        {
            // 常に検証済の値を持つためtrueを返す
            return true;
        }

        /// <summary>
        /// FlexGrid中で編集中にキーが押されたときの処理を決定します。
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool C1EditorKeyDownFinishEdit(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //// エンターキーの場合
                //if (this.DroppedDown && this.DropDownCalendar.FocusDate != null)
                //{
                //    // ドロップダウン表示中で選択値があるとき、選択値で決定する。
                //    this.Value = this.DropDownCalendar.FocusDate;
                //}
                // 処理をFlexGridへ返す。
                return true;
            }
            else if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Escape)
            {
                // 処理をFlexGridへ返す。
                return true;
            }

            // コントロールで処理を続ける。
            return false;
        }


        #endregion
    }
}
