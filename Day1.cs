using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Day1
    {

        public Day1()
        {
            Console.WriteLine("\n\n\nDay1");
            Console.WriteLine("=============================");
            demonstrateIfElse();
            demonstrateSwitchCase();
            printPattern(20);
            workWithClass();
        }


        private static void workWithClass()
        {
            Console.WriteLine("\n\nWorking with Classes.");

            Car car = new Car();

            car.name = "Duster";
            car.mileage = 12.3m;
            car.seats = 5;
            car.used = false;
            car.distance = 2342.2f;

            car.print();
        }

        private static void demonstrateSwitchCase()
        {
            Console.WriteLine("\n\nSwitch Case.");
            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("x = 1");
                    break;
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("x = 4 or x = 5");
                    break;
                default:
                    Console.WriteLine("x > 5");
                    break;
            }
        }

        private static void demonstrateIfElse()
        {
            Console.WriteLine("\n\nIf-Else.");
            int i = 20, j = 20;

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }
            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }
            else
            {
                Console.WriteLine("i is equal to j");
            }
        }

        private static void printPattern(int v)
        {
            Console.WriteLine("\n\nPattern Printing.");
            for (int i = v; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
