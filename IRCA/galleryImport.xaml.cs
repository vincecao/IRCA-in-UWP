using System;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{

    public sealed partial class galleryImport : Page
    {
        public galleryImport()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            doPickImage();
        }

            private async void doPickImage()
        {
            var openPicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };
            openPicker.FileTypeFilter.Add(".jpg");
            var file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                await ProcessFile(file);
            }
            else
            {
                
            }
        }

        private async Task ProcessFile(StorageFile file)
        {
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                //using writeableBitmap
                BitmapDecoder decoder = await BitmapDecoder.CreateAsync(stream);
                App.image = new WriteableBitmap((int)decoder.PixelWidth, (int)decoder.PixelHeight);
                //using bitmap
                //var image = new BitmapImage();
                App.image.SetSource(stream);
                imageView.Source = App.image;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
