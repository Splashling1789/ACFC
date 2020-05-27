using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace ACFC
{
    public class Program
    {
        static string SV;
        static string SVo;
        static string SX;
        static string Sa;
        static string St;
        static string SXo;
        static double V;
        static double Vo;
        static double X;
        static double a;
        static double t;
        static double Xo;
        static string direccion = AppDomain.CurrentDomain.BaseDirectory;
        static List<bool> Vresult = new List<bool>();
        static List<bool> Xresult = new List<bool>();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¡Bienvenido al asistente para calcular fórmulas comunes! (ACFC)\nCreado por Splashling (Javier Albero)\nVersion 0.5.0.0");
            inicio();
            
        }

        static void Velocidad()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("V = Vo + a · t\n");
            Console.WriteLine("¿Que incógnita te falta?");
            Console.WriteLine("\n1. V (Velocidad)\n2. Vo (Velocidad inicial)\n3. a (Aceleracion)\n4. t (Tiempo)");
            Console.WriteLine("\nSelecciona el número correspondiente: ");
            string Vinc = Console.ReadLine();

            Console.WriteLine("Ahora pediré los datos necesarios. El dato que desees calcular puede ser cualquier número");
            Console.Write("\nIntroduce V (Velocidad): ");
            SV = Console.ReadLine();
            Console.Write("\nIntroduce Vo (Velocidad inicial): ");
            SVo = Console.ReadLine();
            Console.Write("\nIntroduce a (Aceleracion): ");
            Sa = Console.ReadLine();
            Console.Write("\nIntroduce t (Tiempo): ");
            St = Console.ReadLine();

            Vresult.Add(Double.TryParse(SV, out V));
            Vresult.Add(Double.TryParse(SVo, out Vo));
            Vresult.Add(Double.TryParse(St, out t));
            Vresult.Add(Double.TryParse(Sa, out a));

            if (Vinc == "1" && Vresult[1] == true && Vresult[2] == true && Vresult[3] == true)
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
                inicio();
            }
            else if(Vinc == "2" && Vresult[0] == true && Vresult[2] == true && Vresult[3] == true)
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
                inicio();
            }
            else if (Vinc == "3" && Vresult[0] == true && Vresult[1] == true && Vresult[2] == true)
            {
                Console.WriteLine("Datos procesados satisfactoriamente");

                Console.WriteLine("a = (" + V + " - " + Vo + ") / " + t);
                Console.WriteLine("\na = " + ((V - Vo)/t));
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("a = (" + V + " - " + Vo + ") / " + t + "\na = " + ((V - Vo) / t));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                inicio();
            }
            else if (Vinc == "4" && Vresult[0] == true && Vresult[1] == true && Vresult[3] == true)
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
                inicio();
            }
            else
            {
                Console.WriteLine("Hubo un problema en el proceso: un valor de los que has introducido no es un numero valido");
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                inicio();
            }
        }

        static void Posicion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X = Xo + Vo · t + 1/2 · a · t^2\n");
            Console.WriteLine("¿Que incognita te falta?");
            Console.WriteLine("\n1. X (Posicion)\n2. Xo (Posicion inicial)\n3. Vo (Velocidad inicial)\n4. a (aceleracion)");
            Console.WriteLine("\nSelecciona el numero correspondiente: ");
            string Xinc = Console.ReadLine();

            Console.WriteLine("Ahora pediré los datos necesarios. El dato que desees calcular puede ser cualquier número");
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

            Xresult.Add(Double.TryParse(SX, out X));
            Xresult.Add(Double.TryParse(SXo, out Xo));
            Xresult.Add(Double.TryParse(SVo, out Vo));
            Xresult.Add(Double.TryParse(St, out t));
            Xresult.Add(Double.TryParse(Sa, out a));

            if(Xinc == "1" && Xresult[1] == true && Xresult[2] == true && Xresult[3] == true && Xresult[4] == true)
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
                inicio();
            }

            else if (Xinc == "2" && Xresult[0] == true && Xresult[2] == true && Xresult[3] == true && Xresult[4] == true)
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
                inicio();
            }

            else if (Xinc == "3" && Xresult[0] == true && Xresult[1] == true && Xresult[3] == true && Xresult[4] == true)
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
                inicio();
            }

            else if (Xinc == "4" && Xresult[0] == true && Xresult[1] == true && Xresult[2] == true && Xresult[3] == true)
            {
                //a = (X - Xo - Vo · t) / 1/2 · t^2
                Console.WriteLine("Datos procesados satisfactoriamente");
                Console.WriteLine("\na = (" + X + " - " + Xo + " - " + Vo +  " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2));
                Console.WriteLine("a = " + ((X - Xo - (Vo * t) ) / (0.5d * Math.Pow(t, 2))));

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(direccion, "Historial.txt"), true))
                {
                    outputFile.WriteLine("a = (" + X + " - " + Xo + " - " + Vo + " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2) + "\na = (" + X + " - " + Xo + " - " + Vo + " · " + t + ") " + "/ 1/2 · " + Math.Pow(t, 2));
                }
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                inicio();
            }
            else
            {
                Console.WriteLine("Hubo un problema en el proceso: un valor de los que has introducido no es válido");
                Console.WriteLine("\nPulsa enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                inicio();
            }
        }
       static void inicio()
       {
           Xresult.Clear();
           Vresult.Clear();
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("\nSelecciona el tipo de fórmula:\n1. V = Vo + a · t (Fórmula de la velocidad)\n2. X = Xo + Vo · t + 1/2 · a · t^2 (Fórmula de la posición)");
           Console.WriteLine("\nEscribe el número correspondiente: ");
           string type = (Console.ReadLine());

           if (type == "1")
                Velocidad();
           else if (type == "2")
                Posicion();
           else
           {
               Console.WriteLine("\nError: No has puesto un número válido");
               inicio();
           }
       }
    }
}