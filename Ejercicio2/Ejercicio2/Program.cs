using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia de la clase de FuncionesVentas para acceder a sus métodos.
            Ventas funciones = new Ventas();

            // Definimos un arreglo estático para almacenar las ventas de los 7 días de la semana.
            double[] ventas = new double[7];

            // Llamamos a la función para ingresar las ventas diarias.
            funciones.IngresarVentas(ventas);

            // Calculamos el total de las ventas.
            double totalVentas = funciones.CalcularTotalVentas(ventas);
            Console.WriteLine($"El total vendido en la semana es: {totalVentas} C$");

            // Encontramos el día con la venta más alta.
            int diaMaxVenta = funciones.EncontrarDiaMaxVenta(ventas);
            Console.WriteLine($"El día con la venta más alta es: \nDía {diaMaxVenta + 1} con {ventas[diaMaxVenta]} C$");
        }

    }
}
