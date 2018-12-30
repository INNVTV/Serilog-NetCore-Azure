# Serilog in .Net Core on Azure
Simple Serilog implementation with .Net Core Razor Pages on Azure.

For more info on Serilog visit their [website](https://serilog.net/) or [wiki](https://github.com/serilog/serilog/wiki).

## Required Packages

    Serilog
    Serilog.Sinks.Console
    Serilog.Sinks.File

## Local Debug
To see Serilog in a local console window make sure you are running via Kestrel and not IIS. You can swithc to Kestrel by selecting the solution/project name from the debug server dropdown: 

![server](https://github.com/INNVTV/Serilog-NetCore-Azure/blob/master/_docs/imgs/server.png)

## Text Logs
Text logs are stored in **_logs** folder and set to a daily rolling interval. Serilog has a vast array of other sinks available.

## UI
Simple interface uses Razor Pages with page handlers:
![UI](https://github.com/INNVTV/Serilog-NetCore-Azure/blob/master/_docs/imgs/ui.png)


