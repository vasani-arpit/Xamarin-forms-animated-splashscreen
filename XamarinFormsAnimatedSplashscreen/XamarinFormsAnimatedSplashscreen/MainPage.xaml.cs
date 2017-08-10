using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsAnimatedSplashscreen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new { HTML = "<html><body><img src='file:///android_asset/cat.gif'/></body></html>" };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(5000);
            await Navigation.PushAsync(new Page1());
        }
    }
}
