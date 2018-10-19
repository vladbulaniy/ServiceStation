using Business.Interfaces;

namespace Business
{
    public class AppDI : IAppService
    {
        public AppDI(IRepairCalculation repairCalculation, IRepairAttr repairAttr)
        {
            this.RepairCalculation = repairCalculation;
            this.RepairAttr = repairAttr;
        }

        public IRepairCalculation RepairCalculation { get; }
        public IRepairAttr RepairAttr { get; }

        public int GetCalculation(int a ,int b)
        {
            CostDetails costDetails = new CostDetails
            {
                Milage = a,
                Year = b
            };
            int res = this.RepairAttr.CalcRateCost(costDetails);
            return this.RepairCalculation.Calculate(res);
        }
    }
}
