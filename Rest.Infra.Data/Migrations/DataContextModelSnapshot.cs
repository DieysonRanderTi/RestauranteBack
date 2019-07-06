﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rest.Infra.Data.Context;

namespace Rest.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Rest.Domain.Ententies.Prato", b =>
                {
                    b.Property<int>("IdPrato")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdRestaurante");

                    b.Property<string>("NomePrato")
                        .IsRequired()
                        .HasColumnName("NomePrato")
                        .HasColumnType("varchar(100)");

                    b.Property<double>("PrecoPrato")
                        .HasColumnName("Preco");

                    b.HasKey("IdPrato");

                    b.HasIndex("IdRestaurante");

                    b.ToTable("Prato");
                });

            modelBuilder.Entity("Rest.Domain.Ententies.Restaurante", b =>
                {
                    b.Property<int>("IdRestaurante")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeRestaurante")
                        .IsRequired()
                        .HasColumnName("NomeRestaurante")
                        .HasColumnType("varchar(100)");

                    b.HasKey("IdRestaurante");

                    b.ToTable("Restaurante");
                });

            modelBuilder.Entity("Rest.Domain.Ententies.Prato", b =>
                {
                    b.HasOne("Rest.Domain.Ententies.Restaurante", "Restaurante")
                        .WithMany()
                        .HasForeignKey("IdRestaurante")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
