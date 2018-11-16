using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DL.Repositories
{
   public interface IMantenimientoVehiculoRepository
    {
        void AddorUpdate(ActividadMantenimiento actividadMantenimiento);
        IEnumerable<Mantenimiento> GetMantenimientos();
        IEnumerable<MantenimientoVehiculos> GetMantenimientoVehiculos();
        IEnumerable<MantenimientoVehiculos> FilterByPantente(string patente);
        IEnumerable<MantenimientoVehiculos> FilterByDetalleMantenimiento(string detalle);
        IEnumerable<string> GetVencimientosVTV(DateTime fecha);
        IEnumerable<PolizasSeguro> GetPolizasSeguro();
        PolizasSeguro AddorUpdatePolizas(PolizasSeguro polizasSeguro);
        PolizasSeguro GetPolizaSeguro(int ID);
        IEnumerable<string> GetVencimientosPolizas(DateTime fecha);
        IEnumerable<RegistrosConducir> GetAllRegistros();
        RegistrosConducir GetByID(int ID);
        IEnumerable<TiposRegistrosConducir> GetTiposRegistrosConducir();
        RegistrosConducir AddOrUpdateRegistro(RegistrosConducir registrosConducir);
        IEnumerable<string> GetVencimientoRegistros(DateTime fecha);
        void DeleteRegistroConducir(int registrosConducir);
        DetalleActividadMantenimiento AddOrUpdateDetalleActividadMantenimiento(DetalleActividadMantenimiento detalleActividadMantenimiento);
        DetalleMantenimientoRepuestos AddorUpdateDetalleMantenimientoRepuesto(DetalleMantenimientoRepuestos detalleMantenimientoRepuestos);
        Mantenimiento AddorUpdateMantenimiento(Mantenimiento mantenimiento);
        IEnumerable<ActividadMantenimiento> GetAllActividadMantenimiento();
        ActividadMantenimiento GetActividadMantenimiento(string Actividad);
        IEnumerable<DetalleActividadMantenimiento> GetAllDetalleActividadMantenimiento(int IDMantenimiento);
        IEnumerable<DetalleMantenimientoRepuestos> GetAllDetalleMantenimientoRepuestos(int IDMantenimiento);
        Mantenimiento GetMantenimientoByID(int ID);
        IEnumerable<Vehiculos> GetAllVehiculos();
        Mantenimiento DeleteManteniento(int ID);
        ActividadMantenimiento GetActividadMantenimientoByID(int ID);
        IEnumerable<RegistrosConducir> FilterRegistrosConducirxDni(string dni);
        PolizasSeguro DeletePolizaSeguro(int ID);

    }
}
