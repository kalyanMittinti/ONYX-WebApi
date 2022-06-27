using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onxy.models
{
   public class Product
    {
        public int RecordId { get; set; }
        public string Productname   { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public string categoryUrl { get; set; }
        public string BrandName { get; set; }
        public string SeriesName { get; set; }
        public string Type { get; set; }
        public bool Isactive  { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Datetime { get; set; }

    }
}
