using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulpilier
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            //
            for (int number = 2; number < 13; number++ )
            {
                for (int multiplier = 1; multiplier < 13; multiplier++)
                {
                    result = number * multiplier;
                    Console.WriteLine("{0} x {1} = {2}", number, multiplier, result);
                }
            }
            
            Console.ReadLine();
        }
    }
}
