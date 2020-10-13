using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    { 
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if(addressId == 1)
            {
                address.AddressType = 1;
                address.AddressLine1 = "Bag End";
                address.AddressLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.StateOrProvince = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var customerAddresses = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                AddressLine1 = "Bag End",
                AddressLine2 = "Bagshot row",
                City = "Hobbiton",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
            };
            customerAddresses.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                AddressLine1 = "Green Dragon",
                City = "Bywater",
                StateOrProvince = "Shire",
                Country = "Middle Earth",
                PostalCode = "146",
            };
            customerAddresses.Add(address);
            return customerAddresses;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
