using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer =  new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@theshire.home";
                customer.FirstName = "Froodo";
                customer.LastName = "Baggins";
                customer.CustomerAddresses = addressRepository.RetrieveByCustomerId(customerId).ToList();
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
