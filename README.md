<h1> Serilog Example code implementations </h1>

<h2>Description:</h2>
Serilog is a diagnostic logging library for .NET applications.
<br>This Repository contains example projects of code implimentation of Serilog

<h2>Projects:</h2>
<ul>
  <li>Serilog.Examples.LogToDebug (Logs to IDE output window)</li>
  <li>Serilog.Examples.LogToConsole (Logs to console)</li>
  <li>Serilog.Examples.LogToFile (Logs to file)</li>
  <li>Serilog.Examples.LogToSeq (Logs to Seq web server)</li>
  <li>Serilog.Examples.LogAll (Logs to all)</li>
</ul>

<h2>Serilog Installation:</h2>
In Visual studio select "Project" -> "Manage Nuget packages". Select "Browse" and search for Serilog,
<br>and install the package needed:
<br>Alternatively you can install the packages in the project using terminal by using the `.NET CLI` commands provided.

<h3>Serilog Nuget Packages:</h3>

<ul>
  <li><IMG  src="https://avatars.githubusercontent.com/u/5691010?s=200&amp;v=4" width="14<"/> <a href="https://www.nuget.org/packages/Serilog/4.0.2-dev-02226#readme-body-tab">Serilog</a> (Advanced logging)</li>
  
  ```dotnet add package Serilog```
  <ul>
    <li>Manages structured logging</li>
    <li>Provies configurable logging creation and capabilities</li>
    <li>Define log levels like (Information, Error, Debug, etc.)</li>
  </ul>
  <li><IMG  src="https://api.nuget.org/v3-flatcontainer/serilog.settings.configuration/8.0.2/icon" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Settings.Configuration#readme-body-tab">Serilog.Settings.Configuration</a> (support Serilog configuration via external configuration files)</li>
  
  ```dotnet add package Serilog.Settings.Configuration```
  <ul>
    <li>External configuration support for appsettings.json among other.</li>
  </ul>
  <li><IMG  src="https://api.nuget.org/v3-flatcontainer/serilog.extensions.logging/8.0.1-dev-10398/icon" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Extensions.Logging/8.0.1-dev-10398#readme-body-tab">Serilog.Extensions.Logger</a> (allows Serilog to be used as a logging provider within applications that rely on the Microsoft.Extensions.Logging infrastructure)</li>
  
  ```dotnet add package Serilog.Extensions.Logging```
  <li><IMG  src="https://avatars.githubusercontent.com/u/5691010?s=200&amp;v=4" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.AspNetCore#readme-body-tab">Serilog.AspNetCore</a> (support for ASP.NET core logging)</li>
  
  ```dotnet add package Serilog.AspNetCore```
</ul>

<h3>Sinks: (Sinks define the various targets where log events are written)</h3>

<ul>
  <li><IMG  src="https://api.nuget.org/v3-flatcontainer/serilog.sinks.async/2.0.0/icon" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Sinks.Async#readme-body-tab">Serilog.Sinks.Async</a> (support Asynchronous sink wrapper for Serilog)</li>
  
  ```dotnet add package Serilog.Sinks.Async```
  <li><IMG  src="https://avatars.githubusercontent.com/u/5691010?s=200&amp;v=4" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Sinks.Debug#readme-body-tab">Serilog.Sinks.Debug</a> (support for writing log to Visual Studio and other IDE output window)</li>
  
  ```dotnet add package Serilog.Sinks.Debug```
  <li><IMG  src="https://avatars.githubusercontent.com/u/5691010?s=200&amp;v=4" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Sinks.Console#readme-body-tab">Serilog.Sinks.Console</a> (support for writing log to the console)</li>
  
  ```dotnet add package Serilog.Sinks.Console```
  <ul>
    <li>Allows Serilog to output log messages to the console.</li>
  </ul>
  <li><IMG  src="https://api.nuget.org/v3-flatcontainer/serilog.sinks.file/6.0.0/icon" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Sinks.File#readme-body-tab">Serilog.Sinks.File</a> (support for writing log to txt, log, json, compact json, xml, csv)</li>
  
  ```dotnet add package Serilog.Sinks.File```
  <li><IMG  src="https://api.nuget.org/v3-flatcontainer/serilog.sinks.seq/9.0.0-dev-00310/icon" width="14<"/> <a href="https://www.nuget.org/packages/Serilog.Sinks.Seq/9.0.0-dev-00310#readme-body-tab">Serilog.Sinks.Seq</a> (support Serilog to send log events to Seq, a structured log server designed for managing and analyzing logs)</li>
  
  ```dotnet add package Serilog.Sinks.Seq```
</ul>

<h3>Enrichers: (Components that add additional contextual information to log events)</h3>
<ul>
  <li>enrichers will be added if requested.</li>
</ul>

<h3>External links:</h3>
<ul>
  <li>Getting Started - <a href="https://serilog.net/">serilog.net</a></li>
  <li>Github - <a href="https://serilog.net/">github.com/serilog/serilog</a></li>
</ul>
