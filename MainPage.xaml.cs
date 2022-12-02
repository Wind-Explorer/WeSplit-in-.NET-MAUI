namespace WeSplit;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        InitialisePeopleCounter();
	}

    public void InitialisePeopleCounter()
    {
        for (var c = 2; c <= 100; c++)
        {
            PeopleCountPicker.Items.Add($"{c.ToString()} people");
        }
        PeopleCountPicker.SelectedIndex = 2;
    }
}

