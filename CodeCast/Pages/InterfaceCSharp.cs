namespace CodeCast.Pages;

public class InterfaceCSharp : ContentPage
{
	public InterfaceCSharp()
	{

		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}