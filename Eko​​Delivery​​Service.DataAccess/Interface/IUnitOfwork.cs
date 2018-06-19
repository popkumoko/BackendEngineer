using EkoDeliveryService.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.DataAccess.Interface
{
    public interface IUnitOfwork
    {
        List<ConnectModel> Graph { get; set; }
    }
}
