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

        public IEnumerable<Vehiculos> FilterVehiculoByPatente(string Patente)
        {
            return mantenimientoVehiculoRepository.FilterVehiculoByPatente(Patente);
        }

        public IEnumerable<Vehiculos> FilterVehiculosbyMarca(string marca)
        {
            return mantenimientoVehiculoRepository.FilterVehiculosbyMarca(marca);
        }

        public IEnumerable<Vehiculos> FilterVehiculosbyYear(int year)
        {
            return mantenimientoVehiculoRepository.FilterVehiculosbyYear(year);
        }

        public IEnumerable<Vehiculos> FilterVehiculosModelos(string modelo)
        {
            return mantenimientoVehiculoRepository.FilterVehiculosModelos(modelo);
        }

        public IEnumerable<MarcasVehiculos> GetMarcasVehiculos()
        {
            return mantenimientoVehiculoRepository.GetMarcasVehiculos();
        }

        public IEnumerable<ModelosVehiculos> GetModeloxMarca(int IdMarca)
        {
            return mantenimientoVehiculoRepository.GetModeloxMarca(IdMarca);
        }
        public IEnumerable<Combustibles> GetCombustibles()
        {
            return mantenimientoVehiculoRepository.GetCombustibles();
        }
        public Vehiculos AddorUpdateVehiculo(Vehiculos vehiculos)
        {
            return mantenimientoVehiculoRepository.AddorUpdateVehiculo(vehiculos);
        }
        public Vehiculos GetVehiculosById(int Id)
        {
            return mantenimientoVehiculoRepository.GetVehiculosById(Id);
        }
        public IEnumerable<ModelosVehiculos> GetModelosVehiculos()
        {
            return mantenimientoVehiculoRepository.GetModelosVehiculos();
        }
        public Vehiculos DeleteVehiculo(int ID)
        {
            return mantenimientoVehiculoRepository.DeleteVehiculo(ID);
        }

        public IEnumerable<Talleres> GetAllTalleres()
        {
            return mantenimientoVehiculoRepository.GetAllTalleres();
        }

        public IEnumerable<Talleres> FilterByTaller(string nombre)
        {
            return mantenimientoVehiculoRepository.FilterByTaller(nombre);
        }

        public IEnumerable<Talleres> FilterByDireccion(string direccion)
        {
            return mantenimientoVehiculoRepository.FilterByDireccion(direccion);
        }

        public Talleres GetTallerByID(int ID)
        {
            return mantenimientoVehiculoRepository.GetTallerByID(ID);
        }
        public Talleres AddorUpdateTaller(Talleres taller)
        {
            return mantenimientoVehiculoRepository.AddorUpdateTaller(taller);
        }

        public IEnumerable<TipoTaller> GetAllTiposTalleres()
        {
            return mantenimientoVehiculoRepository.GetAllTiposTalleres();
        }
        public Talleres DeleteTaller(int ID)
        {
            return mantenimientoVehiculoRepository.DeleteTaller(ID);
        }

    }
}
