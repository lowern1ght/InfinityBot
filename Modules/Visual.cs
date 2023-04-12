
using Pastel;
using Remora.Rest;
using Remora.Commands;
using Remora.Extensions;

//local
using InfinityBot.Resources;

//Remora
using Remora.Discord;
using Remora.Discord.API;
using Remora.Discord.Rest;
using Remora.Discord.Caching;
using Remora.Discord.Gateway;
using Remora.Discord.Commands;
using Remora.Discord.Interactivity;

namespace InfinityBot;

internal static class Visual {
    /// <summary>
    /// Write header info about bot
    /// </summary>
    public static void WriteHeader() {
        Console.WriteLine(VisualAdditional.TitleText.Pastel(System.Drawing.Color.DarkSlateBlue)
            + Environment.NewLine);

        Console.WriteLine($" Author: {VisualAdditional.Author.Pastel(System.Drawing.Color.Gray)} "
            +"<3".Pastel(ConsoleColor.Red) + Environment.NewLine);
    }
}