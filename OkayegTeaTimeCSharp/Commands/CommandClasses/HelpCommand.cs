﻿using OkayegTeaTimeCSharp.Properties;
using OkayegTeaTimeCSharp.Twitch.Bot;
using OkayegTeaTimeCSharp.Utils;
using TwitchLib.Client.Models;

namespace OkayegTeaTimeCSharp.Commands.CommandClasses
{
    public class HelpCommand
    {
        public static void Handle(TwitchBot twitchBot, ChatMessage chatMessage)
        {
            twitchBot.Send(chatMessage.Channel, $"{Emoji.PointRight} {chatMessage.Username}, here you can find a list of commands and the repository: {Resources.GitHubRepoLink}");
        }
    }
}