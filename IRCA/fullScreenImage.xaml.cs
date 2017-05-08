using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Input;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Shapes;

namespace IRCA
{
    public class readItems
    {
        public int _id { get; set; }
        public string[] objectArr { get; set; }
        public string[,] objectData { get; set; }
    }

    public sealed partial class fullScreenImage : Page
    {
        private static string JsonFile;
        public readItems read;

        public fullScreenImage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            JsonFile = "myconfig_" + App._id + ".json";
            StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
            read = await LoadFromJsonAsync(JsonFile, storageFolder);

            FullScreenImage.Source = new BitmapImage(new Uri(App.imageSource));
            StatusGrid.Visibility = Visibility.Visible;
            ShowBtn.Visibility = Visibility.Collapsed;

#pragma warning disable CS0618 // Type or member is obsolete
            scrollViewer.ZoomToFactor(1);
#pragma warning restore CS0618 // Type or member is obsolete


        }

        private void back_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
            
        }

        //load json
        public async Task<readItems> LoadFromJsonAsync(string JsonFile, StorageFolder storageFolder)
        {
            string JsonString = await DeserializeFileAsync(JsonFile, storageFolder);
            if (JsonString != null)
                return JsonConvert.DeserializeObject<readItems>(JsonString);
            return null;
        }

        //read json
        private static async Task<string> DeserializeFileAsync(string JsonFile, StorageFolder storageFolder)
        {
            try
            {
                storageFolder = await storageFolder.GetFolderAsync("Json");
                StorageFile localFile = await storageFolder.GetFileAsync(JsonFile);
                return await FileIO.ReadTextAsync(localFile);
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }

        private async void CanvasGird_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            try
            {
                PointerPoint pt = e.GetCurrentPoint((Image)sender);
                var x = (int)pt.Position.X;
                var y = (int)pt.Position.Y;
                
                await matchReadedJsonAsync(x, y);
            }
            catch
            {

            }
        }

        private async Task matchReadedJsonAsync(int x, int y)
        {
            var _actualWidth = (int)FullScreenImage.ActualWidth;
            var _actualHeight = (int)FullScreenImage.ActualHeight;

            string name = read.objectData[(int)((x / App._accu) / _actualWidth), (int)((y / App._accu) / _actualHeight)];
            //string name = read.objectData[(int)(x / _actualWidth * App._accu), (int)(y / _actualHeight * App._accu)];


            if (name == "null")
            {
                coordinateLabel.Text = (int)((x / App._accu) / _actualWidth) + "," + (int)((y / App._accu) / _actualHeight);
                //coordinateLabel.Text = (int)(x / _actualWidth * App._accu) + "," + (int)(y / _actualHeight * App._accu);

                nameTextBlock.Text = "";
            }
            else
            {
                coordinateLabel.Text = (int)((x / App._accu) / _actualWidth) + "," + (int)((y / App._accu) / _actualHeight) + " " + name;
                nameTextBlock.Text = name;

                StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
                storageFolder = await storageFolder.GetFolderAsync("Audio");
                await Play(name, storageFolder);
            }           
        }

        //read m4a audio
        private async Task Play(string audioFilename, StorageFolder storageFolder)
        {
            MediaElement playback = new MediaElement();
            
            StorageFile file = await storageFolder.GetFileAsync(audioFilename + ".m4a");

            var stream = await file.OpenAsync(FileAccessMode.Read);
            playback.SetSource(stream, file.ContentType);
            playback.Play();
        }

        private void HideBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StatusGrid.Visibility = Visibility.Collapsed;
            ShowBtn.Visibility = Visibility.Visible;
        }

        private void ShowBtn_Tapped(object sender, TappedRoutedEventArgs e)
        {
            StatusGrid.Visibility = Visibility.Visible;
            ShowBtn.Visibility = Visibility.Collapsed;
        }
    }
}
