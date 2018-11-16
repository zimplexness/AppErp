using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL.Repositories;
using Entidades;

namespace Controllers
{
   public class MantenimientoVehiculoController
    {
        private readonly IMantenimientoVehiculoRepository mantenimientoVehiculoRepository;

        public MantenimientoVehiculoController()
        {
            mantenimientoVehiculoRepository = new MantenimientoVehiculoRepository();
        }

      public void AddActividadMantenimiento(ActividadMantenimiento actividad) {

             mantenimientoVehiculoRepository.AddorUpdate(actividad);

        }

        public IEnumerable<Mantenimiento> GetMantenimientos() {

          return  mantenimientoVehiculoRepository.GetMantenimientos();
        }

        public IEnumerable<MantenimientoVehiculos> GetMantenimientoVehiculos()
        {
            return mantenimientoVehiculoRepository.GetMantenimientoVehiculos();
        }

        public IEnumerable<MantenimientoVehiculos> FilterByDetalleMantenimiento(string detalle)
        {
            return mantenimientoVehiculoRepository.FilterByDetalleMantenimiento(detalle);
        }

        public IEnumerable<MantenimientoVehiculos> FilterByPantente(string patente)
        {
            return mantenimientoVehiculoRepository.FilterByPantente(patente);
        }

        public IEnumerable<string> GetVencimientosVTV(DateTime fecha)
        {
            return mantenimientoVehiculoRepository.GetVencimientosVTV(fecha);
        }

        public IEnumerable<PolizasSeguro> GetPolizasSeguroActivas()
        {
            return mantenimientoVehiculoRepository.GetPolizasSeguro();
        }
        public PolizasSeguro AddorUpdatePolizas(PolizasSeguro polizasSeguro)
        {
            return mantenimientoVehiculoRepository.AddorUpdatePolizas(polizasSeguro);
        }
        public PolizasSeguro GetPolizaSeguro(int ID)
        {
            return mantenimientoVehiculoRepository.GetPolizaSeguro(ID);
        }

        public IEnumerable<string> GetVencimientosPolizas(DateTime fecha)
        {
            return mantenimientoVehiculoRepository.GetVencimientosPolizas(fecha);
        }

        public IEnumerable<RegistrosConducir> GetAllRegistros()
        {
            return mantenimientoVehiculoRepository.GetAllRegistros();

        }

        public RegistrosConducir GetRegistroConducir(int ID) {
            return mantenimientoVehiculoRepository.GetByID(ID);
        }

        public IEnumerable<TiposRegistrosConducir> GetTiposRegistrosConducir()
        {
            return mantenimientoVehiculoRepository.GetTiposRegistrosConducir();
        }

        public IEnumerable<string> GetVencimientoRegistros(DateTime fecha)
        {
            return mantenimientoVehiculoRepository.GetVencimientoRegistros(fecha);
        }
        public RegistrosConducir AddOrUpdateRegistro(RegistrosConducir registrosConducir)
        {

            return mantenimientoVehiculoRepository.AddOrUpdateRegistro(registrosConducir);



        }


        public void DeleteRegistroConducir(int registrosConducir)
        {
            mantenimientoVehiculoRepository.DeleteRegistroConducir(registrosConducir);
        }

        public DetalleActividadMantenimiento AddOrUpdateDetalleActividadMantenimiento(DetalleActividadMantenimiento detalleActividadMantenimiento)
        {
            return mantenimientoVehiculoRepository.AddOrUpdateDetalleActividadMantenimiento(detalleActividadMantenimiento);
        }

        public DetalleMantenimientoRepuestos AddorUpdateDetalleMantenimientoRepuesto(DetalleMantenimientoRepuestos detalleMantenimientoRepuestos)
        {
            return mantenimientoVehiculoRepository.AddorUpdateDetalleMantenimientoRepuesto(detalleMantenimientoRepuestos);
        }

        public Mantenimiento AddorUpdateMantenimiento(Mantenimiento mantenimiento)
        {
            return mantenimientoVehiculoRepository.AddorUpdateMantenimiento(mantenimiento);
        }

        public Mantenimiento GetMantenimientoByID(int ID)
        {
            return mantenimientoVehiculoRepository.GetMantenimientoByID(ID);
        }

        public IEnumerable<DetalleMantenimientoRepuestos> GetAllDetalleMantenimientoRepuestos(int IDMantenimiento)
        {
            return mantenimientoVehiculoRepository.GetAllDetalleMantenimientoRepuestos(IDMantenimiento);

        }

        public IEnumerable<DetalleActividadMantenimiento> GetAllDetalleActividadMantenimiento(int IDMantenimiento)
        {
            return mantenimientoVehiculoRepository.GetAllDetalleActividadMantenimiento(IDMantenimiento);
        }

        public IEnumerable<ActividadMantenimiento> GetAllActividadMantenimiento()
        {
            return mantenimientoVehiculoRepository.GetAllActividadMantenimiento();
        }

        public ActividadMantenimiento GetActividadMantenimientoByID(int ID)
        {
            return mantenimientoVehiculoRepository.GetActividadMantenimientoByID(ID);
        }

        public IEnumerable<Vehiculos> GetAllVehiculos()
        {
            return mantenimientoVehiculoRepository.GetAllVehiculos();
        }

        public ActividadMantenimiento GetActividadMantenimiento(string Actividad)
        {
            return mantenimientoVehiculoRepository.GetActividadMantenimiento(Actividad);
        }
        public Mantenimiento DeleteManteniento(int ID)
        {
            return mantenimientoVehiculoRepository.DeleteManteniento(ID);
        }

        public IEnumerable<RegistrosConducir> FilterRegistrosConducirxDni(string dni)
        {
            return mantenimientoVehiculoRepository.FilterRegistrosConducirxDni(dni);
        }

        public PolizasSeguro DeletePolizaSeguro(int ID)
        {
            return mantenimientoVehiculoRepository.DeletePolizaSeguro(ID);
        }

    }
}
