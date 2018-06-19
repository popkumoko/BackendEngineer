using EkoDeliveryService.Logic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.Logic.UnitOfWork.Interface
{
    public interface ILogicUnitOfWork
    {
        ICase1Service Case1Service { get; set; }
        ICase2Service Case2Service { get; set; }
        ICase3Service Case3Service { get; set; }
    }
}
