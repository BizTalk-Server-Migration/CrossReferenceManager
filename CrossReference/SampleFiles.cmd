@ECHO OFF
SETLOCAL ENABLEDELAYEDEXPANSION

SET INST=001
SET listOfAppType=listOfAppType!INST!.xml
SET listOfAppInstance=listOfAppInstance!INST!.xml
SET listOfIDXRef=listOfIDXRef!INST!.xml
SET listOfIDXRefData=listOfIDXRefData!INST!.xml
SET setupfile=setupfile!INST!.xml

SET __AppType_A=ApplicationA
SET __AppInstance_A=AppInstanceA
SET __idXRefName_A=idxXRefA
SET __CommondID_A=CommonIDA
SET __AppID_A=AppIDA

ECHO ^<?xml version="1.0" encoding="UTF-8"?^>>%listOfAppType%
ECHO ^<listOfAppType^>>>%listOfAppType%
ECHO     ^<appType^>>>%listOfAppType%
ECHO         ^<name^>%__AppType_A%^</name^>>>%listOfAppType%
ECHO     ^</appType^>>>%listOfAppType%
ECHO ^</listOfAppType^>>>%listOfAppType%

ECHO ^<?xml version="1.0" encoding="UTF-8"?^>>%listOfAppInstance%
ECHO ^<listOfAppInstance^>>>%listOfAppInstance%
ECHO     ^<appInstance^>>>%listOfAppInstance%
ECHO         ^<instance^>%__AppInstance_A%^</instance^>>>%listOfAppInstance%
ECHO         ^<type^>%__AppType_A%^</type^>>>%listOfAppInstance%
ECHO     ^</appInstance^>>>%listOfAppInstance%
ECHO ^</listOfAppInstance^>>>%listOfAppInstance%

ECHO ^<?xml version="1.0" encoding="UTF-8"?^>>%listOfIDXRef%
ECHO ^<listOfIDXRef^>>>%listOfIDXRef%
ECHO     ^<idXRef^>>>%listOfIDXRef%
ECHO         ^<name^>%__idXRefName_A%^</name^>>>%listOfIDXRef%
ECHO     ^</idXRef^>>>%listOfIDXRef%
ECHO ^</listOfIDXRef^>>>%listOfIDXRef%


ECHO ^<?xml version="1.0" encoding="UTF-8"?^>>%listOfIDXRefData%
ECHO ^<listOfIDXRefData^>>>%listOfIDXRefData%
ECHO     ^<idXRef name="%__idXRefName_A%"^>>>%listOfIDXRefData%
ECHO         ^<appInstance name="%__AppInstance_A%"^>>>%listOfIDXRefData%
ECHO             ^<appID commonID="%__CommondID_A%"^>%__AppID_A%^</appID^>>>%listOfIDXRefData%
ECHO         ^</appInstance^>>>%listOfIDXRefData%
ECHO     ^</idXRef^>>>%listOfIDXRefData%
ECHO ^</listOfIDXRefData^>>>%listOfIDXRefData%

ECHO ^<?xml version="1.0" encoding="UTF-8"?^>>%setupfile%
ECHO ^<Setup-Files^>>>%setupfile%
ECHO 	^<App_Type_file^>%listOfAppType%^</App_Type_file^>>>%setupfile%
ECHO 	^<App_Instance_file^>%ListOfAppInstance%^</App_Instance_file^>>>%setupfile%
ECHO 	^<IDXRef_file^>%ListOfIDXRef%^</IDXRef_file^>>>%setupfile%
ECHO 	^<IDXRef_Data_file^>%ListOfIDXRefData%^</IDXRef_Data_file^>>>%setupfile%
ECHO ^</Setup-Files^>>>%setupfile%