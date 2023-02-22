namespace MySQL;

public partial class PlayerInfo : ContentPage
{
	public PlayerInfo()
	{
		InitializeComponent();
	}
    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}