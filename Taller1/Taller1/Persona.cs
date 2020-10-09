using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Identificacion { get; set; }
        public int Edad { get; set; }
        public bool EsCliente { get; set; }
        public DateTime FechaHoraRegistro { get; set; }
    }
}
