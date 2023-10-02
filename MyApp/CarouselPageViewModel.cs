using System.Collections.Generic;

namespace MyApp
{

    public class MyItemsViewModel
    {
        public string Label { get; set; } = "hello";
        public MyItemsViewModel()
        {
        }
    }
    public partial class CarouselPageViewModel : BaseViewModel
    {
        public List<MyItemsViewModel> MyItems { get; set; } = new List<MyItemsViewModel> {
            new MyItemsViewModel(),
            new MyItemsViewModel(),
            new MyItemsViewModel(),
        };

        public int MyPosition { get; set; } = 0;

        public CarouselPageViewModel()
        {

        }
    }
}
