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
            read = await LoadFromJsonAsync();

            FullScreenImage.Source = new BitmapImage(new Uri(App.imageSource));

        }

        private void stepTextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
            
        }

        public async Task<readItems> LoadFromJsonAsync()
        {
            string JsonString = await DeserializeFileAsync(JsonFile);
            if (JsonString != null)
                return JsonConvert.DeserializeObject<readItems>(JsonString);
            return null;
        }

        //read json
        private static async Task<string> DeserializeFileAsync(string fileName)
        {
            try
            {
                StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
                storageFolder = await storageFolder.GetFolderAsync("Json");
                StorageFile localFile = await storageFolder.GetFileAsync(fileName);
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
                PointerPoint pt = e.GetCurrentPoint(CanvasGird);
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
            string name = read.objectData[(int)x / App._accu, (int)y / App._accu];

            if (name == "null")
            {
                coordinateLabel.Text = (int)x / App._accu + "," + (int)y / App._accu;
                nameTextBlock.Text = "";
            }
            else
            {
                coordinateLabel.Text = (int)x / App._accu + "," + (int)y / App._accu + " " + name;
                nameTextBlock.Text = name;
                await Play(name);
            }

            
        }

        //read m4a audio
        private async Task Play(string audioFilename)
        {
            MediaElement playback = new MediaElement();
            StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
            storageFolder = await storageFolder.GetFolderAsync("Audio");
            StorageFile file = await storageFolder.GetFileAsync(audioFilename + ".m4a");

            var stream = await file.OpenAsync(FileAccessMode.Read);
            playback.SetSource(stream, file.ContentType);
            playback.Play();
        }

    }
}
