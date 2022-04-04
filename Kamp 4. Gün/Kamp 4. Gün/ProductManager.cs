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
            product.ProductName = "Kamera";
        }

        public void Test(int sayi)
        {
            sayi = 99;
        }
    }
}
