using System;

namespace E_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i ;
            long fact, sum;
            fact = 1;
            sum = 0;
            Console.WriteLine("Programa que obtiene el factorial de un número");
            Console.WriteLine("Escribe un número:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("| 0 Factorial es 1 |");
                Console.WriteLine("| La sumatoria es 0|");
            }
            else {
                for (i = 1; i <= n; i++)
                {
                    fact = fact * i;
                    sum = sum + i;
                }
                Console.WriteLine("| {0} Factorial es: {1} |", n, fact);
                Console.WriteLine("| La sumatoria de 0 hasta {0} es {1} |", n, sum);
            }

            Console.WriteLine("           ____");
            Console.WriteLine("         o8%8888,");
            Console.WriteLine("       o88%8888888.");
            Console.WriteLine("      8'-    -:8888b ");
            Console.WriteLine("     8'         8888");
            Console.WriteLine("    d8.-=. ,==-.:888b");
            Console.WriteLine("    >8 `~` :`~' d8888");
            Console.WriteLine("    88         ,88888");
            Console.WriteLine("    88b. `-~  ':88888");
            Console.WriteLine("    888b ~==~ .:88888 ");
            Console.WriteLine("    88888o--:':::8888");
            Console.WriteLine("    `88888| :::' 8888b");
            Console.WriteLine("    8888^^'       8888b");
            Console.WriteLine("   d888           ,%888b.");
            Console.WriteLine("  d88%            %%%8--'-.");
            Console.WriteLine(" /88:.__ ,       _%-' ---  -");
            Console.WriteLine("     '''::===..-'   =  --.  `");
            Console.WriteLine("    Santiago Sepúlveda");

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
