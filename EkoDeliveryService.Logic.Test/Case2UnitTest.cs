using EkoDeliveryService.DataAccess.Implement;
using EkoDeliveryService.Logic.Service.Implement;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EkoDeliveryService.Logic.Test
{
    public class Case2UnitTest
    {
        [Fact]
        public void RouteABE()
        {
            var UnitOfWork = new UnitOfwork();
            var Service = new Case2Service(UnitOfWork);
            var mockDataStart = "E";
            var mockDataEnd = "D";
            var mockMaximum = 4;
            var output = Service.GetPossibleDeliveryRouteWithMaximum(mockDataStart,mockDataEnd,mockMaximum);

            //Assert
            Assert.True(output == 4, "Output was not equal 4");
        }
    }
}
