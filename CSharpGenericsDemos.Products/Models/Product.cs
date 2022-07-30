using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericsDemos.Products.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string LOT { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

        public Product(string sku, string name, string lot)
        {
            Id = Guid.NewGuid();
            SKU = sku;
            Name = name;
            LOT = lot;
        }

    }
}
