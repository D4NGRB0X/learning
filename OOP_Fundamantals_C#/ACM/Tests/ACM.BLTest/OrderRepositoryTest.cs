using ACM.BL;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //--ARRANGE
            OrderRepository orderRepo = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, 00, new TimeSpan(7, 0, 0)),
            };
            //--ACT
            var actual = orderRepo.Retrieve(10);
            //--ASSERT
            Assert.Equal(expected.OrderDate, actual.OrderDate);
        }
    }
}
