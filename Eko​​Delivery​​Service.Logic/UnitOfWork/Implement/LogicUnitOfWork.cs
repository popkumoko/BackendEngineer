using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.Logic.Service.Implement;
using EkoDeliveryService.Logic.Service.Interface;
using EkoDeliveryService.Logic.UnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.Logic.UnitOfWork.Implement
{
    public class LogicUnitOfWork : ILogicUnitOfWork
    {
        private readonly IUnitOfwork UnitOfWork;

        private ICase1Service ICase1Service;
        private ICase2Service ICase2Service;
        private ICase3Service ICase3Service;

        public LogicUnitOfWork(IUnitOfwork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public ICase1Service Case1Service
        {
            get { return ICase1Service ?? (ICase1Service = new Case1Service(UnitOfWork)); }
            set { ICase1Service = value; }
        }

        public ICase2Service Case2Service
        {
            get { return ICase2Service ?? (ICase2Service = new Case2Service(UnitOfWork)); }
            set { ICase2Service = value; }
        }

        public ICase3Service Case3Service
        {
            get { return ICase3Service ?? (ICase3Service = new Case3Service(UnitOfWork)); }
            set { ICase3Service = value; }
        }
    }
}
