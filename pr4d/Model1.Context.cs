﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr4d
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NedvizhimostEntities : DbContext
    {
        public NedvizhimostEntities()
            : base("name=NedvizhimostEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Deal> Deal { get; set; }
        public virtual DbSet<DealEnd> DealEnd { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyType> PropertyType { get; set; }
        public virtual DbSet<Realtor> Realtor { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}