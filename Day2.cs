using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day2
    {

        public Day2()
        {
            Console.WriteLine("\n\n\nDay2");
            Console.WriteLine("=============================");
            demonstrateTypes();
            arrayHandling();


            //inputHandling();
            parseToInt();
            unboxing();
            //persistentAssignment();
            multiDimensionalArrays();
            searchInArray();
            distinctArray();
        }

        private void distinctArray()
        {
            Console.WriteLine("\n\nDistinct Element Array.");
            int[] nums = {1, 2, 1, 2, 1, 1, 1, 2, 2, 1};
            Console.WriteLine(String.Join(", ", nums.Distinct()));
        }

        private void searchInArray()
        {
            Console.WriteLine("\n\nSearching, Counting, Printing and Merging Arrays.");
            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            var stringToFind = "Bill";

            // Note. Returns the first Element alone.
            //element == stringToFind can be replaced with any condition.
            var result = Array.Find(names, element => element == stringToFind);

            string[] results = Array.FindAll(names, element => element.StartsWith("B"));
            string[] resultsWithS = Array.FindAll(names, el => el.StartsWith("S"));

            Console.WriteLine(result);
            Console.WriteLine(String.Join(", ", results));
            Console.WriteLine("Array length: " + results.Count());
            Console.WriteLine("Words with B and S: " + String.Join(", ", results.Union(resultsWithS)));


        }

        private void multiDimensionalArrays()
        {
            Console.WriteLine("\n\nMultidimensional Arrays.");
            int[,] matrix = new int[2, 3];
            Console.WriteLine(matrix);
        }

        private void persistentAssignment()
        {
            Console.WriteLine("\n\nCatching errors in type casting.");
            while (true)
            {
                Console.Write("Enter 'y': ");
                string input = Console.ReadLine();
                try
                {
                    Console.WriteLine(assign(Convert.ToInt32(input)));
                    break;
                }
                catch
                {
                    Console.WriteLine("Give a integer");
                }

            }
        }

        private int assign(int x)
        {
            return (int)((x * x) + (2 * x) + 1);
        }

        private void unboxing()
        {
            Console.WriteLine("\n\nUnboxing an Object.");

            Object obj = 30;
            int i = (int)obj;
            Console.WriteLine(i);
        }

        private void parseToInt()
        {
            Console.WriteLine("\n\nParsing to int.");
            string val = null;
            int result;
            bool ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);
            Console.WriteLine(result);

            val = "100.11";
            ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);
            Console.WriteLine(result);

            val = "999999999999999999999";
            ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);
            Console.WriteLine(result);

            val = "231";
            ifSuccess = int.TryParse(val, out result);
            Console.WriteLine(ifSuccess);
            Console.WriteLine(result);

        }

        private void inputHandling()
        {
            Console.WriteLine("\n\nInput Data.");

            Console.WriteLine("Enter a number.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} + {b}: " + (a + b));
        }

        private void arrayHandling()
        {
            Console.WriteLine("\n\nArray Manipulation. Retrieving with LINQ.");
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var queryResult = from num in nums where num % 2 == 0 select num;

            foreach(var num in queryResult)
            {
                Console.Write(num + " ");
            }
        }

        private static void demonstrateTypes()
        {
            Console.WriteLine("\n\nDemonstrate types.");

            Console.WriteLine("Implicit Data Casting.");
            byte b1 = 45;
            int a1 = b1;

            Object obj = new Object();
            Car car = new Car();
            obj = car;
            Console.WriteLine(typeof(Car));
            Console.WriteLine($"car is Car: {car is Car}");


            dynamic a = 32;
            Console.WriteLine(a);
            a = "23";
            Console.WriteLine(a);
            a = true;
            Console.WriteLine(a);
            a = 252.23m;
            Console.WriteLine(a);


            var b = 20;
            Console.WriteLine(b);
            //b = "23";  // Cannot cast string to int.
            //Console.WriteLine(b);
        }
    }
}
