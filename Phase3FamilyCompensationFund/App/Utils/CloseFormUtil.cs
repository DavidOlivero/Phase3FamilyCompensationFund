using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Services;

namespace Phase3FamilyCompensationFund.App.Utils;

public abstract class CloseFormUtil
{
    public static void CloseForm(Form formReference)
    {
        var response = MessagesHandlerUtil.ShowConfirm(Messages.ConfirmClosed);
        if (response is DialogResult.No)
        {
            return;
        }
        
        formReference.Close();
    }
}