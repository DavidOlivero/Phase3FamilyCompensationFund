using Phase3FamilyCompensationFund.App.Model;

namespace Phase3FamilyCompensationFund.App.Services;

public abstract class DataGridViewHandledService
{
    public static void ShowDataGrid(DataGridView dataGrid, IEnumerable<AffiliateDataStructure> collection)
    {
        dataGrid.Rows.Clear();
        dataGrid.Visible = true;
        foreach (var value in collection)
        {
            dataGrid.Rows.Add(
                value.GetIdentificationNumber(),
                value.GetIdentificationType(),
                value.GetFullName(),
                value.GetStratum(),
                value.GetSalary(),
                value.GetSubsidyValue()
            );
        }
    }
}