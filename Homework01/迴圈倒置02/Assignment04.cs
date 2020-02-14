using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04
{
    class Assignment04
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int row, col;

            for (row = num; row >= 1; row--)
            {
                for (col = num; col >= row; col--)
                {
                    Console.Write(row);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

