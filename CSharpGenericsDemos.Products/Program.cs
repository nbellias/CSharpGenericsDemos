// See https://aka.ms/new-console-template for more information
using CSharpGenericsDemos.Products.Models;

Console.WriteLine("CSharpGenerics program\n");

// Note the new ways for instantiating objects
Book book = new("123-456-7890", "Elsevier", "890567", "Technical Book on Libs", "2022-01012T12:23:34Z");
SmallAppliance _hairDryer = new SmallAppliance { Name = "Hair Dryer", Manufacturer = "Braun", Make = "Dry 230", SerNo = "123", LOT = "2019-10-08T12:34:20Z", SKU = "52-0897" };

Database<Product> _db = new Database<Product>();
_db.ItemList.Add(book);
_db.ItemList.Add(_hairDryer);

// Console.WriteLine(book);
// Console.WriteLine(_hairDryer);
foreach(Product product in _db.ItemList)
{
    Console.WriteLine(product);
}