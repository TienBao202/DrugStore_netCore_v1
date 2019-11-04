using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using DrugStore.Data.Interfaces;
using DrugStore.Data.EF.Extensions;
using DrugStore.Data.Entities;

namespace DrugStore.Data.EF
{
    public class DrugStoreDbContext : DbContext
    {
        public DrugStoreDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Account> Accounts { get; set; }

        public virtual DbSet<Agency> Agencies { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<Invoice_Detail> Invoice_Details { get; set; }

        public virtual DbSet<Medicine> Medicines { get; set; }

        public virtual DbSet<Medicine_Batch> Medicine_Batches { get; set; }

        public virtual DbSet<Medicine_Category> Medicine_Categories { get; set; }

        public virtual DbSet<Medicine_Unit> Medicine_Units { get; set; }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<Purchase_Order> Purchase_Orders { get; set; }

        public virtual DbSet<Purchase_Order_Detail> Purchase_Order_Details { get; set; }

        public virtual DbSet<Supplier> Suppliers { get; set; }

        public virtual DbSet<Supplier_Group> Supplier_Groups { get; set; }

        public virtual DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.Date_Created = DateTime.Now;
                    }
                    changedOrAddedItem.Date_Modified = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DrugStoreDbContext>
    {
        public DrugStoreDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<DrugStoreDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new DrugStoreDbContext(builder.Options);
        }
    }
}

