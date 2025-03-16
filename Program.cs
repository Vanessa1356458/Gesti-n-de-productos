using Gestión_de_productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_productos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>
        {
            new ProductoPerecedero
            {
                Nombre = "Leche",
                Precio = 2.50m,
                Existencia = 10,
                Descripcion = "Leche entera en cartón",
                FechaExpiracion = new DateTime(2023, 12, 31)
            },
            new Producto
            {
                Nombre = "Arroz",
                Precio = 1.20m,
                Existencia = 50,
                Descripcion = "Arroz blanco de grano largo"
            },
            new ProductoPerecedero
            {
                Nombre = "Yogur",
                Precio = 1.00m,
                Existencia = 20,
                Descripcion = "Yogur natural",
                FechaExpiracion = new DateTime(2023, 11, 15)
            }
        };

            try
            {
                Console.WriteLine("Seleccione un producto para vender:");
                for (int i = 0; i < productos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {productos[i].Nombre} (Existencia: {productos[i].Existencia})");
                }

                Console.Write("Ingrese el número del producto: ");
                int seleccion = int.Parse(Console.ReadLine());

                if (seleccion < 1 || seleccion > productos.Count)
                {
                    Console.WriteLine("Error: Selección no válida.");
                    return;
                }

                Producto productoSeleccionado = productos[seleccion - 1];

                Console.Write("Ingrese la cantidad a vender: ");
                int cantidad = int.Parse(Console.ReadLine());

                productoSeleccionado.Vender(cantidad);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: La entrada debe ser un número entero.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (SinExistenciaException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Gracias por su compra.");
            }
        }
    }
}
