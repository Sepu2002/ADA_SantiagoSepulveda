using System;

namespace E_Arrays2D
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            do {
                int alum = askint("Escriba el número de alumnos:");
                int mat = askint("Escriba el número de materias:");
                int[,] arra = new int[mat,alum];
                genArrayrand2D(ref arra);
                printArray2D(arra, mat, alum);



                cont = s_or_n();
            }
            while (cont=='s'||cont=='s');
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
        static void genArrayrand2D(ref int[,] arr)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(10, 101);
            }
        }
        static void printArray2D(int[,] arr, int x, int y) {
            for (int i = 0; i < y; i++)
            {
                Console.Write("Alumno {0}: ", i+1);
                for (int j = 0; j < x; j++)
                {
                    Console.Write("{0} ", arr[j, i]);
                }
                double promedio = averArray(arr, i);
                Console.Write("\t Promedio {0}", promedio);
                Console.Write("\n");
            }

        }
        static double averArray(int[,] arr, int line) {

            int sum = 0;
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                sum = sum + arr[j,line]; 
            }
            double prom = sum/ arr.GetLength(0);
            return prom;
        }
    }
}
