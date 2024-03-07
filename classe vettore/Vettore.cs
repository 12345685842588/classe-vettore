using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_vettore
{
    internal class Vettore
    {
        public readonly double X;
        public readonly double Y;

        public Vettore(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }

        public static Vettore operator /(Vettore v1, double s)
        {
            return new Vettore(v1.X / s, v1.Y / s);
        }

        public static Vettore operator *(Vettore v1, double s)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }

        public static Vettore operator *(double s, Vettore v1)
        {
            return new Vettore(s * v1.X, s * v1.Y);
        }

        public static Vettore operator +(Vettore v)
        {
            return new Vettore(+v.X, +v.Y);
        }

        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.X, -v.Y);
        }

        public double Modulo(Vettore v)
        {
            /* ha detto di non prendere in input valori*/
            double m;
            m = Math.Sqrt(v.X * v.X + v.Y * v.Y);
            return m;
        }

        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }

        public static Vettore Parse(string s)
        {
            string[] parts = s.Split(';');
            double x = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            Vettore v = new Vettore(x, y);
            return v;
        }
        public static bool TryParse(string s, out Vettore v)
        {
            try
            {
                v = Vettore.Parse(s);
                return true;
            }
            catch
            {
                v = null;
                return false;
            }
        }

         public static bool operator ==(Vettore v1, Vettore v2)
         {
            if (object.ReferenceEquals(v1, null))
                return ReferenceEquals(v2, null);
            else if (object.ReferenceEquals(v2, null))
                return false;
            else return v1.X == v2.X && v1.Y == v2.Y;

        }

         public static bool operator !=(Vettore v1, Vettore v2)
         {
             return !(v1 == v2);
         }
        
    }
}
