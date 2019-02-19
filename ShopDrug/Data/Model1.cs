namespace ShopDrug.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1() : base("name=Model1")
        { 
            
        }
        public virtual DbSet<AbsProduct> AbsProducts { get; set; }
        public virtual DbSet<Adresses> Adressess { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Categori> Categoris { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<RealProduct> RealProducts { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}