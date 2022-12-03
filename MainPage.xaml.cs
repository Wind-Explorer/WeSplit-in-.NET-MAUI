namespace WeSplit;

public partial class MainPage : ContentPage
{
    private bool finishedInitializing = false;

    public MainPage()
    {
        InitializeComponent();
        InitializePeopleCounter();
        InitializeTipPercentageSlider();
        InitializeCostTextBox();
        finishedInitializing= true;
        CalculateCost();
    }

    public void InitializePeopleCounter()
    {
        for (var c = 2; c <= 100; c++)
        {
            PeopleCountPicker.Items.Add($"{c.ToString()} people");
        }
        PeopleCountPicker.SelectedIndex = 2;
    }

    public void InitializeTipPercentageSlider()
    {
        TipPercentageSlider.Value = 10;
        TipPercentageText.Text = $"{((int)TipPercentageSlider.Value).ToString()}%";
    }

    public void InitializeCostTextBox()
    {
        CostTextBox.Text = $"80.00";
    }

    private void TipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        TipPercentageText.Text = $"{((int)TipPercentageSlider.Value).ToString()}%";
        CalculateCost();
    }

    private void CalculateCost()
    {
        if (finishedInitializing)
        {
            var str = new string((from c in CostTextBox.Text where char.IsNumber(c) || $"{c}" == "." select c).ToArray());
            CostTextBox.Text = str;
            if (str.Length > 0)
            {
                AmountPayablePerPerson.Text = $"${Math.Round(double.Parse(str) / 100 * (100 + (int)TipPercentageSlider.Value) / (PeopleCountPicker.SelectedIndex + 2), 2)}";
            }
        }
    }

    private void CostTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        CalculateCost();
    }

    private void PeopleCountPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        CalculateCost();
    }
}

