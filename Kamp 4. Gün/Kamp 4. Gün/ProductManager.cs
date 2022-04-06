using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp_4.Gün
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " Eklendi.");

        }

        //public void Test(int sayi)
        //{
        //    sayi = 99;
        //}

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        //public int Topla(int sayi1, int sayi2)
        //{ 
        //    return sayi1 + sayi2; 
        //}

        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
