using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACFC
{
    public class pitagoras
    {
        static string direccion = AppDomain.CurrentDomain.BaseDirectory;
        public static List<bool> result = new List<bool>();
        static string Sc1;
        static string Sc2;
        static string Sh;
        static double c1;
        static double c2;
        static double h;
        static double c;
        public static void Pitagoras()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("c1^2 + c2^2 = h^2");
            Console.WriteLine("\n¿Qué incógnita te falta?");
            Console.WriteLine("\n1. h (Hipotenusa)\n2. c (Cateto cualquiera)");
            string inc = Console.ReadLine();

            Console.WriteLine("Ahora pediré los datos necesarios. El dato que desees calcular déjalo en blanco");
            Console.Write("1. h (Hipotenusa)");
            Sh = Console.ReadLine();
            Console.Write("2. c1 (Primer cateto)");
            Sc1 = Console.ReadLine();
            Console.Write("1. c2 (Segundo cateto)");
            Sc2 = Console.ReadLine();

            result.Add(Double.TryParse(Sh, out h));
            result.Add(Double.TryParse(Sc1, out c1));
            result.Add(Double.TryParse(Sc2, out c2));

            if(inc == "1" && result[1] == true && result[2] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine(Math.Pow(c1, 2) + " + " + Math.Pow(c2, 2) + " = " + "h^2");
                Console.WriteLine("h = " + (Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2))));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine(Math.Pow(c1, 2) + " + " + Math.Pow(c2, 2) + " = " + "h^2" + "\nh = " + (Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2))) + "\n");
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            if (inc == "2" && result[0] == true && (result[2] == true || result[1] == true))
            {
                if (result[1] == true && result[2] == false)
                    c = c1;
                else if (result[1] == false && result[2] == true)
                    c = c2;
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("c^2 = " + Math.Pow(h, 2) + " - " + Math.Pow(c, 2));
                Console.WriteLine("c = " + (Math.Sqrt(Math.Pow(h, 2) - Math.Pow(c, 2))));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("c^2 = " + Math.Pow(h, 2) + " - " + Math.Pow(c, 2) + "\nc = " + (Math.Sqrt(Math.Pow(h, 2) - Math.Pow(c, 2))) + "\n");
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            else
            {
                Console.WriteLine("Hubo un problema en el proceso: un valor de los que has introducido no es un numero valido");
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
        }
    }
}
