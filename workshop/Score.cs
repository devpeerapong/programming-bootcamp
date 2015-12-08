using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace score
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"paiboon", "nan", "panya", "tonnarak", "sukkarin"};

            int[] scores = { 1, 2, 3, 4 ,5};

            for (int position = 0; position < names.Length; position++ )
            {
                Console.WriteLine("Name: {0} Calculus Score: {1}", names[position], scores[position]);
            }

            int sum = 0;
            for (int position = 0; position < names.Length; position++)
            {
                //sum = sum + scores[position]
                sum += scores[position];
            }
            Console.WriteLine("Sum score: {0}", sum);
            Console.WriteLine("Avg score: {0}", scores.Average());
            Console.WriteLine("Max score: {0}", scores.Max());
            Console.WriteLine("Mix score: {0}", scores.Min());
            Console.WriteLine("Sum score: {0}", scores.Sum());

            Console.ReadLine();
        }
    }
}
