using Phase3FamilyCompensationFund.App.Core.Structures;

namespace Phase3FamilyCompensationFund.App.Core.Globals;

public abstract class SubsidyValueGlobalData
{
    public static readonly SubsidyValueData SubsidyValueDefault = new()
    {
        Stratum = null,
        IsAffiliate = true,
        Salary = 0
    };


    public static SubsidyValueData SubsidyValueGlobalDataStructure = SubsidyValueDefault;
}