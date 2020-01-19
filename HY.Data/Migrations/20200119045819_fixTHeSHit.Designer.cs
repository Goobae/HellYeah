﻿// <auto-generated />
using System;
using HY.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HY.Data.Migrations
{
    [DbContext(typeof(HYContext))]
    [Migration("20200119045819_fixTHeSHit")]
    partial class fixTHeSHit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HY.Data.Entities.HYEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EntityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Entities");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            EntityName = "TEST"
                        });
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityCommand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HYEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HYEntityId");

                    b.ToTable("HYEntityCommand");
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int>("PropretyTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityRelationship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HYEntityId")
                        .HasColumnType("int");

                    b.Property<int>("RelationshipTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HYEntityId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityCommand", b =>
                {
                    b.HasOne("HY.Data.Entities.HYEntity", null)
                        .WithMany("EntityCommands")
                        .HasForeignKey("HYEntityId");
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityProperty", b =>
                {
                    b.HasOne("HY.Data.Entities.HYEntity", "Entity")
                        .WithMany("EntityProperties")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HY.Data.Entities.HYEntityRelationship", b =>
                {
                    b.HasOne("HY.Data.Entities.HYEntity", null)
                        .WithMany("EntityRelationships")
                        .HasForeignKey("HYEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
