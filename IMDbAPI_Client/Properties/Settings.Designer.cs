﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMDbAPI_Client.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\New Movies")]
        public string MoviesDirectory {
            get {
                return ((string)(this["MoviesDirectory"]));
            }
            set {
                this["MoviesDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApiKey {
            get {
                return ((string)(this["ApiKey"]));
            }
            set {
                this["ApiKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DownloadSiteName1\r\nDownloadSiteName2")]
        public string RemoveSites {
            get {
                return ((string)(this["RemoveSites"]));
            }
            set {
                this["RemoveSites"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public global::MetroFramework.MetroThemeStyle Theme {
            get {
                return ((global::MetroFramework.MetroThemeStyle)(this["Theme"]));
            }
            set {
                this["Theme"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public global::MetroFramework.MetroColorStyle Style {
            get {
                return ((global::MetroFramework.MetroColorStyle)(this["Style"]));
            }
            set {
                this["Style"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SeriesTvDirectory {
            get {
                return ((string)(this["SeriesTvDirectory"]));
            }
            set {
                this["SeriesTvDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SeriesTvID {
            get {
                return ((string)(this["SeriesTvID"]));
            }
            set {
                this["SeriesTvID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MovieFile {
            get {
                return ((string)(this["MovieFile"]));
            }
            set {
                this["MovieFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::IMDbAPI_Client.ClientOptions ClientOptions {
            get {
                return ((global::IMDbAPI_Client.ClientOptions)(this["ClientOptions"]));
            }
            set {
                this["ClientOptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Movies")]
        public global::IMDbAPI_Client.OperationType OperationType {
            get {
                return ((global::IMDbAPI_Client.OperationType)(this["OperationType"]));
            }
            set {
                this["OperationType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseProxy {
            get {
                return ((bool)(this["UseProxy"]));
            }
            set {
                this["UseProxy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyAddress {
            get {
                return ((string)(this["ProxyAddress"]));
            }
            set {
                this["ProxyAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyUsername {
            get {
                return ((string)(this["ProxyUsername"]));
            }
            set {
                this["ProxyUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProxyPassword {
            get {
                return ((string)(this["ProxyPassword"]));
            }
            set {
                this["ProxyPassword"] = value;
            }
        }
    }
}
