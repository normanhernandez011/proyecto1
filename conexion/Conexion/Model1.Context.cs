﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace conexion.Conexion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ControlCuentasDBEntities : DbContext
    {
        public ControlCuentasDBEntities()
            : base("name=ControlCuentasDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Cargos> TBL_Cargos { get; set; }
        public virtual DbSet<TBL_Categorias_Iglesias> TBL_Categorias_Iglesias { get; set; }
        public virtual DbSet<TBL_Cuentas> TBL_Cuentas { get; set; }
        public virtual DbSet<TBL_Iglesias> TBL_Iglesias { get; set; }
        public virtual DbSet<TBL_Ingresos> TBL_Ingresos { get; set; }
        public virtual DbSet<TBL_Responsables> TBL_Responsables { get; set; }
    }
}
