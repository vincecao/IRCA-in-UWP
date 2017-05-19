using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace IRCA
{

    public sealed partial class childPage : Page
    {
        private static string _ImageNumberFromJson ; 
        private List<MyImage> data;
        public childPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            SetImageNumberAsync();

            doShowImage();            
        }

        private async void SetImageNumberAsync()
        {
            int returnValue = 0;

            if (ApplicationData.Current.LocalSettings.Values["ImageNumber"] == null)
            {
                returnValue = 0;
            }
            else
            {
                returnValue = (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"];
            }
            

            try
            {
                string JsonFile = "imagenumberconfig.json";
                StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");

                StorageFile file = await storageFolder.GetFileAsync(JsonFile);
                var JsonString = await FileIO.ReadTextAsync(file);
                if (JsonString != null)
                    returnValue = JsonConvert.DeserializeObject<int>(JsonString);

            }
            catch
            {

            }

            ApplicationData.Current.LocalSettings.Values["ImageNumber"] = (int)returnValue;
        }

        //read image file
        private async System.Threading.Tasks.Task getImageListAsync()
        {
            App.imageArr.Clear();
            var imageNumber = (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"];
            try
            {
                StorageFolder storagefolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
                storagefolder = await storagefolder.GetFolderAsync("Image");
                var files = await storagefolder.GetFilesAsync();
                //for (int i = 0; i < files.Count; i++)
                for (int i = 0; i < imageNumber; i++)
                {
                    App.imageArr.Add(i+"_Picture");
                }               
            }
            catch
            {
            }
        }

        private async void doShowImage()
        {
            data = new List<MyImage>();
            await getImageListAsync();

            //data.Add(new MyImage()
            //{
            //    ImageUrl = "ms-appx:///Assets/sample/1.jpg"
            //});

            for (int i = 0; i < App.imageArr.Count; i++)
            //for (int i = 0; i < (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"]; i++)
            {
                try
                {
                    data.Add(new MyImage()
                    {
                        ImageUrl = "ms-appdata:///local/Save/Image/" + App.imageArr[i] + ".jpg",
                    });

                }
                catch
                {

                }
            }

            myAdaptiveGridView.ItemsSource = data;

        }

        class MyImage
        {
            public string ImageUrl { get; set; }

        }

        private void myAdaptiveGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            App._id = data.IndexOf(e.ClickedItem as MyImage);
            
            App.imageSource = (e.ClickedItem as MyImage).ImageUrl;

            this.Frame.Navigate(typeof(fullScreenImage));
        }
    }
}
