using System;

namespace E_Funciones2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numa, numb;
            char res;
            long facone, factwo;
            Random ran = new Random();
            do {
                Console.Clear();
                numa = askint("Escribe el primer número");
                numb = ran.Next(1,20);
                facone = factorial(numa);
                factwo = factorial(numb);
                Console.WriteLine("{0} y {1}", numa, numb);
                Console.WriteLine("Los factoriales de los números son: {0} y {1}", facone, factwo);


                res = s_or_n();
            }
            while (res == 's'|| res=='S');



            
        }
        //pedir int
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }

        //pedir int
        static int sum(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
                sum = sum + i;
            return sum;
        }
        //Elevar a una potencia
        static int pow(int num, int pot)
        {
            int ajust = 1;
            for (int i = 1; i <= pot; i++)
            {
                ajust = ajust * num;
            }
            return ajust;
        }

        static long factorial(int value) {
            long fact = 1;
            for (int i = 1; i <= value; i++)
                fact = fact * i;

            return fact;
        }
        //Wait
        static void hold()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
        static char s_or_n() {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
                return output;
        }
    }
}
