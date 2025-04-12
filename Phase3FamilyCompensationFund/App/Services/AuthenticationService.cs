using Phase3FamilyCompensationFund.App.Core.Constants;

namespace Phase3FamilyCompensationFund.App.Services;

public abstract class AuthenticationService
{
    public static bool Login(string password)
    {
        return password == AuthenticationConst.Password;
    }
}