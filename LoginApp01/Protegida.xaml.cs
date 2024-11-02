namespace LoginApp01;

public partial class Protegida : ContentPage
{
    public Protegida()
    {
        InitializeComponent();
    }

    public void Button_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new Login();
    }
}