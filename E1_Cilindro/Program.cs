using System;

namespace E1_Cilindro
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Programa que calcula el volumen y área lateral de un cilindro");

			double rad, height, vol, area;

			Console.WriteLine("Ingresa el radio: ");
			rad = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Radio: " + rad);

			Console.WriteLine("Ingresa la altura: ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Altura: " + height);

			vol = Math.PI * rad * rad * height;

			area = 2 * rad * Math.PI * height;


			Console.WriteLine("El volumen del cilindro es: " + vol);
			Console.WriteLine("El área lateral del cilindro es: " + vol);

			Console.WriteLine("");

            Console.WriteLine("                    *****************");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("        ****                                 ***");
            Console.WriteLine("      ***                                       ***");
            Console.WriteLine("     **           ***               ***           **");
            Console.WriteLine("   **           *******           *******          ***");
            Console.WriteLine("  **            *******           *******            **");
            Console.WriteLine(" **             *******           *******             **");
            Console.WriteLine(" **               ***               ***               **");
            Console.WriteLine("**                                                     **");
            Console.WriteLine("**       *                                     *       **");
            Console.WriteLine("**      **                                     **      **");
            Console.WriteLine(" **   ****                                     ****   **");
            Console.WriteLine(" **      **                                   **      **");
            Console.WriteLine(" **       ***                             ***       **");
            Console.WriteLine("  ***       ****                       ****       ***");
            Console.WriteLine("    **         ******             ******         **");
            Console.WriteLine("     ***            ***************            ***");
            Console.WriteLine("        ****                                 ****");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("                    *****************");

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
	}
}
