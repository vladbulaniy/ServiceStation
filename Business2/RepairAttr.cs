using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RepairAttr: IRepairAttr
    {
        bool isDiagnostic;

        //public int CalcRateCost(CostDetails costDetails)
        //{
        //    int result;
            
        //    public calcRateCost(CostDetails costDetails)
        //    {
        //        this.year = costDetails.
        //    }
        //    result = costDetails.

        //    return result;
        //}

        public int CalcRateCost(CostDetails costDetails)
        {
            return costDetails.Milage + costDetails.Year;
        }
    }
}
