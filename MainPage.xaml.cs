namespace WeSplit;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        InitializePeopleCounter();
        InitializeTipPercentageSlider();
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

    private void TipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        TipPercentageText.Text = $"{((int)TipPercentageSlider.Value).ToString()}%";
    }
}

