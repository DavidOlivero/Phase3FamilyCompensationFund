using Phase3FamilyCompensationFund.App.Core.Constants;
using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Core.Globals;
using Phase3FamilyCompensationFund.App.Core.Structures;
using Phase3FamilyCompensationFund.App.Model;

namespace Phase3FamilyCompensationFund.App.Services;

public abstract class SaveRegisterService
{
    public static void SaveANewRegister(
        AffiliateData data,
        StructureTypes structureType = StructureTypes.Stack
    )
    {
        switch (structureType)
        {
            case StructureTypes.Stack:
                SaveAsStack(data);
                break;
            case StructureTypes.List:
                SaveAsList(data);
                break;
            case StructureTypes.Queue:
                SaveAsQueue(data);
                break;
            default:
                SaveAsStack(data);
                break;
        }
    }

    private static void SaveAsStack(AffiliateData data)
    {
         DataStructure.AddToStack(new AffiliateDataStructure(data));
    }
    
    private static void SaveAsList(AffiliateData data)
    {
        DataStructure.AddToList(new AffiliateDataStructure(data));
    }

    private static void SaveAsQueue(AffiliateData data)
    {
        DataStructure.AddToQueue(new AffiliateDataStructure(data));   
    }
}