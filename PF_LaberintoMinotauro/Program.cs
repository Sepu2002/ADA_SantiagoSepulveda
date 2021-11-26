using System;
using System.IO;

namespace PF_LaberintoMinotauro
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genSpawn = new Random();
            int cont = 0;
            int inic = 0;
            char contb = 's';
            int minox = genSpawn.Next(5, 39), chyx = genSpawn.Next(5, 39), chybx = genSpawn.Next(5, 39), chycx = genSpawn.Next(5, 39), ogrx = genSpawn.Next(5, 39), ogrbx = genSpawn.Next(5, 39), ogrcx = genSpawn.Next(5, 39), psyx = genSpawn.Next(5, 39), psybx = genSpawn.Next(5, 39), psycx = genSpawn.Next(5, 39);
            int minoy = genSpawn.Next(3, 19), chyy = genSpawn.Next(3, 19), chyby = genSpawn.Next(3, 19), chycy = genSpawn.Next(3, 19), ogry = genSpawn.Next(3, 19), ogrby = genSpawn.Next(3, 19), ogrcy = genSpawn.Next(3, 19), psyy = genSpawn.Next(3, 19), psyby = genSpawn.Next(3, 19), psycy = genSpawn.Next(3, 19);
            int[,] matrix = new int[40, 20];
            int dif = 0;
            do
            {
                int punt = 0;
                string nombre=splash();
                int playerx = 1, playery = 1;
                matrix = new int[41, 21];
                modeSelect(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy, ref cont, ref punt, ref contb, ref inic, ref dif, nombre);
            } while (contb == 's' || contb == 'S');
        }
        
        static void readMaze(string mapa, ref int[,] matrix)
        {
            string[] lineas = new string[20];
            char[] div = { ',' };
            StreamReader objleer = new StreamReader(mapa);
            string linea = objleer.ReadLine();
            while (linea != null)
            {
                for (int current = 0; current < matrix.GetLength(1)-1; current++)
                {

                    lineas = linea.Split(div);
                    for (int i = 0; i < matrix.GetLength(0)-1; i++)
                    {
                        matrix[i, current] = Convert.ToInt32(lineas[i]);
                    }
                    linea = objleer.ReadLine();
                }
            }
            objleer.Close();
        }
        static void readPoints()
        {
            StreamReader objleer = new StreamReader("Puntaje.txt");
            string item = objleer.ReadLine();
            Console.WriteLine("Nombre\t Puntaje\tDificultad\n");
            while (item != null)
            {
                Console.WriteLine(item);
                item = objleer.ReadLine();
            }
            objleer.Close();
        }
        static void printMaze(int[,] arr, int punt)
        {
            Console.Clear();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
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
                        Console.Write("▬");
                    }
                    if (arr[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("+");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (arr[i, j] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Σ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (arr[i, j] == 6)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("╦");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (arr[i, j] == 7)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("§");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (arr[i, j] == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("φ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (arr[i, j] == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write("Θ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
                Console.Write("\n");

            }
            Console.SetCursorPosition(0, 21);
            Console.Write("Puntuación: {0}\n\n", punt);
            Console.WriteLine("Instrucciones: ");
            Console.WriteLine("\t 1. Presione '-->' para comenzar la partida");
            Console.WriteLine("\t 2. Presione 'S' para guardar la partida");
            Console.WriteLine("\t 3. Intenta llegar a la salida sin tocar a los enemigos");
            Console.WriteLine("\t 4. Agarrar Dracmas (+) te da 10 puntos extras");
            Console.WriteLine("\t 5. Si te encuentras directamente junto a un enemigo, habrás perdido la partida");
            Console.SetCursorPosition(45, 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("Jugador Σ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("Minotauro ╦");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(45, 8);
            Console.WriteLine("Chymera §");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 9);
            Console.WriteLine("Ogro φ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("Cíclope Θ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static string MapSelect()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            StreamReader objleer = new StreamReader("SMTitulo.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                for (int current = 0; current <= 29; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;

            int mapselec = askint("Ingrese su selección");

            switch (mapselec)
            {
                case 1:
                    string opcion = "mapauno.txt";
                    return opcion;

                case 2:
                    opcion = "mapados.txt";
                    return opcion;

                case 3:
                     opcion = "mapatres.txt";
                    return opcion;
                case 4:
                    opcion = "mapacuatro.txt";
                    return opcion;

                case 5:
                    opcion = "mapacinco.txt";
                    return opcion;
                default:
                    opcion = "mapauno.txt";
                    return opcion;


            }
        }
        static void modeSelect(ref int[,] matrix, ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy, ref int cont, ref int punt, ref char contb, ref int inic, ref int dif, string nombre)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            StreamReader objleer = new StreamReader("Smodo.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                for (int current = 0; current <= 22; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;
            inic = askint("Seleccione una opción");
            switch (inic)
            {
                case 1:
                    string mapa = MapSelect();
                    readMaze(mapa, ref matrix);
                    spawnBlock(matrix, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy);
                    dificultySelect(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy, ref cont, ref punt, ref dif, nombre);
                    contb = s_or_n("¿Quieres jugar de nuevo?");
                    Console.Clear();
                    break;
                case 2:
                    readMaze("SavedGame.txt", ref matrix);
                    resumePoints(ref punt);
                    posResume(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy);
                    dificultySelect(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy, ref cont, ref punt, ref dif, nombre);
                    contb = s_or_n("¿Quieres jugar de nuevo? ");
                    Console.Clear();
                    break;
                case 3:
                    readPoints();
                    contb = s_or_n("¿Quieres volver al menú principal? ");
                    break;
            }
        }
        static void dificultySelect(ref int[,] matrix, ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy, ref int cont, ref int punt, ref int dif, string nombre)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            StreamReader objleer = new StreamReader("Dif.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                Console.ForegroundColor = ConsoleColor.White;
                for (int current = 1; current <= 9; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int current = 1; current <= 6; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int current = 1; current <= 6; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                for (int current = 1; current <= 6; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;

            dif = askint("Seleccione una dificultad");
            cont = 0;
            switch (dif)
            {
                case 1:
                    while (cont == 0)
                    {
                        printMaze(matrix, punt);

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt, nombre, dif);

                        controlMin(ref minox, ref minoy, ref matrix);

                        controlChy(ref chyx, ref chyy, ref matrix);

                        controlOgr(ref ogrx, ref ogry, ref matrix);

                        controlPsy(ref psyx, ref psyy, ref matrix);

                        colisionCheck(matrix, playerx, playery, ref cont);

                    }

                    break;

                case 2:
                    while (cont == 0)
                    {
                        printMaze(matrix, punt);

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt, nombre, dif);

                        controlMin(ref minox, ref minoy, ref matrix);

                        controlChy(ref chyx, ref chyy, ref matrix);
                        controlChy(ref chybx, ref chyby, ref matrix);

                        controlOgr(ref ogrx, ref ogry, ref matrix);
                        controlOgr(ref ogrbx, ref ogrby, ref matrix);

                        controlPsy(ref psyx, ref psyy, ref matrix);
                        controlPsy(ref psybx, ref psyby, ref matrix);

                        colisionCheck(matrix, playerx, playery, ref cont);

                    }

                    break;

                case 3:
                    while (cont == 0)
                    {
                        printMaze(matrix, punt);

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt, nombre, dif);

                        controlMin(ref minox, ref minoy, ref matrix);

                        controlChy(ref chyx, ref chyy, ref matrix);
                        controlChy(ref chybx, ref chyby, ref matrix);
                        controlChy(ref chycx, ref chycy, ref matrix);

                        controlOgr(ref ogrx, ref ogry, ref matrix);
                        controlOgr(ref ogrbx, ref ogrby, ref matrix);
                        controlOgr(ref ogrcx, ref ogrcy, ref matrix);

                        controlPsy(ref psyx, ref psyy, ref matrix);
                        controlPsy(ref psybx, ref psyby, ref matrix);
                        controlPsy(ref psycx, ref psycy, ref matrix);

                        colisionCheck(matrix, playerx, playery, ref cont);

                    }
                    break;
            }

        }

        static void control(ref int playerx, ref int playery, ref int[,] matrix, ref int cont, ref int punt, string nombre, int dif)
        {
            
            ConsoleKeyInfo input;
            input = Console.ReadKey(false);

            switch (input.Key)
            {
                case ConsoleKey.RightArrow:
                    if (matrix[playerx + 1, playery] == 0 || matrix[playerx + 1, playery] == 3)
                    {

                        matrix[playerx, playery] = 0;
                        playerx++;
                        punt++;
                        if (matrix[playerx, playery] == 3)
                        {
                            punt = punt + 10;
                        }
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx + 1, playery] == 4)
                    {
                        winScreen(ref cont, punt, nombre, dif);
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (matrix[playerx - 1, playery] == 0 || matrix[playerx - 1, playery] == 3)
                    {
                        matrix[playerx, playery] = 0;
                        playerx--;
                        punt++;
                        if (matrix[playerx, playery] == 3)
                        {
                            punt = punt + 10;
                        }
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx - 1, playery] == 4)
                    {
                        winScreen(ref cont, punt, nombre, dif);
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (matrix[playerx, playery + 1] == 0 || matrix[playerx, playery + 1] == 3)
                    {
                        matrix[playerx, playery] = 0;
                        playery++;
                        punt++;
                        if (matrix[playerx, playery] == 3)
                        {
                            punt = punt + 10;
                        }
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx, playery + 1] == 4)
                    {
                        winScreen(ref cont, punt, nombre, dif);
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (matrix[playerx, playery - 1] == 0 || matrix[playerx , playery - 1] == 3)
                    {
                        matrix[playerx, playery] = 0;
                        playery--;
                        punt++;
                        if (matrix[playerx, playery] == 3)
                        {
                            punt = punt + 10;
                        }
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx, playery - 1] == 4)
                    {
                        winScreen(ref cont, punt, nombre, dif);
                    }
                    break;

                case ConsoleKey.S:
                    saveGame("SavedGame.txt", ref matrix, punt);
                    break;

            }
        }
        static void controlMin(ref int minox, ref int minoy, ref int[,] matrix)
        {
            Random genAleatorio = new Random();
            int randirmin = genAleatorio.Next(1, 5);

            switch (randirmin)
            {
                case 1:
                    if (matrix[minox + 1, minoy] == 0)
                    {
                        matrix[minox, minoy] = 0;
                        minox++;
                        smino(minox, minoy, ref matrix);

                    }
                    break;
                case 2:
                    if (matrix[minox - 1, minoy] == 0)
                    {
                        matrix[minox, minoy] = 0;
                        minox--;
                        smino(minox, minoy, ref matrix);

                    }
                    break;
                case 3:
                    if (matrix[minox, minoy + 1] == 0)
                    {
                        matrix[minox, minoy] = 0;
                        minoy++;
                        smino(minox, minoy, ref matrix);

                    }
                    break;
                case 4:
                    if (matrix[minox, minoy - 1] == 0)
                    {
                        matrix[minox, minoy] = 0;
                        minoy--;
                        smino(minox, minoy, ref matrix);

                    }
                    break;


            }
        }
        static void controlChy(ref int chyx, ref int chyy, ref int[,] matrix)
        {
            Random genAleatorio = new Random();
            int randirmin = genAleatorio.Next(1, 5);

            switch (randirmin)
            {
                case 1:
                    if (matrix[chyx + 1, chyy] == 0)
                    {
                        matrix[chyx, chyy] = 0;
                        chyx++;
                        schy(chyx, chyy, ref matrix);

                    }
                    break;
                case 2:
                    if (matrix[chyx - 1, chyy] == 0)
                    {
                        matrix[chyx, chyy] = 0;
                        chyx--;
                        schy(chyx, chyy, ref matrix);

                    }
                    break;
                case 3:
                    if (matrix[chyx, chyy + 1] == 0)
                    {
                        matrix[chyx, chyy] = 0;
                        chyy++;
                        schy(chyx, chyy, ref matrix);

                    }
                    break;
                case 4:
                    if (matrix[chyx, chyy - 1] == 0)
                    {
                        matrix[chyx, chyy] = 0;
                        chyy--;
                        schy(chyx, chyy, ref matrix);

                    }
                    break;


            }
        }
        static void controlOgr(ref int ogrx, ref int ogry, ref int[,] matrix)
        {
            Random genAleatorio = new Random();
            int randirmin = genAleatorio.Next(1, 5);

            switch (randirmin)
            {
                case 1:
                    if (matrix[ogrx + 1, ogry] == 0)
                    {
                        matrix[ogrx, ogry] = 0;
                        ogrx++;
                        sogr(ogrx, ogry, ref matrix);

                    }
                    break;
                case 2:
                    if (matrix[ogrx - 1, ogry] == 0)
                    {
                        matrix[ogrx, ogry] = 0;
                        ogrx--;
                        sogr(ogrx, ogry, ref matrix);

                    }
                    break;
                case 3:
                    if (matrix[ogrx, ogry + 1] == 0)
                    {
                        matrix[ogrx, ogry] = 0;
                        ogry++;
                        sogr(ogrx, ogry, ref matrix);

                    }
                    break;
                case 4:
                    if (matrix[ogrx, ogry - 1] == 0)
                    {
                        matrix[ogrx, ogry] = 0;
                        ogry--;
                        sogr(ogrx, ogry, ref matrix);

                    }
                    break;


            }
        }
        static void controlPsy(ref int psyx, ref int psyy, ref int[,] matrix)
        {
            Random genAleatorio = new Random();
            int randirmin = genAleatorio.Next(1, 5);

            switch (randirmin)
            {
                case 1:
                    if (matrix[psyx + 1, psyy] == 0)
                    {
                        matrix[psyx, psyy] = 0;
                        psyx++;
                        spsy(psyx, psyy, ref matrix);

                    }
                    break;
                case 2:
                    if (matrix[psyx - 1, psyy] == 0)
                    {
                        matrix[psyx, psyy] = 0;
                        psyx--;
                        spsy(psyx, psyy, ref matrix);

                    }
                    break;
                case 3:
                    if (matrix[psyx, psyy + 1] == 0)
                    {
                        matrix[psyx, psyy] = 0;
                        psyy++;
                        spsy(psyx, psyy, ref matrix);

                    }
                    break;
                case 4:
                    if (matrix[psyx, psyy - 1] == 0)
                    {
                        matrix[psyx, psyy] = 0;
                        psyy--;
                        spsy(psyx, psyy, ref matrix);

                    }
                    break;


            }
        }


        static void splayer(int playerx, int playery, ref int[,] matrix)
        {
            matrix[playerx, playery] = 5;
        }
        static void smino(int minox, int minoy, ref int[,] matrix)
        {
            matrix[minox, minoy] = 6;
        }
        static void schy(int chyx, int chyy, ref int[,] matrix)
        {
            matrix[chyx, chyy] = 7;
        }
        static void sogr(int ogrx, int ogry, ref int[,] matrix)
        {
            matrix[ogrx, ogry] = 8;
        }
        static void spsy(int psyx, int psyy, ref int[,] matrix)
        {
            matrix[psyx, psyy] = 9;
        }

        static void winScreen(ref int cont, int punt, string nombre, int dif)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      :::        :::::::::: :::     ::: :::::::::: :::           ::::::::  :::        ::::::::::     :::     :::::::::");
            Console.WriteLine("     :+:        :+:        :+:     :+: :+:        :+:          :+:    :+: :+:        :+:          :+: :+:   :+:    :+:");
            Console.WriteLine("    +:+        +:+        +:+     +:+ +:+        +:+          +:+        +:+        +:+         +:+   +:+  +:+    +:+");
            Console.WriteLine("   +#+        +#++:++#   +#+     +:+ +#++:++#   +#+          +#+        +#+        +#++:++#   +#++:++#++: +#++:++#:");
            Console.WriteLine("  +#+        +#+         +#+   +#+  +#+        +#+          +#+        +#+        +#+        +#+     +#+ +#+    +#+");
            Console.WriteLine(" #+#        #+#          #+#+#+#   #+#        #+#          #+#    #+# #+#        #+#        #+#     #+# #+#    #+#");
            Console.WriteLine("########## ##########     ###     ########## ##########    ########  ########## ########## ###     ### ###    ###");

            StreamReader objleer = new StreamReader("MinoArtLC.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                for (int current = 0; current <= 31; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Puntuación: {0}", punt);
            cont++;
            string difs = "";
            switch (dif)
            {
                case 1:
                    difs = "Fácil";
                    break;
                case 2:
                    difs = "Medio";
                    break;
                case 3:
                    difs = "Difícil";
                    break;
            }
            writeScore(nombre, punt, difs);
            //hold();

        }
        static void gameOver(ref int cont)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      ::::::::      :::       :::   :::   ::::::::::          ::::::::  :::     ::: :::::::::: :::::::::");
            Console.WriteLine("    :+:    :+:   :+: :+:    :+:+: :+:+:  :+:                :+:    :+: :+:     :+: :+:        :+:    :+:");
            Console.WriteLine("   +:+         +:+   +:+  +:+ +:+:+ +:+ +:+                +:+    +:+ +:+     +:+ +:+        +:+    +:+");
            Console.WriteLine("  :#:        +#++:++#++: +#+  +:+  +#+ +#++:++#           +#+    +:+ +#+     +:+ +#++:++#   +#++:++#:");
            Console.WriteLine(" +#+   +#+# +#+     +#+ +#+       +#+ +#+                +#+    +#+  +#+   +#+  +#+        +#+    +#+");
            Console.WriteLine("#+#    #+# #+#     #+# #+#       #+# #+#                #+#    #+#   #+#+#+#   #+#        #+#    #+#");
            Console.WriteLine("########  ###     ### ###       ### ##########          ########      ###     ########## ###    ###");

            StreamReader objleer = new StreamReader("MinoArtGO.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                for (int current = 0; current <= 21; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;
            cont++;
            //hold();
        }
        static string splash() {
            StreamWriter objescrib = new StreamWriter("Dif.txt", true);
            objescrib.Close();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            StreamReader objleer = new StreamReader("MinoArt.txt");
            string minotauro = objleer.ReadLine();
            while (minotauro != null)
            {
                for (int current = 0; current <= 49; current++)
                {

                    Console.WriteLine(minotauro);
                    minotauro = objleer.ReadLine();
                }
            }
            objleer.Close();
            Console.ForegroundColor = ConsoleColor.White;
            string nombre = askstr("Nombre del Jugador: ");
            return nombre;
            

        }
        static void saveGame(string saveFile, ref int[,] matrix, int punt)
        {
            File.WriteAllText(@"SavedGame.txt", string.Empty);
            StreamWriter objgrabar = new StreamWriter(saveFile, true);

            for (int i = 0; i < matrix.GetLength(1)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0)-1; j++)
                {
                    string value = Convert.ToString(matrix[j, i]);
                    objgrabar.Write("{0}, ", value);
                }
                objgrabar.Write("\n");
            }
            objgrabar.Close();

            File.WriteAllText(@"ScoreSave.txt", string.Empty);
            StreamWriter objgrabarb = new StreamWriter("ScoreSave.txt", true);
            objgrabarb.Write(punt);
            objgrabarb.Close();

        }
        static void writeScore(string nombre, int punt, string dif)
        {
            StreamWriter objgrabar = new StreamWriter("Puntaje.txt", true);
            objgrabar.Write("{0}\t {1}\t \t{2}", nombre, punt, dif);
            objgrabar.Write("\n");
            objgrabar.Close();

        }
        static void posResume(ref int[,] arr, ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy)
        {
            Console.Clear();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {

                    if (arr[i, j] == 5)
                    {
                        playerx = i;
                        playery = j;
                        arr[i, j] = 0;
                    }
                    if (arr[i, j] == 6)
                    {
                        minox = i;
                        minoy = j;
                        arr[i, j] = 0;
                    }

                    if (arr[i, j] == 7)
                    {
                        chyx = i;
                        chyy = j;
                        arr[i, j] = 0;
                    }

                    if (arr[i, j] == 7)
                    {
                        chybx = i;
                        chyby = j;
                        arr[i, j] = 0;
                    }
                    if (arr[i, j] == 7)
                    {
                        chycx = i;
                        chycy = j;
                        arr[i, j] = 0;
                    }

                    if (arr[i, j] == 8)
                    {
                        ogrx = i;
                        ogry = j;
                        arr[i, j] = 0;

                    }
                    if (arr[i, j] == 8)
                    {
                        ogrbx = i;
                        ogrby = j;
                        arr[i, j] = 0;

                    }
                    if (arr[i, j] == 8)
                    {
                        ogrcx = i;
                        ogrcy = j;
                        arr[i, j] = 0;

                    }

                    if (arr[i, j] == 9)
                    {
                        psyx = i;
                        psyy = j;
                        arr[i, j] = 0;
                    }
                    if (arr[i, j] == 9)
                    {
                        psybx = i;
                        psyby = j;
                        arr[i, j] = 0;
                    }
                    if (arr[i, j] == 9)
                    {
                        psycx = i;
                        psycy = j;
                        arr[i, j] = 0;
                    }


                }
                Console.Write("\n");

            }
            Console.SetCursorPosition(0, 1);
        }
        static void resumePoints(ref int punt)
        {
            StreamReader objleerb = new StreamReader("ScoreSave.txt");
            punt = Convert.ToInt32(objleerb.ReadLine());
            objleerb.Close();
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static void colisionCheck(int[,] matrix, int playerx, int playery, ref int cont)
        {
            if (matrix[playerx + 1, playery] == 6 || matrix[playerx + 1, playery] == 7 || matrix[playerx + 1, playery] == 8 || matrix[playerx + 1, playery] == 9)
            {
                gameOver(ref cont);
            }
            if (matrix[playerx - 1, playery] == 6 || matrix[playerx - 1, playery] == 7 || matrix[playerx - 1, playery] == 8 || matrix[playerx - 1, playery] == 9)
            {
                gameOver(ref cont);
            }
            if (matrix[playerx, playery + 1] == 6 || matrix[playerx, playery + 1] == 7 || matrix[playerx, playery + 1] == 8 || matrix[playerx, playery + 1] == 9)
            {
                gameOver(ref cont);
            }
            if (matrix[playerx, playery - 1] == 6 || matrix[playerx, playery - 1] == 7 || matrix[playerx, playery - 1] == 8 || matrix[playerx, playery - 1] == 9)
            {
                gameOver(ref cont);
            }
        }
        static char s_or_n(string mes)
        {
            Console.WriteLine("");
            Console.WriteLine("{0} (s/n) <enter>", mes);
            char output = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return output;
            
        }
        static string askstr(string mes)
        {
            string output;
            Console.WriteLine("{0}", mes);
            output = Console.ReadLine();
            return output;
        }
        static void spawnBlock(int[,] arr, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy)
        {

            Random genSpawn = new Random();

            if (arr[minox, minoy] != 0)
            {
                minox = genSpawn.Next(1, 40);
                minoy = genSpawn.Next(1, 20);
            }


            if (arr[chyx, chyy] != 0)
            {
                chyx = genSpawn.Next(1, 40);
                chyy = genSpawn.Next(1, 20);
            }


            if (arr[chybx, chyby] != 0)
            {
                chybx = genSpawn.Next(1, 40);
                chyby = genSpawn.Next(1, 20);
            }


            if (arr[chycx, chycy] != 0)
            {
                chycx = genSpawn.Next(1, 40);
                chycy = genSpawn.Next(1, 20);
            }


            if (arr[ogrx, ogry] != 0)
            {
                ogrx = genSpawn.Next(1, 40);
                ogry = genSpawn.Next(1, 20);
            }


            if (arr[ogrbx, ogrby] != 0)
            {
                ogrbx = genSpawn.Next(1, 40);
                ogrby = genSpawn.Next(1, 20);
            }


            if (arr[ogrcx, ogrcy] != 0)
            {
                ogrcx = genSpawn.Next(1, 40);
                ogrcy = genSpawn.Next(1, 20);
            }


            if (arr[psyx, psyy] != 0)
            {
                psyx = genSpawn.Next(2, 39);
                psyy = genSpawn.Next(2, 19);
            }


            if (arr[psybx, psyby] != 0)
            {
                psybx = genSpawn.Next(2, 39);
                psyby = genSpawn.Next(2, 19);
            }


            if (arr[psycx, psycy] != 0)
            {
                psycx = genSpawn.Next(2, 39);
                psycy = genSpawn.Next(2, 19);
            }


        }

    }
}
