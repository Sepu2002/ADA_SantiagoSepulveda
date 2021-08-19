using System;

namespace E3_CelFah
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Programa que covierte de grados Celcius a Fahrenheit ");
            Console.WriteLine("Escriba la temperatura en grados C°: ");

            c = Convert.ToDouble(Console.ReadLine());


            f = (9 / 5) * c + 32;

            Console.WriteLine("La temperatura " + c + " C° en Fahrenheit es de: " + f + " F°");

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
