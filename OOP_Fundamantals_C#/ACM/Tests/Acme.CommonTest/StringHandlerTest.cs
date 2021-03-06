using Acme.Common;
using System;
using Xunit;


namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void ValidInsertSpaces()
        {
            //--ARRANGE
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";
            

            //--ACT
            var actual = StringHandler.InsertSpaces(source);
            
            //--ASSERT
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void InsertSpacesWithExistingSpaces()
        {
            //--ARRANGE
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //--ACT
            var actual = source.InsertSpaces();

            //--ASSERT
            Assert.Equal(expected, actual);
        }
    }
}
