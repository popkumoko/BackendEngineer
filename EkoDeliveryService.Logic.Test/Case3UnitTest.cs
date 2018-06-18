using EkoDeliveryService.DataAccess.Implement;
using EkoDeliveryService.Logic.Service.Implement;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EkoDeliveryService.Logic.Test
{
    public class Case3UnitTest
    {
        [Fact]
        public void RouteEToDCheapestIs9()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case3Service(UnitOfWork);

            var mockDataStart = "E";
            var mockDataEnd = "D";
            var output = Service.CalculateCheapestDeliveryCost(mockDataStart,mockDataEnd);

            //Assert
            Assert.True(output == 9, "Output was not equal 9");
        }

        [Fact]
        public void RouteEToDInputIsLower()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case3Service(UnitOfWork);

            var mockDataStart = "e";
            var mockDataEnd = "d";
            var output = Service.CalculateCheapestDeliveryCost(mockDataStart, mockDataEnd);

            //Assert
            Assert.True(output == 9, "Output was not equal 9");
        }

        [Fact]
        public void RouteEToECheapestIs6()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case3Service(UnitOfWork);

            var mockDataStart = "E";
            var mockDataEnd = "E";
            var output = Service.CalculateCheapestDeliveryCost(mockDataStart, mockDataEnd);

            //Assert
            Assert.True(output == 6, "Output was not equal 6");
        }

        [Fact]
        public void RouteEToEInputIsLower()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case3Service(UnitOfWork);

            var mockDataStart = "e";
            var mockDataEnd = "e";
            var output = Service.CalculateCheapestDeliveryCost(mockDataStart, mockDataEnd);

            //Assert
            Assert.True(output == 6, "Output was not equal 6");
        }
    }
}
