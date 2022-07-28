using Xamarin.Forms;

[assembly: ExportFont("fa-solid-900.ttf", Alias = "FAS")]
[assembly: ExportFont("fa-regular-400.ttf", Alias = "FAR")]
[assembly: ExportFont("fa-brands-400.ttf", Alias = "FAB")]

namespace Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            this.MainPage = new NavigationPage(new MainPage());
        }
    }
}
