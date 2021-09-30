using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpresa(AplicacionContext appContext){
            _appContext = appContext;

        }
        public Empresa AddEmpresa(Empresa empresa)
        {
            var new_Empresa = _appContext.empresas.Add(empresa);
            _appContext.SaveChanges();
            return new_Empresa.Entity;
        }

        public bool DeleteEmpresa(int idEmpresa)
        {
           var Empresa_eliminado = _appContext.empresas.FirstOrDefault(
               p => p.Id    == idEmpresa
           );

           if (Empresa_eliminado == null)
           return false;
           _appContext.Remove(Empresa_eliminado);
           _appContext.SaveChanges();
           return true;
           
        }

        public Empresa DetailEmpresa(int IdEmpresa)
        {
            return _appContext.empresas.FirstOrDefault(p => p.Id == IdEmpresa);
        }

        public IEnumerable<Empresa> ListEmpresa()
        {
            return _appContext.empresas;
        }

        public Empresa UpdateEmpresa(Empresa empresa)
        {
            var Empresa_encontrado = _appContext.empresas.FirstOrDefault(
                p => p.Id == empresa.Id
            );

            if (Empresa_encontrado != null){
                Empresa_encontrado.Nit_Empresa = empresa.Nit_Empresa;
                Empresa_encontrado.Nombre_Empresa = empresa.Nombre_Empresa;
                _appContext.SaveChanges();                
            }
            return Empresa_encontrado;
        }
    }
}