﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sandwich_King_DB.Data.EndToEnd
{
    public partial class EndToEndContext : DbContext
    {
        public EndToEndContext()
        {
        }

        public EndToEndContext(DbContextOptions<EndToEndContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<ImageTagMap> ImageTagMap { get; set; }
        public virtual DbSet<ImageTags> ImageTags { get; set; }
        public virtual DbSet<WeatherForecast> WeatherForecast { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImageFilepath).IsUnicode(false);

                entity.Property(e => e.Tags).IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<ImageTagMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ImageId)
                    .HasMaxLength(450)
                    .HasColumnName("ImageID");

                entity.Property(e => e.TagId)
                    .HasMaxLength(450)
                    .HasColumnName("TagID");

                entity.HasOne(d => d.Image)
                    .WithMany()
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_ImageTagMap_Image");

                entity.HasOne(d => d.Tag)
                    .WithMany()
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK_ImageTagMap_ImageTags");
            });

            modelBuilder.Entity<ImageTags>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_Tags");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeatherForecast>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Summary).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}