using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class DetallePedido
    {

        public int Id { get; set; }

        public Pedido IdPedido { get; set; }

        public Producto IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal SubTotal { get; set; }


    }
}