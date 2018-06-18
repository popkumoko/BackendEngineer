using EkoDeliveryService.DataAccess.Interface;
using EkoDeliveryService.Logic.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eko​​Delivery​​Service.Logic.Service.Implement
{
    public class Case1Service : ICase1Service
    {
        private IUnitOfwork UnitOfWork { get; set; }

        public Case1Service(IUnitOfwork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
       
        public int CalculateDeliveryCost(string Path)
        {
            var text = Path.Split('-');
            var cost = 0;
            for(var i = 0 ; i <= text.Length - 2 ; i++)
            {
                if(text[i].ToUpper().Equals("A"))
                {
                    var connect = UnitOfWork.ARepository.Where(w=>w.TownName.Equals( text[i + 1].ToUpper()) );
                    if(connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else if (text[i].ToUpper().Equals("B"))
                {
                    var connect = UnitOfWork.BRepository.Where(w => w.TownName.Equals(text[i + 1].ToUpper()));
                    if (connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else if (text[i].ToUpper().Equals("C"))
                {
                    var connect = UnitOfWork.CRepository.Where(w => w.TownName.Equals(text[i + 1].ToUpper()));
                    if (connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else if (text[i].ToUpper().Equals("D"))
                {
                    var connect = UnitOfWork.DRepository.Where(w => w.TownName.Equals(text[i + 1].ToUpper()));
                    if (connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else if (text[i].ToUpper().Equals("E"))
                {
                    var connect = UnitOfWork.ERepository.Where(w => w.TownName.Equals(text[i + 1].ToUpper()));
                    if (connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else if (text[i].ToUpper().Equals("F"))
                {
                    var connect = UnitOfWork.FRepository.Where(w => w.TownName.Equals(text[i + 1].ToUpper()));
                    if (connect.Any())
                    {
                        cost = cost + connect.First().Cost;
                        continue;
                    }
                    else
                    {
                        cost = 0;
                        break;
                    }
                }
                else
                {
                    cost = 0;
                    break;
                }
            }

            return cost;
        }
    }
}
