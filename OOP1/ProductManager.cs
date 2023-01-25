using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+ " Başarıyla Sepete Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" Güncellendi.");
        }

    }
}
