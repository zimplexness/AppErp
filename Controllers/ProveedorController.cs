using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace Controllers
{
   public class ProveedorController
    {
        private readonly IProveedorRepository _proveedorRepository;
       
        public ProveedorController()
        {
            _proveedorRepository = new ProveedorRepository();
        }

       public  IEnumerable<View_Proveedores> GetProveedores() {
            try
            {
               
             var _Proveedores= _proveedorRepository.GetAll();
                return _Proveedores;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }

          

           

        }

        public IEnumerable<View_Proveedores> FilterByRazon(string razon) {
            try
            {
                return _proveedorRepository.GetByRazon(razon); 
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByNombre(string nombre)
        {
            try
            {
                return _proveedorRepository.GetByNombre(nombre);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByRubro(string Rubro)
        {
            try
            {
                return _proveedorRepository.GetByRubro(Rubro);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public IEnumerable<View_Proveedores> FilterByCuit(string cuit)
        {
            try
            {
                return _proveedorRepository.GetByCuit(cuit);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public View_Proveedores GetProveedor(string cuit) {
            return _proveedorRepository.GetProveedoresByCuit(cuit);

        }

        public IEnumerable< RubroProveedor> GetRubroProveedor() {

            return _proveedorRepository.GetRubroProveedors();
        }

        public void AddorUpdateProveedores(Proveedores proveedores) {
            try
            {
                _proveedorRepository.AddorUpdateProveedores(proveedores);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                
            }
               




        }

        public IEnumerable<Proveedores> GetProveedoresAsync()
        {
            try
            {

                var _Proveedores =_proveedorRepository.GetProveedoresAsync();
                return _Proveedores;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }





        }

        public Proveedores GetProveedorByName(string name) {

            return _proveedorRepository.GetProveedoresByName(name);

        }
        public IEnumerable<string> GetProveedoresName() {
        return  _proveedorRepository.GetProveedoresName();

        }
        public void DeleteProveedores(string cuit)
        {
            _proveedorRepository.DeleteProveedores(cuit);
        }

        public Proveedores GetProveedorObject(string cuit)
        {
            return _proveedorRepository.GetProveedor(cuit);
        }

        public Proveedores GetProveedorById(int ID)
        {
            return _proveedorRepository.GetProveedorById(ID);
        }

        public RubroProveedor AddorUpdateRubro(RubroProveedor rubroProveedor)
        {
            return _proveedorRepository.AddorUpdateRubro(rubroProveedor);
        }

        public RubroProveedor DeleteRubro(int ID)
        {
            return _proveedorRepository.DeleteRubro(ID);

        }

        public RubroProveedor GetRubro(int ID)
        {
            return _proveedorRepository.GetRubro(ID);
        }

        public IEnumerable<View_Proveedores> GetProveedoresCuentaCorriente()
        {
            return _proveedorRepository.GetProveedoresCuentaCorriente();
        }

    }
}
