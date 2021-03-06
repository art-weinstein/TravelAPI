// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Models;

namespace Travel.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20211025215455_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Travel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Miami",
                            Country = "USA",
                            Rating = 7
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Roatan",
                            Country = "Honduras",
                            Rating = 9
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Madrid",
                            Country = "Spain",
                            Rating = 8
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "London",
                            Country = "England",
                            Rating = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
