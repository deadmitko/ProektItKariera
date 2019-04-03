using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ConsoleApp28.Data.Models;
namespace ConsoleApp28.Data
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

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Favourites> Favourites { get; set; }
        public virtual DbSet<Personals> Personals { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<UserUi> UserUi { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=USER-PC\\SQLEXPRESS;Database=proekt;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.ToTable("comments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.ReceiptId).HasColumnName("receipt_id");

                entity.Property(e => e.Text)
                    .HasColumnName("text")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_comments_users");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ReceiptId)
                    .HasConstraintName("FK_comments_receipts");
            });

            modelBuilder.Entity<Favourites>(entity =>
            {
                entity.ToTable("favourites");

                entity.HasIndex(e => e.IdUser)
                    .HasName("FK1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Favourites)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");
            });

            modelBuilder.Entity<Personals>(entity =>
            {
                entity.ToTable("personals");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_personals_users");
            });

            modelBuilder.Entity<Receipts>(entity =>
            {
                entity.ToTable("receipts");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_receipts_users");
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

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserUi)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_user_ui_users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

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
