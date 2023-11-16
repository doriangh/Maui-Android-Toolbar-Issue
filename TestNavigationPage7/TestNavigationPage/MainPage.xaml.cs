namespace TestNavigationPage;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Title = "Test";
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        FlyoutTestingPage.Instance.Detail = new NavigationPage(new SecondPage());
        // Navigation.PushAsync(new SecondPage());
    }
}