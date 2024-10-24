using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise701
{
    internal class Vecter2D
    {        

        public void Add(Vecter2D v)
        {
            X += v.X; Y += v.Y;
        }
        public void Sub(Vecter2D v)
        {
            X -= v.X; Y -= v.Y;
        }
        public void Mul(double k)
        {
            X *= k; Y *= k;
        }
        public double DotProduct(Vecter2D v)
        {
            return X * v.X + Y * v.Y;
        }
        public double X
        {
            set; get;
        }
        public double Y
        {
            set; get;
        }
    }
}
