using Phase3FamilyCompensationFund.App.Logic;
using Phase3FamilyCompensationFund.App.Utils;

namespace Phase3FamilyCompensationFund;

public partial class AuthenticationView : Form
{
    public AuthenticationView()
    {
        InitializeComponent();
    }

    private void WriteNumber(object sender, EventArgs e)
    {
        if (sender is Button button) TbPassword.Text += button.Text;
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        AuthenticationLogic.ApplicationLogin(TbPassword.Text);
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        TbPassword.Text = "";
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        CloseFormUtil.CloseForm(this);
    }
}