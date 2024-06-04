using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group6_Assignment
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, double price, int stock)
        {

            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void IncrementStock(int value)
        {

            Stock += value;
        }

        public void DecrementStock(int value)
        {

            if (Stock >= value)
            {
                Stock -= value;
            }
            else
            {
                Console.WriteLine("Not enough stock to decrease.");
            }
        }
    }
}
