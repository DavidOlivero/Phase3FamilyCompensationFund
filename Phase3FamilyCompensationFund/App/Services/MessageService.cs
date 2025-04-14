using System.ComponentModel;
using System.Reflection;
using Phase3FamilyCompensationFund.App.Core.Enums;

namespace Phase3FamilyCompensationFund.App.Services;

public static class MessageService
{
    public static string? GetMessage(Messages message)
    {
        var type = message.GetType(); // Get the enum type
        var name = Enum.GetName(type, message); // Return a string with the option name
        
        if (name is null) return null;
        var field = type.GetField(name); // Return an object representing the enum option

        var attr = field?.GetCustomAttribute<DescriptionAttribute>(); // Get the related attribute with the field

        return attr?.Description;
    }
}