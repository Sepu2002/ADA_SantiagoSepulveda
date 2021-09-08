using System;

namespace E_AdivinaNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int tri, randnum, inp;
            inp = 0;
            tri = 0;
            Random genAleatorio = new Random();
            randnum = genAleatorio.Next(1, 999);
            

            while (true)
            {
                Console.WriteLine("Juego para que usuario adivine un número del 0 al 999");
                Console.WriteLine("Escriba el número que crea que es");
                inp = Convert.ToInt32(Console.ReadLine());
                if (inp > randnum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Es menos que eso");
                    tri = tri + 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine(" ..;;;;;..");
                    Console.WriteLine("  ':::::'");
                    Console.WriteLine("    ':`");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("oprima <enter> ");
                    string espera = Console.ReadLine();
                    Console.Clear();
                }
                if (inp < randnum) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Es más que eso");
                    tri = tri + 1;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("     .");
                    Console.WriteLine("   .:;:.");
                    Console.WriteLine(" .:;;;;;:.");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.WriteLine("   ;;;;;");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("oprima <enter> ");
                    string espera = Console.ReadLine();
                    Console.Clear();
                }
                if (inp == randnum) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Eso es correcto!");
                    Console.WriteLine("Lo lograste en {0} intentos", tri);
                    Console.WriteLine("     _______________");
                    Console.WriteLine("    |@@@@|     |####|");
                    Console.WriteLine("    |@@@@|     |####|");
                    Console.WriteLine("    |@@@@|     |####|");
                    Console.WriteLine("    ;@@@@|     |####;");
                    Console.WriteLine("     ;@@@|     |###;");
                    Console.WriteLine("      `@@|_____|##'");
                    Console.WriteLine("           (O)");
                    Console.WriteLine("        .-'''''-.");
                    Console.WriteLine("      .'  * * *  `.");
                    Console.WriteLine("     :  *       *  :");
                    Console.WriteLine("    : ~  G R A N  ~ :");
                    Console.WriteLine("    : ~  TRABAJO  ~ :");
                    Console.WriteLine("     :  *       *  :");
                    Console.WriteLine("      `.  * * *  .'");
                    Console.WriteLine("        `-.....-'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("oprima <enter> ");
                    string espera = Console.ReadLine();
                    break;
                }
            }
        }
    }
}//<>
