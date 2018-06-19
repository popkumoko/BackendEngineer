using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eko​​Delivery​​Service.DataAccess.Implement
{
    public class UnitOfwork : IUnitOfwork
    {
        private List<ConnectModel> IGraph;

        public List<ConnectModel> Graph
        {
            get { return IGraph ?? (IGraph = GetConnect()); }
            set { IGraph = value; }
        }

        private List<ConnectModel> GetConnect()
        {
            var result = new List<ConnectModel>();
            result.Add(new ConnectModel()
            {
                PreviewNode = "A",
                Node = "B",
                Cost = 1
            });
            result.Add(new ConnectModel()
            {
                PreviewNode = "A",
                Node = "C",
                Cost = 4
            });
            result.Add(new ConnectModel()
            {
                PreviewNode = "A",
                Node = "D",
                Cost = 10
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "B",
                Node = "E",
                Cost = 3
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "C",
                Node = "D",
                Cost = 4
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "C",
                Node = "F",
                Cost = 2
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "D",
                Node = "E",
                Cost = 1
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "E",
                Node = "A",
                Cost = 2
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "E",
                Node = "B",
                Cost = 3
            });

            result.Add(new ConnectModel()
            {
                PreviewNode = "F",
                Node = "D",
                Cost = 1
            });

            return result;
        }
    }
}
