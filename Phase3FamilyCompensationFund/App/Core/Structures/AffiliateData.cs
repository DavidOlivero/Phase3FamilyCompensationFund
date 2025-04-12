namespace Phase3FamilyCompensationFund.App.Core.Structures;

public struct AffiliateData
{
    public string IdentificationType { get; init; }
    public string FullName { get; init; }
    public int Stratum { get; init; }
    public int SubsidyValue { get; init; }
    public string DataReport { get; init; }
    public int IdentificationNumber { get; init; }
    public double Salary { get; init; }
    public bool IsAffiliate { get; init; }
    public string AffiliationDate { get; init; }
}