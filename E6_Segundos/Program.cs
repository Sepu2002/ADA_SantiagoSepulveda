using System;

namespace E6_Segundos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, seg, min, hr, di;
            Console.WriteLine("Programa que pasa de segundos a minutos, horas, días y semanas");
            Console.WriteLine("Escribe los segundos a convertir:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num");

            di = num / 86400;
            hr = (num & 86400) / 3600;
            min = ((num & 86400) % 3600) / 60;
            seg = ((num & 86400) % 3600) % 60;

            Console.WriteLine("");
            Console.WriteLine(num+ "segundos equivaele a: ");
            Console.WriteLine(di + "días");
            Console.WriteLine(hr + "horas");
            Console.WriteLine(min + "minutos");
            Console.WriteLine(seg + "segundos");
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
