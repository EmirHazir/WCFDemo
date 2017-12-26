using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Models
{
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UrunAdi { get; set; }
        [DataMember]
        public string UrunBarkod { get; set; }
        [DataMember]
        public string UrunEan { get; set; }
        [DataMember]
        public string RenkKodu { get; set; }
    }
}