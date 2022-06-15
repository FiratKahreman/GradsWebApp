﻿// <auto-generated />
using System;
using GradsApp.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GradsApp.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GradsApp.Core.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CardProfileId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RemainingDiscounts")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsedDiscountsOnAll")
                        .HasColumnType("int");

                    b.Property<int>("UsedDiscountsOnMonth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("GradsApp.Core.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("GradsApp.Core.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("GradsApp.Core.Models.FacultyProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("ProgramName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("FacultyPrograms");
                });

            modelBuilder.Entity("GradsApp.Core.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("GradsApp.Core.Models.SocialComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommentProfileId")
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int?>("SocialPostId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CommentProfileId");

                    b.HasIndex("SocialPostId");

                    b.ToTable("SocialComments");
                });

            modelBuilder.Entity("GradsApp.Core.Models.SocialPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("PostProfileId")
                        .HasColumnType("int");

                    b.Property<string>("PostText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostProfileId");

                    b.ToTable("SocialPosts");
                });

            modelBuilder.Entity("GradsApp.Core.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyProgramId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GotCard")
                        .HasColumnType("bit");

                    b.Property<string>("GradType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsGrad")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorking")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PictureId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CardId")
                        .IsUnique()
                        .HasFilter("[CardId] IS NOT NULL");

                    b.HasIndex("FacultyId");

                    b.HasIndex("FacultyProgramId");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("GradsApp.Core.Models.FacultyProgram", b =>
                {
                    b.HasOne("GradsApp.Core.Models.Faculty", "Faculty")
                        .WithMany("FacultyPrograms")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("GradsApp.Core.Models.SocialComment", b =>
                {
                    b.HasOne("GradsApp.Core.Models.UserProfile", "CommentProfile")
                        .WithMany("SocialComments")
                        .HasForeignKey("CommentProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GradsApp.Core.Models.SocialPost", "SocialPost")
                        .WithMany("SocialComments")
                        .HasForeignKey("SocialPostId");

                    b.Navigation("CommentProfile");

                    b.Navigation("SocialPost");
                });

            modelBuilder.Entity("GradsApp.Core.Models.SocialPost", b =>
                {
                    b.HasOne("GradsApp.Core.Models.UserProfile", "PostProfile")
                        .WithMany("SocialPosts")
                        .HasForeignKey("PostProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PostProfile");
                });

            modelBuilder.Entity("GradsApp.Core.Models.UserProfile", b =>
                {
                    b.HasOne("GradsApp.Core.Models.Card", "ProfileCard")
                        .WithOne("CardProfile")
                        .HasForeignKey("GradsApp.Core.Models.UserProfile", "CardId");

                    b.HasOne("GradsApp.Core.Models.Faculty", null)
                        .WithMany("UserProfiles")
                        .HasForeignKey("FacultyId");

                    b.HasOne("GradsApp.Core.Models.FacultyProgram", "FacultyProgram")
                        .WithMany("UserProfiles")
                        .HasForeignKey("FacultyProgramId");

                    b.Navigation("FacultyProgram");

                    b.Navigation("ProfileCard");
                });

            modelBuilder.Entity("GradsApp.Core.Models.Card", b =>
                {
                    b.Navigation("CardProfile");
                });

            modelBuilder.Entity("GradsApp.Core.Models.Faculty", b =>
                {
                    b.Navigation("FacultyPrograms");

                    b.Navigation("UserProfiles");
                });

            modelBuilder.Entity("GradsApp.Core.Models.FacultyProgram", b =>
                {
                    b.Navigation("UserProfiles");
                });

            modelBuilder.Entity("GradsApp.Core.Models.SocialPost", b =>
                {
                    b.Navigation("SocialComments");
                });

            modelBuilder.Entity("GradsApp.Core.Models.UserProfile", b =>
                {
                    b.Navigation("SocialComments");

                    b.Navigation("SocialPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
