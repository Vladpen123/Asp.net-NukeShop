// <auto-generated />
using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ShopContext))]
    partial class ShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Кроссовки"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Футболки"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Шорты"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Аксессуары"
                        });
                });

            modelBuilder.Entity("DAL.Models.Good", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Goods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Code = "CV0726-007",
                            Count = 23,
                            Desc = "КРОССОВКИ NIKE M REACT VAPOR NXT CLY АРТИКУЛ: CV0726-007",
                            Gender = 0,
                            ManufacturerId = 1,
                            Name = "REACT VAPOR NXT CLY",
                            PhotoPath = "/Files/CV0726_007_preview.png",
                            Price = 7379.00m
                        });
                });

            modelBuilder.Entity("DAL.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nike"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Adidas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Puma"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Helly Henson"
                        });
                });

            modelBuilder.Entity("DAL.Models.Good", b =>
                {
                    b.HasOne("DAL.Models.Category", "Category")
                        .WithMany("Goods")
                        .HasForeignKey("CategoryId");

                    b.HasOne("DAL.Models.Manufacturer", "Manufacturer")
                        .WithMany("Goods")
                        .HasForeignKey("ManufacturerId");

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Navigation("Goods");
                });

            modelBuilder.Entity("DAL.Models.Manufacturer", b =>
                {
                    b.Navigation("Goods");
                });
#pragma warning restore 612, 618
        }
    }
}
