using System;

namespace E_ConejosFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos();
            menu();
            hold();
        }

        public static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        public static void menu() {
            int parejas = 0;
            Console.WriteLine("1- Recursivo");
            Console.WriteLine("2- Lista");
            int selec = askint("Seleccione el método ");
            int num = askint("Escriba el número de meses para determinar el número de parejas de conejos:");
            if (selec == 1)
            {
                parejas = Fibonacci_rec(num);
                Display(parejas);
            }
            else
            {
                Fibonacci_list(num);
            }
        }
        public static int Fibonacci_rec(int n)
        {
           

            if ((n == 0) || (n == 1))
            {
                return n;
                
            }
            else
                return Fibonacci_rec(n - 1) + Fibonacci_rec(n - 2);
        }
        public static void Fibonacci_list(int len) {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i <= len+1; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
        }
        public static void Display(int ans) {
            Console.WriteLine("{0} parejas de conejos", ans);
        }
        public static void Datos() {
            Console.WriteLine("Ingeniería Mecatrónica");
            Console.WriteLine("Analisis y diseño de Algoritmos");
            Console.WriteLine("Santiago Sepúlveda Landeros");
            Console.WriteLine("0212496");

        }
        static void hold()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("   ***");
            Console.WriteLine("  ** **");
            Console.WriteLine(" **   **         ****");
            Console.WriteLine(" **   **       **   ****");
            Console.WriteLine(" **  **       *   **   **");
            Console.WriteLine("  **  *      *  **  ***  **");
            Console.WriteLine("   **  *    *  **     **  *");
            Console.WriteLine("    ** **  ** **        **");
            Console.WriteLine("    **   **  **");
            Console.WriteLine("   *           *");
            Console.WriteLine("  *             *");
            Console.WriteLine(" *    0     0    *");
            Console.WriteLine(" *   |   @   |   *");
            Console.WriteLine(" *   |__| |__|   *");
            Console.WriteLine("   *     W     *");
            Console.WriteLine("     **     ** ");
            Console.WriteLine("       *****");
            Console.WriteLine("");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
    }
}
