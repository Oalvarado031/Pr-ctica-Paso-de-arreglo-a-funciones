using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Ventas
    {
        // Función para ingresar las ventas de los 7 días.
        public void IngresarVentas(double[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write($"Ingrese la venta del día {i + 1}: ");
                ventas[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        // Función para calcular el total de ventas.
        public double CalcularTotalVentas(double[] ventas)
        {
            double total = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];
            }
            return total;
        }

        // Función para encontrar el día con la venta más alta.
        public int EncontrarDiaMaxVenta(double[] ventas)
        {
            int diaMax = 0;
            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > ventas[diaMax])
                {
                    diaMax = i;
                }
            }
            return diaMax;
        }

    }
}
