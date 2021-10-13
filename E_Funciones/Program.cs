using System;

namespace E_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, areal;
            Console.WriteLine("Hello World!");
            r = askdoub("Dame el valor del radio");
            h = askdoub("Dame el valor de la altura");
            areal = arealcyl(r,h);
            Console.WriteLine("El área  lateral de cilindro es {0}", areal);
            hold();
        }

        static double arealcyl(double r, double h) {
            double output;
            output = Math.PI * (r * 2)*h;
            return output;
        }

        static double askdoub(string mes) {
            double output;
            Console.WriteLine("{0}", mes);
            output= Convert.ToDouble(Console.ReadLine());
            return output;
        }

        static void hold() {
            Console.WriteLine("Programa exitoso");
            Console.WriteLine("<Presione Enter>");
            string hold = Console.ReadLine();

        }
    }
}
