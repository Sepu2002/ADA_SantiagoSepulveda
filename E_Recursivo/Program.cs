using System;

namespace E_Recursivo
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
        public static void menu()
        {
            int parejas = 0;
            Console.WriteLine("1- Fibonacci");
            Console.WriteLine("2- Factorial");
            Console.WriteLine("3- Sumatoria N ");
            int selec = askint("Seleccione el método ");
            
            if (selec == 1)
            {
                int num = askint("Escriba el número de meses para determinar el número de parejas de conejos:");
                parejas = Fibonacci_rec(num);
                Display(parejas);
            }
            if(selec ==2)
            {
                int num = askint("Escriba un número para obtener su factorial");
                long res=Factorial(num);
                Display(res);
            }
            if (selec == 3) {
                int num = askint("Escriba un número para obtener su sumatoria");
                long res = SumN(num);
                Display(res);
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
        public static long Factorial(int num) {
            if (num == 0)
            {
                return 1;
            }
            else {
                Console.Write(" {0} * ", num);
                return num * Factorial(num - 1);
            }
        }
        public static long SumN(int num) {
            if (num == 0)
            {
                Console.Write(" {0} ", num);
                return 0;
            }
            else {
                Console.Write(" {0} + ", num);
                return num + SumN(num - 1);
            }
        }
        public static void Datos()
        {
            Console.WriteLine("Ingeniería Mecatrónica");
            Console.WriteLine("Analisis y diseño de Algoritmos");
            Console.WriteLine("Santiago Sepúlveda Landeros");
            Console.WriteLine("0212496");

        }
        static void hold()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
        public static void Display(long ans)
        {
            Console.WriteLine(" = {0}", ans);
        }
    }
}
