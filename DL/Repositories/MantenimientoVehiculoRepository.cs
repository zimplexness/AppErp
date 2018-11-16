using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DL.Repositories
{
    public class MantenimientoVehiculoRepository : IMantenimientoVehiculoRepository
    {
        private readonly Entities _context;
        public MantenimientoVehiculoRepository()
        {
            this._context = new Entities();
        }


        public void AddorUpdate(ActividadMantenimiento actividadMantenimiento)
        {
            if (string.IsNullOrEmpty(actividadMantenimiento.Detalle))
            {
                throw new Exception("Error, Debe insertar la Descripción");

            }
            else
            {
                if (_context.ActividadMantenimiento.Where(x=>x.IDActividadMantenimiento==actividadMantenimiento.IDActividadMantenimiento).FirstOrDefault()==null)
                {
                    _context.ActividadMantenimiento.Add(actividadMantenimiento);
                    _context.SaveChanges();
                }
                else
                {
                    _context.ActividadMantenimiento.Attach(actividadMantenimiento);
                    _context.Entry(actividadMantenimiento).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
                
            }
        }

        public DetalleActividadMantenimiento AddOrUpdateDetalleActividadMantenimiento(DetalleActividadMantenimiento detalleActividadMantenimiento)
        {
            try
            {
                var OLD = _context.DetalleActividadMantenimiento.Find(detalleActividadMantenimiento.IdDetalleActividadMantenimiento);
               if (OLD!=null)
                {

                    _context.Entry(OLD).State = EntityState.Detached;
                    _context.Entry(detalleActividadMantenimiento).State = EntityState.Modified;

                    
                       
                 }
                else
                 {
                    _context.DetalleActividadMantenimiento.Add(detalleActividadMantenimiento);

                }
                if (_context.SaveChanges()>0)
                {
                    return detalleActividadMantenimiento;
                }  
               
              
            }
            catch ( Exception exception)
            {

                throw new Exception(exception.Message);
            }
            return detalleActividadMantenimiento = null;
        }

        public DetalleMantenimientoRepuestos AddorUpdateDetalleMantenimientoRepuesto(DetalleMantenimientoRepuestos detalleMantenimientoRepuestos)
        {
            try
            {
                var OLD = _context.DetalleMantenimientoRepuestos.Find(detalleMantenimientoRepuestos.IdDetalleMantenimientoRepuesto);
                if (OLD!=null)
                {
                    _context.Entry(OLD).State = EntityState.Detached;
                   
                    _context.Entry(detalleMantenimientoRepuestos).State = EntityState.Modified;
                   
                   
                }
                else
                {
                    _context.DetalleMantenimientoRepuestos.Add(detalleMantenimientoRepuestos);
                }
                if (_context.SaveChanges() > 0)
                    return detalleMantenimientoRepuestos;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
            return detalleMantenimientoRepuestos = null;
        }

        public Mantenimiento AddorUpdateMantenimiento(Mantenimiento mantenimiento)
        {
            try
            {
                if (_context.Mantenimiento.AsNoTracking().Where(x => x.IDMantenimiento == mantenimiento.IDMantenimiento).FirstOrDefault() != null)
                {

                    _context.Mantenimiento.Attach(mantenimiento);
                    _context.Entry(mantenimiento).State = EntityState.Modified;
                }
                else
                {
                    _context.Mantenimiento.Add(mantenimiento);
                  
                   
                }
                if (_context.SaveChanges() > 0)
                    return mantenimiento;
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
            return mantenimiento = null;
        }

        public PolizasSeguro AddorUpdatePolizas(PolizasSeguro polizasSeguro)
        {
            try
            {

           
            if (_context.PolizasSeguro.Any(x=>x.IDPolizaSeguro==polizasSeguro.IDPolizaSeguro))
            {
                _context.PolizasSeguro.Attach(polizasSeguro);
                _context.Entry(polizasSeguro).State = EntityState.Modified;

            }
            else
            {
                _context.PolizasSeguro.Add(polizasSeguro);

            }
            if (_context.SaveChanges() > 0)
                return polizasSeguro;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return polizasSeguro = null;
        }

        public RegistrosConducir AddOrUpdateRegistro(RegistrosConducir registrosConducir)
        {
            try
            {
                if (_context.RegistrosConducir.Any(x=>x.IDRegistroConducir==registrosConducir.IDRegistroConducir))
                {
                    _context.RegistrosConducir.Attach(registrosConducir);
                    _context.Entry(registrosConducir).State = EntityState.Modified;
                }
                else
                {
                    _context.RegistrosConducir.Add(registrosConducir);

                }
                if (_context.SaveChanges() > 0)
                {
                    return registrosConducir;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                
            }
            return registrosConducir = null;
          
           
           
        }

        public Mantenimiento DeleteManteniento(int ID)
        {
            Mantenimiento mantenimiento = new Mantenimiento();
            try
            {
                //delete mantenimiento
                 mantenimiento = _context.Mantenimiento.Where(x => x.IDMantenimiento == ID).FirstOrDefault();
                _context.Entry(mantenimiento).State = EntityState.Deleted;

                //delete DetalleMantenimiento
                List<DetalleActividadMantenimiento> listDetalleMantenimiento = _context.DetalleActividadMantenimiento.Where(x => x.IdMantenimiento == mantenimiento.IDMantenimiento).ToList();
                foreach (var item in listDetalleMantenimiento)
                {
                    _context.Entry(item).State = EntityState.Deleted;
                }

                //Delete Detalle Mantenimiento Repuesto

                List<DetalleMantenimientoRepuestos> ListDetalleRepuesto = _context.DetalleMantenimientoRepuestos.Where(x => x.IDMantenimiento == mantenimiento.IDMantenimiento).ToList();
                foreach (var item in ListDetalleRepuesto)
                {
                    _context.Entry(item).State = EntityState.Deleted;
                }

                if (_context.SaveChanges() > 0)
                    return mantenimiento;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                
            }
            return mantenimiento = null;
        }

        public PolizasSeguro DeletePolizaSeguro(int ID)
        {
            var Poliza = _context.PolizasSeguro.Where(x => x.IDPolizaSeguro == ID).FirstOrDefault();
            _context.PolizasSeguro.Remove(Poliza);
            _context.SaveChanges();
            return Poliza;
        }

        public void DeleteRegistroConducir(int registrosConducir)
        {
            try
            {
                var Registro = _context.RegistrosConducir.Where(x => x.IDRegistroConducir == registrosConducir).FirstOrDefault();
                _context.RegistrosConducir.Remove(Registro);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<MantenimientoVehiculos> FilterByDetalleMantenimiento(string detalle)
        {
            return _context.MantenimientoVehiculos.Where(x => x.Detalle.Contains(detalle)).ToList();
        }

        public IEnumerable<MantenimientoVehiculos> FilterByPantente(string patente)
        {
            return _context.MantenimientoVehiculos.Where(x => x.Patente.Contains(patente)).ToList();
        }

        public IEnumerable<RegistrosConducir> FilterRegistrosConducirxDni(string dni)
        {
            return _context.RegistrosConducir.Where(x => x.Empleados.DNI.Contains(dni.ToUpper())).ToList();
        }

        public ActividadMantenimiento GetActividadMantenimiento(string Actividad)
        {
            return _context.ActividadMantenimiento.Where(x => x.Detalle == Actividad).FirstOrDefault();
        }

        public ActividadMantenimiento GetActividadMantenimientoByID(int ID)
        {
            return _context.ActividadMantenimiento.Where(x => x.IDActividadMantenimiento == ID).FirstOrDefault();
        }

        public IEnumerable<ActividadMantenimiento> GetAllActividadMantenimiento()
        {
            return _context.ActividadMantenimiento.ToList();
        }

        public IEnumerable<DetalleActividadMantenimiento> GetAllDetalleActividadMantenimiento(int IDMantenimiento)
        {
            return _context.DetalleActividadMantenimiento.Where(x=>x.IdMantenimiento==IDMantenimiento).
                   Include(x=>x.ActividadMantenimiento).
                   ToList();
        }

        public IEnumerable<DetalleMantenimientoRepuestos> GetAllDetalleMantenimientoRepuestos(int IDMantenimiento)
        {
            return _context.DetalleMantenimientoRepuestos.Where(x => x.IDMantenimiento == IDMantenimiento).Include(x => x.Articulos).ToList();
                                                          
        }

        public IEnumerable<RegistrosConducir> GetAllRegistros()
        {
            return _context.RegistrosConducir.Include(x => x.Empleados).
                                              Include(x => x.TiposRegistrosConducir).ToList();

        }

        public IEnumerable<Vehiculos> GetAllVehiculos()
        {
            return _context.Vehiculos.ToList();
        }

        public RegistrosConducir GetByID(int ID)
        {
            return _context.RegistrosConducir.Where(x => x.IDRegistroConducir == ID).FirstOrDefault();
        }

        public Mantenimiento GetMantenimientoByID(int ID)
        {
            return _context.Mantenimiento.Where(x => x.IDMantenimiento == ID).FirstOrDefault();
        }

        public IEnumerable<Mantenimiento> GetMantenimientos()
        {

            var mantenimiento = _context.Mantenimiento
                             .Include(v => v.Vehiculos)
                             .Include(t => t.Talleres)
                             .ToList();
            return mantenimiento;
                             
        }

        public IEnumerable<MantenimientoVehiculos> GetMantenimientoVehiculos()
        {
            return _context.MantenimientoVehiculos.ToList();
        }

        public PolizasSeguro GetPolizaSeguro(int ID)
        {
            return _context.PolizasSeguro.Where(x => x.IDPolizaSeguro == ID).Include(x=>x.Proveedores).FirstOrDefault();
        }

        public IEnumerable<PolizasSeguro> GetPolizasSeguro()
        {
                return _context.PolizasSeguro.
                Include(x=>x.Proveedores).ToList();
        }

        public IEnumerable<TiposRegistrosConducir> GetTiposRegistrosConducir()
        {
            return _context.TiposRegistrosConducir.ToList();
        }

        public IEnumerable<string> GetVencimientoRegistros(DateTime fecha)
        {
            return _context.RegistrosConducir.Where(x => x.FechaVencimiento < fecha).Select(x => x.Empleados.Apellidos+ "-" + "-" + x.Empleados.Nombres + "-" + x.TiposRegistrosConducir.TipoRegistro + "-" + x.FechaVencimiento).ToList();
        }

        public IEnumerable<string> GetVencimientosPolizas(DateTime fecha)
        {
            return _context.PolizasSeguro.Where(x => x.FechaFin < fecha && x.Activa==true).Select(x => x.Nopoliza + "-" + "-" + x.Proveedores.Nombre + "-" + x.Descripcion + "-" + x.FechaFin).ToList();
        }

        public IEnumerable<string> GetVencimientosVTV(DateTime fecha)
        {
            return _context.Vehiculos.Where(x => x.VigenciaVTV < fecha).Select(x=>x.Patente+"-"+x.MarcasVehiculos.Marcas+"-"+x.ModelosVehiculos.Modelo).ToList();
        }
    }
}
