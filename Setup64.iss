; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "mCleaner"
#define MyAppVersion "1.0"
#define MyAppPublisher "MicroHealth, LLC"
#define MyAppURL "https://www.microhealthllc.com/"
#define MyAppExeName "mCleaner.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{020C6305-420E-4D7C-983F-66B3454CFF5B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=setup64
Compression=lzma
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\mCleaner.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\Clam\*"; DestDir: "{app}\Clam"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\Cleaners\*"; DestDir: "{app}\Cleaners"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\GalaSoft.MvvmLight.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\GalaSoft.MvvmLight.Extras.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\GalaSoft.MvvmLight.Platform.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\mCleaner.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\Microsoft.Practices.ServiceLocation.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\sqlite3.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\x64\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Clients\oDesk\2015\Frank\MicroHealthLLC_Git\mCleaner\mCleaner\mCleaner\bin\Release\System.Windows.Interactivity.dll"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
