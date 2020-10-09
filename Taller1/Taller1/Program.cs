using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PersonaLogica logica = new PersonaLogica();
            bool control = true;
            bool escliente = true;
            List<Persona> lista = new List<Persona>();
            string nombre;
            string apellido;
            Int32 identificacion;
            Int32 edad;
            string cliente;
            DateTime fecha;
            int cont;



            while (control)
            {
                Console.WriteLine(" TALLER 1 .NET\n 1.Nueva Persona\n 2.Listar Personas\n 3.Salir");
                Int32 opcion = Int32.Parse(Console.ReadLine());
                cont = 0;
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("BIENVENIDO\nDigite los siguientes datos: \n Nombre\n Apellido\n Identificacion\n Edad\n Es cliente? SI/NO\n");
                        nombre = Console.ReadLine();
                        apellido = Console.ReadLine();
                        identificacion = Int32.Parse(Console.ReadLine());
                        edad = Int32.Parse(Console.ReadLine());
                        cliente = Console.ReadLine();

                        if (cliente.Equals("SI"))
                        {
                             escliente = true;
                        }
                        if(cliente.Equals("NO"))
                        {
                            escliente = false;
                        }
                        fecha = DateTime.Now;
                        logica.guardarPersona(nombre, apellido, identificacion, edad, escliente, fecha);
                        break;
                    case 2:
                        lista = logica.getLista();
                        foreach (var persona in lista)
                        {
                            cont++;
                            Console.WriteLine(" Nombre persona "+cont +": "+persona.Nombre);
                            Console.WriteLine(" Apellido persona " + cont + ": " + persona.Apellido);
                            Console.WriteLine(" Identificación persona " + cont + ": " + persona.Identificacion);
                            Console.WriteLine(" Edad persona " + cont + ": " + persona.Edad);
                            if (persona.EsCliente)
                            {
                                Console.WriteLine(" Es Cliente");
                            }
                            else
                            {
                                Console.WriteLine(" Es Proveedor");
                            }
                            Console.WriteLine(persona.FechaHoraRegistro);
                            Console.WriteLine("-----------------------------------------------------------\n");

                        }
                        break;
                    case 3:
                        control = false;
                        break;
                }
            }
            
        }
    }
}
