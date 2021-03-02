using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using Store.Core;
using Store.Core.ApplicationService.Implementations;
using Store.Core.Entities;
using Xunit;

namespace Store.Tests
{
    public class ProductServiceTests
    {
        [Fact]
        public void GetAllProducts_WithName_CallsGetAllByName()
        {
            var productRepositoryStub = new Mock<IDataRepository>();
            productRepositoryStub.Setup(x => x.GetProductByName(It.IsAny<string>()))
                .Returns(new List<Product>
                {
                    new Product { Id = 1, Name = "Name", Category="Cat1", Description = "description", Price = 100},
                });
            var productService = new DataService(productRepositoryStub.Object);
            var actual = productService.GetAllProductsByName("Name");

            Assert.Collection(actual, product => Assert.Equal(1, product.Id));
        }
    }
}
