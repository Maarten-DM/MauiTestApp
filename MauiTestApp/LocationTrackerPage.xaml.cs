namespace MauiTestApp;

public partial class LocationTrackerPage : ContentPage
{
	public LocationTrackerPage()
	{
		InitializeComponent();
	}

    private async void ButtonTrackLocation_Clicked(object sender, EventArgs e)
    {
		GeolocationRequest locationRequest = new GeolocationRequest(GeolocationAccuracy.Medium);
		Location loc = await Geolocation.GetLocationAsync(locationRequest);
		lblLongitude.Text = loc.Longitude.ToString();
		lblLatitude.Text = loc.Latitude.ToString();

	}
}