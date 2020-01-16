
using QuatesApp.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuatesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            BindingContext = new WelcomePageModel();
        }
    }
}