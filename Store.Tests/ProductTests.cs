using System;
using Store.Core.Entities;
using Xunit;

namespace Store.Tests
{
    public class ProductTests
    {
        [Fact]
        public void IsName_WithNull_ReturnFalse()
        {
            bool actual = Product.IsName(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsName_WithBlankString_ReturnFalse()
        {
            bool actual = Product.IsName(" ");

            Assert.False(actual);
        }

        [Fact]
        public void IsName_WithGoodName_ReturnTrue()
        {
            bool actual = Product.IsName("Food");

            Assert.True(actual);
        }
    }
}
