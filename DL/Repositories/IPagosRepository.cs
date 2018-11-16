using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public interface IPagosRepository
    {
        Pagos AddorUpdatePagos(Pagos pagos);
        void AddorUpdateDetallesPagos(DetallesPago detallesPago);
        DetalleMediosPagos AddorUpdateMediosPagos(DetalleMediosPagos detalleMediosPagos);
        IEnumerable<MediosPago> GetMediosPago();
        IEnumerable<Bancos> GetBancos();
        IEnumerable<Pagos> GetAllPagos();
        Pagos GetPagoByID(int IdPago);
        Retenciones AddorUpdateRetencion(Retenciones retenciones);
        Retenciones GetRetencion(int IdPago);
        Retenciones CalcularRetenciones(string NombreProveedor, float ImporteFacturas);
        MediosPago GetMedioPagoByNombre(string Medio);
        Bancos GetBancobyName(string name);
        SeleccionarDatosRetencion_Result GetDatosRetenciones(int idpago);
        IEnumerable<EncabezadoOrdenPago_Result> EncabezadoOdern(int idpago);
        IEnumerable<OrdenPago_Result> OrdenPago(int idpago);
        IEnumerable<SeleccionarMediosDePagos_Result> MediosPagos(int idpago);
        IEnumerable<SelectPagosProveedores_Result> GetPagosProveedores(DateTime fechainicio, DateTime fechafin);




    }
}
