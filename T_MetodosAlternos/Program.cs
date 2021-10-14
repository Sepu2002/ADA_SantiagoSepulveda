using System;

namespace T_MetodosAlternos
{
    class Program
    {
        static void Main(string[] args)
        {
            char check = 's';
            do {
                Console.Clear();
                Menu();
                check = s_or_n();
            }
            while (check == 's'|| check == 'S' );

        }
        public static void Menu()
        {
            Console.WriteLine("1-Cálculadora Factorial");
            Console.WriteLine("2-Sumatoria N");
            Console.WriteLine("3-Cálculadora Fibonacci");
            int selec = askint("Seleccione una operación: ");
            

            switch (selec) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Cálculadora Factorial");
                    Console.WriteLine("1-Recursivo");
                    Console.WriteLine("2-Iterativo");
                    int metfac = askint("Seleccione un método: ");
                    if (metfac == 1)
                    {
                        int n = askint("Escriba un número: ");
                        long resf = Factorial(n);
                        Console.Write(" = {0}\n", resf);
                    }
                    else {
                        int n = askint("Escriba un número: ");
                        long resf = Factorialit(n);
                        Console.Write(" = {0}\n", resf);
                    }

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Sumatoria N");
                    Console.WriteLine("1-Recursivo");
                    Console.WriteLine("2-Iterativo");
                    int metsum = askint("Seleccione un método");
                    if (metsum == 1)
                    {
                        int n = askint("Escriba un número: ");
                        long resf = SumN(n);
                        Console.Write(" = {0}\n", resf);

                    }
                    else {
                        int n = askint("Escriba un número: ");
                        long resf = SumN(n);
                        Console.Write(" = {0}\n", resf);
                    }

                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Cálculadora Fibonacci");
                    Console.WriteLine("1-Recursivo");
                    Console.WriteLine("2-Iterativo");
                    int metfib = askint("Seleccione un método:");
                    if (metfib == 1)
                    {
                        int n = askint("Escriba un número: ");
                        long resf = Fibonacci(n);
                        Console.Write(" = {0}\n", resf);
                    }
                    else {

                        int n = askint("Escriba un número: ");
                        Fibonaccit(n);
                        

                    }
                    break;
            
            }

        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        public static long Factorial(int num)
        {
            if (num == 0|| num == 1)
            {
                Console.Write("1");
                return 1;
            }
            else
            {
                Console.Write("{0} * ", num);
                return num * Factorial(num - 1);
            }
        }
        public static long Factorialit(int num) {
            long n = 1;
            for (int i = num; i >= 1; i--) {
                if (i == 1||i==0)
                {
                    Console.Write("1");
                }
                
                else
                {
                    Console.Write("{0} * ", i);
                    n = n * i;
                }
            }
            return n;
        }
        public static long SumN(int num)
        {
            if (num == 0)
            {
                Console.Write(" {0} ", num);
                return 0;
            }
            else
            {
                Console.Write(" {0} + ", num);
                return num + SumN(num - 1);
            }
        }
        public static long SumNit(int num) {
            long n = 1;
            for (int i = num; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0} * ", i);
                    n = n + i;
                }
            }
            return n;

        }
        public static int Fibonacci(int n)
        {


            if ((n == 0) || (n == 1))
            {
                return n;

            }
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public static void Fibonaccit(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1} ", a, b);
            for (int i = 2; i < len + 1; i++)
            {
                c = a + b;
                Console.Write("{0} ", c);
                a = b;
                b = c;
            }
        }
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }


    }
}
