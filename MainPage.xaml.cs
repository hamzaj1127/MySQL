namespace MySQL;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnGoToPlayerInputPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PlayerInput());
    }

    private void BtnGoToPlayerInfoPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PlayerInfo());

    }
}

