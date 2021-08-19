using System;

namespace E8_CircCuad
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, percu, arcu, perci, arci, dif;
            Console.WriteLine("Programa para calcular círculo con radio x y cuadrado con lado x ");

            Console.WriteLine("Escribe el valor de x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X= " + x);

            percu = 4 * x;
            arcu = x * x;
            perci = Math.PI * 2 * x;
            arci = Math.PI * x * x;
            dif = arci - arcu;
            Console.WriteLine("");
            Console.WriteLine("Longitud de la circunferencia= " + perci);
            Console.WriteLine("Área del círculo= " + arci);
            Console.WriteLine("Perímetro del cuadrado= " + percu);
            Console.WriteLine("Área del cuadrado= " + arcu);
            Console.WriteLine("Diferencia entre áreas= " + dif);
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
