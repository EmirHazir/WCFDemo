using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WcfService.Models.Mapping
{
    public class UrunCinsleriMap : EntityTypeConfiguration<UrunCinsleri>
    {
        public UrunCinsleriMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UrunCinsiAdi)
                .HasMaxLength(50);

            this.Property(t => t.Aciklama)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UrunCinsleri");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunCinsiAdi).HasColumnName("UrunCinsiAdi");
            this.Property(t => t.Aciklama).HasColumnName("Aciklama");
        }
    }
}
