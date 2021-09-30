using System.Runtime.Serialization;
using System;
using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> ListEmpleados();
        
        Empleado AddEmpleado(Empleado empleado);

         Empleado UpdateEmpleado(Empleado empleado);

         Boolean DeleteEmpleado(int IdEmpleado);

         Empleado DetailEmpleado(int IdEmpleado);


    }
}