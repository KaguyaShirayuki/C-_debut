using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // dobule型の変数tempを宣言し、キーボードから数値を入力させなさい。
            Console.Write("整数値を入力: ");
            double temp = double.Parse(Console.ReadLine());
            // tempの値を表示しなさい。
            Console.WriteLine(temp);
            // tempが0.0ならゼロと表示しなさい。
            if (temp == 0.0){ Console.WriteLine("ゼロ"); } 
            // tempが負の数ならマイナスと表示しなさい。
            else if (temp > 0.0){ Console.WriteLine("プラス"); }  
            // tempが正の値ならプラスと表示しなさい。
            else{ Console.WriteLine("マイナス");}
        }
    }
}
