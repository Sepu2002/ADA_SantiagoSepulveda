using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace E_SmileXY
{
    class Program
    {
        static void Main(string[] args)
        {
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
                        if (x<=max_ancho)
                        {
                            x++;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(102, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(102, 5);
                            Console.Write("Derecha →");
                            Console.SetCursorPosition(x, y);
                        }
                        break;



                    case ConsoleKey.LeftArrow:
                        if (x > 1)
                        {
                            x--;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(102, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(102, 5);
                            Console.Write("Izquierda ←");
                            Console.SetCursorPosition(x, y);

                        }
                        break;
                       
                        
                    case ConsoleKey.DownArrow:
                        if (y <= max_alto)
                        {
                            y++;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(102, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(102, 5);
                            Console.Write("Abajo ↓");
                            Console.SetCursorPosition(x, y);

                        }
                        break;
                        
                        
                    case ConsoleKey.UpArrow:
                        if (y>1)
                        {
                            y--;
                            Console.Clear();
                            Console.SetCursorPosition(x, y);
                            Console.Write(smile);
                            Console.SetCursorPosition(102, 27);
                            Console.Write(x + "," + y);
                            Console.SetCursorPosition(102, 5);
                            Console.Write("Arriba ↑");
                            Console.SetCursorPosition(x, y);

                        }
                        break;
                        
                        

                }
            }
            while (tecla.Key != ConsoleKey.Spacebar);
        }
    }
}
