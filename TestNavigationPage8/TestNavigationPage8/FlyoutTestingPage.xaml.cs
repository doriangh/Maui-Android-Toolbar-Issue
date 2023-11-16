namespace TestNavigationPage8;

public partial class FlyoutTestingPage : FlyoutPage
{
	public static FlyoutTestingPage Instance { get; set; }

	public FlyoutTestingPage()
	{
		InitializeComponent();
		
		Instance = this;
	}
}
