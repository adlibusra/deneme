using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { CategoryId=1, CategoryName="Bilgisayar"},
                new Category{  CategoryId=2, CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId=1, CategoryId=1, ProductName="Acer LAptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitsInStock=5 },
                new Product{ ProductId=2, CategoryId=1, ProductName="Asus LAptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitsInStock=3 },
                new Product{ ProductId=3, CategoryId=1, ProductName="HP LAptop", QuantityPerUnit="5 GB Ram", UnitPrice=6000, UnitsInStock=2 },
                new Product{ ProductId=4, CategoryId=2, ProductName="Samsung", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitsInStock=15 },
                new Product{ ProductId=5, CategoryId=2, ProductName="Apple", QuantityPerUnit="4 GB Ram", UnitPrice=8000, UnitsInStock=0 },
            };
            // Test(products);
            //AnyTest(products);
            //FindTest(products);
            //FinfAllTest(products);

             // ClassiLinqTest(products);

            Console.ReadLine();
        }

        private static void ClassiLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select p;
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FinfAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 1);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var resulst = products.Any(p => p.ProductName == "Asus LAptop");
            Console.WriteLine(resulst);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik -------------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            Console.WriteLine("Linq--------------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }

    class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string  ProductName { get; set; }

        public string QuantityPerUnit{ get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
    }
}
