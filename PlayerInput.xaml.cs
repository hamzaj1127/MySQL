namespace MySQL;

public partial class PlayerInput : ContentPage
{
	public PlayerInput()
	{
		InitializeComponent();
	}

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}