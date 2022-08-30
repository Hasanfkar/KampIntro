using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Id = 1;
            product1.CategoryId = 5;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            //int sayi = 100;

            //ProductManager productManager = new ProductManager();
            //productManager.Add(product1);
            //productManager.Change1(sayi);
            //productManager.Change2(product1);

            //Console.WriteLine(sayi);
            //Console.WriteLine(product1.ProductName);



        }
    }
}
