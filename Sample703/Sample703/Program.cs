using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person2 p = new Person2();
            p.SetAgeAndName("上田麗奈", 30);
            // p.Name = "伊藤健太郎";
            p.Age = 22;
            Console.WriteLine("名前：{0} 年齢：{1}", p.Name, p.Age);
        }
    }
}
