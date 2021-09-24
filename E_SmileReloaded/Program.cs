using System;
using System.Threading;
using System.Threading.Tasks;

namespace E_SmileReloaded
{
    class Program
    {
        static void Main(string[] args)
        {
            int randx, randy, randir;
            
            // Leer teclas
            ConsoleKeyInfo tecla;
            char smile = '☻';
            int max_ancho = 40; int max_alto = 17;
            Console.SetCursorPosition(1, 1);
            Console.Write("Smile");
            int x = 2;
            int y = 2;
            Console.SetCursorPosition(x, y);

            Console.Write(smile);

            do
            {
                
                tecla = Console.ReadKey(false);
                switch (tecla.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (x <= max_ancho)
                        {
                            Console.Clear();
                            x++;
                            
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(60, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(60, 5);
                            Console.Write("Derecha →");
                            Console.SetCursorPosition(x, y);
                        }
                        break;



                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                        {
                            Console.Clear();
                            x--;
                            
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(60, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(60, 5);
                            Console.Write("Izquierda ←");
                            Console.SetCursorPosition(x, y);

                        }
                        break;


                    case ConsoleKey.DownArrow:
                        if (y <= max_alto)
                        {
                            Console.Clear();
                            y++;
                            
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(60, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(60, 5);
                            Console.Write("Abajo ↓");
                            Console.SetCursorPosition(x, y);

                        }
                        break;


                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            Console.Clear();
                            y--;
                            
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(60, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(60, 5);
                            Console.Write("Arriba ↑");
                            Console.SetCursorPosition(x, y);

                        }
                        break;
                    case ConsoleKey.Tab:
                        Console.Clear();
                        Random genAleatoriox = new Random();
                        Random genAleatorioy = new Random();

                        randx = genAleatoriox.Next(2, 39);
                        randy = genAleatorioy.Next(2, 16);
                        x = randx;
                        y = randy;
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        Console.SetCursorPosition(60, 27);
                        Console.Write(x + "," + y);
                        Console.SetCursorPosition(60, 5);
                        Console.Write("Aleatorio");
                        Console.SetCursorPosition(x, y);
                        break;

                    case ConsoleKey.Escape:
                        Random genAleatoriod = new Random();

                        randir = genAleatoriod.Next(0, 5);

                        switch (randir) {
                            case 1:
                                if (x <= max_ancho)
                                {
                                    x++;
                                    //Console.Clear();
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(60, 27);
                                    Console.Write(x + "," + y);
                                    Console.SetCursorPosition(60, 5);
                                    Console.Write("Derecha");
                                    Console.SetCursorPosition(x, y);
                                    Task.Delay(300);

                                }
                                break;

                            case 2:
                                if (x > 1)
                                {
                                    x--;
                                    //Console.Clear();
                                    
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(60, 27);
                                    Console.Write(x + "," + y);
                                    Console.SetCursorPosition(60, 5);
                                    Console.Write("Izquierda");
                                    Console.SetCursorPosition(x, y);
                                    Task.Delay(300);

                                }
                                break;

                            case 3:
                                if (y <= max_alto)
                                {
                                    y++;
                                    //Console.Clear();
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(60, 27);
                                    Console.Write(x + "," + y);
                                    Console.SetCursorPosition(60, 5);
                                    Console.Write("Abajo");
                                    Console.SetCursorPosition(x, y);
                                    Task.Delay(300);

                                }
                                break;
                               
                            case 4:
                                if (y > 1)
                                {
                                    y--;
                                    //Console.Clear();
                                    Console.SetCursorPosition(x, y);
                                    Console.Write(smile);
                                    Console.SetCursorPosition(60, 27);
                                    Console.Write(x + "," + y);
                                    Console.SetCursorPosition(60, 5);
                                    Console.Write("Arriba ↑");
                                    Console.SetCursorPosition(x, y);
                                    Task.Delay(300);

                                }
                                break;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.SetCursorPosition(x, y);
                        Console.Write(smile);
                        Console.SetCursorPosition(60, 27);
                        Console.Write(x + "," + y);
                        Console.SetCursorPosition(60, 5);
                        Console.Write("Cleared");
                        Console.SetCursorPosition(x, y);
                        break;
                }
            }
            while (true);
        }
    }
}
