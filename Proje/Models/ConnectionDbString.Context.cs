﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proje.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjeConnectionOkulDbEntities : DbContext
    {
        public ProjeConnectionOkulDbEntities()
            : base("name=ProjeConnectionOkulDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ders> Ders { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<OgrenciDers> OgrenciDers { get; set; }
        public virtual DbSet<OkulYonetim> OkulYonetim { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
