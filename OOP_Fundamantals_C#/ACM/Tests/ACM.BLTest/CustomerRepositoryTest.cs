using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //--ARRANGE
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                
                EmailAddress = "fbaggins@theshire.home",
                FirstName = "Froodo",
                LastName = "Baggins",
                CustomerAddresses = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        AddressLine1 = "Bag End",
                        AddressLine2 = "Bagshot row",
                        City = "Hobbiton",
                        StateOrProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144",
                    },

                    new Address()
                    {
                        AddressType = 2,
                        AddressLine1 = "Green Dragon",
                        City = "Bywater",
                        StateOrProvince = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146",
                    },


        }
            };

            //--ACT
            var actual = customerRepository.Retrieve(1);

            //--ASSERT
            Assert.Equal(expected.CustomerId, actual.CustomerId);
            Assert.Equal(expected.EmailAddress, actual.EmailAddress);
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);

            for(int index = 0; index<1; index++)
            {
                Assert.Equal(expected.CustomerAddresses[index].AddressType, actual.CustomerAddresses[index].AddressType);
                Assert.Equal(expected.CustomerAddresses[index].AddressLine1, actual.CustomerAddresses[index].AddressLine1);
                Assert.Equal(expected.CustomerAddresses[index].City, actual.CustomerAddresses[index].City);
                Assert.Equal(expected.CustomerAddresses[index].StateOrProvince, actual.CustomerAddresses[index].StateOrProvince);
                Assert.Equal(expected.CustomerAddresses[index].Country, actual.CustomerAddresses[index].Country);
                Assert.Equal(expected.CustomerAddresses[index].PostalCode, actual.CustomerAddresses[index].PostalCode);
            }

        }


    }
}
