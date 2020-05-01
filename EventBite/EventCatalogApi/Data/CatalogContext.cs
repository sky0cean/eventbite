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
        public DbSet<CatalogFormat> CatalogFormats { get; set; }
        public DbSet<CatalogItem> CatalogItems { get; set; }



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
            });

            modelBuilder.Entity<CatalogFormat>(e =>
            {
                e.ToTable("CatalogFormats");
                e.Property(f => f.Id)
                    .IsRequired()
                    .UseHiLo("catalog_format_hilo");

                e.Property(f => f.Format)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CatalogItem>(e =>
            {
                e.ToTable("Catalog");
                e.Property(c => c.Id)
                    .IsRequired()
                    .UseHiLo("Catalog_hilo");

                e.Property(c => c.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                e.Property(c => c.Price)
                    .IsRequired();

                e.HasOne(c => c.CatalogFormat)
                    .WithMany()
                    .HasForeignKey(c => c.CatalogFormatId);

                e.HasOne(c => c.CatalogCategory)
                    .WithMany()
                    .HasForeignKey(c => c.CatalogCategoryId);



            });
        }

    }
}
