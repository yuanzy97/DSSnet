IF EXIST %1 GOTO COPY
MD %1
:COPY
XCOPY /S /I /V /C /R /Y %2 %1
:DONE