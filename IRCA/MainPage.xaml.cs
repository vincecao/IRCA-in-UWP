using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace IRCA
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();                       
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
                headerTitle.Text = "Child";
                myFrame.Navigate(typeof(childPage));
            }
            else if (ParentListBoxItem.IsSelected)
            {
                passwdDialogAsync("Please enter the password: ", Windows.Storage.ApplicationData.Current.LocalSettings.Values["MyPassSetting"]?.ToString());
            }
            else if (ShareListBoxItem.IsSelected)
            {
                headerTitle.Text = "Share";
                myFrame.Navigate(typeof(sharePage));
            }
            else if (SettingListBoxItem.IsSelected)
            {
                headerTitle.Text = "Setting";
                myFrame.Navigate(typeof(settingPage));
            }
        }

        private async void passwdDialogAsync(string title, string passWord)
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
                PrimaryButtonText = "Enter",
                SecondaryButtonText = "Cancel"
            };

            if (await dialog.ShowAsync() == ContentDialogResult.Primary && inputTextBox.Text == passWord)
            {
                headerTitle.Text = "Parent Configuration";
                myFrame.Navigate(typeof(parentPage));
            }
            else
            {
                ChildListBoxItem.IsSelected = true;
                headerTitle.Text = "Child";
            }
        }
    }
}
