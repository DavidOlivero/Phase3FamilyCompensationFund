using Phase3FamilyCompensationFund.App.Core.Globals;

namespace Phase3FamilyCompensationFund.App.Core.Constants;

public static class DataReportConst
{
    public static readonly Dictionary<string, Func<string>> Reports = new()
    {
        {
            "Pila",
            static () => {
                var total = DataStructure.GetStack().Sum(item => item.GetSubsidyValue());
                return $"${total}";
            }
        },
        {
            "Cola",
            static () => $"{DataStructure.GetQueue().Count}"
        },
        {
            "Lista",
            static () =>
            {
                var totalSalary = 0.0;
                var amount = 0;
                foreach (var item in DataStructure.GetList())
                {
                    totalSalary += item.GetSalary();
                    amount++;
                }

                return totalSalary == 0 ? "$0" : $"${totalSalary / amount}";
            }
        }
    };
}