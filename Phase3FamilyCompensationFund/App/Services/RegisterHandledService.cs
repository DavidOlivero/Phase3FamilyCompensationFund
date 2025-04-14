using Phase3FamilyCompensationFund.App.Core.Constants;
using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Core.Structures;
using Phase3FamilyCompensationFund.App.Model;

namespace Phase3FamilyCompensationFund.App.Services;

public abstract class RegisterHandledService
{
    public static void SaveANewRegister(
        AffiliateData data,
        StructureTypes structureType = StructureTypes.Stack
    )
    {
        RegistersHandledFunctionsConst.SaveRegisterFunctions[structureType.ToString()](data);
    }

    public static void RemoveRegister(StructureTypes structureType, int index = 0)
    {
        RegistersHandledFunctionsConst.RemoveRegisterFunctions[structureType.ToString()](index);
    }

    public static IEnumerable<AffiliateDataStructure> GetRegister(StructureTypes structureType)
    {
        return RegistersHandledFunctionsConst.GetRegisterFunctions[structureType.ToString()]();
    }
}