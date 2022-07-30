using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenericsDemos.Products.Models
{
    internal class Book : Product
    {

        public string ISBN { get; set; }
        public string Publisher { get; set; }

        public Book()
        {

        }

        public Book(string isbn, string publisher, string sku, string name, string lot) : base(sku, name, lot)
        {
            ISBN = isbn;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"Product ID:{this.Id}, Type:{this.GetType().Name}, ISBN:\"{this.ISBN}\", Publisher:\"{this.Publisher}\", SKU:\"{this.SKU}\", name:\"{this.Name}\", LOT:{this.LOT}";
        }
    }
}
