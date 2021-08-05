using System;
using System.Collections.Generic;
using System.Text;

namespace LUCKY.Models
{
    public class ClasVentas
    {
        public int idPuntoVenta { get; set; }
        public string nombrePuntoV { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string image { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
    }
}
