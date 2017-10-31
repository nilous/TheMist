;NSIS Modern User Interface
;Basic Example Script
;Written by Joost Verburg

;--------------------------------
;Include Modern UI

  !include "MUI2.nsh"


;--------------------------------
;General

  ;Name and file
  Name "The Mist"
  OutFile "TheMistSetup.exe"

  ;Default installation folder
  InstallDir "$PROGRAMFILES\TheMist"

  ;Get installation folder from registry if available
  ;InstallDirRegKey HKCU "Software\Modern UI Test" ""

  ;Request application privileges for Windows Vista
  RequestExecutionLevel admin

;--------------------------------
;Interface Settings

  !define MUI_ABORTWARNING

;--------------------------------
;Pages

  !insertmacro MUI_PAGE_LICENSE "License.txt"
  ;!insertmacro MUI_PAGE_COMPONENTS
  ;!insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES

  ;!insertmacro MUI_UNPAGE_CONFIRM
  ;!insertmacro MUI_UNPAGE_INSTFILES

;--------------------------------
;Languages

  ;!insertmacro MUI_LANGUAGE "English"
  !insertmacro MUI_LANGUAGE "SimpChinese"

;--------------------------------
;Installer Sections

Section "Dummy Section" SecDummy
  SetDetailsPrint both

  SetOutPath "$INSTDIR"
  File "TheMist.exe"
  File "db.dat"
  File "Newtonsoft.Json.dll"
  File "Newtonsoft.Json.xml"
  File "Npgsql.dll"
  File "Npgsql.xml"
  File "System.Threading.Tasks.Extensions.dll"
  File "System.Threading.Tasks.Extensions.xml"
  File "TheMist.application"
  File "TheMist.exe.config"
  File "TheMist.exe.manifest"

  CreateShortCut "$DESKTOP\¹úÄÚÊÕ¸¶.lnk" "$INSTDIR\TheMist.exe"

SectionEnd

;--------------------------------
;Descriptions

  ;Language strings
  LangString DESC_SecDummy ${LANG_ENGLISH} "A test section."

  ;Assign language strings to sections
  !insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
    !insertmacro MUI_DESCRIPTION_TEXT ${SecDummy} $(DESC_SecDummy)
  !insertmacro MUI_FUNCTION_DESCRIPTION_END

;--------------------------------
;Uninstaller Section

Section "Uninstall"

  ;ADD YOUR OWN FILES HERE...

  Delete "$INSTDIR\Uninstall.exe"

  RMDir "$INSTDIR"

  DeleteRegKey /ifempty HKCU "Software\Modern UI Test"

SectionEnd
