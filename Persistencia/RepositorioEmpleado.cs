using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpleado(AplicacionContext appContext){
            _appContext = appContext;

        }
        public Empleado AddEmpleado(Empleado empleado)
        {
            var new_Empleado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return new_Empleado.Entity;
        }

            public bool DeleteEmpleado(int idEmpleado)
        {
           var Empleado_eliminado = _appContext.Empleados.FirstOrDefault(
               p => p.Id    == idEmpleado
           );

           if (Empleado_eliminado == null)
           return false;
           _appContext.Remove(Empleado_eliminado);
           _appContext.SaveChanges();
           return true;
           
        }

        public Empleado DetailEmpleado(int IdEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(p => p.Id == IdEmpleado);
        }

        public IEnumerable<Empleado> ListEmpleados()
        {
            return _appContext.Empleados;
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var Empleado_encontrado = _appContext.Empleados.FirstOrDefault(
                p => p.Id == empleado.Id
            );

            if (Empleado_encontrado != null){
                Empleado_encontrado.Nombre = empleado.Nombre;
                Empleado_encontrado.Codigo_Empleado = empleado.Codigo_Empleado;
                _appContext.SaveChanges();                
            }
            return Empleado_encontrado;
        }
    }
}