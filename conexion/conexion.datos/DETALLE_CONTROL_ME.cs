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
    
    public partial class DETALLE_CONTROL_ME
    {
        public int ID_DEPTO { get; set; }
        public int NUMERO_REFERENCIA { get; set; }
        public string CODIGO_INVENTARIO { get; set; }
        public string CODIGO_NUEVO { get; set; }
        public System.DateTime FECHA_COMPRA { get; set; }
        public Nullable<System.DateTime> MES_DEPRECIACION { get; set; }
        public int ID_PROVEEDOR { get; set; }
        public string TIPO_MOBILIARIO { get; set; }
        public Nullable<int> ID_MARCA { get; set; }
        public string TIPO_MATERIAL { get; set; }
        public string COLOR { get; set; }
        public Nullable<int> DIVISIONES_GAVETAS { get; set; }
        public string MODELO { get; set; }
        public string NUMERO_SERIE { get; set; }
        public string UBICACION { get; set; }
        public int ID_EMPLEADO { get; set; }
        public string CONDICION_ACTUAL { get; set; }
        public string USUARIO_RESPONSABLE { get; set; }
        public string ESTADO { get; set; }
    }
}