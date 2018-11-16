using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public interface ISharedRepository
    {
        IEnumerable<Zonas> GetZonas();
        IEnumerable<Localidades> GetLocalidades();
        IEnumerable<Provincias> GetProvincias();
        IEnumerable<EmpresasClientes> GetAfectadoEmpresa();
        
    }
}
