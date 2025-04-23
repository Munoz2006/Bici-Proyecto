using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.controllers
{
    internal class StockController
    {
        public void CargarProductos(string categoria = null)
        {
            List<Stock> productos = Producto.ObtenerProductos(categoria);
            vista.MostrarProductos(productos);
        }
    }
}
