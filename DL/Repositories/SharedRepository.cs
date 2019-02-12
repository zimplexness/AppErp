using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public class SharedRepository:ISharedRepository
    {
        private readonly Entities _context;

        public SharedRepository()
        {
            _context = new Entities();
        }

        public IEnumerable<EmpresasClientes> GetAfectadoEmpresa()
        {
            return _context.EmpresasClientes.ToList();
        }

        public IEnumerable<Choferes> GetChoferes()
        {
            return _context.Choferes.ToList();
        }

        public IEnumerable<Localidades> GetLocalidades()
        {
            return _context.Localidades.ToList();
        }

        public IEnumerable<Provincias> GetProvincias()
        {
            return _context.Provincias.ToList();
        }

        public IEnumerable<Zonas> GetZonas()
        {
            return _context.Zonas.ToList();
        }
    }
}
