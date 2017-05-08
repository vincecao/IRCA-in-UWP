using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace IRCA
{
    public sealed partial class sharePage : Page
    {
        public sharePage()
        {
            this.InitializeComponent();
            
            StorageFolder folder = ApplicationData.Current.LocalFolder;

            FolderPath.Text = folder.Path;
            
        }

        private void FolderPath_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            FolderPath.SelectAll();
        }

        private void Button_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(FolderPath.Text);
            //dataPackage.RequestedOperation = DataPackageOperation.Copy;
            Clipboard.SetContent(dataPackage);
        }

        private void FolderPath_GotFocus(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            FolderPath.SelectAll();
        }
    }
}
