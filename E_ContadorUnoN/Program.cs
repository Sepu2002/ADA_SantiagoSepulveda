using System;

namespace E_ContadorUnoN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            int sum, max, min;
            double prom, sumd, nd;
            max = 0;
            min = 99;
            sum = 0;
            prom = 0;

            Console.WriteLine("Programa que que escribe un rango de números y sus cuadrados: ");
            Console.WriteLine("Escriba número de iteraciones:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba cada número y presione <enter>:");
            Console.WriteLine("\t\t\t\t\t\t--------------------------");
            Console.WriteLine("\t\t\t\t\t\t|Paso | max | min | sum | ");
            Console.WriteLine("\t\t\t\t\t\t--------------------------");
            
            for (int count = 1; count <= n; count++) {
                
                num = Convert.ToInt32(Console.ReadLine());
                if (num < min) {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum = sum + num;
                Console.WriteLine("\t\t\t\t\t\t--------------------------");
                Console.WriteLine("\t\t\t\t\t\t |{0}  |  {1}  |  {2}  |  {3}| ", count, max, min, sum);
                Console.WriteLine("\t\t\t\t\t\t--------------------------");
            }

            sumd = Convert.ToDouble(sum);
            nd = Convert.ToDouble(n);
            prom = sumd / nd;
            Console.WriteLine("\t\t\t\t\t\tEl número mas pequeño es: {0}", min);
            Console.WriteLine("\t\t\t\t\t\tEl número mas grande es: {0}", max);
            Console.WriteLine("\t\t\t\t\t\tLa suma de los números es: {0}", sum);
            Console.WriteLine("\t\t\t\t\t\tEl promedio de los números es: {0}", prom);

            Console.WriteLine("         ,MMM8&&&.");
            Console.WriteLine("    _...MMMMM88&&&&..._");
            Console.WriteLine(" .::'''MMMMM88&&&&&&'''::.");
            Console.WriteLine("::     MMMMM88&&&&&&     ::");
            Console.WriteLine("'::....MMMMM88&&&&&&....::'");
            Console.WriteLine("   `''''MMMMM88&&&&''''`");
            Console.WriteLine("   SSL   'MMM8&&&'");
            Console.WriteLine("Santiago Sepúlveda Landeros");

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
// <>j