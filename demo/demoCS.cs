using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of multiplication table: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number > 12 || number < 1)
            {
                Console.WriteLine("The number must be between 1 - 12");
            }
            else
            {
                for (int i = 1; i < 13; i++)
                {
                    int result = number * i;
                    Console.WriteLine("{0} x {1} = {2}", number, i, result);
                }
            }

            Console.ReadLine();
        }
    }
}
