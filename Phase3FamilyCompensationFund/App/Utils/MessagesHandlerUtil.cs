using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Services;

namespace Phase3FamilyCompensationFund.App.Utils;

public static class MessagesHandlerUtil
{
    public static void ShowMessage(Messages message, MessageBoxIcon icon)
    {
        MessageBox.Show(
            MessageService.GetMessage(message),
            @"Mensaje",
            MessageBoxButtons.OK,
            icon
        );
    }

    public static DialogResult ShowConfirm(Messages message)
    {
        return MessageBox.Show(
            MessageService.GetMessage(message),
            @"Confirmar",
            MessageBoxButtons.YesNo
        );
    }
}