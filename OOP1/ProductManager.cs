using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Products product)
        {
            Console.WriteLine("Ürün eklendi :" + product.ProductName );
        }

        //public void Change1(int sayi)
        //{
        //    sayi = 200;
        //}

        //public void Change2(Products product)
        //{
        //    product.ProductName = "Kasa";
        //}
    }
}
