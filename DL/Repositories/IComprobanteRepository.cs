using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public interface IComprobanteRepository
    {
        IEnumerable< TiposComprobante> GetTiposComprobante();
        IEnumerable< CentroCostos> GetCentroCostos();
        IEnumerable<TiposFactura> GetTiposFactura();
        IEnumerable< CondicionesCompra> GetCondicionesCompra();
        IEnumerable< Contable> GetContable();
        Comprobantes AddOrUpdateComprobantes(Comprobantes comprobantes);
        Comprobantes GetComprobantesByNofacuraProveedor(int IdProveedor,string Pventa,string Nofactura);
        IEnumerable<SeleccionarDetalleComprobantesArticulos_Result> GetDetallesComprobanteArticulos(int IDcomprobantes);
        DetallesComprobanteArticulos AddorUpdateComprobantesArticulos(DetallesComprobanteArticulos detallesComprobanteArticulos);
        IEnumerable<String> GetNombresArticulo();
        Articulos GetArticulosByName(string name);
        double TotalDetalleComprobanteConIva(int idComprobante);
        double TotalDetalleComprobanteNeto(int idComprobante);
        IEnumerable<FacturasPendientesPago_Result> GetAllFacturasPedientes(int Idproveedor);
        void ActualizarEstadoComprobante(int Idcomprobante);
        void ActualizarEstado(int idcomprobante);
        void ActualizarComprobantes(Comprobantes comprobantes);
        bool VerifyComprobantes(int Proveedor, string PuntoV,string NoFactura);
        Comprobantes DeleteComprobantes(int ID);
        Comprobantes GetComprobante(int Proveedor, string PuntoV, string NoFactura);
        IEnumerable<DetallesComprobanteArticulos> GetALLDetallesComprobanteArticulos(int IdComprobante);
        Comprobantes DeleteComprobante(int IDComprobante);
        IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantes(DateTime fecha1,DateTime fecha2);
        IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxProveedor(string Nombre,DateTime fecha1, DateTime fecha2);
        IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxFactura(string Puntov, string Nofactura,DateTime fecha1,DateTime fecha2);
        Comprobantes GetComprobanteById(int ID);
        IEnumerable<DetallesComprobanteArticulos> GetComprobantesArticulos(int ID);

    }
}
