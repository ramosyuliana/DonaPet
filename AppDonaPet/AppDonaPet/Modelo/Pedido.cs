using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Pedido
    {

        public int Id { get; set; }

        public Persona IdUsuario { get; set; }

        public MetodoPago IdMetodoPago { get; set; }

        public DateTime FechaPedido { get; set; }

        public decimal TotalBruto { get; set; }

        public decimal TotalDescuento { get; set; }

        public decimal TotalNeto { get; set; }

        public string Estado { get; set; }

        public Descuento IdDescuento { get; set; }

    }
}