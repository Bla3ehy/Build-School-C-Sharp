using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Assingment01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字 :");
            string i = Console.ReadLine();
            int value = int.Parse(i);
            if (value % 2 == 0)
            {
                Console.WriteLine("這是一個偶數");
            }
            else
                Console.WriteLine("這是一個奇數");

        }



    }
}
