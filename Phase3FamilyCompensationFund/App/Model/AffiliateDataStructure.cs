using Phase3FamilyCompensationFund.App.Core.Structures;

namespace Phase3FamilyCompensationFund.App.Model;

public class AffiliateDataStructure(AffiliateData data)
{
    private readonly string _identificationType = data.IdentificationType;
    private readonly string _fullName = data.FullName;
    private readonly int _stratum = data.Stratum;
    private readonly int _subsidyValue = data.SubsidyValue;
    private readonly string _dataReport = data.DataReport;
    private readonly int _identificationNumber = data.IdentificationNumber;
    private readonly double _salary = data.Salary;
    private readonly bool _isAffiliate = data.IsAffiliate;
    private readonly string _affiliationDate = data.AffiliationDate;

    public string GetIdentificationType()
    {
        return _identificationType;
    }

    public string GetFullName()
    {
        return _fullName;
    }

    public int GetStratum()
    {
        return _stratum;
    }

    public int GetSubsidyValue()
    {
        return _subsidyValue;
    }

    public string GetDataReport()
    {
        return _dataReport;
    }

    public int GetIdentificationNumber()
    {
        return _identificationNumber;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public bool GetIsAffiliate()
    {
        return _isAffiliate;
    }

    public string GetAffiliationDate()
    {
        return _affiliationDate;
    }
}