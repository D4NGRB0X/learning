using ACM.BL;
using System;
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
            };

            //--ACT
            var actual = customerRepository.Retrieve(1);

            //--ASSERT
            Assert.Equal(expected.CustomerId, actual.CustomerId);
        }


    }
}
