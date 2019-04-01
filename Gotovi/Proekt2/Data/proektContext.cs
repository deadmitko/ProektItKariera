using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proekt2.Models;

namespace Proekt2.Data.Models
{
    public partial class proektContext : DbContext
    {
        public proektContext()
        {
        }

        public proektContext(DbContextOptions<proektContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<UserUi> UserUi { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=proekt;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Files>(entity =>
            {
                entity.ToTable("files");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ext)
                    .HasColumnName("ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.File).HasColumnName("file");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserUi>(entity =>
            {
                entity.ToTable("user_ui");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Ui1)
                    .IsRequired()
                    .HasColumnName("ui1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('black')");

                entity.Property(e => e.Ui2)
                    .IsRequired()
                    .HasColumnName("ui2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('gray')");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.First)
                    .HasColumnName("first")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Last)
                    .HasColumnName("last")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
