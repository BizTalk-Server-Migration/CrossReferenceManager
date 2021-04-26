@ECHO OFF
SETLOCAL
SET SETUPFILE=QA-setupfile.xml
IF "%~1" NEQ "" IF EXIST "%~1" SET SETUPFILE=%~1
for /f "skip=4 tokens=2,*" %%f in ('reg query "HKLM\SOFTWARE\Microsoft\BizTalk Server\3.0" /v "InstallPath"') do SET BTSXRefImport="%%~g\BTSXRefImport.exe"
IF NOT DEFINED BTSXRefImport (
   for /f "skip=2 tokens=2,*" %%f in ('reg query "HKLM\SOFTWARE\Microsoft\BizTalk Server\3.0" /v "InstallPath"') do SET BTSXRefImport="%%~g\BTSXRefImport.exe"
)
SET BTSXRefImport=%BTSXRefImport:\\=\%
%BTSXRefImport% -file="%SETUPFILE%"

IF "%0" NEQ "%~nx0" PAUSE Press any key to return to windows
