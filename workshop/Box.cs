using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 3; column++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
