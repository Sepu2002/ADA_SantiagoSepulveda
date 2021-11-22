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
            int punt = 0;
            int playerx = 1, playery = 1;
            int minox = genSpawn.Next(2, 39), chyx = genSpawn.Next(2, 39), chybx = genSpawn.Next(2, 39), chycx = genSpawn.Next(2, 39), ogrx = genSpawn.Next(2, 39), ogrbx = genSpawn.Next(2, 39), ogrcx = genSpawn.Next(2, 39), psyx = genSpawn.Next(2, 39), psybx = genSpawn.Next(2, 39), psycx = genSpawn.Next(2, 39);
            int minoy = genSpawn.Next(2, 19), chyy = genSpawn.Next(2, 19), chyby = genSpawn.Next(1, 19), chycy = genSpawn.Next(1, 19), ogry = genSpawn.Next(1, 19), ogrby = genSpawn.Next(1, 19), ogrcy = genSpawn.Next(1, 19), psyy = genSpawn.Next(1, 19), psyby = genSpawn.Next(1, 19), psycy = genSpawn.Next(1, 19);
            int[,] matrix = new int[40, 20];
            modeSelect(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy);
            dificultySelect(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy, ref cont, ref punt);     
        }
        static void readMaze(string mapa, ref int[,] matrix) {
            string[] items = new string[20];
            char[] div = { ',' };
            StreamReader objleer = new StreamReader(mapa);
            string item = objleer.ReadLine();
            while (item != null)
            {
                for (int current = 0; current < matrix.GetLength(1); current++)
                {


                    items = item.Split(div);
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, current] = Convert.ToInt32(items[i]);
                    }
                    item = objleer.ReadLine();
                }
            }
            objleer.Close();
        }
        static void printMaze (int[,] arr, int punt)
        {
            Console.Clear();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    if (arr[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("█");
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
                        Console.Write("+");
                    }
                    if (arr[i, j] == 4)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    if (arr[i, j] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("☺");
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
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Θ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }


                }
                Console.Write("\n");
                
            }
            Console.SetCursorPosition(0, 25);
            Console.Write("Puntuación: {0}",punt);
        }
        static string MapSelect() {
            string opcion = "";
            Console.WriteLine("Selecciona un Mapa");
            Console.WriteLine("");
            Console.WriteLine("1. Mapa 1");
            Console.WriteLine("2. Mapa 2");
            Console.WriteLine("3. Mapa 3");
            Console.WriteLine("4. Mapa 4");
            Console.WriteLine("5. Mapa 5");
            //Console.WriteLine("6. Continuar partida guardada");
            int mapselec= askint("Ingrese su selección");

            switch (mapselec) {
                case 1:
                    opcion = "mapauno.txt";
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

                //case 6:
                    //opcion = "SavedGame.txt";
                    //return opcion;
                default:
                    opcion = "mapauno.txt";
                    return opcion;


            }
        }
        static void modeSelect(ref int[,] matrix, ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy) {
            Console.WriteLine("1. Entrar a selección de mapas");
            Console.WriteLine("2. Continuar partida guardada");
            int inic = askint("Seleccione una opción");
            switch (inic)
            {
                case 1:
                    string mapa = MapSelect();
                    readMaze(mapa, ref matrix);
                    spawnBlock(matrix, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy);
                    break;
                case 2:
                    readMaze("SavedGame.txt", ref matrix);
                    posResume(ref matrix, ref playerx, ref playery, ref minox, ref minoy, ref chyx, ref chyy, ref chybx, ref chyby, ref chycx, ref chycy, ref ogrx, ref ogry, ref ogrbx, ref ogrby, ref ogrcx, ref ogrcy, ref psyx, ref psyy, ref psybx, ref psyby, ref psycx, ref psycy);
                    break;
            }
        }
        static void dificultySelect(ref int[,] matrix, ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy, ref int cont, ref int punt) {
            Console.WriteLine("1. Fácil (4 Enemigos)");
            Console.WriteLine("2. Medio (7 Enemigos)");
            Console.WriteLine("3. Difícil (10 Enemigos)");
            int dif = askint("Seleccione una dificultad");
            switch (dif) {
                case 1:
                    while (cont == 0)
                    {
                        printMaze(matrix, punt);

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt);

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

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt);

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

                        control(ref playerx, ref playery, ref matrix, ref cont, ref punt);

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
        
        static void control(ref int playerx, ref int playery, ref int[,] matrix, ref int cont, ref int punt) {
            ConsoleKeyInfo input;
            input = Console.ReadKey(false);
        
            switch (input.Key) {
                case ConsoleKey.RightArrow:
                    if (matrix[playerx+1,playery]==0 ) {

                        matrix[playerx, playery] = 0;  
                        playerx++;
                        punt++;
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx + 1, playery] == 4) {
                        winScreen(ref cont, punt);
                    }
                        break;

                case ConsoleKey.LeftArrow:
                    if (matrix[playerx - 1, playery] == 0)
                    {
                        matrix[playerx, playery] = 0;
                        playerx--;
                        punt++;
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx - 1, playery] == 4)
                    {
                        winScreen(ref cont, punt);
                    }
                    break;

                case ConsoleKey.DownArrow:
                    if (matrix[playerx, playery + 1] == 0)
                    {
                        matrix[playerx, playery] = 0;
                        playery++;
                        punt++;
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx, playery + 1] == 4)
                    {
                        winScreen(ref cont, punt);
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (matrix[playerx, playery - 1] == 0)
                    {
                        matrix[playerx, playery] = 0;
                        playery--;
                        punt++;
                        splayer(playerx, playery, ref matrix);

                    }
                    if (matrix[playerx, playery - 1] == 4)
                    {
                        winScreen(ref cont, punt);
                    }
                    break;

                case ConsoleKey.S:
                    saveGame("SavedGame.txt",ref matrix);
                    break;

            }
        }
        static void controlMin(ref int minox, ref int minoy, ref int[,] matrix) {
            Random genAleatorio = new Random();
            int randirmin = genAleatorio.Next(1, 5);

            switch (randirmin) {
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
       
        static void splayer(int playerx, int playery, ref int[,] matrix) {
            matrix[playerx, playery] = 5;
        }
        static void smino(int minox, int minoy, ref int[,] matrix) {
            matrix[minox, minoy] = 6;
        }
        static void schy(int chyx, int chyy, ref int[,] matrix){
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

        static void winScreen(ref int cont, int punt) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("      :::        :::::::::: :::     ::: :::::::::: :::           ::::::::  :::        ::::::::::     :::     :::::::::");
            Console.WriteLine("     :+:        :+:        :+:     :+: :+:        :+:          :+:    :+: :+:        :+:          :+: :+:   :+:    :+:");
            Console.WriteLine("    +:+        +:+        +:+     +:+ +:+        +:+          +:+        +:+        +:+         +:+   +:+  +:+    +:+");
            Console.WriteLine("   +#+        +#++:++#   +#+     +:+ +#++:++#   +#+          +#+        +#+        +#++:++#   +#++:++#++: +#++:++#:");
            Console.WriteLine("  +#+        +#+         +#+   +#+  +#+        +#+          +#+        +#+        +#+        +#+     +#+ +#+    +#+");
            Console.WriteLine(" #+#        #+#          #+#+#+#   #+#        #+#          #+#    #+# #+#        #+#        #+#     #+# #+#    #+#");
            Console.WriteLine("########## ##########     ###     ########## ##########    ########  ########## ########## ###     ### ###    ###");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Puntuación: {0}", punt);
            cont++;
            hold();

        }
        static void gameOver(ref int cont) {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      ::::::::      :::       :::   :::   ::::::::::          ::::::::  :::     ::: :::::::::: :::::::::");
            Console.WriteLine("    :+:    :+:   :+: :+:    :+:+: :+:+:  :+:                :+:    :+: :+:     :+: :+:        :+:    :+:");
            Console.WriteLine("   +:+         +:+   +:+  +:+ +:+:+ +:+ +:+                +:+    +:+ +:+     +:+ +:+        +:+    +:+");
            Console.WriteLine("  :#:        +#++:++#++: +#+  +:+  +#+ +#++:++#           +#+    +:+ +#+     +:+ +#++:++#   +#++:++#:");
            Console.WriteLine(" +#+   +#+# +#+     +#+ +#+       +#+ +#+                +#+    +#+  +#+   +#+  +#+        +#+    +#+");
            Console.WriteLine("#+#    #+# #+#     #+# #+#       #+# #+#                #+#    #+#   #+#+#+#   #+#        #+#    #+#");
            Console.WriteLine("########  ###     ### ###       ### ##########          ########      ###     ########## ###    ###");
            Console.ForegroundColor = ConsoleColor.White;
            cont++;
            hold();
        }
        static void hold()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
        static void saveGame(string saveFile, ref int[,] matrix) {
            File.WriteAllText(@"SavedGame.txt", string.Empty);
            StreamWriter objgrabar = new StreamWriter(saveFile, true);
            
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    string value=Convert.ToString(matrix[j,i]);
                    objgrabar.Write("{0}, ",value);
                }
                objgrabar.Write("\n");
            }
            objgrabar.Close();
        }
        static void posResume(ref int[,] arr,ref int playerx, ref int playery, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy) {
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
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static void colisionCheck(int[,] matrix, int playerx, int playery, ref int cont) {
            if (matrix[playerx + 1, playery] == 6 || matrix[playerx + 1, playery] == 7 || matrix[playerx + 1, playery] == 8 || matrix[playerx + 1, playery] == 9) {
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
        static void spawnBlock(int[,] arr, ref int minox, ref int minoy, ref int chyx, ref int chyy, ref int chybx, ref int chyby, ref int chycx, ref int chycy, ref int ogrx, ref int ogry, ref int ogrbx, ref int ogrby, ref int ogrcx, ref int ogrcy, ref int psyx, ref int psyy, ref int psybx, ref int psyby, ref int psycx, ref int psycy) {

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
