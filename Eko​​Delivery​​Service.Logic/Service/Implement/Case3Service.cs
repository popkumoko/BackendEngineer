using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.DataAccess.Models;
using EkoDeliveryService.Logic.Model;
using EkoDeliveryService.Logic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eko​​Delivery​​Service.Logic.Service.Implement
{
    public class Case3Service : ICase3Service
    {
        private IUnitOfwork UnitOfWork { get; set; }

        public Case3Service(IUnitOfwork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public int CalculateCheapestDeliveryCost(string Start, string End)
        {
            var Vector = GetVectorsList();
            string SelectNode = Start.ToUpper();
            int Cost = 0;
            var OldSelect = new List<string>();

            while((Cost == 0) || (SelectNode != End.ToUpper()))
            {
                var Connect = UnitOfWork.Graph.Where(w => w.PreviewNode == SelectNode);

                foreach(var i in Connect)
                {
                    var update = Vector.Where(w => w.VectorNode == i.Node).First();
                    update.Cost = Cost + i.Cost;
                    update.Preview = SelectNode;
                    update.CheckOld = SelectNode + update.Cost.ToString();
                }

                var NextSelect = Vector.Where(w => w.Cost != null && !(OldSelect.Contains(w.CheckOld))).OrderBy(o => o.Cost).Take(1).First();
                Cost = NextSelect.Cost ?? 0;
                SelectNode = NextSelect.VectorNode;
                OldSelect.Add(NextSelect.CheckOld);
            }

            return Cost;
        }

        private List<VectorDto> GetVectorsList()
        {
            var result = new List<VectorDto>();

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "A"
            });

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "B"
            });

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "C"
            });

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "D"
            });

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "E"
            });

            result.Add(new VectorDto()
            {
                CheckOld = null,
                Cost = null,
                Preview = null,
                VectorNode = "F"
            });

            return result;
        }
    }
    

}
