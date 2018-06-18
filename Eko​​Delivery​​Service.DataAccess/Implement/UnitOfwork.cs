using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.DataAccess.Implement
{
    public class UnitOfwork : IUnitOfwork
    {
        private List<ConnectModel> IARepository;
        private List<ConnectModel> IBRepository;
        private List<ConnectModel> ICRepository;
        private List<ConnectModel> IDRepository;
        private List<ConnectModel> IERepository;
        private List<ConnectModel> IFRepository;

        public List<ConnectModel> ARepository
        {
            get { return IARepository ?? (IARepository = GetAConnect()); }
            set { IARepository = value; }
        }

        public List<ConnectModel> BRepository
        {
            get { return IBRepository ?? (IBRepository = GetBConnect()); }
            set { IBRepository = value; }
        }

        public List<ConnectModel> CRepository
        {
            get { return ICRepository ?? (ICRepository = GetCConnect()); }
            set { ICRepository = value; }
        }
        public List<ConnectModel> DRepository
        {
            get { return IDRepository ?? (IDRepository = GetDConnect()); }
            set { IDRepository = value; }
        }
        public List<ConnectModel> ERepository
        {
            get { return IERepository ?? (IERepository = GetEConnect()); }
            set { IERepository = value; }
        }
        public List<ConnectModel> FRepository
        {
            get { return IFRepository ?? (IFRepository = GetFConnect()); }
            set { IFRepository = value; }
        }

        private List<ConnectModel> GetAConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "B",
                Cost = 1
            });
            result.Add(new ConnectModel()
            {
                TownName = "C",
                Cost = 4
            });
            result.Add(new ConnectModel()
            {
                TownName = "D",
                Cost = 10
            });

            return result;
        }

        private List<ConnectModel> GetBConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "E",
                Cost = 3
            });

            return result;
        }

        private List<ConnectModel> GetCConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "F",
                Cost = 2
            });
            result.Add(new ConnectModel()
            {
                TownName = "D",
                Cost = 4
            });

            return result;
        }

        private List<ConnectModel> GetDConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "E",
                Cost = 1
            });

            return result;
        }

        private List<ConnectModel> GetEConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "B",
                Cost = 3
            });
            result.Add(new ConnectModel()
            {
                TownName = "A",
                Cost = 2
            });

            return result;
        }

        private List<ConnectModel> GetFConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                TownName = "D",
                Cost = 1
            });

            return result;
        }
    }
}
