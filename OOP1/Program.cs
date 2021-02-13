using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "MAsa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, ProductName="kalem", CategoryId=5, UnitsInStock=5,
                UnitPrice=35};


            //PAscal Case: ilk harfler büyük 
            // camelCase : ilk harf küçük diğerleri büyük
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            productManager.Update(product1);
            Console.WriteLine(product1.ProductName);

           


            Console.ReadLine();
            

        }
    }
}
