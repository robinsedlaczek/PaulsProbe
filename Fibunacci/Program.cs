using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibunacci
{
    class Program
    {
        public static int Fibunacci(int n)
        {
            int a = 1;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {
            Console.WriteLine("Willkommen! \n\nGeben Sie eine Zahl ein um alle Zahlen bis zu Ihrer \nEingabe der Fibunaccifolge anzeigen zu lassen.");
            Console.WriteLine("\nWas ist Ihre Eingabe?\n");

            string benutzer = Console.ReadLine();
            int eingabe = Convert.ToInt32(benutzer);

            Console.WriteLine("\nUnd los gehts:\n");

            for (int i = 0; i < eingabe; i++)
            {
                Console.WriteLine(Fibunacci(i));
            }

            Console.WriteLine("\nTaste drücken zum beenden!");

            Console.ReadKey();
        }
    }
}
