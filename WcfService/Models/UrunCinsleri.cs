using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class UrunCinsleri
    {
        public UrunCinsleri()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string UrunCinsiAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
