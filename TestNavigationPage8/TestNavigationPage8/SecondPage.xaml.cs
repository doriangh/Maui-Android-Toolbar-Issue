namespace TestNavigationPage8;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
		Title = "Second";
		NavigationPage.SetHasNavigationBar(this, true);
	}
}
