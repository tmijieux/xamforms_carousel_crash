using Xamarin.Forms;

namespace MyApp
{
    public partial class CarouselPage : ContentPage
    {
        public CarouselPage()
        {
            BindingContext = new CarouselPageViewModel();
            InitializeComponent();
        }
    }
}
