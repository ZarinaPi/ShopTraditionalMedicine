using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace coursework
{
    public partial class shopContext : DbContext
    {
        private static shopContext _context;

        public shopContext()
        {
        }

        public shopContext(DbContextOptions<shopContext> options)
            : base(options)
        {
        }

        public static shopContext GetContext()
        {
            if (_context == null)
                _context = new shopContext();
            return _context;
        }

        public virtual DbSet<Authorization> Authorizations { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrdersProduct> OrdersProducts { get; set; }
        public virtual DbSet<OrdersV> OrdersVs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductsV> ProductsVs { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<UnitProduct> UnitProducts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersV> UsersVs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\zarin\\OneDrive\\Рабочий стол\\ДИПЛОМ\\БД\\shop.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>(entity =>
            {
                entity.HasKey(e => e.IdAuthorization);

                entity.HasIndex(e => e.IdAuthorization, "IX_Authorizations_id_authorization")
                    .IsUnique();

                entity.Property(e => e.IdAuthorization).HasColumnName("id_authorization");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Authorizations)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient);

                entity.HasIndex(e => e.IdClient, "IX_Clients_id_client")
                    .IsUnique();

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.MobileNumberClient).HasColumnName("mobile_number_client");

                entity.Property(e => e.NameClient).HasColumnName("name_client");

                entity.Property(e => e.PatronymicClient).HasColumnName("patronymic_client");

                entity.Property(e => e.SurnameClient).HasColumnName("surname_client");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.HasIndex(e => e.IdOrder, "IX_Orders_id_order")
                    .IsUnique();

                entity.Property(e => e.IdOrder).HasColumnName("id_order");

                entity.Property(e => e.IdClient).HasColumnName("id_client");

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.PriceOrders).HasColumnName("price_orders");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdClient);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdStatus);

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdUser);
            });

            modelBuilder.Entity<OrdersProduct>(entity =>
            {
                entity.HasKey(e => new { e.IdOrders, e.IdProducts });

                entity.Property(e => e.IdOrders).HasColumnName("id_orders");

                entity.Property(e => e.IdProducts).HasColumnName("id_products");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.HasOne(d => d.IdOrdersNavigation)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.IdOrders)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.IdProductsNavigation)
                    .WithMany(p => p.OrdersProducts)
                    .HasForeignKey(d => d.IdProducts)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrdersV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Orders_v");

                entity.Property(e => e.IdOrder).HasColumnName("id_order");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.NameStatus).HasColumnName("name_status");

                entity.Property(e => e.PriceOrders).HasColumnName("price_orders");

                entity.Property(e => e.SurnameClient).HasColumnName("surname_client");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct);

                entity.HasIndex(e => e.IdProduct, "IX_Products_id_product")
                    .IsUnique();

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.IdUnitProduct).HasColumnName("id_unit_product");

                entity.Property(e => e.NameProduct).HasColumnName("name_product");

                entity.Property(e => e.PriceProduct).HasColumnName("price_product");

                entity.Property(e => e.QuantityProduct).HasColumnName("quantity_product");

                entity.HasOne(d => d.IdUnitProductNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdUnitProduct);
            });

            modelBuilder.Entity<ProductsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Products_v");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.NameProduct).HasColumnName("name_product");

                entity.Property(e => e.NameUnitProduct).HasColumnName("name_unit_product");

                entity.Property(e => e.PriceProduct).HasColumnName("price_product");

                entity.Property(e => e.QuantityProduct).HasColumnName("quantity_product");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.HasIndex(e => e.IdStatus, "IX_Statuses_id_status")
                    .IsUnique();

                entity.Property(e => e.IdStatus).HasColumnName("id_status");

                entity.Property(e => e.NameStatus).HasColumnName("name_status");
            });

            modelBuilder.Entity<UnitProduct>(entity =>
            {
                entity.HasKey(e => e.IdUnitProduct);

                entity.HasIndex(e => e.IdUnitProduct, "IX_UnitProducts_id_unit_product")
                    .IsUnique();

                entity.Property(e => e.IdUnitProduct).HasColumnName("id_unit_product");

                entity.Property(e => e.NameUnitProduct).HasColumnName("name_unit_product");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.HasIndex(e => e.IdUser, "IX_Users_id_user")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.AddressUser).HasColumnName("address_user");

                entity.Property(e => e.MobileNumberUser).HasColumnName("mobile_number_user");

                entity.Property(e => e.NameUser).HasColumnName("name_user");

                entity.Property(e => e.PatronymicUser).HasColumnName("patronymic_user");

                entity.Property(e => e.SurnameUser).HasColumnName("surname_user");
            });

            modelBuilder.Entity<UsersV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Users_v");

                entity.Property(e => e.AddressUser).HasColumnName("address_user");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.MobileNumberUser).HasColumnName("mobile_number_user");

                entity.Property(e => e.NameUser).HasColumnName("name_user");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PatronymicUser).HasColumnName("patronymic_user");

                entity.Property(e => e.Role).HasColumnName("role");

                entity.Property(e => e.SurnameUser).HasColumnName("surname_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
