using Phase3FamilyCompensationFund.App.Core.Enums;
using Phase3FamilyCompensationFund.App.Core.Globals;
using Phase3FamilyCompensationFund.App.Logic;
using Phase3FamilyCompensationFund.App.Utils;

namespace Phase3FamilyCompensationFund;

public partial class DataRegister : Form
{
    private readonly DataRegisterLogic _dataRegisterLogic;
    
    public DataRegister()
    {
        InitializeComponent();
        _dataRegisterLogic = new DataRegisterLogic(this);
    }

    private void BtnRegister_Click(object sender, EventArgs e)
    {
        _dataRegisterLogic.SaveNewRegister();
        _dataRegisterLogic.EnabledRegisterButton();
        _dataRegisterLogic.ClearForm(ask: false);
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        _dataRegisterLogic.ClearForm(ask: true);
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        CloseFormUtil.CloseForm(this);
    }

    private void SldStratum_SelectedIndexChanged(object sender, EventArgs e)
    {
        SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Stratum = SldStratum.SelectedItem?.ToString();
        _dataRegisterLogic.CalculateSubsidyValue();
    }

    private void TbSalary_TextChanged(object sender, EventArgs e)
    {
        var salaryValue = TbSalary.Text.Trim();
        SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.Salary = double.Parse(
            salaryValue.Length > 0 ? salaryValue : "0"
        );
        _dataRegisterLogic.CalculateSubsidyValue();
    }

    private void CkbAny_CheckedChanged(object sender, EventArgs e)
    {
        SubsidyValueGlobalData.SubsidyValueGlobalDataStructure.IsAffiliate = CkbYes.Checked;
        _dataRegisterLogic.CalculateSubsidyValue();
    }

    private void TbFullName_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = FieldsControlUtil.ComprobateIfIsText(e);
    }

    private void TbIdNumber_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = FieldsControlUtil.ComprobateIfIsNumber(e);
    }

    private void TbSalary_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = FieldsControlUtil.ComprobateIfIsNumber(e);
    }

    private void SldStructureType_SelectedIndexChanged(object sender, EventArgs e)
    {
        _dataRegisterLogic.GetDataReport();
    }

    private void BtnStackReport_Click(object sender, EventArgs e)
    {
        DataRegisterLogic.ShowGridReport(StructureTypes.Stack, DgvStack, BtnStackDelete);
    }

    private void BtnQueueReport_Click(object sender, EventArgs e)
    {
        DataRegisterLogic.ShowGridReport(StructureTypes.Queue, DgvQueue, BtnQueueDelete);
    }

    private void BtnListReport_Click(object sender, EventArgs e)
    {
        DataRegisterLogic.ShowGridReport(StructureTypes.List, DgvList, BtnListDelete);
    }

    private void BtnStackDelete_Click(object sender, EventArgs e)
    {
        _dataRegisterLogic.DeleteRegister(StructureTypes.Stack, DgvStack, BtnStackDelete);
    }

    private void BtnQueueDelete_Click(object sender, EventArgs e)
    {
        _dataRegisterLogic.DeleteRegister(StructureTypes.Queue, DgvQueue, BtnQueueDelete);
    }
    
    private void BtnListDelete_Click(object sender, EventArgs e)
    {
        _dataRegisterLogic.DeleteRegister(StructureTypes.List, DgvList, BtnListDelete, removeFromIndex: true);
    }
}