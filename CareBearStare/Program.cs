using System;
using System.Collections.Generic;
using System.Linq;
using CareBearStare.Bears;

namespace CareBearStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            tenderHeart.Hug(grumpyBear);
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Maria");
                bear.Stare();
            }


            //these are filter and transformation statements: .select and .where
            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                                                .Select(bear => bear.Name)
                                                .Where(name => name.StartsWith('T'));

            //the fact arrow functions: called Lambda expressions or delegate expressions
            //they will "short circut": .Any will stop after finding one bear that is not a tinderheart
            //.All will stop at the first tinderheart found
            var anyTinderHeartBears = careBears.Any(bear => bear is TinderHeart);
            var allTinderHeartBears = careBears.All(bear => bear is TinderHeart);

            var firstBear = careBears.First();
            var firstBearStartingWithT = careBears.First(bear => bear.Name.StartsWith("T"));
            //var blowsUp = careBears.First(bear => bear.Name.StartsWith("W"));  --> throws and exceptions
            var works = careBears.FirstOrDefault(bear => bear.Name.StartsWith("W"));  //returns as null

            var skippedGrumpy = careBears.Skip(1).Take(2);  //skips the 1st one, but will returnt he next 2 things

            var numOfCharacters = careBears.Sum(bear => bear.Name.Length); //aslo .Max

            var orderedBears = careBears.OrderBy(bear => bear.BellyBadge);

            //Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love - a - lot Bear, Tenderheart Bear, and Wish Bear

            Console.ReadKey();
        }
    }
}
