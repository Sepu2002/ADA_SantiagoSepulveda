using System;

namespace E_DivPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int div, num, caso, numd;
            div = 2;
            caso = 0;
            Console.WriteLine("Seleccione los datos que quiere obtener:");
            Console.WriteLine("(1) Los factores primos de un número 'n'");
            Console.WriteLine("(2) Los factores primos de todos los números hasta 'n' ");
            caso = Convert.ToInt32(Console.ReadLine());

            switch (caso) 
            {
                case 1:
                    Console.WriteLine("Programa que obtine los factores primos de un número");
                    Console.WriteLine("Escriba el número a factorizar: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sus factores primos son: ");

                    while (num > 1)
                    {
                        if (num % div == 0)
                        {
                            Console.Write("| {0} ", div);
                            num = num / div;
                        }
                        else
                        {
                            div++;
                        }
                    }
                    Console.Write("|");
                    break;

                case 2:
                    Console.WriteLine("Programa que obtine los factores primos de los números hasta 'n'");
                    Console.WriteLine("Escriba el número límite: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sus factores primos son: ");

                    for (int cont = 2; cont <= num; cont++) {

                        numd = cont;
                        div = 2;
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("  {0}",cont);
                        
                        while (numd > 1)
                        {
                            if (numd % div == 0)
                            {
                                Console.Write("| {0} ", div);
                                numd = numd / div;
                            }
                            else
                            {
                                div++;
                            }
                        }
                        Console.Write("|");

                    }

                    break;





            }
            System.Threading.Thread.Sleep(2300);
            Console.WriteLine("");
            Console.WriteLine("\t           ;               ,");
            Console.WriteLine("\t          ,;                 '.");
            Console.WriteLine("\t         ;:                   :;");
            Console.WriteLine("\t        ::                     ::");
            Console.WriteLine("\t        ::                     ::");
            Console.WriteLine("\t        ':                     :");
            Console.WriteLine("\t         :.                    :");
            Console.WriteLine("\t      ;' ::                   ::  '");
            Console.WriteLine("\t     .'  ';                   ;'  '.");
            Console.WriteLine("\t    ::    :;                 ;:    :: ");
            Console.WriteLine("\t    ;      :;.             ,;:     ::");
            Console.WriteLine("\t    :;      :;:           ,;'       ::");
            Console.WriteLine("\t    ::.      ':;  ..,.;  ;:'     ,.;: ");
            Console.WriteLine("\t     '''...   '::,::::: ;:   .;.; ''' ");
            Console.WriteLine("\t         ''''....;:::::;,;.; ''' ");
            Console.WriteLine("\t     .:::.....''':::::::'',...;::::;.");
            Console.WriteLine("\t    ;:' '''''';.,;:::::;.'''''''  ':;");
            Console.WriteLine("\t   ::'         ;::;:::;::..         :;");
            Console.WriteLine("\t  ::         ,;:::::::::::;:..       ::");
            Console.WriteLine("\t  ;'     ,;;:;::::::::::::::;'; ..':.");
            Console.WriteLine("\t ::     ;:'  ::::::''''::::::  ':     ::");
            Console.WriteLine("\t  :.    ::   ::::::;  :::::::   :     ;");
            Console.WriteLine("\t   ;    ::   :::::::  :::::::   :    ;");
            Console.WriteLine("\t    '   ::   ::::::....:::::'  ,:   '");
            Console.WriteLine("\t     '  ::    :::::::::::::'   :: ");
            Console.WriteLine("\t        ::     ':::::::::''    ::");
            Console.WriteLine("\t        ':       ''''''''      ::");
            Console.WriteLine("\t         ::                   ;:");
            Console.WriteLine("\t         ':;                 ;:'");
            Console.WriteLine("\t -SSL-     ';              ,;'");
            Console.WriteLine("\t             ''           ''");
            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }

    }
}
/*Console.WriteLine("Programa que obtiene los divisores primos de un número:");
            int num, div;
            string divs;
            Console.WriteLine("Escriba el número a factorizar: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (div = 2; num > 1; div++)
                {
                    int x = 0;
                    while (num % div == 0)
                    {
                        num /= div;
                        x++;
                    }
                divs = Convert.ToString(div);

                Console.WriteLine("{0} es un factor primo {1} veces", div, x);
                }
            
        }*/