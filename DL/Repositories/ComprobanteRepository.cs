using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DL;
using System.Data.Entity;

namespace DL.Repositories
{
   public class ComprobanteRepository : IComprobanteRepository
      {
        private readonly Entities _context;
        private Comprobantes _comprobantes;
        public ComprobanteRepository()
        {
            _context = new Entities();
            _comprobantes = new Comprobantes();

        }

        public void ActualizarEstadoComprobante(int Idcomprobante)
        {

            var Comprobante = _context.Comprobantes.Where(x => x.IdComprobante == Idcomprobante).FirstOrDefault();
             Comprobante.IdEstado = 1;
            _context.Comprobantes.Attach(Comprobante);
            _context.Entry(Comprobante).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Comprobantes AddOrUpdateComprobantes(Comprobantes comprobantes)
        {
            if (_context.Comprobantes.Where(x => x.IdProveedor == comprobantes.IdProveedor && x.Sucursal == comprobantes.Sucursal&& x.NoFactura == comprobantes.NoFactura).FirstOrDefault() != null)
            {
                _context.Comprobantes.Attach(comprobantes);
                _context.Entry(comprobantes).State = EntityState.Modified;


            }
            else
            {
                _context.Comprobantes.Add(comprobantes);
            }
            _context.SaveChanges();
            return comprobantes;




        }

        public void ActualizarComprobantes(Comprobantes comprobantes) {

            var _Comprobante = _context.Comprobantes.Where(x => x.IdComprobante == comprobantes.IdComprobante).ToList();
           
            foreach (var item in _Comprobante)
            {
                _context.Comprobantes.Attach(item);

                item.IIBB = comprobantes.IIBB;
                item.Retenciones = comprobantes.Retenciones;
                item.ConceptosNograbado = comprobantes.ConceptosNograbado;
                item.PercepcionIva = comprobantes.PercepcionIva;
                item.IdEstado = comprobantes.IdEstado;
                item.ImporteNeto = comprobantes.ImporteNeto;
                item.Importe = comprobantes.Importe;
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();


            }


         }


        public DetallesComprobanteArticulos AddorUpdateComprobantesArticulos(DetallesComprobanteArticulos detallesComprobanteArticulos)
        {
            try
            {
                var OLD = _context.DetallesComprobanteArticulos.Find(detallesComprobanteArticulos.idTable_DetallesComprobanteArticulos);
                if (OLD != null)
                {
                    _context.Entry(OLD).State = EntityState.Detached;

                    _context.Entry(detallesComprobanteArticulos).State = EntityState.Modified;


                }
                else
                {
                    _context.DetallesComprobanteArticulos.Add(detallesComprobanteArticulos);
                }
                if (_context.SaveChanges() > 0)
                    return detallesComprobanteArticulos;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return detallesComprobanteArticulos = null;
                





            
        }

        public IEnumerable<FacturasPendientesPago_Result> GetAllFacturasPedientes(int Idproveedor)
        {
            return _context.FacturasPendientesPago(Idproveedor);
        }

        public Articulos GetArticulosByName(string name)
        {
            return _context.Articulos.Where(x => x.Nombre == name).FirstOrDefault();
        }

        public IEnumerable<CentroCostos> GetCentroCostos()
        {
            return _context.CentroCostos.ToList();
        }

        public Comprobantes GetComprobantesByNofacuraProveedor(int IdProveedor, string Pventa, string Nofactura)
        {
            return _context.Comprobantes.Where(x => x.IdProveedor == IdProveedor && x.Sucursal == Pventa && x.NoFactura == Nofactura).FirstOrDefault();
        }

        public IEnumerable<CondicionesCompra> GetCondicionesCompra()
        {
            return _context.CondicionesCompra.ToList();
        }

        public IEnumerable<Contable> GetContable()
        {
            return _context.Contable.ToList();
        }

        public IEnumerable<SeleccionarDetalleComprobantesArticulos_Result> GetDetallesComprobanteArticulos(int IDcomprobantes)
        {
            return _context.SeleccionarDetalleComprobantesArticulos(IDcomprobantes);
        }

        public IEnumerable<string> GetNombresArticulo()
        {
            return _context.Articulos.Select(x => x.Nombre).ToList();
        }

        public IEnumerable<TiposComprobante> GetTiposComprobante()
        {
            return _context.TiposComprobante.ToList();
        }

        public IEnumerable<TiposFactura> GetTiposFactura()
        {
            return _context.TiposFactura.ToList();
        }

        public double TotalDetalleComprobanteConIva(int idComprobante)
        {
          
            var TotalNeto = _context.DetallesComprobanteArticulos.Where(x => x.IdComprobante == idComprobante).Select(x => x.Importe*x.Cantidad);
            var Importe = TotalNeto.Sum();


            return  Convert.ToDouble( Importe);

           
        }

        public double TotalDetalleComprobanteNeto(int idComprobante)
        {
            var TotalNeto = _context.DetallesComprobanteArticulos.Where(x => x.IdComprobante == idComprobante).Select(x => x.Precio * x.Cantidad);
            var Importe = TotalNeto.Sum();


            return Convert.ToDouble(Importe);
        }


        public void ActualizarEstado(int idcomprobante)
        {

            var comprobante = _context.Comprobantes.Where(x => x.IdComprobante == idcomprobante).ToList() ;
                
                foreach (var item in comprobante)
                {
                    _context.Comprobantes.Attach(item);
                     item.IdEstado = 1;
                    _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();

                }

            }

        public bool VerifyComprobantes(int Proveedor, string PuntoV, string NoFactura)
        {
            if (_context.Comprobantes.Where(x => x.IdProveedor == Proveedor && x.Sucursal == PuntoV && x.NoFactura == NoFactura).FirstOrDefault() != null)
            {
                return true;
            }
            else return false;
        }

        public Comprobantes GetComprobante(int Proveedor, string PuntoV, string NoFactura)
        {
            return _context.Comprobantes.Where(x => x.IdProveedor == Proveedor && x.Sucursal == PuntoV && x.NoFactura == NoFactura).FirstOrDefault();
        }

        public IEnumerable<DetallesComprobanteArticulos> GetALLDetallesComprobanteArticulos(int IdComprobante)
        {
            return _context.DetallesComprobanteArticulos.Where(x => x.IdComprobante == IdComprobante).Include(x=>x.Articulos).ToList();
          
        }

        public Comprobantes DeleteComprobante(int IDComprobante)
        {
            var comprobante = _context.Comprobantes.Where(x => x.IdComprobante == IDComprobante).FirstOrDefault();
            _context.Comprobantes.Remove(comprobante);
            _context.SaveChanges();
            return comprobante;
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantes(DateTime fecha1, DateTime fecha2)
        {
            try
            {
                return _context.GetAllComprobantesxFechas(fecha1,fecha2);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxProveedor(string Nombre, DateTime fecha1, DateTime fecha2)
        {
            var Comprobantes = _context.GetAllComprobantesxFechas(fecha1, fecha2);
           return Comprobantes.Where(x => x.NombreProveedor == Nombre).ToList();
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxFactura(string Puntov, string Nofactura, DateTime fecha1, DateTime fecha2)
        {

            var Comprobantes = _context.GetAllComprobantesxFechas(fecha1, fecha2);
            return Comprobantes.Where(x => x.Sucursal == Puntov && x.NoFactura==Nofactura).ToList();
        }

        public Comprobantes GetComprobanteById(int ID)
        {
            return _context.Comprobantes.Where(x => x.IdComprobante == ID).FirstOrDefault();
        }

        public IEnumerable<DetallesComprobanteArticulos> GetComprobantesArticulos(int ID)
        {
            return _context.DetallesComprobanteArticulos.Where(x => x.IdComprobante == ID).ToList();
        }

        public Comprobantes DeleteComprobantes(int ID)
        {
            Comprobantes comprobante = new Comprobantes();
            comprobante = _context.Comprobantes.Where(x => x.IdComprobante == ID).FirstOrDefault();

            _context.Comprobantes.Remove(comprobante);
            _context.SaveChanges();
            return comprobante;


        }
    }
}
