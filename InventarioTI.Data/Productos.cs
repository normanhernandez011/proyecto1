//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InventarioTI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Inventario = new HashSet<Inventario>();
        }
    
        public decimal ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public Nullable<decimal> TipoProductoID { get; set; }
        public Nullable<decimal> MarcaID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> Inventario { get; set; }
        public virtual Marcas Marcas { get; set; }
        public virtual TiposProducto TiposProducto { get; set; }
    }
}
