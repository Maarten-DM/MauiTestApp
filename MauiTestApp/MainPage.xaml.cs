namespace MauiTestApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		lblOrientation.Text = new DeviceOrientationService().GetOrientation().ToString();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LocationTrackerPage());
    }
}

