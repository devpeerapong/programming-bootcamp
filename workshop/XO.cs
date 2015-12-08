using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[3,3];
            for (int row = 0; row < 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    table[row, column] = "-";
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write("{0}  ", table[row, column]);
                }
                Console.WriteLine();
            }

            for (int round = 0; round < 9; round++)
            {
                string turn = "X";
                Console.WriteLine("Turn {0} ", turn);
                Console.Write("Enter X: ");
                string inputX = Console.ReadLine();
                int x = Int32.Parse(inputX);
                Console.Write("Enter Y: ");
                string inputY = Console.ReadLine();
                int y = Int32.Parse(inputY);

                table[x - 1, y - 1] = turn;

                Console.Clear();

                for (int row = 0; row < 3; row++)
                {
                    for (int column = 0; column < 3; column++)
                    {
                        Console.Write("{0}  ", table[row, column]);
                    }
                    Console.WriteLine();
                }
            }


            Console.ReadLine();


        }
    }
}
