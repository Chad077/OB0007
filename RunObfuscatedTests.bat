copy ".\Tests\bin\Debug\Microsoft.VisualStudio.TestPlatform.*.dll" ".\Tests\bin\Debug\BabelOut\"

:loop

set test="C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\Extensions\TestPlatform\vstest.console.exe"
%test% ".\Tests\bin\Debug\BabelOut\Tests.dll" /logger:console;verbosity=minimal

pause
goto :loop
rem @if errorlevel 1 pause


