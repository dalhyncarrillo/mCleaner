﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mCleaner.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ClamWin_DB {
            get {
                return ((string)(this["ClamWin_DB"]));
            }
            set {
                this["ClamWin_DB"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClamWin_UpdateDBAtStartup {
            get {
                return ((bool)(this["ClamWin_UpdateDBAtStartup"]));
            }
            set {
                this["ClamWin_UpdateDBAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClamWin_AutoScanMemoryAtStartup {
            get {
                return ((bool)(this["ClamWin_AutoScanMemoryAtStartup"]));
            }
            set {
                this["ClamWin_AutoScanMemoryAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ClamWin_Proxy_Address {
            get {
                return ((string)(this["ClamWin_Proxy_Address"]));
            }
            set {
                this["ClamWin_Proxy_Address"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClamWin_SupressMessageAtStartup {
            get {
                return ((bool)(this["ClamWin_SupressMessageAtStartup"]));
            }
            set {
                this["ClamWin_SupressMessageAtStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ClamWin_Proxy_UserPass {
            get {
                return ((string)(this["ClamWin_Proxy_UserPass"]));
            }
            set {
                this["ClamWin_Proxy_UserPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("database.clamav.net")]
        public string ClamWin_DatabaseMirror {
            get {
                return ((string)(this["ClamWin_DatabaseMirror"]));
            }
            set {
                this["ClamWin_DatabaseMirror"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HideIrrelevantCleaners {
            get {
                return ((bool)(this["HideIrrelevantCleaners"]));
            }
            set {
                this["HideIrrelevantCleaners"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShredFiles {
            get {
                return ((bool)(this["ShredFiles"]));
            }
            set {
                this["ShredFiles"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool StartWhenSystemStarts {
            get {
                return ((bool)(this["StartWhenSystemStarts"]));
            }
            set {
                this["StartWhenSystemStarts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.2.0.0")]
        public string Version {
            get {
                return ((string)(this["Version"]));
            }
            set {
                this["Version"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection CustomLocationForDeletion {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CustomLocationForDeletion"]));
            }
            set {
                this["CustomLocationForDeletion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection WhitelistCollection {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["WhitelistCollection"]));
            }
            set {
                this["WhitelistCollection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int CleanOption {
            get {
                return ((int)(this["CleanOption"]));
            }
            set {
                this["CleanOption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection DupChecker_CustomPath {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DupChecker_CustomPath"]));
            }
            set {
                this["DupChecker_CustomPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DupChecker_MinSize {
            get {
                return ((int)(this["DupChecker_MinSize"]));
            }
            set {
                this["DupChecker_MinSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("9223372036854775")]
        public long DupChecker_MaxSize {
            get {
                return ((long)(this["DupChecker_MaxSize"]));
            }
            set {
                this["DupChecker_MaxSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*")]
        public string DupChecker_FileContaining {
            get {
                return ((string)(this["DupChecker_FileContaining"]));
            }
            set {
                this["DupChecker_FileContaining"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.*")]
        public string DupChecker_FileExtensions {
            get {
                return ((string)(this["DupChecker_FileExtensions"]));
            }
            set {
                this["DupChecker_FileExtensions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DupChecker_DuplicateFolderPath {
            get {
                return ((string)(this["DupChecker_DuplicateFolderPath"]));
            }
            set {
                this["DupChecker_DuplicateFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime ClamWin_LastDBUpdate {
            get {
                return ((global::System.DateTime)(this["ClamWin_LastDBUpdate"]));
            }
            set {
                this["ClamWin_LastDBUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int ClamWin_DaysBeforeNotifyToUpdate {
            get {
                return ((int)(this["ClamWin_DaysBeforeNotifyToUpdate"]));
            }
            set {
                this["ClamWin_DaysBeforeNotifyToUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClamWin_Update {
            get {
                return ((bool)(this["ClamWin_Update"]));
            }
            set {
                this["ClamWin_Update"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection LastActionsChecked {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["LastActionsChecked"]));
            }
            set {
                this["LastActionsChecked"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection CustomCleanerSelections {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CustomCleanerSelections"]));
            }
            set {
                this["CustomCleanerSelections"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>C:\\</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ClamWin_ScanLocations {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ClamWin_ScanLocations"]));
            }
            set {
                this["ClamWin_ScanLocations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>500</string>
  <string>150M</string>
  <string>50</string>
  <string>100M</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ClamWin_Max {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ClamWin_Max"]));
            }
            set {
                this["ClamWin_Max"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>[^\]*\.dbx$</string>
  <string>[^\]*\.tbb$</string>
  <string>[^\]*\.pst$</string>
  <string>[^\]*\.dat$</string>
  <string>[^\]*\.log$</string>
  <string>[^\]*\.evt$</string>
  <string>[^\]*\.nsf$</string>
  <string>[^\]*\.ntf$</string>
  <string>[^\]*\.chm$</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ClamWin_Exclude {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ClamWin_Exclude"]));
            }
            set {
                this["ClamWin_Exclude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DuplicateFilterFileSizeCriteara {
            get {
                return ((bool)(this["DuplicateFilterFileSizeCriteara"]));
            }
            set {
                this["DuplicateFilterFileSizeCriteara"] = value;
            }
        }
    }
}
