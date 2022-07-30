using System;
namespace CSharpGenericsDemos.Products.Models
{
    internal class SmallAppliance : Product
    {
        public string SerNo { get; set; }
        public string Manufacturer { get; set; }
        public string Make { get; set; }

        public SmallAppliance()
        {
        }

        public SmallAppliance(string serno, string manufacturer, string make, string sku, string name, string lot) : base(sku, name, lot)
        {
            SerNo = serno;
            Manufacturer = manufacturer;
            Make = make;
        }

        public override string ToString()
        {
            return $"Product ID:{this.Id}, Type:{this.GetType().Name}, SERNO:\"{this.SerNo}\", Make:\"{this.Make}\", Manufacturer:\"{this.Manufacturer}\", SKU:\"{this.SKU}\", name:\"{this.Name}\", LOT:{this.LOT}";
        }
    }
}

