using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myButton.Clicked += myButtonClicked;
        }

        private void myButtonClicked(object sender, EventArgs e)
        {
            OpenMyCarouselPage();
        }

        private async void OpenMyCarouselPage()
        {
            try
            {
                Page page = null;
                page = await Task.Run(() => new CarouselPage());
                await Navigation.PushAsync(page);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }
    }
}
