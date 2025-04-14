using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Services;
using Phase3FamilyCompensationFund.App.Utils;

namespace Phase3FamilyCompensationFund.App.Logic;

public static class AuthenticationLogic
{
    public static void ApplicationLogin(string password)
    {
        if (!AuthenticationService.Login(password))
        {
            MessagesHandlerUtil.ShowMessage(Messages.AuthenticationError, MessageBoxIcon.Error);
            return;
        }
        
        new DataRegister().Show();
    }
}