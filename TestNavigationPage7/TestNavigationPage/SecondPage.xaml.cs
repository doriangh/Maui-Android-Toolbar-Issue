namespace TestNavigationPage;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
		Title = "Second";
		NavigationPage.SetHasNavigationBar(this, true);
	}
}
