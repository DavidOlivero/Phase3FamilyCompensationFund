namespace Phase3FamilyCompensationFund.App.Utils;

public abstract class FieldsControlUtil
{
    public static bool ComprobateIfIsNumber(KeyPressEventArgs e)
    {
        return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
    }

    public static bool ComprobateIfIsText(KeyPressEventArgs e)
    {
        return !char.IsControl(e.KeyChar) && !e.KeyChar.Equals(' ') && !char.IsLetter(e.KeyChar);
    }
}