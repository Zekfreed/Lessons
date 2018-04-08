﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TraineeManagement.Data;

namespace TraineeManagement.Migrations
{
    [DbContext(typeof(TraineeManagementContext))]
    [Migration("20180407235509_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TraineeManagement.Data.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("TraineeManagement.Data.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("TraineeManagement.Data.Traineeship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BeginDate");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("TraineeId");

                    b.HasKey("Id");

                    b.HasIndex("TraineeId");

                    b.ToTable("TraineeShips");
                });

            modelBuilder.Entity("TraineeManagement.Data.Traineeship", b =>
                {
                    b.HasOne("TraineeManagement.Data.Trainee", "Trainee")
                        .WithMany("Traineeships")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
