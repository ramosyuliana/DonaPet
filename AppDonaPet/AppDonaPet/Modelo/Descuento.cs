using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Descuento
    {

        public int Id { get; set; }

        public string Titulo { get; set; }

        public string TipoDescuento { get; set; }

        public decimal Valor { get; set; }

        public int CostoPuntos { get; set; }

        public string Estado { get; set; }

    }
}