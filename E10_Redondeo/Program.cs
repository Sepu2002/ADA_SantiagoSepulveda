using System;

namespace E10_Redondeo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int num, ant, post;

            Console.WriteLine("Programa que Redondea un numero a las centenas más cercanas ");

            //Pedir número a redondear
            Console.Write("Ingresa el  numero entero:  ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero : " + num);

            //Obtener centena anterior y posterior
            ant = num - (num % 100);
            post = num - num % 100 + 100;

            //Imprimir resultados
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

            //Espera
            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();

        }
    }
}
