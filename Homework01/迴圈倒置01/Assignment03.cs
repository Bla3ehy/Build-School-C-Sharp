using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03
{
    class Assignment03
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("請輸入一串以逗號分隔的整數數字字串:");
            string a = Console.ReadLine();
            char[] c = a.ToCharArray();
            Array.Reverse(c);

            foreach (var item in c)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }    
    }
}
