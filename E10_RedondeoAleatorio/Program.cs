using System;

namespace E10_RedondeoAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, ant, post;

            Random genRand = new Random();


            Console.WriteLine("Programa que Redondea un numero a las centenas más cercanas ");

            Console.Write("Ingresa el  numero entero:  ");
            num = Convert.ToInt32(genRand.Next(0, 9999)); ;
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
