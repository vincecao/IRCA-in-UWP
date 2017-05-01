using System;
using System.Collections.Generic;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{

    public sealed partial class childPage : Page
    {

        private List<MyImage> data;
        public childPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            doShowImage();            
        }

        //read image file
        private async System.Threading.Tasks.Task getImageListAsync()
        {
            App.imageArr.Clear();
            try
            {
                StorageFolder storagefolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");
                storagefolder = await storagefolder.GetFolderAsync("Image");
                var files = await storagefolder.GetFilesAsync();
                //for (int i = 0; i < files.Count; i++)
                for (int i = 0; i < (int)ApplicationData.Current.LocalSettings.Values["ImageNumber"]; i++)
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
