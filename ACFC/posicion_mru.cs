using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ACFC
{
    class posicion_mru
    {
        static string SX;
        static string Sa;
        static string St;
        static string SXo;
        static string SVo;
        static double X;
        static double a;
        static double t;
        static double Xo;
        static double Vo;
        static string direccion = AppDomain.CurrentDomain.BaseDirectory;
        public static List<bool> result = new List<bool>();
        public static void Posicion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X = Xo + Vo · t + 1/2 · a · t^2\n");
            Console.WriteLine("¿Que incognita te falta?");
            Console.WriteLine("\n1. X (Posicion)\n2. Xo (Posicion inicial)\n3. Vo (Velocidad inicial)\n4. a (aceleracion)");
            Console.WriteLine("\nSelecciona el numero correspondiente: ");
            string inc = Console.ReadLine();

            Console.WriteLine("Ahora pediré los datos necesarios. El dato que desees calcular déjalo en blanco");
            Console.Write("\nIntroduce X (Posicion): ");
            SX = Console.ReadLine();
            Console.Write("\nIntroduce Xo (Posicion inicial): ");
            SXo = Console.ReadLine();
            Console.Write("\nIntroduce Vo (Velocidad inicial): ");
            SVo = Console.ReadLine();
            Console.Write("\nIntroduce t (Tiempo): ");
            St = Console.ReadLine();
            Console.Write("\nIntroduce a (Aceleracion): ");
            Sa = Console.ReadLine();

            result.Add(Double.TryParse(SX, out X));
            result.Add(Double.TryParse(SXo, out Xo));
            result.Add(Double.TryParse(SVo, out Vo));
            result.Add(Double.TryParse(St, out t));
            result.Add(Double.TryParse(Sa, out a));

            if (inc == "1" && result[1] == true && result[2] == true && result[3] == true && result[4] == true)
            {
                //X = Xo + Vo · t + 1/2 · a · t^2
                Console.WriteLine("Datos procesados satisfactoriamente");
                Console.WriteLine("\nX = " + Xo + " + " + Vo + " · " + t + " + 1/2 · " + a + " · " + Math.Pow(t, 2));
                Console.WriteLine("X = " + (Xo + (Vo * t) + (0.5d * a * Math.Pow(t, 2))));

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("X = " + Xo + " + " + Vo + " · " + t + " + 1/2 · " + a + " · " + Math.Pow(t, 2) + "\nX = " + (Xo + (Vo * t) + (0.5d * a * Math.Pow(t, 2))));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }

            else if (inc == "2" && result[0] == true && result[2] == true && result[3] == true && result[4] == true)
            {
                //Xo = X - (Vo * t) - (0,5 * a * t^2)
                Console.WriteLine("Datos procesados satisfactoriamente");
                Console.WriteLine("\nXo = " + X + " - " + Vo + " · " + t + " - 1/2 · " + a + " · " + Math.Pow(t, 2));
                Console.WriteLine("Xo = " + (X - (Vo * t) - (0.5d * a * Math.Pow(t, 2))));

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("Xo = " + X + " - " + Vo + " · " + t + " - 1/2 · " + a + " · " + Math.Pow(t, 2) + "\nXo = " + (X - (Vo * t) - (0.5d * a * Math.Pow(t, 2))));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }

            else if (inc == "3" && result[0] == true && result[1] == true && result[3] == true && result[4] == true)
            {
                //Vo = (X - Xo - 1/2 * a * t^2 ) / t
                Console.WriteLine("Datos procesados satisfactoriamente");
                Console.WriteLine("\nVo = (" + X + " - " + Xo + " - 1/2 " + " · " + a + " · " + Math.Pow(t, 2) + ") / " + t);
                Console.WriteLine("Vo = " + ((X - Xo - (0.5d * a * Math.Pow(t, 2))) / t));

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("Vo = (" + X + " - " + Xo + " - 1/2 " + " · " + a + " · " + Math.Pow(t, 2) + ") / " + t + "\nVo = " + ((X - Xo - (0.5d * a * Math.Pow(t, 2))) / t));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }

            else if (inc == "4" && result[0] == true && result[1] == true && result[2] == true && result[3] == true)
            {
                //a = (X - Xo - Vo · t) / 1/2 · t^2
                Console.WriteLine("Datos procesados satisfactoriamente");
                Console.WriteLine("\na = (" + X + " - " + Xo + " - " + Vo + " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2));
                Console.WriteLine("a = " + ((X - Xo - (Vo * t)) / (0.5d * Math.Pow(t, 2))));

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("a = (" + X + " - " + Xo + " - " + Vo + " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2) + "\na = (" + X + " - " + Xo + " - " + Vo + " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
            else
            {
                Console.WriteLine("Hubo un problema en el proceso: un valor de los que has introducido no es válido");
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Program.inicio();
            }
        }
    }
}
