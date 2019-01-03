﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using villagecharacters;

namespace villagecharacters.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("villagecharacters.Models.Characters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Health");

                    b.Property<string>("Hitpoints");

                    b.Property<string>("Name");

                    b.Property<string>("Speed");

                    b.HasKey("Id");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("villagecharacters.Models.Villages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("NumberOfWalls");

                    b.Property<string>("TroopCapacity");

                    b.Property<string>("VillageLevel");

                    b.HasKey("Id");

                    b.ToTable("Villages");
                });
#pragma warning restore 612, 618
        }
    }
}
