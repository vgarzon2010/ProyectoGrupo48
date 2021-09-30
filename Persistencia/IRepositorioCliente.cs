using System.Runtime.Serialization;
using System;
using Dominio;
using System.Collections.Generic;


namespace Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> ListClientes();
        
        Cliente AddCliente(Cliente cliente);

        Cliente UpdateCliente(Cliente cliente);

         Boolean DeleteCliente(int IdCliente);

         Cliente DetailCliente(int IdCliente);
         
    }
}