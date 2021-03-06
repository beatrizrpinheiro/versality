// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Versality.Data;

namespace Versality.Migrations
{
    [DbContext(typeof(VersalityContext))]
    [Migration("20220301235138_six")]
    partial class six
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("Versality.Models.ActiveMethods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ActiveMethods");
                });

            modelBuilder.Entity("Versality.Models.Knowledge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ActionLeader")
                        .HasColumnType("longtext");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<int>("TheProblemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Knowledge");
                });

            modelBuilder.Entity("Versality.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sector");
                });

            modelBuilder.Entity("Versality.Models.ViewModels.TheProblem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateProblem")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Sector")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TheProblem");
                });
#pragma warning restore 612, 618
        }
    }
}
