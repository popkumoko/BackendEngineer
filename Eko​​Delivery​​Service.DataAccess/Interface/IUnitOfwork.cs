using EkoDeliveryService.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.DataAccess.Interface
{
    public interface IUnitOfwork
    {
        List<ConnectModel> ARepository { get; set; }
        List<ConnectModel> BRepository { get; set; }
        List<ConnectModel> CRepository { get; set; }
        List<ConnectModel> DRepository { get; set; }
        List<ConnectModel> ERepository { get; set; }
        List<ConnectModel> FRepository { get; set; }
    }
}
