using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace Controllers
{
  public  class ComprobanteController
    {
        private Comprobantes comprobantes;
        public IComprobanteRepository _comprobanteRepository;
        public ComprobanteController()
        {
            _comprobanteRepository = new ComprobanteRepository();
            comprobantes = new Comprobantes();
        }

       public IEnumerable<CentroCostos> GetCentroCostos() {
            return   _comprobanteRepository.GetCentroCostos();
        }

        public IEnumerable<CondicionesCompra> GetCondicionesCompra() {
          return _comprobanteRepository.GetCondicionesCompra(); 

        }

        public IEnumerable<Contable> GetContable() {
          return  _comprobanteRepository.GetContable();
        }

        public IEnumerable<TiposComprobante> GetTiposComprobante() {
            return _comprobanteRepository.GetTiposComprobante();

        }
        public IEnumerable<TiposFactura> GetTiposFactura() {

            return _comprobanteRepository.GetTiposFactura();
        }

        public Comprobantes AddorUpdateComprobantes(Comprobantes comprobantes) {

            try
            {
               return _comprobanteRepository.AddOrUpdateComprobantes(comprobantes);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Comprobantes GetComprobanteByFacturaPRoveedor(int Idproveedor,string Pventa, string Nofactura) {
            try
            {
              return _comprobanteRepository.GetComprobantesByNofacuraProveedor(Idproveedor,Pventa,Nofactura);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public IEnumerable<SeleccionarDetalleComprobantesArticulos_Result> GetDetalleComprobantesArticulos_Result(int IDComprobante)
        {

            return _comprobanteRepository.GetDetallesComprobanteArticulos(IDComprobante);



        }

        public DetallesComprobanteArticulos AddorUpdateComprobantesArticulos(DetallesComprobanteArticulos detallesComprobanteArticulos) {
            try
            {
                return _comprobanteRepository.AddorUpdateComprobantesArticulos(detallesComprobanteArticulos);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IEnumerable<string> GetListaNombreArticulos() {

            return _comprobanteRepository.GetNombresArticulo();

        }

        public Articulos GetArticuloByName(string name)
        {

            return _comprobanteRepository.GetArticulosByName(name);

        }

        public double TotalNetoDetalleComprobantes(int IdComprobante) {

          return  _comprobanteRepository.TotalDetalleComprobanteConIva(IdComprobante);
            
        }

        public IEnumerable<FacturasPendientesPago_Result> GetAllFacturasPedientes(int Idproveedor)
        {
            return _comprobanteRepository.GetAllFacturasPedientes(Idproveedor);
        }

        public double TotalDetalleComprobanteNeto(int idComprobante)
        {
            return _comprobanteRepository.TotalDetalleComprobanteNeto(idComprobante);
        }

        public void ActualizarEstadoComprobante(int Idcomprobante)
        {
            _comprobanteRepository.ActualizarEstadoComprobante(Idcomprobante);
        }

        public void ActualizarComprobantes(Comprobantes comprobantes)
        {
            _comprobanteRepository.ActualizarComprobantes(comprobantes);


        }
        public bool VerifyComprobantes(int Proveedor, string PuntoV, string NoFactura)
        {
            return _comprobanteRepository.VerifyComprobantes(Proveedor,PuntoV,NoFactura);
        }

        public Comprobantes GetComprobante(int Proveedor, string PuntoV, string NoFactura)
        {
            return _comprobanteRepository.GetComprobante(Proveedor,PuntoV,NoFactura);
        }

        public IEnumerable<DetallesComprobanteArticulos> GetALLDetallesComprobanteArticulos(int IdComprobante)
        {
            return _comprobanteRepository.GetALLDetallesComprobanteArticulos(IdComprobante);
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantes(DateTime fecha1, DateTime fecha2)
        {
            return _comprobanteRepository.GetAllComprobantes(fecha1,fecha2);
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxProveedor(string Nombre, DateTime fecha1, DateTime fecha2)
        {
            return _comprobanteRepository.GetAllComprobantesxProveedor(Nombre,fecha1,fecha2);
        }

        public IEnumerable<GetAllComprobantesxFechas_Result> GetAllComprobantesxFactura(string Puntov, string Nofactura, DateTime fecha1, DateTime fecha2)
        {
            return _comprobanteRepository.GetAllComprobantesxFactura(Puntov,Nofactura,fecha1,fecha2); 
        }

        public Comprobantes GetComprobanteById(int ID)
        {
            return _comprobanteRepository.GetComprobanteById(ID);
        }

        public IEnumerable<DetallesComprobanteArticulos> GetComprobantesArticulos(int ID)
        {
            return _comprobanteRepository.GetComprobantesArticulos(ID);
        }

        public Comprobantes DeleteComprobantes(int ID)
        {

            return _comprobanteRepository.DeleteComprobante(ID);


        }

    }
}
