using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppDonaPet.Modelo
{
    public class Persona
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Documento { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Correo { get; set; }

        public string Contraseña { get; set; }

        public int PuntosDisponibles { get; set; }

        public Rol IdRol { get; set; }

    }
}