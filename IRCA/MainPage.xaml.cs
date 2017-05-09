using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{
    public sealed partial class MainPage : Page
    {

        private ObservableCollection<string> TextList = new ObservableCollection<string>();

        public MainPage()
        {
            this.InitializeComponent();           

            if (ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] != null && (bool)ApplicationData.Current.LocalSettings.Values["ChineseLanguage"] == true)
            {
                TextList.Clear();
                TextList.Add("儿童");
                TextList.Add("家长");
                TextList.Add("分享");
                TextList.Add("设置");
                TextList.Add("请输入密码：");
                TextList.Add("确认");
                TextList.Add("取消");
                TextList.Add("家长配置页");
            }
            else
            {
                TextList.Clear();
                TextList.Add("Child");
                TextList.Add("Parent");
                TextList.Add("Share");
                TextList.Add("Setting");
                TextList.Add("Please enter the password: ");
                TextList.Add("Enter");
                TextList.Add("Cancel");
                TextList.Add("Parent Configuration");
            }

            headerTitle.Text = TextList[0];
            ChildListBoxTextBlock.Text = TextList[0];
            ParentListBoxTextBlock.Text = TextList[1];
            ShareListBoxTextBlock.Text = TextList[2];
            SettingListBoxTextBlock.Text = TextList[3];

        }

        //private async void fullScreenMoblie()
        //{
        //    //if (ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0))
        //    //{
        //    //    var statusBar = StatusBar.GetForCurrentView();
        //    //    await statusBar.HideAsync();
        //    //}
        //}

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            myFrame.Navigate(typeof(childPage));
            //fullScreenMoblie();
            
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChildListBoxItem.IsSelected)
            {
                headerTitle.Text = TextList[0];
                myFrame.Navigate(typeof(childPage));
            }
            else if (ParentListBoxItem.IsSelected)
            {
                PasswdDialogAsync(TextList[4], Windows.Storage.ApplicationData.Current.LocalSettings.Values["MyPassSetting"]?.ToString());
            }
            else if (ShareListBoxItem.IsSelected)
            {
                headerTitle.Text = TextList[2];
                myFrame.Navigate(typeof(sharePage));
            }
            else if (SettingListBoxItem.IsSelected)
            {
                headerTitle.Text = TextList[3];
                myFrame.Navigate(typeof(settingPage));
            }
        }

        private async void PasswdDialogAsync(string title, string passWord)
        {
            TextBox inputTextBox = new TextBox()
            {
                AcceptsReturn = false,
                Height = 32
            };

            ContentDialog dialog = new ContentDialog()
            {
                Content = inputTextBox,
                Title = title,
                IsSecondaryButtonEnabled = true,
                PrimaryButtonText = TextList[5],
                SecondaryButtonText = TextList[6]
            };

            if (await dialog.ShowAsync() == ContentDialogResult.Primary && inputTextBox.Text == passWord)
            {
                headerTitle.Text = TextList[7];
                myFrame.Navigate(typeof(parentPage));
            }
            else
            {
                ChildListBoxItem.IsSelected = true;
                headerTitle.Text = TextList[0];
            }
        }
    }
}
