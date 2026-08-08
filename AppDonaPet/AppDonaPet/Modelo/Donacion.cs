using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Donacion
    {

        public int Id { get; set; }

        public Persona IdUsuario { get; set; }

        public decimal PesoDonado { get; set; }

        public int PuntosGenerados { get; set; }

        public string DescripcionMaterial { get; set; }

        public DateTime FechaDonacion { get; set; }


    }
}