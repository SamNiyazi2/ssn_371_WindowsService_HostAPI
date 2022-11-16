
rem 11/15/2022 12:30 pm - SSN

set tempcd=%cd%

cd %~dp0

"c:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Current\Bin\msbuild.exe" -p:Configuration=DEBUG

cd %tempcd%
set tempcd=