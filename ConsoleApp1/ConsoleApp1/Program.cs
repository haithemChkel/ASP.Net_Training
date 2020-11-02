using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // **** Generic ****
            List<Vehicle> vehicules = new List<Vehicle>
            {
            new Auto { Brand = "Renault"},
            new Moto { Brand = "Honda"},
            new Auto { Brand = "Peugeaot"},
            new Moto { Brand = "Yamaha"},
            };
            foreach (var item in vehicules)
            {
                ShowVehicule(item);
            }


            // **** Indices and ranges ****
            var words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0
            Console.WriteLine($"The last word is {words[^1]}"); // writes "dog"
            string[] quickBrownFox = words[1..4]; // quick brown fox
            string[] lazyDog = words[^2..^0]; // lazy dog
            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            string[] lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Range phrase = 1..4;
            var text = words[phrase]; //// quick brown fox


            Console.ReadLine();
        }

        static void ShowVehicule<T>(T vehicule) where T : Vehicle
        {
            Console.WriteLine("Vehicule of type {0}", vehicule.Brand);
        }

    }
}