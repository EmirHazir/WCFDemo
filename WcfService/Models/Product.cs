using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public string UrunBarkod { get; set; }
        public string UrunEan { get; set; }
        public string RenkKodu { get; set; }

        public Nullable<int> UrunCinsID { get; set; }
        public virtual Bedenler Bedenler { get; set; }
        public Nullable<int> BedenID { get; set; }
        public virtual UrunCinsleri UrunCinsleri { get; set; }
    }
}
