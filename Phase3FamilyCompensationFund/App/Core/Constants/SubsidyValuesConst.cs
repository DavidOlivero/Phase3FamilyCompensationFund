namespace Phase3FamilyCompensationFund.App.Core.Constants;

public abstract class SubsidyValuesConst
{
    public static readonly Dictionary<string, double> AffiliatesValues = new()
    {
        { "1", 450000 },
        { "2", 350000 },
        { "3", 250000 },
        { "4", 150000 },
        { "5", 0 },
        { "6", 0 }
    };

    public static readonly Dictionary<string, double> NonAffiliated = new()
    {
        { "1", 300000 },
        { "2", 200000 },
        { "3", 100000 },
        { "4", 50000 },
        { "5", 0 },
        { "6", 0 }
    };
}