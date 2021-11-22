using System;
using System.IO;

namespace E_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            StreamWriter objgrabar = new StreamWriter("ssl.txt", true);
            Console.Write("Texto a guardar: ");
            dato = Console.ReadLine();
            objgrabar.WriteLine(dato);
            objgrabar.Close();
            Console.WriteLine("Registro guardado exitosamente, presione <enter> para continuar\n");
            Console.ReadKey();

            StreamReader objleer = new StreamReader("ssl.txt");
            dato = objleer.ReadLine();
            while (dato != null) {
                Console.WriteLine(dato);
                dato = objleer.ReadLine();
            }
            objleer.Close();
            Console.WriteLine("\n Presione <enter> para terminar");
            Console.ReadLine();
        }
    }
}
