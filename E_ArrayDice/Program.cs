using System;

namespace E_ArrayDice
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';

            do
            {
                int num = askint("Escribe el número de tiradas");
                int[] arra = new int[num];
                genArrayrand(ref arra);
                printArray(arra);
                cont = s_or_n();
            }
            while (cont == 's' || cont == 'S');

        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

        }
        static void genArrayrand(ref int[] arr)
        {
            Random genAleatorio = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = genAleatorio.Next(0, 7);
            }
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        static int findArrayValue(int[] arr, int find)
        {
            int i, count = 0;
            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == find)
                {
                    count++;
                }
            }
            return (count);

        }
        static void displayResults(int[] arr, int num)
        {
            Console.WriteLine("Rango\t\t Frecuencia\t\t Porcentaje\t |-----------------------------------------------| 50%");
            int bas = 0, top = 9;

            for (int i = 0; i < arr.Length; i++)
            {
                double perc = (arr[i] * 1.0 / num) * 100;
                int percut = Convert.ToInt32(perc);
                Console.Write("{0}, {1}\t\t {2}\t\t\t\t {3}%\t ", bas, top, arr[i], percut);


                barGraph(percut);
                Console.Write("\n");

                bas = bas + 10;
                top = top + 10;
            }
        }


    }
}
