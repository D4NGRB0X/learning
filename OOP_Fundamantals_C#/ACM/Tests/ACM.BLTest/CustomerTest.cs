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

        [Fact]
        public void FullNameFirstNameEmpty()
        {    //--ARRANGE
            Customer customer = new Customer
            { 
                LastName = "Baggins" 
            };
            string expected = "Baggins";
            //--ACT
            string actual = customer.FullName;
            //--ASSERT
            Assert.Equal(expected, actual);
        }

       [Fact]
       public void FullNameLastNameEmpty()
        {
            //--ARRANGE
            Customer customer = new Customer
            { 
                FirstName = "Bilbo" 
            };

            string expected = "Bilbo";

            //--ACT
            string actual = customer.FullName;

            //--ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
