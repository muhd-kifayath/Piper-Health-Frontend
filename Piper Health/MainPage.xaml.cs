namespace Piper_Health
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                HomeNavigation.Text = $"Clicked {count} time";
            else
                HomeNavigation.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(HomeNavigation.Text);
        }
    }

}
