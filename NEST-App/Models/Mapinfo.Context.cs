﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEST_App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MapinfoContainer : DbContext
    {
        public MapinfoContainer()
            : base("name=MapinfoContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<UAVInformation> UAVInformationSet { get; set; }
        public DbSet<PopulationDensity> PopulationDensitySet { get; set; }
        public DbSet<MapInformation> MapInformationSet { get; set; }
        public DbSet<Weather> WeatherSet { get; set; }
    }
}