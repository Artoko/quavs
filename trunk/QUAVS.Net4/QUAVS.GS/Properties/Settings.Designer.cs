﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUAVS.GS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::QUAVS.Types.VideoSourceType VideoSource {
            get {
                return ((global::QUAVS.Types.VideoSourceType)(this["VideoSource"]));
            }
            set {
                this["VideoSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::QUAVS.Types.VideoCodecType VideoCompressor {
            get {
                return ((global::QUAVS.Types.VideoCodecType)(this["VideoCompressor"]));
            }
            set {
                this["VideoCompressor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("255")]
        public byte HUDAlpha {
            get {
                return ((byte)(this["HUDAlpha"]));
            }
            set {
                this["HUDAlpha"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("480")]
        public int VideoHeight {
            get {
                return ((int)(this["VideoHeight"]));
            }
            set {
                this["VideoHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("640")]
        public int VideoWidth {
            get {
                return ((int)(this["VideoWidth"]));
            }
            set {
                this["VideoWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::QUAVS.Types.VideoFolderType VideoFolder {
            get {
                return ((global::QUAVS.Types.VideoFolderType)(this["VideoFolder"]));
            }
            set {
                this["VideoFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Lime")]
        public global::System.Drawing.Color HUDColor {
            get {
                return ((global::System.Drawing.Color)(this["HUDColor"]));
            }
            set {
                this["HUDColor"] = value;
            }
        }
    }
}
