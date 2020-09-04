using ACM.BL;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ACM.BLTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderDateTest()
        {
            //--ARRANGE
            Order order = new Order
            { OrderDate = "09/04/2020" };
            var expected = "09/04/2020";
            //--ACT
            var actual = order.OrderDate;
            //--ASSERT
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateValid()
        {
            //--ARRANGE
            Order order = new Order { OrderDate = DateTime.Now.ToString() };
            var expected = true;
            //--ACT
            var actual = order.Validate();
            //--ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
