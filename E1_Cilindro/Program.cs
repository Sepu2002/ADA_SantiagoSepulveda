using System;

namespace E1_Cilindro
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el volumen y área lateral de un cilindro");
            //declarar variables
			double rad, height, vol, area;

            //Pedir el radio
			Console.WriteLine("Ingresa el radio: ");
			rad = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Radio: " + rad);

            //pedir la altura
			Console.WriteLine("Ingresa la altura: ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Altura: " + height);

            //calcular volumen
			vol = Math.PI * rad * rad * height;
            //calcular área lateral
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

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
	}
}
