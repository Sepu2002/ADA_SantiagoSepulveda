using System;
using System.Threading;
using System.Threading.Tasks;

namespace E_SmileReloadedFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int  endgame;
            endgame = 0;
            string start = "Inicio       ";
            int x = 2, y = 2;
            Splash();
            Console.Write("Smile");
            Show(x,y,start);
            do Control(ref x, ref y, ref endgame, ref start);
            while (endgame==0);
        }
        public static void Show(int numx, int numy, string dir)
        {
            char smile = '☻';
            Console.SetCursorPosition(0, 0);
            Box();
            Console.SetCursorPosition(numx, numy);
            Console.Write(smile);
            Console.SetCursorPosition(50, 17);
            Console.Write("{0}, {1}", numx, numy);
            Console.SetCursorPosition(50, 5);
            Console.Write(dir);
            

        }

        public static void Box() {
            Console.SetCursorPosition(0, 0);
            Console.Write("|-----------------------------------------|\n");
            for (int i = 1; i < 19; i++) {
                Console.SetCursorPosition(0,i);
                Console.Write("|");
                Console.SetCursorPosition(42, i);
                Console.Write("|");
            }
            Console.WriteLine("\n|-----------------------------------------|");
        }

        public static void Control(ref int x, ref int y, ref int endgame, ref string start)
        {
            int randir;
            string  derecha = "Derecha      ", izquierda = "Izquierda      ", abajo = "Abajo     ", arriba = "Arriba      ", aleatorio = "Aleatorio     ";
            ConsoleKeyInfo tecla;
            int max_ancho = 40; int max_alto = 17;
            tecla = Console.ReadKey(false);
            switch (tecla.Key)
            {
                case ConsoleKey.RightArrow:
                    if (x <= max_ancho)
                    {
                        Console.Clear();
                        x++;

                        Show(x, y, derecha);
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (x > 1)
                    {
                        Console.Clear();
                        x--;

                        Show(x, y, izquierda);

                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (y <= max_alto)
                    {
                        Console.Clear();
                        y++;

                        Show(x, y, abajo);

                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (y > 1)
                    {
                        Console.Clear();
                        y--;

                        Show(x, y, arriba);

                    }
                    break;

                case ConsoleKey.Tab:
                    Console.Clear();
                    Random genAleatoriox = new Random();
                    x = genAleatoriox.Next(2, 39);
                    y = genAleatoriox.Next(2, 16);
                    Show(x, y, aleatorio);
                    break;

                case ConsoleKey.Escape:
                    Random genAleatoriod = new Random();
                    randir = genAleatoriod.Next(0, 5);

                    switch (randir)
                    {
                        case 1:
                            if (x <= max_ancho)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                x++;
                                Show(x, y, derecha);
                                Task.Delay(300);
                            }
                            break;
                        case 2:
                            if (x > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                x--;
                                Show(x, y, izquierda);
                                Task.Delay(300);
                            }
                            break;
                        case 3:
                            if (y <= max_alto)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                y++;
                                Show(x, y, abajo);
                                Task.Delay(300);
                            }
                            break;
                        case 4:
                            if (y > 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                y--;
                                Show(x, y, arriba);
                                Task.Delay(300);
                            }
                            break;
                    }
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Show(x, y, start);
                    break;

                case ConsoleKey.F:
                    Console.Clear();
                    endgame++;
                    break;
            }

        }

        public static void Splash() {

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

            Console.WriteLine("Bienvenido, oprima <enter> ");

            string espera = Console.ReadLine();
            Console.Clear();

        }
        
    }
}
