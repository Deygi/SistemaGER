﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIGRE.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SGEBDEntidades : DbContext
    {
        public SGEBDEntidades()
            : base("name=SGEBDEntidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<typeProduct> typeProduct { get; set; }
        public virtual DbSet<typeUnit> typeUnit { get; set; }
        public virtual DbSet<typeUser> typeUser { get; set; }
        public virtual DbSet<Ubigeo> Ubigeo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}