using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart ()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            Color = BearColor.Brown;
        }

        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name}Shoots hearts from his belly.❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️❤️");
            Console.ResetColor();
        }
    }
}
