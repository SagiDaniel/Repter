﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepterDB.Model;

namespace RepterDB.Migrations
{
    [DbContext(typeof(JaratContext))]
    partial class JaratContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepterDB.Model.Jarat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CelVarosID")
                        .HasColumnType("int");

                    b.Property<int>("KiinduloVarosID")
                        .HasColumnType("int");

                    b.Property<double>("KmDij")
                        .HasColumnType("float");

                    b.Property<string>("Legitarsasag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CelVarosID");

                    b.HasIndex("KiinduloVarosID");

                    b.ToTable("Jatatok");
                });

            modelBuilder.Entity("RepterDB.Model.Varos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Nepesseg")
                        .HasColumnType("int");

                    b.Property<string>("Nev")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Varosok");
                });

            modelBuilder.Entity("RepterDB.Model.Jarat", b =>
                {
                    b.HasOne("RepterDB.Model.Varos", "CelVaros")
                        .WithMany()
                        .HasForeignKey("CelVarosID");

                    b.HasOne("RepterDB.Model.Varos", "KiinduloVaros")
                        .WithMany("JaratokInnen")
                        .HasForeignKey("KiinduloVarosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CelVaros");

                    b.Navigation("KiinduloVaros");
                });

            modelBuilder.Entity("RepterDB.Model.Varos", b =>
                {
                    b.Navigation("JaratokInnen");
                });
#pragma warning restore 612, 618
        }
    }
}
