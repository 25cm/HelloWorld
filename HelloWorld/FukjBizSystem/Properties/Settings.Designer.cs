﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FukjBizSystem.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\HolidayFile.xml")]
        public string HolidayFile {
            get {
                return ((string)(this["HolidayFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(".\\ErrMsgFile.xml")]
        public string ErrMsgFile {
            get {
                return ((string)(this["ErrMsgFile"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ScenarioMode {
            get {
                return ((bool)(this["ScenarioMode"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\FukjBizSystem\\Print")]
        public string PrintDirectory {
            get {
                return ((string)(this["PrintDirectory"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\FukjBizSystem\\PrintFormat\\")]
        public string PrintFormatFolder {
            get {
                return ((string)(this["PrintFormatFolder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("浄化槽基幹システム")]
        public string SystemName {
            get {
                return ((string)(this["SystemName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\")]
        public string InputCheckFileFolder {
            get {
                return ((string)(this["InputCheckFileFolder"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("HOS.xlsm")]
        public string InputCheckFileNm {
            get {
                return ((string)(this["InputCheckFileNm"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("領収書.xlsx")]
        public string RyosyuFormatFile {
            get {
                return ((string)(this["RyosyuFormatFile"]));
            }
            set {
                this["RyosyuFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("指定採水員証明書.xlsx")]
        public string SaisuiinShomeishoFormatFile {
            get {
                return ((string)(this["SaisuiinShomeishoFormatFile"]));
            }
            set {
                this["SaisuiinShomeishoFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("指定採水員指定書.xlsx")]
        public string SaisuiinShiteishoFormatFile {
            get {
                return ((string)(this["SaisuiinShiteishoFormatFile"]));
            }
            set {
                this["SaisuiinShiteishoFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("seal.png")]
        public string SealImage {
            get {
                return ((string)(this["SealImage"]));
            }
            set {
                this["SealImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("会員情報確認書.xlsx")]
        public string KaiinJouhouKakuninshoFormatFile {
            get {
                return ((string)(this["KaiinJouhouKakuninshoFormatFile"]));
            }
            set {
                this["KaiinJouhouKakuninshoFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("指定採水員指定講習会受講申込書.xlsx")]
        public string JukoMoshikomishoShutsuryokuFormatFile {
            get {
                return ((string)(this["JukoMoshikomishoShutsuryokuFormatFile"]));
            }
            set {
                this["JukoMoshikomishoShutsuryokuFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("保証登録申請書.xlsx")]
        public string HoshoNoFormatFile {
            get {
                return ((string)(this["HoshoNoFormatFile"]));
            }
            set {
                this["HoshoNoFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("タックシール.xlsx")]
        public string SealTackFormatFile {
            get {
                return ((string)(this["SealTackFormatFile"]));
            }
            set {
                this["SealTackFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.0.193;Initial Catalog=fukjBizSystem;Persist Security Info=Tru" +
            "e;User ID=sa;Password=fukj_1800")]
        public string FukjBizSystemConnectionString {
            get {
                return ((string)(this["FukjBizSystemConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("送付状.xlsx")]
        public string SofujoFormatFile {
            get {
                return ((string)(this["SofujoFormatFile"]));
            }
            set {
                this["SofujoFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ＦＡＸ送信票２.xlsx")]
        public string SouShishyo2FormatFile {
            get {
                return ((string)(this["SouShishyo2FormatFile"]));
            }
            set {
                this["SouShishyo2FormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ＦＡＸ送信票１.xlsx")]
        public string SouShishyo1FormatFile {
            get {
                return ((string)(this["SouShishyo1FormatFile"]));
            }
            set {
                this["SouShishyo1FormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("検査啓発推進費支払票(協同組合).xlsx")]
        public string KensaKeihatsuKyodoKumiaiFormatFile {
            get {
                return ((string)(this["KensaKeihatsuKyodoKumiaiFormatFile"]));
            }
            set {
                this["KensaKeihatsuKyodoKumiaiFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("検査啓発推進費一覧.xlsx")]
        public string KensaKeihatsuIchiranFormatFile {
            get {
                return ((string)(this["KensaKeihatsuIchiranFormatFile"]));
            }
            set {
                this["KensaKeihatsuIchiranFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("検査啓発推進費支払票(持込業者).xlsx")]
        public string MoshiKomiGyoshaFormatFile {
            get {
                return ((string)(this["MoshiKomiGyoshaFormatFile"]));
            }
            set {
                this["MoshiKomiGyoshaFormatFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("検査啓発推進費支払票(収集取扱業者).xlsx")]
        public string ShushuToriatsukaiGyoshaFormatFile {
            get {
                return ((string)(this["ShushuToriatsukaiGyoshaFormatFile"]));
            }
            set {
                this["ShushuToriatsukaiGyoshaFormatFile"] = value;
            }
        }
    }
}
