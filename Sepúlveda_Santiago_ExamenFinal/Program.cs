using System;
using System.IO;

namespace Sepúlveda_Santiago_ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genSpawn = new Random();
            int cont = 0;
            int playerx = 1, playery = 1;
            int spritex = genSpawn.Next(3, 39), spritey = genSpawn.Next(2, 19);
            int[,] matrix = new int[41, 21];
            int[] dirs = new int[100];
            int[] dirsr = new int[100];
            personalInfo();
            readArea("Area.txt", ref matrix);
            matrix[spritex, spritey] = 7;

            while (true) {
                cont++;
                control(ref playerx, ref playery, ref matrix, spritex, spritey, cont, ref dirs, ref dirsr);
                printArea(matrix, playerx, playery, spritex, spritey);
            }
        }
        static void personalInfo() {
            Console.WriteLine("Examen Final");
            Console.WriteLine("Santiago Sepúlveda Landeros");
            Console.WriteLine("0212496");
            Console.WriteLine("Ingeniería Mecatrónica");
        }

        static void readArea(string mapa, ref int[,] matrix)
        {
            string[] lineas = new string[20];
            char[] div = { ',' };
            StreamReader objleer = new StreamReader(mapa);
            string linea = objleer.ReadLine();
            while (linea != null)
            {
                for (int current = 0; current < matrix.GetLength(1) - 1; current++)
                {

                    lineas = linea.Split(div);
                    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                    {
                        matrix[i, current] = Convert.ToInt32(lineas[i]);
                    }
                    linea = objleer.ReadLine();
                }
            }
            objleer.Close();
        }

        static void printArea(int[,] arr, int playerx, int playery, int spritex, int spritey)
        {
            Console.Clear();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("╬");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (arr[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.White;
                       
                    }
                    if (arr[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write('☻');
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    }


                }
                Console.Write("\n");
              
            }
            Console.Write("Posición:{0}, {1}", playerx, playery);
            Console.Write("\n");
            Console.Write("Sprite Posición:{0}, {1}", spritex, spritey);
            Console.Write("\n");
            Console.Write("Use las flechas para moverse");
            Console.Write("\n");
            Console.Write("Presione S para hacer el recorrido desde 1,1");
            Console.Write("\n");
            Console.Write("Presione C para hacer el recorrido desde su posición actual");
            Console.Write("\n");
            Console.Write("Presione M para guardar los movimientos en un archivo");
            Console.Write("\n");
            Console.Write("Presione A para correr los movimiento del archivo (No sirve :( aunque debería de, me interesa saber cómo lo resolvería usted si se puede)");
        }

        static void control(ref int playerx, ref int playery, ref int[,] matrix, int spritex, int spritey, int cont, ref int[] dirs, ref int[] dirsr)
        {

            ConsoleKeyInfo input;
            input = Console.ReadKey(false);

            switch (input.Key)
            {
                case ConsoleKey.RightArrow:
                    derecha(ref matrix, ref playerx, ref playery, cont, ref dirs);
                    
                    break;

                case ConsoleKey.LeftArrow:
                    izquierda(ref matrix, ref playerx, ref playery, cont, ref dirs);

                    break;

                case ConsoleKey.DownArrow:
                    abajo(ref matrix, ref playerx, ref playery, cont, ref dirs);

                    break;

                case ConsoleKey.UpArrow:
                    arriba(ref matrix, ref playerx, ref playery, cont, ref dirs);
                    break;

                case ConsoleKey.S:
                    readArea("Area.txt", ref matrix);
                    matrix[spritex, spritey] = 7;
                    playerx = 1;
                    playery = 1;
                    for (int i = 1; i < spritex; i++) 
                    {
                        derecha(ref matrix, ref playerx, ref playery, cont, ref dirs);
                    }
                    for (int j = 1; j < spritey; j++)
                    {
                        abajo(ref matrix, ref playerx, ref playery, cont, ref dirs);
                    }
                    break;

                case ConsoleKey.C:
                    
                    if (spritex > playerx) {
                        for (int i = playerx; i < spritex; i++)
                        {
                            derecha(ref matrix, ref playerx, ref playery, cont, ref dirs);
                        }

                    }
                    if (spritex < playerx)
                    {
                        for (int i = playerx; i > spritex; i++)
                        {
                            izquierda(ref matrix, ref playerx, ref playery, cont, ref dirs);
                        }

                    }

                    if (spritey > playery)
                    {
                        for (int i = playery; i < spritey; i++)
                        {
                            abajo(ref matrix, ref playerx, ref playery, cont, ref dirs);
                        }

                    }

                    if (spritey < playery)
                    {
                        for (int i = playery; i < spritey; i++)
                        {
                           arriba(ref matrix, ref playerx, ref playery, cont, ref dirs);
                        }

                    }
                    break;

                case ConsoleKey.M:
                    saveMoves(ref dirs);
                    break;

                case ConsoleKey.A: 
                    readArea("Area.txt", ref matrix);
                    playerx = 1;
                    playery = 1;
                    recoverMoves(ref dirsr);
                    replayMoves(dirsr, ref playerx, ref playery, ref matrix, ref cont);
                    break;
            }
        }

        static void derecha(ref int[,] matrix, ref int playerx, ref int playery, int cont, ref int[] dirs) {
            if (matrix[playerx + 1, playery] == 0|| matrix[playerx + 1, playery] == 4)
            {
                matrix[playerx, playery] = 3;
                playerx++;
                matrix[playerx, playery] = 2;

            }
            dirs[cont] = 6;
        }
        static void izquierda(ref int[,] matrix, ref int playerx, ref int playery, int cont, ref int[] dirs) {
            if (matrix[playerx - 1, playery] == 0|| matrix[playerx - 1, playery] == 3)
            {
                matrix[playerx, playery] = 4;
                playerx--;
                matrix[playerx, playery] = 2;
            }
            dirs[cont] = 4;
        }
        static void abajo(ref int[,] matrix, ref int playerx, ref int playery, int cont, ref int[] dirs) {
            if (matrix[playerx, playery + 1] == 0|| matrix[playerx, playery + 1] == 6)
            {
                matrix[playerx, playery] = 5;
                playery++;
                matrix[playerx, playery] = 2;
            }
            dirs[cont] = 2;
        }
        static void arriba(ref int[,] matrix, ref int playerx, ref int playery, int cont, ref int[] dirs) {
            if (matrix[playerx, playery - 1] == 0|| matrix[playerx, playery + 1] == 5)
            {
                matrix[playerx, playery] = 6;
                playery--;
                matrix[playerx, playery] = 2;

            }
            dirs[cont] = 8;
        }
        static void saveMoves(ref int[]dirs) {
            File.WriteAllText(@"Moves.txt", string.Empty);
            StreamWriter objgrabarb = new StreamWriter("Moves.txt", true);
            for (int i = 0; i < dirs.Length; i++) {
                objgrabarb.Write("{0},", dirs[i]);
            }
            objgrabarb.Close();
        }
        static void recoverMoves(ref int[] dirsr) {
            string[] lineas = new string[100];
            StreamReader objleer = new StreamReader("Moves.txt");
            char[] div = { ',' };
            string linea = objleer.ReadLine();
            while (linea != null)
            {
                for (int i = 0; i < dirsr.Length; i++)
                {

                    lineas = linea.Split(div);
                    dirsr[i] = int.Parse(lineas[i]);
                    
                }
            }
            objleer.Close();



        }
        static void replayMoves(int[] dirsr, ref int playerx, ref int playery, ref int[,] matrix, ref int cont) {
            for (int i = 0; i < dirsr.Length; i++) {
                if (dirsr[i] == 6) {
                    derecha(ref matrix,ref playerx, ref playery, cont, ref dirsr);
                }
                if (dirsr[i] == 4)
                {
                    izquierda(ref matrix, ref playerx, ref playery, cont, ref dirsr);
                }
                if (dirsr[i] == 2)
                {
                    abajo(ref matrix, ref playerx, ref playery, cont, ref dirsr);
                }
                if (dirsr[i] == 8)
                {
                    arriba(ref matrix, ref playerx, ref playery, cont, ref dirsr);
                }
            }
        }


        
    }
}
