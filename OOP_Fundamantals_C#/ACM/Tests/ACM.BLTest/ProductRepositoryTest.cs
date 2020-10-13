using ACM.BL;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void ProductRetrieveValid()
        {
            //--ARRANGE
            ProductRepository productRepo = new ProductRepository();
            var expected = new Product(2)
            {
                ProductName = "Sting",
                ProductDescription = "Human sized dagger that glows blue when Orcs are in the area",
                ProductPriceNow = 1000.00M,
            };

            //--ACT
            var actual = productRepo.Retrieve(2);
            //--ASSERT
            Assert.Equal(expected.ProductPriceNow, actual.ProductPriceNow);
            Assert.Equal(expected.ProductDescription, actual.ProductDescription);
            Assert.Equal(expected.ProductName, actual.ProductName );
        }
    }
}
