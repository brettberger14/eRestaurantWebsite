using eRestaurant.Data.Entities;
using System.Data.Entity;
using System.Web.UI.WebControls;

namespace eRestaurant.Data.DAL
{
    // : DbContext means that my class ingerits from the DbContext class
    internal class RestaurantContext : DbContext
    {
        // : base(string) is the constructir of the DbContext class that i call before running the body of my own constructor.
        //hooking up constructors to call other constructors is called "Constructor Chaining"
        public RestaurantContext() : base("name=EatIn") { }
        public DbSet<Entities.Table> Tables { get; set; }

        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Reservation>().HasMany(r => r.Tables)
        //        .WithMany(t => t.Reservations)
        //        .Map(mapping =>
        //        {
        //            mapping.ToTable("ReservationTables");
        //            mapping.MapLeftKey("ReservationID");
        //            mapping.MapRightKey("TableID");
        //        });
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
