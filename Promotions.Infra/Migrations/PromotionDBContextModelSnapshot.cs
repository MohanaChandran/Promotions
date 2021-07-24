﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Promotions.Infra;

namespace Promotions.Infra.Migrations
{
    [DbContext(typeof(PromotionDBContext))]
    partial class PromotionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("prm")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Propmotions.Core.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("URL")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Document");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7327),
                            ModifiedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7351),
                            Name = "Marketing",
                            URL = "https://www.facebook.com/"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7399),
                            ModifiedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7403),
                            Name = "Marketing",
                            URL = "https://www.Google.com/"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7422),
                            ModifiedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7426),
                            Name = "Travel",
                            URL = "https://www.MakeMyTrip.com/"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7443),
                            ModifiedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7446),
                            Name = "Finance",
                            URL = "https://www.MoneyControl.com/"
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = 0,
                            CreatedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7464),
                            ModifiedDate = new DateTime(2021, 7, 24, 8, 2, 17, 77, DateTimeKind.Utc).AddTicks(7467),
                            Name = "Finance",
                            URL = "https://www.ICICI.com/"
                        });
                });

            modelBuilder.Entity("Propmotions.Core.Keyword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Keyword");
                });

            modelBuilder.Entity("Propmotions.Core.KeywordDocumentMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DocumentId")
                        .HasColumnType("integer");

                    b.Property<int>("KeywordId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("KeywordId");

                    b.HasIndex("DocumentId", "KeywordId")
                        .IsUnique();

                    b.ToTable("KeywordDocumentMapping");
                });

            modelBuilder.Entity("Propmotions.Core.KeywordDocumentMapping", b =>
                {
                    b.HasOne("Propmotions.Core.Document", "Document")
                        .WithMany("DocumemtMappings")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Propmotions.Core.Keyword", "Keyword")
                        .WithMany("DocumemtMappings")
                        .HasForeignKey("KeywordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Document");

                    b.Navigation("Keyword");
                });

            modelBuilder.Entity("Propmotions.Core.Document", b =>
                {
                    b.Navigation("DocumemtMappings");
                });

            modelBuilder.Entity("Propmotions.Core.Keyword", b =>
                {
                    b.Navigation("DocumemtMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
