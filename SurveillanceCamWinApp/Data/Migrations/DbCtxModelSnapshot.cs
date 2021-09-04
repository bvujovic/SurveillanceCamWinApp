﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveillanceCamWinApp.Data;

namespace SurveillanceCamWinApp.Migrations
{
    [DbContext(typeof(DbCtx))]
    partial class DbCtxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18");

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.AppSetting", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.Camera", b =>
                {
                    b.Property<int>("IdCam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IpLastNum")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastImageDL")
                        .HasColumnType("TEXT");

                    b.HasKey("IdCam");

                    b.ToTable("Cameras");
                });

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.DateDir", b =>
                {
                    b.Property<int>("IdDateDir")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CameraId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImgCountLocal")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ImgCountSDC")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("IdDateDir");

                    b.HasIndex("CameraId");

                    b.ToTable("DateDirs");
                });

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.ImageFile", b =>
                {
                    b.Property<int>("IdImageFile")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DateDirId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ExistsOnSDC")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("IdImageFile");

                    b.HasIndex("DateDirId");

                    b.ToTable("ImageFiles");
                });

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.DateDir", b =>
                {
                    b.HasOne("SurveillanceCamWinApp.Data.Models.Camera", "Camera")
                        .WithMany("DateDirs")
                        .HasForeignKey("CameraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurveillanceCamWinApp.Data.Models.ImageFile", b =>
                {
                    b.HasOne("SurveillanceCamWinApp.Data.Models.DateDir", "DateDir")
                        .WithMany("ImageFiles")
                        .HasForeignKey("DateDirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
