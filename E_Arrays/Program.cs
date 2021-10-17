using System;

namespace E_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            do
            {
                int[] arraya = new int[5], arrayb = new int[5], arrayc = new int[5];
                simpArray(ref arraya);
                printArray(arraya);
                askArrayint(ref arrayb);
                printArray(arrayb);
                genArrayrand(ref arrayc);
                printArray(arrayc);
                cont = s_or_n();
            }
            while (cont == 's' || cont == 'S');
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        static void printArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write("{0}  ", arr[i]);
            }
            
        }

        static void simpArray(ref int[] arraya) {
            for (int i = 0; i < arraya.Length; i++) {
                arraya[i] = i+1;
            }
        }

        static void askArrayint(ref int[] arrayb) {
            for (int i = 0; i < arrayb.Length; i++) {
                arrayb[i] = askint("Escriba un valor");
            }
        }

        static void genArrayrand(ref int[] arrayc) {
            Random genAleatorio = new Random();

            for (int i = 0; i < arrayc.Length; i++)
            {
                arrayc[i] = genAleatorio.Next(1, 100);
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
