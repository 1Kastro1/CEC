using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CakesDB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ingredients> Ingredients { get; set; }
        public virtual DbSet<Izdelie> Izdelie { get; set; }
        public virtual DbSet<PrimerZakaz> PrimerZakaz { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ukrashenia> Ukrashenia { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Izdelie>()
                .Property(e => e.Cost)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Izdelie>()
                .HasMany(e => e.PrimerZakaz)
                .WithRequired(e => e.Izdelie)
                .HasForeignKey(e => new { e.Nomer, e.Date })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ukrashenia>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Ukrashenia>()
                .Property(e => e.Ves)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Izdelie)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.MenegerLogin);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Izdelie1)
                .WithOptional(e => e.Users1)
                .HasForeignKey(e => e.MenegerLogin);
        }
    }
}
