using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{
    public sealed partial class settingPage : Page
    {
        public settingPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void resetPasBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ApplicationData.Current.LocalSettings.Values["MyPassSetting"] = resetPasswordTextBox.Text;
            resetFlyout.Hide();
            resetPasswordTextBox.Text = "";

        }

        private void resetPasswordTextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {

            //if ((char)e.Key < (char)0 || (char)e.Key > (char)9)
            //{
            //    e.Handled = true;
            //}
            //else
            //{
            //    i++;
            //    if (i > 8)
            //    {
            //        e.Handled = true;//不处理 

            //    }
            //}
        }


        private async void resetDataBtn_Click(object sender, RoutedEventArgs e)
        {

            ApplicationData.Current.LocalSettings.Values["ImageNumber"] = 0;

            StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Save");

            try
            {

                StorageFolder images = await storageFolder.GetFolderAsync("Image");
                await images.DeleteAsync(StorageDeleteOption.PermanentDelete);


            }
            catch
            {

            }

            try
            {
                StorageFolder audio = await storageFolder.GetFolderAsync("Audio");
                await audio.DeleteAsync(StorageDeleteOption.PermanentDelete);

            }

            catch
            {

            }

            try
            {
                StorageFolder json = await storageFolder.GetFolderAsync("Json");
                await json.DeleteAsync(StorageDeleteOption.PermanentDelete);
            }
            catch
            {

            }
            resetDataFlyout.Hide();
        }

        private void cancelResetBtn_Click(object sender, RoutedEventArgs e)
        {
            resetDataFlyout.Hide();
        }
    }
}
