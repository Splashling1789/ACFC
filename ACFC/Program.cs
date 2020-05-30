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
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¡Bienvenido al asistente para calcular fórmulas comunes! (ACFC)\nCreado por Splashling (Javier Albero)\nVersion 0.6.0.0");
            inicio();
            
        }

        

        
       public static void inicio()
       {
           posicion_mru.result.Clear();
           velocidad_mru.result.Clear();
           Console.ForegroundColor = ConsoleColor.White;
           Console.WriteLine("\nSelecciona el tipo de fórmula:\n1. V = Vo + a · t (Fórmula de la velocidad)\n2. X = Xo + Vo · t + 1/2 · a · t^2 (Fórmula de la posición)\n3. c1^2 + c2^2 = h^2 (Teorema de pitágoras)");
           Console.WriteLine("\nEscribe el número correspondiente: ");
           string type = (Console.ReadLine());

            if (type == "1")
                velocidad_mru.Velocidad();
            else if (type == "2")
                posicion_mru.Posicion();
            else if (type == "3")
                pitagoras.Pitagoras();
            else
            {
                Console.WriteLine("\nError: No has puesto un número válido");
                inicio();
            }
       }
    }
}