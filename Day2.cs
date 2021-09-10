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
            demonstrateTypes();
            arrayHandling();
            inputHandling();
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
