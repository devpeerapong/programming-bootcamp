using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Force (N): ");
            string inputForce = Console.ReadLine();
            double force = Double.Parse(inputForce);

            Console.Write("Enter Mass (kg): ");
            string inputMass = Console.ReadLine();
            double mass = Double.Parse(inputMass);

            double accel = force / mass;
            
            Console.WriteLine("Accel = " + accel);
            Console.ReadLine();


            Console.ReadLine();

        }
    }
}
