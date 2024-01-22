namespace Biscoito
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ComerBtn_Clicked(object sender, EventArgs e)
        {
            BiscoitoImg.Source = "after_cookie.jpg";
            ((Button)sender).IsEnabled = false;
        }
    }

}
