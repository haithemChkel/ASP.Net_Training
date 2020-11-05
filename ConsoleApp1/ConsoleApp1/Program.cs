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
            new Auto { Brand = "Renault", NombreDePlace = 3},
            new Moto { Brand = "Honda", Cylindre = 50},
            new Auto { Brand = "Peugeaot", NombreDePlace = 52},
            new Moto { Brand = "Yamaha", Cylindre = 56},
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
            Console.WriteLine($"**** quickBrownFox { string.Join(", ", quickBrownFox)}");
            string[] lazyDog = words[^2..^0]; // lazy dog
            string[] allWords = words[..]; // contains "The" through "dog".
            string[] firstPhrase = words[..4]; // contains "The" through "fox"
            Console.WriteLine($"**** firstPhrase { string.Join(", ", firstPhrase)}");
            string[] lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
            Console.WriteLine($"**** lastPhrase { string.Join(", ", firstPhrase)}");

            Range phrase = 1..4;
            var text = words[phrase]; //// quick brown fox



            List<int> numbers = null;
            int? i = null;
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);
            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17


            Console.ReadLine();
        }

        static void ShowVehicule<T>(T vehicule) where T : Vehicle, new() 
        {
            Console.WriteLine("Vehicule of type {0}", vehicule.Brand);
        }

        static void ShowVehicule(Vehicle vehicule)
        {
            Console.WriteLine("Vehicule of type {0}", vehicule.Brand);
        }

    }
}