using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //--ARRANGE
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";
            //--ACT

            string actual = customer.FullName;

            //--ASSERT
            Assert.Equal(expected, actual);
        }
    

    }
}
