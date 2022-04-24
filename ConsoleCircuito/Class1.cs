using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCircuito
{
    internal class Class1
    {
        int r1, r2, r3, r4, rx, ry, Ve;
        double i1, i2, determinante;

        private double calcularVoltaje()
        {
            // Calculo de resistencias equivalentes
            rx = r1 + r3;
            ry = r2 + r3 + r4;

            // Calculo del determinante
            determinante = (rx - ry) - Math.Pow(r3, 2);

            // Calculo de las corrientes
            i1 = (Ve * ry) / determinante;
            i2 = (r3 * Ve) / determinante;

            // Calculo del voltaje
            return r4 * i2;
        }
    }
}
