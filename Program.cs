using System;
using System.Threading;

class RainSimulation
{
    static void Main()
    {
        Console.CursorVisible = false;

        // Simple cloud frames for some subtle animation
        string[] cloudFrames = new string[]
        {
            "      ☁️☁️☁️     ☁️☁️      ",
            "   ☁️☁️      ☁️☁️      ☁️   ",
            "      ☁️☁️☁️     ☁️☁️      "
        };

        // Rain frames simulating drops shifting horizontally
        string[] rainFrames = new string[]
        {
            "     .     .      .  .     ",
            "  .      .     .      .    ",
            "     .      .     .      . ",
            " .      .     .      .     ",
            "     .      .     .      . "
        };

        int width = Console.WindowWidth;
        int height = Console.WindowHeight;

        for (int i = 0; i < 50; i++)
        {
            Console.SetCursorPosition(0, 0);

            // Print cloud frame (cycling through the frames for slight animation)
            string cloud = cloudFrames[i % cloudFrames.Length];
            Console.WriteLine(cloud.PadRight(width));

            // Print rain frames below cloud to fill the remaining screen
            string rain = rainFrames[i % rainFrames.Length];
        } }