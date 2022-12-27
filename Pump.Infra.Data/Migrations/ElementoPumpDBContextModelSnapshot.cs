﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pump.Infra.Data;

#nullable disable

namespace Pump.Infra.Data.Migrations
{
    [DbContext(typeof(ElementoPumpDBContext))]
    partial class ElementoPumpDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pump.Domain.Entity.ElementoPumpEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Gramas")
                        .HasPrecision(20, 6)
                        .HasColumnType("decimal(20,6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<decimal>("Valor")
                        .HasPrecision(20, 6)
                        .HasColumnType("decimal(20,6)");

                    b.HasKey("Id");

                    b.ToTable("ElementoPump", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
