using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService.Models;

namespace WcfService
{
    public class ProductService : IProductService
    {
        public string DoWork()
        {
            return "Hello WCF";
        }


        UrunDetailContext _context = new UrunDetailContext();
        public List<ProductDTO> ProductList()
        {
            return _context.Products.Select(x => new ProductDTO
            {
                Id = x.Id,
                RenkKodu = x.RenkKodu,
                UrunAdi = x.UrunAdi,
                UrunBarkod = x.UrunBarkod,
                UrunEan = x.UrunEan
            }).ToList();
        }
    }
}
