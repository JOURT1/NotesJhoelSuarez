namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
        {
            Console.WriteLine($"Navigating to: {about.MoreInfoUrl}");
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
        else
        {
            Console.WriteLine("BindingContext is not of type About.");
        }
    }

}