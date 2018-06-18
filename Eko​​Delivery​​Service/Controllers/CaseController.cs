using EkoDeliveryService.Logic.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eko​​Delivery​​Service.Controllers
{
    [Route("api/[controller]")]
    public class CaseController : Controller
    {
        private ILogicUnitOfWork LogicUnitOfWork { get; set; }

        public CaseController(ILogicUnitOfWork LogicUnitOfWork)
        {
            this.LogicUnitOfWork = LogicUnitOfWork;
        }

        [HttpGet("GetDeliveryCost")]
        public object DeliveryCost(string Path)
        {
            var result = LogicUnitOfWork.Case1Service.CalculateDeliveryCost(Path);
            if(result == 0)
            {
                return "No Such Route";
            }
            return result;
        }

        [HttpGet("GetCheapestDeliveryCost")]
        public object GetCheapestDeliveryCost(string Start, string End)
        {
            var result = LogicUnitOfWork.Case3Service.CalculateCheapestDeliveryCost(Start,End);
            return result;
        }
    }
}
