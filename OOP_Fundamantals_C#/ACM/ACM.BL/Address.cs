using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string StreetAddress 
        { 
            get 
            {
                string streetAddress = AddressLine1 + " " + AddressLine2;

                return streetAddress;

            }
        }

        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public int AddressType { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(StreetAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;
            if (string.IsNullOrWhiteSpace(StateOrProvince)) isValid = false;
            if (PostalCode == null) isValid = false;

            return isValid;
        }
    }
}
