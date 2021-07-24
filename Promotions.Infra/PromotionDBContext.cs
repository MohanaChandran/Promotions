using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Propmotions.Core;
using System;

namespace Promotions.Infra
{
    public partial class PromotionDBContext : DbContext
    {

        string _connectionString = string.Empty;

        public PromotionDBContext(DbContextOptions options) : base(options)
        {   
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Database=Promotion;Username=promotionsadmin;Password=Test@Admin");
        }


        #region Promotion
        /* -------------------------------------------Promotion START-------------------------------------------------------------------------------------*/
        public virtual DbSet<Keyword> Keyword { get; set; }
        public virtual DbSet<Document> Document { get; set; }      

        /* -------------------------------------------Promotion END-------------------------------------------------------------------------------------*/
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("prm");
            BuildModelForPromotion(modelBuilder);

            SeedData(modelBuilder);

        }

        private static DataBuilder<Document> SeedData(ModelBuilder modelBuilder)
        {
                      return modelBuilder.Entity<Document>().HasData(
                       new Document
                       {
                           Id = 1,
                           Name = "Marketing",
                           URL = "https://www.facebook.com/"
                       }
                       ,
                        new Document
                        {
                            Id = 2,
                            Name = "Marketing",
                            URL = "https://www.Google.com/"
                        }
                        , new Document
                        {
                            Id = 3,
                            Name = "Travel",
                            URL = "https://www.MakeMyTrip.com/"
                        }
                        , new Document
                        {
                            Id = 4,
                            Name = "Finance",
                            URL = "https://www.MoneyControl.com/"
                        }
                        , new Document
                        {
                            Id = 5,
                            Name = "Finance",
                            URL = "https://www.ICICI.com/"
                        }
               );
        }

        private static void BuildModelForPromotion(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Keyword>().HasKey(ur => new { ur.Id });
            modelBuilder.Entity<Document>().HasKey(ur => new { ur.Id });
            modelBuilder.Entity<KeywordDocumentMapping>().HasKey(ur => ur.Id);
            modelBuilder.Entity<KeywordDocumentMapping>()
                 .HasIndex(p => new { p.DocumentId, p.KeywordId }).IsUnique();
            

            modelBuilder.Entity<Keyword>()          
           .HasMany(e => e.DocumemtMappings)
           .WithOne(e => e.Keyword)
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Keyword>()
           .Property(p => p.Id)
           .ValueGeneratedOnAdd();


            modelBuilder.Entity<Document>()
           .HasMany(e => e.DocumemtMappings)
           .WithOne(e => e.Document)
           .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Document>()
           .Property(p => p.Id)
           .ValueGeneratedOnAdd();

        }

    }
}
