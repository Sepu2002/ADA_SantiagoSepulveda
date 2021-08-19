using System;

namespace E7_PeriAreaRec2x
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, per, area;
            Console.WriteLine("Programa que calcula perímetro y área de un rectangulo cuya longitud es el doble de su anchura");
            Console.WriteLine("Escriba la longitud del rectángulo en pies:");
            x = Convert.ToDouble(Console.ReadLine());
            y = x / 2;
            Console.WriteLine("Longitud: " + x + " pies");
            Console.WriteLine("Anchura: " + y + " pies");
            Console.WriteLine("");

            per = 3 * x ;
            area = x * (x / 2);

            Console.WriteLine("El perímetro es de: " + per + " pies");
            Console.WriteLine("El área es de: " + area + " pies");

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
