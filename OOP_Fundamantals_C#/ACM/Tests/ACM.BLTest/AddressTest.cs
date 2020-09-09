using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class AddressTest
    {
        [Fact]
        public void StreetAddressValid()
        {
            //--ARRANGE
            Address address = new Address()
            {
                AddressLine1 = "4 Underhill",
                AddressLine2 = "#1",
            };
            var expected = "4 Underhill #1";
            //--ACT
            var actual = address.StreetAddress;
            //--ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
