﻿// <auto-generated />
using System;
using ExpressoAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpressoAPI.Migrations
{
    [DbContext(typeof(ExpressDbContext))]
    partial class ExpressDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExpressoAPI.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("ExpressoAPI.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Time")
                        .IsRequired();

                    b.Property<int>("TotalPeople");

                    b.HasKey("Id");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("ExpressoAPI.Models.Submenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int?>("MenuId");

                    b.Property<string>("Name");

                    b.Property<int>("price");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Submenu");
                });

            modelBuilder.Entity("ExpressoAPI.Models.Submenu", b =>
                {
                    b.HasOne("ExpressoAPI.Models.Menu")
                        .WithMany("Submenus")
                        .HasForeignKey("MenuId");
                });
#pragma warning restore 612, 618
        }
    }
}
