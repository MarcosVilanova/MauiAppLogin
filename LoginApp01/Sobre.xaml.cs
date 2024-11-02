namespace LoginApp01;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    public void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Login();
    }
}