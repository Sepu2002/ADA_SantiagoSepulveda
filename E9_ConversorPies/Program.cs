using System;

namespace E9_ConversorPies
{
    class Program
    {
        static void Main(string[] args)
        {
            double ft, yd, inc, cm, m;
            Console.WriteLine("Programa que convierte pies a yardas, pulgadas, centímetros y metros:");

            Console.WriteLine("Escribe la medida en pies:");
            ft = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(ft + " pies");

            yd = ft / 3;
            inc = ft * 12;
            cm = inc * 2.54;
            m = cm / 100;

            Console.WriteLine(yd + " yardas");
            Console.WriteLine(inc + " pulgadas");
            Console.WriteLine(cm + " centímetros");
            Console.WriteLine(m + " metros");

            Console.WriteLine("");

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
