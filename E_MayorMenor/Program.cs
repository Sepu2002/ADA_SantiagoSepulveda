using System;

namespace E_MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            double numone, numtwo;
            Console.WriteLine("Programa que checa si un numero es moyor menos o igual a otro: ");

            Console.WriteLine("Escribe el 1er número: ");
            numone = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el 2o número: ");
            numtwo = Convert.ToDouble(Console.ReadLine());

            if (numone > numtwo) {
                Console.WriteLine(numone + " es mayor que " + numtwo);
            }

            if (numone == numtwo)
            {
                Console.WriteLine(numone + " es igual a " + numtwo);
            }

            else
            {
                Console.WriteLine(numtwo + " es mayor que " + numone);
            }

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
