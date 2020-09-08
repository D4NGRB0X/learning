using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPriceNow { get; set; }
        public int ProductId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (ProductPriceNow == null) isValid = false;
            return isValid;
        }


    }
}
