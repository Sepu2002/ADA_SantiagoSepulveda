using System;

namespace E4_AreaCuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, area, per;
            Console.WriteLine("Programa que calcula la superficie y el perímetro de un cuarto: ");
            Console.WriteLine("Escriba la longitud del cuarto: ");

            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Longitud: " + x);

            Console.WriteLine("Escriba la anchura del cuarto: ");

            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Anchura: " + y);

            area = x * y;
            per = (2 * x) + (2 * y);

            Console.WriteLine();
            Console.WriteLine("Perímetro: " + per);
            Console.WriteLine("Superficie: " + area);

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
