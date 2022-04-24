using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCircuito
{
    internal class Program
    {
        static int r1, r2, r3, r4, rx, ry, Ve;
        static double Vab, i1, i2, determinante;

        static void Main(string[] args)
        {
            r1 = 1;
            r2 = 1;
            r3 = 2;
            r4 = 3;
            Ve = 5;

            Console.WriteLine("Teniendo el circuito de la imagen anexa, calcular el voltaje ab (Vab)\n\n");
            
            Console.WriteLine("El valor del voltaje es: " + calcularVoltaje() + " V");

            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
            System.Diagnostics.Process.Start("image.jpg");

            // Makes the program wait for a key press and it prevents the screen until a key is pressed.
            Console.ReadKey();
        }

        private static double calcularVoltaje()
        {
            // Calculo de resistencias equivalentes
            rx = r1 + r3;
            ry = r2 + r3 + r4;

            // Calculo del determinante
            determinante = (rx - ry) - Math.Pow(r3, 2);

            // Calculo de las corrientes
            i1 = (Ve * ry) / determinante;
            i2 = (r3 * Ve) / determinante;

            Console.WriteLine(i2);
            // Calculo del voltaje
            return (r4 * i2);
        }
    }
}
