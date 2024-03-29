﻿// <auto-generated />
using EfcDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfcDataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("Domain.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubForumId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Domain.Models.SubForum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OwnerUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username");

                    b.ToTable("SubForums");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.Post", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany("MyPosts")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("Domain.Models.SubForum", b =>
                {
                    b.HasOne("Domain.Models.User", null)
                        .WithMany("MyForums")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("MyForums");

                    b.Navigation("MyPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
