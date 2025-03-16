using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_productos
{
    public class SinExistenciaException : Exception
    {
        public SinExistenciaException(string message) : base(message) { }
    }
    class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public string Descripcion { get; set; }

        public void Vender(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("La cantidad debe ser un entero positivo.");
            }
            if (cantidad>Existencia)
            {
                throw new SinExistenciaException($"No hay suficiente existencia de {Nombre}. Existencia disponible: {Existencia}");
            }
            Existencia -= cantidad;
            Console.WriteLine($"Venta realizada: {cantidad} unidades de {Nombre}. Existencia restante: {Existencia}");
        }
    }
}
