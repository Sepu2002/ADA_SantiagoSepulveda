using System;

namespace E_RomanosLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, num;
            int uni, dec, cent, um;
            Console.WriteLine("Programa que convierte un número a notación romana: ");
            Console.WriteLine("Escribe un número entre 1 y 3999:");
            max = Convert.ToInt32(Console.ReadLine());
            num = 1;

            for (int i = 0; i < max; i++) {
                um = (num / 1000) % 10;
                cent = (num / 100) % 10;
                dec = (num / 10) % 10;
                uni = num % 10;

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Número: {0}  {1}  {2}  {3} \t\t\t \n", um, cent, dec, uni);
               


                switch (um)
                {
                    case 1:
                        Console.Write("M ");
                        break;
                    case 2:
                        Console.Write("MM ");
                        break;
                    case 3:
                        Console.Write("MMM ");
                        break;
                    default:
                        Console.Write(" ");
                        break;
                }



                switch (cent)
                {
                    case 1:
                        Console.Write("C ");
                        break;
                    case 2:
                        Console.Write("CC ");
                        break;
                    case 3:
                        Console.Write("CCC ");
                        break;
                    case 4:
                        Console.Write("CD ");
                        break;
                    case 5:
                        Console.Write("D ");
                        break;
                    case 6:
                        Console.Write("DC ");
                        break;
                    case 7:
                        Console.Write("DCC ");
                        break;
                    case 8:
                        Console.Write("DCCC ");
                        break;
                    case 9:
                        Console.Write("CM ");
                        break;
                }




                switch (dec)
                {
                    case 1:
                        Console.Write("X ");
                        break;
                    case 2:
                        Console.Write("XX ");
                        break;
                    case 3:
                        Console.Write("XXX ");
                        break;
                    case 4:
                        Console.Write("XL ");
                        break;
                    case 5:
                        Console.Write("L ");
                        break;
                    case 6:
                        Console.Write("LX ");
                        break;
                    case 7:
                        Console.Write("LXX ");
                        break;
                    case 8:
                        Console.Write("LXXX ");
                        break;
                    case 9:
                        Console.Write("XC ");
                        break;
                }



                switch (uni)
                {
                    case 1:
                        Console.Write("I ");
                        break;
                    case 2:
                        Console.Write("II ");
                        break;
                    case 3:
                        Console.Write("III ");
                        break;
                    case 4:
                        Console.Write("IV ");
                        break;
                    case 5:
                        Console.Write("V ");
                        break;
                    case 6:
                        Console.Write("VI ");
                        break;
                    case 7:
                        Console.Write("VII ");
                        break;
                    case 8:
                        Console.Write("VIII ");
                        break;
                    case 9:
                        Console.Write("IX ");
                        break;
                }
                num++;
            }
            Console.WriteLine("\t\t\t ");
            Console.WriteLine(" \t\t\t\t\t\t\t ");


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
            Console.WriteLine("  SSL               *****************");

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
