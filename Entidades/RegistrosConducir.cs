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
    
    public partial class RegistrosConducir
    {
        public int IDRegistroConducir { get; set; }
        public Nullable<int> EmpleadoID { get; set; }
        public Nullable<int> TipoRegistroID { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual TiposRegistrosConducir TiposRegistrosConducir { get; set; }
    }
}
