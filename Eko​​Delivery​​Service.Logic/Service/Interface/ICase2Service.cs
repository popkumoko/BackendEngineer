using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.Logic.Service.Interface
{
    public interface ICase2Service
    {
        int GetPossibleDeliveryRouteWithMaximum(string StartNode, string EndNode, int Max);
    }
}
