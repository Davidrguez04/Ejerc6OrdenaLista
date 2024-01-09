using Ejerc6OrdenaLista.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc6OrdenaLista.Servicios
{
    internal interface InterfazDarAlta
    {
        public void darAltaCliente(List<ClienteDto> listaClientes);

        public void comproClientes(List<ClienteDto> listaClientes);

    }
        
}
