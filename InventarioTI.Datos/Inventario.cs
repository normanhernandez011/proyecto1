//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioTI.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventario
    {
        public decimal InventarioID { get; set; }
        public Nullable<decimal> ProductoID { get; set; }
        public Nullable<decimal> MovimientoID { get; set; }
        public Nullable<int> Cantidad { get; set; }
    
        public virtual Movimientos Movimientos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
