using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public ProductRepository Product { get; set; }
        public int Quantity { get; set; }
        public double? PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (Product == null) isValid = false;
            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            return isValid;
        }
        public OrderItem Retrieve()
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

    }
}
