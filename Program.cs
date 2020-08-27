using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //
            //Restriction/Filtering Operations
            //
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit == "L");
            Console.WriteLine("What fruits start with the Letter L");
            // LFruits.foreach(items => Console.WriteLine($"{items}"));
            foreach (string items in LFruits)
            {
                Console.WriteLine($"{items}");
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");
            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);
            Console.WriteLine("I hand picked a few numbers Id like ya to see, counted em by multiplying 4 or maybe 6...");
            foreach (int thaPicks in fourSixMultiples)
            {
                Console.WriteLine(thaPicks);
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //
            //Ordering Operations
            //
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();
            descend.ForEach(name => Console.WriteLine($"Heres the List Descending: {name}"));
            Console.WriteLine("-------------------------------------------------------------------------------------");

            // Build a collection of these numbers sorted in ascending order
            List<int> numberd = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };
            List<int> ascend = numberd.OrderBy(numz => numz).ToList();
            ascend.ForEach(numz => Console.WriteLine($"Heres the List Ascending: {numz}"));
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //
            //Aggregate Operations
            //
            //Output the prior list of "numberd"....show how many numbers there are:
            /*            List<int> numberd.Count(num).ToList();
                        numberd.ForEach(num => Console.WriteLine($"Heres the official count of numbers in that list: {num}"));
                        Console.WriteLine("-------------------------------------------------------------------------------------");
                 */

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };
            double purchaseListSum = purchases.Sum();
            Console.WriteLine($"How much money have we made?: {purchaseListSum}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };
            double mostExpensive = prices.Max();
            Console.WriteLine($"What is our most expensive product?: {mostExpensive}");
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //
            //Partitioning Operations
            //
            
            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */


/* foreach (var area in areas)
  Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side",
                    area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));  */
        }

    }
}