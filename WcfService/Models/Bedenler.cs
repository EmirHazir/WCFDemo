using System;
using System.Collections.Generic;

namespace WcfService.Models
{
    public partial class Bedenler
    {
        public Bedenler()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string BedenAdi { get; set; }
        public string BedenAciklama { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
