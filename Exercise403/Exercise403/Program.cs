using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1．2つの1～10の整数の乱数を発生させ、整数型変数a,bに代入
            Random rnd = new Random();
            int a = rnd.Next(1, 11);
            int b = rnd.Next(1, 11);
           
            // 2. a= ●, b= × といった具合にa,bの値を表示（例：a=2, b=4）
            Console.WriteLine("a = {0} b = {1}", a, b);

            // 3. a+b= と表示しその後整数値をコンソールから入力させる
            while (true)
            {
                Console.Write("a + b = ");
                int ans = int.Parse(Console.ReadLine());

                // 4. 入力した値がa,bの和に等しければ正解と表示しプログラム修了
                if (ans == a + b)
                {
                    Console.WriteLine("正解");
                    break;
                }
                else
                {   // 5. 正しくなければまちがいと表示し3に戻る
                    Console.WriteLine("間違い");
                }
            }
        }
    }
}
