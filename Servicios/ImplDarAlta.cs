using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejerc6OrdenaLista.Dtos;

namespace Ejerc6OrdenaLista.Servicios
{
    internal class ImplDarAlta:InterfazDarAlta
    {
        public void darAltaCliente(List<ClienteDto> listaClientes)
        {
            ClienteDto nuevoCliente = crearNuevoCliente();

            //Esto es para controlar si el Id que introduce el cliente ya esta en uso
            foreach (ClienteDto cliente2 in listaClientes)
            {
                if (cliente2.IdCLiente.Equals(nuevoCliente.IdCLiente))
                {

                    Console.WriteLine("Introduzca otro id ya que este ya esta en uso: ");
                    nuevoCliente.IdCLiente = Convert.ToInt64(Console.ReadLine());


                    break;
                }
                else
                {
                    break;
                }
            }

            listaClientes.Add(nuevoCliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            /*Console.WriteLine("Intoduzca el id: ");
            nuevoCliente.Id = Convert.ToInt64(Console.ReadLine());
            */


            Console.WriteLine("Introduzca el id:");
            nuevoCliente.IdCLiente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca nombre:");
            nuevoCliente.NombreCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca sus apellidos:");
            nuevoCliente.ApellidosCliente = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Introduzca su edad:");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;
        }

        public void comproClientes(List<ClienteDto>listaClientes)
        {
            ClienteDto cliente= new ClienteDto();

            foreach(ClienteDto cliente2 in listaClientes)
            {
                int clientes = 0;
                clientes++;

                do {

                    Console.WriteLine("\n\tNo tiene mas de 3 o 3 clientes registrados: ");
                    cliente = crearNuevoCliente();

                } while (clientes > 3);
                
            }

        }

    }
}
