using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ACM.BL
{
    public class Product : EntityBase
    {


        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        private string _productName;
        public string ProductName 
        {
            get 
            {
                var stringHandler = new StringHandler();
                return stringHandler.InsertSpaces(_productName);
            }  
            set 
            {
                _productName = value; 
            
            } 
        }
        public string ProductDescription { get; set; }
        public decimal? ProductPriceNow { get; set; }
        public int ProductId { get; private set; }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (ProductPriceNow == null) isValid = false;
            return isValid;
        }


    }
}
