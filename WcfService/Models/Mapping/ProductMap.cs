using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace WcfService.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.UrunAdi)
                .HasMaxLength(50);

            this.Property(t => t.UrunBarkod)
                .HasMaxLength(50);

            this.Property(t => t.UrunEan)
                .HasMaxLength(50);

            this.Property(t => t.RenkKodu)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UrunAdi).HasColumnName("UrunAdi");
            this.Property(t => t.UrunBarkod).HasColumnName("UrunBarkod");
            this.Property(t => t.UrunEan).HasColumnName("UrunEan");
            this.Property(t => t.BedenID).HasColumnName("BedenID");
            this.Property(t => t.RenkKodu).HasColumnName("RenkKodu");
            this.Property(t => t.UrunCinsID).HasColumnName("UrunCinsID");

            // Relationships
            this.HasOptional(t => t.Bedenler)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.BedenID);
            this.HasOptional(t => t.UrunCinsleri)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.UrunCinsID);

        }
    }
}
