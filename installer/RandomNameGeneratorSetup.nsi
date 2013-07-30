;Include Modern UI

  !include "MUI2.nsh"
  !include "FileAssociation.nsh"

Name "Random Name Generator 1"
OutFile "RandomNameGenerator1Setup.exe"
InstallDir "$PROGRAMFILES\Zeta Centauri\Random Name Generator"
InstallDirRegKey HKLM "Software\Random Name Generator" "Install_Dir"
RequestExecutionLevel admin
!define MUI_ICON "RandomName.ico"
!define MUI_UNICON "RandomName.ico"

;Version Information

  VIProductVersion "1.0.0.0"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "Random Name Generator"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "Zeta Centauri"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "Copyright 2011-2012 Zeta Centauri"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "Random Name Generator Installer"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "1.0.0.0"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductVersion" "1.0.0.0"

;Interface Settings

  !define MUI_ABORTWARNING

;Pages

  !insertmacro MUI_PAGE_LICENSE "License.txt"
;  !insertmacro MUI_PAGE_DIRECTORY
  !insertmacro MUI_PAGE_INSTFILES
      !define MUI_FINISHPAGE_NOAUTOCLOSE
      !define MUI_FINISHPAGE_RUN
      !define MUI_FINISHPAGE_RUN_CHECKED
      !define MUI_FINISHPAGE_RUN_TEXT "Launch Random Name Generator"
      !define MUI_FINISHPAGE_RUN_FUNCTION "LaunchProgram"
      !define MUI_FINISHPAGE_SHOWREADME ""
      !define MUI_FINISHPAGE_SHOWREADME_NOTCHECKED
      !define MUI_FINISHPAGE_SHOWREADME_TEXT "Create Desktop Shortcut"
      !define MUI_FINISHPAGE_SHOWREADME_FUNCTION finishpageaction
  !insertmacro MUI_PAGE_FINISH
  
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES

;Languages
 
  !insertmacro MUI_LANGUAGE "English"


; The stuff to install
Section "Random Name Generator"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "RandomNameGenerator.exe"
  File "License.txt"
  File "RandomName.ico"
  
  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\RandomNameGenerator "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "DisplayName" "Random Name Generator"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "DisplayVersion" "1"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "Publisher" "Zeta Centauri"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "DisplayIcon" "$INSTDIR\RandomName.ico"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator" "NoRepair" 1
  WriteUninstaller "uninstall.exe"
   
SectionEnd

; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

  CreateDirectory "$SMPROGRAMS\Zeta Centauri\Random Name Generator"
  CreateShortCut "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Random Name Generator.lnk" "$INSTDIR\RandomNameGenerator.exe" "" "" 0
  ;CreateShortCut "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  WriteINIStr "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Random Name Generator Website.url" "InternetShortcut" "URL" "http://zetacentauri.com/software_randomnamegenerator.htm"
  
SectionEnd

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\RandomNameGenerator"
  DeleteRegKey HKLM SOFTWARE\RandomNameGenerator

  ; Remove files and uninstaller
  Delete $INSTDIR\RandomNameGenerator.exe
  Delete $INSTDIR\License.txt
  Delete $INSTDIR\uninstall.exe
  Delete $INSTDIR\RandomName.ico

  ; Remove shortcuts, if any
  Delete "$SMPROGRAMS\Zeta Centauri\Random Name Generator\*.*"
  Delete "$DESKTOP\Random Name Generator.lnk"
  Delete "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Random Name Generator Website.url"
  ;DeleteINISec "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Random Name Generator Website.url" "InternetShortcut"

  ; Remove directories used
  RMDir "$SMPROGRAMS\Zeta Centauri\Random Name Generator"
  RMDir "$SMPROGRAMS\Zeta Centauri"
  RMDir "$INSTDIR"


SectionEnd

Function LaunchProgram
  ExecShell "" "$SMPROGRAMS\Zeta Centauri\Random Name Generator\Random Name Generator.lnk"
FunctionEnd

Function finishpageaction
  CreateShortcut "$DESKTOP\Random Name Generator.lnk" "$instdir\RandomNameGenerator.exe"
FunctionEnd
