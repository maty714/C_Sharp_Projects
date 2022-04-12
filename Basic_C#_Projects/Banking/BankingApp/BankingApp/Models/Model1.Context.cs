namespace Model1.Models
{
    using BankingApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class BankDataEntities : DbContext
    {
        public BankDataEntities()
            : base("name=BankDataEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Customer_Account> Customer_Account { get; set; }
        public virtual DbSet<Customer_Info> Customer_Info { get; set; }
    }
}