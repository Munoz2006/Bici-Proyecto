using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entity
{
    internal class Stock
    {
        public string categoria_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string atributos_producto { get; set; }
        public int stock { get; set; }
        public double valor_producto { get; set; }
        public byte[] imagen { get; set; }
    }
}
