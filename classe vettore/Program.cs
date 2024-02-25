using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_vettore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vettore v1 = new Vettore(-2, 3);
            Vettore v2 = new Vettore(5, 1);
            double s = 2;

            Console.WriteLine("v1+v2={0}", v1 + v2);
            Console.WriteLine("v1-v2={0}", v1 - v2);
            Console.WriteLine("v1*v2={0}", v1 * v2);
            Console.WriteLine("v1*s={0}", v1 * s);
            Console.WriteLine("s*v1={0}", s * v1);
            Console.WriteLine("v1/s={0}", v1 / s);
            Console.WriteLine("-v={0}", -v1);
            Console.WriteLine("+v={0}", +v1);

            Console.ReadLine();
        }
    }
}
