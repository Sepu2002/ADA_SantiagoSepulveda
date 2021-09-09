using System;

namespace E_AdivinaNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int tri, randnum, inp, max ,level;
            inp = 0;
            tri = 0;
            max = 1;

            Console.WriteLine("Escriba el nivel de dificultad");
            Console.WriteLine("Nivel Básico (1): 1-50");
            Console.WriteLine("Nivel Medio (2): 1-500");
            Console.WriteLine("Nivel Avanzado (3): 1-999");
            level = Convert.ToInt32(Console.ReadLine());
            Random genAleatorio = new Random();
            switch(level)
            {
               case 1:
                    max = 50;
                    break;
               case 2:
                    max = 100;
                    break;
               case 3:
                    max = 999;
                    break;
            }

            randnum = genAleatorio.Next(1, max);
            while (true)
            {
                Console.WriteLine("Juego para que usuario adivine un número de 1 a {0}", max);
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
