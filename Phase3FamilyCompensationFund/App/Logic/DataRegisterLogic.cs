using System.Globalization;
using Phase3FamilyCompensationFund.App.Core.Constants;
using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Core.Globals;
using Phase3FamilyCompensationFund.App.Core.Structures;
using Phase3FamilyCompensationFund.App.Services;
using Phase3FamilyCompensationFund.App.Utils;

namespace Phase3FamilyCompensationFund.App.Logic;

public class DataRegisterLogic(DataRegister formReference)
{
    public void SaveNewRegister()
    {
        if (!ComprobateForm(formReference)) return;
        var data = new AffiliateData
        {
            IdentificationType = formReference.SldIdType.SelectedItem!.ToString()!,
            AffiliationDate = formReference.DpDate.Text,
            DataReport = formReference.TbDataReport.Text,
            FullName = formReference.TbFullName.Text,
            IdentificationNumber = int.Parse(formReference.TbIdNumber.Text),
            IsAffiliate = formReference.CkbYes.Checked,
            Salary = ConvertMoneyToNumber.ConvertToDecimal(formReference.TbSalary.Text),
            Stratum = int.Parse(formReference.SldStratum.SelectedItem!.ToString()!),
            SubsidyValue = ConvertMoneyToNumber.CovertToInteger(formReference.TbSubsidyValue.Text)
        };
        
        SaveRegisterService.SaveANewRegister(data, GetStructureTypeUtil.GetSelectedStructure(
            formReference.SldStructureType.SelectedItem!.ToString()!)
        );
        MessagesHandlerUtil.ShowMessage(Messages.FormSuccess, MessageBoxIcon.Information);
    }

    public void ClearForm(bool ask)
    {
        if (ask)
        {
            var response = MessagesHandlerUtil.ShowConfirm(Messages.ClearForm);
            if (response == DialogResult.No) return;
        }
        
        EvaluateFormService.ClearForm(formReference);
        SubsidyValueGlobalData.SubsidyValueGlobalDataStructure = SubsidyValueGlobalData.SubsidyValueDefault;
        formReference.TbSubsidyValue.Text = string.Empty;
    }

    public void CalculateSubsidyValue()
    {
        if (SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Stratum is null) return;
        formReference.TbSubsidyValue.Text = CalculatePriceService.CalculatePrice().ToString(CultureInfo.InvariantCulture);
    }

    public void GetDataReport()
    {
        var selectedItem = formReference.SldStructureType.SelectedItem?.ToString();
        if (
            string.IsNullOrEmpty(selectedItem) || 
            !DataReportConst.Reports.TryGetValue(selectedItem, out var report)
        ) return;
        
        var dataReport = report();
        formReference.TbDataReport.Text = dataReport;
    }

    public void ShowGridReport(StructureTypes structureType)
    {
        switch (structureType)
        {
            case StructureTypes.Stack:
                DataGridViewHandledService.ShowDataGrid(formReference.DgvStack, DataStructure.GetStack());
                formReference.BtnStackDelete.Enabled = true;
                break;
            case StructureTypes.Queue:
                DataGridViewHandledService.ShowDataGrid(formReference.DgvQueue, DataStructure.GetQueue());
                formReference.BtnQueueDelete.Enabled = true;
                break;
            case StructureTypes.List:
                DataGridViewHandledService.ShowDataGrid(formReference.DgvList, DataStructure.GetList());
                formReference.BtnListDelete.Enabled = true;
                break;
            default: return;
        }
    }

    public void EnabledRegisterButton()
    {
        var selectedItem = formReference.SldStructureType.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedItem)) return;

        var structureType = GetStructureTypeUtil.GetSelectedStructure(selectedItem);
        switch (structureType)
        {
            case StructureTypes.Stack:
                formReference.BtnStackReport.Enabled = true;
                break;
            case StructureTypes.Queue:
                formReference.BtnQueueReport.Enabled = true;
                break;
            case StructureTypes.List:
                formReference.BtnListReport.Enabled = true;
                break;
            default: return;
        }
    }

    public void DeleteRegister(StructureTypes structureType)
    {
        switch (structureType)
        {
            case StructureTypes.Stack:
                DataStructure.RemoveFromStack();
                break;
            case StructureTypes.Queue:
                DataStructure.RemoveFromQueue();
                break;
            case StructureTypes.List:
                var indexToDelete = formReference.DgvList.SelectedRows[0].Index;
                DataStructure.RemoveFromList(indexToDelete);
                break;
            default: return;
        }
        
        ShowGridReport(structureType);
    }
    
    private static bool ComprobateForm(DataRegister formReference)
    {
        if (EvaluateFormService.FormIsFull(formReference)) return true;
        MessagesHandlerUtil.ShowMessage(Messages.FormError, MessageBoxIcon.Error);
        return false;
    }
}