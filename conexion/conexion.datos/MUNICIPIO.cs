//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace conexion.conexion.datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUNICIPIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUNICIPIO()
        {
            this.AGENCIA = new HashSet<AGENCIA>();
        }
    
        public int ID_MUNICIPIO { get; set; }
        public string NOMBRE_MUNICIPIO { get; set; }
        public int ID_DEPARTAMENTO { get; set; }
        public string USUARIO_RESPONSABLE { get; set; }
        public string ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENCIA> AGENCIA { get; set; }
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
    }
}
