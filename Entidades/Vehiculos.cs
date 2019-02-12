//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculos()
        {
            this.Mantenimiento = new HashSet<Mantenimiento>();
        }
    
        public int IDVehiculo { get; set; }
        public Nullable<bool> Activo { get; set; }
        public string Patente { get; set; }
        public Nullable<int> Marca { get; set; }
        public Nullable<int> Modelo { get; set; }
        public string Nochasis { get; set; }
        public string NoCarroceria { get; set; }
        public string NoMotor { get; set; }
        public Nullable<int> IdPolizaSeguro { get; set; }
        public Nullable<bool> NeumaticoRepuesto { get; set; }
        public Nullable<int> IDCombustible { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public Nullable<System.DateTime> FechaTransferencia { get; set; }
        public Nullable<System.DateTime> VigenciaVTV { get; set; }
        public Nullable<int> IdChofer { get; set; }
        public string Titular { get; set; }
        public Nullable<int> KM { get; set; }
        public Nullable<int> TenantID { get; set; }
        public Nullable<int> UserTransac { get; set; }
        public Nullable<bool> Gps { get; set; }
        public string DireccionRadicacion { get; set; }
    
        public virtual Combustibles Combustibles { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual MarcasVehiculos MarcasVehiculos { get; set; }
        public virtual ModelosVehiculos ModelosVehiculos { get; set; }
        public virtual PolizasSeguro PolizasSeguro { get; set; }
        public virtual Vehiculos Vehiculos1 { get; set; }
        public virtual Vehiculos Vehiculos2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimiento> Mantenimiento { get; set; }
    }
}
