using System;

namespace E2_CocienteResiduo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, coci, res;
            Console.WriteLine("Programa que divide 2 números y enseña residuo");
            Console.WriteLine("Escriba el 1er número: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primer número: " + x);
            Console.WriteLine("Escriba el 2o número: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo número: " + y);

            coci = x / y;
            res = x % y;

            Console.WriteLine(x + "/" + y + " = " + coci + " con un residuo de " + res);




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
