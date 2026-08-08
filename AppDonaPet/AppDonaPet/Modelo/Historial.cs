using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Historial
    {

        public int Id { get; set; }

        public Persona IdUsuario { get; set; }

        public string TipoMovimiento { get; set; }

        public int CantidadPuntos { get; set; }

        public string Descripcion { get; set; }

        public int IdOrigen { get; set; }

        public DateTime FechaMovimiento { get; set; }
    }
}