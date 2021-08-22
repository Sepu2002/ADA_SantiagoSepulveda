using System;

namespace E1_CilindroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el volumen y área lateral de un cilindro con valores aleatorios");

            double rad, height, vol, area;

            Random randRad = new Random();
            Random randHei = new Random();

            Console.WriteLine("Radio generado: ");
            rad = Convert.ToDouble(randRad.Next(1, 5));
            Console.WriteLine("Radio: " + rad);

            Console.WriteLine("Altura generada: ");
            height = Convert.ToDouble(randHei.Next(1, 20));
            Console.WriteLine("Altura: " + height);

            vol = Math.PI * rad * rad * height;

            area = 2 * rad * Math.PI * height;


            Console.WriteLine("El volumen del cilindro es: " + vol);
            Console.WriteLine("El área lateral del cilindro es: " + area);

            Console.WriteLine("");

            Console.WriteLine("                    .------.");
            Console.WriteLine("                   (        )");
            Console.WriteLine("                   |~------~|");
            Console.WriteLine("                   |        | .----.");
            Console.WriteLine("                   |         (      )");
            Console.WriteLine("                   |        ||~----~|");
            Console.WriteLine("                   |        ||      |");
            Console.WriteLine("                   |        ||  .-----.");
            Console.WriteLine("                   |        || |._____.'");
            Console.WriteLine("                   |        || |       |");
            Console.WriteLine("                   |   .------.|       |");
            Console.WriteLine("                   |  (        |       |");
            Console.WriteLine("                   |  |~------~|       |");
            Console.WriteLine("                   |  |        |       |");
            Console.WriteLine("    _..----------..|  |  _.-----._     |");
            Console.WriteLine(" .-~                ~-..-         -.   |");
            Console.WriteLine(" |.                  .||-_       _-|   |");

          

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
