using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test05
{
    class Assignment05
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("請輸入一個中華民國年份:");
            string a = Console.ReadLine();
            bool b = DateTime.IsLeapYear(int.Parse(a)+1911);

            if (b == true)
            {
                Console.WriteLine("閏年");
            }
            else
            {
                Console.WriteLine("平年");
            }
            Console.ReadLine();
        }
    }
}
