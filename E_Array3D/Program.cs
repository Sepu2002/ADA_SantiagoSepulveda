using System;

namespace E_Array3D
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            do {
                int numalum = askint("Escriba el número de alumnos");
                int numsem = askint("Escriba el número de semestres");
                int nummat = askint("Escriba el número de materias");
                int[,,] datos = new int[numalum+1, numsem+1, nummat+1];
                genArray3D(ref datos, numalum, numsem, nummat);
                hold("Arreglo generado exitosamente");
                print3DArray(datos, numalum, numsem, nummat);
                cont = s_or_n();
            }
            while (cont == 's'|| cont == 'S');


            
        }
        static void genArray3D(ref int[,,] arr, int x, int y, int z) {

            Random rand = new Random();
            int val = 0;
            for (int i = 1; i <= x; i++) {

                for (int j = 1; j <= y; j++) {
                    int sum = 0;
                    for (int k = 1; k <= z; k++) {

                        val = rand.Next(0, 101);
                        arr[i, j, k] = val;
                        sum = sum + val;
                    }
                    arr[i, j, 0] = sum / z;
                }
            }
        
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static void print3DArray(int[,,] arr, int x, int y, int z) {

            int promg = 0;
            for (int i = 1; i <= x; i++) {

                Console.WriteLine("Alumno {0,2} : ", i);
                for (int j = 1; j <= y; j++) {

                    Console.Write("Semestre {0,2} : ", j);
                    for (int k = 1; k <= z; k++) {

                        Console.Write(" {0,3} ", arr[i, j, k]);
                    }
                    Console.Write("\t Promedio = {0,3}", arr[i,j,0]);
                    Console.WriteLine("");
                    promg = promg + arr[i,j,0];
                }
            }
            promg = promg / y / z;
            Console.WriteLine("\n\t Promedio general de los {0,2} alumnos = {1,3}", x,promg);
        }
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        static void hold(string mes)
        {
            Console.WriteLine(mes);
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
    }
}
