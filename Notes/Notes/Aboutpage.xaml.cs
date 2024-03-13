namespace Notes;

public partial class Aboutpage : ContentPage
{
	public Aboutpage()
	{
		InitializeComponent();
	}

	private async void LearMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://www.google.com.br/")
	}
}