﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D();
            v1.x = 1.0; v1.y = 1.0;
            Console.WriteLine("v1=({0},{1})", v1.x, v1.y);
            Vector2D v2 = new Vector2D();
            v2.x = 1.0; v2.y = -1.0;
            Console.WriteLine("v2=({0},{1})", v2.x, v2.y);
            // v1 + v2
            v1.Add(v2);
            Console.WriteLine("v1=({0},{1})", v1.x, v1.y);
            // v1 - v2
            v1.Sub(v2);
            Console.WriteLine("v1=({0},{1})", v1.x, v1.y);
            // 2*v1
            v1.Mul(2.0);
            Console.WriteLine("v1=({0},{1})", v1.x, v1.y);
            // v1, v2の内積
            Console.WriteLine("v1,v2の内積：{0}", v1.DotProduct(v2));
        }
    }
}
