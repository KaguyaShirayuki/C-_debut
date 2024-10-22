using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            
            if(s1 == "Hello" && s2 == "World"){
                Console.WriteLine("Good");
            }else{
                Console.WriteLine("Hello World please!");
            }
        }
    }
}
