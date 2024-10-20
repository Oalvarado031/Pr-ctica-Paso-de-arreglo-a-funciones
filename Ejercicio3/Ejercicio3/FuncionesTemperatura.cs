using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class FuncionesTemperatura
    {
        public void IngresarTemperaturas(List<double> temperaturas)
        {
            Console.Write("¿Cuántas temperaturas desea ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese la temperatura en Celsius #{i + 1}: ");
                double temp = double.Parse(Console.ReadLine());
                temperaturas.Add(temp);
            }
        }

        // Función para convertir a Fahrenheit
        public void ConvertirAFahrenheit(List<double> temperaturasCelsius, List<double> temperaturasFahrenheit)
        {
            temperaturasFahrenheit.Clear();  // Limpiar lista antes de agregar
            foreach (double temp in temperaturasCelsius)
            {
                double fahrenheit = (temp * 9 / 5) + 32;
                temperaturasFahrenheit.Add(fahrenheit);
            }
        }

        // Función para convertir a Kelvin
        public void ConvertirAKelvin(List<double> temperaturasCelsius, List<double> temperaturasKelvin)
        {
            temperaturasKelvin.Clear();  // Limpiar lista antes de agregar
            foreach (double temp in temperaturasCelsius)
            {
                double kelvin = temp + 273.15;
                temperaturasKelvin.Add(kelvin);
            }
        }

        // Función para mostrar temperaturas convertidas
        public void MostrarTemperaturas(List<double> temperaturas, string escala)
        {
            Console.WriteLine($"Temperaturas en {escala}:");
            for (int i = 0; i < temperaturas.Count; i++)
            {
                Console.WriteLine($"Temperatura #{i + 1}: {temperaturas[i]} {escala}");
            }
        }

        // Función para eliminar una temperatura
        public void EliminarTemperatura(List<double> temperaturas)
        {
            Console.WriteLine("Lista de temperaturas:");
            for (int i = 0; i < temperaturas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {temperaturas[i]}");
            }

            Console.Write("Ingrese el número de la temperatura que desea eliminar: ");
            int indiceEliminar = int.Parse(Console.ReadLine()) - 1;

            if (indiceEliminar >= 0 && indiceEliminar < temperaturas.Count)
            {
                temperaturas.RemoveAt(indiceEliminar);
                Console.WriteLine("Temperatura eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }

    }
}
