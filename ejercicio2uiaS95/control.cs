using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM9EJERCICIO4

{

    public static class Funciones
    {
        // Función para calcular factoriales de un arreglo
        public static void CalcularFactoriales(int[] numeros, int[] factoriales)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] >= 0)
                {
                    factoriales[i] = CalcularFactorial(numeros[i]);
                }
                else
                {
                    factoriales[i] = -1; // Indica que el factorial no se calcula para números negativos
                }
            }
        }

        // Función auxiliar que calcula el factorial de un solo número
        private static int CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;

            int resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}