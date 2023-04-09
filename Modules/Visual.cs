using Pastel;
using InfinityBot.Resources;
using System.Runtime.InteropServices;

namespace InfinityBot;

internal static class Visual {
    public static void WriteHeader() {
        Console.WriteLine(VisualAdditional.TitleText.Pastel(System.Drawing.Color.DarkSlateBlue)
            + Environment.NewLine);

        Console.WriteLine($" Author: {VisualAdditional.Author.Pastel(System.Drawing.Color.Gray)} "
            +"<3".Pastel(ConsoleColor.Red));
    }
}