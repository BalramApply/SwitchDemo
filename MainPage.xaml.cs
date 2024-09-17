namespace SwitchDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ToggleBorder(object sender, ToggledEventArgs args)
        {
            Switch xyz = sender as Switch;

            imgBot.Background = xyz.IsToggled ? Colors.SkyBlue : Colors.Transparent;
        }
    }

}
