using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            int number;
            bool parseSuccessful = int.TryParse(
               Console.ReadLine(), out number);

            while (!(parseSuccessful && number % 2 == 0))
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter even number: ");
                parseSuccessful = int.TryParse(
                    Console.ReadLine(), out number);
            }

            Console.WriteLine("Even number entered: {0}",
                number);
        }
    }
}