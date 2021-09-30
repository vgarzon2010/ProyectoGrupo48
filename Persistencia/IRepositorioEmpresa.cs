using System.Runtime.Serialization;
using System;
using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<Empresa> ListEmpresa();
        
        Empresa AddEmpresa(Empresa empresa);

         Empresa UpdateEmpresa(Empresa empresa);

         Boolean DeleteEmpresa(int IdEmpresa);

         Empresa DetailEmpresa(int IdEmpresa);
         
    }
}