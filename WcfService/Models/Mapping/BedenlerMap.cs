using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WcfService.Models.Mapping
{
    public class BedenlerMap : EntityTypeConfiguration<Bedenler>
    {
        public BedenlerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BedenAdi)
                .HasMaxLength(50);

            this.Property(t => t.BedenAciklama)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bedenler");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BedenAdi).HasColumnName("BedenAdi");
            this.Property(t => t.BedenAciklama).HasColumnName("BedenAciklama");
        }
    }
}
