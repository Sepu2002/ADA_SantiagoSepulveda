using System;

namespace Ejercicioprueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Programa que imprime pirámida de 1s");
            Console.WriteLine("Escribe número de niveles");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= x; i++) {
                for (int j = 1; j <= (x - i); j++) 
                    Console.Write(" ");

                for (int t = 1; t < i * 2; t++) 
                    Console.Write("1");
                Console.WriteLine();
    
            }

        }
    }
}
