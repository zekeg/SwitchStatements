using System;

namespace SwitchStatements;

internal class SwitchStatements
{
    static void Main()
    {
        Console.WriteLine("What is your favorite school subject?");
        string schoolSub = Console.ReadLine().ToLower();
        switch (schoolSub) {
            case "math":
                Console.WriteLine("Math is ok, I guess...for some folks...not me");
                break;
            case "english":
                Console.WriteLine("Yeah, english? I speek english all the time I don't need to go to school for it.");
                break;
            case "history":
                Console.WriteLine("I don't really need to go to school for history, there's a whole channel for it. Have you heard that they truck on ice now??");
                break;
            case "chemistry":
                Console.WriteLine("I don't wanna take chemistry, I heard chemicals are dangerous.");
                break;
            case "gym":
                Console.WriteLine("Who the heck is Jim?");
                break;
            default:
                Console.WriteLine($"I don't know what {schoolSub} is and I'm certainly not wasting my time going to school for it");
                break;
        }
    }
}
