namespace Cards
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Disptach> Disptaches { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<ReceiveOrder> ReceiveOrders { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Items)
                .WithOptional(e => e.Supplier)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.ReceiveOrders)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
