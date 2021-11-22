using System;

namespace SepulvedaSantiagoParcial2
{
    class Program
    {
        static void Main(string[] args)
        {
            char cont = 's';
            int n = 0;
            int[] arr = new int[1000];
            int targ = askint("Escriba el número a buscar:");
            do
            {
                opciones(n, targ);
                int opt=askint("Selecione una operación:");
                menu(opt, ref n, ref arr, targ);
                cont = s_or_n();
            }
            while (cont == 'S' || cont == 's');
            hold();
        }

        static char s_or_n()
        {
            Console.WriteLine("");
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        static void menu(int selec, ref int n, ref int[] arr, int targ) {
            switch (selec)
            {

                case 1:
                    Random rand = new Random();
                    n = rand.Next(1, 1000);
                    Console.WriteLine("El número generado es {0}", n);
                    break;

                case 2:
                    int found= buscRef(n, targ);
                    Console.WriteLine("");
                    Console.WriteLine("El número '3' se encontró en {0} números", found);
                    break;

                case 3:
                    buscRefArr(n, ref arr, targ);
                    break;

                case 4:
                    printArray(arr);
                    break;

                case 5:
                    Console.WriteLine("En número a buscar es {0}", targ);
                    int x = askint("Escribia un número para verficar si contiene el número");
                    int encontrado = checkforNum(x, targ);
                    Console.WriteLine("El número '{1}' aparece {0} veces", encontrado, targ);
                    break;
            
            
            }
        
        }
        static void opciones(int n, int targ) {
            Console.Clear();
            Console.WriteLine("En número actual es {0}", n);
            Console.WriteLine("En número a buscar es {0}", targ);
            Console.WriteLine("1-Calcular y mostrar el número N aleatorio calculado.");
            Console.WriteLine("2-Indicar mediante el uso de una FUNCIÓN la cantidad de números de 1 a N que contienen el dígito de referencia.");
            Console.WriteLine("3-Construir un MÉTODO que guarde en un ARREGLO de enteros, cuando el dígito SÍ se encuentre en el número.");
            Console.WriteLine("4- Mostrar mediante un MÉTODO el ARREGLO de los números que contienen al dígito.");
            Console.WriteLine("5-Diseñar una FUNCIÓN que indique si un número X, que proporcione el usuario, contiene el dígito solicitado. ");

        }
        static int buscRef(int n, int targ) {
            int apar = 0;
            for (int i = 1; i <= n; i++) {
                int uni = i % 100;
                int dec = i % 10;
                int cent = i / 100;
                if (uni == targ || dec == targ || cent == targ) {
                    //Console.Write("{0} ",i);
                    apar++;
                }
            }
            return apar;
        }
        static void buscRefArr(int n, ref int[] arr, int targ) {
            for (int i = 1; i <= n; i++)
            {
                int uni = i % 100;
                int dec = i % 10;
                int cent = i / 100;
                if (uni == targ || dec == targ || cent == targ)
                {
                    arr[i - 1] = i;
                    
                }
            }
            
        }
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write("{0}  ", arr[i]);
                }
            }

        }
        static int checkforNum(int n, int targ) {
            string str = n.ToString();
            int[] decom = new int[str.Length+1];
            for (int i = 0; i < str.Length; i++) {
                decom[i] = n % 10;
                n = n/10;
            }
            int apar = 0;
            for (int i = 0; i < str.Length; i++) {
                if (decom[i] == targ) {
                    apar++;
                }
            }
            printArray(decom);
            return apar;
            
        }
        static void hold()
        {
            Console.WriteLine("                    *****************");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("        ****                                 ***");
            Console.WriteLine("      ***                                       ***");
            Console.WriteLine("     **           ***               ***           **");
            Console.WriteLine("   **           *******           *******          ***");
            Console.WriteLine("  **            *******           *******            **");
            Console.WriteLine(" **             *******           *******             **");
            Console.WriteLine(" **               ***               ***               **");
            Console.WriteLine("**                                                     **");
            Console.WriteLine("**       *                                     *       **");
            Console.WriteLine("**      **                                     **      **");
            Console.WriteLine(" **   ****                                     ****   **");
            Console.WriteLine(" **      **                                   **      **");
            Console.WriteLine(" **       ***                             ***       **");
            Console.WriteLine("  ***       ****                       ****       ***");
            Console.WriteLine("    **         ******             ******         **");
            Console.WriteLine("     ***            ***************            ***");
            Console.WriteLine("        ****                                 ****");
            Console.WriteLine("           ****                           ****");
            Console.WriteLine("               ******               ******");
            Console.WriteLine("                    *****************");

            Console.WriteLine("¡Muchas grácias!");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();
        }

        }
    }
