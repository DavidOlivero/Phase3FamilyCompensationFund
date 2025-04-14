using Phase3FamilyCompensationFund.App.Core.Enums;

namespace Phase3FamilyCompensationFund.App.Utils;

public static class GetStructureTypeUtil
{
    public static StructureTypes GetSelectedStructure(string structureType)
    {
        var structure = structureType switch
        {
            "Pila" => StructureTypes.Stack,
            "Lista" => StructureTypes.List,
            "Cola" => StructureTypes.Queue,
            _ => StructureTypes.Stack
        };

        return structure;
    }
}