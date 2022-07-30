using System;
namespace CSharpGenericsDemos.Products.Models
{
	public class Database<T>
	{
		public List<T> ItemList { get; set; }

        public Database()
        {
			ItemList = new List<T>();
        }

	}
}

