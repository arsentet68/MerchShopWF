using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MerchShopWF;

public partial class MerchShopDatabaseContext : DbContext
{
    public MerchShopDatabaseContext()
    {
    }

    public MerchShopDatabaseContext(DbContextOptions<MerchShopDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Album> Albums { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemOrder> ItemOrders { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Performer> Performers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MERCH_SHOP_DATABASE;Username=postgres;Password=1488");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("albums_pkey");

            entity.ToTable("albums");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PerformerId).HasColumnName("performer_id");
            entity.Property(e => e.Year).HasColumnName("year");

            entity.HasOne(d => d.Performer).WithMany(p => p.Albums)
                .HasForeignKey(d => d.PerformerId)
                .HasConstraintName("albums_performer_id_fkey");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("customers_pkey");

            entity.ToTable("customers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("items_pkey");

            entity.ToTable("items");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlbumId).HasColumnName("album_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");

            entity.HasOne(d => d.Album).WithMany(p => p.Items)
                .HasForeignKey(d => d.AlbumId)
                .HasConstraintName("items_album_id_fkey");
        });

        modelBuilder.Entity<ItemOrder>(entity =>
        {
            entity.HasKey(e => new { e.ItemId, e.OrderId }).HasName("item_order_pkey");

            entity.ToTable("item_order");

            entity.Property(e => e.ItemId).HasColumnName("item_id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.Units).HasColumnName("units");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemOrders)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_order_item_id_fkey");

            entity.HasOne(d => d.Order).WithMany(p => p.ItemOrders)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_order_order_id_fkey");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DeliveryAddress)
                .HasColumnType("character varying")
                .HasColumnName("delivery_address");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TotalPrice).HasColumnName("total_price");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("orders_customer_id_fkey");
        });

        modelBuilder.Entity<Performer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("performers_pkey");

            entity.ToTable("performers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Country)
                .HasColumnType("character varying")
                .HasColumnName("country");
            entity.Property(e => e.DebutYear)
                .HasColumnType("character varying")
                .HasColumnName("debut_year");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
