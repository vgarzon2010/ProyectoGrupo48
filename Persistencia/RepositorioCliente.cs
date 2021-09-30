using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AplicacionContext _appContext;

        public RepositorioCliente(AplicacionContext appContext){
            _appContext = appContext;

        }
        public Cliente AddCliente(Cliente cliente)
        {
            var new_Cliente = _appContext.clientes.Add(cliente);
            _appContext.SaveChanges();
            return new_Cliente.Entity;
        }

            public bool DeleteCliente(int idCliente)
        {
           var Cliente_eliminado = _appContext.clientes.FirstOrDefault(
               p => p.Id    == idCliente
           );

           if (Cliente_eliminado == null)
           return false;
           _appContext.Remove(Cliente_eliminado);
           _appContext.SaveChanges();
           return true;
           
        }

        public Cliente DetailCliente(int IdCliente)
        {
            return _appContext.clientes.FirstOrDefault(p => p.Id == IdCliente);
        }

        public IEnumerable<Cliente> ListClientes()
        {
            return _appContext.clientes;
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var Cliente_encontrado = _appContext.clientes.FirstOrDefault(
                p => p.Id == cliente.Id
            );

            if (Cliente_encontrado != null){
                Cliente_encontrado.Nombre = cliente.Nombre;
                Cliente_encontrado.Codigo_Cliente = cliente.Codigo_Cliente;
                _appContext.SaveChanges();                
            }
            return Cliente_encontrado;
        }
        
    }
}