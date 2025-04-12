namespace Phase3FamilyCompensationFund.App.Utils;

public abstract class ConvertMoneyToNumber
{
    public static int CovertToInteger(string value)
    {
        return int.Parse(value.Trim().Replace("$", ""));
    }

    public static double ConvertToDecimal(string value)
    {
        return double.Parse(value.Trim().Replace("$", ""));
    }
}