﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OurProducts.Models;

namespace OurProducts.Migrations
{
  //  [DbContext(typeof(OurProductContext))]
    partial class OurProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OurProducts.Models.Product", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("PPrice")
                        .HasColumnType("real");

                    b.HasKey("PId");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
