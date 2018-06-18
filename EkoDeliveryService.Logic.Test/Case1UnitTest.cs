using EkoDeliveryService.DataAccess.Implement;
using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.Logic.Service.Implement;
using Moq;
using System;
using Xunit;

namespace EkoDeliveryService.Logic.Test
{
    public class Case1UnitTest
    {
        [Fact]
        public void RouteABE()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case1Service(UnitOfWork);

            var mockData = "A-B-E";
            var output = Service.CalculateDeliveryCost(mockData);

            //Assert
            Assert.True(output == 4, "Output was not equal 4");
        }

        [Fact]
        public void RouteABEInputIsLower()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case1Service(UnitOfWork);

            var mockData = "a-b-e";
            var output = Service.CalculateDeliveryCost(mockData);

            //Assert
            Assert.True(output == 4, "Output was not equal 4");
        }

        [Fact]
        public void RouteAD()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case1Service(UnitOfWork);

            var mockData = "A-D";
            var output = Service.CalculateDeliveryCost(mockData);

            //Assert
            Assert.True(output == 10, "Output was not equal 10");
        }

        [Fact]
        public void RouteEACF()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case1Service(UnitOfWork);

            var mockData = "E-A-C-F";
            var output = Service.CalculateDeliveryCost(mockData);

            //Assert
            Assert.True(output == 8, "Output was not equal 8");
        }

        [Fact]
        public void RouteADF()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case1Service(UnitOfWork);

            var mockData = "A-D-F";
            var output = Service.CalculateDeliveryCost(mockData);

            //Assert
            Assert.True(output == 0, "Output was not equal 0");
        }
    }
}
