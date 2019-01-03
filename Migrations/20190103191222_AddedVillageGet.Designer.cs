﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using villagecharacters;

namespace villagecharacters.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190103191222_AddedVillageGet")]
    partial class AddedVillageGet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("villagecharacters.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Health");

                    b.Property<string>("Hitpoints");

                    b.Property<string>("Name");

                    b.Property<string>("Speed");

                    b.Property<int>("VillageId");

                    b.HasKey("Id");

                    b.HasIndex("VillageId");

                    b.ToTable("Character");
                });

            modelBuilder.Entity("villagecharacters.Models.Village", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("NumberOfWalls");

                    b.Property<string>("TroopCapacity");

                    b.Property<string>("VillageLevel");

                    b.HasKey("Id");

                    b.ToTable("Village");
                });

            modelBuilder.Entity("villagecharacters.Models.Character", b =>
                {
                    b.HasOne("villagecharacters.Models.Village", "Village")
                        .WithMany("Character")
                        .HasForeignKey("VillageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
