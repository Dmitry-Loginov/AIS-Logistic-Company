using Microsoft.EntityFrameworkCore;

namespace АИС
{

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Tarif> Tarifs { get; set; }
        public DbSet<TypeCargo> TypeCargos { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentMaxItem> ShipmentMaxItems { get; set; }
        public DbSet<ShipmentImport> ShipmentImports { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemMaxId> ItemMaxIds { get; set; }
        public DbSet<ShipmentOut> ShipmentOuts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=DB.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Role)
                .WithMany(t => t.Users)
                .HasForeignKey(p => p.RoleId);
            modelBuilder.Entity<ShipmentMaxItem>(s =>
            {
                s.ToTable("Shipment");
                s.HasOne<Shipment>().WithOne().HasForeignKey<ShipmentMaxItem>(e => e.ShipmentId);
            });
            modelBuilder.Entity<ItemMaxId>(s =>
            {
                s.ToTable("Item");
                s.HasOne<Item>().WithOne().HasForeignKey<ItemMaxId>(e => e.ItemId);
            });
            modelBuilder.Entity<ShipmentImport>(s =>
            {
                s.ToTable("Shipment");
                s.HasOne<Shipment>().WithOne().HasForeignKey<ShipmentImport>(e => e.ShipmentId);
                //s.Property(e => e.ProviderName);
            });
            modelBuilder.Entity<ShipmentOut>(s =>
            {
                s.ToTable("Shipment");
                s.HasOne<Shipment>().WithOne().HasForeignKey<ShipmentOut>(e => e.ShipmentId);
                //s.Property(e => e.ProviderName);
            });
            //modelBuilder.Entity<OrderContext.User>(u =>
            //{
            //    u.ToTable("User");
            //    u.Property(e => e.Email).HasColumnName("Email");
            //    u.HasOne<UserContext.User>().WithOne().HasForeignKey<OrderContext.User>(e => e.Id);
            //});
        }
    }
}