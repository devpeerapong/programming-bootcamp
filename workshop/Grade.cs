using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score");
            string inputScore = Console.ReadLine();
            int score = Int32.Parse(inputScore);

            //ถ้าคะแนนมากกว่า 80 เกรด A
            if (score > 80)
            {
                Console.WriteLine("Your grade is A.");
            }
            //ถ้าคะแนนมากกว่า 40 ผ่าน  "You Pass"
            else if (score > 40)
            {
                Console.WriteLine("You PASS");
            }
            //ถ้าคะแนนน้อยกว่า 40 ตก  "You Fail"
            else
            {
                Console.WriteLine("You Fail");
            }
        }
    }
}
