using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            /*List<int> list1 = new List<int>(); 
            List<int> list2 = new List<int>();

            Console.WriteLine("輸入一串以逗號分隔的整數數字字串 :");
            string input = Console.ReadLine(); 
            string[] str = input.Split(',');
            
            foreach (string i in str)          
            {
                if (int.Parse(i) % 2 == 0)
                {
                    list1.Add(int.Parse(i));
                }
                else
                {
                    list2.Add(int.Parse(i));
                }
            }

            list1.Sort();                      
            list2.Sort();   
            
            Console.Write($"偶數為:");          
            print(list1);                      
            Console.Write($"\n奇數為:");         
            print(list2);                      
            Console.ReadLine();
        }


        private static void print(List<int>list)
        {
            int count = 0;
            foreach(int i in list)
            {
                if(count != 0)
                {
                    Console.Write(" , ");
                }
                Console.Write(i);
                count++;
            }
        }*/

            var list1 = new List<int>();
            var list2 = new List<int>();
            Console.WriteLine("輸入:");
            string input = Console.ReadLine();
            string[] inputSplited = input.Split(',');

            for (int i = 0; i < inputSplited.Length; i++)
            {
                int number = Convert.ToInt32(inputSplited[i]);
                if (number % 2 == 0)
                {
                    list2.Add(number);
                }
                else
                {
                    list1.Add(number);
                }
            }
            list1.Sort();
            list2.Sort();

            Console.WriteLine("奇數:" + string.Join(",", list1));
            Console.WriteLine("偶數:" + string.Join(",", list2));
            Console.ReadLine();
        }
    }
}
