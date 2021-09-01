using System;

namespace E_AñoBisiesto_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que verifica si un año es bisiesto");

            Console.WriteLine("Escribe un año : ");

            int Year = Convert.ToInt32(Console.ReadLine());

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} es bisiesto.", Year);
            }
            else
            {
                Console.WriteLine("{0} no es bisiesto.", Year);
           
            }

            Console.WriteLine("                     .::.");
            Console.WriteLine("                  .:'  .:");
            Console.WriteLine("        ,MMM8&&&.:'   .:'");
            Console.WriteLine("       MMMMM88&&&&  .:'");
            Console.WriteLine("      MMMMM88&&&&&&:'");
            Console.WriteLine("      MMMMM88&&&&&&");
            Console.WriteLine("    .:MMMMM88&&&&&&");
            Console.WriteLine("  .:'  MMMMM88&&&&");
            Console.WriteLine(".:'   .:'MMM8&&&'");
            Console.WriteLine(":'  .:'");
            Console.WriteLine("'::' ");
           

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
