using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2uiaS95
{
    internal class productos
    { 
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public productos(string nombre, decimal precio, int cantidad)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }
    }

    public class Inventario
    {
        private Dictionary<string, productos> productos = new Dictionary<string, productos>();

        public void AgregarProducto(string nombre, decimal precio, int cantidad)
        {
            if (productos.ContainsKey(nombre))
            {
                Console.WriteLine($"El producto '{nombre}' ya existe en el inventario.");
            }
            else
            {
                productos[nombre] = new productos(nombre, precio, cantidad);
                Console.WriteLine($"Producto '{nombre}' añadido al inventario.");
            }
        }

        public void ActualizarStock(string nombre, int nuevaCantidad)
        {
            if (productos.ContainsKey(nombre))
            {
                productos[nombre].Cantidad = nuevaCantidad;
                Console.WriteLine($"Cantidad del producto '{nombre}' actualizada a {nuevaCantidad}.");
            }
            else
            {
                Console.WriteLine($"El producto '{nombre}' no se encuentra en el inventario.");
            }
        }

        public decimal CalcularValorTotal()
        {
            decimal total = 0;
            foreach (var producto in productos.Values)
            {
                total += producto.Precio * producto.Cantidad;
            }
            return total;
        }
    }
}
