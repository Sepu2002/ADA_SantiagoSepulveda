using System;

namespace E_EcuacionCuad
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, resun, resdos, dis;
            Console.WriteLine("Programa que resuelve ecuación cuadrática");

            Console.WriteLine("Escribe el término cuadrático:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = " + a);

            Console.WriteLine("Escribe el término lineal:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = " + b);

            Console.WriteLine("Escribe el término independiente:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a = " + c);

            dis = (b * b) - (4 * a * c);

            if (dis > 0) {
                resun = ((b * -1) + Math.Sqrt(dis)) / (2 * a);
                resdos = ((b * -1) - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("Los resultados de esta ecuación para x son: ");
                Console.WriteLine("x1: " + resun);
                Console.WriteLine("x2: " + resdos);
            }
            if (dis == 0) {
                resun = ((b * -1) / (2 * a));
                Console.WriteLine("La única resolución de la ecuación para x es: ");
                Console.WriteLine("x: " + resun);
            }
            if (dis < 0) {
                Console.WriteLine("Esta ecuación no tiene resultado en los reales ");
            }

            Console.WriteLine("BBBBBBBBBBBBBBBBBBBBBBBBBBB");
            Console.WriteLine("BMB---------------------B B");
            Console.WriteLine("BBB---------------------BBB");
            Console.WriteLine("BBB---------------------BBB");
            Console.WriteLine("BBB---------------------BBB");
            Console.WriteLine("BBB---------------------BBB");
            Console.WriteLine("BBBBBBBBBBBBBBBBBBBBBBBBBBB");
            Console.WriteLine("BBBBB++++++++++++++++BBBBBB");
            Console.WriteLine("BBBBB++BBBBB+++++++++BBBBBB");
            Console.WriteLine("BBBBB++BBBBB+++++++++BBBBBB");
            Console.WriteLine("BBBBB++BBBBB+++++++++BBBBBB");
            Console.WriteLine("BBBBB++++++++++++++++BBBBBB");
            



        }
    }
}
