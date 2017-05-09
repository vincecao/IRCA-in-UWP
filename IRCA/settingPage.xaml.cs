using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{
    public sealed partial class settingPage : Page
    {
        private ObservableCollection<string> TextList = new ObservableCollection<string>();

        public settingPage()
        {
            this.InitializeComponent();          

            if (ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] != null && (bool)ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] == true)
            {
                ChineseToggle.IsOn = true;
                TextList.Clear();
                TextList.Add("重置密码");
                TextList.Add("清除本地缓存");
                TextList.Add("清除本地数据");
                TextList.Add("确定要清除所有本地缓存");
                TextList.Add("确定要清除所有本地数据");
                TextList.Add("重置");

            }
            else
            {
                ChineseToggle.IsOn = false;
                TextList.Clear();
                TextList.Add("Reset the password");
                TextList.Add("Clear the cache");
                TextList.Add("Clear the data");
                TextList.Add("Are you sure to clear all cache in the child-mode? ");
                TextList.Add("Are you sure to clear all data in the child-mode? ");
                TextList.Add("Reset");
            }

            ResPassTextBlock.Text = TextList[0];
            ClearCacheTextBlock.Text = TextList[1];
            ClearDataTextBlock.Text = TextList[2];
            Warning1TextBlock.Text = TextList[3];
            Warning2TextBlock.Text = TextList[4];
            ResetTextBlock.Text = TextList[5];
            ResetTextBlock2.Text = TextList[5];
            ResetTextBlock3.Text = TextList[5];

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

            try
            {
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
            }
            catch { }


            
            resetDataFlyout.Hide();
        }

        private void cancelResetBtn_Click(object sender, RoutedEventArgs e)
        {
            resetDataFlyout.Hide();
        }

        private void cancelResetCacheBtn_Click(object sender, RoutedEventArgs e)
        {
            resetCacheDataFlyout.Hide();
        }

        private async void resetCacheDataBtn_Click(object sender, RoutedEventArgs e)
        {
         
            try
            {
                StorageFolder storageFolder = await ApplicationData.Current.LocalFolder.GetFolderAsync("Cache");
                await storageFolder.DeleteAsync(StorageDeleteOption.PermanentDelete);
            }
            catch
            {

            }
            
            resetCacheDataFlyout.Hide();
        }

        private void ChineseToggle_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] = true;
                }
                else
                {
                    ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] = false;
                }
            }
        }
    }
}
