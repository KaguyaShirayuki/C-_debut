using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力： ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
