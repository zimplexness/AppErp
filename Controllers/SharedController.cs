using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace Controllers
{
  public  class SharedController
    {

        private readonly SharedRepository sharedRepository;
        public SharedController()
        {
            sharedRepository = new SharedRepository();
        }


        public IEnumerable<EmpresasClientes> GetAfectadoEmpresa()
        {
            return sharedRepository.GetAfectadoEmpresa();
        }

        public IEnumerable<Localidades> GetLocalidades()
        {
            return sharedRepository.GetLocalidades();
        }

        public IEnumerable<Provincias> GetProvincias()
        {
            return sharedRepository.GetProvincias();
        }

        public IEnumerable<Zonas> GetZonas()
        {
            return sharedRepository.GetZonas();
        }
        public IEnumerable<Choferes> GetChoferes()
        {
            return sharedRepository.GetChoferes();
        }

    }
}
