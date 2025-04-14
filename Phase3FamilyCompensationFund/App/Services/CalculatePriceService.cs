using Phase3FamilyCompensationFund.App.Core.Constants;
using Phase3FamilyCompensationFund.App.Core.Globals;

namespace Phase3FamilyCompensationFund.App.Services;

public static class CalculatePriceService
{
    public static double CalculatePrice()
    {
        double price;
        switch (SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.IsAffiliate)
        {
            case true when
                SubsidyValuesConst.AffiliatesValues.TryGetValue(SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Stratum!, out price):
            case false when
                SubsidyValuesConst.NonAffiliated.TryGetValue(SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Stratum!, out price):
                break;
            default:
                price = 0;
                break;
        }

        return SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.IsAffiliate &&
               SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Salary < 500000
               ? price + 50000
               : SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Salary < 1000000
               ? price + 150000
               : 0;
    }
}