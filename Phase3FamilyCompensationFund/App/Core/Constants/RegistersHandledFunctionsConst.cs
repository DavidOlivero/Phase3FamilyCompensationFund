using Phase3FamilyCompensationFund.App.Core.Globals;
using Phase3FamilyCompensationFund.App.Core.Structures;
using Phase3FamilyCompensationFund.App.Model;

namespace Phase3FamilyCompensationFund.App.Core.Constants;

public static class RegistersHandledFunctionsConst
{
    public static readonly Dictionary<string, Action<AffiliateData>> SaveRegisterFunctions = new()
    {
        {
            "Stack",
            (data) => DataStructure.AddToStack(new AffiliateDataStructure(data))
        },
        {
            "Queue",
            (data) => DataStructure.AddToQueue(new AffiliateDataStructure(data))
        },
        {
            "List",
            (data) => DataStructure.AddToList(new AffiliateDataStructure(data))
        }
    };
    
    public static readonly Dictionary<string, Action<int>> RemoveRegisterFunctions = new()
    {
        {
            "Stack",
            (_) => DataStructure.RemoveFromStack()
        },
        {
            "Queue",
            (_) => DataStructure.RemoveFromQueue()
        },
        {
            "List",
            DataStructure.RemoveFromList
        }
    };
    
    public static readonly Dictionary<string, Func<IEnumerable<AffiliateDataStructure>>> GetRegisterFunctions = new()
    {
        {
            "Stack",
            DataStructure.GetStack
        },
        {
            "Queue",
            DataStructure.GetQueue
        },
        {
            "List",
            DataStructure.GetList
        }
    };
}