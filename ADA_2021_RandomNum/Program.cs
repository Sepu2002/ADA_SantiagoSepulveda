using System;

namespace ADA_2021_RandomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int randnum;

            Random genAleatorio = new Random();

            randnum = genAleatorio.Next(1, 7);

            Console.WriteLine("Número Aleatorio: " + randnum);

            Console.WriteLine("               .........");
            Console.WriteLine("              :~, *   * ~,");
            Console.WriteLine("              : ~, *   * ~.");
            Console.WriteLine("              :  ~........~");
            Console.WriteLine("              : *:         :      ~'~,");
            Console.WriteLine("              :  :         :    ~' *  ~,");
            Console.WriteLine("              ~* :    *    : ,~' *    * ~,");
            Console.WriteLine("               ~,:         :.~,*    *  ,~ :");
            Console.WriteLine("                ~:.........::  ~, *  ,~   :");
            Console.WriteLine("                            : *  ~,,~  *  :");
            Console.WriteLine("                            :* * * :  *   :");
            Console.WriteLine("                             ~, *  : *  ,~");
            Console.WriteLine("                               ~,  :  ,~");
            Console.WriteLine("                                 ~,:,~");
           

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();
        }
    }
}
