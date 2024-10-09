namespace MauiAppPhil;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Alert Demo", "Hello, you have clicked the button!", "This is the text of the button. ");
    }
}