﻿using System.Diagnostics;
using System.Threading;
using OkayegTeaTimeCSharp.Logging;
using OkayegTeaTimeCSharp.Twitch.API;
using OkayegTeaTimeCSharp.Twitch.Bot;

namespace OkayegTeaTimeCSharp;

public static class Program
{
    private static bool _running = true;

    private static void Main()
    {
        Console.Title = "OkayegTeaTime";

        LoadJsonData();
        TwitchApi.Configure();
        TwitchBot twitchBot = new();
        twitchBot.Connect();

        while (_running)
        {
            Thread.Sleep(1000);
        }
    }

    public static void ConsoleOut(string value, bool logging = false, ConsoleColor fontColor = ConsoleColor.Gray)
    {
        Console.ForegroundColor = fontColor;
        Console.WriteLine($"{DateTime.Now:HH:mm:ss} | {value}");
        Console.ForegroundColor = ConsoleColor.Gray;
        if (logging)
        {
            Logger.Log(value);
        }
    }

    public static void DebugOut(string value, bool logging = false)
    {
        Debug.WriteLine($"{DateTime.Now:HH:mm:ss} | {value}");
        if (logging)
        {
            Logger.Log(value);
        }
    }

    public static void Restart()
    {
        ConsoleOut($"[SYSTEM] RESTARTED", true, ConsoleColor.Red);
        Process.Start($"./OkayegTeaTimeCSharp");
        _running = false;
        Environment.Exit(0);
    }
}
