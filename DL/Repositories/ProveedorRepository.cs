using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using Entidades;
using DL;
using System.Threading.Tasks;

namespace DL.Repositories
{
   public class ProveedorRepository:IProveedorRepository
    {

        private readonly Entities _context;

        public ProveedorRepository() {
            this._context = new Entities();
        }
        
        public IEnumerable<View_Proveedores> GetAll()
        {
            return _context.View_Proveedores.ToList();
        }

        public View_Proveedores GetProveedoresByCuit(string cuit)
        {
            return _context.View_Proveedores
                    .FirstOrDefault(x => x.Cuit ==cuit );

        }

        public IEnumerable<View_Proveedores> GetByRubro(string Rubro)
        {
            return _context.View_Proveedores.Where(x => x.RubroProveedor.Contains(Rubro.ToUpper())).ToList();
        }

        public IEnumerable<View_Proveedores> GetByRazon(string razon)
        {
            return _context.View_Proveedores.Where(x => x.Razon.Contains(razon.ToUpper())).ToList();
        }

        public IEnumerable<View_Proveedores> GetByNombre(string nombre )
        {
            return _context.View_Proveedores.Where(x => x.Nombre.Contains(nombre.ToUpper())).ToList();
        }

        public void DeleteProveedores(string cuit)
        {
            Proveedores proveedores = _context.Proveedores.Where(x=>x.Cuit==cuit).FirstOrDefault();
            _context.Proveedores.Remove(proveedores);
            _context.SaveChanges();
        }

        public void AddorUpdateProveedores(Proveedores Proveedor)
        {
            try
            {
                using (_context)
                {
                   
                        if (_context.Proveedores.FirstOrDefault(
                        x => x.IdProveedores == Proveedor.IdProveedores) != null)
                        {
                            _context.Proveedores.Attach(Proveedor);
                            _context.Entry(Proveedor).State = EntityState.Modified;
                         
                        }
                        else
                        {
                            _context.Proveedores.Add(Proveedor);


                        }
                        _context.SaveChanges();

                   
                   

                }

              
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

                
          
           
        }

        public IEnumerable<RubroProveedor> GetRubroProveedors()
        {
            return _context.RubroProveedor.ToList();
        }

        public IEnumerable<View_Proveedores> GetByCuit(string cuit)
        {
           return _context.View_Proveedores.Where(x => x.Cuit.Contains(cuit.ToUpper())).ToList();
        }

        public IEnumerable<Proveedores> GetProveedoresAsync()
        {
            throw new NotImplementedException();
        }

        public Proveedores GetProveedoresByName(string name)
        {
            return _context.Proveedores.Where(x => x.Nombre == name).FirstOrDefault();
        }

        public IEnumerable<string> GetProveedoresName()
        {
           return _context.Proveedores.Select(x=>x.Nombre).ToList();
        }

        public Proveedores GetProveedor(string cuit)
        {
            return _context.Proveedores.Where(x => x.Cuit == cuit).FirstOrDefault();
        }

        public bool DeleteRubroProveedor(int ID)
        {
            throw new NotImplementedException();
        }

        public Proveedores GetProveedorById(int ID)
        {
            return _context.Proveedores.Where(x=>x.IdProveedores==ID).FirstOrDefault();
        }

        public RubroProveedor AddorUpdateRubro(RubroProveedor rubroProveedor)
        {
            try
            {
                var Old = _context.RubroProveedor.Where(x => x.IDRubroProveedor == rubroProveedor.IDRubroProveedor).FirstOrDefault();
                if (Old!=null)
                {
                    _context.Entry(Old).State = EntityState.Detached;
                    _context.Entry(rubroProveedor).State = EntityState.Modified;
                }
                else
                {
                    _context.RubroProveedor.Add(rubroProveedor);
                }
                if (_context.SaveChanges()>0)
                {
                    return rubroProveedor;
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return rubroProveedor = null;
        }

        public RubroProveedor DeleteRubro(int ID)
        {
            RubroProveedor rubroProveedor = new RubroProveedor();
            try
            {
                rubroProveedor = _context.RubroProveedor.Where(x => x.IDRubroProveedor == ID).FirstOrDefault();
                _context.RubroProveedor.Remove(rubroProveedor);
                if (_context.SaveChanges() > 0)
                return rubroProveedor;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return rubroProveedor = null;

            
            
        }

        public RubroProveedor GetRubro(int ID)
        {
            return _context.RubroProveedor.Where(x => x.IDRubroProveedor == ID).FirstOrDefault();
        }

        public IEnumerable<View_Proveedores> GetProveedoresCuentaCorriente()
        {
            return _context.View_Proveedores.Where(x => x.CuentaCorriente == true).ToList();
        }
    }
}
