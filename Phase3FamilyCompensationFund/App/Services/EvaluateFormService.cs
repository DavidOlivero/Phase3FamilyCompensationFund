namespace Phase3FamilyCompensationFund.App.Services;

public abstract class EvaluateFormService
{
    public static bool FormIsFull(Form form)
    {
        var isFull = false;
        
        foreach (var group in form.Controls.OfType<GroupBox>())
        {
            var textBoxes = group.Controls.OfType<TextBox>()
                .Where(textBox => string.IsNullOrEmpty(textBox.Text.Trim()));
            var dropDowns = group.Controls.OfType<ComboBox>()
                .Where(comboBox => comboBox.SelectedItem == null);
            var datePickers = group.Controls.OfType<DateTimePicker>()
                .Where(datePicker => string.IsNullOrEmpty(datePicker.Text.Trim()));
            
            isFull = !textBoxes.Any() && !dropDowns.Any() && !datePickers.Any();
        }
        
        return isFull;
    }

    public static void ClearForm(Form form)
    {
        foreach (var group in form.Controls.OfType<GroupBox>())
        {
            foreach (var textBox in group.Controls.OfType<TextBox>()) textBox.Text = string.Empty;
            foreach (var dropDown in group.Controls.OfType<ComboBox>()) dropDown.SelectedIndex = -1;
            foreach (var datePicker in group.Controls.OfType<DateTimePicker>()) datePicker.Text = string.Empty;
        }
    }
}