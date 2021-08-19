using System;

namespace E10_Redondeo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ant, post;

            Console.WriteLine("Programa que Redondea un numero a las centenas más cercanas ");

            Console.Write("Ingresa el  numero entero:  ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero : " + num);

            ant = num - (num % 100);
            post = num - num % 100 + 100;

            Console.WriteLine("Centena Anterior  = " + ant);
            Console.WriteLine("Centena Siguiente = " + post);

            Console.WriteLine("                    *****************");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("        ****                                 ***");
            Console.WriteLine("      ***                                       ***");
            Console.WriteLine("     **           ***               ***           **");
            Console.WriteLine("   **           *******           *******          ***");
            Console.WriteLine("  **            *******           *******            **");
            Console.WriteLine(" **             *******           *******             **");
            Console.WriteLine(" **               ***               ***               **");
            Console.WriteLine("**                                                     **");
            Console.WriteLine("**       *                                     *       **");
            Console.WriteLine("**      **                                     **      **");
            Console.WriteLine(" **   ****                                     ****   **");
            Console.WriteLine(" **      **                                   **      **");
            Console.WriteLine(" **       ***                             ***       **");
            Console.WriteLine("  ***       ****                       ****       ***");
            Console.WriteLine("    **         ******             ******         **");
            Console.WriteLine("     ***            ***************            ***");
            Console.WriteLine("        ****                                 ****");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("                    *****************");

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();

        }
    }
}
