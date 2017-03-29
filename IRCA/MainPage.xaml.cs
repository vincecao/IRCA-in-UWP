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

                InputTextDialogAsync("Please enter the password: ");

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

        private async void InputTextDialogAsync(string title)
        {
            TextBox inputTextBox = new TextBox();
            inputTextBox.AcceptsReturn = false;
            inputTextBox.Height = 32;
            ContentDialog dialog = new ContentDialog();
            dialog.Content = inputTextBox;
            dialog.Title = title;
            dialog.IsSecondaryButtonEnabled = true;
            dialog.PrimaryButtonText = "Enter";
            dialog.SecondaryButtonText = "Cancel";

            App.passWord = Windows.Storage.ApplicationData.Current.LocalSettings.Values["MyPassSetting"]?.ToString();

            if (await dialog.ShowAsync() == ContentDialogResult.Primary && inputTextBox.Text == App.passWord)
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
