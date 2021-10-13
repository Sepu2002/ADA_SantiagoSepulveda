using System;

namespace E_Transportista
{
    class Program
    {
        static void Main(string[] args)
        {
            int mer, guad, mtr, oax;
            char cont = 's';
            mer = guad = mtr = oax = 0;
            do {
                Console.Clear();
                Central(ref mer, ref guad, ref mtr, ref oax);
                cont=s_or_n();
            }
            while (cont=='s'|| cont=='S');
            
        }
        static int askint(string mes)
        {
            int output;
            Console.WriteLine("{0}", mes);
            output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
        public static void Central(ref int mer, ref int guad, ref int mtr, ref int oax) {
            int bus = askint("Escriba el número de camiones:");
            int trip=askint("Escriba el número de viajes:");
            
            for (int i = 1; i <= bus; i++)
            {
                Destino(trip, i, ref mer, ref guad, ref mtr, ref oax);
                Console.WriteLine("");
                
            }
            Console.WriteLine("\nMérida\tGuadalajara\tMonterrey\tOaxaca");
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", mer, guad, mtr, oax);
        }
        public static void Destino(int via,int cam, ref int mer, ref int guad, ref int mtr, ref int oax) {
            int cas, merloc, guadloc, mtrloc, oaxloc;
            merloc = guadloc = mtrloc = oaxloc = 0;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Camión: {0}", cam);
            for (int i = 1; i <= via; i++)
            {
                Random genAleatorio = new Random();
                cas = genAleatorio.Next(1, 5);

                switch (cas)
                {
                    case 1:
                        Console.Write("Mérida\t");
                        mer++;
                        merloc++;
                        
                        break;
                    case 2:
                        Console.Write("Guadalajara\t");
                        guad++;
                        guadloc++;
                        break;
                    case 3:
                        Console.Write("Monterrey\t");
                        mtr++;
                        mtrloc++;
                        break;
                    case 4:
                        Console.Write("Oaxaca\t");
                        oax++;
                        oaxloc++;
                        break;
                }

            }
            Console.WriteLine("\nMérida\tGuadalajara\tMonterrey\tOaxaca");
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", merloc, guadloc, mtrloc, oaxloc);


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
