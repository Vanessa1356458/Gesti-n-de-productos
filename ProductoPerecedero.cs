using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestión_de_productos
{
    class ProductoPerecedero: Producto
    {
        public DateTime FechaExpiracion { get; set; }
    }
}
