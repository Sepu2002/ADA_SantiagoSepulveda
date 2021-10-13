using System;

namespace E_SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int cancelar = 0;
            int select;
            while (cancelar == 0) {
                Console.WriteLine("1.-");
                Console.WriteLine("2.-");
                Console.WriteLine("3.-");
                Console.WriteLine("4.-");
                Console.WriteLine("5.-");
                Console.WriteLine("6.- Cerrar programa");
                select = Convert.ToInt32(Console.ReadLine());

                switch (select) {

                    case 1:
                        // Aquí va tu 1er programa
                        Console.WriteLine("Oprima enter para volver al menú");
                        string espera = Console.ReadLine();
                        break;

                    case 2:
                        // Aquí va tu 2o programa
                        Console.WriteLine("Oprima enter para volver al menú");
                        string esperatw = Console.ReadLine();
                        break;

                    case 3:
                        // Aquí va tu 3er programa
                        Console.WriteLine("Oprima enter para volver al menú");
                        string esperath = Console.ReadLine();
                        break;

                    case 4:
                        // Aquí va tu 4o programa
                        Console.WriteLine("Oprima enter para volver al menú");
                        string esperafo = Console.ReadLine();
                        break;

                    case 5:
                        // Aquí va tu 5o programa
                        Console.WriteLine("Oprima enter para volver al menú");
                        string esperaf = Console.ReadLine();
                        break;

                    case 6://este cierra el programa, no hay que cambiarle nada
                        cancelar++;
                        Console.WriteLine("Oprima enter para volver al menú");
                        string esperas = Console.ReadLine();
                        break;
                        


                }

            }
        }
    }
}
