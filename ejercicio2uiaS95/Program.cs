using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2uiaS95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            Console.Write("¿Cuántos productos desea agregar al inventario? ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad en stock: ");
                int cantidad = int.Parse(Console.ReadLine());

                inventario.AgregarProducto(nombre, precio, cantidad);
            }

            // Ejemplo de actualización y cálculo del valor total
      
            decimal valorTotal = inventario.CalcularValorTotal();
            Console.WriteLine($"El valor total del inventario es: ${valorTotal}");

            // Esperar una tecla antes de cerrar
            Console.ReadKey();
        }
    }
}
