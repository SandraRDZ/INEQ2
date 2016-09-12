using INEQ2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace INEQ2.DAL
{

    public class DAL : DbContext
    {
        public DAL() : base("INEQ")
        {
        }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Statu> Status { get; set; }
        public DbSet<Warehouse> Warehouse { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
