using System;
using Dominio;
using Persistencia;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorioEmpleado _repoEmpleado = 
        new RepositorioEmpleado(new Persistencia.AplicacionContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Ejecutando Instrucción!");
            //addEmpleado();
            //updateEmpleado();
            //Console.WriteLine("Empleado Actualizado");
            //deleteEmpleado();
            //Console.WriteLine("Empleado Eliminado");
            //addCliente();
            //Console.WriteLine("Cliente Registrado");
            //UpdateCliente();
            //Console.WriteLine("Cliente Actualizado");
            //deleteCliente();
            //Console.WriteLine("Cliente Eliminado");
            //addEmpresa();
            //Console.WriteLine("Empresa Registrada");
            UpdateEmpresa();
            Console.WriteLine("Empresa Actualizada");
            //deleteEmpresa();
            //Console.WriteLine("Empresa Eliminada");


        }

        private static void addEmpleado(){
            var empleado = new Empleado{
                Nombre = "Gabriel",
                Codigo_Empleado = 1004
            };
            _repoEmpleado.AddEmpleado(empleado);
        }

        private static void updateEmpleado(){
            var empleado = new Empleado{
                Id = 1,
                Nombre = "Victor",
                Codigo_Empleado = 1002
            };
            _repoEmpleado.UpdateEmpleado(empleado);
        }

        private static void deleteEmpleado(){
            _repoEmpleado.DeleteEmpleado(3);            
        }


        private static IRepositorioCliente _repoCliente = 
        new RepositorioCliente(new Persistencia.AplicacionContext());

        private static void addCliente(){
            var cliente = new Cliente{
                Nombre = "Juan Carlos",
                Codigo_Cliente = 10002
            };
            //_repoEmpleado.AddCliente(cliente);
            _repoCliente.AddCliente(cliente);
        }

        private static void UpdateCliente(){
            var Cliente = new Cliente{
                Id = 1,
                Nombre = "Victor",
                Codigo_Cliente = 10002
            };
            //_repoEmpleado.UpdateEmpleado(empleado);
            _repoCliente.UpdateCliente(Cliente);
        }

        private static void deleteCliente(){
            //_repoEmpleado.DeleteEmpleado(3);
            _repoCliente.DeleteCliente(3) ;           
        }
            
        private static IRepositorioEmpresa _repoEmpresa = 
        new RepositorioEmpresa(new Persistencia.AplicacionContext());
        
        private static void addEmpresa(){
            var empresa = new Empresa{
                Nombre_Empresa = "GASES DE ANTIOQUIA",
                Nit_Empresa = 811010242
            };
            //_repoEmpleado.AddCliente(cliente);
            _repoEmpresa.AddEmpresa(empresa);
        }

        private static void UpdateEmpresa(){
            var empresa = new Empresa{
                Id = 3,
                Nombre_Empresa = "Gases de Antioquia",
                Nit_Empresa = 811010245
            };
            //_repoEmpleado.UpdateEmpleado(empleado);
            _repoEmpresa.UpdateEmpresa(empresa);
        }

        private static void deleteEmpresa(){
            //_repoEmpleado.DeleteEmpleado(3);
            _repoEmpresa.DeleteEmpresa(3) ;           
        }
        


    }
}
