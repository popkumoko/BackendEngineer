using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.Logic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eko​​Delivery​​Service.Logic.Service.Implement
{
    public class Case2Service : ICase2Service
    {
        private IUnitOfwork UnitOfWork { get; set; }
        private List<string> ListPath = new List<string>();

        public Case2Service(IUnitOfwork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public int GetPossibleDeliveryRouteWithMaximum(string StartNode, string EndNode, int Max)
        {
            var DFS = new Stack<string>();
            DFS.Push(StartNode);

            var text = DFS.ToString();


            string SelectNode = StartNode;
            var CheckTwicePath = new List<string>();
            var CountPath = 0;
            var CheckNode = UnitOfWork.Graph;
            string PreVisitNode = StartNode;

            while(DFS.Count != 0)
            {
                var Connect = CheckNode.Where(w => w.PreviewNode == SelectNode && (!(CheckTwicePath.Contains((SelectNode + w.Node))) && w.Check != true)).FirstOrDefault();
                if (Connect == null || DFS.Count > Max)
                {
                    var preview = DFS.First();
                    var UnCheck = CheckNode.Where(w => w.PreviewNode == preview);
                    foreach (var i in UnCheck)
                    {
                        i.Check = false;
                    }
                    DFS.Pop();
                    if(DFS.Count != 0)
                        SelectNode = DFS.First();

                    continue;
                }

                DFS.Push(Connect.Node);
                SelectNode = Connect.Node;
                Connect.Check = true;

                if (Connect.Node == EndNode)
                {
                    CountPath++;
                    var preview = DFS.First();
                    var UnCheck = CheckNode.Where(w => w.PreviewNode == preview);
                    foreach (var i in UnCheck)
                    {
                        i.Check = false;
                    }
                    DFS.Pop();
                    if (DFS.Count != 0)
                        SelectNode = DFS.First();
                    continue;
                }
                CheckTwicePath = GetCheckTwicePath(DFS.ToArray());
            }
            return CountPath;
        }

        private List<string> GetCheckTwicePath(string[] DFS)
        {
            var CheckTwicePath = new List<string>();

            for(var i = (DFS.Length - 1); i > 0; i--)
            {
                CheckTwicePath.Add(DFS[i] + DFS[i-1]);
            }

            return CheckTwicePath;
        }
    }
}
