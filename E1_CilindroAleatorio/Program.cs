using System;

namespace E1_CilindroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el volumen y área lateral de un cilindro con valores aleatorios");
            //Declarar variables
            double rad, height, vol, area;

            //Empezar generadores aleatorios
            Random randRad = new Random();
            Random randHei = new Random();

            //Generar radio
            Console.WriteLine("Radio generado: ");
            rad = Convert.ToDouble(randRad.Next(1, 5));
            Console.WriteLine("Radio: " + rad);

            //Generar altura
            Console.WriteLine("Altura generada: ");
            height = Convert.ToDouble(randHei.Next(1, 20));
            Console.WriteLine("Altura: " + height);

            //Calcular volumen
            vol = Math.PI * rad * rad * height;

            //Calcular área lateral
            area = 2 * rad * Math.PI * height;

            //Imprimir resultados
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

          
            //Espera
            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
