@echo off

IF EXIST "out" RMDIR /S /Q "out"

MKDIR "out"
MKDIR "out\bin"

rc.exe /fo "out\restartaudio.res" "restartaudio.rc"
csc.exe /win32res:"out\restartaudio.res" /debug /pdb:"out\bin\restartaudio.pdb" /out:"out\bin\restartaudio.exe" "restartaudio.cs"
