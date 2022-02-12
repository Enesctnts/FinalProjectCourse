using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            Console.ReadLine();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            Console.WriteLine("***Ürün Adı***" + "\t\t\t\t***Ürün Kategorisi***\n");
            
            foreach (var product in productManager.GetProductDetails())
            {
                var result = product.ProductName.Length;
                Console.Write(product.ProductName);

                for (int i = 0; i < (40-result); i++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine(product.CategoryName);
            }

        }
    }
}
