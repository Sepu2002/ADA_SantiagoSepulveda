using System;

namespace E_Romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int uni, dec, cent, um;
            Console.WriteLine("Programa que convierte un número a notación romana: ");
            Console.WriteLine("Escribe un número entre 1 y 3999:");
            num = Convert.ToInt32(Console.ReadLine());


            um = (num / 1000) % 10;
            cent = (num / 100) % 10;
            dec = (num / 10) % 10;
            uni = num % 10;

            Console.Write("Número        :  \t  ");
            Console.Write("{0}  {1}  {2}  {3} \t\t\t \n", um, cent, dec, uni);
            Console.Write(" \t\t\t\t\t\t\t \n");


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
                    Console.Write("ValorNOválido ");
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
                    Console.Write("I");
                    break;
                case 2:
                    Console.Write("II");
                    break;
                case 3:
                    Console.Write("III");
                    break;
                case 4:
                    Console.Write("IV");
                    break;
                case 5:
                    Console.Write("V");
                    break;
                case 6:
                    Console.Write("VI");
                    break;
                case 7:
                    Console.Write("VII");
                    break;
                case 8:
                    Console.Write("VIII");
                    break;
                case 9:
                    Console.Write("IX");
                    break;
            }
            Console.WriteLine("\t\t\t ");
            Console.WriteLine(" \t\t\t\t\t\t\t ");


            Console.WriteLine(" \n\n");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Presione <Enter> para salir . . . . ");
            string salir = Console.ReadLine(); Console.WriteLine("Adios!");



        }
    }
        }




            /*if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");*/
        