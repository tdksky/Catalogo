﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class inventarioEntities : DbContext
    {
        public inventarioEntities()
            : base("name=inventarioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<procesos> procesos { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<proyecto> proyecto { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<sucursal> sucursal { get; set; }
        public virtual DbSet<tipos_documento> tipos_documento { get; set; }
        public virtual DbSet<transferencia> transferencia { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}
