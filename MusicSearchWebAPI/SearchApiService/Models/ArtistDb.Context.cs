﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchApiService.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusicStoreDbEntities : DbContext
    {
        public MusicStoreDbEntities()
            : base("name=MusicStoreDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<artist> artists { get; set; }
        public virtual DbSet<artistalia> artistalias { get; set; }
        public virtual DbSet<artistrelease> artistreleases { get; set; }
        public virtual DbSet<release> releases { get; set; }
    }
}