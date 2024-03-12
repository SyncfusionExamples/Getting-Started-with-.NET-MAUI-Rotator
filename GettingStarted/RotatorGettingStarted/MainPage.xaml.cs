using Syncfusion.Maui.Rotator;

namespace RotatorGettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<SfRotatorItem> collectionOfItems =
            [
                new SfRotatorItem() { Image = "image1.png" },
                new SfRotatorItem() { Image = "image2.png" },
                new SfRotatorItem() { Image = "image3.png" },
                new SfRotatorItem() { Image = "image4.png" },
                new SfRotatorItem() { Image = "image5.png" },
                new SfRotatorItem() { Image = "image6.png" },
            ];
            rotator.ItemsSource = collectionOfItems;
        }
    }
}
