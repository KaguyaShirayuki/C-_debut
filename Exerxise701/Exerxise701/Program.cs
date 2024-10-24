using Exercise701;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerxise701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vecter2D v1 = new Vecter2D();
            v1.X = 1.0; v1.Y = 1.0;
            Console.WriteLine("v1=({0},{1})", v1.X, v1.Y);
            Vecter2D v2 = new Vecter2D();
            v2.X = 1.0; v2.Y = -1.0;
            Console.WriteLine("v2=({0},{1})", v2.X, v2.Y);
            // v1 + v2
            v1.Add(v2);
            Console.WriteLine("v1=({0},{1})", v1.X, v1.Y);
            // v1 - v2
            v1.Sub(v2);
            Console.WriteLine("v1=({0},{1})", v1.X, v1.Y);
            // 2*v1
            v1.Mul(2.0);
            Console.WriteLine("v1=({0},{1})", v1.X, v1.Y);
            // v1, v2の内積
            Console.WriteLine("v1,v2の内積：{0}", v1.DotProduct(v2));
        }
    }
}
