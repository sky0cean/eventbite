using EventCatalogApi.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogApi.Data
{
    public class CatalogContext: DbContext
    {
        //Constructor
        public CatalogContext(DbContextOptions options)
            : base(options)
        {  }

        public DbSet<CatalogCategory> CatalogCategories { get; set; }
        public DbSet<CatalogFormat> catalogFormats { get; set; }
        public DbSet<CatalogItem> catalogItems { get; set; }
        public DbSet<CatalogDate> catalogDates { get; set; }
        public DbSet<CatalogPrice> catalogPrices { get; set; }


        //Model = Table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogCategory>(e =>
            {
                e.ToTable("CatalogCategories");
                e.Property(c => c.Id)
                    .IsRequired()
                    .UseHiLo("catalog_category_hilo");

                e.Property(c => c.Category)
                    .IsRequired()
                    .HasMaxLength(100);
            })
        }
    }
}
