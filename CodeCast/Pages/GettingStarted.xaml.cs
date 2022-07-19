namespace CodeCast.Pages;

public partial class GettingStarted : ContentPage
{
	public GettingStarted()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Login());
	}
}