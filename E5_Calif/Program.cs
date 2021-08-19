using System;

namespace E5_Calif
{
    class Program
    {
        static void Main(string[] args)
        {
            double ex, tar, inv, calif;
            double exp, tarp, invp;
            Console.WriteLine("Programa que calcula las notas del curso de computación");
            Console.WriteLine("Criterios de evaluación:");
            Console.WriteLine("Examen ----------> 50%");
            Console.WriteLine("Tarea -----------> 30%");
            Console.WriteLine("Investigación ---> 20%");
            Console.WriteLine("");

            Console.WriteLine("Escriba su calificación de examen");
            ex = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Examen:" + ex);

            Console.WriteLine("Escriba su calificación de tarea");
            tar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tarea:" + tar);

            Console.WriteLine("Escriba su calificación de la investigación");
            inv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Investigación:" + inv);

            exp = (ex * 0.5);
            tarp = (tar * 0.3);
            invp = (inv * 0.2);
            calif = exp + tarp + invp;

            Console.WriteLine("");

            Console.WriteLine("Ponderaciones:");
            Console.WriteLine("Examen ----------> " + exp);
            Console.WriteLine("Tarea -----------> " + tarp);
            Console.WriteLine("Investigación ---> " + invp);
            Console.WriteLine("Calificación final: " + calif);

            Console.WriteLine("");
           

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

            Console.WriteLine("Programa exitoso, oprima <enter> ");
            string espera = Console.ReadLine();


        }
    }
}
