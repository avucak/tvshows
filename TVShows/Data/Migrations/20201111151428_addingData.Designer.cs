﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(TVShowsContext))]
    [Migration("20201111151428_addingData")]
    partial class addingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Data.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("EpisodeLength")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Synopsis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EpisodeLength = 60.0,
                            Name = "Umbrella Academy",
                            Synopsis = "It's sort of like the fantastic four or X-men"
                        },
                        new
                        {
                            Id = 2,
                            EpisodeLength = 23.5,
                            Name = "Love is war",
                            Synopsis = "They think they're smart but they are basically tsunderes"
                        },
                        new
                        {
                            Id = 3,
                            EpisodeLength = 24.0,
                            Name = "Fullmetal Alchemist: Brotherhood",
                            Synopsis = "Many would say it's the best show ever made"
                        },
                        new
                        {
                            Id = 4,
                            EpisodeLength = 58.0,
                            Name = "The Boys",
                            Synopsis = "Superheroes, again"
                        });
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Username = "Carson"
                        },
                        new
                        {
                            Id = 2,
                            Username = "Meredith"
                        },
                        new
                        {
                            Id = 3,
                            Username = "Arthur"
                        },
                        new
                        {
                            Id = 4,
                            Username = "Lila"
                        });
                });

            modelBuilder.Entity("Data.Models.UserShow", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<int?>("ShowStatus")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ShowId");

                    b.HasIndex("ShowId");

                    b.ToTable("UserShows");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ShowId = 1,
                            ShowStatus = 2
                        },
                        new
                        {
                            UserId = 1,
                            ShowId = 2,
                            ShowStatus = 0
                        },
                        new
                        {
                            UserId = 1,
                            ShowId = 4,
                            ShowStatus = 0
                        },
                        new
                        {
                            UserId = 2,
                            ShowId = 4,
                            ShowStatus = 0
                        },
                        new
                        {
                            UserId = 3,
                            ShowId = 2,
                            ShowStatus = 1
                        },
                        new
                        {
                            UserId = 3,
                            ShowId = 3,
                            ShowStatus = 2
                        },
                        new
                        {
                            UserId = 4,
                            ShowId = 1,
                            ShowStatus = 2
                        },
                        new
                        {
                            UserId = 4,
                            ShowId = 2,
                            ShowStatus = 1
                        },
                        new
                        {
                            UserId = 4,
                            ShowId = 4
                        });
                });

            modelBuilder.Entity("Data.Models.UserShow", b =>
                {
                    b.HasOne("Data.Models.Show", "Show")
                        .WithMany("UserShows")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Models.User", "User")
                        .WithMany("UserShows")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Models.Show", b =>
                {
                    b.Navigation("UserShows");
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Navigation("UserShows");
                });
#pragma warning restore 612, 618
        }
    }
}
