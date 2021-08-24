using System;

namespace E10_RedondeoAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int num, ant, post;

            //Empezar generador de numeros aleatorios
            Random genRand = new Random();

            
            Console.WriteLine("Programa que Redondea un numero a las centenas más cercanas ");

            //Generar número a redondear
            Console.Write("Ingresa el  numero entero:  ");
            num = Convert.ToInt32(genRand.Next(0, 9999)); ;
            Console.WriteLine("Numero : " + num);

            //Calcular centenas anterior y posterior
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
