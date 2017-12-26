using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using WcfService.Models.Mapping;

namespace WcfService.Models
{
    public partial class UrunDetailContext : DbContext
    {
        static UrunDetailContext()
        {
            Database.SetInitializer<UrunDetailContext>(null);
        }

        public UrunDetailContext()
            : base("Name=UrunDetailContext")
        {
        }

        public DbSet<Bedenler> Bedenlers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<UrunCinsleri> UrunCinsleris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BedenlerMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UrunCinsleriMap());
        }
    }
}
