using System;
using System.IO;


namespace E_ArchivosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            string[] palabras = new string[5];
            char[] separador = { ',' };
            int[,] numeros = new int[100, 5];
            int indice = 0;
            int color = 0; int numero = 0;
            char cont = 's';

            do {

                menu(ref dato, ref numero, separador, ref palabras, ref numeros, indice, color);

                cont=s_or_n();
            }
            while (cont=='s'||cont=='S');

            

        }
        static void genDatos(ref string dato, ref int numero) {
            Random aleatorio = new Random();
            // ENTRADA Graba un dato tipo cadena en el archivo prueba.txt
            StreamWriter objgrabar = new StreamWriter("numeros.txt", true);
            Console.WriteLine("Se generan los valores automáticamente, el primer número es el color ");
            //dato = Console.ReadLine();
            dato = "";
            dato = dato + aleatorio.Next(1, 3) + ',';
            for (int contador = 2; contador <= 5; contador++)
            {
                numero = aleatorio.Next(0, 100);
                if (contador < 5)
                    dato = dato + numero + ',';
                else
                    dato = dato + numero;
            }
            objgrabar.WriteLine(dato);
            objgrabar.Close();
            
        }
        static void showDatos(ref string dato, char[] separador, ref string[] palabras, ref int[,] numeros, int indice, int color) {
            StreamReader objleer = new StreamReader("numeros.txt");
            dato = objleer.ReadLine();
            while (dato != null)
            {
                Console.WriteLine(dato);
                palabras = dato.Split(separador);
                numeros[indice, 0] = Convert.ToInt32(palabras[0]);
                numeros[indice, 1] = Convert.ToInt32(palabras[1]);
                numeros[indice, 2] = Convert.ToInt32(palabras[2]);
                numeros[indice, 3] = Convert.ToInt32(palabras[3]);
                numeros[indice, 4] = Convert.ToInt32(palabras[4]);
                indice++;
                dato = objleer.ReadLine();
            }
            objleer.Close();
            Console.WriteLine();
            Console.WriteLine("El texto en el archivo es el siguiente : \n");
            // Salida del arreglo de numeros
            Console.WriteLine("Los números en el arreglo son : \n");
            for (int cont = 0; cont < indice; cont++)
            {
                color = numeros[cont, 0];
                if (color == 1)
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;
                for (int columna = 1; columna < 5; columna++)
                {
                    Console.Write("{0,3}", numeros[cont, columna]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
   
        }
        static void menu(ref string dato, ref int numero, char[] separador, ref string[] palabras, ref int[,] numeros, int indice, int color) {
            Console.Clear();
            Console.WriteLine("1- Genrar números y meterlos a un archivo");
            Console.WriteLine("2- Leer y desplegar los números del archivo");
            int selec = askint("Seleccione una operación:");
            switch (selec) {
                case 1:
                    genDatos(ref dato, ref numero);
                    break;
                case 2:
                    showDatos(ref dato, separador, ref palabras, ref numeros, indice, color);
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
        static char s_or_n()
        {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("¿Quieres continuar? (s/n) <enter>");
            char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
    }
}
