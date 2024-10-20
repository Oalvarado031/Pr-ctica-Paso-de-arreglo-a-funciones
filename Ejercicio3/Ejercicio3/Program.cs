using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia de la clase FuncionesTemperaturas
            FuncionesTemperatura funciones = new FuncionesTemperatura();

            // Lista para almacenar las temperaturas en Celsius
            List<double> temperaturasCelsius = new List<double>();
            List<double> temperaturasFahrenheit = new List<double>();
            List<double> temperaturasKelvin = new List<double>();

            bool continuar = true;

            while (continuar)
            {
                // Llamamos a la función para ingresar las temperaturas en Celsius
                funciones.IngresarTemperaturas(temperaturasCelsius);

                // Convertimos las temperaturas a Fahrenheit y Kelvin
                funciones.ConvertirAFahrenheit(temperaturasCelsius, temperaturasFahrenheit);
                funciones.ConvertirAKelvin(temperaturasCelsius, temperaturasKelvin);

                // Mostramos las temperaturas convertidas
                funciones.MostrarTemperaturas(temperaturasFahrenheit, "Fahrenheit");
                funciones.MostrarTemperaturas(temperaturasKelvin, "Kelvin");

                // Preguntar si el usuario desea eliminar alguna temperatura convertida
                Console.WriteLine("¿Desea eliminar alguna temperatura convertida? (S/N)");
                string respuestaEliminar = Console.ReadLine().ToUpper();
                if (respuestaEliminar == "S")
                {
                    Console.WriteLine("¿De cuál lista desea eliminar? (1. Fahrenheit, 2. Kelvin)");
                    int listaEliminar = int.Parse(Console.ReadLine());
                    if (listaEliminar == 1)
                    {
                        funciones.EliminarTemperatura(temperaturasFahrenheit);
                    }
                    else if (listaEliminar == 2)
                    {
                        funciones.EliminarTemperatura(temperaturasKelvin);
                    }
                }

                // Preguntar si desea continuar ingresando temperaturas
                Console.WriteLine("¿Desea continuar ingresando temperaturas? (S/N)");
                string respuesta = Console.ReadLine().ToUpper();
                continuar = respuesta == "S";
            }
        }

    }
}
