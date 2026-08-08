using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Producto
    {

        public int Id { get; set; }

        public string CodigoProducto { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string Estado { get; set; }

        public string Imagen { get; set; }

        public int LimiteVenta { get; set; }

        public Categoria IdCategoria { get; set; }
    }
}