using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace Controllers
{
   public class PagosController
    {
        private readonly IPagosRepository _PagoRepository;

        public PagosController()
        {
            _PagoRepository = new PagoRepository();
        }

        public DetalleMediosPagos AddorUpdateMediosPagos(DetalleMediosPagos detalleMediosPagos)
        {
            return _PagoRepository.AddorUpdateMediosPagos(detalleMediosPagos);

        }

        public Pagos AddorUpdatePagos(Pagos pagos)
        {
            return _PagoRepository.AddorUpdatePagos(pagos);
        }

        public void AddorUpdateDetallesPagos(DetallesPago detallePago)
        {
            _PagoRepository.AddorUpdateDetallesPagos(detallePago);
        }

        public Retenciones AddorUpdateRetencion(Retenciones retenciones)
        {
            return _PagoRepository.AddorUpdateRetencion(retenciones);
        }

        public IEnumerable<Pagos> GetAllPagos()
        {
            return _PagoRepository.GetAllPagos();
        }

        public IEnumerable<Bancos> GetBancos()
        {
            return _PagoRepository.GetBancos();
        }

        public IEnumerable<MediosPago> GetMediosPago()
        {
            return _PagoRepository.GetMediosPago();
        }

        public Pagos GetPagoByID(int IdPago)
        {
            return _PagoRepository.GetPagoByID(IdPago);
        }

        public Retenciones GetRetencion(int IdPago)
        {
            return _PagoRepository.GetRetencion(IdPago);
        }

        public Retenciones CalcularRetenciones(string NombreProveedor, float ImporteFacturas)
        {
            return _PagoRepository.CalcularRetenciones(NombreProveedor,ImporteFacturas);


        }

        public MediosPago GetMedioPagoByNombre(string Medio)
        {
           return _PagoRepository.GetMedioPagoByNombre(Medio);
        }

        public Bancos GetBancobyName(string name)
        {
            return _PagoRepository.GetBancobyName(name);
        }

        public SeleccionarDatosRetencion_Result GetDatosRetenciones(int idpago)
        {
            return _PagoRepository.GetDatosRetenciones(idpago);


        }
        public IEnumerable<EncabezadoOrdenPago_Result> EncabezadoOdern(int idpago)
        {
            return _PagoRepository.EncabezadoOdern(idpago);
        }

        public IEnumerable<OrdenPago_Result> OrdenPago(int idpago)
        {
            return _PagoRepository.OrdenPago(idpago);
        }

        public IEnumerable<SeleccionarMediosDePagos_Result> MediosPagos(int idpago)
        {
            return _PagoRepository.MediosPagos(idpago);
        }

        public IEnumerable<SelectPagosProveedores_Result> GetPagosProveedores(DateTime fechainicio, DateTime fechafin)
        {
            return _PagoRepository.GetPagosProveedores(fechainicio,fechafin);
        }

        public IEnumerable<Pagos> GetAllpagos(DateTime fecha1, DateTime fecha2)
        {
            return _PagoRepository.GetAllpagos(fecha1,fecha2);

        }



    }
}
