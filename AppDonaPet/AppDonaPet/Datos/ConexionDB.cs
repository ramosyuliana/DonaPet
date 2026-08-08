using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppDonaPet.Datos
{
    public class ConexionDB
    {

        private static readonly string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;


        public static SqlConnection MtAbrirConexion()
        {
            if (string.IsNullOrEmpty(cadena))
            {
                throw new Exception("No se pudo conectar");
            }
            return new SqlConnection(cadena);
        }
    }
}