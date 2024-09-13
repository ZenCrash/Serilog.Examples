﻿using Microsoft.Extensions.Configuration;
using Serilog.Context;

namespace Serilog.Examples.LogToFile
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Initialize serilog using appsetting.json
      IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

      Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configuration)
        .Enrich.FromLogContext()
        .CreateLogger();

      //Log examples
      Log.Verbose("Hello Verbose World!");
      Log.Debug("Hello Debug World!");
      Log.Information("Hello Information World!");
      Log.Warning("Hello Warning World!");
      Log.Error("Hello Error World!");
      Log.Fatal("Hello Fatal World!");

      using (LogContext.PushProperty("MeaningOfLife", 42)) //contextual information to your log events
      {
        Log.Information("What is the meaning of life");
      }
    }
  }
}
