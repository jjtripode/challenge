﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nubimetricsApiCurrency.Data;

namespace nubimetricsApiCurrency.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("nubimetricsApiCurrency.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Nombre");

                    b.Property<string>("Password")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellido = "Apellido 1",
                            Email = "Email    1",
                            Nombre = "Nombre   1",
                            Password = "Password 1"
                        },
                        new
                        {
                            Id = 2,
                            Apellido = "Apellido2",
                            Email = "Email   2",
                            Nombre = "Nombre  2",
                            Password = "Password2"
                        },
                        new
                        {
                            Id = 3,
                            Apellido = "Apellido3",
                            Email = "Email   3",
                            Nombre = "Nombre  3",
                            Password = "Password3"
                        },
                        new
                        {
                            Id = 4,
                            Apellido = "Apellido4",
                            Email = "Email   4",
                            Nombre = "Nombre  4",
                            Password = "Password4"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
