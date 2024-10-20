using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4sem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tamaño del arreglo
            const int size = 5;
            int[] numeros = new int[size];
            int[] factoriales = new int[size];

            // Leer números
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            // Calcular factoriales usando una clase auxiliar
            control.Funciones.CalcularFactoriales(numeros, factoriales);

            // Mostrar resultados
            Console.WriteLine("\nNúmeros originales y sus factoriales:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Número: {numeros[i]}, Factorial: {factoriales[i]}");
            }
        }
    }
}