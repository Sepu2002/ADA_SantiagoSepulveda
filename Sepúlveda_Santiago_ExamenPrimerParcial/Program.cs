using System;

namespace Sepúlveda_Santiago_ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int caso, id, none, ntwo, nthree, sum, lo, med, hi, cancel;
            string name;
            cancel = 0;
            Random genAleatorio = new Random();
            Console.WriteLine("Universidad Panamericana");
            Console.WriteLine("Santiago Sepúlveda Landeros");
            Console.WriteLine("Ingeniería Mecatrónica");
            Console.WriteLine("0212496");
            Console.WriteLine("");
            Console.WriteLine("Proporcione su nombre y apellidos:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            id = genAleatorio.Next(100000, 399999);
            Console.WriteLine("Su ID automático es: {0}",id);
            while (cancel == 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Seleccione programa a correr: ");
                Console.WriteLine("1. Desplegar datos del usuario:");
                Console.WriteLine("2. Separa ID en 3 segmentos iguales:");
                Console.WriteLine("3. Sumar ID separado en segmentos iguales:");
                Console.WriteLine("4. Obtener el segmento del ID mayor y el menor:");
                Console.WriteLine("5. Obtener los números entre el segmento mayor y el menor del ID:");
                Console.WriteLine("6. Salir del programa:");

                caso = Convert.ToInt32(Console.ReadLine());

                switch (caso)
                {

                    case 1:
                        Console.WriteLine("Este es el programa 1");
                        Console.WriteLine("Los datos del usuario son:");
                        Console.WriteLine("Nombre= {0} \t ID= {1}", name, id);
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        string esperaun = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Este es el programa 2");


                        nthree = id % 100;
                        ntwo = (id / 100) % 100;
                        none = (id / 10000);

                        Console.WriteLine("{0}, {1}, {2}", none, ntwo, nthree);
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        string esperados = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine("Este es el programa 3");
                        Console.WriteLine("La suma del ID {0} separado en segmentos es:", id);
                        nthree = id % 100;
                        ntwo = (id / 100) % 100;
                        none = (id / 10000);
                        sum = none + ntwo + nthree;
                        Console.WriteLine("Suma= {0} + {1} + {2} = {3}", none, ntwo, nthree, sum);
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        string esperatres = Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Este es el programa 4");
                        nthree = id % 100;
                        ntwo = (id / 100) % 100;
                        none = (id / 10000);
                        Console.WriteLine("{0}, {1}, {2}", none, ntwo, nthree);
                        if (none > ntwo)
                        {
                            med = none;
                            lo = ntwo;
                        }
                        else
                        {
                            med = ntwo;
                            lo = none;
                        }
                        if (med > nthree)
                        {
                            hi = med;
                            if (lo > nthree)
                            {
                                med = lo;
                                lo = nthree;
                            }
                            else
                            {
                                med = nthree;
                            }
                        }
                        else hi = nthree;


                        Console.WriteLine("El mayor de los números es: {0}", hi);
                        Console.WriteLine("El menor de los números es: {0}", lo);
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        string esperacuat = Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Este es el programa 5");
                        nthree = id % 100;
                        ntwo = (id / 100) % 100;
                        none = (id / 10000);

                        if (none > ntwo)
                        {
                            med = none;
                            lo = ntwo;
                        }
                        else
                        {
                            med = ntwo;
                            lo = none;
                        }
                        if (med > nthree)
                        {
                            hi = med;
                            if (lo > nthree)
                            {
                                med = lo;
                                lo = nthree;
                            }
                            else
                            {
                                med = nthree;
                            }
                        }
                        else hi = nthree;
                        Console.WriteLine("El rango es de {0} a {1}", lo, hi);
                        Console.WriteLine("");
                        for (int i = lo; i <= hi; i++)
                        {
                            Console.Write("{0}\t", i);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        string esperacinc = Console.ReadLine();
                        break;

                    case 6:
                        cancel= cancel+ 1;
                        Console.WriteLine("Programa finalizado, oprima <enter> ");
                        break;


                }
            
            }
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("           ;               ,");
            Console.WriteLine("         ,;                 '.");
            Console.WriteLine("        ;:                   :;");
            Console.WriteLine("       ::                     ::");
            Console.WriteLine("       ::                     ::");
            Console.WriteLine("       ':                     :");
            Console.WriteLine("        :.                    :");
            Console.WriteLine("     ;' ::                   ::  '");
            Console.WriteLine("    .'  ';                   ;'  '.");
            Console.WriteLine("   ::    :;                 ;:    :: ");
            Console.WriteLine("   ;      :;.             ,;:     ::");
            Console.WriteLine("   :;      :;:           ,;'       ::");
            Console.WriteLine("   ::.      ':;  ;.,.;  ;:'     ,.;: ");
            Console.WriteLine("    '''...   '::,::::: ;:   .;.; ''' ");
            Console.WriteLine("        ''''....;:::::;,;.; ''' ");
            Console.WriteLine("    .:::.....''':::::::'',...;::::;.");
            Console.WriteLine("   ;:' '''''';.,;:::::;.'''''''  ':;");
            Console.WriteLine("  ::'         ;::;:::;::..         :;");
            Console.WriteLine(" ::         ,;:::::::::::;:..       ::");
            Console.WriteLine(" ;'     ,;;:;::::::::::::::;'; ..':.");
            Console.WriteLine("::     ;:'  ::::::''''::::::  ':     ::");
            Console.WriteLine(" :.    ::   ::::::;  :::::::   :     ;");
            Console.WriteLine("  ;    ::   :::::::  :::::::   :    ;");
            Console.WriteLine("   '   ::   ::::::....:::::'  ,:   '");
            Console.WriteLine("    '  ::    :::::::::::::'   :: ");
            Console.WriteLine("       ::     ':::::::::''    ::");
            Console.WriteLine("       ':       ''''''''      ::");
            Console.WriteLine("        ::                   ;:");
            Console.WriteLine("        ':;                 ;:'");
            Console.WriteLine("-SSL-     ';              ,;'");
            Console.WriteLine("            ''           ''");
            Console.WriteLine("¡Muchas gracias prof!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("¡Viv");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("a Mex");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ico!");
            string espera = Console.ReadLine();
        }
    }
}
