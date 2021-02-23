using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());

            //var result = productManager.GetProductDetails();
            //if (result.Success)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            var result = productManager.GetAll();
            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //foreach (var product in productManager.GetProductDetails().)
            //{
            //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

            //}

            //static void CategoryTest()
            //{
            //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            //    foreach (var category in categoryManager.GetAll())
            //    {
            //        Console.WriteLine(category.CategoryName);
            //    }
            //}

            //static void ProductTest()
            //{
            //    ProductManager productManager = new ProductManager(new EfProductDal());
            //    foreach (var product in productManager.GetAll())
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //    foreach (var product in productManager.GetAllByCategoryId(2))
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }

            //    foreach (var product in productManager.GetByUnitPrice(40, 100))
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}
        }
    }
}
