using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- FizzBuzz Exercise with C# -----\n");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    Console.WriteLine("Fizzbuzz");
                if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                Console.WriteLine(i);
            }
            Console.Write("\nPress ENTER to exit: ");
            Console.ReadLine();
        }
    }
}
