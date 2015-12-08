using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTS
{
    class Program
    {
        static void Main(string[] args)
        {            
            // รับค่าสถานี
            // 1. แสดงบอกผู้ใช้ให้ใส่สถานี
            Console.WriteLine("Please select your destination: ");
            Console.WriteLine("1. Asok");
            Console.WriteLine("2. Siam");
            // 2. รับค่าสถานีจากผู้ใช้
            string station = "";
            string stationNumber = Console.ReadLine();
            int price = 0;

            // เช็คราคาสถานีว่าราคาเท่าไหร่
            // เช็คความเท่ากันใช้ ==
            // ถ้าผู้ใช้ ใส่เลข 1 สถานีจะเท่ากับ Asok
            // 1 == 1 -> true
            // 1 != 1 -> false
            if (stationNumber == "1") 
            {
                station = "Asok";
                // ถ้าไป Asok ให้แสดงราคา 2,000 บาท
                price = 2000;
            }
            // ถ้าผู้ใช้ ใส่เลข 2 สถานีจะเท่ากับ Siam
            if (stationNumber == "2")
            {
                station = "Siam";
                // ถ้าไป Siam ให้แสดงราคา 42 บาท
                price = 42;
            }
            // เช็คความไม่เทากันใช้ !=
            // ถ้าใส่นอกเหนือจาก 1, 2 ให้แสดงว่า Do not have destination
            if (stationNumber != "1" && stationNumber != "2")
            {
                Console.WriteLine("Do not have station");
            }
            else
            {
                // 3. แสดงบอกว่าผู้ใช้ต้องการไปไหน
                Console.WriteLine("You are going to {0}", station);
                // แสดงราคาออกมา
                Console.WriteLine("Price: {0}", price);
            }

            // รับค่าเงินที่หยอด
            string inputMoney = Console.ReadLine();
            int money = Int32.Parse(inputMoney);

            // เช็คว่าเงินที่หยอด ขาด หรือ พอดี หรือ เกิน
            // ถ้าหยอดเงินไม่พอ ให้แสดงค่าเงินที่ขาด
            if (money < price) 
            {
                int debt = price - money;
                Console.WriteLine("Money not enough. Please enter {0} more", debt);
            }
            
            if (money == price)
            {
                Console.WriteLine("Here is your ticket. Good luck.");
            }

            if (money > price)
            {
                int debt = money - price;
                Console.WriteLine("Here is your change, {0} Baht", debt);
                Console.WriteLine("Here is your ticket. Good luck.");
            }
            // ถ้าหยอดพอดี ให้จ่ายบัตรออกมา
            // ถ้าหยอดเกิน ทอนเงิน บัตร

            Console.ReadLine();
        }
    }
}
