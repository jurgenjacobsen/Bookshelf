namespace Bookshelf;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		new WebView
		{
			Source = "https://www.microsoft.com"
		};
	}
}

