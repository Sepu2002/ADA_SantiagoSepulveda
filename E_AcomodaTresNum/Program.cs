using System;

namespace E_AcomodaTresNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, lo, med, hi;
            Console.WriteLine("Programa que acomoda 3 números en orden ascendente");

            Console.WriteLine("Escriba 1er numero:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a: " + a);

            Console.WriteLine("Escriba 2do numero:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: " + b);

            Console.WriteLine("Escriba 3er numero:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c: " + c);

            if (a > b)
            {
                med = a;
                lo = b;
            }
            else
            {
                med = b;
                lo = a;
            }
            if (med > c)
            {
                hi = med;
                if (lo > c)
                {
                    med = lo;
                    lo = c;
                }
                else
                {
                    med = c;
                }
            } 
            else hi = c;

            Console.WriteLine("Los números en orden ascendente son:");
            Console.WriteLine(lo + ", " + med + ", " + hi);

            Console.WriteLine("");

            Console.WriteLine("         ,MMM8&&&.");
            Console.WriteLine("    _...MMMMM88&&&&..._");
            Console.WriteLine(" .::'''MMMMM88&&&&&&'''::.");
            Console.WriteLine("::     MMMMM88&&&&&&     ::");
            Console.WriteLine("'::....MMMMM88&&&&&&....::'");
            Console.WriteLine("   `''''MMMMM88&&&&''''`");
            Console.WriteLine("         'MMM8&&&'");
        }
    }
}
