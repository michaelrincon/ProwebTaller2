using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class PersonaLogica
    {

        List<Persona> listaPersonas = new List<Persona>();

        public void guardarPersona(string Nombre, string Apellido, int Identificacion,int Edad, bool EsCliente,DateTime FechaRegistro )
        {
            Persona personaNueva = new Persona();
            personaNueva.Nombre = Nombre;
            personaNueva.Apellido = Apellido;
            personaNueva.Edad = Edad;
            personaNueva.EsCliente = EsCliente;
            personaNueva.Identificacion = Identificacion;
            personaNueva.FechaHoraRegistro = FechaRegistro;
            listaPersonas.Add(personaNueva);
        }

        public List<Persona> getLista()
        {
            return listaPersonas;
        }

        
    }

   
}
