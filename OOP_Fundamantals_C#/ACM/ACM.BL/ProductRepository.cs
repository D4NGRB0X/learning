using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            //testing
            if(productId == 2)
            {
                product.ProductName = "Sting";
                product.ProductDescription = "Human sized dagger that glows blue when Orcs are in the area";
                product.ProductPriceNow = 1000.00M;
            }

            return product;
            //return new Product(productId);
        }

        public bool Save()
        {
            return true;
        }
    }
}
