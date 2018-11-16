using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace DL.Repositories
{
    public class PagoRepository : IPagosRepository
        {

        private readonly Entities _context;
        private Pagos _Pagos;
        private DetallePago _DetallePago;
        private DetalleMediosPagos _DetalleMediosPagos;
        private Retenciones _Retenciones;

        public PagoRepository()
        {
            _context = new Entities();
            _Pagos = new Pagos();
            _DetallePago = new DetallePago();
            _DetalleMediosPagos = new DetalleMediosPagos();
            _Retenciones = new Retenciones();
        }

        public DetalleMediosPagos AddorUpdateMediosPagos(DetalleMediosPagos detalleMediosPagos)
        {
            try
            {
                if (_context.DetalleMediosPagos.Any(x=>x.IdDetalleMedioPago==detalleMediosPagos.IdDetalleMedioPago)==true)
                {
                    _context.DetalleMediosPagos.Attach(detalleMediosPagos);
                    _context.Entry(detalleMediosPagos).State = EntityState.Modified;
                }
                else
                {
                    _context.DetalleMediosPagos.Add(detalleMediosPagos);

                }
                _context.SaveChanges();
                return detalleMediosPagos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public Pagos AddorUpdatePagos(Pagos pagos)
        {
            try
            {
                if (_context.Pagos.Any(x=>x.Idpago==pagos.Idpago)==true)
                {
                    _context.Pagos.Attach(pagos);
                    _context.Entry(pagos).State = EntityState.Modified;

                }
                else
                {
                    _context.Pagos.Add(pagos);
                }
                _context.SaveChanges();
                return pagos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void AddorUpdateDetallesPagos(DetallesPago detallePago)
        {
            try
            {
                if (_context.DetallesPago.Where(x=>x.IdDetallePago==detallePago.IdDetallePago).FirstOrDefault()!=null)
                {
                    _context.DetallesPago.Attach(detallePago);
                    _context.Entry(detallePago).State = EntityState.Modified;
                }
                else
                {
                    _context.DetallesPago.Add(detallePago);

                }
                _context.SaveChanges();
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Retenciones AddorUpdateRetencion(Retenciones retenciones)
        {
            try
            {
                if (_context.Retenciones.Any(x => x.IdPago== retenciones.IdPago) == true)
                {
                    _context.Retenciones.Attach(retenciones);
                    _context.Entry(retenciones).State = EntityState.Modified;
                }
                else
                {
                    _context.Retenciones.Add(retenciones);

                }
                _context.SaveChanges();
                    return retenciones;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Pagos> GetAllPagos()
        {
            return _context.Pagos.ToList();
        }

        public IEnumerable<Bancos> GetBancos()
        {
            return _context.Bancos.ToList();
        }

        public IEnumerable<MediosPago> GetMediosPago()
        {
            return _context.MediosPago.ToList();
        }

        public Pagos GetPagoByID(int IdPago)
        {
            return _context.Pagos.Where(x => x.Idpago == IdPago).FirstOrDefault();
        }

        public Retenciones GetRetencion(int IdPago)
        {
            return _context.Retenciones.Where(x => x.IdPago == IdPago).
                                              Include(x => x.Empresas).FirstOrDefault();
        }

        public Retenciones CalcularRetenciones(string NombreProveedor, float ImporteFacturas)
        {
            Proveedores proveedores;
            Retenciones retenciones = new Retenciones();
        
                proveedores = _context.Proveedores.Where(x => x.Nombre == NombreProveedor).FirstOrDefault();
                retenciones = new Retenciones();

                if (proveedores.Proveedores1.IDProvincia != 1 || proveedores.IDLocalidad == 8)
                {
                    retenciones = null;
                }
                else
                {
                    PadronRgsRet Padron = _context.PadronRgsRet.Where(x => x.Cuit == proveedores.Cuit).FirstOrDefault();
                    if (Padron != null)
                    {
                        retenciones.Importe = (ImporteFacturas * Padron.Alicuota) / 100;
                        retenciones.Alicuota = Padron.Alicuota;
                        retenciones.Fecha = DateTime.Now;
                        retenciones.EmpresaID = 1;
                       

                    }
                    if (Padron == null)
                    {
                        var maxAliRetencion = _context.MaxAliRetencion.Max(x=>x.Max);
                        retenciones.Importe = (ImporteFacturas *maxAliRetencion ) / 100;
                        retenciones.Alicuota = 4;
                        retenciones.Fecha = DateTime.Now;
                        retenciones.EmpresaID = 1;
                    

                    }

              
                }
                return retenciones;




        }

        public MediosPago GetMedioPagoByNombre(string Medio)
        {
            return _context.MediosPago.Where(x => x.MediosPago1 == Medio).FirstOrDefault();
        }

        public Bancos GetBancobyName(string name)
        {
            return _context.Bancos.Where(x => x.Nombre == name).FirstOrDefault();
        }

        public SeleccionarDatosRetencion_Result GetDatosRetenciones(int idpago)
        {
           return _context.SeleccionarDatosRetencion(idpago).FirstOrDefault();
         

        }

        public IEnumerable<EncabezadoOrdenPago_Result> EncabezadoOdern(int idpago)
        {
            return _context.EncabezadoOrdenPago(idpago);
        }

        public IEnumerable<OrdenPago_Result> OrdenPago(int idpago)
        {
            return _context.OrdenPago(idpago);
        }

        public IEnumerable<SeleccionarMediosDePagos_Result> MediosPagos(int idpago)
        {
            return _context.SeleccionarMediosDePagos(idpago);
        }

        public IEnumerable<SelectPagosProveedores_Result> GetPagosProveedores(DateTime fechainicio, DateTime fechafin)
        {
            return _context.SelectPagosProveedores(fechainicio,fechafin);
        }
    }
}
