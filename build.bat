@echo off
dotnet publish --self-contained true -r linux-x64 -c release
pause