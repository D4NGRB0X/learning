using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer =  new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@theshire.home";
                customer.FirstName = "Froodo";
                customer.LastName = "Baggins";
            }
            return customer;

        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
