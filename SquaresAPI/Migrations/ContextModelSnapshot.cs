﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SquaresAPI.Data;

namespace SquaresAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SquaresAPI.Entities.PointsList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("SquaresNeedToBeUpdated")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("PointsLists");
                });

            modelBuilder.Entity("SquaresAPI.Entities.PointsList", b =>
                {
                    b.OwnsMany("SquaresAPI.Entities.Point", "Points", b1 =>
                        {
                            b1.Property<int>("PointsListId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("X")
                                .HasColumnType("int");

                            b1.Property<int>("Y")
                                .HasColumnType("int");

                            b1.HasKey("PointsListId", "Id");

                            b1.ToTable("PointsLists_Points");

                            b1.WithOwner()
                                .HasForeignKey("PointsListId");
                        });

                    b.OwnsMany("SquaresAPI.Entities.Square", "Squares", b1 =>
                        {
                            b1.Property<int>("PointsListId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.HasKey("PointsListId", "Id");

                            b1.ToTable("Square");

                            b1.WithOwner()
                                .HasForeignKey("PointsListId");

                            b1.OwnsMany("SquaresAPI.Entities.Point", "Points", b2 =>
                                {
                                    b2.Property<int>("SquarePointsListId")
                                        .HasColumnType("int");

                                    b2.Property<int>("SquareId")
                                        .HasColumnType("int");

                                    b2.Property<int>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("int")
                                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                                    b2.Property<int>("X")
                                        .HasColumnType("int");

                                    b2.Property<int>("Y")
                                        .HasColumnType("int");

                                    b2.HasKey("SquarePointsListId", "SquareId", "Id");

                                    b2.ToTable("Square_Points");

                                    b2.WithOwner()
                                        .HasForeignKey("SquarePointsListId", "SquareId");
                                });

                            b1.Navigation("Points");
                        });

                    b.Navigation("Points");

                    b.Navigation("Squares");
                });
#pragma warning restore 612, 618
        }
    }
}
