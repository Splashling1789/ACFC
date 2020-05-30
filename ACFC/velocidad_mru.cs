using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACFC
{
    class velocidad_mru
    {
        static string SV;
        static string SVo;
        static string Sa;
        static string St;
        static double V;
        static double Vo;
        static double t;
        static double a;
        static string direccion = AppDomain.CurrentDomain.BaseDirectory;
        public static List<bool> result = new List<bool>();
        public static void Velocidad()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("V = Vo + a · t\n");
            Console.WriteLine("¿Que incógnita te falta?");
            Console.WriteLine("\n1. V (Velocidad)\n2. Vo (Velocidad inicial)\n3. a (Aceleracion)\n4. t (Tiempo)");
            Console.WriteLine("\nSelecciona el número correspondiente: ");
            string inc = Console.ReadLine();

            Console.WriteLine("Ahora pediré los datos necesarios. El dato que desees calcular déjalo en blanco");
            Console.Write("\nIntroduce V (Velocidad): ");
            SV = Console.ReadLine();
            Console.Write("\nIntroduce Vo (Velocidad inicial): ");
            SVo = Console.ReadLine();
            Console.Write("\nIntroduce a (Aceleracion): ");
            Sa = Console.ReadLine();
            Console.Write("\nIntroduce t (Tiempo): ");
            St = Console.ReadLine();

            result.Add(Double.TryParse(SV, out V));
            result.Add(Double.TryParse(SVo, out Vo));
            result.Add(Double.TryParse(St, out t));
            result.Add(Double.TryParse(Sa, out a));

            if (inc == "1" && result[1] == true && result[2] == true && result[3] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("V = " + Vo + " + " + a + " · " + t);
                Console.WriteLine("\nV = " + (Vo + (a * t)));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("V = " + Vo + " + " + a + " · " + t + "\nV = " + Vo + a * t + "\n");
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            else if (inc == "2" && result[0] == true && result[2] == true && result[3] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("Vo = " + V + " - " + a + " · " + t);
                Console.WriteLine("\nVo = " + (V + (-a * t)));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("Vo = " + V + " - " + a + " · " + t + "\nVo = " + V + (-a * t));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            else if (inc == "3" && result[0] == true && result[1] == true && result[2] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("a = (" + V + " - " + Vo + ") / " + t);
                Console.WriteLine("\na = " + ((V - Vo) / t));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("a = (" + V + " - " + Vo + ") / " + t + "\na = " + ((V - Vo) / t));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            else if (inc == "4" && result[0] == true && result[1] == true && result[3] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("t = (" + V + " - " + Vo + ") / " + a);
                Console.WriteLine("\nt = " + ((V - Vo) / a));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("t = (" + V + " - " + Vo + ") / " + a + "\nt = " + ((V - Vo) / a));
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
