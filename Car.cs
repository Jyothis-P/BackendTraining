using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public Car()
        {

        }

        public string name { get; set; }
        public int seats { get; set; }
        public float distance { get; set; }
        public decimal mileage { get; set; }
        public bool used { get; set; }


        public void print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Seats: {seats}");
            Console.WriteLine($"Distance Travelled: {distance}");
            Console.WriteLine($"Mileage: {mileage}");
            Console.WriteLine($"Used?: {used}");
        }
    }

}
