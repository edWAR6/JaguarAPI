﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EARTH.Jaguar.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<P_Personas> P_Personas { get; set; }
        public DbSet<P_Notas> P_Notas { get; set; }
        public DbSet<R_RegistroNotas> R_RegistroNotas { get; set; }
        public DbSet<VR_Rendimiento_A_Academ> VR_Rendimiento_A_Academ { get; set; }
        public DbSet<VR_Rendimiento_Periodos> VR_Rendimiento_Periodos { get; set; }
        public DbSet<P_NotasPublicas> P_NotasPublicas { get; set; }
    }
}
