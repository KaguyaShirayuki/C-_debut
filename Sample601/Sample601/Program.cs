using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;
            p1 = new Person();
            p2 = new Person();
            p1.name = "伊藤健太郎";
            p1.age = 50;
            p2.SetAgeAndName("上田麗奈", 30);

            p1.ShowAgeAndName();
            p2.ShowAgeAndName();

        }
    }
}
